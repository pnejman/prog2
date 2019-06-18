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
        private readonly XDocument doc;
        private readonly Logger logger;

        public DataFile(string path, Logger logger)
        {
            //for instance members, use 'this.' notation - it helps identify the statics
            this.logger = logger;
            this.FilePath = path;

            try
            {
                logger.LogEvent($"Loading data from {Path.GetFileName(FilePath)}");
                doc = XDocument.Load(FilePath);
                foreach (var val in doc.Descendants("value"))
                {
                    try
                    {
                        ValueItem v = new ValueItem(int.Parse(val.Attribute("a").Value), int.Parse(val.Attribute("b").Value));
                        ValueItems.Add(v);
                    }
                    catch (FormatException)
                    {
                        //in general, it is good to log *what* went wrong, not just 'where' (i.e. include exception details)
                        logger.LogError($"Error loading item - non-number or empty value(s) in {val}");
                    }
                    catch (ArgumentNullException)
                    {
                        logger.LogError($"Error loading item - missing value(s) in {val}");
                    }
                    
                }
            }
            catch (System.Xml.XmlException ex)
            {
                logger.LogError($"Can't load data from {Path.GetFileName(FilePath)}, input file corrupted, line {ex.LineNumber}, column {ex.LinePosition}: {ex.Message}");
            }
            catch (ArgumentException)
            {
                logger.LogError($"Can't load data from {Path.GetFileName(FilePath)}, invalid path");
            }
            catch (Exception ex)
            {
                logger.LogError($"Can't load data from {Path.GetFileName(FilePath)}, unknown error ('{ex.Message}')");
            }
            finally
            {
                logger.LogEvent($"{ValueItems.Count()} items read");
            }
        }

        public void SaveToFile(string path = null)
        {
            try
            {
                string saveTo = path ?? FilePath;
                logger.LogEvent($"Saving data to {Path.GetFileName(saveTo)}");
                doc.Root.RemoveNodes();
                foreach (ValueItem item in ValueItems)
                {
                    XElement valueElement = new XElement("value");
                    valueElement.SetAttributeValue("a", item.A);
                    valueElement.SetAttributeValue("b", item.B);
                    doc.Root.Add(valueElement);
                }
                doc.Save(saveTo);
                logger.LogEvent($"{ValueItems.Count} items saved");
            }
            catch
            {
                logger.LogError($"Can't save data to {Path.GetFileName(FilePath)}");
            }
        }
    }
}
