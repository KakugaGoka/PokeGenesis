using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenesisDexEngine;

namespace GenesisDex
{
    public partial class FormAdd : Form
    {
        //===========================================================================================================
        //=== Variables =============================================================================================
        //===========================================================================================================
        int CAP { get; set; }
        int EVO { get; set; }
        int MOV { get; set; }
        int SKI { get; set; }
        //===========================================================================================================
        bool dragging = false;
        //===========================================================================================================
        Point dragCursorPoint;
        Point dragFormPoint;
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        
        //===========================================================================================================
        public FormAdd()
        {
            InitializeComponent();
            gbMega.Visible = false;
            gbMega2.Visible = false;
            List<string> abilitymod = new List<string>();
            abilitymod.Add("Basic");
            abilitymod.Add("Advanced");
            abilitymod.Add("High");
            cbAbi1.DataSource = abilitymod;
            cbAbi2.BindingContext = new BindingContext();
            cbAbi2.DataSource = abilitymod;
            cbAbi3.BindingContext = new BindingContext();
            cbAbi3.DataSource = abilitymod;
            cbAbi3.SelectedIndex = 1;
            cbAbi4.BindingContext = new BindingContext();
            cbAbi4.DataSource = abilitymod;
            cbAbi4.SelectedIndex = 1;
            cbAbi5.BindingContext = new BindingContext();
            cbAbi5.DataSource = abilitymod;
            cbAbi5.SelectedIndex = 2;
            AddContextMenuRTB(listCap);
            AddContextMenuRTB(listSkills);
            AddContextMenuRTB(listEvo);
            AddContextMenuRTB(listMoves);
            AddContextMenuTB(tbNumber);
            AddContextMenuTB(tbName);
            AddContextMenuTB(tbHP);
            AddContextMenuTB(tbATK);
            AddContextMenuTB(tbDEF);
            AddContextMenuTB(tbSPATK);
            AddContextMenuTB(tbSPDEF);
            AddContextMenuTB(tbSPD);
            AddContextMenuTB(tbType);
            AddContextMenuTB(tbAbi1);
            AddContextMenuTB(tbAbi2);
            AddContextMenuTB(tbAbi3);
            AddContextMenuTB(tbAbi4);
            AddContextMenuTB(tbAbi5);
            AddContextMenuTB(tbHeight);
            AddContextMenuTB(tbWeight);
            AddContextMenuTB(tbGender);
            AddContextMenuTB(tbDiet);
            AddContextMenuTB(tbEgg);
            AddContextMenuTB(tbHatch);
            AddContextMenuTB(tbHabitat);
            AddContextMenuTB(tbMegaName);
            AddContextMenuTB(tbMegaType);
            AddContextMenuTB(tbMegaHP);
            AddContextMenuTB(tbMegaATK);
            AddContextMenuTB(tbMegaDEF);
            AddContextMenuTB(tbMegaSPATK);
            AddContextMenuTB(tbMegaSPDEF);
            AddContextMenuTB(tbMegaSPD);
            AddContextMenuTB(tbMegaAbility);
            AddContextMenuTB(tbMega2Name);
            AddContextMenuTB(tbMega2Type);
            AddContextMenuTB(tbMega2HP);
            AddContextMenuTB(tbMega2ATK);
            AddContextMenuTB(tbMega2DEF);
            AddContextMenuTB(tbMega2SPATK);
            AddContextMenuTB(tbMega2SPDEF);
            AddContextMenuTB(tbMega2SPD);
            AddContextMenuTB(tbMega2Ability);
            cbAbi1.ContextMenu = new ContextMenu();
            cbAbi2.ContextMenu = new ContextMenu();
            cbAbi3.ContextMenu = new ContextMenu();
            cbAbi4.ContextMenu = new ContextMenu();
            cbAbi5.ContextMenu = new ContextMenu();
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void btAddPKMN_Click(object sender, EventArgs e)
        {
            AddPokemon();
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void AddPokemon()
        {
            if (tbName.Text.Trim() == "" || tbNumber.Text.Trim() == "" || tbGender.Text.Trim() == "" || tbHP.Text.Trim() == "" || tbATK.Text.Trim() == "" || tbDEF.Text.Trim() == "" || tbSPATK.Text.Trim() == "" ||
                 tbSPDEF.Text.Trim() == "" || tbSPD.Text.Trim() == "" || tbType.Text.Trim() == "" || listEvo.Text.Trim() == "" || listMoves.Text.Trim() == "")
            {
                MessageBox.Show("Please complete the form before attempting to add to the Pokedex.");
                return;
            }
            List<string> Capabilities = new List<string>();
            List<string> Moves = new List<string>();
            List<string> Evo = new List<string>();
            List<string> Skills = new List<string>();
            List<string> tC = new List<string>();
            List<string> tS = new List<string>();
            string[] tempCap = listCap.Text.Split(',');
            foreach (string s in tempCap)
                tC.Add(s);
            for ( var s = 0; s < tC.Count; s++) 
            {
                string newString = tC[s];
                string nextString = Regex.Replace(newString, @"\s+", " ");
                Capabilities.Add(nextString.Trim());
            }
            int count = Capabilities.Count;
            StringBuilder build = new StringBuilder();
            bool building = false;
            for (var s = 0; s < count; s++)
            {
                if (building == false)
                {
                    if (Capabilities[s].Contains("(") == true)
                    {
                        if (!Capabilities[s].Contains(")"))
                        {
                            build.Append(Capabilities[s] + ", ");
                            Capabilities.RemoveAt(s);
                            s--;
                            count--;
                            building = true;
                        }
                        else
                        {
                            building = false;
                        }
                    }
                }
                else
                {
                    if (Capabilities[s].Contains(")") == true)
                    {
                        build.Append(Capabilities[s]);
                        Capabilities.RemoveAt(s);
                        Capabilities.Add(build.ToString());
                        s--;
                        count--;
                        build.Clear();
                        building = false;
                    }
                    else
                    {
                        build.Append(Capabilities[s]);
                        Capabilities.RemoveAt(s);
                        count--;
                        s--;
                    }
                }
            }
            string[] tempMove = listMoves.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
            foreach (string s in tempMove)
                Moves.Add(s);
            foreach (string s in Moves)
            {
                s.Trim();
                s.Replace(@"\t|\n|\r", "");
            }
            string[] tempEvo = listEvo.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
            foreach (string s in tempEvo)
                Evo.Add(s);
            foreach (string s in Evo)
            {
                s.Trim();
                s.Replace(@"\t|\n|\r", "");
            }
            string[] tempSkills = listSkills.Text.Split(',');
            foreach (string s in tempSkills)
                tS.Add(s);
            for (var s = 0; s < tS.Count; s++)
            {
                string newString = tS[s];
                string nextString = Regex.Replace(newString, @"\s+", " ");
                Skills.Add(nextString.Trim());
            }
            tbNumber.Text = tbNumber.Text.Trim(' ');
            tbName.Text = tbName.Text.Trim(' ');
            tbType.Text = tbType.Text.Trim(' ');
            tbHP.Text = tbHP.Text.Trim(' ');
            tbATK.Text = tbATK.Text.Trim(' ');
            tbDEF.Text = tbDEF.Text.Trim(' ');
            tbSPATK.Text = tbSPATK.Text.Trim(' ');
            tbSPDEF.Text = tbSPDEF.Text.Trim(' ');
            tbSPD.Text = tbSPD.Text.Trim(' ');
            tbHeight.Text = tbHeight.Text.Trim(' ');
            tbWeight.Text = tbWeight.Text.Trim(' ');
            tbGender.Text = tbGender.Text.Trim(' ');
            tbEgg.Text = tbEgg.Text.Trim(' ');
            tbHatch.Text = tbHatch.Text.Trim(' ');
            rtbEntry.Text = rtbEntry.Text.Trim(' ');
            int c = 0;
            int e = 0;
            int m = 0;
            int k = 0;
            string legend;
            if (cbLegend.Checked == true)
            {
                legend = "true";
            }
            else
            {
                legend = "false";
            }
            string stage = "0";
            string[] evoSplit;
            string[] name = tbName.Text.Split(' ');
            foreach (string s in Evo)
            {
                if (s.Contains(name[0]))
                {
                    evoSplit = s.Split(' ');
                    stage = evoSplit[0];
                    break;
                }
            }
            XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            XElement pokemon = new XElement("Pokemon", new XAttribute("Stage", stage),
                new XElement("number", tbNumber.Text),
                new XElement("id", tbName.Text),
                new XElement("type", tbType.Text),
                new XElement("hp", tbHP.Text),
                new XElement("atk", tbATK.Text),
                new XElement("def", tbDEF.Text),
                new XElement("spatk", tbSPATK.Text),
                new XElement("spdef", tbSPDEF.Text),
                new XElement("spd", tbSPD.Text),
                new XElement("size", tbHeight.Text),
                new XElement("weight", tbWeight.Text),
                new XElement("gender", tbGender.Text),
                new XElement("egg", tbEgg.Text),
                new XElement("hatch", tbHatch.Text),
                new XElement("diet", tbDiet.Text),
                new XElement("habitat", tbHabitat.Text),
                new XElement("legendary", legend),
                new XElement("entry", rtbEntry.Text),
                new XElement("List" + tbNumber.Text,
                    new XElement("Ability",
                        new XElement(cbAbi1.Text + "Ability", tbAbi1.Text),
                        new XElement(cbAbi2.Text + "Ability", tbAbi2.Text),
                        new XElement(cbAbi3.Text + "Ability", tbAbi3.Text),
                        new XElement(cbAbi4.Text + "Ability", tbAbi4.Text),
                        new XElement(cbAbi5.Text + "Ability", tbAbi5.Text)),
                    new XElement("Skills",
                        from s in Skills
                        select new XElement("skill", new XAttribute("id", k++), s)),
                    new XElement("Capability",
                        from s in Capabilities
                        select new XElement("cap", new XAttribute("id", c++), s)),
                    new XElement("Evolution",
                        from s in Evo
                        select new XElement("evo", new XAttribute("id", e++), s)),
                     new XElement("Moves",
                        from s in Moves
                        select new XElement("move", new XAttribute("id", m++), s))));
            doc.Root.Add(pokemon);
            if (cbMega.Checked == true)
            {
                if (cbXY.Checked == true)
                {
                    tbMegaName.Text = tbMegaName.Text.Trim(' ');
                    tbMegaType.Text = tbMegaType.Text.Trim(' ');
                    tbMegaHP.Text = tbMegaHP.Text.Trim(' ');
                    tbMegaATK.Text = tbMegaATK.Text.Trim(' ');
                    tbMegaDEF.Text = tbMegaDEF.Text.Trim(' ');
                    tbMegaSPATK.Text = tbMegaSPATK.Text.Trim(' ');
                    tbMegaSPDEF.Text = tbMegaSPDEF.Text.Trim(' ');
                    tbMegaSPD.Text = tbMegaSPD.Text.Trim(' ');
                    tbMegaAbility.Text = tbMegaAbility.Text.Trim(' ');
                    XElement megax = new XElement("MegaX" + tbNumber.Text,
                        new XElement("id", tbMegaName.Text),
                        new XElement("type", tbMegaType.Text),
                        new XElement("hp", tbMegaHP.Text),
                        new XElement("atk", tbMegaATK.Text),
                        new XElement("def", tbMegaDEF.Text),
                        new XElement("spatk", tbMegaSPATK.Text),
                        new XElement("spdef", tbMegaSPDEF.Text),
                        new XElement("spd", tbMegaSPD.Text),
                        new XElement("ability", tbMegaAbility.Text));
                    doc.Root.Add(megax);
                    tbMega2Name.Text = tbMega2Name.Text.Trim(' ');
                    tbMega2Type.Text = tbMega2Type.Text.Trim(' ');
                    tbMega2HP.Text = tbMega2HP.Text.Trim(' ');
                    tbMega2ATK.Text = tbMega2ATK.Text.Trim(' ');
                    tbMega2DEF.Text = tbMega2DEF.Text.Trim(' ');
                    tbMega2SPATK.Text = tbMega2SPATK.Text.Trim(' ');
                    tbMega2SPDEF.Text = tbMega2SPDEF.Text.Trim(' ');
                    tbMega2SPD.Text = tbMega2SPD.Text.Trim(' ');
                    tbMega2Ability.Text = tbMega2Ability.Text.Trim(' ');
                    XElement megay = new XElement("MegaY" + tbNumber.Text,
                        new XElement("id", tbMega2Name.Text),
                        new XElement("type", tbMega2Type.Text),
                        new XElement("hp", tbMega2HP.Text),
                        new XElement("atk", tbMega2ATK.Text),
                        new XElement("def", tbMega2DEF.Text),
                        new XElement("spatk", tbMega2SPATK.Text),
                        new XElement("spdef", tbMega2SPDEF.Text),
                        new XElement("spd", tbMega2SPD.Text),
                        new XElement("ability", tbMega2Ability.Text));
                    doc.Root.Add(megay);
                }
                else
                {
                    tbMegaName.Text = tbMegaName.Text.Trim(' ');
                    tbMegaType.Text = tbMegaType.Text.Trim(' ');
                    tbMegaHP.Text = tbMegaHP.Text.Trim(' ');
                    tbMegaATK.Text = tbMegaATK.Text.Trim(' ');
                    tbMegaDEF.Text = tbMegaDEF.Text.Trim(' ');
                    tbMegaSPATK.Text = tbMegaSPATK.Text.Trim(' ');
                    tbMegaSPDEF.Text = tbMegaSPDEF.Text.Trim(' ');
                    tbMegaSPD.Text = tbMegaSPD.Text.Trim(' ');
                    tbMegaAbility.Text = tbMegaAbility.Text.Trim(' ');
                    XElement mega = new XElement("Mega" + tbNumber.Text,
                        new XElement("id", tbMegaName.Text),
                        new XElement("type", tbMegaType.Text),
                        new XElement("hp", tbMegaHP.Text),
                        new XElement("atk", tbMegaATK.Text),
                        new XElement("def", tbMegaDEF.Text),
                        new XElement("spatk", tbMegaSPATK.Text),
                        new XElement("spdef", tbMegaSPDEF.Text),
                        new XElement("spd", tbMegaSPD.Text),
                        new XElement("ability", tbMegaAbility.Text));
                    doc.Root.Add(mega);
                }
            }
            doc.Descendants().Where(f => string.IsNullOrEmpty(f.Value)).Remove();
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            DialogResult result = MessageBox.Show(tbName.Text + " has been added to the Pokedex!");
            if (result == DialogResult.OK) { this.Close(); }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void cbMega_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMega.Checked == true)
            {
                gbMega.Visible = true;
                if (cbXY.Checked == true)
                {
                    cbXY_CheckedChanged(this, new EventArgs());
                }
            }
            else
            {
                gbMega.Visible = false;
                cbXY.Checked = false;
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void cbXY_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMega.Checked == true)
            {
                if (cbXY.Checked == true)
                {
                    gbMega2.Visible = true;
                    gbMega.Text = "Mega X Info";
                }
                else
                {
                    gbMega2.Visible = false;
                    gbMega.Text = "Mega Info";
                }
            }
            else
            {
                gbMega2.Visible = false;
                gbMega.Text = "Mega Info";
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void FormAdd_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormAdd_MouseMove(object sender, MouseEventArgs e)
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
        private void FormAdd_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void AddContextMenuRTB(RichTextBox rtb)
        {
            if (rtb.ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };
                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => rtb.Cut();
                cms.Items.Add(tsmiCut);
                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => rtb.Copy();
                cms.Items.Add(tsmiCopy);
                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => rtb.Paste();
                cms.Items.Add(tsmiPaste);
                rtb.ContextMenuStrip = cms;
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void AddContextMenuTB(TextBox tb)
        {
            if (tb.ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };
                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => tb.Cut();
                cms.Items.Add(tsmiCut);
                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => tb.Copy();
                cms.Items.Add(tsmiCopy);
                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => tb.Paste();
                cms.Items.Add(tsmiPaste);
                tb.ContextMenuStrip = cms;
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void CheckedState(CheckBox cb)
        {
            if (cb.Checked)
                cb.Checked = false;
            else
                cb.Checked = true;
        }

        //===========================================================================================================
        //===========================================================================================================
        private void cbLegend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(cbLegend);
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void cbMega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(cbMega);
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void cbXY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckedState(cbXY);
            }
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void pbExit_MouseHover(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.png");
        }
        //===========================================================================================================
        //===========================================================================================================

        //===========================================================================================================
        //===========================================================================================================
        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }
        //===========================================================================================================
        //===========================================================================================================
    }
}
