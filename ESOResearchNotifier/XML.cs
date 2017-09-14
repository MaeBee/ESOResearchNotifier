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

        public static List<string> ReadCharacters(string FileName)
        {
            XmlDocument XMLDoc = new XmlDocument();
            XMLDoc.Load(FileName);
            List<string> returnList = new List<string>();
            if (XMLDoc.SelectSingleNode("//selectedcharacters") != null)
            {
                foreach (XmlNode node in XMLDoc.SelectSingleNode("//selectedcharacters").ChildNodes)
                {
                    returnList.Add(node.Attributes["name"].Value);
                }
            }
            return returnList;
        }

        public static void WriteData(string FileName, Dictionary<string, string> Config, List<string> Characters)
        {
            XDocument XDoc = new XDocument();

            XElement XRoot = new XElement("config");

            XElement XRootVars = new XElement("vars");
            foreach(KeyValuePair<string, string> Line in Config)
            {
                XRootVars.Add(new XElement("var", new XAttribute("name", Line.Key), new XAttribute("value", Line.Value)));
            }
            XRoot.Add(XRootVars);

            XElement XRootChars = new XElement("selectedcharacters");
            foreach (string Character in Characters)
            {
                XRootChars.Add(new XElement("character", new XAttribute("name", Character)));
            }
            XRoot.Add(XRootChars);

            XDoc.Add(XRoot);

            XDoc.Save(FileName);
        }
    }
}
