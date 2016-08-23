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
        List<Evolution> evoList = new List<Evolution>();
        List<Skill> skillList = new List<Skill>();
        List<Capability> capList = new List<Capability>();
        List<Move> moveList = new List<Move>();
        List<Ability> abiList = new List<Ability>();
        List<Image> pokeImages = new List<Image>();
        List<Image> megaImages = new List<Image>();
        List<Image> megaxImages = new List<Image>();
        List<Image> megayImages = new List<Image>();
        int carryi { get; set; }
        int page = 1;
        int imageDisplayed = 1;
        bool mega { get; set; }
        bool megax { get; set; }
        bool viewMega { get; set; }
        bool onMegaX { get; set; }
        bool pokeChange { get; set; }
        bool done = false;
        List<string> pokeDex = new List<string>();
        System.Timers.Timer clickWait = new System.Timers.Timer();

        public FormMain()
        {
            InitializeComponent();
            pbY.Visible = false;
            pbX.Visible = false;
            PokemonList pokeXML = new PokemonList();
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MainMenu.PNG");
            pbPokeLeft.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonLeft.gif");
            pbPokeRight.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\PokemonRight.gif");
            pokeList = pokeXML.createList("Pokemon");
            for (var i = 0; i < pokeList.Count; i++)
            {
                pokeDex.Add(pokeList[i].id);
            }
            lbPokemon.DataSource = pokeDex;
        }

        private void lbPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = 0;
            for (i = 0; i < pokeList.Count; i++)
            {
                if (lbPokemon.Text == pokeList[i].id.ToString()) { break; }
            }
            mega = File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega.gif");
            megax = File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x.gif");
            if (mega == true)
            {
                pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                pbY.Visible = false;
                pbX.Visible = false;
                viewMega = false;
            }
            else if (megax == true)
            {
                pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                onMegaX = false;
                pbY.Visible = true;
                pbX.Visible = true;
                viewMega = false;
            }
            else
            {
                pbY.Visible = false;
                pbX.Visible = false;
                pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaNo.PNG");
                
            }
            pokeImages.Clear();
            megaImages.Clear();
            megaxImages.Clear();
            megayImages.Clear();
            pokeImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + ".gif"));
            int n = 0;
            while (done == false)
            {
                n++;
                if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-" + n + ".gif"))
                {
                    pokeImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-" + n + ".gif"));
                }
                else
                {
                    done = true;
                }
            }
            pokeImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + ".gif"));
            n = 0;
            done = false;
            while (done == false)
            {
                n++;
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-" + n + ".gif"))
                {
                    pokeImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-" + n + ".gif"));
                }
                else
                {
                    done = true;
                }
            }
            if (mega == true)
            {
                megaImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega.gif"));
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-" + n + ".gif"))
                    {
                        megaImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
                megaImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega.gif"));
                n = 0;
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-" + n + ".gif"))
                    {
                        megaImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
            if (megax == true)
            {
                megaxImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x.gif"));
                megayImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-y.gif"));
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x-" + n + ".gif"))
                    {
                        megaxImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-x-" + n + ".gif"));
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
                        megayImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + "-mega-y-" + n + ".gif"));
                    }
                    else
                    {
                        done = true;
                    }
                }
                megaxImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-x.gif"));
                megayImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-y.gif"));
                n = 0;
                done = false;
                while (done == false)
                {
                    n++;
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-x-" + n + ".gif"))
                    {
                        megaxImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-x-" + n + ".gif"));
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
                        megayImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Shiny\\" + pokeList[i].number + "-mega-y-" + n + ".gif"));
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
            var pokePic = pbPokemon.Image;
            int pokeH = (122 - pokePic.Height) / 2;
            pbPokemon.Location = new Point(114, (171 + pokeH));
            updatePage();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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
            Environment.Exit(0);
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.PNG");
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.PNG");
        }

        private void pbMega_MouseHover(object sender, EventArgs e)
        {
            if (mega == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                }
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffHover.PNG");
                }
            }
        }

        private void pbMega_MouseLeave(object sender, EventArgs e)
        {
            if (mega == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOn.PNG");
                }
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
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
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffHover.PNG");
                    viewMega = false;
                    pbPokemon.Image = pokeImages[0];
                    updatePage();
                }
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                    viewMega = true;
                    pbPokemon.Image = megaImages[0];
                    updatePage();
                }
            }
            else if (megax == true)
            {
                if (viewMega == true)
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffHover.PNG");
                    viewMega = false;
                    pbPokemon.Image = pokeImages[0];
                    updatePage();
                }
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                    changeMega();
                    viewMega = true;
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
                pbY.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYOff.PNG");
                pbX.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaXOn.PNG");
                updatePage();
                return;
            }
            if (onMegaX == true)
            {
                onMegaX = false;
                pbPokemon.Image = megayImages[0];
                pbY.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYOn.PNG");
                pbX.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaXOff.PNG");
                updatePage();
                return;
            }
        }

        private void infoForward_MouseHover(object sender, EventArgs e)
        {
            infoForward.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRightHover.PNG");
        }

        private void infoBack_MouseHover(object sender, EventArgs e)
        {
            infoBack.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeftHover.PNG");
        }

        private void infoBack_MouseLeave(object sender, EventArgs e)
        {
            infoBack.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoLeft.PNG");
        }

        private void infoForward_MouseLeave(object sender, EventArgs e)
        {
            infoForward.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\InfoRight.PNG");
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
                        megaList = megaXML.createList("MegaX" + pokeList[i].number);
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
                            pokeList[i].number, megaList[0].id, megaList[0].type, megaList[0].hp, megaList[0].atk, megaList[0].def,
                            megaList[0].spatk, megaList[0].spdef, megaList[0].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                            pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat);
                    }
                    else
                    {
                        megaList = megaXML.createList("MegaY" + pokeList[i].number);
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
                            pokeList[i].number, megaList[0].id, megaList[0].type, megaList[0].hp, megaList[0].atk, megaList[0].def,
                            megaList[0].spatk, megaList[0].spdef, megaList[0].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                            pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat);
                    }
                }
                else if (mega == true)
                {
                    megaList = megaXML.createList("Mega" + pokeList[i].number);
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
                        pokeList[i].number, megaList[0].id, megaList[0].type, megaList[0].hp, megaList[0].atk, megaList[0].def,
                        megaList[0].spatk, megaList[0].spdef, megaList[0].spd, pokeList[i].size, pokeList[i].weight, pokeList[i].gender,
                        pokeList[i].egg, pokeList[i].hatch, pokeList[i].diet, pokeList[i].habitat);
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
            capList = capXML.createList(pokeList[i].number);
            skillList = skillXML.createList(pokeList[i].number);
            rtbInfo1.Text = ("Capabilities:" + Environment.NewLine);
            for (var e = 0; e < capList.Count; e++)
            {
                rtbInfo1.Text += "-" + capList[e].cap + Environment.NewLine;
            }
            rtbInfo1.Text += (Environment.NewLine + "Skills:" + Environment.NewLine);
            for (var e = 0; e < skillList.Count; e++)
            {
                rtbInfo1.Text += "-" + skillList[e].skill + Environment.NewLine;
            }
        }

        private void writeMoves()
        {
            int i = carryi;
            MoveList moveXML = new MoveList();
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
            evoList = evoXML.createList(pokeList[i].number);
            rtbInfo1.Text = ("Evolutions:" + Environment.NewLine);
            for (var e = 0; e < evoList.Count; e++)
            {
                rtbInfo1.Text += "-" + evoList[e].evo + Environment.NewLine;
            }
            AbilityList abiXML = new AbilityList();
            abiList = abiXML.createList(pokeList[i].number);
            rtbInfo1.Text += string.Format(Environment.NewLine + "Basic Abilities:" + Environment.NewLine +
                "-{0}" + Environment.NewLine + 
                "-{1}" + Environment.NewLine + Environment.NewLine +
                "Advanced Abilities:" + Environment.NewLine +
                "-{2}" + Environment.NewLine + 
                "-{3}" + Environment.NewLine + Environment.NewLine +
                "High Ability:" + Environment.NewLine +
                "-{4}", 
                abiList[0].ability, abiList[1].ability,
                abiList[2].ability, abiList[3].ability,
                abiList[4].ability);
            MegaList megaAbility = new MegaList();
            if (viewMega == true)
            {
                if (mega == true)
                {
                    megaList = megaAbility.createList("Mega" + pokeList[i].number);
                    rtbInfo1.Text += string.Format(Environment.NewLine + Environment.NewLine + "Mega Ability:" + Environment.NewLine +
                        "-" + megaList[0].ability);
                }
                else if (megax == true)
                {
                    if (onMegaX == true)
                    {
                        megaList = megaAbility.createList("MegaX" + pokeList[i].number);
                        rtbInfo1.Text += string.Format(Environment.NewLine + Environment.NewLine + "Mega Ability X:" + Environment.NewLine +
                            "-" + megaList[0].ability);
                    }
                    else
                    {
                        megaList = megaAbility.createList("MegaY" + pokeList[i].number);
                        rtbInfo1.Text += string.Format(Environment.NewLine + Environment.NewLine + "Mega Ability Y:" + Environment.NewLine +
                            "-" + megaList[0].ability);
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
    }
}
