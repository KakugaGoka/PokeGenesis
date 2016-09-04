using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using GenesisDexEngine;


namespace GenesisDex
{
    public partial class FormMain : Form
    {
        List<Pokemon> pokeList = new List<Pokemon>();
        List<Mega> megaList = new List<Mega>();
        MegaList testMega = new MegaList();
        List<Evolution> evoList = new List<Evolution>();
        List<Skill> skillList = new List<Skill>();
        List<Capability> capList = new List<Capability>();
        List<Move> moveList = new List<Move>();
        List<Ability> abiList = new List<Ability>();
        List<Image> pokeImages = new List<Image>();
        List<Image> megaImages = new List<Image>();
        List<Image> megaxImages = new List<Image>();
        List<Image> megayImages = new List<Image>();
        List<string> updateList = new List<string>();
        int carryi { get; set; }
        int page = 1;
        int imageDisplayed = 0;
        int pbPokeLocX { get; set; }
        int pbPokeLocY { get; set; }
        bool mega { get; set; }
        bool megax { get; set; }
        bool viewMega { get; set; }
        bool onMegaX { get; set; }
        bool pokeChange { get; set; }
        bool done = false;
        List<string> pokeDex = new List<string>();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormMain()
        {
            InitializeComponent();
            pbPokeLocX = pbPokemon.Location.X;
            pbPokeLocY = pbPokemon.Location.Y;
            imageDisplayed = 0;
            updateList.Add("updating...");
            pbY.Visible = false;
            pbX.Visible = false;
            PokemonList pokeXML = new PokemonList();
            this.BackgroundImage = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MainMenu.PNG");
            pbPokeLeft.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeft.gif");
            pbPokeRight.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRight.gif");
            pbPokeAdd.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\AddPokemon.png");
            pokeList = pokeXML.createList("Pokemon");
            SortPokeList();
            for (var i = 0; i < pokeList.Count; i++)
            {
                pokeDex.Add(pokeList[i].id);
            }
            lbPokemon.DataSource = pokeDex;
            lbPokemon.SelectedIndex = 0;
        }

