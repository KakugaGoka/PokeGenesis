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
        Point dragCursorPoint;
        Point dragFormPoint;
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
        List<Move> moveList = new List<Move>();
        List<Ability> abiList = new List<Ability>();
        List<Skill> skillList = new List<Skill>();
        List<Capability> capList = new List<Capability>();
        List<Evolution> evoList = new List<Evolution>();
        Random rng = new Random();
        List<Items> habitatList = new List<Items>();
        List<Items> typeList = new List<Items>();
        List<Nature> natureList = new List<Nature>();
        List<string> habitats = new List<string>();
        List<string> types = new List<string>();
        Pokemon IChooseYou = new Pokemon();
        List<Items> itemList = new List<Items>();
        ItemList itemXML = new ItemList();
        List<TM> TMList = new List<TM>();
        TMList TMXML = new TMList();
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
        List<string> AllDesc3 = new List<string>();
        List<string[]> Info = new List<string[]>();
        List<string> preInfo = new List<string>();
        List<string> Gender = new List<string>();
        List<string> Stat = new List<string>();
        List<List<string>> AllStat = new List<List<string>>();
        List<string> Cap = new List<string>();
        List<List<string>> AllCap = new List<List<string>>();
        List<decimal> MaxHealth = new List<decimal>();
        List<decimal> CurrentHealth = new List<decimal>();
        List<string> Type = new List<string>();
        int TrueLevel = new int();
        int Page = 1;
        int Current = 0;
        int Amount = 0;
        int nature { get; set; }
        int cash = 0;
        int pbPokeLocX { get; set; }
        int pbPokeLocY { get; set; }
        int PokeLevelMax { get; set; }
        int PokeLevelMin { get; set; }
        int Progress { get; set; }
        bool canLegendary { get; set;}
        bool canItems { get; set; }
        bool canShiny { get; set; }
        bool onItem2 = false;
        bool onItem3 = false;
        bool isShiny = false;
        bool dragging = false;
        bool hasScanned = false;
        bool isScanning = false;
        string typeShiny { get; set; }
        string newShiny { get; set; }
        string PokeName { get; set; }
        string PokeType { get; set; }
        string PokeHabitat { get; set; }
        string PokeStage { get; set; }
        string [] info { get; set; }
        

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
            stages.Add("Only 1s");
            stages.Add("Only 2s");
            stages.Add("Only 3s");
            stages.Add("1s & 2s");
            stages.Add("1s & 3s");
            stages.Add("2s & 3s");
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
            if (isScanning) return;
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

        private void pbScanPokemon_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            isScanning = true;
            infoBack.Visible = true;
            infoForward.Visible = true;
            pkLevelMin_ValueChanged(this, new EventArgs());
            pkLevelMax_ValueChanged(this, new EventArgs());
            PokeName = pkPokemon.Text;
            PokeHabitat = pkHabitat.Text;
            PokeType = pkType.Text;
            PokeStage = pkStageAllowed.Text;
            PokeLevelMax = Convert.ToInt32(pkLevelMax.Value);
            PokeLevelMin = Convert.ToInt32(pkLevelMin.Value);
            Amount = Convert.ToInt32(pkAmount.Value);
            GenerationProgress.Maximum = Amount;
            canItems = pkHasItem.Checked;
            canLegendary = pkCanBeLegend.Checked;
            canShiny = pkCanBeShiny.Checked;
            lblProgress.Text = "Queuing Scan";
            PokeGenerator.RunWorkerAsync();
        }

        private void PokeGenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            hasScanned = true;
            if (pokeDex.Contains(PokeName) == false) { MessageBox.Show("That is not a Pokemon."); return; }
            if (types.Contains(PokeType) == false) { MessageBox.Show("That is not a Type."); return; }
            if (habitats.Contains(PokeHabitat) == false) { MessageBox.Show("That is not a Habitat."); return; }
            if (stages.Contains(PokeStage) == false) { MessageBox.Show("That is not a Evolutionary Stage."); return; }
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
            AllStat.Clear();
            AllLevels.Clear();
            AllCap.Clear();
            Info.Clear();
            Gender.Clear();
            Type.Clear();
            MaxHealth.Clear();
            CurrentHealth.Clear();
            Current = 0;
            Progress = 0;
            CreateScanList();
            for (var z = 0; z < Amount; z++)
            {
                IChooseYou = new Pokemon();
                Pokemon Final = new Pokemon();
                preInfo.Clear();
                isShiny = false;
                Final = GetPokemon();
                int Level = GetLevel();
                preInfo.Add("It is a " + Final.id);
                if (pkCanBeShiny.Checked == true)
                {
                    int i = rng.Next(1, 101);
                    if (i == 1 || i == 100)
                    {
                        preInfo.Add("It's a Shiny!");
                        isShiny = true;
                        GetShiny(Final);
                        Type.Add(newShiny);
                        AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + Final.number + ".gif"));
                    }
                    else
                    {
                        AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + Final.number + ".gif"));
                        Type.Add(Final.type);
                    }

                }
                else
                {
                    AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + Final.number + ".gif"));
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
                GetGender(AllPokemon[Current]);
                GetMoves();
                AllMoves.Add(moves);
                GetAbilities();
                AllAbilities.Add(ability);
                GetSkills();
                AllSkills.Add(skill);
                GetStats(AllPokemon[Current], TrueLevel + 10);
                AllStat.Add(Stat);
                GetHealth();
                GetCap(AllPokemon[Current]);
                AllCap.Add(Cap);
                info = preInfo.ToArray();
                Info.Add(info);
                Current++;
                Progress++;
                PokeGenerator.ReportProgress(Progress);
            }
        }

        private void PokeGenerator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
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
            isScanning = false;
        }

        private void PokeGenerator_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            GenerationProgress.Value = e.ProgressPercentage;
            lblProgress.Text = e.ProgressPercentage.ToString() + "/" + Amount.ToString() + " Complete";
        }

        private void CreateScanList()
        {
            pokeList = new List<Pokemon>();
            pokeList = pokeXML.createList("Pokemon");
            if (PokeName == "Any")
            {
                CheckHabitat();
                CheckType();
                CheckEvo();
                if (!canLegendary)
                {
                    GetLegend();
                }
            }

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
            if (PokeStage != "Any")
            {
                List < string > stageAllow = new List<string>();
                if (PokeStage == "Only 1s")
                {
                    stageAllow.Add("1 -");
                    goto OnlyOne;
                }
                if (PokeStage == "Only 2s")
                {
                    stageAllow.Add("2 -");
                    goto OnlyOne;
                }
                if (PokeStage == "Only 3s")
                {
                    stageAllow.Add("3 -");
                    goto OnlyOne;
                }
                if (PokeStage == "1s & 2s")
                {
                    stageAllow.Add("1 -");
                    stageAllow.Add("2 -");
                    goto TwoStages;
                }
                if (PokeStage == "1s & 3s")
                {
                    stageAllow.Add("1 -");
                    stageAllow.Add("3 -");
                    goto TwoStages;
                }
                if (PokeStage == "2s & 3s")
                {
                    stageAllow.Add("2 -");
                    stageAllow.Add("3 -");
                    goto TwoStages;
                }
                OnlyOne:
                for (var e = 0; e < pokeList.Count; e++)
                {
                    string[] name = pokeList[e].id.Split().ToArray();
                    evoList = evoXML.createList(pokeList[e].number);
                    for (var x = 0; x < evoList.Count; x++)
                    {
                        if (evoList[x].evo.Contains(name[0]))
                        {
                            if (!evoList[x].evo.Contains(stageAllow[0]))
                            {
                                pokeList.RemoveAt(e);
                                e -= 1;
                                break;
                            }
                        }
                    }
                }
                return;
                TwoStages:
                for (var e = 0; e < pokeList.Count; e++)
                {
                    string[] name = pokeList[e].id.Split().ToArray();
                    evoList = evoXML.createList(pokeList[e].number);
                    for (var x = 0; x < evoList.Count; x++)
                    {
                        if (evoList[x].evo.Contains(name[0]))
                        {
                            if (!evoList[x].evo.Contains(stageAllow[0]) && !evoList[x].evo.Contains(stageAllow[1]))
                            {
                                pokeList.RemoveAt(e);
                                e -= 1;
                                break;
                            }
                        }
                    }
                }
                return;
            }
            else
            {
                return;
            }
        }

        private void CheckHabitat()
        {
            if (PokeHabitat != "Any")
            {
                for (var e = 0; e < pokeList.Count; e++)
                {
                    if (pokeList[e].habitat.Trim() == ""||pokeList[e].habitat == null)
                    {
                        MessageBox.Show(pokeList[e].id + "'s does not have a habitat...");
                        pokeList.RemoveAt(e);
                        e -= 1;
                    }
                    else if (pokeList[e].habitat.Contains(PokeHabitat) == false)
                    {
                        pokeList.RemoveAt(e);
                        e -= 1;
                    }
                }
            }
        }

        private void CheckType()
        {
            if ( PokeType == "Any") { return; }
            for (var e = 0; e < pokeList.Count; e++)
            {
                if (pokeList[e].type.Trim() == "" || pokeList[e].type == null)
                {
                    MessageBox.Show(pokeList[e].id + "'s does not have a type...");
                    pokeList.RemoveAt(e);
                    e -= 1;
                }
                else if (pokeList[e].type.Contains(PokeType) == false)
                {
                    pokeList.RemoveAt(e);
                    e -= 1;
                }
                      
            }
        }

        private Pokemon GetPokemon()
        {
            int i;
            if (PokeName != "Any")
            {
                Pokemon find = pokeList.Find(x => x.id == pkPokemon.Text);
                return find;
            }
            else
            {
                i = rng.Next(0, pokeList.Count);
                try { return pokeList[i]; } catch { MessageBox.Show("There are no registered Pokemon that fit this criteria..."); return null; }
            }
        }

        private int GetLevel()
        {
            int min = Convert.ToInt32(pkLevelMin.Value);
            int max = Convert.ToInt32(pkLevelMax.Value + 1);
            int i = rng.Next(min, max);
            return i;
        }

        private void GetCap(Pokemon poke)
        {
            Cap = new List<string>();
            capList = capXML.createList(poke.number);
            foreach (Capability cap in capList)
            {
                Cap.Add(cap.cap);
            }
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
            try { hp = Convert.ToInt32(poke.hp); } catch { MessageBox.Show(poke.id + "'s hp is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); hp = 1; return; }
            try { atk = Convert.ToInt32(poke.atk); } catch { MessageBox.Show(poke.id + "'s atk is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); atk = 1; return; }
            try { def = Convert.ToInt32(poke.def); } catch { MessageBox.Show(poke.id + "'s def is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); def = 1; return; }
            try { spatk = Convert.ToInt32(poke.spatk); } catch { MessageBox.Show(poke.id + "'s spatk is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); spatk = 1; return; }
            try { spdef = Convert.ToInt32(poke.spdef); } catch { MessageBox.Show(poke.id + "'s spdef is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); spdef = 1; return; }
            try { spd = Convert.ToInt32(poke.spd); } catch { MessageBox.Show(poke.id + "'s spd is not a proper integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); spd = 1; return; }
            stats = getstats.createList(hp, atk, def, spatk, spdef, spd);
            stats = GetNature(stats);
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

        private List<Stat> GetNature(List<Stat> stats)
        {
            natureList = natureXML.createList("Natures", "Nature");
            int i = rng.Next(0, natureList.Count - 1);
            int hp;
            int atk;
            int def;
            int spatk;
            int spdef;
            int spd;
            hp = Convert.ToInt32(stats[0].stat);
            atk = Convert.ToInt32(stats[1].stat);
            def = Convert.ToInt32(stats[2].stat);
            spatk = Convert.ToInt32(stats[3].stat);
            spdef = Convert.ToInt32(stats[4].stat);
            spd = Convert.ToInt32(stats[5].stat);
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
            stats[0].stat = hp;
            stats[1].stat = atk;
            stats[2].stat = def;
            stats[3].stat = spatk;
            stats[4].stat = spdef;
            stats[5].stat = spd;
            AllNatures.Add(natureList[i].id);
            return stats;
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
            if (poke.gender == "Genderless"|| poke.gender == "No Gender"||poke.gender == "None" || poke.gender == "Hermaphrodite")
            {
                Gender.Add("No Gender");
                return poke;
            }
            else
            {
                string[] gender;
                try { gender = poke.gender.Split(' '); } catch { MessageBox.Show(poke.id + "'s Gender Ratio is not entered correctly. Please take a " +
                    "look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); Gender.Add("!ERROR!"); return poke; }
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
                    "look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); Gender.Add("!ERROR!"); return poke; }
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
            rtbInfo1.Text ="Name: " + AllPokemon[Current].id + Environment.NewLine +
                "Type: " + Type[Current] + Environment.NewLine +
                "Level: " + AllLevels[Current] + Environment.NewLine +
                Environment.NewLine +
                "Stats:" + Environment.NewLine +
                "Current Health: " + CurrentHealth[Current] + Environment.NewLine +
                "Max Health:\t   " + MaxHealth[Current] + Environment.NewLine +
                "HP:\t\t   " + AllStat[Current][0] + Environment.NewLine +
                "ATK:\t\t   " + AllStat[Current][1] + Environment.NewLine +
                "DEF:\t\t   " + AllStat[Current][2] + Environment.NewLine + 
                "SPATK:\t   " + AllStat[Current][3] + Environment.NewLine +
                "SPDEF:\t   " + AllStat[Current][4] + Environment.NewLine + 
                "SPD:\t\t   " + AllStat[Current][5] + Environment.NewLine +
                Environment.NewLine +
                "Capabilities:" + Environment.NewLine;
            foreach (string cap in AllCap[Current])
            {
                rtbInfo1.Text += cap + Environment.NewLine;
            }

        }

        private void WriteMoves()
        {
            pkItem.Visible = false;
            rtbInfo1.Text = "Gender: " + Gender[Current] + Environment.NewLine +
                "Nature: " + AllNatures[Current] + Environment.NewLine +
                "Size: " + AllPokemon[Current].size + Environment.NewLine +
                "Weight: " + AllPokemon[Current].weight + Environment.NewLine;
            rtbInfo1.Text += (Environment.NewLine + "Moves:" + Environment.NewLine);
            for (var w = 0; w < AllMoves[Current].Count; w++)
            {
                rtbInfo1.Text += "-" + AllMoves[Current][w] + Environment.NewLine;
            }
            rtbInfo1.Text += Environment.NewLine + "Abilities:" + Environment.NewLine;
            for (var a = 0; a < AllAbilities[Current].Count; a++)
            {
                rtbInfo1.Text += "-" + AllAbilities[Current][a] + Environment.NewLine;
            }
            rtbInfo1.Text += Environment.NewLine + "Skills:";
            for (var s = 0; s < AllSkills[Current].Count; s += 2)
            {
                rtbInfo1.Text += Environment.NewLine + "-" + AllSkills[Current][s] + "\t-" + AllSkills[Current][s + 1];
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

        private void WriteLoot()
        {
            tbPageCount.Text = "----";
            pkItem.Visible = false;
            rtbInfo1.Clear();
            for (int x = 0; x < AllDesc3.Count; x++)
            {

                rtbInfo1.Text += AllDesc3[x] + Environment.NewLine + Environment.NewLine;
            }
            rtbInfo1.Text += "$" + cash.ToString();
        }

        private void infoBack_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            Page--;
            if (Page == 0) { Page = 4; }
            UpdatePage();
        }

        private void infoForward_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
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

        private void GetHealth()
        {
            int health = (Convert.ToInt32(Stat[0]) * 3) + TrueLevel + 10;
            MaxHealth.Add(health);
            CurrentHealth.Add(health);
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
                try { lvl = Convert.ToInt32(moveLevel[0]); } catch { MessageBox.Show(IChooseYou.id + "'s Move is not entered correctly. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue.   '" + moveList[e].move + "'"); moves.Add("!ERROR!"); return; }
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
            onItem2 = false;
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
            if (i < 79) { ItemGenByTier(1); }
            else if (i < 94) { ItemGenByTier(2); }
            else if (i < 100) { ItemGenByTier(3); }
            else if (i < 101) { ItemGenByTier(4); }
            i = rng.Next(1, 11);
            if (i == 10)
            {
                preInfo.Add("It has a few things!");
                onItem2 = true;
                GetItem2();
            }
            else
            {
                preInfo.Add("It has something!");
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllDesc2.Add("There are no items.");
            }
        }

        private void GetItem2()
        {
            int i = rng.Next(1, 101);
            if (i < 79) { ItemGenByTier(1); }
            else if (i < 94) { ItemGenByTier(2); }
            else if (i < 100) { ItemGenByTier(3); }
            else if (i < 101) { ItemGenByTier(4); }
        }

        private void ItemGenByTier(int tier)
        {
            itemList = itemXML.createList(tier.ToString());
            int i = rng.Next(0, itemList.Count);
            if (!onItem3)
            {
                if (onItem2)
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
            else
            {
                AllDesc3.Add(itemList[i].id + ": " + itemList[i].desc);
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
            if (isScanning) return;
            infoForward.Visible = true;
            infoBack.Visible = true;
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
            if (isScanning) return;
            infoForward.Visible = true;
            infoBack.Visible = true;
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
            if (isScanning) return;
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

        private void pbLoot_Click(object sender, EventArgs e)
        {
            GetLoot();
        }

        private void GetLoot()
        {
            infoBack.Visible = false;
            infoForward.Visible = false;
            pkItem.Visible = false;
            AllDesc3.Clear();
            rtbInfo1.Clear();
            int val = Convert.ToInt32(nudPlayerLevel.Value);
            cash = 0;
            onItem3 = true;
            for (int x = 0; x < val; x++)
            {
                int i = rng.Next(1, 4);
                if (i == 1)
                    GetItem2();
                else
                    cash += rng.Next(1, 6) * 100;
            }
            onItem3 = false;
            WriteLoot();
        }

        private void pbPokeRefresh_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (hasScanned)
            {
                infoForward.Visible = true;
                infoBack.Visible = true;
                UpdatePage();
            }
        }

        private void pbLootRefresh_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (hasScanned)
            {
                infoForward.Visible = false;
                infoBack.Visible = false;
                WriteLoot();
            }
        }

        private void pbLoot_MouseHover(object sender, EventArgs e)
        {
            pbLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLootHover.png");
        }

        private void pbLoot_MouseLeave(object sender, EventArgs e)
        {
            pbLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLoot.png");
        }

        private void pbPokeRefresh_MouseHover(object sender, EventArgs e)
        {
            pbPokeRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokeViewHover.png");
        }

        private void pbPokeRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbPokeRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokeView.png");
        }

        private void pbLootRefresh_MouseHover(object sender, EventArgs e)
        {
            pbLootRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootViewHover.png");
        }

        private void pbLootRefresh_MouseLeave(object sender, EventArgs e)
        {
            pbLootRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootView.png");
        }

        private void pkDamage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbDealDamage_Click(this, new EventArgs());
            }
        }

        private void pbDealDamage_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (hasScanned)
            {
                if ((CurrentHealth[Current] - pkDamage.Value) > MaxHealth[Current])
                    CurrentHealth[Current] = MaxHealth[Current];
                else
                   CurrentHealth[Current] -= pkDamage.Value;
                UpdatePage();
            }
        }

        private void pbDealDamage_MouseHover(object sender, EventArgs e)
        {
            pbDealDamage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealDamageHover.png");
        }

        private void pbDealDamage_MouseLeave(object sender, EventArgs e)
        {
            pbDealDamage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealDamage.png");
        }

        private void CheckedState(CheckBox cb)
        {
            if (cb.Checked)
                cb.Checked = false;
            else
                cb.Checked = true;
        }

        private void pkHasItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(pkHasItem);
            }
        }

        private void pkCanBeShiny_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(pkCanBeShiny);
            }
        }

        private void pkCanBeLegend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(pkCanBeLegend);
            }
        }
    }
}
