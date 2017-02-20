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
using Microsoft.Win32;

namespace GenesisDexEngine
{
    class Options
    {
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
        public string name { get; set; }
        public int die { get; set; }
        public int bonus { get; set; }
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
        public List<int> relation { get; set; }
    }

    class PokeRegion
    {
        public string RegionName { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }
        public List<Spawn> Spawns { get; set; }
    }

    class Spawn
    {
        public string Name { get; set; }
        public int SpawnRate { get; set; }
    }

    class StatusAfflictions
    {
        public bool Burned { get; set; }
        public bool Frozen { get; set; }
        public bool BadSleep { get; set; }
        public bool Poisoned { get; set; }
        public bool Cursed { get; set; }
        public bool Rage { get; set; }
        public bool Infatuation { get; set; }
        public bool Asleep { get; set; }
        public bool Blind { get; set; }
        public bool TotalBlind { get; set; }
        public bool Slowed { get; set; }
        public bool Suppress { get; set; }
        public bool Flinch { get; set; }
        public bool Confused { get; set; }
        public bool Paralysis { get; set; }
        public bool Trapped { get; set; }
        public bool Tripped { get; set; }
        public bool Stuck { get; set; }
        public bool Fainted { get; set; }
        public bool Vulnerable { get; set; }
    }

    class Types
    {
        public string name { get; set; }
        public double normal { get; set; }
        public double fire { get; set; }
        public double water { get; set; }
        public double electric { get; set; }
        public double grass { get; set; }
        public double ice { get; set; }
        public double fighting { get; set; }
        public double poison { get; set; }
        public double ground { get; set; }
        public double flying { get; set; }
        public double psychic { get; set; }
        public double bug { get; set; }
        public double rock { get; set; }
        public double ghost { get; set; }
        public double dragon { get; set; }
        public double dark { get; set; }
        public double steel { get; set; }
        public double fairy { get; set; }
    }

    class PokeInfo
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    class MoveJSON
    {
        public string moveType { get; set; }
        public string moveFreq { get; set; }
        public string moveAC { get; set; }
        public string moveDB { get; set; }
        public string moveClass { get; set; }
        public string moveRange { get; set; }
        public string moveEffect { get; set; }
        public string moveConType { get; set; }
        public string moveConEffect { get; set; }

        public MoveJSON(string movetype, string movefreq, string moveac, string movedb, string moveclass, string moverange, string moveeffect, string contype, string coneffect)
        {
            moveType = movetype;
            moveFreq = movefreq;
            moveAC = moveac;
            moveDB = movedb;
            moveClass = moveclass;
            moveRange = moverange;
            moveEffect = moveeffect;
            moveConType = contype;
            moveConEffect = coneffect;
        }
    }

    class AbilityJSON
    {
        public string abiFreq { get; set; }
        public string abiTarget { get; set; }
        public string abiTrigger { get; set; }
        public string abiEffect { get; set; }

        public AbilityJSON(string abifrq, string abitarget, string abitrigger, string abieffect)
        {
            abiFreq = abifrq;
            abiTarget = abitarget;
            abiTrigger = abitrigger;
            abiEffect = abieffect;
        }
    }

    class StatusList
    {
        public StatusAfflictions createStatus()
        {
            StatusAfflictions idList = new StatusAfflictions();
            idList.Burned = false;
            idList.Frozen = false;
            idList.BadSleep = false;
            idList.Poisoned = false;
            idList.Cursed = false;
            idList.Rage = false;
            idList.Infatuation = false;
            idList.Asleep = false;
            idList.Blind = false;
            idList.TotalBlind = false;
            idList.Slowed = false;
            idList.Suppress = false;
            idList.Flinch = false;
            idList.Confused = false;
            idList.Paralysis = false;
            idList.Trapped = false;
            idList.Tripped = false;
            idList.Stuck = false;
            idList.Fainted = false;
            idList.Vulnerable = false;
            return idList;
        }
    }

    class InfoList
    {
        public List<PokeInfo> createList(string One, string Two)
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Info.xml");
            List<PokeInfo> idList = new List<PokeInfo>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants(One).Descendants(Two)
                        select new PokeInfo
                        {
                            name = (string)node.Attribute("name").Value,
                            description = (string)node.Element("Description").Value
                        };
            idList = query.ToList();
            return idList;
        }
    }

    class TypeList
    {
        public List<Types> createList()
        {
            XDocument doc = null;
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Types.xml");
            List<Types> idList = new List<Types>();
            doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Types").Descendants("id")
                        select new Types
                        {
                            name = (string)node.Attribute("type"),
                            normal = (double)node.Element("normal"),
                            fire = (double)node.Element("fire"),
                            water = (double)node.Element("water"),
                            electric = (double)node.Element("electric"),
                            grass = (double)node.Element("grass"),
                            ice = (double)node.Element("ice"),
                            fighting = (double)node.Element("fighting"),
                            poison = (double)node.Element("poison"),
                            ground = (double)node.Element("ground"),
                            flying = (double)node.Element("flying"),
                            psychic = (double)node.Element("psychic"),
                            bug = (double)node.Element("bug"),
                            rock = (double)node.Element("rock"),
                            ghost = (double)node.Element("ghost"),
                            dragon = (double)node.Element("dragon"),
                            dark = (double)node.Element("dark"),
                            steel = (double)node.Element("steel"),
                            fairy = (double)node.Element("fairy")
                        };
            idList = query.ToList();
            return idList;
        }
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
                            PokedexSkin = (string)node.Element("PokedexSkin")
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
            var query = from node in doc.Descendants("Item")
                        where (string)node.Attribute("Tier") == tier
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
                            name = (string)node.Element("name").Value,
                            die = (int)node.Element("die"),
                            bonus = (int)node.Element("bonus")
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

    //
    class RegionsList
    {
        public List<PokeRegion> createList()
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Regions.xml");
            List<PokeRegion> idList = new List<PokeRegion>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Region")
                        select new PokeRegion
                        {
                            RegionName = (string)node.Attribute("Name"),
                            MaxLevel = (int)node.Element("MaxLevel"),
                            MinLevel = (int)node.Element("MinLevel"),
                        };
            idList = query.ToList();
            return idList;
        }
    }

    //
    class SpawnList
    {
        public List<PokeRegion> createList()
        {
            string fileName = (AppDomain.CurrentDomain.BaseDirectory + "DATA\\XML\\Regions.xml");
            List<PokeRegion> idList = new List<PokeRegion>();
            XDocument doc = XDocument.Load(fileName);
            var query = from node in doc.Descendants("Region").Descendants("Spawns")
                        select new PokeRegion
                        {
                            Spawns = (from val in node.Elements("id")
                                      select new Spawn { Name = (string)val.Value, SpawnRate = (int)val.Attribute("spawnrate") }).ToList()
                        };
            idList = query.ToList();
            return idList;
        }
    }

    //
    class DPISense
    {
        public int? CheckDPI()
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop\WindowMetrics");
            int? dpix = regKey.GetValue("AppliedDPI") as int?;
            return dpix;
        }
    }
}
