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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Win32;

namespace GenesisDex
{
    public partial class FormScan : Form
    {
        //===========================================================================================================
        //=== Variables =============================================================================================
        //===========================================================================================================
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormScan));
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
        List<Pokemon> BasePokemon = new List<Pokemon>();
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
        List<Skill> skill = new List<Skill>();
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
        TypeList typeXML = new TypeList();
        List<Types> typeList = new List<Types>();
        //===========================================================================================================
        OptionsList optionsXML = new OptionsList();
        List<Options> optionsList = new List<Options>();
        //===========================================================================================================
        BanList banXML = new BanList();
        List<string> banList = new List<string>();
        //===========================================================================================================
        StatusList statusBool = new StatusList();
        List<StatusAfflictions> AllStatus = new List<StatusAfflictions>();
        //===========================================================================================================
        List<Image> AllItems1 = new List<Image>();
        List<Image> AllImages = new List<Image>();
        //===========================================================================================================
        InfoList moveinfoXML = new InfoList();
        List<PokeInfo> moveinfoList = new List<PokeInfo>();
        //===========================================================================================================
        InfoList skillinfoXML = new InfoList();
        List<PokeInfo> skillinfoList = new List<PokeInfo>();
        //===========================================================================================================
        InfoList capinfoXML = new InfoList();
        List<PokeInfo> capinfoList = new List<PokeInfo>();
        //===========================================================================================================
        InfoList abilityinfoXML = new InfoList();
        List<PokeInfo> abilityinfoList = new List<PokeInfo>();
        //===========================================================================================================
        List<int> AllLevels = new List<int>();
        List<int> ItemTiers = new List<int>();
        List<int> PokeTiers = new List<int>();
        //===========================================================================================================
        List<int[]> CombatStage = new List<int[]>();
        //===========================================================================================================
        List<decimal> MaxHealth = new List<decimal>();
        List<decimal> CurrentHealth = new List<decimal>();
        List<decimal> Injuries = new List<decimal>();
        //===========================================================================================================
        List<string> habitats = new List<string>();
        List<string> types = new List<string>();
        List<string> pokeDex = new List<string>();
        List<string> regions = new List<string>();
        List<string> natures = new List<string>();
        List<string> regionPokemon = new List<string>();
        List<string> moves = new List<string>();
        List<string> ability = new List<string>();
        List<string> stages = new List<string>();
        List<string> AllNatures = new List<string>();
        List<string> AllDesc1 = new List<string>();
        List<string> Gender = new List<string>();
        List<string> Stat = new List<string>();
        List<string> Cap = new List<string>();
        List<string> Type = new List<string>();
        List<string> updateList = new List<string>();
        //===========================================================================================================
        List<List<Skill>> AllSkills = new List<List<Skill>>();
        //===========================================================================================================
        List<List<string>> AllMoves = new List<List<string>>();
        List<List<string>> AllAbilities = new List<List<string>>();
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
        int PokeRegIndex { get; set; }
        int Progress { get; set; }
        int Dots { get; set; }
        int skillIndex { get; set; }
        int moveIndex { get; set; }
        int abilityIndex { get; set; }
        int capIndex { get; set; }
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
        bool importResult { get; set; }
        bool isWritingInfo { get; set; }
        //===========================================================================================================
        string typeShiny { get; set; }
        string newShiny { get; set; }
        string PokeName { get; set; }
        string PokeType { get; set; }
        string PokeHabitat { get; set; }
        string PokeStage { get; set; }
        string PokeNature { get; set; }
        string PokeReg { get; set; }
        string saveFilePath { get; set; }
        //===========================================================================================================
        string[] info { get; set; }
        //===========================================================================================================
        FormLoot fl;
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
            isShiny = false;
            dragging = false;
            hasScanned = false;
            isScanning = false;
            queueFinished = false;
            chkForceShiny.Enabled = false;
            Page = 1;
            Current = 0;
            Amount = 0;
            Cash = 0;
            Dots = 0;
            pbPokeLocX = pbPokemon.Location.X;
            pbPokeLocY = pbPokemon.Location.Y;
            ScanUpdate();
            typeList = typeXML.createList();
            habitatList = habitatXML.createList("Habitats", "Habitat");
            natureList = natureXML.createList("Natures", "Nature");
            skillinfoList = skillinfoXML.createList("Skills","Skill");
            moveinfoList = moveinfoXML.createList("Moves", "Move");
            capinfoList = capinfoXML.createList("Capabilities", "Capability");
            abilityinfoList = abilityinfoXML.createList("Abilities", "Ability");
            updateList.Add("updating...");
            habitats.Clear();
            types.Clear();
            natures.Clear();
            habitats.Add("Any");
            for (var h = 0; h < habitatList.Count; h++)
            {
                habitats.Add(habitatList[h].id);
            }
            types.Add("Any");
            for (var t = 0; t < typeList.Count; t++)
            {
                types.Add(typeList[t].name);
            }
            natures.Add("Any");
            for (var n = 0; n < natureList.Count; n++)
            {
                natures.Add(natureList[n].id);
            }
            cbHabitat.DataSource = habitats;
            cbType.DataSource = types;
            cbNature.DataSource = natures;
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
            btnMinimize.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MinimizeButton.png");
            btnScan.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ChangeMode.png");
            btnScanPokemon.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemon.png");
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeft.png");
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRight.png");
            btnDealDamage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealDamage.png");
            btnDealOneTick.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealTick.png");
            btnOptions.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Options.png");
            btnCry.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Cry.png");
            chkAppend.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            chkHasItem.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            chkCanBeShiny.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            chkCanBeLegend.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png"));
            btnSave.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Save.png"));
            btnImport.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Import.png");
            btnGetLoot.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootWindow.png"));
            btnDeletePoke.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DeletePokemon.png"));
            btnGoTo.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\GoTo.png"));
            btnRoll20Export.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Roll20Export.png");
            nudGoTo.Maximum = 1;
            nudGoTo.Minimum = 1;
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
                BasePokemon.Clear();
                AllNatures.Clear();
                AllItems1.Clear();
                AllDesc1.Clear();
                AllStat.Clear();
                AllLevels.Clear();
                AllCap.Clear();
                AllShinyCheck.Clear();
                AllStatus.Clear();
                CombatStage.Clear();
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
                isShiny = false;
                Final = GetPokemon();
                if (Final == null) return;
                int Level = GetLevel();
                int i = rng.Next(1, 101);
                if (!canShiny) i = 50;
                else if (forceShiny) i = 1;
                if (i == 1 || i == 100)
                {
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
                if (chkHasItem.Checked)
                {
                    GetItem();
                }
                else
                {
                    AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                    AllDesc1.Add("Nothing is here.");
                }
                IChooseYou = Final;
                AllPokemon.Add(IChooseYou);
                BasePokemon.Add(IChooseYou);
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
                AllShinyCheck.Add(isShiny);
                AllStatus.Add(statusBool.createStatus());
                CombatStage.Add(new int[] {0, 0, 0, 0, 0, 0});
                Injuries.Add(0);
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
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            WriteInfo();
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
                    if (pokeList[e].stage != stageAllow[0] && pokeList[e].stage != stageAllow[1])
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
                if (PokeReg == "Any")
                {
                    i = rng.Next(0, pokeList.Count);
                    try { return pokeList[i]; } catch { MessageBox.Show("There are no registered Pokemon that fit this criteria..."); return null; }
                }
                else
                {
                    int[] ratesbase = new int[] {
                        1, 1, 1, 1, 1, 1, 1, 1, 1,
                        2, 2, 2, 2, 2, 2, 2, 2,
                        3, 3, 3, 3, 3, 3, 3,
                        4, 4, 4, 4, 4, 4,
                        5, 5, 5, 5, 5,
                        6, 6, 6, 6,
                        7, 7, 7,
                        8, 8,
                        9 };
                    List<int> rates = new List<int>();
                    rates = ratesbase.ToList();
                    int x = rng.Next(rates.Count());
                    Start:
                    i = rng.Next(0, pokeList.Count);
                    foreach (Spawn s in spawnList[PokeRegIndex-1].Spawns)
                    {
                        try
                        {
                            if (pokeList[i].id == s.Name)
                            {
                                if (s.SpawnRate <= rates[x])
                                    break;
                                else
                                    goto Start;

                            }
                        }
                        catch { MessageBox.Show("There are no registered Pokemon that fit this criteria..."); return null; }
                    }
                    try { return pokeList[i]; } catch { MessageBox.Show("There are no registered Pokemon that fit this criteria..."); return null; }
                }
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
            List<int> base5 = new List<int>();
            List<int> base4 = new List<int>();
            List<int> base3 = new List<int>();
            List<int> base2 = new List<int>();
            List<int> base1 = new List<int>();
            List<int> base0 = new List<int>();
            base0.Add(stats[0].stat);
            stats[0].relation = base0;
            base1.Add(stats[1].stat);
            stats[1].relation = base1;
            base2.Add(stats[2].stat);
            stats[2].relation = base2;
            base3.Add(stats[3].stat);
            stats[3].relation = base3;
            base4.Add(stats[4].stat);
            stats[4].relation = base4;
            base5.Add(stats[5].stat);
            stats[5].relation = base5;
            for (int s = 1; s < 6; s++)
            {
                if (stats[s].stat == stats[0].stat)
                    stats[s].relation = base0;
            }
            if (stats[1].relation[0] != base0[0])
            {
                for (int s = 2; s < 6; s++)
                {
                    if (stats[s].stat == stats[1].stat)
                        stats[s].relation = base1;
                }
            }
            if (stats[2].relation[0] != base1[0] && stats[2].relation[0] != base0[0])
            {
                for (int s = 3; s < 6; s++)
                {
                    if (stats[s].stat == stats[2].stat)
                        stats[s].relation = base2;
                }
            }
            if (stats[3].relation[0] != base2[0] && stats[2].relation[0] != base1[0] && stats[2].relation[0] != base0[0])
            {
                for (int s = 4; s < 6; s++)
                {
                    if (stats[s].stat == stats[3].stat)
                        stats[s].relation = base3;
                }
            }
            if (stats[4].relation[0] != base3[0] && stats[2].relation[0] != base2[0] && stats[2].relation[0] != base1[0] && stats[2].relation[0] != base0[0])
            {
                for (int s = 5; s < 6; s++)
                {
                    if (stats[s].stat == stats[4].stat)
                        stats[s].relation = base4;
                }
            }
            for (var l = level; l > 0; l--)
            {
                int i = rng.Next(1, 7);
                if (i == 1)
                {
                    if (stats[5].relation[0] == stats[0].relation[0])
                        stats[5].stat++;
                    for (int e = 4; e > -1; e--)
                    {
                        if (stats[5].relation[0] != stats[e].relation[0])
                            if (stats[5].stat < stats[e].relation[0] - 1)
                            {
                                stats[5].stat++;
                                if (stats[5].stat != stats[5].relation[0]
                                    && stats[4].stat != stats[5].relation[0]
                                    && stats[3].stat != stats[5].relation[0]
                                    && stats[2].stat != stats[5].relation[0]
                                    && stats[1].stat != stats[5].relation[0]
                                    && stats[0].stat != stats[5].relation[0])
                                    stats[5].relation[0]++;
                                break;
                            }
                            else { l++; break; }
                    }
                }
                else if (i == 2)
                {
                    if (stats[4].relation[0] == stats[0].relation[0])
                        stats[4].stat++;
                    for (int e = 3; e > -1; e--)
                    {
                        if (stats[4].relation[0] != stats[e].relation[0])
                            if (stats[4].stat < stats[e].relation[0] - 1)
                            {
                                stats[4].stat++;
                                if (stats[5].stat != stats[4].relation[0]
                                    && stats[4].stat != stats[4].relation[0]
                                    && stats[3].stat != stats[4].relation[0]
                                    && stats[2].stat != stats[4].relation[0]
                                    && stats[1].stat != stats[4].relation[0]
                                    && stats[0].stat != stats[4].relation[0])
                                    stats[4].relation[0]++;
                                break;
                            }
                            else { l++; break; }
                    }
                }
                else if (i == 3)
                {
                    if (stats[3].relation[0] == stats[0].relation[0])
                        stats[3].stat++;
                    for (int e = 2; e > -1; e--)
                    {
                        if (stats[3].relation[0] != stats[e].relation[0])
                            if (stats[3].stat < stats[e].relation[0] - 1)
                            {
                                stats[3].stat++;
                                if (stats[5].stat != stats[3].relation[0]
                                    && stats[4].stat != stats[3].relation[0]
                                    && stats[3].stat != stats[3].relation[0]
                                    && stats[2].stat != stats[3].relation[0]
                                    && stats[1].stat != stats[3].relation[0]
                                    && stats[0].stat != stats[3].relation[0])
                                    stats[3].relation[0]++;
                                break;
                            }
                            else { l++; break; }
                    }
                }
                else if (i == 4)
                {
                    if (stats[2].relation[0] == stats[0].relation[0])
                        stats[2].stat++;
                    for (int e = 1; e > -1; e--)
                    {
                        if (stats[2].relation[0] != stats[e].relation[0])
                            if (stats[2].stat < stats[e].relation[0] - 1)
                            {
                                stats[2].stat++;
                                if (stats[5].stat != stats[2].relation[0]
                                    && stats[4].stat != stats[2].relation[0]
                                    && stats[3].stat != stats[2].relation[0]
                                    && stats[2].stat != stats[2].relation[0]
                                    && stats[1].stat != stats[2].relation[0]
                                    && stats[0].stat != stats[2].relation[0])
                                    stats[2].relation[0]++;
                                break;
                            }
                            else { l++; break; }
                    }
                }
                else if (i == 5)
                {
                    if (stats[1].relation[0] == stats[0].relation[0])
                        stats[1].stat++;
                    if (stats[1].relation[0] != stats[0].relation[0])
                    {
                        if (stats[1].stat < stats[0].relation[0] - 1)
                        {
                            stats[1].stat++;
                            if (stats[5].stat != stats[1].relation[0]
                                && stats[4].stat != stats[1].relation[0]
                                && stats[3].stat != stats[1].relation[0]
                                && stats[2].stat != stats[1].relation[0]
                                && stats[1].stat != stats[1].relation[0]
                                && stats[0].stat != stats[1].relation[0])
                                stats[1].relation[0]++;
                        }
                        else { l++; }
                    }
                }
                else if (i == 6)
                {
                    stats[0].stat++;
                    if (stats[5].stat != stats[0].relation[0]
                        && stats[4].stat != stats[0].relation[0]
                        && stats[3].stat != stats[0].relation[0]
                        && stats[2].stat != stats[0].relation[0]
                        && stats[1].stat != stats[0].relation[0]
                        && stats[0].stat != stats[0].relation[0])
                        stats[0].relation[0]++;
                }
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
            natureList = new List<Nature>();
            natureList = natureXML.createList("Natures", "Nature");
            int i = 0;
            if (PokeNature != "Any")
                for (int n = 0; n < natureList.Count(); n++)
                {
                    if (natureList[n].id == PokeNature)
                    {
                        i = n;
                    }
                }
            else
            {
                i = rng.Next(0, natureList.Count - 1);
            }
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

        private Skill SkillUp(int i)
        {
            int Up = 0;
            try { Up = Convert.ToInt32(skillList[i].die); }
            catch
            {
                MessageBox.Show("skill die is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue. Erroring skill will be replaced with an 'ERROR' text.");
                skillList[i].die = "ERROR";
                return skillList[i];
            }
            Up++;
            skillList[i].die = Up.ToString();
            return skillList[i];
        }

        private Skill SkillDn(int i)
        {
            int Down = 50;
            try { Down = Convert.ToInt32(skillList[i].die); }
            catch
            {
                MessageBox.Show("skill die is not entered correctly. " +
                "Please take a look at the Pokemon.XML in your Data\\XML folder to closer inspet the issue. Erroring skill will be replaced with an 'ERROR' text.");
                skillList[i].die = "ERROR";
                return skillList[i];
            }
            Down--;
            skillList[i].die = Down.ToString();
            return skillList[i];
        }

        //===========================================================================================================
        //=== GetSkills is used to apply the random skill variant to generated Pokemon. =============================
        //===========================================================================================================
        private void GetSkills()
        {
            skillList = new List<Skill>();
            skill = new List<Skill>();
            List<Skill> prep = new List<Skill>();
            prep.Clear();
            skillList.Clear();
            skillList = skillXML.createList(IChooseYou.number);
            skill.Clear();
            var values = Enumerable.Range(0, skillList.Count).OrderBy(x => Guid.NewGuid().GetHashCode()).ToArray();
            int sk = rng.Next(0, 4);
            if (sk == 0)
            {
                for (int s = 0; s < skillList.Count(); s++)
                {
                    prep.Add(skillList[values[s]]);
                }
            }
            else if (sk == 1)
            {
                prep.Add(SkillUp(values[0]));
                prep.Add(SkillDn(values[1]));
                for (int s = 2; s < skillList.Count(); s++)
                {
                    prep.Add(skillList[values[s]]);
                }
            }
            else if (sk == 2)
            {
                prep.Add(SkillUp(values[0]));
                prep.Add(SkillDn(values[1]));
                prep.Add(SkillUp(values[2]));
                prep.Add(SkillDn(values[3]));
                for (int s = 4; s < skillList.Count(); s++)
                {
                    prep.Add(skillList[values[s]]);
                }
            }
            else if (sk == 3)
            {
                prep.Add(SkillUp(values[0]));
                prep.Add(SkillDn(values[1]));
                prep.Add(SkillUp(values[2]));
                prep.Add(SkillDn(values[3]));
                prep.Add(SkillUp(values[4]));
                prep.Add(SkillDn(values[5]));
                for (int s = 6; s < skillList.Count(); s++)
                {
                    prep.Add(skillList[values[s]]);
                }
            }
            foreach (Skill s in prep)
            {
                if (s.name.Contains("Athl") == true)
                {
                    skill.Add(s);
                }

            }
            foreach (Skill s in prep)
            {
                if (s.name.Contains("Acro") == true)
                {
                    skill.Add(s);
                }
            }
            foreach (Skill s in prep)
            {
                if (s.name.Contains("Combat") == true)
                {
                    skill.Add(s);
                }
            }
            foreach (Skill s in prep)
            {
                if (s.name.Contains("Stealth") == true)
                {
                    skill.Add(s);
                }
            }
            foreach (Skill s in prep)
            {
                if (s.name.Contains("Percep") == true)
                {
                    skill.Add(s);
                }
            }
            foreach (Skill s in prep)
            {
                if (s.name.Contains("Focus") == true)
                {
                    skill.Add(s);
                }
            }
            if (prep.Count > 0)
            {
                foreach (Skill s in prep)
                {
                    if (!s.name.Contains("Athl") 
                        && !s.name.Contains("Acro") 
                        && !s.name.Contains("Combat") 
                        && !s.name.Contains("Stealth") 
                        && !s.name.Contains("Percep") 
                        && !s.name.Contains("Focus"))
                    skill.Add(s);
                }
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
                    mov = mov.Replace("- ", "(");
                    mov = mov + ")";
                    moves.Add(mov);
                }
                if (moves.Count > 6)
                {
                    int moveNum = rng.Next(0, 7);
                    moves.RemoveAt(moveNum);
                }
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
                if (moves.Count >= 6)
                {
                    int moveNum = rng.Next(0, 6);
                    moves.RemoveAt(moveNum);
                }
                string newmove = TMList[i].id + " (" + TMList[i].type +")";
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
            string newtype = typeList[i].name;
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
                AllDesc1.Add("Nothing is here.");
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
        }

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

            AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + itemList[i].id + ".png"));
            AllDesc1.Add(itemList[i].id + ": " + itemList[i].desc);

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
            pbPokemon.Location = new Point(189 - (pbPokemon.Width / 2), 250 - (pbPokemon.Height));
        }

        //===========================================================================================================
        //=== SetItem is used to set the Item Image in the correct place to keep it centered based on the varying ===
        //===== size of the image. ==================================================================================
        //===========================================================================================================
        private void SetItem()
        {
            pkItem.Size = pkItem.Image.Size;
            pkItem.Location = new Point(538 - (pkItem.Width / 2), 177 - (pkItem.Height));
        }

        //===========================================================================================================
        //=== WriteInfo is used to write the Pokemon's info onto Page One of the Scanned Pokemon. ===================
        //===========================================================================================================
        private void WriteInfo()
        {
            isWritingInfo = true;
            tbNature.Text = AllNatures[Current];
            string natureUp = "NA";
            string natureDown = "NA";
            nudHPCS.Value = CombatStage[Current][0];
            nudATKCS.Value = CombatStage[Current][1];
            nudDEFCS.Value = CombatStage[Current][2];
            nudSPATKCS.Value = CombatStage[Current][3];
            nudSPDEFCS.Value = CombatStage[Current][4];
            nudSPDCS.Value = CombatStage[Current][5];
            for (int i = 0; i < natureList.Count; i++)
            {
                if (natureList[i].id == tbNature.Text)
                {
                    natureUp = natureList[i].up;
                    natureDown = natureList[i].down;
                    break;
                }
            }
            if (natureUp == natureDown)
            {
                natureUp = "NA";
                natureDown = "NA";
            }
            if (AllShinyCheck[Current])
            {
                tbName.Text = "Shiny " + AllPokemon[Current].id + Environment.NewLine;
            }
            else
            {
                tbName.Text = AllPokemon[Current].id + Environment.NewLine;
            }
            tbType.Text = Type[Current];
            tbLevel.Text = AllLevels[Current].ToString();
            tbGender.Text = Gender[Current];
            tbCurrentHealth.Text = CurrentHealth[Current].ToString();
            tbMaxHealth.Text = MaxHealth[Current].ToString();
            if (natureUp == "hp")
                tbBaseHP.Text = (Convert.ToInt32(BasePokemon[Current].hp) + 1).ToString();
            else if (natureDown == "hp")
                tbBaseHP.Text = (Convert.ToInt32(BasePokemon[Current].hp) - 1).ToString();
            else
                tbBaseHP.Text = BasePokemon[Current].hp;
            tbLevelHP.Text = AllStat[Current][0];
            if (nudHPCS.Value > 0)
                tbCurrentHP.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][0]) / 5) * Math.Abs(nudHPCS.Value) + Convert.ToDecimal(AllStat[Current][0]))).ToString();
            else if (nudHPCS.Value < 0)
                tbCurrentHP.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][0]) / 10) * Math.Abs(nudHPCS.Value) - Convert.ToDecimal(AllStat[Current][0]))).ToString();
            else
                tbCurrentHP.Text = tbLevelHP.Text;
            if (natureUp == "atk")
                tbBaseATK.Text = (Convert.ToInt32(BasePokemon[Current].atk) + 2).ToString();
            else if (natureDown == "atk")
                tbBaseATK.Text = (Convert.ToInt32(BasePokemon[Current].atk) - 2).ToString();
            else
                tbBaseATK.Text = BasePokemon[Current].atk;
            tbLevelATK.Text = AllStat[Current][1];
            if (nudATKCS.Value > 0)
                tbCurrentATK.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][1]) / 5) * Math.Abs(nudATKCS.Value) + Convert.ToDecimal(AllStat[Current][1]))).ToString();
            else if (nudATKCS.Value < 0)
                tbCurrentATK.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][1]) / 10) * Math.Abs(nudATKCS.Value) - Convert.ToDecimal(AllStat[Current][1]))).ToString();
            else
                tbCurrentATK.Text = tbLevelATK.Text;
            if (natureUp == "def")
                tbBaseDEF.Text = (Convert.ToInt32(BasePokemon[Current].def) + 2).ToString();
            else if (natureDown == "def")
                tbBaseDEF.Text = (Convert.ToInt32(BasePokemon[Current].def) - 2).ToString();
            else
                tbBaseDEF.Text = BasePokemon[Current].def;
            tbLevelDEF.Text = AllStat[Current][2];
            if (nudDEFCS.Value > 0)
                tbCurrentDEF.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][2]) / 5) * Math.Abs(nudDEFCS.Value) + Convert.ToDecimal(AllStat[Current][2]))).ToString();
            else if (nudDEFCS.Value < 0)
                tbCurrentDEF.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][2]) / 10) * Math.Abs(nudDEFCS.Value) - Convert.ToDecimal(AllStat[Current][2]))).ToString();
            else
                tbCurrentDEF.Text = tbLevelDEF.Text;
            if (natureUp == "spatk")
                tbBaseSPATK.Text = (Convert.ToInt32(BasePokemon[Current].spatk) + 2).ToString();
            else if (natureDown == "spatk")
                tbBaseSPATK.Text = (Convert.ToInt32(BasePokemon[Current].spatk) - 2).ToString();
            else
                tbBaseSPATK.Text = BasePokemon[Current].spatk;
            tbLevelSPATK.Text = AllStat[Current][3];
            if (nudSPATKCS.Value > 0)
                tbCurrentSPATK.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][3]) / 5) * Math.Abs(nudSPATKCS.Value) + Convert.ToDecimal(AllStat[Current][3]))).ToString();
            else if (nudSPATKCS.Value < 0)
                tbCurrentSPATK.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][3]) / 10) * Math.Abs(nudSPATKCS.Value) - Convert.ToDecimal(AllStat[Current][3]))).ToString();
            else
                tbCurrentSPATK.Text = tbLevelSPATK.Text;
            if (natureUp == "spdef")
                tbBaseSPDEF.Text = (Convert.ToInt32(BasePokemon[Current].spdef) + 2).ToString();
            else if (natureDown == "spdef")
                tbBaseSPDEF.Text = (Convert.ToInt32(BasePokemon[Current].spdef) - 2).ToString();
            else
                tbBaseSPDEF.Text = BasePokemon[Current].spdef;
            tbLevelSPDEF.Text = AllStat[Current][4];
            if (nudSPDEFCS.Value > 0)
                tbCurrentSPDEF.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][4]) / 5) * Math.Abs(nudSPDEFCS.Value) + Convert.ToDecimal(AllStat[Current][4]))).ToString();
            else if (nudSPDEFCS.Value < 0)
                tbCurrentSPDEF.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][4]) / 10) * Math.Abs(nudSPDEFCS.Value) - Convert.ToDecimal(AllStat[Current][4]))).ToString();
            else
                tbCurrentSPDEF.Text = tbLevelSPDEF.Text;
            if (natureUp == "spd")
                tbBaseSPD.Text = (Convert.ToInt32(BasePokemon[Current].spd) + 2).ToString();
            else if (natureDown == "spd")
                tbBaseSPD.Text = (Convert.ToInt32(BasePokemon[Current].spd) - 2).ToString();
            else
                tbBaseSPD.Text = BasePokemon[Current].spd;
            tbLevelSPD.Text = AllStat[Current][5];
            if (nudSPDCS.Value > 0)
                tbCurrentSPD.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][5]) / 5) * Math.Abs(nudSPDCS.Value) + Convert.ToDecimal(AllStat[Current][5]))).ToString();
            else if (nudSPDCS.Value < 0)
                tbCurrentSPD.Text = (Math.Abs(Math.Round(Convert.ToDecimal(AllStat[Current][5]) / 10) * Math.Abs(nudSPDCS.Value) - Convert.ToDecimal(AllStat[Current][5]))).ToString();
            else
                tbCurrentSPD.Text = tbLevelSPD.Text;
            lbCapabilites.Items.Clear();
            foreach (string cap in AllCap[Current])
            {
                lbCapabilites.Items.Add(cap);
            }
            lbMoves.Items.Clear();
            lbAbilities.Items.Clear();
            lbSkills.Items.Clear();
            lbMoves.Items.Add("Moves:");
            lbMoves.Items.Add("Struggle (Normal)");
            for (var w = 0; w < AllMoves[Current].Count; w++)
            {
                lbMoves.Items.Add(AllMoves[Current][w]);
            }
            lbAbilities.Items.Add("Abilities:");
            for (var a = 0; a < AllAbilities[Current].Count; a++)
            {
                lbAbilities.Items.Add(AllAbilities[Current][a]);
            }
            lbSkills.Items.Add("Skills:");
            for (var s = 0; s < AllSkills[Current].Count; s++)
            {
                if (Convert.ToInt32(AllSkills[Current][s].bonus) < 0)
                {
                    lbSkills.Items.Add(AllSkills[Current][s].name + " " + AllSkills[Current][s].die + "d6" + AllSkills[Current][s].bonus);
                }
                else
                {
                    string skillAdd = AllSkills[Current][s].name + " " + AllSkills[Current][s].die + "d6+" + AllSkills[Current][s].bonus;
                    skillAdd = skillAdd.Replace("++", "+");
                    lbSkills.Items.Add(skillAdd);
                }
            }
            pkItem.Image = AllItems1[Current];
            SetItem();
            rtbGasp.Text = "Held Item- " + Environment.NewLine + AllDesc1[Current];
            rtbGasp.Refresh();
            chkBurned.Checked = AllStatus[Current].Burned;
            chkFrozen.Checked = AllStatus[Current].Frozen;
            chkParalysis.Checked = AllStatus[Current].Paralysis;
            chkPoisoned.Checked = AllStatus[Current].Poisoned;
            chkBadSleep.Checked = AllStatus[Current].BadSleep;
            chkConfused.Checked = AllStatus[Current].Confused;
            chkCursed.Checked = AllStatus[Current].Cursed;
            chkRage.Checked = AllStatus[Current].Rage;
            chkFlinch.Checked = AllStatus[Current].Flinch;
            chkInfatuation.Checked = AllStatus[Current].Infatuation;
            chkTotalBlind.Checked = AllStatus[Current].TotalBlind;
            chkSuppress.Checked = AllStatus[Current].Suppress;
            chkBlind.Checked = AllStatus[Current].Blind;
            chkAsleep.Checked = AllStatus[Current].Asleep;
            chkSlowed.Checked = AllStatus[Current].Slowed;
            chkStuck.Checked = AllStatus[Current].Stuck;
            chkTrapped.Checked = AllStatus[Current].Trapped;
            chkTripped.Checked = AllStatus[Current].Tripped;
            chkVulnerable.Checked = AllStatus[Current].Vulnerable;
            chkFainted.Checked = AllStatus[Current].Fainted;
            GetCaptureRate();
            Types ttInfoType1 = typeList[0];
            Types ttInfoType2 = typeList[0];
            bool typeTwoEdit = false;
            for (int t1 = 0; t1 < typeList.Count(); t1++)
            {
                if (tbType.Text.Contains(typeList[t1].name))
                {
                    ttInfoType1 = typeList[t1];
                    break;
                }
            }
            for (int t2 = 0; t2 < typeList.Count(); t2++)
            {
                if (tbType.Text.Contains(typeList[t2].name))
                    if (ttInfoType1 != (typeList[t2]))
                    {
                        ttInfoType2 = typeList[t2];
                        typeTwoEdit = true;
                        break;
                    }

            }
            if (typeTwoEdit == true)
            {
                string TypeString = 
                    "Normal: x" + (ttInfoType1.normal * ttInfoType2.normal).ToString() + Environment.NewLine +
                    "Fire: x" + (ttInfoType1.fire * ttInfoType2.fire).ToString() + Environment.NewLine +
                    "Water: x" + (ttInfoType1.water * ttInfoType2.water).ToString() + Environment.NewLine +
                    "Electric: x" + (ttInfoType1.electric * ttInfoType2.electric).ToString() + Environment.NewLine +
                    "Grass: x" + (ttInfoType1.grass * ttInfoType2.grass).ToString() + Environment.NewLine +
                    "Ice: x" + (ttInfoType1.ice * ttInfoType2.ice).ToString() + Environment.NewLine +
                    "Fighting: x" + (ttInfoType1.fighting * ttInfoType2.fighting).ToString() + Environment.NewLine +
                    "Poison: x" + (ttInfoType1.poison * ttInfoType2.poison).ToString() + Environment.NewLine +
                    "Ground: x" + (ttInfoType1.ground * ttInfoType2.ground).ToString() + Environment.NewLine +
                    "Flying: x" + (ttInfoType1.flying * ttInfoType2.flying).ToString() + Environment.NewLine +
                    "Psychic: x" + (ttInfoType1.psychic * ttInfoType2.psychic).ToString() + Environment.NewLine +
                    "Bug: x" + (ttInfoType1.bug * ttInfoType2.bug).ToString() + Environment.NewLine +
                    "Rock: x" + (ttInfoType1.rock * ttInfoType2.rock).ToString() + Environment.NewLine +
                    "Ghost: x" + (ttInfoType1.ghost * ttInfoType2.ghost).ToString() + Environment.NewLine +
                    "Dragon: x" + (ttInfoType1.dragon * ttInfoType2.dragon).ToString() + Environment.NewLine +
                    "Dark: x" + (ttInfoType1.dark * ttInfoType2.dark).ToString() + Environment.NewLine +
                    "Steel: x" + (ttInfoType1.steel * ttInfoType2.steel).ToString() + Environment.NewLine +
                    "Fairy: x" + (ttInfoType1.fairy * ttInfoType2.fairy).ToString() + Environment.NewLine;
                if (TypeString.Contains("x2.25"))
                {
                    TypeString = TypeString.Replace("x2.25", "x2");
                }
                if (TypeString.Contains("x0.75"))
                {
                    TypeString = TypeString.Replace("x0.75", "x1");
                }
                ttInfo.SetToolTip(this.tbType, TypeString);
            }
            else
            {
                ttInfo.SetToolTip(this.tbType,
                    "Normal: x" + (ttInfoType1.normal).ToString() + Environment.NewLine +
                    "Fire: x" + (ttInfoType1.fire).ToString() + Environment.NewLine +
                    "Water: x" + (ttInfoType1.water).ToString() + Environment.NewLine +
                    "Electric: x" + (ttInfoType1.electric).ToString() + Environment.NewLine +
                    "Grass: x" + (ttInfoType1.grass).ToString() + Environment.NewLine +
                    "Ice: x" + (ttInfoType1.ice).ToString() + Environment.NewLine +
                    "Fighting: x" + (ttInfoType1.fighting).ToString() + Environment.NewLine +
                    "Poison: x" + (ttInfoType1.poison).ToString() + Environment.NewLine +
                    "Ground: x" + (ttInfoType1.ground).ToString() + Environment.NewLine +
                    "Flying: x" + (ttInfoType1.flying).ToString() + Environment.NewLine +
                    "Psychic: x" + (ttInfoType1.psychic).ToString() + Environment.NewLine +
                    "Bug: x" + (ttInfoType1.bug).ToString() + Environment.NewLine +
                    "Rock: x" + (ttInfoType1.rock).ToString() + Environment.NewLine +
                    "Ghost: x" + (ttInfoType1.ghost).ToString() + Environment.NewLine +
                    "Dragon: x" + (ttInfoType1.dragon).ToString() + Environment.NewLine +
                    "Dark: x" + (ttInfoType1.dark).ToString() + Environment.NewLine +
                    "Steel: x" + (ttInfoType1.steel).ToString() + Environment.NewLine +
                    "Fairy: x" + (ttInfoType1.fairy).ToString() + Environment.NewLine);
            }
            nudGoTo.Maximum = AllPokemon.Count;
            nudInjuries.Value = Injuries[Current];
            isWritingInfo = false;
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void GetCaptureRate()
        {
            int captureRate = 100;
            if (CurrentHealth[Current] <= 0)
                tbCaptureRate.Text = "Pokemon is unconcious.";
            else
            {
                captureRate -= AllLevels[Current] * 2;
                double health = Convert.ToDouble(CurrentHealth[Current] / MaxHealth[Current]);
                if (CurrentHealth[Current] == 1)
                    captureRate += 30;
                else if (health >= 0.755)
                    captureRate -= 30;
                else if (health >= 0.505)
                    captureRate -= 15;
                else if (health >= 0.255)
                    captureRate += 0;
                else
                    captureRate += 15;
                evoList = evoXML.createList(AllPokemon[Current].number);
                int stagesTotal = evoList.Count();
                int stageCurrent = Convert.ToInt32(AllPokemon[Current].stage);
                int stagesRemain = stagesTotal - stageCurrent;
                if (stagesRemain == 0)
                    captureRate -= 10;
                else if (stagesRemain == 1)
                    captureRate += 0;
                else if (stagesRemain == 2)
                    captureRate += 10;
                if (AllShinyCheck[Current])
                    captureRate -= 10;
                if (AllStatus[Current].Burned == true) { captureRate += 10; }
                if (AllStatus[Current].Frozen == true) { captureRate += 10; }
                if (AllStatus[Current].BadSleep == true) { captureRate += 5; }
                if (AllStatus[Current].Poisoned == true) { captureRate += 10; }
                if (AllStatus[Current].Cursed == true) { captureRate += 5; }
                if (AllStatus[Current].Rage == true) { captureRate += 5; }
                if (AllStatus[Current].Infatuation == true) { captureRate += 5; }
                if (AllStatus[Current].Asleep == true) { captureRate += 5; }
                if (AllStatus[Current].Slowed == true) { captureRate += 5; }
                if (AllStatus[Current].Suppress == true) { captureRate += 5; }
                if (AllStatus[Current].Flinch == true) { captureRate += 5; }
                if (AllStatus[Current].Confused == true) { captureRate += 5; }
                if (AllStatus[Current].Paralysis == true) { captureRate += 10; }
                if (AllStatus[Current].Stuck == true) { captureRate += 10; }
                captureRate += 5 * Convert.ToInt32(Injuries[Current]);
                tbCaptureRate.Text = captureRate.ToString() + " or lower to capture.";
            }
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
        private void PokeSaveJSON_DoWork(object sender, DoWorkEventArgs e)
        {
            string typeOne;
            string typeTwo;
            if (tbType.Text.Contains("/"))
            {
                string[] typesSplit = tbType.Text.Split('/');
                typeOne = typesSplit[0];
                typeTwo = typesSplit[1];
            } 
            else
            {
                typeOne = tbType.Text;
                typeTwo = "None";
            }

            string height;
            string weight;
            string[] hSplit = AllPokemon[Current].size.Split('(');
            string[] wSplit = AllPokemon[Current].weight.Split('(');
            height = hSplit[1].Remove(hSplit[1].Length-1);
            weight = wSplit[1].Remove(wSplit[1].Length-1);

            int athl = 0;
            int acro = 0;
            int com = 0;
            int steal = 0;
            int perc = 0;
            int foc = 0;
            int tech = 0;
            int athlB = 0;
            int acroB = 0;
            int comB = 0;
            int stealB = 0;
            int percB = 0;
            int focB = 0;
            int techB = 0;
            for (int skill = 0; skill < AllSkills[Current].Count; skill++)
            {
                if (AllSkills[Current][skill].name == "Athl")
                {
                    athl = Convert.ToInt32(AllSkills[Current][skill].die);
                    athlB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
                if (AllSkills[Current][skill].name == "Acro")
                {
                    acro = Convert.ToInt32(AllSkills[Current][skill].die);
                    acroB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
                if (AllSkills[Current][skill].name == "Combat")
                {
                    com = Convert.ToInt32(AllSkills[Current][skill].die);
                    comB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
                if (AllSkills[Current][skill].name == "Stealth")
                {
                    steal = Convert.ToInt32(AllSkills[Current][skill].die);
                    stealB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
                if (AllSkills[Current][skill].name == "Percep")
                {
                    perc = Convert.ToInt32(AllSkills[Current][skill].die);
                    percB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
                if (AllSkills[Current][skill].name == "Focus")
                {
                    foc = Convert.ToInt32(AllSkills[Current][skill].die);
                    focB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
                if (AllSkills[Current][skill].name == "Edu:Tech")
                {
                    tech = Convert.ToInt32(AllSkills[Current][skill].die);
                    techB = Convert.ToInt32(AllSkills[Current][skill].bonus);
                }
            }

            string[] heldItem = AllDesc1[Current].Split(':');

            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                writer.WritePropertyName("CharType");
                writer.WriteValue(0);
                writer.WritePropertyName("nickname");
                writer.WriteValue(tbName.Text.Trim());
                writer.WritePropertyName("species");
                writer.WriteValue(AllPokemon[Current].id);
                writer.WritePropertyName("type1");
                writer.WriteValue(typeOne);
                writer.WritePropertyName("type2");
                writer.WriteValue(typeTwo);
                writer.WritePropertyName("Level");
                writer.WriteValue(AllLevels[Current]);
                writer.WritePropertyName("HeldItem");
                if (heldItem[0] == "Nothing is here.")
                    writer.WriteValue("");
                else
                    writer.WriteValue(heldItem[0]);
                writer.WritePropertyName("Gender");
                writer.WriteValue(Gender[Current]);
                writer.WritePropertyName("Nature");
                writer.WriteValue(AllNatures[Current]);
                writer.WritePropertyName("Height");
                writer.WriteValue(height);
                writer.WritePropertyName("WeightClass");
                writer.WriteValue(weight);
                writer.WritePropertyName("base_HP");
                writer.WriteValue(Convert.ToInt32(BasePokemon[Current].hp));
                writer.WritePropertyName("base_ATK");
                writer.WriteValue(Convert.ToInt32(BasePokemon[Current].atk));
                writer.WritePropertyName("base_DEF");
                writer.WriteValue(Convert.ToInt32(BasePokemon[Current].def));
                writer.WritePropertyName("base_SPATK");
                writer.WriteValue(Convert.ToInt32(BasePokemon[Current].spatk));
                writer.WritePropertyName("base_SPDEF");
                writer.WriteValue(Convert.ToInt32(BasePokemon[Current].spdef));
                writer.WritePropertyName("base_SPEED");
                writer.WriteValue(Convert.ToInt32(BasePokemon[Current].spd));
                writer.WritePropertyName("HP");
                writer.WriteValue(Convert.ToInt32(AllStat[Current][0]) - Convert.ToInt32(BasePokemon[Current].hp));
                writer.WritePropertyName("ATK");
                writer.WriteValue(Convert.ToInt32(AllStat[Current][1]) - Convert.ToInt32(BasePokemon[Current].atk));
                writer.WritePropertyName("DEF");
                writer.WriteValue(Convert.ToInt32(AllStat[Current][2]) - Convert.ToInt32(BasePokemon[Current].def));
                writer.WritePropertyName("SPATK");
                writer.WriteValue(Convert.ToInt32(AllStat[Current][3]) - Convert.ToInt32(BasePokemon[Current].spatk));
                writer.WritePropertyName("SPDEF");
                writer.WriteValue(Convert.ToInt32(AllStat[Current][4]) - Convert.ToInt32(BasePokemon[Current].spdef));
                writer.WritePropertyName("SPEED");
                writer.WriteValue(Convert.ToInt32(AllStat[Current][5]) - Convert.ToInt32(BasePokemon[Current].spd));
                writer.WritePropertyName("Capabilities");
                writer.WriteStartObject();
                string startNaturewalk = "Error";
                for (int s = 0; s < lbCapabilites.Items.Count; s++)
                {
                    if (lbCapabilites.Items[s].ToString().Contains("Naturewalk"))
                    {
                        StringBuilder build = new StringBuilder();
                        List<string> capWalks = new List<string>();
                        string[] start1 = lbCapabilites.Items[s].ToString().Split(')');
                        string[] start2 = start1[0].Split('(');
                        string[] start3 = start2[1].Split(',');
                        foreach (string w in start3)
                        {
                            build.Clear();
                            build.Append("Naturewalk (");
                            build.Append(w.Trim());
                            build.Append(")");
                            capWalks.Add(build.ToString());
                        }
                        startNaturewalk = lbCapabilites.Items[s].ToString();
                        foreach (string v in capWalks)
                        {
                            writer.WritePropertyName(v);
                            writer.WriteValue(true);
                        }
                    }
                }
                foreach (string c in lbCapabilites.Items)
                {
                    if (c != "Capabilites:" && !c.Contains(startNaturewalk))
                    {
                        if (c.Contains("Overland") || c.Contains("Swim") || c.Contains("Power"))
                        {
                            string[] capSplit = c.Split(' ');
                            writer.WritePropertyName(capSplit[0]);
                            writer.WriteValue(Convert.ToInt32(capSplit[1]));
                        }
                        else if (c.Contains("Jump"))
                        {
                            string[] capSplit = c.Split(' ');
                            string[] highLow = capSplit[1].Split('/');
                            writer.WritePropertyName("HJ");
                            writer.WriteValue(highLow[0]);
                            writer.WritePropertyName("LJ");
                            writer.WriteValue(highLow[1]);
                        }
                        else
                        {
                            writer.WritePropertyName(c);
                            writer.WriteValue(true);
                        }
                    }
                }
                writer.WriteEndObject();
                writer.WritePropertyName("Athletics");
                writer.WriteValue(athl);
                writer.WritePropertyName("Acrobatics");
                writer.WriteValue(acro);
                writer.WritePropertyName("Combat");
                writer.WriteValue(com);
                writer.WritePropertyName("Stealth");
                writer.WriteValue(steal);
                writer.WritePropertyName("Perception");
                writer.WriteValue(perc);
                writer.WritePropertyName("Focus");
                writer.WriteValue(foc);
                writer.WritePropertyName("TechnologyEducation");
                writer.WriteValue(tech);
                writer.WritePropertyName("Athletics_bonus");
                writer.WriteValue(athlB);
                writer.WritePropertyName("Acrobatics_bonus");
                writer.WriteValue(acroB);
                writer.WritePropertyName("Combat_bonus");
                writer.WriteValue(comB);
                writer.WritePropertyName("Stealth_bonus");
                writer.WriteValue(stealB);
                writer.WritePropertyName("Perception_bonus");
                writer.WriteValue(percB);
                writer.WritePropertyName("Focus_bonus");
                writer.WriteValue(focB);
                writer.WritePropertyName("TechnologyEducation_bonus");
                writer.WriteValue(techB);
                writer.WritePropertyName("TutorPoints");
                writer.WriteValue(0);
                int placement = 1;
                foreach (string m in lbMoves.Items)
                {
                    if (m != "Moves:")
                    {
                        string json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Data\JSON\moves.json");
                        JObject mJSON = JObject.Parse(json);
                        string[] mSplit = m.Split('(');
                        JToken moveName = mJSON[mSplit[0].Trim()];
                        MoveJSON moveInfo = new MoveJSON("--", "--", "--", "--", "--", "--", "--", "--", "--");
                        try { moveInfo.moveType = (string)moveName["Type"]; } catch { }
                        try { moveInfo.moveFreq = (string)moveName["Freq"]; } catch { }
                        try { moveInfo.moveAC = (string)moveName["AC"]; } catch { }
                        try { moveInfo.moveDB = (string)moveName["DB"]; } catch { }
                        try { moveInfo.moveClass = (string)moveName["Class"]; } catch { }
                        try { moveInfo.moveRange = (string)moveName["Range"]; } catch { }
                        try { moveInfo.moveEffect = (string)moveName["Effect"]; } catch { }
                        try { moveInfo.moveConEffect = (string)moveName["Contest Type"]; } catch { }
                        try { moveInfo.moveConType = (string)moveName["Contest Effect"]; } catch { }
                        writer.WritePropertyName("Move" + placement);
                        writer.WriteStartObject();
                        writer.WritePropertyName("Name");
                        writer.WriteValue(mSplit[0].Trim());
                        if (moveInfo.moveType != null)
                        {
                            writer.WritePropertyName("Type");
                            writer.WriteValue(moveInfo.moveType);
                        }
                        if (moveInfo.moveFreq != null)
                        {
                            writer.WritePropertyName("Freq");
                            writer.WriteValue(moveInfo.moveFreq);
                        }
                        if (moveInfo.moveAC != null)
                        {
                            writer.WritePropertyName("AC");
                            writer.WriteValue(moveInfo.moveAC);
                        }
                        if (moveInfo.moveDB != null)
                        {
                            writer.WritePropertyName("DB");
                            writer.WriteValue(moveInfo.moveDB);
                        }
                        if (moveInfo.moveClass != null)
                        {
                            writer.WritePropertyName("DType");
                            writer.WriteValue(moveInfo.moveClass);
                        }
                        if (moveInfo.moveRange != null)
                        {
                            writer.WritePropertyName("Range");
                            writer.WriteValue(moveInfo.moveRange);
                        }
                        if (moveInfo.moveEffect != null)
                        {
                            writer.WritePropertyName("Effect");
                            writer.WriteValue(moveInfo.moveEffect);
                        }
                        if (moveInfo.moveConType != null)
                        {
                            writer.WritePropertyName("Contest Type");
                            writer.WriteValue(moveInfo.moveConType);
                        }
                        if (moveInfo.moveConEffect != null)
                        {
                            writer.WritePropertyName("Contest Effect");
                            writer.WriteValue(moveInfo.moveConEffect);
                        }
                        writer.WriteEndObject();
                        placement++;
                    }
                }
                placement = 1;
                foreach (string a in lbAbilities.Items)
                {
                    if (a != "Abilities:")
                    {
                        string json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Data\JSON\abilities.json");
                        JObject aJSON = JObject.Parse(json);
                        JToken abilityName = aJSON[a];
                        AbilityJSON abilityInfo = new AbilityJSON("--", "--", "--", "--");
                        try { abilityInfo.abiTrigger = (string)abilityName["Trigger"]; } catch { }
                        try { abilityInfo.abiFreq = (string)abilityName["Freq"]; } catch { }
                        try { abilityInfo.abiTarget = (string)abilityName["Target"]; } catch { }
                        try { abilityInfo.abiEffect = (string)abilityName["Effect"]; } catch { }
                        writer.WritePropertyName("Ability" + placement);
                        writer.WriteStartObject();
                        writer.WritePropertyName("Name");
                        writer.WriteValue(a);
                        if (abilityInfo.abiFreq != null)
                        {
                            writer.WritePropertyName("Freq");
                            writer.WriteValue(abilityInfo.abiFreq);
                        }
                        if (abilityInfo.abiTarget != null)
                        {
                            writer.WritePropertyName("Target");
                            writer.WriteValue(abilityInfo.abiTarget);
                        }
                        if (abilityInfo.abiTrigger != null)
                        {
                            writer.WritePropertyName("Trigger");
                            writer.WriteValue(abilityInfo.abiTrigger);
                        }
                        if (abilityInfo.abiEffect != null)
                        {
                            writer.WritePropertyName("Effect");
                            writer.WriteValue(abilityInfo.abiEffect);
                        }
                        writer.WriteEndObject();
                        placement++;
                    }
                }
            }
            File.WriteAllText(saveFilePath, sb.ToString());
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void PokeSaveScan_DoWork(object sender, DoWorkEventArgs e)
        {
            if (saveResult == true)
            {
                System.IO.Stream fileStream = PokeSaveDialog.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                sw.WriteLine("§PokeGenesis Export§");
                sw.WriteLine(" Name: " + tbName.Text + Environment.NewLine +
                    " Number: " + AllPokemon[Current].number + Environment.NewLine +
                    " Type: " + tbType.Text + Environment.NewLine +
                    " Gender: " + tbGender.Text + Environment.NewLine +
                    " Size: " + AllPokemon[Current].size + Environment.NewLine +
                    " Weight: " + AllPokemon[Current].weight + Environment.NewLine +
                    " Nature: " + tbNature.Text + Environment.NewLine +
                    " Level: " + tbLevel.Text + Environment.NewLine +
                    Environment.NewLine +
                    " Stats:" + Environment.NewLine +
                    " Current Health: " + tbCurrentHealth.Text + Environment.NewLine +
                    " Max Health: " + tbMaxHealth.Text + Environment.NewLine +
                    " Injuries: " + nudInjuries.Value.ToString() + Environment.NewLine +
                    " HP: " + tbLevelHP.Text + " (" + BasePokemon[Current].hp + ")" + Environment.NewLine +
                    " ATK: " + tbLevelATK.Text + " (" + BasePokemon[Current].atk + ")" + Environment.NewLine +
                    " DEF: " + tbLevelDEF.Text + " (" + BasePokemon[Current].def + ")" + Environment.NewLine +
                    " SPATK: " + tbLevelSPATK.Text + " (" + BasePokemon[Current].spatk + ")" + Environment.NewLine +
                    " SPDEF: " + tbLevelSPDEF.Text + " (" + BasePokemon[Current].spdef + ")" + Environment.NewLine +
                    " SPD: " + tbLevelSPD.Text + " (" + BasePokemon[Current].spd + ")" + Environment.NewLine +
                    Environment.NewLine +
                    "Capabilities:");
                foreach (string cap in AllCap[Current])
                {
                    sw.WriteLine("-" + cap);
                }
                sw.WriteLine(Environment.NewLine + "Moves:");
                for (var w = 0; w < AllMoves[Current].Count; w++)
                {
                    sw.WriteLine("-" + AllMoves[Current][w]);
                }
                sw.WriteLine(Environment.NewLine + "Abilities:");
                for (var a = 0; a < AllAbilities[Current].Count; a++)
                {
                    sw.WriteLine("-" + AllAbilities[Current][a]);
                }
                sw.WriteLine(Environment.NewLine + "Skills:");
                for (var s = 0; s < AllSkills[Current].Count; s++)
                {
                    if (Convert.ToInt32(AllSkills[Current][s].bonus) < 0)
                    {
                        sw.WriteLine("-" + AllSkills[Current][s].name + " " + AllSkills[Current][s].die + "d6" + AllSkills[Current][s].bonus);
                    }
                    else
                    {
                        sw.WriteLine("-" + AllSkills[Current][s].name + " " + AllSkills[Current][s].die + "d6+" + AllSkills[Current][s].bonus);
                    }
                }
                sw.WriteLine(Environment.NewLine + "Held Item:" + Environment.NewLine + AllDesc1[Current]);
                sw.WriteLine(Environment.NewLine + "------------------------------------------------------------------------------------------");
                PokeSaveScan.ReportProgress(1);
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
        //=== 
        //===========================================================================================================
        private void PokeImportScan_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] paths = PokeImportDialog.FileNames;
            foreach (string i in paths)
            {
                string[] importedPokemon = File.ReadAllLines(i).ToArray();
                string imName = "ERROR";
                string imHP = "0";
                string imATK = "0";
                string imDEF = "0";
                string imSPATK = "0";
                string imSPDEF = "0";
                string imSPD = "0";
                string imbHP = "0";
                string imbATK = "0";
                string imbDEF = "0";
                string imbSPATK = "0";
                string imbSPDEF = "0";
                string imbSPD = "0";
                string imWeight = "ERROR";
                string imSize = "ERROR";
                if (importedPokemon[0] != "§PokeGenesis Export§") return;
                for (int s = 0; s < importedPokemon.Count(); s++)
                {
                    if (importedPokemon[s].Contains(" Name:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imName = temp[2];
                    }
                    if (importedPokemon[s].Contains(" Number:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        if(imName.Contains("Shiny "))
                            AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + temp[2] + ".gif"));
                        else
                            AllImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + temp[2] + ".gif"));
                    }
                    if (importedPokemon[s].Contains(" Type:"))
                    {
                        string[] temp = importedPokemon[s].Split(':');
                        Type.Add(temp[1].Trim());
                    }
                    if (importedPokemon[s].Contains(" Nature:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        AllNatures.Add(temp[2]);
                    }
                    if (importedPokemon[s].Contains(" Weight:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        StringBuilder build = new StringBuilder();
                        for (int t = 2; t < temp.Count(); t++)
                        {
                            build.Append(temp[t] + " ");
                        }
                        imWeight = build.ToString();
                    }
                    if (importedPokemon[s].Contains(" Size:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        StringBuilder build = new StringBuilder();
                        for (int t = 2; t < temp.Count(); t++)
                        {
                            build.Append(temp[t] + " ");
                        }
                        imSize = build.ToString();
                    }
                    if (importedPokemon[s].Contains(" Gender:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        StringBuilder build = new StringBuilder();
                        for (int t = 2; t < temp.Count(); t++)
                        {
                            build.Append(temp[t] + " ");
                        }
                        Gender.Add(build.ToString());
                    }
                    if (importedPokemon[s].Contains(" Level:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        AllLevels.Add(Convert.ToInt32(temp[2]));
                    }
                    if (importedPokemon[s].Contains(" Current Health:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        CurrentHealth.Add(Convert.ToInt32(temp[3]));
                    }
                    if (importedPokemon[s].Contains(" Max Health:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        MaxHealth.Add(Convert.ToInt32(temp[3]));
                    }
                    if (importedPokemon[s].Contains(" Injuries:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        Injuries.Add(Convert.ToInt32(temp[2]));
                    }
                    if (importedPokemon[s].Contains(" HP:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imHP = temp[2];
                        imbHP = temp[3].Replace("(", string.Empty).Replace(")", string.Empty);
                    }
                    if (importedPokemon[s].Contains(" ATK:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imATK = temp[2];
                        imbATK = temp[3].Replace("(", string.Empty).Replace(")", string.Empty);
                    }
                    if (importedPokemon[s].Contains(" DEF:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imDEF = temp[2];
                        imbDEF = temp[3].Replace("(", string.Empty).Replace(")", string.Empty);
                    }
                    if (importedPokemon[s].Contains(" SPATK:"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imSPATK = temp[2];
                        imbSPATK = temp[3].Replace("(", string.Empty).Replace(")", string.Empty);
                    }
                    if (importedPokemon[s].Contains(" SPDEF"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imSPDEF = temp[2];
                        imbSPDEF = temp[3].Replace("(", string.Empty).Replace(")", string.Empty);
                    }
                    if (importedPokemon[s].Contains(" SPD"))
                    {
                        string[] temp = importedPokemon[s].Split(' ');
                        imSPD = temp[2];
                        imbSPD = temp[3].Replace("(", string.Empty).Replace(")", string.Empty);
                    }
                    if (importedPokemon[s].Contains("Capabilities:"))
                    {
                        List<string> cap = new List<string>();
                        for (int c = s + 1; c < importedPokemon.Count(); c++)
                        {
                            if(importedPokemon[c].Contains("-"))
                                cap.Add(importedPokemon[c].Replace("-", string.Empty));
                            else
                                break;
                        }
                        AllCap.Add(cap);
                    }
                    if (importedPokemon[s].Contains("Moves:"))
                    {
                        List<string> mov = new List<string>();
                        for (int c = s + 1; c < importedPokemon.Count(); c++)
                        {
                            if (importedPokemon[c].Contains("-"))
                                mov.Add(importedPokemon[c].Replace("-", string.Empty));
                            else
                                break;
                        }
                        AllMoves.Add(mov);
                    }
                    if (importedPokemon[s].Contains("Abilities:"))
                    {
                        List<string> abi = new List<string>();
                        for (int c = s + 1; c < importedPokemon.Count(); c++)
                        {
                            if (importedPokemon[c].Contains("-"))
                                abi.Add(importedPokemon[c].Replace("-", string.Empty));
                            else
                                break;
                        }
                        AllAbilities.Add(abi);
                    }
                    if (importedPokemon[s].Contains("Skills:"))
                    {
                        List<string> ski = new List<string>();
                        for (int c = s + 1; c < importedPokemon.Count(); c++)
                        {
                            if (importedPokemon[c].Contains("-"))
                                ski.Add(importedPokemon[c].Replace("-", string.Empty));
                            else
                                break;
                        }
                        List<Skill> imSkills = new List<Skill>();
                        foreach(string sk in ski)
                        {
                            string[] skillFind = sk.Split(' ');
                            string[] finalSKill = skillFind[1].Split('d');
                            Skill newSkill = new Skill
                            {
                                name = skillFind[0],
                                die = finalSKill[0],
                                bonus = finalSKill[1].TrimStart('6')
                            };
                            imSkills.Add(newSkill);
                        }
                        AllSkills.Add(imSkills);
                    }
                    if (importedPokemon[s].Contains("Held Item:"))
                    {
                        AllDesc1.Add(importedPokemon[s + 1]);
                        if (importedPokemon[s + 1] == "Nothing is here.")
                            AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Blank.png"));
                        else
                        {
                            string[] temp = importedPokemon[s + 1].Split(':');
                            AllItems1.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + temp[0] + ".png"));
                        }
                    }
                }
                AllPokemon.Add(new Pokemon
                {
                    id = imName,
                    weight = imWeight,
                    size = imSize
                });
                BasePokemon.Add(new Pokemon
                {
                    hp = imbHP,
                    atk = imbATK,
                    def = imbDEF,
                    spatk = imbSPATK,
                    spdef = imbSPDEF,
                    spd = imbSPD
                });
                AllStat.Add(new List<string>
                    {
                        imHP,
                        imATK,
                        imDEF,
                        imSPATK,
                        imSPDEF,
                        imSPD
                    });
                AllShinyCheck.Add(false);
                AllStatus.Add(new StatusAfflictions
                {
                    Burned = false,
                    Frozen = false,
                    BadSleep = false,
                    Poisoned = false,
                    Cursed = false,
                    Rage = false,
                    Infatuation = false,
                    Asleep = false,
                    Blind = false,
                    TotalBlind = false,
                    Slowed = false,
                    Suppress = false,
                    Flinch = false,
                    Confused = false,
                    Paralysis = false,
                    Trapped = false,
                    Tripped = false,
                    Stuck = false,
                    Fainted = false,
                    Vulnerable = false
                });
                CombatStage.Add(new int[] { 0, 0, 0, 0, 0, 0 });
                hasScanned = true;
            }
        }
        private void PokeImportScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Dots += e.ProgressPercentage;
            if (Dots >= 30) { Dots = 0; }
            if (Dots <= 9) { lblProgress.Text = "Importing Scan.  "; }
            else if (Dots <= 19) { lblProgress.Text = "Importing Scan.. "; }
            else if (Dots <= 29) { lblProgress.Text = "Importing Scan..."; }
        }
        private void PokeImportScan_RunWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProgress.Text = "Import Complete";
            Current = AllPokemon.Count - 1;
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            pbPokemon.Image = AllImages[Current];
            SetPoke();
            WriteInfo();
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
        private void btnExit_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Application.Exit();
        }

        //===========================================================================================================
        //=== pbScan is the button in the form that takes you back to the main Pokedex. =============================
        //===========================================================================================================
        private void btnScan_MouseEnter(object sender, EventArgs e)
        {
            btnScan.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ChangeModeHover.png");
        }
        private void btnScan_MouseLeave(object sender, EventArgs e)
        {
            btnScan.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ChangeMode.png");
        }
        private void btnScan_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
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
        private void btnScanPokemon_MouseEnter(object sender, EventArgs e)
        {
            btnScanPokemon.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemonHover.png");
        }
        private void btnScanPokemon_MouseLeave(object sender, EventArgs e)
        {
            btnScanPokemon.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanPokemon.png");
        }
        private void btnScanPokemon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (isScanning) return;
            queueFinished = false;
            isScanning = true;
            pkLevelMin_ValueChanged(this, new EventArgs());
            pkLevelMax_ValueChanged(this, new EventArgs());
            PokeName = lbPokemon.SelectedItem.ToString();
            PokeHabitat = cbHabitat.Text;
            PokeType = cbType.Text;
            PokeStage = cbStageAllowed.Text;
            PokeNature = cbNature.Text;
            PokeReg = cbRegion.Text;
            PokeRegIndex = cbRegion.SelectedIndex;
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
        private void pbPokeLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
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
            WriteInfo();
        }
        private void pbPokeRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
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
            WriteInfo();
        }
        private void btnPokeRight_MouseEnter(object sender, EventArgs e)
        {
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRightHover.png");
        }
        private void btnPokeRight_MouseLeave(object sender, EventArgs e)
        {
            btnPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRight.png");
        }
        private void btnPokeLeft_MouseEnter(object sender, EventArgs e)
        {
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeftHover.png");
        }
        private void btnPokeLeft_MouseLeave(object sender, EventArgs e)
        {
            btnPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeft.png");
        }

        //===========================================================================================================
        //=== Enables the User to just press enter when editing the Damage amount in order to click the Damage ======
        //===== in the Ui. ==========================================================================================
        //===========================================================================================================
        private void pkDamage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pbDealDamage_MouseUp(this, new MouseEventArgs(MouseButtons.Left, 1, 1, 1, 0));
            }
        }

        //===========================================================================================================
        //=== Applies the damage in the Damage Amount NUD box to the current selected pokemon in the list. ==========
        //===========================================================================================================
        private void pbDealDamage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (isScanning) return;
            if (hasScanned)
            {
                if ((CurrentHealth[Current] - pkDamage.Value) > MaxHealth[Current])
                    CurrentHealth[Current] = MaxHealth[Current];
                else if ((CurrentHealth[Current] - pkDamage.Value) < 0 - (MaxHealth[Current] * 2))
                    CurrentHealth[Current] = 0 - (MaxHealth[Current] * 2);
                else
                   CurrentHealth[Current] -= pkDamage.Value;
                if (CurrentHealth[Current] <= 0)
                    AllStatus[Current].Fainted = true;
                else
                    AllStatus[Current].Fainted = false;
                WriteInfo();
            }
        }

        //===========================================================================================================
        //=== Updates the Deal Damage button in the UI. =============================================================
        //===========================================================================================================
        private void pbDealDamage_MouseEnter(object sender, EventArgs e)
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
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.png");
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }

        //===========================================================================================================
        //=== Opens FormOptions from FormScan, and creats a closing event to update after Options Edit. =============
        //===========================================================================================================
        private void btnOptions_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
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
        private void btnOptions_MouseEnter(object sender, EventArgs e)
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
        private void btnCry_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
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

        private void btnCry_MouseEnter(object sender, EventArgs e)
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
                foreach (string s in lbPokemon.Items)
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
                cbRegion_SelectedIndexChanged(this, new EventArgs());
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
            PokeNature = cbNature.Text;
            PokeReg = cbRegion.Text;
            PokeRegIndex = cbRegion.SelectedIndex;
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
        //=== 
        //===========================================================================================================
        private void btnRoll20Export_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (!hasScanned) return;
            PokeSaveDialog.FileName = tbName.Text.Trim();
            PokeSaveDialog.Filter = "JSON File | *.json";
            saveResult = PokeSaveDialog.ShowDialog() == DialogResult.OK;
            if (!saveResult) return;
            saveFilePath = PokeSaveDialog.FileName;
            PokeSaveJSON.RunWorkerAsync();
        }
        private void btnRoll20Export_MouseEnter(object sender, EventArgs e)
        {
            btnRoll20Export.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Roll20ExportHover.png");
        }
        private void btnRoll20Export_MouseLeave(object sender, EventArgs e)
        {
            btnRoll20Export.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Roll20Export.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnSave_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (!hasScanned) return;
            PokeSaveDialog.FileName = tbName.Text.Trim();
            PokeSaveDialog.Filter = "PokeGenesis Export File | *.pkgen";
            saveResult = PokeSaveDialog.ShowDialog() == DialogResult.OK;
            if (!saveResult) return;
            saveFilePath = PokeSaveDialog.FileName;
            PokeSaveScan.RunWorkerAsync();
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
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
        private void btnImport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            PokeImportDialog.Filter = "PokeGenesis Export File | *.pkgen";
            PokeImportDialog.Multiselect = true;
            PokeImportDialog.FileName = "";
            importResult = PokeImportDialog.ShowDialog() == DialogResult.OK;
            if (!importResult) return;
            PokeImportScan.RunWorkerAsync();
        }
        private void btnImport_MouseEnter(object sender, EventArgs e)
        {
            btnImport.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ImportHover.png");
        }
        private void btnImport_MouseLeave(object sender, EventArgs e)
        {
            btnImport.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Import.png");
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
                foreach (Spawn p in spawnList[selectRegion].Spawns)
                {
                    if(pokeDex.Contains(p.Name))
                        regionPokemon.Add(p.Name);
                }
                lbPokemon.DataSource = regionPokemon;
                nudLevelMax.Value = regionList[selectRegion].MaxLevel;
                nudLevelMin.Value = regionList[selectRegion].MinLevel;
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void nudHPCS_ValueChanged(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                CombatStage[Current][0] = Convert.ToInt32(nudHPCS.Value);
                WriteInfo();
            }
        }
        private void nudATKCS_ValueChanged(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                CombatStage[Current][1] = Convert.ToInt32(nudATKCS.Value);
                WriteInfo();
            }
        }
        private void nudDEFCS_ValueChanged(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                CombatStage[Current][2] = Convert.ToInt32(nudDEFCS.Value);
                WriteInfo();
            }
        }
        private void nudSPATKCS_ValueChanged(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                CombatStage[Current][3] = Convert.ToInt32(nudSPATKCS.Value);
                WriteInfo();
            }
        }
        private void nudSPDEFCS_ValueChanged(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                CombatStage[Current][4] = Convert.ToInt32(nudSPDEFCS.Value);
                WriteInfo();
            }
        }
        private void nudSPDCS_ValueChanged(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                CombatStage[Current][5] = Convert.ToInt32(nudSPDCS.Value);
                WriteInfo();
            }
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnDealOneTick_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (isScanning) return;
            if (hasScanned)
            {
                if ((CurrentHealth[Current] - Math.Round(MaxHealth[Current] / 10)) > MaxHealth[Current])
                    CurrentHealth[Current] = MaxHealth[Current];
                else if ((CurrentHealth[Current] - Math.Round(MaxHealth[Current] / 10)) < (0 - MaxHealth[Current] * 2))
                    CurrentHealth[Current] = 0 - (MaxHealth[Current] * 2);
                else
                    CurrentHealth[Current] -= Math.Round(MaxHealth[Current] / 10);
                if (CurrentHealth[Current] <= 0)
                    AllStatus[Current].Fainted = true;
                else
                    AllStatus[Current].Fainted = false;
                WriteInfo();
            }
        }
        private void btnDealOneTick_MouseEnter(object sender, EventArgs e)
        {
            btnDealOneTick.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealTickHover.png");
        }
        private void btnDealOneTick_MouseLeave(object sender, EventArgs e)
        {
            btnDealOneTick.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DealTick.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkBurned_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurned.Checked)
            {
                chkBurned.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    if (nudDEFCS.Value - 2 < -6)
                        nudDEFCS.Value = -6;
                    else
                        nudDEFCS.Value -= 2;
                    AllStatus[Current].Burned = true;
                    WriteInfo();
                }
            }
            else
            {
                chkBurned.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    if (nudDEFCS.Value + 2 > 6)
                        nudDEFCS.Value = 6;
                    else
                        nudDEFCS.Value += 2;
                    AllStatus[Current].Burned = false;
                    WriteInfo();
                }
            }
        }
        private void chkBurned_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkBurned);
            }
        }
        private void chkBurned_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkBurned), this.chkBurned, new Point(chkBurned.Width - 5 - 5, this.chkBurned.Height - 5));
        }
        private void chkBurned_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkBurned);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkFrozen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFrozen.Checked)
            {
                chkFrozen.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Frozen = true;
                    WriteInfo();
                }
            }
            else
            {
                chkFrozen.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Frozen = false;
                    WriteInfo();
                }
            }
        }
        private void chkFrozen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkFrozen);
            }
        }
        private void chkFrozen_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkFrozen), this.chkFrozen, new Point(chkFrozen.Width - 5, this.chkFrozen.Height - 5));
        }
        private void chkFrozen_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkFrozen);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkBadSleep_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBadSleep.Checked)
            {
                chkBadSleep.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].BadSleep = true;
                    WriteInfo();
                }
            }
            else
            {
                chkBadSleep.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].BadSleep = false;
                    WriteInfo();
                }
            }
        }
        private void chkBadSleep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkBadSleep);
            }
        }
        private void chkBadSleep_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkBadSleep), this.chkBadSleep, new Point(chkBadSleep.Width - 5, this.chkBadSleep.Height - 5));
        }
        private void chkBadSleep_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkBadSleep);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkPoisoned_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPoisoned.Checked)
            {
                chkPoisoned.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    if (nudSPDEFCS.Value - 2 < -6)
                        nudSPDEFCS.Value = -6;
                    else
                        nudSPDEFCS.Value -= 2;
                    AllStatus[Current].Poisoned = true;
                    WriteInfo();
                }
            }
            else
            {
                chkPoisoned.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    if (nudSPDEFCS.Value + 2 > 6)
                        nudSPDEFCS.Value = 6;
                    else
                        nudSPDEFCS.Value += 2;
                    AllStatus[Current].Poisoned = false;
                    WriteInfo();
                }
            }
        }
        private void chkPoisoned_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkPoisoned);
            }
        }
        private void chkPoisoned_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkPoisoned), this.chkPoisoned, new Point(chkPoisoned.Width - 5, this.chkPoisoned.Height - 5));
        }
        private void chkPoisoned_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkPoisoned);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkCursed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCursed.Checked)
            {
                chkCursed.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Cursed = true;
                    WriteInfo();
                }
            }
            else
            {
                chkCursed.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Cursed = false;
                    WriteInfo();
                }
            }
        }
        private void chkCursed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkCursed);
            }
        }
        private void chkCursed_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkCursed), this.chkCursed, new Point(chkCursed.Width - 5, this.chkCursed.Height - 5));
        }
        private void chkCursed_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkCursed);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkRage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRage.Checked)
            {
                chkRage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Rage = true;
                    WriteInfo();
                }
            }
            else
            {
                chkRage.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Rage = false;
                    WriteInfo();
                }
            }
        }
        private void chkRage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkRage);
            }
        }
        private void chkRage_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkRage), this.chkRage, new Point(chkRage.Width - 5, this.chkRage.Height - 5));
        }
        private void chkRage_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkRage);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkInfatuation_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInfatuation.Checked)
            {
                chkInfatuation.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Infatuation = true;
                    WriteInfo();
                }
            }
            else
            {
                chkInfatuation.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Infatuation = false;
                    WriteInfo();
                }
            }
        }
        private void chkInfatuation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkInfatuation);
            }
        }
        private void chkInfatuation_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkInfatuation), this.chkInfatuation, new Point(chkInfatuation.Width - 5, this.chkInfatuation.Height - 5));
        }
        private void chkInfatuation_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkInfatuation);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkAsleep_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAsleep.Checked)
            {
                chkAsleep.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Asleep = true;
                    WriteInfo();
                }
            }
            else
            {
                chkAsleep.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Asleep = false;
                    WriteInfo();
                }
            }
        }
        private void chkAsleep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkAsleep);
            }
        }
        private void chkAsleep_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkAsleep), this.chkAsleep, new Point(chkAsleep.Width - 5, this.chkAsleep.Height - 5));
        }
        private void chkAsleep_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkAsleep);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkBlind_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlind.Checked)
            {
                chkBlind.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Blind = true;
                    WriteInfo();
                }
            }
            else
            {
                chkBlind.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Blind = false;
                    WriteInfo();
                }
            }
        }
        private void chkBlind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkBlind);
            }
        }
        private void chkBlind_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkBlind), this.chkBlind, new Point(chkBlind.Width - 5, this.chkBlind.Height - 5));
        }
        private void chkBlind_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkBlind);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkTotalBlind_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTotalBlind.Checked)
            {
                chkTotalBlind.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].TotalBlind = true;
                    WriteInfo();
                }
            }
            else
            {
                chkTotalBlind.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].TotalBlind = false;
                    WriteInfo();
                }
            }
        }
        private void chkTotalBlind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkTotalBlind);
            }
        }
        private void chkTotalBlind_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkTotalBlind), this.chkTotalBlind, new Point(chkTotalBlind.Width - 5, this.chkTotalBlind.Height - 5));
        }
        private void chkTotalBlind_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkTotalBlind);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkSlowed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSlowed.Checked && hasScanned)
            {
                chkSlowed.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo)
                {
                    AllStatus[Current].Slowed = true;
                    WriteInfo();
                }
            }
            else
            {
                chkSlowed.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Slowed = false;
                    WriteInfo();
                }
            }
        }
        private void chkSlowed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkSlowed);
            }
        }
        private void chkSlowed_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkSlowed), this.chkSlowed, new Point(chkSlowed.Width - 5, this.chkSlowed.Height - 5));
        }
        private void chkSlowed_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkSlowed);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkSuppress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuppress.Checked)
            {
                chkSuppress.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Suppress = true;
                    WriteInfo();
                }
            }
            else
            {
                chkSuppress.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Suppress = false;
                    WriteInfo();
                }
            }
        }
        private void chkSuppress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkSuppress);
            }
        }
        private void chkSuppress_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkSuppress), this.chkSuppress, new Point(chkSuppress.Width - 5, this.chkSuppress.Height - 5));
        }
        private void chkSuppress_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkSuppress);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkFlinch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFlinch.Checked)
            {
                chkFlinch.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Flinch = true;
                    WriteInfo();
                }
            }
            else
            {
                chkFlinch.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Flinch = false;
                    WriteInfo();
                }
            }
        }
        private void chkFlinch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkFlinch);
            }
        }
        private void chkFlinch_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkFlinch), this.chkFlinch, new Point(chkFlinch.Width - 5, this.chkFlinch.Height - 5));
        }
        private void chkFlinch_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkFlinch);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkConfused_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfused.Checked)
            {
                chkConfused.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Confused = true;
                    WriteInfo();
                }
            }
            else
            {
                chkConfused.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Confused = false;
                    WriteInfo();
                }
            }
        }
        private void chkConfused_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkConfused);
            }
        }
        private void chkConfused_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkConfused), this.chkConfused, new Point(chkConfused.Width - 5, this.chkConfused.Height - 5));
        }
        private void chkConfused_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkConfused);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkParalysis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkParalysis.Checked)
            {
                chkParalysis.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    if (nudSPDCS.Value - 4 < -6)
                        nudSPDCS.Value = -6;
                    else
                        nudSPDCS.Value -= 4;
                    AllStatus[Current].Paralysis = true;
                    WriteInfo();
                }
            }
            else
            {
                chkParalysis.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    if (nudSPDCS.Value + 4 > 6)
                        nudSPDCS.Value = 6;
                    else
                        nudSPDCS.Value += 4;
                    AllStatus[Current].Paralysis = false;
                    WriteInfo();
                }
            }
        }
        private void chkParalysis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkParalysis);
            }
        }
        private void chkParalysis_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkParalysis), this.chkParalysis, new Point(chkParalysis.Width - 5, this.chkParalysis.Height - 5));
        }
        private void chkParalysis_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkParalysis);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkTrapped_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrapped.Checked)
            {
                chkTrapped.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Trapped = true;
                    WriteInfo();
                }
            }
            else
            {
                chkTrapped.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Trapped = false;
                    WriteInfo();
                }
            }
        }
        private void chkTrapped_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkTrapped);
            }
        }
        private void chkTrapped_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkTrapped), this.chkTrapped, new Point(chkTrapped.Width - 5, this.chkTrapped.Height - 5));
        }
        private void chkTrapped_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkTrapped);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkStuck_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStuck.Checked)
            {
                chkStuck.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Stuck = true;
                    WriteInfo();
                }
            }
            else
            {
                chkStuck.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Stuck = false;
                    WriteInfo();
                }
            }
        }
        private void chkStuck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkStuck);
            }
        }
        private void chkStuck_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkStuck), this.chkStuck, new Point(chkStuck.Width - 5, this.chkStuck.Height - 5));
        }
        private void chkStuck_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkStuck);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkVulnerable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVulnerable.Checked)
            {
                chkVulnerable.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Vulnerable = true;
                    WriteInfo();
                }
            }
            else
            {
                chkVulnerable.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Vulnerable = false;
                    WriteInfo();
                }
            }
        }
        private void chkVulnerable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkVulnerable);
            }
        }
        private void chkVulnerable_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkVulnerable), this.chkVulnerable, new Point(chkVulnerable.Width - 5, this.chkVulnerable.Height - 5));
        }
        private void chkVulnerable_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkVulnerable);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkFainted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFainted.Checked)
            {
                chkFainted.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Fainted = true;
                    WriteInfo();
                }
            }
            else
            {
                chkFainted.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Fainted = false;
                    WriteInfo();
                }
            }
        }
        private void chkFainted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkFainted);
            }
        }
        private void chkFainted_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkFainted), this.chkFainted, new Point(chkFainted.Width - 5, this.chkFainted.Height - 5));
        }
        private void chkFainted_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkFainted);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void chkTripped_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTripped.Checked)
            {
                chkTripped.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Checked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Tripped = true;
                    WriteInfo();
                }
            }
            else
            {
                chkTripped.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Unchecked.png");
                if (!isWritingInfo && hasScanned)
                {
                    AllStatus[Current].Tripped = false;
                    WriteInfo();
                }
            }
        }
        private void chkTripped_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(chkTripped);
            }
        }
        private void chkTripped_MouseHover(object sender, EventArgs e)
        {
                ttInfo.Show(ttInfo.GetToolTip(chkTripped), this.chkTripped, new Point(chkTripped.Width - 5, this.chkTripped.Height - 5));
        }
        private void chkTripped_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(chkTripped);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MinimizeButtonHover.png");
        }
        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MinimizeButton.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnGetLoot_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (fl == null)
            {
                fl = new FormLoot();
                fl.FormClosed += fl_FormClosed;
            }
            try { fl.Show(this); } catch { }
        }
        private void btnGetLoot_MouseEnter(object sender, EventArgs e)
        {
            btnGetLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootWindowHover.png");
        }
        private void btnGetLoot_MouseLeave(object sender, EventArgs e)
        {
            btnGetLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootWindow.png");
        }
        private void fl_FormClosed(object sender, FormClosedEventArgs e)
        {
            fl = null;
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void tbType_MouseEnter(object sender, EventArgs e)
        {
            if (hasScanned)
                ttInfo.Show(ttInfo.GetToolTip(tbType), this.tbType, new Point(tbType.Width, this.tbType.Top - 150));
        }
        private void tbType_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(tbType);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void lbMoves_MouseMove(object sender, MouseEventArgs e)
        {
            if (!hasScanned) return;
            int IndexPoint = lbMoves.IndexFromPoint(e.Location);
            try { lbMoves.Items[IndexPoint].ToString(); } catch { return; }
            if (lbMoves.Items[IndexPoint].ToString() == "Moves:") IndexPoint = 1;
            if (moveIndex != IndexPoint && lbMoves.Items.Count != 1)
            {
                string MoveTip = "No info to display...";
                string[] MoveName = lbMoves.Items[IndexPoint].ToString().Split('(');
                MoveName[1] = MoveName[1].Remove(MoveName[1].Length-1, 1);
                for (int s = 0; s < moveinfoList.Count; s++)
                {
                    if (moveinfoList[s].name == MoveName[0].Trim())
                    {
                        MoveTip = moveinfoList[s].description;
                    }
                }
                if (MoveTip != "No info to display...")
                {
                    try
                    {
                        if (tbType.Text.Contains(MoveName[1]))
                        {
                            string[] MoveListInfo = Regex.Split(MoveTip, "\r\n|\r|\n");
                            for (int s = 0; s < MoveListInfo.Count(); s++)
                            {
                                if (MoveListInfo[s].Contains("DB:"))
                                {
                                    StringBuilder build = new StringBuilder();
                                    string[] DamBase = MoveListInfo[s].Split(':');
                                    string STAB = (Convert.ToInt32(DamBase[1]) + 2).ToString();
                                    build.Append("DB:");
                                    build.Append(STAB);
                                    MoveListInfo[s] = build.ToString();
                                    build.Clear();
                                    foreach (string b in MoveListInfo)
                                    {
                                        build.Append(b + Environment.NewLine);
                                    }
                                    MoveTip = build.ToString();
                                }
                            }
                        }
                    }
                    catch { }
                }
                MoveTip = Regex.Replace(MoveTip, @"^\s*$[\r\n]*", "", RegexOptions.Multiline);
                moveIndex = IndexPoint;
                ttInfo.Hide(lbMoves);
                ttInfo.Show(MoveTip, lbMoves, lbMoves.Width / 2, 20 + (18 * IndexPoint));
            }
        }
        private void lbMoves_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(lbMoves);
            moveIndex = 0;
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void lbSkills_MouseMove(object sender, MouseEventArgs e)
        {
            if (!hasScanned) return;
            int IndexPoint = lbSkills.IndexFromPoint(e.Location);
            try { lbSkills.Items[IndexPoint].ToString(); } catch { return; }
            if (lbSkills.Items[IndexPoint].ToString() == "Skills:") IndexPoint = 1;
            if (skillIndex != IndexPoint && lbSkills.Items.Count != 1)
            {
                string SkillTip = "No info to display...";
                for (int s = 0; s < skillinfoList.Count; s++)
                {
                    if (lbSkills.Items[IndexPoint].ToString().Contains(skillinfoList[s].name))
                    {
                        SkillTip = skillinfoList[s].description;
                    }
                }
                SkillTip = Regex.Replace(SkillTip, @"^\s*$[\r\n]*", "", RegexOptions.Multiline);
                skillIndex = IndexPoint;
                ttInfo.Hide(lbSkills);
                ttInfo.Show(SkillTip, lbSkills, lbSkills.Width / 2, 20 + (18 * IndexPoint));
            }
        }
        private void lbSkills_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(lbSkills);
            skillIndex = 0;
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void lbCaps_MouseMove(object sender, MouseEventArgs e)
        {
            if (!hasScanned) return;
            int IndexPoint = lbCapabilites.IndexFromPoint(e.Location);
            try { lbCapabilites.Items[IndexPoint].ToString(); } catch { return; }
            if (capIndex != IndexPoint && lbCapabilites.Items.Count != 1)
            {
                string capTip = "No info to display...";
                for (int s = 0; s < capinfoList.Count; s++)
                {
                    if (lbCapabilites.Items[IndexPoint].ToString().Contains(capinfoList[s].name))
                    {
                        capTip = capinfoList[s].description;
                    }
                }
                capTip = Regex.Replace(capTip, @"^\s*$[\r\n]*", "", RegexOptions.Multiline);
                capIndex = IndexPoint;
                ttInfo.Hide(lbCapabilites);
                ttInfo.Show(capTip, lbCapabilites, lbCapabilites.Width / 2, 20 + (18 * IndexPoint));
            }
        }
        private void lbCapabilites_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(lbCapabilites);
            capIndex = 0;
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void lbAbilities_MouseMove(object sender, MouseEventArgs e)
        {
            if (!hasScanned) return;
            int IndexPoint = lbAbilities.IndexFromPoint(e.Location);
            try { lbAbilities.Items[IndexPoint].ToString(); } catch { return; }
            if (lbAbilities.Items[IndexPoint].ToString() == "Abilities:") IndexPoint = 1;
            if (abilityIndex != IndexPoint && lbAbilities.Items.Count != 1)
            {
                string abilityTip = "No info to display...";
                for (int s = 0; s < abilityinfoList.Count; s++)
                {
                    if (lbAbilities.Items[IndexPoint].ToString().Contains(abilityinfoList[s].name))
                    {
                        abilityTip = abilityinfoList[s].description;
                    }
                }
                abilityTip = Regex.Replace(abilityTip, @"^\s*$[\r\n]*", "", RegexOptions.Multiline);
                abilityIndex = IndexPoint;
                ttInfo.Hide(lbAbilities);
                ttInfo.Show(abilityTip, lbAbilities, lbAbilities.Width / 2, 20 + (18 * IndexPoint));
            }
        }
        private void lbAbilities_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(lbAbilities);
            abilityIndex = 0;
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void tbNature_MouseEnter(object sender, EventArgs e)
        {
            if (hasScanned)
            {
                string updown = "ERROR";
                for (int i = 0; i < natureList.Count; i++)
                {
                    if (natureList[i].id == tbNature.Text)
                    {
                        updown = "+" + natureList[i].up + " and -" + natureList[i].down;
                        break;
                    }
                }
                ttInfo.Show(updown, this.tbNature, new Point(tbNature.Width, this.tbNature.Top - 150));
            }
        }
        private void tbNature_MouseLeave(object sender, EventArgs e)
        {
            ttInfo.Hide(tbNature);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnDeletePoke_MouseUp(object sender, MouseEventArgs e)
        {
            if (!hasScanned) return;
            if (AllPokemon.Count < 2) return;
            DialogResult deletePokemon = MessageBox.Show("Are you sure you wish to delete " + AllPokemon[Current].id + "?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (deletePokemon == DialogResult.No) return;
            AllPokemon.RemoveAt(Current);
            BasePokemon.RemoveAt(Current);
            AllLevels.RemoveAt(Current);
            AllMoves.RemoveAt(Current);
            AllCap.RemoveAt(Current);
            AllAbilities.RemoveAt(Current);
            AllSkills.RemoveAt(Current);
            AllStat.RemoveAt(Current);
            AllShinyCheck.RemoveAt(Current);
            AllStatus.RemoveAt(Current);
            AllImages.RemoveAt(Current);
            AllItems1.RemoveAt(Current);
            AllDesc1.RemoveAt(Current);
            CombatStage.RemoveAt(Current);
            Gender.RemoveAt(Current);
            Type.RemoveAt(Current);
            MaxHealth.RemoveAt(Current);
            AllNatures.RemoveAt(Current);
            CurrentHealth.RemoveAt(Current);
            if (Current >= AllPokemon.Count)
                Current = 0;
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            pbPokemon.Image = AllImages[Current];
            SetPoke();
            WriteInfo();
        }
        private void btnDeletePoke_MouseEnter(object sender, EventArgs e)
        {
            btnDeletePoke.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DeletePokemonHover.png"));
        }
        private void btnDeletePoke_MouseLeave(object sender, EventArgs e)
        {
            btnDeletePoke.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\DeletePokemon.png"));
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnGoTo_MouseUp(object sender, MouseEventArgs e)
        {
            if (!hasScanned) return;
            Current = Convert.ToInt32(nudGoTo.Value - 1);
            tbPokeCount.Text = (Current + 1).ToString() + "/" + AllPokemon.Count.ToString();
            pbPokemon.Image = AllImages[Current];
            SetPoke();
            WriteInfo();
        }
        private void btnGoTo_MouseEnter(object sender, EventArgs e)
        {
            btnGoTo.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\GoToHover.png"));
        }
        private void btnGoTo_MouseLeave(object sender, EventArgs e)
        {
            btnGoTo.Image = (getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\GoTo.png"));
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void nudInjuries_ValueChanged(object sender, EventArgs e)
        {
            Injuries[Current] = nudInjuries.Value;
            WriteInfo();
        }
    }
}
