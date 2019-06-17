using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2
{
    public partial class Form1 : Form
    {
        DataFile DataFile;
        private bool _fileLoaded = false; //consistency - howcome you have _ prefix?
        public bool FileLoaded {
            get => _fileLoaded;
            set {
                _fileLoaded = value;
                dataFileBindingSource.ResetCurrentItem();
            }
        }

        //if you have fields which are only assigned once, make them readonly - this will make the intent more obvious and prevent from accidental breaking
        Logger Logger = new Logger();
        List<Operation> operations = new List<Operation>();
        BindingSource dataFileBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            IumericUpDownIterations.Maximum = decimal.MaxValue;

            //+1 point for making the friendly name of the calculation - however, this can be improved :)
            operations.Add(new Operation(OperationType.Divide, "Dzielenie"));
            operations.Add(new Operation(OperationType.Multiply, "Mnożenie"));
            operations.Add(new Operation(OperationType.Power, "Potęgowanie"));
            operations.Add(new Operation(OperationType.Substract, "Odejmowanie"));
            ComboBoxOperation.DataSource = operations;

            dataFileBindingSource.Add(this);
            PanelStartSaveButtons.DataBindings.Add("Enabled", dataFileBindingSource, "FileLoaded");
        }

        private void UpdateLog()
        {
            if (Logger == null)
            {
                return;
            }

            TextBoxLog.Lines = Logger.Log.Where(li =>
                (CheckBoxShowEvents.Checked && li.ErrorLevel == ErrorLevel.Info) ||
                (CheckBoxShowErrors.Checked && li.ErrorLevel == ErrorLevel.Error)
                ).Select(li => li.ToString()).ToArray();

            TextBoxLog.SelectionStart = TextBoxLog.TextLength;
            TextBoxLog.ScrollToCaret();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            decimal iterations = IumericUpDownIterations.Value;
            for (int i = 0; i < DataFile.ValueItems.Count; i++)
            {
                ValueItem vi = DataFile.ValueItems[i];
                decimal iteration = iterations;
                while (iteration-- > 0)
                {
                    Operation op = (ComboBoxOperation.SelectedItem as Operation);
                    try
                    {
                        switch (op.Type)
                        {
                            case OperationType.Multiply:
                                vi.Multiply();
                                break;
                            case OperationType.Divide:
                                vi.Divide();
                                break;
                            case OperationType.Power:
                                vi.Power();
                                break;
                            case OperationType.Substract:
                                vi.Substract();
                                break;
                            default:
                                MessageBox.Show("Select operation");
                                return;
                        }
                        Logger.LogEvent($"Item {i + 1}, operation '{op.Label}', iteration {iterations - iteration}, result: {vi}");
                    }
                    catch
                    {
                        Logger.LogError($"Item {i + 1}, operation '{op.Label}', iteration {iterations - iteration} failed");
                    }
                }
            }
            DataFile.ValueItems.ResetBindings();
            UpdateLog();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml", //magic string should be rather replaced with a private readonly field (especially that it's used more than once)
                //if you add new supported extension, you need to change in two places
                InitialDirectory = TextBoxInputFile.Text
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxInputFile.Text = ofd.FileName;
            }
        }

        private void ButtoOpen_Click(object sender, EventArgs e)
        {
            DataFile = new DataFile(TextBoxInputFile.Text, Logger);
            FileLoaded = DataFile != null;
            ListBoxContent.DataSource = DataFile.ValueItems;
            UpdateLog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "XML files (*.xml)|*.xml",
                InitialDirectory = Path.GetDirectoryName(DataFile.FilePath),
                FileName = Path.GetFileNameWithoutExtension(DataFile.FilePath),
                DefaultExt = "xml"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataFile.SaveToFile(sfd.FileName);
            }
            UpdateLog();
        }

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (!CheckBoxShowErrors.Checked && !CheckBoxShowEvents.Checked)
            {
                (sender as CheckBox).Checked = true;
                return;
            }
            UpdateLog();
        }

        private void ButtonSaveLog_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Text files (*.txt)|*.txt",
                    InitialDirectory = DataFile.FilePath,
                    DefaultExt = "txt"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, Logger.Log.Where(li =>
                        (CheckBoxShowEvents.Checked && li.ErrorLevel == ErrorLevel.Info) ||
                        (CheckBoxShowErrors.Checked && li.ErrorLevel == ErrorLevel.Error)
                        ).Select(li => li.ToString()).ToArray());
                }
            }
            catch
            {
                Logger.LogError("Error saving log file");
            }
        }
    }
}
