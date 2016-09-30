using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenesisDexEngine;

namespace GenesisDex
{
    public partial class FormOptions : Form
    {
        OptionsList optionsXML = new OptionsList();
        List<Options> optionsList = new List<Options>();

        BanList banXML = new BanList();
        List<BannedPokemon> banList = new List<BannedPokemon>();

        PokemonList pokeXML = new PokemonList();
        List<Pokemon> pokeList = new List<Pokemon>();

        public FormOptions()
        {
            InitializeComponent();
            optionsList = optionsXML.createList();
            banList = banXML.createList();
            pokeList = pokeXML.createList("Pokemon");
            SortPokeList();
            nudPlayerLevel.Value = optionsList[0].MaxPlayerLevel;
            nudPokeLevel.Value = optionsList[0].MaxPokemonLevel;
            nudScanLimit.Value = optionsList[0].MaxScanAmount;
            nudTier.Value = optionsList[0].MaxItemTier;
            txtItemGasp1.Text = optionsList[0].OneItemGasp;
            txtItemGasp2.Text = optionsList[0].TwoItemGasp;
            txtPokeGasp.Text = optionsList[0].PokemonGasp;
            for(var i = 0; i < banList.Count; i++)
            {
                if(banList[i].PokeBan != "Placeholder")
                    listBanned.Items.Add(banList[i].PokeBan);
            }
            foreach(Pokemon s in pokeList)
            {
                if (!listBanned.Items.Contains(s.id))
                    listAllowed.Items.Add(s.id);
            }
        }

        private void SortPokeList()
        {
            pokeList.Sort(delegate (Pokemon x, Pokemon y)
            {
                try { return x.number.CompareTo(y.number); } catch { return 0; }
            });
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            if (listAllowed.SelectedItem != null)
            {
                listBanned.Items.Add(listAllowed.SelectedItem);
                listAllowed.Items.Remove(listAllowed.SelectedItem);
            }
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            if (listBanned.SelectedItem != null)
            {
                listAllowed.Items.Add(listBanned.SelectedItem);
                listBanned.Items.Remove(listBanned.SelectedItem);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> banned = new List<string>();
            banned = listBanned.Items.Cast<string>().ToList();
            XmlDocument docXml = new XmlDocument();
            docXml.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\Options.xml");
            XmlNode node = docXml.SelectSingleNode("/*/BanList");
            node.RemoveAll();
            docXml.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\Options.xml");
            XDocument docX = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\Options.xml");
            docX.Descendants().Where(d => string.IsNullOrEmpty(d.Value)).Remove();
            var maxPlayer = docX.Element("Options").Element("MaxPlayerLevel");
            var maxPokemon = docX.Element("Options").Element("MaxPokemonLevel");
            var maxScan = docX.Element("Options").Element("MaxScanAmount");
            var maxTier = docX.Element("Options").Element("MaxItemTier");
            var gasp1 = docX.Element("Options").Element("OneItemGasp");
            var gasp2 = docX.Element("Options").Element("TwoItemGasp");
            var gaspPoke = docX.Element("Options").Element("PokemonGasp");
            maxPlayer.Value = nudPlayerLevel.Value.ToString();
            maxPokemon.Value = nudPokeLevel.Value.ToString();
            maxScan.Value = nudScanLimit.Value.ToString();
            maxTier.Value = nudTier.Value.ToString();
            gasp1.Value = txtItemGasp1.Text;
            gasp2.Value = txtItemGasp2.Text;
            gaspPoke.Value = txtPokeGasp.Text;
            XElement ban;
            if (banned == null)
            {
                ban = new XElement("BanList",
                    new XElement("PokeBan", "PlaceHolder"));
            }
            else
            {
                ban = new XElement("BanList",
                    from b in banned
                    select new XElement("PokeBan", b));
            }
            docX.Root.Add(ban);
            docX.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\Options.xml");
            optionsList = new List<Options>();
            optionsList = optionsXML.createList();
            banList = new List<BannedPokemon>();
            banList = banXML.createList();
            pokeList = new List<Pokemon>();
            pokeList = pokeXML.createList("Pokemon");
            nudPlayerLevel.Value = optionsList[0].MaxPlayerLevel;
            nudPokeLevel.Value = optionsList[0].MaxPokemonLevel;
            nudScanLimit.Value = optionsList[0].MaxScanAmount;
            nudTier.Value = optionsList[0].MaxItemTier;
            txtItemGasp1.Text = optionsList[0].OneItemGasp;
            txtItemGasp2.Text = optionsList[0].TwoItemGasp;
            txtPokeGasp.Text = optionsList[0].PokemonGasp;
            listBanned.Items.Clear();
            listAllowed.Items.Clear();
            for (var i = 0; i < banList.Count; i++)
            {
                if (banList[i].PokeBan != "Placeholder")
                    listBanned.Items.Add(banList[i].PokeBan);
            }
            foreach (Pokemon s in pokeList)
            {
                if (!listBanned.Items.Contains(s.id))
                    listAllowed.Items.Add(s.id);
            }
            MessageBox.Show("Save Complete.");
        }
    }
}
