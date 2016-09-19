using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenesisDexEngine;

namespace GenesisDex
{
    public partial class FormScan : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        PokemonList pokeXML = new PokemonList();
        MoveList moveXML = new MoveList();
        BasicAbiList basicXML = new BasicAbiList();
        AdvAbiList advXML = new AdvAbiList();
        HighAbiList highXML = new HighAbiList();
        SkillList skillXML = new SkillList();
        CapabilityList capXML = new CapabilityList();
        NameList typeXML = new NameList();
        NatureList natureXML = new NatureList();
        NameList habitatXML = new NameList();
        EvolutionList evoXML = new EvolutionList();
        List<Pokemon> pokeList = new List<Pokemon>();
        List<Pokemon> permaList = new List<Pokemon>();
        List<Move> moveList = new List<Move>();
        List<Ability> abiList = new List<Ability>();
        List<Skill> skillList = new List<Skill>();
        List<Capability> capList = new List<Capability>();
        List<Evolution> evoList = new List<Evolution>();
        Random rng = new Random();
        int pbPokeLocX { get; set; }
        int pbPokeLocY { get; set; }
        List<Items> habitatList = new List<Items>();
        List<Items> typeList = new List<Items>();
        List<Nature> natureList = new List<Nature>();
        List<string> habitats = new List<string>();
        List<string> types = new List<string>();
        int nature { get; set; }
        Pokemon IChooseYou = new Pokemon();
        int TrueLevel = new int();
        int Page = 1;
        List<Items> itemList = new List<Items>();
        ItemList itemXML = new ItemList();
        List<TM> TMList = new List<TM>();
        TMList TMXML = new TMList();
        bool getItem2 = false;
        List<string> pokeDex = new List<string>();
        List<string> moves = new List<string>();
        List<string> ability = new List<string>();
        List<string> skill = new List<string>();
        List<string> stages = new List<string>();
        List<List<string>> AllMoves = new List<List<string>>();
        List<List<string>> AllAbilities = new List<List<string>>();
        List<List<string>> AllSkills = new List<List<string>>();
        List<string> AllNatures = new List<string>();
        List<Image> AllImages = new List<Image>();
        List<Pokemon> AllPokemon = new List<Pokemon>();
        List<int> AllLevels = new List<int>();
        List<Image> AllItems1 = new List<Image>();
        List<Image> AllItems2 = new List<Image>();
        List<string> AllDesc1 = new List<string>();
        List<string> AllDesc2 = new List<string>();
        List<string[]> Info = new List<string[]>();
        List<string> Gender = new List<string>();
        List<string> Stat = new List<string>();
        List<List<string>> AllStat = new List<List<string>>();
        List<string> Type = new List<string>();
        int Current = 0;
        int Amount = 0;
        bool isShiny = false;
        string typeShiny { get; set; }
        string newShiny { get; set; }

