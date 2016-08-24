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

namespace GenesisDex
{
    public partial class FormChild : Form
    {
        public List<String> list
        {
            get; set;
        }

        public FormChild()
        {
            InitializeComponent();
            gbMega.Visible = false;
            gbMega2.Visible = false;
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
                        new XElement("ability", tbBasic1.Text)),
                    new XElement("Ability",
                        new XElement("ability", tbBasic2.Text)),
                    new XElement("Ability",
                        new XElement("ability", tbAdv1.Text)),
                    new XElement("Ability",
                        new XElement("ability", tbAdv2.Text)),
                    new XElement("Ability",
                        new XElement("ability", tbHigh1.Text)),
                        from s in Capabilities
                        select new XElement("Capability",
                            new XElement("cap", s)),
                        from s in Evo
                        select new XElement("Evolution",
                            new XElement("evo", s)),
                        from s in Moves
                        select new XElement("Moves",
                            new XElement("move", s))));
            doc.Root.Add(pokemon);
            if (cbMega.Checked == true)
            {
                if (cbXY.Checked == true)
                {
                    XElement megax = new XElement("MegaX" + tbNumber.Text,
                        new XElement("id", tbName.Text),
                        new XElement("type", tbMegaType.Text),
                        new XElement("hp", tbMegaHP.Text),
                        new XElement("atk", tbMegaATK.Text),
                        new XElement("def", tbMegaDEF.Text),
                        new XElement("spatk", tbMegaSPATK.Text),
                        new XElement("spdef", tbMegaSPDEF.Text),
                        new XElement("spd", tbMegaSPD.Text),
                        new XElement("ability", tbMegaAbility.Text));
                    doc.Root.Add(megax);
                    XElement megay = new XElement("MegaY" + tbNumber.Text,
                        new XElement("id", tbName.Text),
                        new XElement("type", tbMegaType.Text),
                        new XElement("hp", tbMegaHP.Text),
                        new XElement("atk", tbMegaATK.Text),
                        new XElement("def", tbMegaDEF.Text),
                        new XElement("spatk", tbMegaSPATK.Text),
                        new XElement("spdef", tbMegaSPDEF.Text),
                        new XElement("spd", tbMegaSPD.Text),
                        new XElement("ability", tbMegaAbility.Text));
                    doc.Root.Add(megay);
                }
                else
                {
                    XElement mega = new XElement("Mega" + tbNumber.Text,
                        new XElement("id", tbName.Text),
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
            listCap.Items.Add(tbCapAdd.Text);
        }

        private void btEvoAdd_Click(object sender, EventArgs e)
        {
            listEvo.Items.Add(tbEvoAdd.Text);
        }

        private void btMoveAdd_Click(object sender, EventArgs e)
        {
            listMoves.Items.Add(tbMoveAdd.Text);

        }

        private void cbMega_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMega.Checked == true)
            {
                gbMega.Visible = true;
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
    }
}
