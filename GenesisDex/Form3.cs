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
        AbilityList abiXML = new AbilityList();
        SkillList skillXML = new SkillList();
        CapabilityList capXML = new CapabilityList();
        List<Pokemon> pokeList = new List<Pokemon>();
        List<Move> moveList = new List<Move>();
        List<Ability> abiList = new List<Ability>();
        List<Skill> skillList = new List<Skill>();
        List<Capability> capList = new List<Capability>();
        Random rng = new Random();
        int pbPokeLocX { get; set; }
        int pbPokeLocY { get; set; }

        public FormScan()
        {
            InitializeComponent();
            pbPokeLocX = pbPokemon.Location.X;
            pbPokeLocY = pbPokemon.Location.Y;
            pokeList = pokeXML.createList("Pokemon");
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

        private void pbScanPokemon_Click(object sender, EventArgs e)
        {
            int i = rng.Next(0, pokeList.Count -1);
            pbPokemon.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + pokeList[i].number + ".gif");
            var pokePic = pbPokemon.Image;
            int pokeH = (pokePic.Height);
            int pbH = pbPokemon.Height;
            pbPokemon.Location = new Point(pbPokeLocX, (pbPokeLocY + ((pbH / 2) - (pokeH / 2))));
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
    }
}
