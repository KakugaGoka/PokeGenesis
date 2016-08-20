using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GenesisDexEngine;


namespace GenesisDex
{
    public partial class Form1 : Form
    {

        List<Pokemon> pokeList = new List<Pokemon>();
        List<string> pokeDex = new List<string>();

        public Form1()
        {
            InitializeComponent();
            PokemonList pokeXML = new PokemonList();
            pokeList = pokeXML.createList("Pokemon", "Pokemon");
            for (var i = 0; i < pokeList.Count; i++)
            {
                pokeDex.Add(pokeList[i].id);
            }
            cbDex.DataSource = pokeDex;
        }

        private void cbDex_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = 0;
            for (i = 0; i < pokeList.Count; i++)
            {
                if (cbDex.Text == pokeList[i].id.ToString()) { break; }
            }
            pbPokemon.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\" + pokeList[i].number + ".gif");
            pbPokemon.Location = new Point(18, 47);
            var pokeImage = pbPokemon.Image;
            int pokeH = (122-pokeImage.Height)/2;
            pbPokemon.Location = new Point(18, (47 + pokeH));
            lblHP.Text = pokeList[i].hp;
            lblATK.Text = pokeList[i].atk;
            lblDEF.Text = pokeList[i].def;
            lblSPATK.Text = pokeList[i].spatk;
            lblSPDEF.Text = pokeList[i].spdef;
            lblSPD.Text = pokeList[i].spd;
        }
    }
}
