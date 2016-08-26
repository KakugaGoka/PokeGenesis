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
        ItemList typeXML = new ItemList();
        ItemList natureXML = new ItemList();
        ItemList habitatXML = new ItemList();
        List<Pokemon> pokeList = new List<Pokemon>();
        List<Move> moveList = new List<Move>();
        List<Ability> abiList = new List<Ability>();
        List<Skill> skillList = new List<Skill>();
        List<Capability> capList = new List<Capability>();
        Random rng = new Random();
        int pbPokeLocX { get; set; }
        int pbPokeLocY { get; set; }
        List<Items> habitatList = new List<Items>();
        List<Items> typeList = new List<Items>();
        List<Items> natureList = new List<Items>();
        List<string> habitats = new List<string>();
        List<string> types = new List<string>();

        public FormScan()
        {
            InitializeComponent();
            pbPokeLocX = pbPokemon.Location.X;
            pbPokeLocY = pbPokemon.Location.Y;
            pokeList = pokeXML.createList("Pokemon");
            typeList = typeXML.createList("Types", "Type");
            habitatList = habitatXML.createList("Habitats", "Habitat");
            natureList = natureXML.createList("Natures", "Nature");
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
            pkHabitat.DataSource = habitats;
            pkType.DataSource = types;
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
            pokeList.Clear();
            pokeList = pokeXML.createList("Pokemon");
            CheckHabitat();
            CheckType();
            string Nature = GetNature();
            Pokemon Pikachu = GetPokemon();
            int Level = GetLevel();
            Pokemon IChooseYou = LevelPokemon(Pikachu, Level);
            pbPokemon.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Pokemon\\" + IChooseYou.number + ".gif");
            SetImage();
            rtbInfo1.Text = "Number: " + IChooseYou.number + Environment.NewLine +
                "Name: " + IChooseYou.id + Environment.NewLine +
                "Type: " + IChooseYou.type + Environment.NewLine +
                Environment.NewLine +
                "Level: " + Level + Environment.NewLine +
                Environment.NewLine +
                "Stats:" + Environment.NewLine +
                "HP:\t\t" + IChooseYou.hp + Environment.NewLine +
                "ATK:\t\t" + IChooseYou.atk + Environment.NewLine +
                "DEF:\t\t" + IChooseYou.def + Environment.NewLine +
                "SPATK:\t\t" + IChooseYou.spatk + Environment.NewLine +
                "SPDEF:\t\t" + IChooseYou.spdef + Environment.NewLine +
                "SPD:\t\t" + IChooseYou.spd + Environment.NewLine +
                Environment.NewLine +
                "Size: " + IChooseYou.size + Environment.NewLine +
                "Weight: " + IChooseYou.weight;
                
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

        private void CheckHabitat()
        {
            string Habitat = pkHabitat.SelectedText;
            if (Habitat == "Any") { return; }
            for(var e = 0; e < pokeList.Count; e++)
            {
                capList = capXML.createList(pokeList[e].number);
                for (var c = 0; c < capList.Count; c++)
                {
                    if (capList[c].cap.Contains(Habitat) != true)
                    {
                        capList.RemoveAt(c);
                        c -= 1;
                    }
                }
                if (capList.Count == 0)
                {
                    pokeList.RemoveAt(e);
                    e -= 1;
                }
            }

        }

        private void CheckType()
        {
            string Type = pkType.SelectedText;
            if ( Type == "Any") { return; }
            for (var e = 0; e < pokeList.Count; e++)
            {
                if (pokeList[e].type.Contains(Type) != true)
                {
                    pokeList.RemoveAt(e);
                    e -= 1;
                }
                      
            }
        }

        private string GetNature()
        {
            natureList = natureXML.createList("Natures", "Nature");
            int i = rng.Next(0, natureList.Count - 1);
            return natureList[i].id;
        }

        private Pokemon GetPokemon()
        {
            int i = rng.Next(0, pokeList.Count - 1);
            return pokeList[i];
        }

        private int GetLevel()
        {
            int min = Convert.ToInt32(pkLevelMin.Value);
            int max = Convert.ToInt32(pkLevelMax.Value);
            int i = rng.Next(min, max);
            return i;
        }

        private void SetImage()
        {
            var pokePic = pbPokemon.Image;
            int pokeH = (pokePic.Height);
            int pbH = pbPokemon.Height;
            pbPokemon.Location = new Point(pbPokeLocX, (pbPokeLocY + ((pbH / 2) - (pokeH / 2))));
        }

        private Pokemon LevelPokemon(Pokemon poke, int level)
        {
            List<int> stats = new List<int>();
            List<int> oldstats = new List<int>();
            stats.Clear();
            stats.Add(Convert.ToInt32(poke.hp));
            stats.Add(Convert.ToInt32(poke.atk));
            stats.Add(Convert.ToInt32(poke.def));
            stats.Add(Convert.ToInt32(poke.spatk));
            stats.Add(Convert.ToInt32(poke.spdef));
            stats.Add(Convert.ToInt32(poke.spd));
            oldstats = stats;
            SortStats(stats);
            var x = 0;
            int hp = 0;
            int atk = 0;
            int def = 0;
            int spatk = 0;
            int spdef = 0;
            int spd = 0;
            for (x = 0; x < stats.Count; x++)
            {
                if (stats[x] == oldstats[5]) { hp = x; }
            }
            for (x = 0; x < stats.Count; x++)
            {
                if (stats[x] == oldstats[4]) { atk = x; }
            }
            for (x = 0; x < stats.Count; x++)
            {
                if (stats[x] == oldstats[3]) { def = x; }
            }
            for (x = 0; x < stats.Count; x++)
            {
                if (stats[x] == oldstats[2]) { spatk = x; }
            }
            for (x = 0; x < stats.Count; x++)
            {
                if (stats[x] == oldstats[1]) { spdef = x; }
            }
            for (x = 0; x < stats.Count; x++)
            {
                if (stats[x] == oldstats[0]) { spd = x; }
            }
            int a = stats[0];
            int b = stats[1];
            int c = stats[2];
            int d = stats[3];
            int e = stats[4];
            int f = stats[5];
            for (var l = level; l > 0; l-= 1)
            {
                int z = rng.Next(0, 5) + 1;
                if (z == 1)
                {
                    if (b == a) { a += 1; }
                    else if (b > a - 2) { z += 1; }
                    else { a += 1; }
                }
                else if (z == 2)
                {
                    if (c == b) { b += 1; }
                    else if (c > b - 2) { z += 1; }
                    else { b += 1; }
                }
                else if (z == 3)
                {
                    if (d == c) { c += 1; }
                    else if (d > c - 2) { z += 1; }
                    else { c += 1; }
                }
                else if (z == 4)
                {
                    if (e == d) { d += 1; }
                    else if (e > d - 2) { z += 1; }
                    else { d += 1; }
                }
                else if (z == 5)
                {
                    if (f == e) { e += 1; }
                    else if (f > e - 2) { z += 1; }
                    else { e += 1; }
                }
                else if (z == 6)
                {
                    if (f == e) { e += 1; }
                    else if (f == e-1) { l += 1; }
                    else { e += 1; }
                }
            }
            stats[0] = a;
            stats[1] = b;
            stats[2] = c;
            stats[3] = d;
            stats[4] = e;
            stats[5] = f;

            poke.hp = stats[hp].ToString();
            poke.atk = stats[atk].ToString();
            poke.def = stats[def].ToString();
            poke.spatk = stats[spatk].ToString();
            poke.spdef = stats[spdef].ToString();
            poke.spd = stats[spd].ToString();

            return poke;

        }

        private void SortStats(List<int> stats)
        {
            stats.Sort(delegate (int x, int y)
            {
                return y.CompareTo(x);
            });
        }
    }
}
