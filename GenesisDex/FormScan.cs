using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Vorbis;
using NAudio.Wave;
using GenesisDexEngine;

namespace GenesisDex
{
    public partial class FormScan : Form
    {
        //===========================================================================================================
        //=== Variables =============================================================================================
        //===========================================================================================================
        Point dragCursorPoint = new Point();
        Point dragFormPoint = new Point();
        //===========================================================================================================
        Random rng = new Random();
        //===========================================================================================================
        Pokemon IChooseYou = new Pokemon();
        //===========================================================================================================
        PokemonList pokeXML = new PokemonList();
        List<Pokemon> pokeList = new List<Pokemon>();
        //===========================================================================================================
        List<Pokemon> AllPokemon = new List<Pokemon>();
        //===========================================================================================================
        RegionsList regionXML = new RegionsList();
        List<PokeRegion> regionList = new List<PokeRegion>();
        //===========================================================================================================
        SpawnList spawnXML = new SpawnList();
        List<PokeRegion> spawnList = new List<PokeRegion>();
        //===========================================================================================================
        MovesList moveXML = new MovesList();
        List<Moves> moveList = new List<Moves>();
        //===========================================================================================================
        BasicAbiList basicXML = new BasicAbiList();
        AdvAbiList advXML = new AdvAbiList();
        HighAbiList highXML = new HighAbiList();
        List<Ability> abiList = new List<Ability>();
        //===========================================================================================================
        SkillList skillXML = new SkillList();
        List<Skill> skillList = new List<Skill>();
        //===========================================================================================================
        CapabilityList capXML = new CapabilityList();
        List<Capability> capList = new List<Capability>();
        //===========================================================================================================
        NatureList natureXML = new NatureList();
        List<Nature> natureList = new List<Nature>();
        //===========================================================================================================
        EvolutionList evoXML = new EvolutionList();
        List<Evolution> evoList = new List<Evolution>();
        //===========================================================================================================
        TMList TMXML = new TMList();
        List<TM> TMList = new List<TM>();
        //===========================================================================================================
        ItemList itemXML = new ItemList();
        List<Items> itemList = new List<Items>();
        //===========================================================================================================
        NameList habitatXML = new NameList();
        List<Items> habitatList = new List<Items>();
        //===========================================================================================================
        NameList typeXML = new NameList();
        List<Items> typeList = new List<Items>();
        //===========================================================================================================
        OptionsList optionsXML = new OptionsList();
        List<Options> optionsList = new List<Options>();
        //===========================================================================================================
        BanList banXML = new BanList();
        List<string> banList = new List<string>();
        //===========================================================================================================
        List<Image> AllItems1 = new List<Image>();
        List<Image> AllItems2 = new List<Image>();
        List<Image> AllImages = new List<Image>();
        //===========================================================================================================
        List<int> AllLevels = new List<int>();
        List<int> ItemTiers = new List<int>();
        List<int> PokeTiers = new List<int>();
        //===========================================================================================================
        List<decimal> MaxHealth = new List<decimal>();
        List<decimal> CurrentHealth = new List<decimal>();
        //===========================================================================================================
        List<string> habitats = new List<string>();
        List<string> types = new List<string>();
        List<string> pokeDex = new List<string>();
        List<string> regions = new List<string>();
        List<string> regionPokemon = new List<string>();
        List<string> moves = new List<string>();
        List<string> ability = new List<string>();
        List<string> skill = new List<string>();
        List<string> stages = new List<string>();
        List<string> AllNatures = new List<string>();
        List<string> AllDesc1 = new List<string>();
        List<string> AllDesc2 = new List<string>();
        List<string> AllDesc3 = new List<string>();
        List<string> preInfo = new List<string>();
        List<string> Gender = new List<string>();
        List<string> Stat = new List<string>();
        List<string> Cap = new List<string>();
        List<string> Type = new List<string>();
        List<string> updateList = new List<string>();
        //===========================================================================================================
        List<string[]> Info = new List<string[]>();
        //===========================================================================================================
        List<List<string>> AllMoves = new List<List<string>>();
        List<List<string>> AllAbilities = new List<List<string>>();
        List<List<string>> AllSkills = new List<List<string>>();
        List<List<string>> AllStat = new List<List<string>>();
        List<List<string>> AllCap = new List<List<string>>();
        //===========================================================================================================
        List<bool> AllShinyCheck = new List<bool>();
        //===========================================================================================================
        int TrueLevel { get; set; }
        int Page { get; set; }
        int Current { get; set; }
        int Amount { get; set; }
        int Cash { get; set; }
        int Nature { get; set; }
        int pbPokeLocX { get; set; }
        int pbPokeLocY { get; set; }
        int PokeLevelMax { get; set; }
        int PokeLevelMin { get; set; }
        int Progress { get; set; }
        int Dots { get; set; }
        //===========================================================================================================
        bool canLegendary { get; set;}
        bool canItems { get; set; }
        bool canShiny { get; set; }
        bool forceShiny { get; set; }
        bool onItem2 { get; set; }
        bool onLoot { get; set; }
        bool isShiny { get; set; }
        bool dragging { get; set; }
        bool hasScanned { get; set; }
        bool isScanning { get; set; }
        bool queueFinished { get; set; }
        bool viewingLoot { get; set; }
        bool appendList { get; set; }
        bool saveResult { get; set; }
        //===========================================================================================================
        string typeShiny { get; set; }
        string newShiny { get; set; }
        string PokeName { get; set; }
        string PokeType { get; set; }
        string PokeHabitat { get; set; }
        string PokeStage { get; set; }
        string saveFilePath { get; set; }
        //===========================================================================================================
        string[] info { get; set; }
        //===========================================================================================================

