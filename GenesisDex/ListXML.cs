using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenesisDexEngine
{
    class Pokemon
    {
        public string id { get; set; }
        public string number { get; set; }
        public string type { get; set; }
        public string hp { get; set; }
        public string atk { get; set; }
        public string def { get; set; }
        public string spdef { get; set; }
        public string spatk { get; set; }
        public string spd { get; set; }
        public string size { get; set; }
        public string weight { get; set; }
        public string gender { get; set; }
        public string egg { get; set; }
        public string hatch { get; set; }
        public string diet { get; set; }
        public string habitat { get; set; }
        public string legendary { get; set; }
    }

    class Mega
    {
        public string id { get; set; }
        public string type { get; set; }
        public string hp { get; set; }
        public string atk { get; set; }
        public string def { get; set; }
        public string spatk { get; set; }
        public string spdef { get; set; }
        public string spd { get; set; }
        public string ability { get; set; }
    }

    class Items
    {
        public string id { get; set; }
        public string desc { get; set; }
    }

    class Evolution
    {
        public string evo { get; set; }
        public int id { get; set; }
    }

    class Ability
    {
        public string basicability { get; set; }
        public string advability { get; set; }
        public string highability { get; set; }
    }

    class Capability
    {
        public string cap { get; set; }
    }

    class Skill
    {
        public string skill { get; set; }
    }

    class Move
    {
        public string move { get; set; }
    }

    class Nature
    {
        public string id { get; set; }
        public string up { get; set; }
        public string down { get; set; }
    }

    class TM
    {
        public string id { get; set; }
        public string number { get; set; }
        public string type { get; set; }
    }

class PokemonList
    {
        public List<Pokemon> createList(string decend)
        {
            XDocument doc = null;
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Pokemon> idList = new List<Pokemon>();
            doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend)
                        select new Pokemon
                        {
                            number = (string)node.Element("number"),
                            id = (string)node.Element("id"),
                            type = (string)node.Element("type"),
                            hp = (string)node.Element("hp"),
                            atk = (string)node.Element("atk"),
                            def = (string)node.Element("def"),
                            spatk = (string)node.Element("spatk"),
                            spdef = (string)node.Element("spdef"),
                            spd = (string)node.Element("spd"),
                            size = (string)node.Element("size"),
                            weight = (string)node.Element("weight"),
                            hatch = (string)node.Element("hatch"),
                            egg = (string)node.Element("egg"),
                            diet = (string)node.Element("diet"),
                            habitat = (string)node.Element("habitat"),
                            gender = (string)node.Element("gender"),
                            legendary = (string)node.Element("legendary")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class MegaList
    {
        public List<Mega> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Mega> idList = new List<Mega>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend)
                        select new Mega
                        {
                            id = (string)node.Element("id"),
                            type = (string)node.Element("type"),
                            hp = (string)node.Element("hp"),
                            atk = (string)node.Element("atk"),
                            def = (string)node.Element("def"),
                            spatk = (string)node.Element("spatk"),
                            spdef = (string)node.Element("spdef"),
                            spd = (string)node.Element("spd"),
                            ability = (string)node.Element("ability")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class NameList
    {
        public List<Items> createList(string xml, string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\" + xml + ".xml");
            List<Items> idList = new List<Items>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend)
                        select new Items
                        {
                            id = (string)node.Element("id")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class ItemList
    {
        public List<Items> createList(string xml, string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Items\\" + xml + ".xml");
            List<Items> idList = new List<Items>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend)
                        select new Items
                        {
                            id = (string)node.Element("id"),
                            desc = (string)node.Element("desc")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class TMList
    {
        public List<TM> createList(string xml, string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\" + xml + ".xml");
            List<TM> idList = new List<TM>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend)
                        select new TM
                        {
                            id = (string)node.Element("id"),
                            number = (string)node.Element("number"),
                            type = (string)node.Element("type")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class NatureList
    {
        public List<Nature> createList(string xml, string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\" + xml + ".xml");
            List<Nature> idList = new List<Nature>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend)
                        select new Nature
                        {
                            id = (string)node.Element("id"),
                            up = (string)node.Element("up"),
                            down = (string)node.Element("down")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class EvolutionList
    {
        public List<Evolution> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Evolution> idList = new List<Evolution>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Evolution").Descendants("evo")
                        select new Evolution
                        {
                            evo = (string)node.Value,
                            id = (int)node.Attribute("id")
                        };
            idList = query.ToList();
            return idList;
        }
    }
    class CapabilityList
    {
        public List<Capability> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Capability> idList = new List<Capability>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Capability").Descendants("cap")
                        select new Capability
                        {
                            cap = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }
    class SkillList
    {
        public List<Skill> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Skill> idList = new List<Skill>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Skills").Descendants("skill")
                        select new Skill
                        {
                            skill = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class MoveList
    {
        public List<Move> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Move> idList = new List<Move>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Moves").Descendants("move")
                        select new Move
                        {
                                 move = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class BasicAbiList
    {
        public List<Ability> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Ability> idList = new List<Ability>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Ability").Descendants("BasicAbility")
                        select new Ability
                        {
                            basicability = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class AdvAbiList
    {
        public List<Ability> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Ability> idList = new List<Ability>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Ability").Descendants("AdvancedAbility")
                        select new Ability
                        {
                            advability = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class HighAbiList
    {
        public List<Ability> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Ability> idList = new List<Ability>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Ability").Descendants("HighAbility")
                        select new Ability
                        {
                            highability = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class Stat
    {
        public int stat { get; set; }
        public string id { get; set; }
    }

    class StatList
    {
        public List<Stat> createList(int hp, int atk, int def, int spatk, int spdef, int spd)
        {
            Stat HP = new Stat { id = "hp", stat = hp };
            Stat ATK = new Stat { id = "atk", stat = atk };
            Stat DEF = new Stat { id = "def", stat = def };
            Stat SPATK = new Stat { id = "spatk", stat = spatk };
            Stat SPDEF = new Stat { id = "spdef", stat = spdef };
            Stat SPD = new Stat { id = "spd", stat = spd };
            List<Stat> statList = new List<Stat>();
            statList.Add(HP);
            statList.Add(ATK);
            statList.Add(DEF);
            statList.Add(SPATK);
            statList.Add(SPDEF);
            statList.Add(SPD);
            return statList;
        }
    }
}
