using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XDocument doc = XDocument.Load("input.xml");
            foreach (var val in doc.Descendants("value"))
            {
                try
                {
                    ValueItem v = new ValueItem(Int32.Parse(val.Attribute("a").Value), Int32.Parse(val.Attribute("b").Value));
                    listBox1.Items.Add(v);
                } catch
                {
                    MessageBox.Show($"error loading item {val}");
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iterations = Int32.Parse(textBox1.Text);
                ValueItem v = listBox1.SelectedItem as ValueItem;
                Action op;
                switch ((Operations)comboBox1.SelectedIndex)
                {
                    case Operations.Multiply:
                        op = v.Multiply;
                        break;
                    case Operations.Divide:
                        op = v.Divide;
                        break;
                    case Operations.Power:
                        op = v.Power;
                        break;
                    case Operations.Substract:
                        op = v.Substract;
                        break;
                    default:
                        MessageBox.Show("Select operation");
                        return;
                }
                op();
                listBox1.Items[listBox1.SelectedIndex] = v;
            }
            catch
            {

            }
        }
    }
}
