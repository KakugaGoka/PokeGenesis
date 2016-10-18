using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace GenesisDexEngine
{
    class Options
    {
        public string OneItemGasp { get; set; }
        public string TwoItemGasp { get; set; }
        public string PokemonGasp { get; set; }
        public string ShinyGasp { get; set; }
        public string PokedexSkin { get; set; }
        public int CryVolume { get; set; }
        public int MaxPlayerLevel { get; set; }
        public int MaxPokemonLevel { get; set; }
        public int MaxScanAmount { get; set; }
        public int MaxItemTier { get; set; }
        public int CashPerLevel { get; set; }
    }

    class Pokemon
    {
        public string id { get; set; }
        public string entry { get; set; } 
        public string stage { get; set; }
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

    class Moves
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

    class Stat
    {
        public int stat { get; set; }
        public string id { get; set; }
    }

    class PokeRegion
    {
        public string RegionName { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }
        public List<string> Spawns { get; set; }
    }


    // Used to create a list to populate FormOptions and to apply those Options into the other Forms.
    class OptionsList
    {
        public List<Options> createList()
        {
            XDocument doc = null;
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\Options.xml");
            List<Options> idList = new List<Options>();
            doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Options")
                        select new Options
                        {
                            MaxPokemonLevel = (int)node.Element("MaxPokemonLevel"),
                            MaxPlayerLevel = (int)node.Element("MaxPlayerLevel"),
                            MaxScanAmount = (int)node.Element("MaxScanAmount"),
                            MaxItemTier = (int)node.Element("MaxItemTier"),
                            CashPerLevel = (int)node.Element("CashPerLevel"),
                            CryVolume = (int)node.Element("CryVolume"),
                            PokedexSkin = (string)node.Element("PokedexSkin"),
                            OneItemGasp = (string)node.Element("OneItemGasp"),
                            TwoItemGasp = (string)node.Element("TwoItemGasp"),
                            PokemonGasp = (string)node.Element("PokemonGasp"),
                            ShinyGasp = (string)node.Element("ShinyGasp")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    // Used to read the list of banned pokemon in the Options.XML and apply it to the forms.
    class BanList
    {
        public List<string> createList()
        {
            XDocument doc = null;
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\Options.xml");
            List<string> idList = new List<string>();
            doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Options").Descendants("BanList").Descendants("PokeBan")
                        select (string)node.Value;
            idList = query.ToList();
            return idList;
        }
    }

    // Used to create a list of Pokemon from the Pokemon.XML and populate the forms with them.
    class PokemonList
    {
        public List<Pokemon> createList()
        {
            XDocument doc = null;
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Pokemon> idList = new List<Pokemon>();
            doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Pokemon")
                        select new Pokemon
                        {
                            stage = (string)node.Attribute("Stage"),
                            number = (string)node.Element("number"),
                            id = (string)node.Element("id"),
                            entry = (string)node.Element("entry"),
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

    // Used for when a pokemon has a mega form. This ist is called to populate in that data where it is needed.
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

    // Used to grab lists like Habitat and Type since they have nothing but a single string in each item in the XML.
    class NameList
    {
        public List<Items> createList(string xml, string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\" + xml + ".xml");
            List<Items> idList = new List<Items>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(decend).Descendants("id")
                        select new Items
                        {
                            id = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    //Used to grab the Items and their descriptions from the Items.XML from loot generation and Pokemon gereation if Items are allowed.
    class ItemList
    {
        public List<Items> createList(string tier)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Items.xml");
            List<Items> idList = new List<Items>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Item") where (string)node.Attribute("Tier") == tier
                        select new Items
                        {
                            id = (string)node.Element("id"),
                            desc = (string)node.Element("desc")
                        };
            idList = query.ToList();
            return idList;
        }
    }

    // Used to generate TMs and HMs for when the pokemon is able to learn such things during generation. (Such as when they are shiny)
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

    // Used to pull in the Natures for Pokemon Generation form the Natures.XML
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

    // Used to create a list of the evolutions of a pokemon in order to populate info List in FormMain and FormScan. These are grabbed forom the Pokemon.XML
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

    // Used to create a list of Capabilities for the specified pokemon from the Pokemon.XML
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

    // Used to create a list of Skills for the specified pokemon from the Pokemon.XML
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

    // Used to create a list of Moves for the specified pokemon from the Pokemon.XML
    class MovesList
    {
        public List<Moves> createList(string decend)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Pokemon.xml");
            List<Moves> idList = new List<Moves>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("List" + decend).Descendants("Moves").Descendants("move")
                        select new Moves
                        {
                                 move = (string)node.Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    // Used to create a list of teh Basic Abilities for the specified pokemon from the Pokemon.XML
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

    // Used to create a list of Adv Abilities for the specified pokemon from the Pokemon.XML
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

    // Used to create a list of Hiigh Abilites for the specified pokemon from the Pokemon.XML
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

    // Used to create a list of the Stats for the specified pokemon from the Pokemon.XML
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

    // Used to create a list of Hiigh Abilites for the specified pokemon from the Pokemon.XML
    class RegionsList
    {
        public List<PokeRegion> createList()
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Regions.xml");
            List<PokeRegion> idList = new List<PokeRegion>();
            XDocument doc = XDocument.Load(fileName);
            List<string> child = new List<string>();
            foreach (XElement n in doc.Descendants("Region").Descendants("Spawns").Elements("id"))
            {
                child.Add((string)n.Value);
            }
            var query = from node in doc.Descendants("Region")
                        select new PokeRegion
                        {
                            Spawns = child,
                            RegionName = (string)node.Attribute("Name"),
                            MaxLevel = (int)node.Element("MaxLevel"),
                            MinLevel = (int)node.Element("MinLevel"),
                        };
            idList = query.ToList();
            return idList;
        }
    }
}