        public FormScan()
        {
            InitializeComponent();
            pkGasp.Text = "";
            pbPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeft.gif");
            pbPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRight.gif");
            pbPokeLeft.Visible = false;
            pbPokeRight.Visible = false;
            pbGotoPage.Visible = false;
            pkGoto.Enabled = false;
            pbPokeLocX = pbPokemon.Location.X;
            pbPokeLocY = pbPokemon.Location.Y;
            pokeList = pokeXML.createList("Pokemon");
            SortPokemon(pokeList);
            typeList = typeXML.createList("Types", "Type");
            habitatList = habitatXML.createList("Habitats", "Habitat");
            natureList = natureXML.createList("Natures", "Nature");
            infoBack.Visible = false;
            infoForward.Visible = false;
            habitats.Clear();
            types.Clear();
            for (var h = 0; h < habitatList.Count; h++)
            {
                habitats.Add(habitatList[h].id);
            }
            for (var t = 0; t < typeList.Count; t++)
            {
                types.Add(typeList[t].id);
            }
            pokeDex.Add("Any");
            for (var p = 0; p < pokeList.Count; p++)
            {
                pokeDex.Add(pokeList[p].id);
            }
            pkHabitat.DataSource = habitats;
            pkType.DataSource = types;
            pkPokemon.DataSource = pokeDex;
            stages.Add("Any");
            stages.Add("1");
            stages.Add("2");
            stages.Add("3");
            pkStageAllowed.DataSource = stages;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbScan_MouseHover(object sender, EventArgs e)
        {
            pbScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokedexHover.png");
        }

        private void pbScan_MouseLeave(object sender, EventArgs e)
        {
            pbScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokedexHover.png");
        }

        private void pbScan_Click_1(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            this.Hide();
            fm.Show();
        }
        private void FormScan_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormScan_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormScan_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pbScanPokemon_MouseHover(object sender, EventArgs e)
        {
            pbScanPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemonHover.png");
        }

        private void pbScanPokemon_MouseLeave(object sender, EventArgs e)
        {
            pbScanPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemon.png");
        }

        private void CreateScanList()
        {
            permaList = new List<Pokemon>();
            pokeList = new List<Pokemon>();
            pokeList = pokeXML.createList("Pokemon");
            if (pkPokemon.Text == "Any")
            {
                CheckHabitat();
                CheckType();
                CheckEvo();
                if (pkCanBeLegend.Checked != true)
                {
                    GetLegend();
                }
                for (var p = 0; p < pokeList.Count; p++)
                {
                    permaList.Add(pokeList[p]);
                }
            }
            else
            {
                foreach (Pokemon p in pokeList)
                {
                    if (p.id.Contains(pkPokemon.Text) == true)
                    {
                        permaList.Add(p);
                        break;
                    }
                }
            }
        }


        private void pbScanPokemon_Click(object sender, EventArgs e)
        {
            if (pkPokemon.Items.Contains(pkPokemon.Text) == false) { MessageBox.Show("That is not a Pokemon."); return; }
            if (pkType.Items.Contains(pkType.Text) == false) { MessageBox.Show("That is not a Type."); return; }
            if (pkHabitat.Items.Contains(pkHabitat.Text) == false) { MessageBox.Show("That is not a Habitat."); return; }
            if (pkStageAllowed.Items.Contains(pkStageAllowed.Text) == false) { MessageBox.Show("That is not a Evolutionary Stage."); return; }
            AllSkills.Clear();
            AllAbilities.Clear();
            AllMoves.Clear();
            AllImages.Clear();
            AllPokemon.Clear();
            AllNatures.Clear();
            AllItems1.Clear();
            AllItems2.Clear();
            AllDesc1.Clear();
            AllDesc2.Clear();
            AllLevels.Clear();
            Info.Clear();
            Gender.Clear();
            AllStat.Clear();
            Type.Clear();
            CreateScanList();
            Amount = Convert.ToInt32(pkAmount.Value);
            for (var z = 0; z < Amount; z++)
            {
                IChooseYou = null;
                pokeList = new List<Pokemon>();
                for (var p = 0; p < permaList.Count; p++)
                {
                    pokeList.Add(permaList[p]);
                }
                Pokemon HeyYou = null;
                Pokemon PokeBall = null;
                Pokemon Final = null;
                pkGasp.Clear();
                infoForward.Visible = true;
                infoBack.Visible = true;
                isShiny = false;
                pkLevelMin_ValueChanged(this, new EventArgs());
                pkLevelMax_ValueChanged(this, new EventArgs());
                HeyYou = GetPokemon();
                if (HeyYou == null) { return; }
                int Level = GetLevel();
                PokeBall = GetGender(HeyYou); if (PokeBall == null) { return; }
                Final = PokeBall;
                pkGasp.Text += "It is a " + Final.id;
                if (pkCanBeShiny.Checked == true)
                {
                    int i = rng.Next(1, 101);
                    if (i == 1 || i == 100)
                    {
                        pkGasp.Text += Environment.NewLine + "It's a Shiny!";
                        isShiny = true;
                        GetShiny(Final);
                        Type.Add(newShiny);
                        AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + PokeBall.number + ".gif"));
                    }
                    else
                    {
                        AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + PokeBall.number + ".gif"));
                        Type.Add(Final.type);
                    }

                }
                else
                {
                        AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + PokeBall.number + ".gif"));
                        Type.Add(Final.type);
                }
                if (pkHasItem.Checked == true)
                {
                    GetItem();
                }
                else
                {
                    AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                    AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                    AllDesc1.Add("There are no items.");
                    AllDesc2.Add("There are no items.");
                }
                IChooseYou = Final;
                AllPokemon.Add(IChooseYou);
                TrueLevel = Level;
                AllLevels.Add(TrueLevel);
                GetMoves();
                AllMoves.Add(moves);
                GetAbilities();
                AllAbilities.Add(ability);
                GetSkills();
                AllSkills.Add(skill);
                GetStats(Final, TrueLevel+10);
                GetNature();
                AllStat.Add(Stat);
                string[] info = pkGasp.Lines;
                Info.Add(info);
            }
            Current = 0;
            tbPokeCount.Text = (Current + 1).ToString() + "/" + Amount.ToString();
            pbPokemon.Image = AllImages[Current];
            SetImage();
            if (AllPokemon.Count > 1)
            {
                pbPokeRight.Visible = true;
                pbPokeLeft.Visible = true;
                pbGotoPage.Visible = true;
                pkGoto.Enabled = true;
                pkGoto.Maximum = Amount;
            }
            else
            {
                pbPokeRight.Visible = false;
                pbPokeLeft.Visible = false;
                pbGotoPage.Visible = false;
                pkGoto.Enabled = false;
            }
            UpdatePage();
            SetGasp();

                
        }

        private Image getImage(string x)
        {
            string path = (x);
            if (File.Exists(x) == true)
            {
                return Image.FromFile(path);
            }
            else if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\MissingNo.gif"))
            {
                return Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\MissingNo.gif");
            }
            else
            {
                return Image.FromFile(null);
            }
        }

        private void CheckEvo()
        {
            if (pkStageAllowed.Text != "Any")
            {
                int sA = Convert.ToInt32(pkStageAllowed.Text);
                for (var e = 0; e < pokeList.Count; e++)
                {
                    string[] pokeID = pokeList[e].id.Split(' ').ToArray();
                    evoList = evoXML.createList(pokeList[e].number);
                    for (var x = 0; x < evoList.Count; x++)
                    {
                        if (evoList[x].evo.Contains(pokeID[0]) == true)
                        {
                            if (!evoList[x].evo.Contains(sA + " -"))
                            {
                                pokeList.RemoveAt(e);
                                e -= 1;
                                break;
                            }

                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void CheckHabitat()
        {
            string Habitat = pkHabitat.Text;
            if (Habitat != "Any")
            {
                for (var e = 0; e < pokeList.Count; e++)
                {
                    if (pokeList[e].habitat.Contains(Habitat) == false)
                    {
                        pokeList.RemoveAt(e);
                        e -= 1;
                    }
                }
            }
        }

        private void CheckType()
        {
            string Type = pkType.Text;
            if ( Type == "Any") { return; }
            for (var e = 0; e < pokeList.Count; e++)
            {
                if (pokeList[e].type.Contains(Type) == false)
                {
                    pokeList.RemoveAt(e);
                    e -= 1;
                }
                      
            }
        }

        private void GetNature()
        {
            natureList = natureXML.createList("Natures", "Nature");
            int i = rng.Next(0, natureList.Count - 1);
            int hp;
            int atk;
            int def;
            int spatk;
            int spdef;
            int spd;
            hp = Convert.ToInt32(Stat[0]); 
            atk = Convert.ToInt32(Stat[1]);
            def = Convert.ToInt32(Stat[2]); 
            spatk = Convert.ToInt32(Stat[3]);
            spdef = Convert.ToInt32(Stat[4]); 
            spd = Convert.ToInt32(Stat[5]);
            if (natureList[i].up == "hp") { hp++; }
            else if (natureList[i].up == "atk") { atk += 2; }
            else if (natureList[i].up == "def") { def += 2; }
            else if (natureList[i].up == "spatk") { spatk += 2; }
            else if (natureList[i].up == "spdef") { spdef += 2; }
            else if (natureList[i].up == "spd") { spd += 2; }
            if (natureList[i].down == "hp") { hp--; }
            else if (natureList[i].down == "atk") { atk -= 2; }
            else if (natureList[i].down == "def") { def -= 2; }
            else if (natureList[i].down == "spatk") { spatk -= 2; }
            else if (natureList[i].down == "spdef") { spdef -= 2; }
            else if (natureList[i].down == "spd") { spd -= 2; }
            Stat[0] = hp.ToString();
            Stat[1] = atk.ToString();
            Stat[2] = def.ToString();
            Stat[3] = spatk.ToString();
            Stat[4] = spdef.ToString();
            Stat[5] = spd.ToString();
            AllNatures.Add(natureList[i].id);
            return;
        }

        private Pokemon GetPokemon()
        {
            int i = rng.Next(0, pokeList.Count);
            try { return pokeList[i]; } catch { MessageBox.Show("There are no registered Pokemon that fit this criteria..."); return null; }
            
        }

        private int GetLevel()
        {
            int min = Convert.ToInt32(pkLevelMin.Value);
            int max = Convert.ToInt32(pkLevelMax.Value + 1);
            int i = rng.Next(min, max);
            return i;
        }

        private void SetImage()
        {
            pbPokemon.Size = pbPokemon.Image.Size;
            pbPokemon.Location = new Point(203 - (pbPokemon.Width / 2), 305 - (pbPokemon.Height));
        }

        private void SetItem()
        {
            pkItem.Size = pkItem.Image.Size;
            pkItem.Location = new Point(623 - (pkItem.Width / 2), 512 - (pkItem.Height));
        }

        private void GetStats(Pokemon poke, int level)
        {
            List<Stat> stats = new List<Stat>();
            StatList getstats = new StatList();
            Stat = new List<string>();
            int hp;
            int atk;
            int def;
            int spatk;
            int spdef;
            int spd;
            try { hp = Convert.ToInt32(poke.hp); } catch { MessageBox.Show(poke.id + "'s hp is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return; }
            try { atk = Convert.ToInt32(poke.atk); } catch { MessageBox.Show(poke.id + "'s atk is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return; }
            try { def = Convert.ToInt32(poke.def); } catch { MessageBox.Show(poke.id + "'s def is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return; }
            try { spatk = Convert.ToInt32(poke.spatk); } catch { MessageBox.Show(poke.id + "'s spatk is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return; }
            try { spdef = Convert.ToInt32(poke.spdef); } catch { MessageBox.Show(poke.id + "'s spdef is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return; }
            try { spd = Convert.ToInt32(poke.spd); } catch { MessageBox.Show(poke.id + "'s spd is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return; }
            stats = getstats.createList(hp, atk, def, spatk, spdef, spd);
            SortStats(stats);

            for (var l = level; l > 0; l--)
            {
                int i = rng.Next(1, 7);
                if ( i == 1) { if (stats[5].stat <= stats[4].stat) { stats[5].stat++; } else { l++; } }
                else if (i == 2) { if (stats[4].stat <= stats[3].stat) { stats[4].stat++; } else { l++; } }
                else if (i == 3) { if (stats[3].stat <= stats[2].stat) { stats[3].stat++; } else { l++; } }
                else if (i == 4) { if (stats[2].stat <= stats[1].stat) { stats[2].stat++; } else { l++; } }
                else if (i == 5) { if (stats[1].stat <= stats[0].stat) { stats[1].stat++; } else { l++; } }
                else if (i == 6) { stats[0].stat++; }
            }
            for (var z = 0; z < stats.Count; z++)
            {
                if (stats[z].id == "hp") { Stat.Add(stats[z].stat.ToString()); }
            }
            for (var z = 0; z < stats.Count; z++)
            {
                if (stats[z].id == "atk") { Stat.Add(stats[z].stat.ToString()); }
            }
            for (var z = 0; z < stats.Count; z++)
            {
                if (stats[z].id == "def") { Stat.Add(stats[z].stat.ToString()); }
            }
            for (var z = 0; z < stats.Count; z++)
            {
                if (stats[z].id == "spatk") { Stat.Add(stats[z].stat.ToString()); }
            }
            for (var z = 0; z < stats.Count; z++)
            {
                if (stats[z].id == "spdef") { Stat.Add(stats[z].stat.ToString()); }
            }
            for (var z = 0; z < stats.Count; z++)
            {
                if (stats[z].id == "spd") { Stat.Add(stats[z].stat.ToString()); }
            }
            return;

        }

        private void SortStats(List<Stat> stats)
        {
            stats.Sort(delegate (Stat x, Stat y)
            {
                return y.stat.CompareTo(x.stat);
            });
        }

        private void SortPokemon(List<Pokemon> stats)
        {
            stats.Sort(delegate (Pokemon x, Pokemon y)
            {
                return x.number.CompareTo(y.number);
            });
        }

        private Pokemon GetGender(Pokemon poke)
        {
            if (poke.gender == "Genderless" || poke.gender == "None")
            {
                Gender.Add("Genderless");
                return poke;
            }
            else
            {
                string[] gender;
                try { gender = poke.gender.Split(' '); } catch { MessageBox.Show(poke.id + "'s Gender Ratio is not entered correctly. Please take a " +
                    "look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return poke = null; }
                string m = gender[0];
                m = m.Replace("%", " ");
                m = m.Trim();
                if (m.Contains('.'))
                {
                    string[] gendermale = m.Split('.');
                    m = gendermale[0];
                    m = m.Trim();
                }
                int male;
                try { male = Convert.ToInt32(m); } catch { MessageBox.Show(poke.id + "'s Gender Ratio is not entered correctly. Please take a " + 
                    "look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return poke = null; }
                int i = rng.Next(0, 101);
                if (i <= male)
                {
                    Gender.Add("Male");
                    return poke;
                }
                else
                {
                    Gender.Add("Female");
                    return poke;
                }
            }
        }

        private void GetLegend()
        {
            for (var l = 0; l < pokeList.Count; l++)
            {
                if (pokeList[l].legendary == "true")
                {
                    pokeList.RemoveAt(l);
                    l -= 1;
                }
            }
        }

        private void WriteInfo()
        {
            pkItem.Visible = false;
            rtbInfo1.Text = "Number: " + AllPokemon[Current].number + Environment.NewLine +
                "Name: " + AllPokemon[Current].id + Environment.NewLine +
                "Type: " + Type[Current] + Environment.NewLine +
                Environment.NewLine +
                "Level: " + AllLevels[Current] + Environment.NewLine +
                "Nature: " + AllNatures[Current] + Environment.NewLine +
                Environment.NewLine +
                "Stats:" + Environment.NewLine +
                "HP:\t\t" + AllStat[Current][0] + Environment.NewLine +
                "ATK:\t\t" + AllStat[Current][1] + Environment.NewLine +
                "DEF:\t\t" + AllStat[Current][2] + Environment.NewLine +
                "SPATK:\t" + AllStat[Current][3] + Environment.NewLine +
                "SPDEF:\t" + AllStat[Current][4] + Environment.NewLine +
                "SPD:\t\t" + AllStat[Current][5] + Environment.NewLine +
                Environment.NewLine +
                "Gender: " + Gender[Current] + Environment.NewLine +
                "Size: " + AllPokemon[Current].size + Environment.NewLine +
                "Weight: " + AllPokemon[Current].weight;
        }

        private void WriteMoves()
        {
            pkItem.Visible = false;
            rtbInfo1.Text = ("Moves:" + Environment.NewLine);
            for (var w = 0; w < AllMoves[Current].Count; w++)
            {
                rtbInfo1.Text += "-" + AllMoves[Current][w] + Environment.NewLine;
            }
            rtbInfo1.Text += Environment.NewLine + "Abilities:" + Environment.NewLine;
            for (var a = 0; a < AllAbilities[Current].Count; a++)
            {
                rtbInfo1.Text += "-" + AllAbilities[Current][a] + Environment.NewLine;
            }
            rtbInfo1.Text += Environment.NewLine + "Skills:" + Environment.NewLine;
            for (var s = 0; s < AllSkills[Current].Count; s++)
            {
                rtbInfo1.Text += "-" + AllSkills[Current][s] + Environment.NewLine;
            }
        }

        private void WriteItem1()
        {
            pkItem.Visible = true;
            pkItem.Image = AllItems1[Current];
            SetItem();
            rtbInfo1.Text = "Item 1-" + Environment.NewLine +
                AllDesc1[Current];
        }
        private void WriteItem2()
        {
            pkItem.Visible = true;
            pkItem.Image = AllItems2[Current];
            SetItem();
            rtbInfo1.Text = "Item 2-" + Environment.NewLine +
                AllDesc2[Current];

        }

        private void infoBack_Click(object sender, EventArgs e)
        {
            Page--;
            if (Page == 0) { Page = 4; }
            UpdatePage();
        }

        private void infoForward_Click(object sender, EventArgs e)
        {
            Page++;
            if (Page == 5) { Page = 1; }
            UpdatePage();
        }

        private void UpdatePage()
        {
            tbPageCount.Text = Page + "/4";
            if (Page == 1) { WriteInfo(); }
            if (Page == 2) { WriteMoves(); }
            if (Page == 3) { WriteItem1(); }
            if (Page == 4) { WriteItem2(); }
        }

        private void GetAbilities()
        {
            abiList = new List<Ability>();
            ability = new List<string>();
            abiList.Clear();
            abiList = basicXML.createList(IChooseYou.number);
            ability.Clear();
            int i = rng.Next(0, abiList.Count);
            ability.Add(abiList[i].basicability);
            if (TrueLevel >= 20)
            {
                abiList = advXML.createList(IChooseYou.number);
                i = rng.Next(0, abiList.Count);
                ability.Add(abiList[i].advability);
            }
            if (TrueLevel >= 40)
            {
                abiList = highXML.createList(IChooseYou.number);
                i = rng.Next(0, abiList.Count);
                ability.Add(abiList[i].highability);
            }
        }

        private string SkillUp(int i)
        {
            StringBuilder build = new StringBuilder();
            string skil = skillList[i].skill.ToString();
            string[] up1 = skil.Split('d');
            string[] up2 = up1[0].Split(' ');
            int temp;
            try { temp = Convert.ToInt32(up2[1]); } catch { MessageBox.Show(IChooseYou.id + "'s Skill is not entered correctly. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return "ERROR"; }
            int fin = temp + 1;
            build.Append(up2[0] + " " + fin + "d" + up1[1]);
            return build.ToString();
        }

        private string SkillDn(int i)
        {
            StringBuilder build = new StringBuilder();
            string skil = skillList[i].skill.ToString();
            string[] up1 = skil.Split('d');
            string[] up2 = up1[0].Split(' ');
            int temp;
            try { temp = Convert.ToInt32(up2[1]); } catch { MessageBox.Show(IChooseYou.id + "'s Skill is not entered correctly. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return "ERROR"; }
            int fin = temp - 1;
            build.Append(up2[0] + " " + fin + "d" + up1[1]);
            return build.ToString();
        }

        private void GetSkills()
        {
            skillList = new List<Skill>();
            skill = new List<string>();
            List<string> prep = new List<string>();
            prep.Clear();
            skillList.Clear();
            skillList = skillXML.createList(IChooseYou.number);
            skill.Clear();
            var values = Enumerable.Range(0, 6).OrderBy(x => Guid.NewGuid().GetHashCode()).ToArray();
            int sk = rng.Next(0, 4);
            if (sk == 0)
            {
                prep.Add(skillList[values[0]].skill);
                prep.Add(skillList[values[1]].skill);
                prep.Add(skillList[values[2]].skill);
                prep.Add(skillList[values[3]].skill);
                prep.Add(skillList[values[4]].skill);
                prep.Add(skillList[values[5]].skill);
            }
            else if (sk == 1)
            {
                prep.Add(SkillUp(values[0]));
                prep.Add(SkillDn(values[1]));
                prep.Add(skillList[values[2]].skill);
                prep.Add(skillList[values[3]].skill);
                prep.Add(skillList[values[4]].skill);
                prep.Add(skillList[values[5]].skill);
            }
            else if (sk == 2)
            {
                prep.Add(SkillUp(values[0]));
                prep.Add(SkillDn(values[1]));
                prep.Add(SkillUp(values[2]));
                prep.Add(SkillDn(values[3]));
                prep.Add(skillList[values[4]].skill);
                prep.Add(skillList[values[5]].skill);
            }
            else if (sk == 3)
            {
                prep.Add(SkillUp(values[0]));
                prep.Add(SkillDn(values[1]));
                prep.Add(SkillUp(values[2]));
                prep.Add(SkillDn(values[3]));
                prep.Add(SkillUp(values[4]));
                prep.Add(SkillDn(values[5]));
            }
            foreach (string s in prep)
            {
                if (s.Contains("Athl") == true) { skill.Add(s); }
            }
            foreach (string s in prep)
            {
                if (s.Contains("Acro") == true) { skill.Add(s); }
            }
            foreach (string s in prep)
            {
                if (s.Contains("Combat") == true) { skill.Add(s); }
            }
            foreach (string s in prep)
            {
                if (s.Contains("Stealth") == true) { skill.Add(s); }
            }
            foreach (string s in prep)
            {
                if (s.Contains("Percep") == true) { skill.Add(s); }
            }
            foreach (string s in prep)
            {
                if (s.Contains("Focus") == true) { skill.Add(s); }
            }
        }

        private void GetMoves()
        {
            int i = TrueLevel;
            moveXML = new MoveList();
            moves = new List<string>();
            moveList.Clear();
            moveList = moveXML.createList(IChooseYou.number);
            StringBuilder build = new StringBuilder();
            for (var e = 0; e < moveList.Count; e++)
            {
                string[] moveLevel = moveList[e].move.Split(' ');
                int lvl;
                try { lvl = Convert.ToInt32(moveLevel[0]); } catch { MessageBox.Show(IChooseYou.id + "'s Move is not entered correctly. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue.   '" + moveList[e].move + "'"); return; }
                if (lvl <= i)
                {
                    build.Clear();
                    foreach (string s in moveLevel)
                    {
                        if (s != moveLevel[0])
                        {
                            build.Append(s);
                            build.Append(" ");
                        }
                    }
                    string mov = build.ToString();
                    mov = mov.Trim();
                    moves.Add(mov);
                }
                if (moves.Count > 6) { moves.RemoveAt(0); }
            }
            bool done = false;
            if (isShiny == true)
            {
                TMList = TMXML.createList("TM-HM", "TM");
                do
                {
                    i = rng.Next(0, TMList.Count);
                    if (TMList[i].type == typeShiny)
                    {
                        done = true;
                    }
                } while (done == false);
                if (moves.Count >= 6) { moves.RemoveAt(0); }
                string newmove = TMList[i].id + " - " + TMList[i].type;
                moves.Add(newmove);
            }
        }

        private void GetShiny(Pokemon poke)
        {
            string[] type = poke.type.Split(' ');
            int i = rng.Next(1, typeList.Count);
            string newtype = typeList[i].id;
            StringBuilder build = new StringBuilder();
            if (type.Count() <= 1)
            {
                List<string> fix = new List<string>();
                fix.Add(type[0]);
                fix.Add("/");
                fix.Add("placeholder");
                type = fix.ToArray();
            }
            foreach (string s in type)
            {
                if (s != type[2])
                {
                    build.Append(s);
                    build.Append(" ");
                }
            }
            build.Append(newtype);
            typeShiny = newtype;
            newShiny = build.ToString();
            return;
        }

        private void GetItem()
        {
            getItem2 = false;
            int i = rng.Next(1, 101);
            if (i < 26)
            {
                GetItem1(); 
            }
            else
            {
                AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllDesc1.Add("There are no items.");
                AllDesc2.Add("There are no items.");
                return;
            }
        }

        private void GetItem1()
        {
            int i = rng.Next(1, 101);
            if (i < 79) { Tier1(); }
            else if (i < 94) { Tier2(); }
            else if (i < 100) { Tier3(); }
            else if (i < 101) { Tier4(); }
            i = rng.Next(1, 11);
            if (i == 10)
            {
                pkGasp.Text += Environment.NewLine +  "It has a few things!";
                getItem2 = true;
                GetItem2();
            }
            else
            {
                pkGasp.Text += Environment.NewLine + "It has something!";
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllDesc2.Add("There are no items.");
            }
        }

        private void GetItem2()
        {
            int i = rng.Next(1, 101);
            if (i < 79) { Tier1(); }
            else if (i < 94) { Tier2(); }
            else if (i < 100) { Tier3(); }
            else if (i < 101) { Tier4(); }
        }
        
        private void Tier1()
        {
            itemList = itemXML.createList("Tier1", "Item");
            int i = rng.Next(0, itemList.Count);
            if (getItem2 == true)
            {
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc2.Add(itemList[i].id + ": " + itemList[i].desc);
            }
            else
            {
                AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc1.Add(itemList[i].id + ": " + itemList[i].desc);
            }
        }

        private void Tier2()
        {
            itemList = itemXML.createList("Tier2", "Item");
            int i = rng.Next(0, itemList.Count);
            if (getItem2 == true)
            {
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc2.Add(itemList[i].id + ": " + itemList[i].desc);
            }
            else
            {
                AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc1.Add(itemList[i].id + ": " + itemList[i].desc);
            }
        }

        private void Tier3()
        {
            itemList = itemXML.createList("Tier3", "Item");
            int i = rng.Next(0, itemList.Count);
            if (getItem2 == true)
            {
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc2.Add(itemList[i].id + ": " + itemList[i].desc);
            }
            else
            {
                AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc1.Add(itemList[i].id + ": " + itemList[i].desc);
            }
        }

        private void Tier4()
        {
            itemList = itemXML.createList("Tier4", "Item");
            int i = rng.Next(0, itemList.Count);
            if (getItem2 == true)
            {
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc2.Add(itemList[i].id + ": " + itemList[i].desc);
            }
            else
            {
                AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
                AllDesc1.Add(itemList[i].id + ": " + itemList[i].desc);
            }
        }

        private void pkLevelMin_ValueChanged(object sender, EventArgs e)
        {
            if (pkLevelMin.Value > pkLevelMax.Value) { pkLevelMax.Value = pkLevelMin.Value; }
        }

        private void pkLevelMax_ValueChanged(object sender, EventArgs e)
        {
            if (pkLevelMax.Value < pkLevelMin.Value) { pkLevelMin.Value = pkLevelMax.Value; }
        }

        private void pkPokemon_TextChanged(object sender, EventArgs e)
        {
            if (pkPokemon.Text != "Any")
            {
                pkHabitat.Enabled = false;
                pkType.Enabled = false;
                pkCanBeLegend.Enabled = false;
                pkStageAllowed.Enabled = false;
            }
            else
            {
                pkHabitat.Enabled = true;
                pkType.Enabled = true;
                pkCanBeLegend.Enabled = true;
                pkStageAllowed.Enabled = true;
            }
        }

        private void pbPokeLeft_Click(object sender, EventArgs e)
        {
            if (Current <= 0)
            {
                Current = Amount - 1;
            }
            else
            {
                Current--;
            }
            tbPokeCount.Text = (Current + 1).ToString() + "/" + Amount.ToString();
            pbPokemon.Image = AllImages[Current];
            SetImage();
            SetGasp();
            UpdatePage();
        }

        private void pbPokeRight_Click(object sender, EventArgs e)
        {
            if (Current >= Amount - 1)
            {
                Current = 0;
            }
            else
            {
                Current++;
            }
            tbPokeCount.Text = (Current + 1).ToString() + "/" + Amount.ToString();
            pbPokemon.Image = AllImages[Current];
            SetImage();
            SetGasp();
            UpdatePage();
        }

        private void SetGasp()
        {
            pkGasp.Text = "";
            foreach (string s in Info[Current])
            {
                pkGasp.Text += s + Environment.NewLine;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pbGotoPage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\GotoPageHover.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pbGotoPage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\GotoPage.png");
        }

        private void pkGoto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbGotoPage_Click(this, new EventArgs());
            }
        }

        private void pbGotoPage_Click(object sender, EventArgs e)
        {
            Current = Convert.ToInt32(pkGoto.Value) - 1;
            if (Current > Amount - 1)
            {
                Current = 0;
            }
            tbPokeCount.Text = (Current + 1).ToString() + "/" + Amount.ToString();
            pbPokemon.Image = AllImages[Current];
            SetImage();
            SetGasp();
            UpdatePage();
        }
    }
}
