using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prog2
{
    class DataFile
    {
        public string FilePath { get; private set; }
        public BindingList<ValueItem> ValueItems { get; private set; } = new BindingList<ValueItem>();

        //consistency & conventions - lower case for private instance fields
        private XDocument doc;
        private Logger Logger;

        public DataFile(string path, Logger logger)
        {
            //for instance members, use 'this.' notation - it helps identify the statics
            Logger = logger;
            FilePath = path;

            try
            {
                Logger.LogEvent($"Loading data from {Path.GetFileName(FilePath)}");
                doc = XDocument.Load(FilePath);
                foreach (var val in doc.Descendants("value"))
                {
                    try
                    {
                        ValueItem v = new ValueItem(int.Parse(val.Attribute("a").Value), int.Parse(val.Attribute("b").Value));
                        ValueItems.Add(v);
                    }
                    catch
                    {
                        //in general, it is good to log *what* went wrong, not just 'where' (i.e. include exception details)
                        Logger.LogError($"Error loading item {val}");
                    }
                }
            }
            catch
            {
                Logger.LogError($"Can't load data from {Path.GetFileName(FilePath)}");
            }
            finally
            {
                Logger.LogEvent($"{ValueItems.Count()} items read");
            }
        }

        public void SaveToFile(string path = null)
        {
            try
            {
                string saveTo = path ?? FilePath;
                Logger.LogEvent($"Saving data to {Path.GetFileName(saveTo)}");
                doc.Root.RemoveNodes();
                foreach (ValueItem item in ValueItems)
                {
                    XElement valueElement = new XElement("value");
                    valueElement.SetAttributeValue("a", item.a);
                    valueElement.SetAttributeValue("b", item.b);
                    doc.Root.Add(valueElement);
                }
                doc.Save(saveTo);
                Logger.LogEvent($"{ValueItems.Count} items saved");
            }
            catch
            {
                Logger.LogError($"Can't save data to {Path.GetFileName(FilePath)}");
            }
        }
    }
}
