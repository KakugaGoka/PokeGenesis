using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenesisEngine
{
    class Identifier
    {
        public string id { get; set; }
    }

    class XMLtoList
    {
        public List<Identifier> createList(string xml)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "XML\\"+xml+".xml");
            List<Identifier> idList = new List<Identifier>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(xml)
                        select new Identifier
                        {
                            id = (string)node.Element("id")
                        };
            idList = query.ToList();
            return idList;
        }
    }
}