        //===========================================================================================================
        //=== FormScan is the Generation Form. It contains functions that allow it to be repositioned on the screen==
        //===========================================================================================================
        public FormScan()
        {
            InitializeComponent();
            rtbGasp.Text = "";
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeft.png");
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRight.png");
            onItem2 = false;
            onLoot = false;
            isShiny = false;
            dragging = false;
            hasScanned = false;
            isScanning = false;
            queueFinished = false;
            viewingLoot = false;
            Page = 1;
            Current = 0;
            Amount = 0;
            Cash = 0;
            Dots = 0;
            pbPokeLocX = pbPokemon.Location.X;
            pbPokeLocY = pbPokemon.Location.Y;
            ScanUpdate();
            typeList = typeXML.createList("Types", "Type");
            habitatList = habitatXML.createList("Habitats", "Habitat");
            natureList = natureXML.createList("Natures", "Nature");
            updateList.Add("updating...");
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
            cbHabitat.DataSource = habitats;
            cbType.DataSource = types;
            lbPokemon.DataSource = pokeDex;
            stages.Add("Any");
            stages.Add("Only 1s");
            stages.Add("Only 2s");
            stages.Add("Only 3s");
            stages.Add("1s & 2s");
            stages.Add("1s & 3s");
            stages.Add("2s & 3s");
            cbStageAllowed.DataSource = stages;
            for (int i = 1; i <= optionsList[0].MaxItemTier; i++ )
            {
                for (int p = optionsList[0].MaxItemTier - (i - 1); p > 0; p--)
                {
                    ItemTiers.Add(i);
                }
            }
            btnExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
            btnInfoBack.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeft.png");
            btnInfoForward.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRight.png");
            btnScan.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ChangeMode.png");
            btnScanPokemon.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemon.png");
            btnLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLoot.png");
            btnLootRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootView.png");
            btnPokeRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokeView.png");
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeft.png");
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRight.png");
            btnDealDamage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealDamage.png");
            btnOptions.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Options.png");
            btnCry.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Cry.png");
            chkAppend.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            chkHasItem.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            chkCanBeShiny.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            chkCanBeLegend.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            btnSave.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Save.png"));
            PokeSaveDialog.Filter = "Text File | *.txt";
            chkForceShiny.Enabled = false;
            nudLevelMin.Value = 2;
            nudLevelMax.Value = 15;
        }

        //===========================================================================================================
        //===ScanUpdate is used to update all of the lists that are called on this page to enforce any new Options == 
        //===== changes made by the user. ===========================================================================
        //===========================================================================================================
        private void ScanUpdate()
        {
            pokeList = new List<Pokemon>();
            optionsList = new List<Options>();
            regionList = new List<PokeRegion>();
            spawnList = new List<PokeRegion>();
            banList = new List<string>();
            pokeDex = new List<string>();
            regionList = regionXML.createList();
            spawnList = spawnXML.createList();
            pokeList = pokeXML.createList();
            optionsList = optionsXML.createList();
            banList = banXML.createList();
            this.BackgroundImage = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MainMenu" + optionsList[0].PokedexSkin + ".PNG");
            for (int p = 0; p < pokeList.Count; p++)
            {
                if (banList.Contains(pokeList[p].id))
                {
                    pokeList.RemoveAt(p);
                    p--;
                }
            }
            SortPokemon(pokeList);
            pokeDex.Clear();
            pokeDex.Add("Any");
            for (var p = 0; p < pokeList.Count; p++)
            {
                pokeDex.Add(pokeList[p].id);
            }
            regions.Clear();
            regions.Add("Any");
            for (var r = 0; r < regionList.Count; r++)
            {
                regions.Add(regionList[r].RegionName);
            }
            lbPokemon.DataSource = banList;
            cbRegion.DataSource = banList;
            lbPokemon.DataSource = pokeDex;
            cbRegion.DataSource = regions;
            nudAmount.Maximum = optionsList[0].MaxScanAmount;
            nudLevelMax.Maximum = optionsList[0].MaxPokemonLevel;
            nudLevelMin.Maximum = optionsList[0].MaxPokemonLevel;
            nudPlayerLevel.Maximum = optionsList[0].MaxPlayerLevel;
        }