        private void lbPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pokeList == null) { return; }
            var i = 0;
            for (i = 0; i < pokeList.Count; i++)
            {
                try { if (lbPokemon.Text == pokeList[i].id.ToString()) { break; } } catch { }
            }
            pbY.Visible = false;
            pbX.Visible = false;
            try
            {
                megaList.Clear();
                megaList = testMega.createList("Mega" + pokeList[i].number);
                mega = megaList.Count() != 0;
            }
            catch { return; }
            try
            {
                megaList.Clear();
                megaList = testMega.createList("MegaX" + pokeList[i].number);
                megax = megaList.Count() != 0;
            }
            catch { return; }
            if (mega == true)
            {
                pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                viewMega = false;
            }
            else if (megax == true)
            {
                pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                onMegaX = false;
                viewMega = false;
            }
            else
            {
                pbY.Visible = false;
                pbX.Visible = false;
                pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaNo.PNG");

            }
            pokeImages.Clear();
            megaImages.Clear();
            megaxImages.Clear();
            megayImages.Clear();
            try
            {
                pokeImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + ".gif"));
            }
            catch { }
            int n = 0;
            done = false;
            while (done == false)
            {
                n++;
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-" + n + ".gif"))
                {
                    pokeImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-" + n + ".gif"));
                }
                else
                {
                    done = true;
                }
            }
            try
            {
                pokeImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + ".gif"));
            }
            catch { return; }
            n = 0;
            done = false;
            while (done == false)
            {
                n++;
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-" + n + ".gif"))
                {
                    pokeImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-" + n + ".gif"));
                }
                else
                {
                    done = true;
                }
            }
            if (mega == true)
            {
                megaImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega.gif"));
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-" + n + ".gif"))
                    {
                        megaImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
                megaImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega.gif"));
                n = 0;
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-" + n + ".gif"))
                    {
                        megaImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            if (megax == true)
            {
                megaxImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x.gif"));
                megayImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-y.gif"));
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x-" + n + ".gif"))
                    {
                        megaxImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-y-" + n + ".gif"))
                    {
                        megayImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-y-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
                megaxImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-x.gif"));
                megayImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-y.gif"));
                n = 0;
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-x-" + n + ".gif"))
                    {
                        megaxImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-x-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-y-" + n + ".gif"))
                    {
                        megayImages.Add(getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-y-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            viewMega = false;
            carryi = i;
            pbPokemon.Image = pokeImages[0];
            SetImage();
            imageDisplayed = 0;
            updatePage();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.PNG");
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.PNG");
        }

        private void pbMega_MouseHover(object sender, EventArgs e)
        {
            if (mega == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                }
                else
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffHover.PNG");
                }
            }
        }

        private void pbMega_MouseLeave(object sender, EventArgs e)
        {
            if (mega == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOn.PNG");
                }
                else
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                }
            }
        }

        private void pbMega_MouseClick(object sender, MouseEventArgs e)
        {
            int i = carryi;
            if (mega == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffHover.PNG");
                    viewMega = false;
                    pbPokemon.Image = pokeImages[0];
                    SetImage();
                    updatePage();
                }
                else
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                    viewMega = true;
                    pbPokemon.Image = megaImages[0];
                    SetImage();
                    updatePage();
                }
            }
            else if (megax == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffHover.PNG");
                    viewMega = false;
                    pbPokemon.Image = pokeImages[0];
                    SetImage();
                    pbY.Visible = false;
                    pbX.Visible = false;
                    updatePage();
                }
                else
                {
                    pbMega.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                    changeMega();
                    viewMega = true;
                    pbY.Visible = true;
                    pbX.Visible = true;
                    updatePage();
                }
            }
        }

        private void changeMega()
        {
            int i = carryi;
            if (onMegaX == false)
            {
                onMegaX = true;
                pbPokemon.Image = megaxImages[0];
                SetImage();
                pbY.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYOff.PNG");
                pbX.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaXOn.PNG");
                updatePage();
                return;
            }
            else if (onMegaX == true)
            {
                onMegaX = false;
                pbPokemon.Image = megayImages[0];
                SetImage();
                pbY.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYOn.PNG");
                pbX.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaXOff.PNG");
                updatePage();
                return;
            }
        }

        private void infoForward_MouseHover(object sender, EventArgs e)
        {
            infoForward.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRightHover.PNG");
        }

        private void infoBack_MouseHover(object sender, EventArgs e)
        {
            infoBack.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeftHover.PNG");
        }

        private void infoBack_MouseLeave(object sender, EventArgs e)
        {
            infoBack.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeft.PNG");
        }

        private void infoForward_MouseLeave(object sender, EventArgs e)
        {
            infoForward.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRight.PNG");
        }

        private void writeInfo()
        {
            int i = carryi;
            MegaList megaXML = new MegaList();
            if (viewMega == true)
            {
                if (megax == true)
                {
                    if (onMegaX == true)
                    {
                        megaList.Clear();
                        megaList = megaXML.createList("MegaX" + pokeList[i].number);
                        rtbInfo1.Text = string.Format(
                            "Number: {0}" + Environment.NewLine +
                            "Name: {1}" + Environment.NewLine +
                            "Type: {2}" + Environment.NewLine + Environment.NewLine +
                            "HP:\t\t{3}\t{16}" + Environment.NewLine +
                            "ATK:\t\t{4}\t{17}" + Environment.NewLine +
                            "DEF:\t\t{5}\t{18}" + Environment.NewLine +
                            "SPATK:\t\t{6}\t{19}" + Environment.NewLine +
                            "SPDEF:\t\t{7}\t{20}" + Environment.NewLine +
                            "SPD:\t\t{8}\t{21}" + Environment.NewLine + Environment.NewLine +
                            "Height: {9}" + Environment.NewLine +
                            "Weight: {10}" + Environment.NewLine + Environment.NewLine +
                            "Gender Ratio: {11}" + Environment.NewLine +
                            "Egg Group: {12}" + Environment.NewLine +
                            "Average Hatch Time: {13}" + Environment.NewLine + Environment.NewLine +
                            "Diet: {14}" + Environment.NewLine +
                            "Habitat: {15}",
                            pokeList[i].number, megaList[0].id, megaList[0].type, pokeList[i].hp, pokeList[i].atk, pokeList[i].def,
                            pokeList[i].spatk, pokeList[i].spdef, pokeList[i].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                            pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat, megaList[0].hp, megaList[0].atk,
                            megaList[0].def, megaList[0].spatk, megaList[0].spdef, megaList[0].spd);
                    }
                    else
                    {
                        megaList.Clear();
                        megaList = megaXML.createList("MegaY" + pokeList[i].number);
                        rtbInfo1.Text = string.Format(
                            "Number: {0}" + Environment.NewLine +
                            "Name: {1}" + Environment.NewLine +
                            "Type: {2}" + Environment.NewLine + Environment.NewLine +
                            "HP:\t\t{3}\t{16}" + Environment.NewLine +
                            "ATK:\t\t{4}\t{17}" + Environment.NewLine +
                            "DEF:\t\t{5}\t{18}" + Environment.NewLine +
                            "SPATK:\t\t{6}\t{19}" + Environment.NewLine +
                            "SPDEF:\t\t{7}\t{20}" + Environment.NewLine +
                            "SPD:\t\t{8}\t{21}" + Environment.NewLine + Environment.NewLine +
                            "Height: {9}" + Environment.NewLine +
                            "Weight: {10}" + Environment.NewLine + Environment.NewLine +
                            "Gender Ratio: {11}" + Environment.NewLine +
                            "Egg Group: {12}" + Environment.NewLine +
                            "Average Hatch Time: {13}" + Environment.NewLine + Environment.NewLine +
                            "Diet: {14}" + Environment.NewLine +
                            "Habitat: {15}",
                            pokeList[i].number, megaList[0].id, megaList[0].type, pokeList[i].hp, pokeList[i].atk, pokeList[i].def,
                            pokeList[i].spatk, pokeList[i].spdef, pokeList[i].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                            pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat, megaList[0].hp, megaList[0].atk,
                            megaList[0].def, megaList[0].spatk, megaList[0].spdef, megaList[0].spd);
                    }
                }
                else if (mega == true)
                {
                    megaList.Clear();
                    megaList = megaXML.createList("Mega" + pokeList[i].number);
                    rtbInfo1.Text = string.Format(
                        "Number: {0}" + Environment.NewLine +
                        "Name: {1}" + Environment.NewLine +
                        "Type: {2}" + Environment.NewLine + Environment.NewLine +
                        "HP:\t\t{3}\t{16}" + Environment.NewLine +
                        "ATK:\t\t{4}\t{17}" + Environment.NewLine +
                        "DEF:\t\t{5}\t{18}" + Environment.NewLine +
                        "SPATK:\t\t{6}\t{19}" + Environment.NewLine +
                        "SPDEF:\t\t{7}\t{20}" + Environment.NewLine +
                        "SPD:\t\t{8}\t{21}" + Environment.NewLine + Environment.NewLine +
                        "Height: {9}" + Environment.NewLine +
                        "Weight: {10}" + Environment.NewLine + Environment.NewLine +
                        "Gender Ratio: {11}" + Environment.NewLine +
                        "Egg Group: {12}" + Environment.NewLine +
                        "Average Hatch Time: {13}" + Environment.NewLine + Environment.NewLine +
                        "Diet: {14}" + Environment.NewLine +
                        "Habitat: {15}",
                        pokeList[i].number, megaList[0].id, megaList[0].type, pokeList[i].hp, pokeList[i].atk, pokeList[i].def,
                        pokeList[i].spatk, pokeList[i].spdef, pokeList[i].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                        pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat, megaList[0].hp, megaList[0].atk, 
                        megaList[0].def, megaList[0].spatk, megaList[0].spdef, megaList[0].spd);
                }
            }
            else
            {
                rtbInfo1.Text = string.Format(
                    "Number: {0}" + Environment.NewLine +
                    "Name: {1}" + Environment.NewLine +
                    "Type: {2}" + Environment.NewLine + Environment.NewLine +
                    "HP:\t\t{3}" + Environment.NewLine +
                    "ATK:\t\t{4}" + Environment.NewLine +
                    "DEF:\t\t{5}" + Environment.NewLine +
                    "SPATK:\t\t{6}" + Environment.NewLine +
                    "SPDEF:\t\t{7}" + Environment.NewLine +
                    "SPD:\t\t{8}" + Environment.NewLine + Environment.NewLine +
                    "Height: {9}" + Environment.NewLine +
                    "Weight: {10}" + Environment.NewLine + Environment.NewLine +
                    "Gender Ratio: {11}" + Environment.NewLine +
                    "Egg Group: {12}" + Environment.NewLine +
                    "Average Hatch Time: {13}" + Environment.NewLine + Environment.NewLine +
                    "Diet: {14}" + Environment.NewLine +
                    "Habitat: {15}",
                    pokeList[i].number, pokeList[i].id, pokeList[i].type, pokeList[i].hp, pokeList[i].atk, pokeList[i].def,
                    pokeList[i].spatk, pokeList[i].spdef, pokeList[i].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                    pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat);
            }
        }

        private void writeStats()
        {
            int i = carryi;
            CapabilityList capXML = new CapabilityList();
            SkillList skillXML = new SkillList();
            capList.Clear();
            skillList.Clear();
            capList = capXML.createList(pokeList[i].number);
            skillList = skillXML.createList(pokeList[i].number);
            rtbInfo1.Text = ("Capabilities:" + Environment.NewLine);
            for (var e = 0; e < capList.Count; e++)
            {
                rtbInfo1.Text += "-" + capList[e].cap + Environment.NewLine;
            }
            rtbInfo1.Text += Environment.NewLine + "Skills:" + Environment.NewLine;
            for (var e = 0; e < skillList.Count; e++)
            {
                rtbInfo1.Text += "-" + skillList[e].skill + Environment.NewLine;
            }

        }

        private void writeMoves()
        {
            int i = carryi;
            MoveList moveXML = new MoveList();
            moveList.Clear();
            moveList = moveXML.createList(pokeList[i].number);
            rtbInfo1.Text = ("Moves:" + Environment.NewLine);
            for (var e = 0; e < moveList.Count; e++)
            {
                rtbInfo1.Text += "-" + moveList[e].move + Environment.NewLine;
            }
        }

        private void writeEvo()
        {
            int i = carryi;
            EvolutionList evoXML = new EvolutionList();
            evoList.Clear();
            evoList = evoXML.createList(pokeList[i].number);
            rtbInfo1.Text = ("Evolutions:" + Environment.NewLine);
            for (var e = 0; e < evoList.Count; e++)
            {
                rtbInfo1.Text += "-" + evoList[e].evo + Environment.NewLine;
            }
            BasicAbiList basicXML = new BasicAbiList();
            AdvAbiList advXML = new AdvAbiList();
            HighAbiList highXML = new HighAbiList();
            abiList.Clear();
            abiList = basicXML.createList(pokeList[i].number);
            rtbInfo1.Text += Environment.NewLine + "Abilities:";
            for (var s = 0; s < abiList.Count; s++)
            {
                rtbInfo1.Text += Environment.NewLine + "Basic Ability - " + abiList[s].basicability;
            }
            abiList = advXML.createList(pokeList[i].number);
            for (var s = 0; s < abiList.Count; s++)
            {
                rtbInfo1.Text += Environment.NewLine + "Advanced Ability - " + abiList[s].advability;
            }
            abiList = highXML.createList(pokeList[i].number);
            for (var s = 0; s < abiList.Count; s++)
            {
                rtbInfo1.Text += Environment.NewLine + "High Ability - " + abiList[s].highability;
            }
            MegaList megaAbility = new MegaList();
            if (viewMega == true)
            {
                if (mega == true)
                {
                    megaList = megaAbility.createList("Mega" + pokeList[i].number);
                    rtbInfo1.Text += string.Format(Environment.NewLine + "Mega Ability - " + megaList[0].ability);
                }
                else if (megax == true)
                {
                    if (onMegaX == true)
                    {
                        megaList = megaAbility.createList("MegaX" + pokeList[i].number);
                        rtbInfo1.Text += string.Format(Environment.NewLine + "Mega Ability X - " + megaList[0].ability);
                    }
                    else
                    {
                        megaList = megaAbility.createList("MegaY" + pokeList[i].number);
                        rtbInfo1.Text += string.Format(Environment.NewLine + "Mega Ability Y - " + megaList[0].ability);
                    }
                }
            }
        }

        private void infoForward_Click(object sender, EventArgs e)
        {
            page += 1;
            updatePage();

        }

        private void infoBack_Click(object sender, EventArgs e)
        {
            page -= 1;
            updatePage();
        }

        private void updatePage()
        {
            if (page == 5) { page = 1; }
            if (page == 0) { page = 4; }
            tbPageCount.Text = page.ToString() + "/4";
            if (page == 1) { writeInfo(); }
            if (page == 2) { writeStats(); }
            if (page == 3) { writeMoves(); }
            if (page == 4) { writeEvo(); }
        }

        private void pbPokeRight_Click(object sender, EventArgs e)
        {
            if (viewMega == true)
            {
                if (megax == false)
                {
                    imageDisplayed += 1;
                    if (imageDisplayed >= pokeImages.Count) { imageDisplayed = 0; }
                    pbPokemon.Image = megaImages[imageDisplayed];
                }
                else
                {
                    if (onMegaX == true)
                    {
                        imageDisplayed += 1;
                        if (imageDisplayed >= pokeImages.Count) { imageDisplayed = 0; }
                        pbPokemon.Image = megaxImages[imageDisplayed];
                    }
                    else
                    {
                        imageDisplayed += 1;
                        if (imageDisplayed >= pokeImages.Count) { imageDisplayed = 0; }
                        pbPokemon.Image = megayImages[imageDisplayed];
                    }
                }
            }
            else
            {
                imageDisplayed += 1;
                if (imageDisplayed >= pokeImages.Count) { imageDisplayed = 0; }
                pbPokemon.Image = pokeImages[imageDisplayed];
            }
        }
        private void pbPokeLeft_Click(object sender, EventArgs e)
        {
            if (viewMega == true)
            {
                if (megax == false)
                {
                    if (imageDisplayed == 0) { imageDisplayed = pokeImages.Count - 1; }
                    else { imageDisplayed -= 1; }
                    pbPokemon.Image = megaImages[imageDisplayed];
                }
                else
                {
                    if (onMegaX == true)
                    {
                        if (imageDisplayed == 0) { imageDisplayed = pokeImages.Count - 1; }
                        else { imageDisplayed -= 1; }
                        pbPokemon.Image = megaxImages[imageDisplayed];
                    }
                    else
                    {
                        if (imageDisplayed == 0) { imageDisplayed = pokeImages.Count - 1; }
                        else { imageDisplayed -= 1; }
                        pbPokemon.Image = megayImages[imageDisplayed];
                    }
                }
            }
            else
            {
                if (imageDisplayed == 0) { imageDisplayed = pokeImages.Count - 1; }
                else { imageDisplayed -= 1; }
                pbPokemon.Image = pokeImages[imageDisplayed];
            }

        }

        private void pbX_Click(object sender, EventArgs e)
        {
            if (onMegaX == false)
            {
                changeMega();
            }
        }

        private void pbY_Click(object sender, EventArgs e)
        {
            if (onMegaX == true)
            {
                changeMega();
            }
        }

        private void pbPokeAdd_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormAdd fc = new FormAdd();
            fc.FormClosing += FormAddIsClosing;
            fc.Show();
        }

        private void FormAddIsClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }
            this.Show();
            RefreshPokedex();
            this.Update();
        }

        private void RefreshPokedex()
        {
            PokemonList pokeXML = new PokemonList();
            pokeDex.Clear();
            pokeList.Clear();
            pokeList = pokeXML.createList("Pokemon");
            SortPokeList();
            for (var i = 0; i < pokeList.Count; i++)
            {
                pokeDex.Add(pokeList[i].id);
            }
            lbPokemon.DataSource = updateList;
            lbPokemon.DataSource = pokeDex;
            lbPokemon.SelectedIndex = 0;
            lbPokemon.Refresh();
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

        private void pbPokeAdd_MouseHover(object sender, EventArgs e)
        {
            pbPokeAdd.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\AddPokemonHover.png");
        }

        private void pbPokeAdd_MouseLeave(object sender, EventArgs e)
        {
            pbPokeAdd.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\AddPokemon.png");
        }

        private void SortPokeList()
        {
            pokeList.Sort(delegate (Pokemon x, Pokemon y)
            {
                try { return x.number.CompareTo(y.number); } catch { return 0; }
            });
        }

        private void pbScan_MouseHover(object sender, EventArgs e)
        {
            pbScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanHover.png");

        }

        private void pbScan_Click(object sender, EventArgs e)
        {
            FormScan fs = new FormScan();
            this.Hide();
            fs.Show();
        }

        private void pbScan_MouseHover_1(object sender, EventArgs e)
        {
            pbScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanHover.png");
        }

        private void pbScan_MouseLeave(object sender, EventArgs e)
        {
            pbScan.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\Scan.png");
        }

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

        private void SetImage()
        {
            pbPokemon.Size = pbPokemon.Image.Size;
            pbPokemon.Location = new Point(203 - (pbPokemon.Width / 2), 305 - (pbPokemon.Height));
        }
    }
}
