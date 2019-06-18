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
        private readonly string dataFileDialogFilter = "XML files (*.xml)|*.xml";
        private readonly string dataFileDialogDefaultExt = "xml";
        private readonly string logFileDialogFilter = "Text files (*.txt)|*.txt";
        private readonly string logFileDialogDefaultExt = "txt";

        private DataFile dataFile;
        private bool fileLoaded = false; //consistency - howcome you have _ prefix?
        public bool FileLoaded {
            get => fileLoaded;
            set {
                fileLoaded = value;
                dataFileBindingSource.ResetCurrentItem();
            }
        }

        //if you have fields which are only assigned once, make them readonly - this will make the intent more obvious and prevent from accidental breaking
        private readonly Logger logger = new Logger();
        private readonly BindingSource dataFileBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            NumericUpDownIterations.Maximum = decimal.MaxValue;

            //+1 point for making the friendly name of the calculation - however, this can be improved :)

            List<KeyValuePair<OperationType, string>> operations = new List<KeyValuePair<OperationType, string>>();
            Array values = Enum.GetValues(typeof(OperationType));

            foreach (int val in values)
            {
                OperationType temp = (OperationType)val;
                operations.Add(new KeyValuePair<OperationType, string>(temp, temp.GetLabel()));
            }
            ComboBoxOperation.DataSource = operations;
            ComboBoxOperation.DisplayMember = "Value";

            dataFileBindingSource.Add(this);
            PanelStartSaveButtons.DataBindings.Add("Enabled", dataFileBindingSource, "FileLoaded");
        }

        private void UpdateLog()
        {
            if (logger == null)
            {
                return;
            }

            TextBoxLog.Lines = logger.Log.Where(li =>
                (CheckBoxShowEvents.Checked && li.ErrorLevel == ErrorLevel.Info) ||
                (CheckBoxShowErrors.Checked && li.ErrorLevel == ErrorLevel.Error)
                ).Select(li => li.ToString()).ToArray();

            TextBoxLog.SelectionStart = TextBoxLog.TextLength;
            TextBoxLog.ScrollToCaret();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            decimal iterations = NumericUpDownIterations.Value;
            for (int i = 0; i < dataFile.ValueItems.Count; i++)
            {
                ValueItem vi = dataFile.ValueItems[i];
                decimal iteration = iterations;
                while (iteration-- > 0)
                {
                    var op = (KeyValuePair<OperationType, string>)ComboBoxOperation.SelectedItem;
                    try
                    {
                        switch (op.Key)
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
                        logger.LogEvent($"Item {i + 1}, operation '{op.Value}', iteration {iterations - iteration}, result: {vi}");
                    }
                    catch
                    {
                        logger.LogError($"Item {i + 1}, operation '{op.Value}', iteration {iterations - iteration} failed");
                    }
                }
            }
            dataFile.ValueItems.ResetBindings();
            UpdateLog();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = dataFileDialogFilter, //magic string should be rather replaced with a private readonly field (especially that it's used more than once)
                //if you add new supported extension, you need to change in two places
                InitialDirectory = TextBoxInputFile.Text,
                DefaultExt = dataFileDialogDefaultExt
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxInputFile.Text = ofd.FileName;
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            dataFile = null;
            dataFile = new DataFile(TextBoxInputFile.Text, logger);
            FileLoaded = dataFile != null;
            ListBoxContent.DataSource = dataFile.ValueItems;
            UpdateLog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = dataFileDialogFilter,
                InitialDirectory = Path.GetDirectoryName(dataFile.FilePath),
                FileName = Path.GetFileNameWithoutExtension(dataFile.FilePath),
                DefaultExt = dataFileDialogDefaultExt
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataFile.SaveToFile(sfd.FileName);
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
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = logFileDialogFilter,
                InitialDirectory = dataFile.FilePath,
                DefaultExt = logFileDialogDefaultExt
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var logItems = logger.Log.Where(li =>
                            (CheckBoxShowEvents.Checked && li.ErrorLevel == ErrorLevel.Info) ||
                            (CheckBoxShowErrors.Checked && li.ErrorLevel == ErrorLevel.Error)
                            ).Select(li => li.ToString());

                logger.SaveLog(sfd.FileName, false, logItems);
            }
        }
    }
}
