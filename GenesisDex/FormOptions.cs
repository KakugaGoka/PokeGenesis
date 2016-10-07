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
        Point dragCursorPoint = new Point();
        Point dragFormPoint = new Point();

        OptionsList optionsXML = new OptionsList();
        List<Options> optionsList = new List<Options>();

        BanList banXML = new BanList();
        List<string> banList = new List<string>();

        PokemonList pokeXML = new PokemonList();
        List<Pokemon> pokeList = new List<Pokemon>();

        bool dragging { get; set; }
        bool restoreDefaults { get; set; }

        public FormOptions()
        {
            InitializeComponent();
            dragging = false;
            restoreDefaults = false;
            RefreshOptions();
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
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
            var maxItemTier = docX.Element("Options").Element("MaxItemTier");
            var cashPerLevel = docX.Element("Options").Element("CashPerLevel");
            var cryVolume = docX.Element("Options").Element("CryVolume");
            var gasp1 = docX.Element("Options").Element("OneItemGasp");
            var gasp2 = docX.Element("Options").Element("TwoItemGasp");
            var gaspPoke = docX.Element("Options").Element("PokemonGasp");
            var gaspShiny = docX.Element("Options").Element("ShinyGasp");
            maxPlayer.Value = nudPlayerLevel.Value.ToString();
            maxPokemon.Value = nudPokeLevel.Value.ToString();
            maxScan.Value = nudScanLimit.Value.ToString();
            maxItemTier.Value = nudItemTier.Value.ToString();
            cashPerLevel.Value = nudCashPerLevel.Value.ToString();
            cryVolume.Value = nudCryVolume.Value.ToString();
            gasp1.Value = txtItemGasp1.Text;
            gasp2.Value = txtItemGasp2.Text;
            gaspPoke.Value = txtPokeGasp.Text;
            gaspShiny.Value = txtShinyGasp.Text;
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
            RefreshOptions();
            if (restoreDefaults)
                MessageBox.Show("Defaults Restored.");
            else
                MessageBox.Show("Save Complete.");
            restoreDefaults = false;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            DialogResult confirmDefault = MessageBox.Show("Are you sure you wish to restore the default options?", "Confirm Restore Default", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmDefault == DialogResult.Yes)
            {
                pokeList = new List<Pokemon>();
                pokeList = pokeXML.createList("Pokemon");
                nudPlayerLevel.Value = 50;
                nudPokeLevel.Value = 100;
                nudScanLimit.Value = 100;
                nudItemTier.Value = 4;
                nudCashPerLevel.Value = 100;
                nudCryVolume.Value = 3;
                txtItemGasp1.Text = "It has something!";
                txtItemGasp2.Text = "It has a few things!";
                txtPokeGasp.Text = "It's a ~p";
                txtShinyGasp.Text = "It's a Shiny ~p";
                listBanned.Items.Clear();
                listAllowed.Items.Clear();
                foreach (Pokemon s in pokeList)
                {
                    if (!listBanned.Items.Contains(s.id))
                        listAllowed.Items.Add(s.id);
                }
                restoreDefaults = true;
                btnSave_Click(this, new EventArgs());
            }
        }

        //===========================================================================================================
        //===========================================================================================================
        private void FormOptions_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void FormOptions_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void FormOptions_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd fc = new FormAdd();
            fc.FormClosing += FormAddIsClosing;
            fc.Show();
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void FormAddIsClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }
            this.Show();
            RefreshOptions();
            this.Update();
        }
        //===========================================================================================================
        //===========================================================================================================

        private void RefreshOptions()
        {
            optionsList = new List<Options>();
            optionsList = optionsXML.createList();
            banList = new List<string>();
            banList = banXML.createList();
            pokeList = new List<Pokemon>();
            pokeList = pokeXML.createList("Pokemon");
            nudPlayerLevel.Value = optionsList[0].MaxPlayerLevel;
            nudPokeLevel.Value = optionsList[0].MaxPokemonLevel;
            nudScanLimit.Value = optionsList[0].MaxScanAmount;
            nudItemTier.Value = optionsList[0].MaxItemTier;
            nudCashPerLevel.Value = optionsList[0].CashPerLevel;
            nudCryVolume.Value = optionsList[0].CryVolume;
            txtItemGasp1.Text = optionsList[0].OneItemGasp;
            txtItemGasp2.Text = optionsList[0].TwoItemGasp;
            txtPokeGasp.Text = optionsList[0].PokemonGasp;
            txtShinyGasp.Text = optionsList[0].ShinyGasp;
            listBanned.Items.Clear();
            listAllowed.Items.Clear();
            for (var i = 0; i < banList.Count; i++)
            {
                if (banList[i] != "Placeholder")
                    listBanned.Items.Add(banList[i]);
            }
            foreach (Pokemon s in pokeList)
            {
                if (!listBanned.Items.Contains(s.id))
                    listAllowed.Items.Add(s.id);
            }
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.png");
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }
    }
}

