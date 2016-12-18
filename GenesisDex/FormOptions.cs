using System;
using System.Reflection;
using System.IO;
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

        RegionsList regionXML = new RegionsList();
        List<PokeRegion> regionList = new List<PokeRegion>();

        SpawnList spawnXML = new SpawnList();
        List<PokeRegion> spawnList = new List<PokeRegion>();

        List<int> spawnRate = new List<int>();

        bool dragging { get; set; }
        bool restoreDefaults { get; set; }

        public FormOptions()
        {
            InitializeComponent();
            dragging = false;
            restoreDefaults = false;
            RefreshOptions();
            RefreshRegions();
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
            if (listAllowed.SelectedItems != null)
            {
                for (int i = 0; i < listAllowed.SelectedItems.Count; i++)
                {
                    listBanned.Items.Add(listAllowed.SelectedItems[i]);
                    listAllowed.Items.Remove(listAllowed.SelectedItems[i]);
                    i--;
                }
            }
        }

        private void btnAllow_Click(object sender, EventArgs e)
        {
            if (listBanned.SelectedItems != null)
            {
                for (int i = 0; i < listBanned.SelectedItems.Count; i++)
                {
                    listAllowed.Items.Add(listBanned.SelectedItems[i]);
                    listBanned.Items.Remove(listBanned.SelectedItems[i]);
                    i--;
                }
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
            var skinIndex = docX.Element("Options").Element("PokedexSkin");
            maxPlayer.Value = nudPlayerLevel.Value.ToString();
            maxPokemon.Value = nudPokeLevel.Value.ToString();
            maxScan.Value = nudScanLimit.Value.ToString();
            maxItemTier.Value = nudItemTier.Value.ToString();
            cashPerLevel.Value = nudCashPerLevel.Value.ToString();
            cryVolume.Value = nudCryVolume.Value.ToString();
            skinIndex.Value = nudDexSkin.Value.ToString();
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
                pokeList = pokeXML.createList();
                nudPlayerLevel.Value = 50;
                nudPokeLevel.Value = 100;
                nudScanLimit.Value = 100;
                nudItemTier.Value = 4;
                nudCashPerLevel.Value = 100;
                nudCryVolume.Value = 3;
                nudDexSkin.Value = 1;
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
            pokeList = pokeXML.createList();
            nudPlayerLevel.Value = optionsList[0].MaxPlayerLevel;
            nudPokeLevel.Value = optionsList[0].MaxPokemonLevel;
            nudScanLimit.Value = optionsList[0].MaxScanAmount;
            nudItemTier.Value = optionsList[0].MaxItemTier;
            nudCashPerLevel.Value = optionsList[0].CashPerLevel;
            nudCryVolume.Value = optionsList[0].CryVolume;
            nudDexSkin.Value = Convert.ToDecimal(optionsList[0].PokedexSkin);
            listBanned.Items.Clear();
            listAllowed.Items.Clear();
            listPokeDex.Items.Clear();
            for (var i = 0; i < banList.Count; i++)
            {
                if (banList[i] != "Placeholder")
                    listBanned.Items.Add(banList[i]);
            }
            SortPokeList();
            foreach (Pokemon s in pokeList)
            {
                listPokeDex.Items.Add(s.id);
            }
            foreach (Pokemon s in pokeList)
            {
                if (!listBanned.Items.Contains(s.id))
                    listAllowed.Items.Add(s.id);
            }
        }

        private void RefreshRegions()
        {
            regionList = new List<PokeRegion>();
            regionList = regionXML.createList();
            spawnList = new List<PokeRegion>();
            spawnList = spawnXML.createList();
            listRegions.Items.Clear();
            for (var i = 0; i < regionList.Count; i++)
            {
                listRegions.Items.Add(regionList[i].RegionName);
            }
            listRegions.SelectedIndex = 0;
            listRegionAllowed.Items.Clear();
            listRegionBanned.Items.Clear();
            foreach (Spawn s in spawnList[listRegions.SelectedIndex].Spawns)
            {
                if (s.Name != "Placeholder")
                    listRegionAllowed.Items.Add(s.Name);
                if (!listPokeDex.Items.Contains(s.Name))
                    listRegionAllowed.Items.Remove(s.Name);
            }
            SortPokeList();
            foreach (Pokemon s in pokeList)
            {
                if (!listRegionAllowed.Items.Contains(s.id) && listPokeDex.Items.Contains(s.id))
                    listRegionBanned.Items.Add(s.id);
            }
            listRegionAllowed.SelectedIndex = 0;
        }

        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.png");
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }

        private void btnSaveRegion_Click(object sender, EventArgs e)
        {
            List<string> regionAllowed = new List<string>();
            regionAllowed = listRegionAllowed.Items.Cast<string>().ToList();
            XDocument docX = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
            docX.Descendants().Where(d => string.IsNullOrEmpty(d.Value)).Remove();
            var nameNode = docX.Descendants("Regions").Elements("Region");
            var regionNode = nameNode.ElementAt(listRegions.SelectedIndex);
            var maxLevel = regionNode.Element("MaxLevel");
            var minLevel = regionNode.Element("MinLevel");
            var regionName = regionNode.Attribute("Name");
            maxLevel.Value = nudRegionMax.Value.ToString();
            minLevel.Value = nudRegionMin.Value.ToString();
            regionName.Value = tbRegionName.Text;
            regionNode.Element("Spawns").Remove();
            XElement ban;
            if (regionAllowed == null)
            {
                ban = new XElement("Spawns",
                    new XElement("id", "Placeholder"));
            }
            else
            {
                ban = new XElement("Spawns");
                for ( int b = 0; b < regionAllowed.Count; b++)
                {
                    ban.Add(new XElement("id", new XAttribute("spawnrate", spawnRate[b]), regionAllowed[b]));
                }
            }
            regionNode.Add(ban);
            docX.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
            RefreshRegions();
        }

        private void btnRegionAdd_Click(object sender, EventArgs e)
        {
            if (listRegionAllowed.SelectedItems != null)
            {
                for (int i = 0; i < listRegionAllowed.SelectedItems.Count; i++)
                {
                    listRegionBanned.Items.Add(listRegionAllowed.SelectedItems[i]);
                    listRegionAllowed.Items.Remove(listRegionAllowed.SelectedItems[i]);
                    spawnRate.RemoveAt(listRegionAllowed.SelectedIndices[i]);
                    i--;
                }
            }
        }

        private void btnRegionRemove_Click(object sender, EventArgs e)
        {
            if (listRegionBanned.SelectedItems != null)
            {
                for (int i = 0; i < listRegionBanned.SelectedItems.Count; i++)
                {
                    listRegionAllowed.Items.Add(listRegionBanned.SelectedItems[i]);
                    listRegionBanned.Items.Remove(listRegionBanned.SelectedItems[i]);
                    spawnRate.Add(1);
                    i--;
                }
            }
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            int newRegionNum = 0;
            doesExist:
            newRegionNum++;
            if (listRegions.Items.Contains("NewRegion" + newRegionNum))
            {
                goto doesExist;
            }
            XDocument docX = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
            var newRegionXML = new XElement("Region", 
                new XAttribute("Name", "NewRegion" + newRegionNum), 
                new XElement("MaxLevel", 100),
                new XElement("MinLevel", 1),
                new XElement("Spawns",
                new XElement("id",
                new XAttribute("spawnrate", 1), "Placeholder")));
            docX.Root.Add(newRegionXML);
            docX.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
            RefreshRegions();
        }

        private void listRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            spawnRate = new List<int>();
            tbRegionName.Text = listRegions.SelectedItem.ToString();
            nudRegionMax.Value = regionList[listRegions.SelectedIndex].MaxLevel;
            nudRegionMin.Value = regionList[listRegions.SelectedIndex].MinLevel;
            listRegionAllowed.Items.Clear();
            listRegionBanned.Items.Clear();
            if (spawnList[listRegions.SelectedIndex].Spawns != null)
                foreach (Spawn s in spawnList[listRegions.SelectedIndex].Spawns)
                {
                    if (s.Name != "Placeholder")
                    {
                        listRegionAllowed.Items.Add(s.Name);
                        spawnRate.Add(s.SpawnRate);
                    }
                }
            SortPokeList();
            foreach (Pokemon s in pokeList)
            {
                if (!listRegionAllowed.Items.Contains(s.id))
                    listRegionBanned.Items.Add(s.id);
            }
            try { listRegionAllowed.SelectedIndex = 0; } catch { };
        }

        private void btnRestoreRegions_Click(object sender, EventArgs e)
        {
            DialogResult deleteRegion = MessageBox.Show("Are you sure you wish to restore the default regions?", "Restore Region Defaults", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (deleteRegion == DialogResult.Yes)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "GenesisDex.Data.XML.DefaultRegions.xml";
                string result;
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml", result);
                RefreshRegions();
            }
        }

        private void btnDeleteRegion_Click(object sender, EventArgs e)
        {
            DialogResult deleteRegion = MessageBox.Show("Are you sure you wish to delete the " + listRegions.SelectedItem.ToString() + " Region?", "Delete Region", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (deleteRegion == DialogResult.Yes)
            {
                XDocument docX = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
                docX.Descendants().Where(d => string.IsNullOrEmpty(d.Value)).Remove();
                var nameNode = docX.Descendants("Regions").Elements("Region");
                var regionNode = nameNode.ElementAt(listRegions.SelectedIndex);
                regionNode.Remove();
                docX.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Regions.xml");
                RefreshRegions();
            }
        }

        private void btnDeletePoke_Click(object sender, EventArgs e)
        {
            DialogResult deleteRegion = MessageBox.Show("Are you sure you wish to delete " + listPokeDex.SelectedItem.ToString() + " from the Pokedex?", "Delete Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (deleteRegion == DialogResult.Yes)
            {
                XDocument docX = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
                docX.Descendants().Where(d => string.IsNullOrEmpty(d.Value)).Remove();
                string numberNeeded = "000";
                try { XElement nameNode = docX.Root.Descendants("Pokemon").Where(x => x.Element("id").Value == listPokeDex.SelectedItem.ToString()).SingleOrDefault();
                    numberNeeded = nameNode.Element("number").Value;
                    nameNode.Remove(); } catch { }
                try { XElement megaNode = docX.Root.Descendants("Mega" + numberNeeded).SingleOrDefault();
                    megaNode.Remove(); } catch { }
                docX.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
                RefreshOptions();
                RefreshRegions();
            }
        }

        private void listRegionAllowed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRegionAllowed.SelectedItems.Count == 1)
            {
                nudSpawn.Enabled = true;
                nudSpawn.Value = spawnRate[listRegionAllowed.SelectedIndex];
            }
            else
                nudSpawn.Enabled = false;
        }

        private void nudSpawn_ValueChanged(object sender, EventArgs e)
        {
            if (listRegionAllowed.SelectedItems.Count == 1)
                spawnRate[listRegionAllowed.SelectedIndex] = Convert.ToInt32(nudSpawn.Value);
        }
    }
}

