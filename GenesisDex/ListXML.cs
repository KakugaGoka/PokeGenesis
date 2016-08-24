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

    class Evolution
    {
        public string evo { get; set; }
    }

    class Ability
    {
        public string ability { get; set; }
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

    class TM
    {
        public string tm { get; set; }
    }

    class Egg
    {
        public string egg { get; set; }
    }

    class Tutor
    {
        public string tut { get; set; }
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
                            gender = (string)node.Element("gender")
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

    class EvolutionList
    {
        public List<Evolution> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Evolution> idList = new List<Evolution>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Evolution")
                        select new Evolution
                        {
                            evo = (string)node.Element("evo")
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
            var query = from node in doc.Descendants("List" + decend).Descendants("Capability")
                        select new Capability
                        {
                            cap = (string)node.Element("cap")
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
            var query = from node in doc.Descendants("List" + decend).Descendants("Skills")
                        select new Skill
                        {
                            skill = (string)node.Element("skill")
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
            var query = from node in doc.Descendants("List" + decend).Descendants("Moves")
                        select new Move
                        {
                            move = (string)node.Element("move")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class AbilityList
    {
        public List<Ability> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Ability> idList = new List<Ability>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Ability")
                        select new Ability
                        {
                            ability = (string)node.Element("ability")
                        };
            idList = query.ToList();
            return idList;
        }
    }
}