        //===========================================================================================================
        //=== PokeGenerator it the backgroundworker used to generate the list of pokemon you will view. Its progress=
        //===== changed function is used to update the progress bar and progress label in the form. =================
        //===========================================================================================================
        private void PokeGenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            hasScanned = true;
            if (!pokeDex.Contains(PokeName)) { MessageBox.Show("That is not a Pokemon."); return; }
            if (!types.Contains(PokeType)) { MessageBox.Show("That is not a Type."); return; }
            if (!habitats.Contains(PokeHabitat)) { MessageBox.Show("That is not a Habitat."); return; }
            if (!stages.Contains(PokeStage)) { MessageBox.Show("That is not a Evolutionary Stage."); return; }
            if (appendList)
            {
                Current = AllPokemon.Count;
            }
            else
            {
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
                AllShinyCheck.Clear();
                Info.Clear();
                Gender.Clear();
                Type.Clear();
                MaxHealth.Clear();
                CurrentHealth.Clear();
                Current = 0;
            }
            Progress = 0;
            CreateScanList();
            queueFinished = true;
            for (var z = 0; z < Amount; z++)
            {
                IChooseYou = new Pokemon();
                Pokemon Final = new Pokemon();
                preInfo.Clear();
                isShiny = false;
                Final = GetPokemon();
                if (Final == null) return;
                int Level = GetLevel();
                int i = rng.Next(1, 101);
                if (!canShiny) i = 50;
                else if (forceShiny) i = 1;
                if (i == 1 || i == 100)
                {
                    preInfo.Add(optionsList[0].ShinyGasp);
                    isShiny = true;
                    GetShiny(Final);
                    Type.Add(newShiny);
                    AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + Final.number + ".gif"));
                }
                else
                {
                    preInfo.Add(optionsList[0].PokemonGasp);
                    AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + Final.number + ".gif"));
                    Type.Add(Final.type);
                }
                if (chkHasItem.Checked)
                {
                    GetItem();
                }
                else
                {
                    AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                    AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                    AllDesc1.Add("Nothing is here.");
                    AllDesc2.Add("Nothing is here.");
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
                AllShinyCheck.Add(isShiny);
                Current++;
                Progress++;
                PokeGenerator.ReportProgress(Progress);
            }
        }

        //===========================================================================================================
        //=== WHen the Background Worker is done, this will run to finish the UI update. ============================
        //===========================================================================================================
        private void PokeGenerator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Current = 0;
            try { pbPokemon.Image = AllImages[Current]; } catch { return; }
            SetPoke();
            UpdatePage();
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            SetGasp();
            isScanning = false;
        }

        //===========================================================================================================
        //=== Used to update the progress bar and t any other UI element during the scannign process. ===============
        //===========================================================================================================
        private void PokeGenerator_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!queueFinished)
            {
                Dots += e.ProgressPercentage;
                if (Dots >= 30) { Dots = 0; }
                if (Dots <= 9) { lblProgress.Text = "Queuing Scan.  "; } 
                else if (Dots <= 19) { lblProgress.Text = "Queuing Scan.. "; }
                else if (Dots <= 29) { lblProgress.Text = "Queuing Scan..."; }
            }
            else
            {
                prbGenerationProgress.Value = e.ProgressPercentage;
                lblProgress.Text = e.ProgressPercentage.ToString() + "/" + Amount.ToString() + " Complete";
            }
        }

        //===========================================================================================================
        //=== CreateScanList is used to create and filter the list that is requested in the comboboxes and ==========
        //===== check boxes of FormScan. ============================================================================
        //===========================================================================================================
        private void CreateScanList()
        {
            pokeList = new List<Pokemon>();
            pokeList = pokeXML.createList();
            banList = banXML.createList();
            for (int p = 0; p < pokeList.Count; p++)
            {
                if (banList.Contains(pokeList[p].id))
                {
                    pokeList.RemoveAt(p);
                    p--;
                }
                if (!lbPokemon.Items.Contains(pokeList[p].id))
                {
                    pokeList.RemoveAt(p);
                    p--;
                }
            }
            if (PokeName == "Any")
            {
                CheckEvo();
                CheckHabitat();
                CheckType();
                CheckLegend();
            }
        }

        //===========================================================================================================
        //=== CheckEvo is used to sort out the Evolution Stages that the user has stated they would like to generate=
        //===== from the ones they would like removed. ==============================================================
        //===========================================================================================================
        private void CheckEvo()
        {
            if (PokeStage != "Any")
            {
                List < string > stageAllow = new List<string>();
                if (PokeStage == "Only 1s")
                {
                    stageAllow.Add("1");
                    goto OnlyOne;
                }
                if (PokeStage == "Only 2s")
                {
                    stageAllow.Add("2");
                    goto OnlyOne;
                }
                if (PokeStage == "Only 3s")
                {
                    stageAllow.Add("3");
                    goto OnlyOne;
                }
                if (PokeStage == "1s & 2s")
                {
                    stageAllow.Add("1");
                    stageAllow.Add("2");
                    goto TwoStages;
                }
                if (PokeStage == "1s & 3s")
                {
                    stageAllow.Add("1");
                    stageAllow.Add("3");
                    goto TwoStages;
                }
                if (PokeStage == "2s & 3s")
                {
                    stageAllow.Add("2");
                    stageAllow.Add("3");
                    goto TwoStages;
                }
                OnlyOne:
                for (var e = 0; e < pokeList.Count; e++)
                {
                    PokeGenerator.ReportProgress(1);
                    if (pokeList[e].stage != stageAllow[0])
                    {
                        pokeList.RemoveAt(e);
                        e -= 1;
                    }
                }
                return;
                TwoStages:
                for (var e = 0; e < pokeList.Count; e++)
                {
                    PokeGenerator.ReportProgress(1);
                    if (pokeList[e].stage != stageAllow[0] || pokeList[e].stage != stageAllow[1])
                    {
                        pokeList.RemoveAt(e);
                        e -= 1;
                    }
                }
                return;
            }
            else
            {
                return;
            }
        }

        //===========================================================================================================
        //=== CheckHabitat is used to remove all pokemon from the generation criteria that do not live in the =======
        //===== user specified habitat. =============================================================================
        //===========================================================================================================
        private void CheckHabitat()
        {
            if (PokeHabitat != "Any")
            {
                for (var e = 0; e < pokeList.Count; e++)
                {
                    PokeGenerator.ReportProgress(1);
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

        //===========================================================================================================
        //=== CheckType is used to remove all types excpet the type specified by the user. ==========================
        //===========================================================================================================
        private void CheckType()
        {
            if ( PokeType == "Any") { return; }
            for (var e = 0; e < pokeList.Count; e++)
            {
                PokeGenerator.ReportProgress(1);
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

        //===========================================================================================================
        //=== CheckLegend is used to remove legendaries from the generation list, unless the legendary check box is==
        //===== checked in the form.=================================================================================
        //===========================================================================================================
        private void CheckLegend()
        {
            if (PokeName == "Any")
            {
                if (!chkCanBeLegend.Checked)
                {
                    for (var l = 0; l < pokeList.Count; l++)
                    {
                        PokeGenerator.ReportProgress(1);
                        if (pokeList[l].legendary == "true")
                        {
                            pokeList.RemoveAt(l);
                            l -= 1;
                        }
                    }
                }
            }
        }

        //===========================================================================================================
        //=== GetPokemon is used to search the list for the specified pokemon, or search the list for a random ======
        //===== Pokemon left over after Habitats, Types, and Stages are sorted. =====================================
        //===========================================================================================================
        private Pokemon GetPokemon()
        {
            int i;
            if (PokeName != "Any")
            {
                Pokemon find = pokeList.Find(x => x.id == PokeName);
                return find;
            }
            else
            {
                i = rng.Next(0, pokeList.Count);
                try { return pokeList[i]; } catch { MessageBox.Show("There are no registered Pokemon that fit this criteria..."); return null; }
            }
        }

        //===========================================================================================================
        //=== GetLevel does just that. Generates a random level between the Minimum and Maximum integer specified ===
        //===== in the Form before scanning. ========================================================================
        //===========================================================================================================
        private int GetLevel()
        {
            int min = Convert.ToInt32(nudLevelMin.Value);
            int max = Convert.ToInt32(nudLevelMax.Value + 1);
            int i = rng.Next(min, max);
            return i;
        }

        //===========================================================================================================
        //=== GetCap generates a list of capabilities based on the pokemon selected in GetPokemon. ==================
        //===========================================================================================================
        private void GetCap(Pokemon poke)
        {
            Cap = new List<string>();
            capList = capXML.createList(poke.number);
            foreach (Capability cap in capList)
            {
                Cap.Add(cap.cap);
            }
        }

        //===========================================================================================================
        //==== GetStats creates a list of stats based on the Pokemon selected in GetPokemon, takes those stats, =====
        //===== calls to generat andadd nature stats, and levels up the stats to the level generated in GetLevel. ===
        //===========================================================================================================
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
            try { hp = Convert.ToInt32(poke.hp); } catch { MessageBox.Show(poke.id + "'s hp is not a proper " +
                "integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer " +
                "inspet the issue."); hp = 1; return; }
            try { atk = Convert.ToInt32(poke.atk); } catch { MessageBox.Show(poke.id + "'s atk is not a proper " +
                "integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer " + 
                "inspet the issue."); atk = 1; return; }
            try { def = Convert.ToInt32(poke.def); } catch { MessageBox.Show(poke.id + "'s def is not a proper " +
                "integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer " +
                "inspet the issue."); def = 1; return; }
            try { spatk = Convert.ToInt32(poke.spatk); } catch { MessageBox.Show(poke.id + "'s spatk is not a proper " +
                "integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the " +
                "issue."); spatk = 1; return; }
            try { spdef = Convert.ToInt32(poke.spdef); } catch { MessageBox.Show(poke.id + "'s spdef is not a proper " +
                "integer. Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the " +
                "issue."); spdef = 1; return; }
            try { spd = Convert.ToInt32(poke.spd); } catch { MessageBox.Show(poke.id + "'s spd is not a proper integer. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the " +
                "issue."); spd = 1; return; }
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

        //===========================================================================================================
        //=== GetNature is called in GetStats in order to randomly select a nature for the pokemon and apply the ====
        //===== appropriate stat bonuses to send back to GetStats. ==================================================
        //===========================================================================================================
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

        //===========================================================================================================
        //=== GetGender takes the gender ratio from the Pokemon generated and converts it into an integer in order ==
        //===== to roll the given percent to decide Male or Female. Also, key phrases are given below for if the ====
        //===== given Pokemon is genderless. ========================================================================
        //===========================================================================================================
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
                try { gender = poke.gender.Split(' '); } catch { MessageBox.Show(poke.id + "'s Gender Ratio is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue.");
                    Gender.Add("!ERROR!"); return poke; }
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
                try { male = Convert.ToInt32(m); } catch { MessageBox.Show(poke.id + "'s Gender Ratio is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue.");
                    Gender.Add("!ERROR!"); return poke; }
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

        //===========================================================================================================
        //=== GetAbilities generates abilities from the Pokemon selected in GetPokemon based on their level. ======== 
        //===========================================================================================================
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

        //===========================================================================================================
        //=== GetHealth applies the formula to turn HP and Level into Health. =======================================
        //===========================================================================================================
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
            try { temp = Convert.ToInt32(up2[1]); } catch { MessageBox.Show(IChooseYou.id + "'s Skill is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return "ERROR"; }
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
            try { temp = Convert.ToInt32(up2[1]); } catch { MessageBox.Show(IChooseYou.id + "'s Skill is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue."); return "ERROR"; }
            int fin = temp - 1;
            build.Append(up2[0] + " " + fin + "d" + up1[1]);
            return build.ToString();
        }

        //===========================================================================================================
        //=== GetSkills is used to apply the random skill variant to generated Pokemon. =============================
        //===========================================================================================================
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

        //===========================================================================================================
        //=== GetMoves is used to check the Pokemon's level against its Level learned Move List and remove the ======
        //===== oldest one to make room for new ones, after the Pokemon reaches 6 total moves known. ================
        //===========================================================================================================
        private void GetMoves()
        {
            int i = TrueLevel;
            moveXML = new MovesList();
            moves = new List<string>();
            moveList.Clear();
            moveList = moveXML.createList(IChooseYou.number);
            StringBuilder build = new StringBuilder();
            for (var e = 0; e < moveList.Count; e++)
            {
                string[] moveLevel = moveList[e].move.Split(' ');
                int lvl;
                try { lvl = Convert.ToInt32(moveLevel[0]); } catch { MessageBox.Show(IChooseYou.id + "'s Move is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue.   '" + moveList[e].move + 
                "'"); moves.Add("!ERROR!"); return; }
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

        //===========================================================================================================
        //=== GetShiny is ran if the pokemon is determined to be shiny. If so, it adds a type to the Pokemon and ====
        //===== teaches them a random move of that type. This adds a greater variance of what a shiny can be. If ====
        //===== the Pokemon has two types, then the second one is replaced. =========================================
        //===========================================================================================================
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

        //===========================================================================================================
        //=== GetItem is used to determine if the Pokemon generates with items or not. This only occurs if the ======
        //===== Items Checkbox is checked in the Form. ==============================================================
        //===========================================================================================================
        private void GetItem()
        {
            onItem2 = false;
            int i = rng.Next(1, 101);
            if (i < 25)
            {
                GetItem1(); 
            }
            else
            {
                AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllDesc1.Add("Nothing is here.");
                AllDesc2.Add("Nothing is here.");
                return;
            }
        }

        //===========================================================================================================
        //=== GetItem1 rolls to determine what tier the first item held by the Pokemon is, and to determine if the ==
        //===== Pokemon is holding a second item or not. ============================================================
        //===========================================================================================================
        private void GetItem1()
        {
            int i = rng.Next(ItemTiers.Count);
            ItemGenByTier(ItemTiers[i]);
            i = rng.Next(1, 11);
            if (i == 10)
            {
                preInfo.Add(optionsList[0].TwoItemGasp);
                onItem2 = true;
                GetItem2();
            }
            else
            {
                preInfo.Add(optionsList[0].OneItemGasp);
                AllItems2.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                AllDesc2.Add("Nothing is here.");
            }
        }

        //===========================================================================================================
        //=== GetItems2 is used to determine what tier the second item held by the Pokemon is. ======================
        //===========================================================================================================
        private void GetItem2()
        {
            int i = rng.Next(ItemTiers.Count);
            ItemGenByTier(ItemTiers[i]);
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //=== ItemGenByTier is used to determine what item is going to be placed in Item1 or Item2 using the tier ===
        //===== generated in GetItem1 or GetItem2. This is also used in the GetLoot function. =======================
        //===========================================================================================================
        private void ItemGenByTier(int tier)
        {
            itemList = itemXML.createList(tier.ToString());
            int i = rng.Next(0, itemList.Count);
            if (itemList.Count == 0)
            {
                if (tier == 1)
                    ItemGenByTier(optionsList[0].MaxItemTier);
                else
                    ItemGenByTier(tier - 1);
            }
            if (!onLoot)
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

        //===========================================================================================================
        //=== SetGasp gathers the lines from the Info list generated along with each Pokemon and writes it out into =
        //===== the Gasp textbox in the Form. =======================================================================
        //===========================================================================================================
        private void SetGasp()
        {
            rtbGasp.Text = "";
            foreach (string s in Info[Current])
            {
                rtbGasp.Text += s + Environment.NewLine;
            }
            Regex name = new Regex("~p");
            string result = name.Replace(rtbGasp.Text, AllPokemon[Current].id);
            rtbGasp.Text = result;
        }

        //===========================================================================================================
        //=== SortStats is used to order the Stats in GetStats from highest to lowest in order to keep the Base =====
        //===== Stat Relation when increasing them to match the Pokemon's Level. ====================================
        //===========================================================================================================
        private void SortStats(List<Stat> stats)
        {
            stats.Sort(delegate (Stat x, Stat y)
            {
                return y.stat.CompareTo(x.stat);
            });
        }

        //===========================================================================================================
        //=== Sort Pokemon is used to sort Pokemon by their number, lowest to higherst. This is so that the Pokemon =
        //===== Combobox is in the correct order for a Pokedex. =====================================================
        //===========================================================================================================
        private void SortPokemon(List<Pokemon> stats)
        {
            stats.Sort(delegate (Pokemon x, Pokemon y)
            {
                return x.number.CompareTo(y.number);
            });
        }

        //===========================================================================================================
        //=== GetImage is used to check to see if the image requested actually exists. If it does not, it is then ===
        //===== replaced with teh MissingNo image. ==================================================================
        //===========================================================================================================
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

        //===========================================================================================================
        //=== SetImage is used to set the Pokemon Image in the correct place to keep it centered based on the =======
        //===== varying size of the image. ==========================================================================
        //===========================================================================================================
        private void SetPoke()
        {
            pbPokemon.Size = pbPokemon.Image.Size;
            pbPokemon.Location = new Point(233 - (pbPokemon.Width / 2), 250 - (pbPokemon.Height));
        }

        //===========================================================================================================
        //=== SetItem is used to set the Item Image in the correct place to keep it centered based on the varying ===
        //===== size of the image. ==================================================================================
        //===========================================================================================================
        private void SetItem()
        {
            pkItem.Size = pkItem.Image.Size;
            pkItem.Location = new Point(939 - (pkItem.Width / 2), 578 - (pkItem.Height));
        }

        //===========================================================================================================
        //=== WriteInfo is used to write the Pokemon's info onto Page One of the Scanned Pokemon. ===================
        //===========================================================================================================
        private void WriteInfo()
        {
            viewingLoot = false;
            pkItem.Visible = false;
            if (AllShinyCheck[Current])
            {
                rtbInfo.Text = "Name: Shiny " + AllPokemon[Current].id + Environment.NewLine;
            }
            else
            {
                rtbInfo.Text = "Name: " + AllPokemon[Current].id + Environment.NewLine;
            }
            rtbInfo.Text += "Type: " + Type[Current] + Environment.NewLine +
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
                rtbInfo.Text += cap + Environment.NewLine;
            }

        }

        //===========================================================================================================
        //=== WriteMoves is used to write the Gender, Nature, Size, Weight, Abilites, Skills, and Moves of the ======
        //===== current Pokemon on Page Two. ========================================================================
        //===========================================================================================================
        private void WriteMoves()
        {
            viewingLoot = false;
            pkItem.Visible = false;
            rtbInfo.Text = "Gender: " + Gender[Current] + Environment.NewLine +
                "Nature: " + AllNatures[Current] + Environment.NewLine +
                "Size: " + AllPokemon[Current].size + Environment.NewLine +
                "Weight: " + AllPokemon[Current].weight + Environment.NewLine;
            rtbInfo.Text += (Environment.NewLine + "Moves:" + Environment.NewLine);
            for (var w = 0; w < AllMoves[Current].Count; w++)
            {
                rtbInfo.Text += "-" + AllMoves[Current][w] + Environment.NewLine;
            }
            rtbInfo.Text += Environment.NewLine + "Abilities:" + Environment.NewLine;
            for (var a = 0; a < AllAbilities[Current].Count; a++)
            {
                rtbInfo.Text += "-" + AllAbilities[Current][a] + Environment.NewLine;
            }
            rtbInfo.Text += Environment.NewLine + "Skills:";
            for (var s = 0; s < AllSkills[Current].Count; s++)
            {
                rtbInfo.Text += Environment.NewLine + "-" + AllSkills[Current][s];
            }
        }

        //===========================================================================================================
        //=== WriteItem1 is used to write out the Name, Description, and place the Image of the Item rolled for =====
        //===== Slot 1. =============================================================================================
        //===========================================================================================================
        private void WriteItem1()
        {
            viewingLoot = false;
            pkItem.Visible = true;
            pkItem.Image = AllItems1[Current];
            SetItem();
            rtbInfo.Text = "Item 1-" + Environment.NewLine +
                AllDesc1[Current];
        }

        //===========================================================================================================
        //=== WriteItem2 is used to write out the Name, Description, and place the Image of the Item rolled for =====
        //===== Slot 2. =============================================================================================
        //===========================================================================================================
        private void WriteItem2()
        {
            viewingLoot = false;
            pkItem.Visible = true;
            pkItem.Image = AllItems2[Current];
            SetItem();
            rtbInfo.Text = "Item 2-" + Environment.NewLine +
                AllDesc2[Current];

        }

        //===========================================================================================================
        //=== WriteLoot is used in the Loot Scannign process in order to Write the loot over the shown page in the ==
        //===== FormScan form. ======================================================================================
        //===========================================================================================================
        private void WriteLoot()
        {
            tbPageCount.Text = "----";
            viewingLoot = true;
            pkItem.Visible = false;
            rtbInfo.Clear();
            for (int x = 0; x < AllDesc3.Count; x++)
            {
                rtbInfo.Text += AllDesc3[x] + Environment.NewLine + Environment.NewLine;
            }
            rtbInfo.Text += "$" + Cash.ToString();
        }

        //===========================================================================================================
        //=== UpdatePage is used to ensure that the correct info is written onto the current selected page. =========
        //===== Whether this is to change the Pokemon or change the page on the current Pokemon, this is the ========
        //===== fuction that is called. =============================================================================
        //===========================================================================================================
        private void UpdatePage()
        {
            tbPageCount.Text = Page + "/4";
            if (Page == 1) { WriteInfo(); }
            if (Page == 2) { WriteMoves(); }
            if (Page == 3) { WriteItem1(); }
            if (Page == 4) { WriteItem2(); }
        }

        //===========================================================================================================
        //=== GetLoot is used to generate loot for the players based off the level specified in the form. This uses =
        //===== the GetItem2 function in order to save lines of code. ===============================================
        //===========================================================================================================
        private void GetLoot()
        {
            pkItem.Visible = false;
            AllDesc3.Clear();
            rtbInfo.Clear();
            int val = Convert.ToInt32(nudPlayerLevel.Value);
            Cash = 0;
            onLoot = true;
            for (int x = 0; x < val; x++)
            {
                int i = rng.Next(1, 4);
                if (i == 1)
                    GetItem2();
                else
                    Cash += rng.Next(1, 6) * optionsList[0].CashPerLevel;
            }
            onLoot = false;
            WriteLoot();
        }

        //===========================================================================================================
        //=== Checks the "Checked" State of the passed in CheckBox and changes it.===================================
        //===========================================================================================================
        private void CheckedState(CheckBox cb)
        {
            if (cb.Checked)
                cb.Checked = false;
            else
                cb.Checked = true;
        }

        //===========================================================================================================
        //=== This is the background worker for the save function, that allows the players to save their scan as a ==
        //===== text file that they can view later on. ==============================================================
        //===========================================================================================================
        private void PokeSaveScan_DoWork(object sender, DoWorkEventArgs e)
        {
            if (saveResult == true)
            {
                System.IO.Stream fileStream = PokeSaveDialog.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                sw.WriteLine("Pokemon List");
                sw.WriteLine("ΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦΦ");
                for (int i = 0; i < AllPokemon.Count; i++)
                {
                    sw.WriteLine("~" + (i + 1).ToString() + "~" + Environment.NewLine);
                    if (AllShinyCheck[i])
                    {
                        sw.WriteLine("Name: Shiny " + AllPokemon[i].id);
                    }
                    else
                    {
                        sw.WriteLine("Name: " + AllPokemon[i].id);
                    }
                    sw.WriteLine("Type: " + Type[i] + Environment.NewLine +
                        "Gender: " + Gender[i] + Environment.NewLine +
                        "Nature: " + AllNatures[i] + Environment.NewLine +
                        "Size: " + AllPokemon[i].size + Environment.NewLine +
                        "Weight: " + AllPokemon[i].weight + Environment.NewLine +
                        "Level: " + AllLevels[i] + Environment.NewLine +
                        Environment.NewLine +
                        "Stats:" + Environment.NewLine +
                        "Current Health:\t " + CurrentHealth[i] + Environment.NewLine +
                        "Max Health:\t " + MaxHealth[i] + Environment.NewLine +
                        "HP:\t\t " + AllStat[i][0] + Environment.NewLine +
                        "ATK:\t\t " + AllStat[i][1] + Environment.NewLine +
                        "DEF:\t\t " + AllStat[i][2] + Environment.NewLine +
                        "SPATK:\t\t " + AllStat[i][3] + Environment.NewLine +
                        "SPDEF:\t\t " + AllStat[i][4] + Environment.NewLine +
                        "SPD:\t\t " + AllStat[i][5] + Environment.NewLine +
                        Environment.NewLine +
                        "Capabilities:");
                    foreach (string cap in AllCap[i])
                    {
                        sw.WriteLine(cap);
                    }
                    sw.WriteLine(Environment.NewLine + "Moves:");
                    for (var w = 0; w < AllMoves[i].Count; w++)
                    {
                        sw.WriteLine("-" + AllMoves[i][w]);
                    }
                    sw.WriteLine(Environment.NewLine + "Abilities:");
                    for (var a = 0; a < AllAbilities[i].Count; a++)
                    {
                        sw.WriteLine("-" + AllAbilities[i][a]);
                    }
                    sw.WriteLine(Environment.NewLine + "Skills:");
                    for (var s = 0; s < AllSkills[i].Count; s++)
                    {
                        sw.WriteLine("-" + AllSkills[i][s]);
                    }
                    sw.WriteLine(Environment.NewLine + "Item 1-" + Environment.NewLine + AllDesc1[i]);
                    sw.WriteLine(Environment.NewLine + "Item 2-" + Environment.NewLine + AllDesc2[i]);
                    sw.WriteLine(Environment.NewLine + "------------------------------------------------------------------------------------------");
                    PokeSaveScan.ReportProgress(1);
                }
                sw.WriteLine(Environment.NewLine + "Loot List");
                sw.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                for (int x = 0; x < AllDesc3.Count; x++)
                {
                    sw.WriteLine(AllDesc3[x] + Environment.NewLine);
                }
                sw.WriteLine("$" + Cash.ToString());
                sw.Flush();
                sw.Close();
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void PokeSaveScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProgress.Text = "Save Complete";
            DialogResult openSave = MessageBox.Show("Save Complete, Would you like to view the document now?", "Open Saved File?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (openSave == DialogResult.Yes)
            {
                Process.Start("notepad.exe", saveFilePath);
                //File.Open(saveFilePath, FileMode.Open);
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void PokeSaveScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Dots += e.ProgressPercentage;
            if (Dots >= 30) { Dots = 0; }
            if (Dots <= 9) { lblProgress.Text = "Saving Scan.  "; }
            else if (Dots <= 19) { lblProgress.Text = "Saving Scan.. "; }
            else if (Dots <= 29) { lblProgress.Text = "Saving Scan..."; }
        }

        //===========================================================================================================
        //Used to register the mouse down on the Form Controll inorder to allow window placement. ===================
        //===========================================================================================================
        private void FormScan_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        //===========================================================================================================
        //=== Update teh window to know wher you have moved it to. ==================================================
        //===========================================================================================================
        private void FormScan_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        //===========================================================================================================
        //=== Tells the form that you have stopped positioning the window. ==========================================
        //===========================================================================================================
        private void FormScan_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        //===========================================================================================================
        //=== btnExit if the exit button at the top of this form. ====================================================
        //===========================================================================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //===========================================================================================================
        //=== pbScan is the button in the form that takes you back to the main Pokedex. =============================
        //===========================================================================================================
        private void btnScan_MouseHover(object sender, EventArgs e)
        {
            btnScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ChangeModeHover.png");
        }
        private void btnScan_MouseLeave(object sender, EventArgs e)
        {
            btnScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ChangeMode.png");
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            Owner.Show();
            this.Activated += fs_FormActive;
            Hide();
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void fs_FormActive(object sender, EventArgs e)
        {
            ScanUpdate();
        }

        //===========================================================================================================
        //=== pbScanPokemon is the Scan Pokemon button in the form. this is used to initiate the background worker ==
        //===== to create the new list of pokemon and clear out the old data. =======================================
        //===========================================================================================================
        private void btnScanPokemon_MouseHover(object sender, EventArgs e)
        {
            btnScanPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemonHover.png");
        }
        private void btnScanPokemon_MouseLeave(object sender, EventArgs e)
        {
            btnScanPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemon.png");
        }
        private void btnScanPokemon_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            queueFinished = false;
            isScanning = true;
            pkLevelMin_ValueChanged(this, new EventArgs());
            pkLevelMax_ValueChanged(this, new EventArgs());
            PokeName = lbPokemon.SelectedItem.ToString();
            PokeHabitat = cbHabitat.Text;
            PokeType = cbType.Text;
            PokeStage = cbStageAllowed.Text;
            PokeLevelMax = Convert.ToInt32(nudLevelMax.Value);
            PokeLevelMin = Convert.ToInt32(nudLevelMin.Value);
            Amount = Convert.ToInt32(nudAmount.Value);
            prbGenerationProgress.Maximum = Amount;
            canItems = chkHasItem.Checked;
            canLegendary = chkCanBeLegend.Checked;
            canShiny = chkCanBeShiny.Checked;
            forceShiny = chkForceShiny.Checked;
            appendList = chkAppend.Checked;
            lblProgress.Text = "Queuing Scan";
            PokeGenerator.RunWorkerAsync();
        }

        //===========================================================================================================
        //=== Used to change the Info page to the next lower number, or complete the circle back to the highest. ====
        //===========================================================================================================
        private void btnInfoBack_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (viewingLoot) return;
            if (!hasScanned) return;
            Page--;
            if (Page == 0) { Page = 4; }
            UpdatePage();
        }

        //===========================================================================================================
        //=== Used to change the Info page to the next highert number, or complete the circle bakc to the lowest. ===
        //===========================================================================================================
        private void btnInfoForward_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (viewingLoot) return;
            if (!hasScanned) return;
            Page++;
            if (Page == 5) { Page = 1; }
            UpdatePage();
        }

        //===========================================================================================================
        //=== Determines if the Minimum level is higher than the Maximum, and if so set Max to Min. =================
        //===========================================================================================================
        private void pkLevelMin_ValueChanged(object sender, EventArgs e)
        {
            if (nudLevelMin.Value > nudLevelMax.Value) { nudLevelMax.Value = nudLevelMin.Value; }
        }

        //===========================================================================================================
        //=== Determins if the Maximum is lower than the minimum, and if so sets Min to Max. ========================
        //===========================================================================================================
        private void pkLevelMax_ValueChanged(object sender, EventArgs e)
        {
            if (nudLevelMax.Value < nudLevelMin.Value) { nudLevelMin.Value = nudLevelMax.Value; }
        }

        //===========================================================================================================
        //=== Checkes when the selected pokemon changes to see if it is still "Any". If not, to disable unneeded ====
        //===== checks in the queue. ================================================================================ 
        //===========================================================================================================
        private void lbPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPokemon.SelectedItem.ToString() != "Any")
            {
                cbHabitat.Enabled = false;
                cbType.Enabled = false;
                chkCanBeLegend.Enabled = false;
                cbStageAllowed.Enabled = false;
            }
            else
            {
                cbHabitat.Enabled = true;
                cbType.Enabled = true;
                chkCanBeLegend.Enabled = true;
                cbStageAllowed.Enabled = true;
            }
        }

        //===========================================================================================================
        //=== Used to switch between the pokemon in the current generation list. ====================================
        //===========================================================================================================
        private void pbPokeLeft_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (AllPokemon.Count < 2) return;
            if (Current <= 0)
            {
                Current = AllPokemon.Count - 1;
            }
            else
            {
                Current--;
            }
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            pbPokemon.Image = AllImages[Current];
            SetPoke();
            SetGasp();
            UpdatePage();
        }
        private void pbPokeRight_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (AllPokemon.Count < 2) return;
            if (Current >= AllPokemon.Count - 1)
            {
                Current = 0;
            }
            else
            {
                Current++;
            }
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            pbPokemon.Image = AllImages[Current];
            SetPoke();
            SetGasp();
            UpdatePage();
        }
        private void btnPokeRight_MouseHover(object sender, EventArgs e)
        {
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRightHover.png");
        }
        private void btnPokeRight_MouseLeave(object sender, EventArgs e)
        {
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRight.png");
        }

        private void btnPokeLeft_MouseHover(object sender, EventArgs e)
        {
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeftHover.png");
        }
        private void btnPokeLeft_MouseLeave(object sender, EventArgs e)
        {
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeft.png");
        }

        //===========================================================================================================
        //=== Calls the GetLoot function from above. This allows the player to have a loot table for their current ==
        //===== Scene without leaving the generator. ================================================================
        //===========================================================================================================
        private void pbLoot_Click(object sender, EventArgs e)
        {
            GetLoot();
        }

        //===========================================================================================================
        //=== Switches from loot to view the pokemon stats. =========================================================
        //===========================================================================================================
        private void pbPokeRefresh_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (hasScanned)
            {
                btnInfoForward.Visible = true;
                btnInfoBack.Visible = true;
                UpdatePage();
            }
        }

        //===========================================================================================================
        //=== Switches from the Pokemon Stats to view the Loot. =====================================================
        //===========================================================================================================
        private void pbLootRefresh_Click(object sender, EventArgs e)
        {
            if (isScanning) return;
            if (hasScanned)
            {
                WriteLoot();
            }
        }

        //===========================================================================================================
        //=== Updates the Loot button image in the UI.==============================================================
        //===========================================================================================================
        private void pbLoot_MouseHover(object sender, EventArgs e)
        {
            btnLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLootHover.png");
        }
        private void pbLoot_MouseLeave(object sender, EventArgs e)
        {
            btnLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLoot.png");
        }

        //===========================================================================================================
        //=== Updates the Pokemon View button in the UI.=============================================================
        //===========================================================================================================
        private void pbPokeRefresh_MouseHover(object sender, EventArgs e)
        {
            btnPokeRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokeViewHover.png");
        }
        private void pbPokeRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnPokeRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokeView.png");
        }

        //===========================================================================================================
        //=== Updates the Loot View button in the UI. ===============================================================
        //===========================================================================================================
        private void pbLootRefresh_MouseHover(object sender, EventArgs e)
        {
            btnLootRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootViewHover.png");
        }
        private void pbLootRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnLootRefresh.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootView.png");
        }

        //===========================================================================================================
        //=== Enables the User to just press enter when editing the Damage amount in order to click the Damage ======
        //===== in the Ui. ==========================================================================================
        //===========================================================================================================
        private void pkDamage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbDealDamage_Click(this, new EventArgs());
            }
        }

        //===========================================================================================================
        //=== Applies the damage in the Damage Amount NUD box to the current selected pokemon in the list. ==========
        //===========================================================================================================
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

        //===========================================================================================================
        //=== Updates the Deal Damage button in the UI. =============================================================
        //===========================================================================================================
        private void pbDealDamage_MouseHover(object sender, EventArgs e)
        {
            btnDealDamage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealDamageHover.png");
        }
        private void pbDealDamage_MouseLeave(object sender, EventArgs e)
        {
            btnDealDamage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealDamage.png");
        }

        //===========================================================================================================
        //=== Uses the CheckedState function to change HasItem when Enter is pressed while it is focused. ===========
        //===========================================================================================================
        private void pkHasItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkHasItem);
            }
        }

        //===========================================================================================================
        //=== Uses the CheckedState function to change CanBeShiny when Enter is pressed while it is focused. ========
        //===========================================================================================================
        private void pkCanBeShiny_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkCanBeShiny);
            }
        }

        //===========================================================================================================
        //=== Uses the CheckedState function to change CanBeLegend when Enter is pressed while it is focused. =======
        //===========================================================================================================
        private void pkCanBeLegend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkCanBeLegend);
            }
        }

        //===========================================================================================================
        //=== Updates the Exit button in the UI. ====================================================================
        //===========================================================================================================
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.png");
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }

        //===========================================================================================================
        //=== Opens FormOptions from FormScan, and creats a closing event to update after Options Edit. =============
        //===========================================================================================================
        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormOptions fc = new FormOptions();
            fc.FormClosing += FormOptionsIsClosing;
            fc.Show();
        }
        private void FormOptionsIsClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }
            this.Enabled = true;
            this.Show();
            ScanUpdate();
            this.Update();
        }

        //===========================================================================================================
        //=== Updates the Options Button in the UI. =================================================================
        //===========================================================================================================
        private void btnOptions_MouseHover(object sender, EventArgs e)
        {
            btnOptions.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\OptionsHover.png");
        }
        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            btnOptions.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Options.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnCry_Click(object sender, EventArgs e)
        {
            if (!hasScanned) return;
            if (isScanning) return;
            string s;
            if (optionsList[0].CryVolume != 10)
            {
                s = "0." + optionsList[0].CryVolume.ToString();
            }
            else
            {
                s = "1.0";
            }
            float f;
            Single.TryParse(s, out f);
            var CryOGG = new VorbisWaveReader(AppDomain.CurrentDomain.BaseDirectory + "Data\\Audio\\Empty.ogg");
            try { CryOGG = new VorbisWaveReader(AppDomain.CurrentDomain.BaseDirectory + "Data\\Audio\\Cries\\" + AllPokemon[Current].number + ".ogg"); } catch { MessageBox.Show(AllPokemon[Current].number + ".ogg does not exist."); }
            var CryPlay = new WaveOut();
            CryPlay.Init(CryOGG);
            CryPlay.Volume = f;
            CryPlay.Play();
        }

        private void btnCry_MouseHover(object sender, EventArgs e)
        {
            btnCry.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CryHover.png");
        }
        private void btnCry_MouseLeave(object sender, EventArgs e)
        {
            btnCry.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Cry.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                List<string> searchDex = new List<string>();
                searchDex.Clear();
                foreach (string s in pokeDex)
                {
                    if (s.StartsWith(tbSearch.Text, StringComparison.OrdinalIgnoreCase) == true)
                    {
                        searchDex.Add(s);
                    }
                }
                lbPokemon.DataSource = searchDex;
            }
            else
            {
                lbPokemon.DataSource = updateList;
                lbPokemon.DataSource = pokeDex;
            }
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                tbSearch.Text = "";
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkAppend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAppend.Checked)
            {
                chkAppend.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png"); 
            }
            else
            {
                chkAppend.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkHasItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHasItem.Checked)
            {
                chkHasItem.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
            }
            else
            {
                chkHasItem.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkCanBeShiny_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanBeShiny.Checked)
            {
                chkCanBeShiny.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                chkForceShiny.Enabled = true;
            }
            else
            {
                chkCanBeShiny.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                chkForceShiny.Enabled = false;
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkCanBeLegend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanBeLegend.Checked)
            {
                chkCanBeLegend.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
            }
            else
            {
                chkCanBeLegend.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkForceShiny_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForceShiny.Checked)
            {
                chkForceShiny.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
            }
            else
            {
                chkForceShiny.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
            }
        }

        //===========================================================================================================
        //=== Allows the user to double click a selected index in the list and scan pokemon that way ================
        //===========================================================================================================
        private void lbPokemon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isScanning) return;
            queueFinished = false;
            isScanning = true;
            pkLevelMin_ValueChanged(this, new EventArgs());
            pkLevelMax_ValueChanged(this, new EventArgs());
            PokeName = lbPokemon.SelectedItem.ToString();
            PokeHabitat = cbHabitat.Text;
            PokeType = cbType.Text;
            PokeStage = cbStageAllowed.Text;
            PokeLevelMax = Convert.ToInt32(nudLevelMax.Value);
            PokeLevelMin = Convert.ToInt32(nudLevelMin.Value);
            Amount = Convert.ToInt32(nudAmount.Value);
            prbGenerationProgress.Maximum = Amount;
            canItems = chkHasItem.Checked;
            canLegendary = chkCanBeLegend.Checked;
            canShiny = chkCanBeShiny.Checked;
            appendList = chkAppend.Checked;
            lblProgress.Text = "Queuing Scan";
            PokeGenerator.RunWorkerAsync();
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveResult = PokeSaveDialog.ShowDialog() == DialogResult.OK;
            if (!saveResult) return;
            saveFilePath = PokeSaveDialog.FileName;
            PokeSaveScan.RunWorkerAsync();
        }
        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\SaveHover.png");
        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Save.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRegion.Text == "Any")
            {
                lbPokemon.DataSource = pokeDex;
            }
            else
            {
                int selectRegion = 0;
                for (int r = 0; r < regionList.Count; r++)
                {
                    if (regionList[r].RegionName == cbRegion.Text)
                    {
                        selectRegion = r;
                        break;
                    }
                }
                regionPokemon = new List<string>();
                regionPokemon.Add("Any");
                foreach (string p in spawnList[selectRegion].Spawns)
                {
                    if(pokeDex.Contains(p))
                        regionPokemon.Add(p);
                }
                lbPokemon.DataSource = regionPokemon;
                nudLevelMax.Value = regionList[selectRegion].MaxLevel;
                nudLevelMin.Value = regionList[selectRegion].MinLevel;
            }
        }
    }
}
