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
    public partial class FormAdd : Form
    {
        int CAP { get; set; }
        int EVO { get; set; }
        int MOV { get; set; }
        int SKI { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormAdd()
        {
            InitializeComponent();
            gbMega.Visible = false;
            gbMega2.Visible = false;
            gbRemove.Visible = false;
        }

        private void btAddPKMN_Click(object sender, EventArgs e)
        {
            AddPokemon();
        }

        private void AddPokemon()
        {
            string[] Capabilities = listCap.Items.Cast<String>().ToArray();
            string[] Moves = listMoves.Items.Cast<String>().ToArray();
            string[] Evo = listEvo.Items.Cast<String>().ToArray();
            string[] Skills = listSkill.Items.Cast<String>().ToArray();
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
            int c = 0;
            int e = 0;
            int m = 0;
            int k = 0;
            XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            XElement pokemon = new XElement("Pokemon",
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
                new XElement("List" + tbNumber.Text,
                    new XElement("Ability",
                        new XElement("basicability1", tbBasic1.Text),
                        new XElement("basicability2", tbBasic2.Text),
                        new XElement("advability1", tbAdv1.Text),
                        new XElement("advability2", tbAdv2.Text),
                        new XElement("highability", tbHigh1.Text)),
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
            if (cbLegend.Checked == true)
            {
                XElement megay = new XElement("legendary", "true");
            }
            else
            {
                XElement megay = new XElement("legendary", "false");
            }
            doc.Descendants().Where(f => string.IsNullOrEmpty(f.Value)).Remove();
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            DialogResult result = MessageBox.Show(tbName.Text + " has been added to the Pokedex!");
            if (result == DialogResult.OK) { this.Close(); }

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapAdd_Click(object sender, EventArgs e)
        {
            if (tbCapAdd.Text != "")
            {
                tbCapAdd.Text = tbCapAdd.Text.Trim(' ');
                listCap.Items.Add(tbCapAdd.Text);
                CAP = listCap.Items.Count - 1;
                tbCapAdd.Text = "";
            }
        }

        private void btEvoAdd_Click(object sender, EventArgs e)
        {
            if (tbEvoAdd.Text != "")
            {
                tbEvoAdd.Text = tbEvoAdd.Text.Trim(' ');
                listEvo.Items.Add(tbEvoAdd.Text);
                EVO = listEvo.Items.Count - 1;
                tbEvoAdd.Text = "";
            }
        }

        private void btMoveAdd_Click(object sender, EventArgs e)
        {
            if (tbMoveAdd.Text != "")
            {
                tbMoveAdd.Text = tbMoveAdd.Text.Trim(' ');
                listMoves.Items.Add(tbMoveAdd.Text);
                MOV = listMoves.Items.Count - 1;
                tbMoveAdd.Text = "";
            }
        }

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

        private void btCapClear_Click(object sender, EventArgs e)
        {
            if (listCap.Items.Count == 0) { }
            else
            {
                listCap.Items.RemoveAt(CAP);
                CAP = listCap.Items.Count - 1;
            }
        }

        private void btEvoClear_Click(object sender, EventArgs e)
        {
            if (listEvo.Items.Count == 0) { }
            else
            {
                listEvo.Items.RemoveAt(EVO);
                EVO = listEvo.Items.Count - 1;
            }
        }

        private void btMoveClear_Click(object sender, EventArgs e)
        {
            if (listMoves.Items.Count == 0) { }
            else
            {
                listMoves.Items.RemoveAt(MOV);
                MOV = listMoves.Items.Count - 1;
            }
        }

        private void tbCapAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btCapAdd_Click(this, new EventArgs());
            }
        }

        private void tbEvoAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEvoAdd_Click(this, new EventArgs());
            }
        }

        private void tbMoveAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btMoveAdd_Click(this, new EventArgs());
            }
        }

        private void cbRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemove.Checked == true)
            {
                gbRemove.Visible = true;
            }
            else
            {
                gbRemove.Visible = false;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            string ItemCode = tbRemove.Text;
            string num = null;
            XmlNode node = doc.SelectSingleNode("/*/Pokemon[contains(id,'" + ItemCode + "')]");
            try
            {
                num = doc.SelectSingleNode("/*/Pokemon[contains(id,'" + ItemCode + "')]/number").InnerText;
            }
            catch { MessageBox.Show("This Pokemon does not exist in the Pokedex... Maybe check your spelling?"); return; }
            XmlNode node1 = doc.SelectSingleNode("/*/Mega" + num);
            XmlNode node2 = doc.SelectSingleNode("/*/MegaX" + num);
            XmlNode node3 = doc.SelectSingleNode("/*/MegaY" + num);
            try { node.RemoveAll(); } catch { }
            try { node1.RemoveAll(); } catch { }
            try { node2.RemoveAll(); } catch { }
            try { node3.RemoveAll(); } catch { }
            MessageBox.Show(tbRemove.Text + " has been removed from the Pokedex...");
            tbRemove.Text = "";
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            doc = null;
            XDocument doc1 = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
            doc1.Descendants().Where(d => string.IsNullOrEmpty(d.Value)).Remove();
            doc1.Save(AppDomain.CurrentDomain.BaseDirectory + "Data\\XML\\Pokemon.xml");
        }

        private void tbRemove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btRemove_Click(this, new EventArgs());
            }
        }

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

        private void FormAdd_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btSkillAdd_Click(object sender, EventArgs e)
        {
            if (tbSkillAdd.Text != "")
            {
                tbSkillAdd.Text = tbSkillAdd.Text.Trim(' ');
                listSkill.Items.Add(tbSkillAdd.Text);
                SKI = listSkill.Items.Count - 1;
                tbSkillAdd.Text = "";
            }
        }

        private void btSkillClear_Click(object sender, EventArgs e)
        {
            if (listSkill.Items.Count == 0) { }
            else
            {
                listSkill.Items.RemoveAt(SKI);
                SKI = listSkill.Items.Count - 1;
            }
        }

        private void tbSkillAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSkillAdd_Click(this, new EventArgs());
            }
        }
    }
}
