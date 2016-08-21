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
            pbPokemon.Location = new Point(142, (232 + pokeH));
            lblHP.Text = pokeList[i].hp;
            lblATK.Text = pokeList[i].atk;
            lblDEF.Text = pokeList[i].def;
            lblSPATK.Text = pokeList[i].spatk;
            lblSPDEF.Text = pokeList[i].spdef;
            lblSPD.Text = pokeList[i].spd;
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
                    clickWait.Enabled = false;
                }
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOff.PNG");
                    clickWait.Enabled = false;
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
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOnClick.PNG");
                    viewMega = false;
                    pbPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Pokemon\\" + pokeList[i].number + ".gif");
                    lblHP.Text = pokeList[i].hp;
                    lblATK.Text = pokeList[i].atk;
                    lblDEF.Text = pokeList[i].def;
                    lblSPATK.Text = pokeList[i].spatk;
                    lblSPDEF.Text = pokeList[i].spdef;
                    lblSPD.Text = pokeList[i].spd;

                    clickWait.Elapsed += new ElapsedEventHandler(pbMega_MouseLeave);
                    clickWait.Interval = 500;
                    clickWait.Enabled = true;
                }
                else
                {
                    pbMega.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MegaYesOffClick.PNG");
                    viewMega = true;
                    pbPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Pokemon\\" + pokeList[i].number + "-mega.gif");
                    MegaList megaXML = new MegaList();
                    megaList = megaXML.createList("Mega" + pokeList[i].number);
                    lblHP.Text = megaList[0].hp;
                    lblATK.Text = megaList[0].atk;
                    lblDEF.Text = megaList[0].def;
                    lblSPATK.Text = megaList[0].spatk;
                    lblSPDEF.Text = megaList[0].spdef;
                    lblSPD.Text = megaList[0].spd;
                    clickWait.Elapsed += new ElapsedEventHandler(pbMega_MouseLeave);
                    clickWait.Interval = 500;
                    clickWait.Enabled = true;
                }
            }
        }
    }
}
