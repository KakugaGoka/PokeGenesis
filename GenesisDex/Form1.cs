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
        int carryi { get; set; }
        bool mega { get; set; }
        bool viewMega { get; set; }
        List<string> pokeDex = new List<string>();
        System.Timers.Timer clickWait = new System.Timers.Timer();

        public FormMain()
        {
            InitializeComponent();
            PokemonList pokeXML = new PokemonList();
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MainMenu.PNG");
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
            pbPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Pokemon\\" + pokeList[i].number + ".gif");
            mega = File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Pokemon\\" + pokeList[i].number + "-mega.gif");
            if (mega == true)
            {
                pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                viewMega = false;

            }
            else
            {
                pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaNo.PNG"); ;
            }
            var pokeImage = pbPokemon.Image;
            int pokeH = (122 - pokeImage.Height) / 2;
            pbPokemon.Location = new Point(142, (182 + pokeH));
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
            carryi = i;
        }

        private void cbDex_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    pbPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Pokemon\\" + pokeList[i].number + ".gif");
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
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnHover.PNG");
                    viewMega = true;
                    pbPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Pokemon\\" + pokeList[i].number + "-mega.gif");
                    MegaList megaXML = new MegaList();
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
    }
}
