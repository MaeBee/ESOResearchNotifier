using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace ESOResearchNotifier
{
    class XML
    {
        public static Dictionary<string,string> ReadData(string FileName)
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(FileName);
            Dictionary<string, string> returnDict = new Dictionary<string, string>();
            foreach (XmlNode node in XMLDoc.SelectSingleNode("//vars").ChildNodes)
            {
                returnDict.Add(node.Attributes["name"].Value, node.Attributes["value"].Value);
            }
            return returnDict;
        }

        public static void WriteData(string FileName, Dictionary<string, string> Data)
        {
            XDocument XDoc = new XDocument();
            XElement XRoot = new XElement("vars");
            foreach(KeyValuePair<string, string> Line in Data)
            {
                XRoot.Add(new XElement("var", new XAttribute("name", Line.Key), new XAttribute("value", Line.Value)));
            }
            XDoc.Add(XRoot);

            XDoc.Save(FileName);
        }
    }
}
