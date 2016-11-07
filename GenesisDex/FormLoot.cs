using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using GenesisDexEngine;

namespace GenesisDex
{
    public partial class FormLoot : Form
    {
        //===========================================================================================================
        //=== Variables =============================================================================================
        //===========================================================================================================
        Point dragCursorPoint = new Point();
        Point dragFormPoint = new Point();
        //===========================================================================================================
        Random rng = new Random();
        //===========================================================================================================
        List<int> ItemTiers = new List<int>();
        //===========================================================================================================
        OptionsList optionsXML = new OptionsList();
        List<Options> optionsList = new List<Options>();
        //===========================================================================================================
        ItemList itemXML = new ItemList();
        List<Items> itemList = new List<Items>();
        //===========================================================================================================
        List<string> lootList = new List<string>();
        List<string> lootName = new List<string>();
        //===========================================================================================================
        int Cash { get; set; }
        //===========================================================================================================
        bool dragging { get; set; }
        //===========================================================================================================

        public FormLoot()
        {
            InitializeComponent();
            btnExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
            btnMinimize.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MinimizeButton.png");
            btnScanLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLoot.png");
            
            RefreshPage();
        }

        //===========================================================================================================
        //Used to register the mouse down on the Form Controll inorder to allow window placement. ===================
        //===========================================================================================================
        private void FormLoot_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        //===========================================================================================================
        //=== Update teh window to know wher you have moved it to. ==================================================
        //===========================================================================================================
        private void FormLoot_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        //===========================================================================================================
        //=== Tells the form that you have stopped positioning the window. ==========================================
        //===========================================================================================================
        private void FormLoot_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void RefreshPage()
        {
            optionsList.Clear();
            optionsList = optionsXML.createList();
            ItemTiers.Clear();
            for (int i = 1; i <= optionsList[0].MaxItemTier; i++)
            {
                for (int p = optionsList[0].MaxItemTier - (i - 1); p > 0; p--)
                {
                    ItemTiers.Add(i);
                }
            }
            this.BackgroundImage = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\LootMenu" + optionsList[0].PokedexSkin + ".PNG");
            nudPlayerLevel.Maximum = optionsList[0].MaxPlayerLevel;
        }

        private void GetLoot()
        {
            lbItems.Items.Clear();
            lootList.Clear();
            lootName.Clear();
            int val = Convert.ToInt32(nudPlayerLevel.Value);
            Cash = 0;
            for (int x = 0; x < val; x++)
            {
                int i = rng.Next(1, 4);
                if (i == 1)
                    GetItem();
                else
                    Cash += rng.Next(1, 6) * optionsList[0].CashPerLevel;
            }
            if (Cash != 0)
            {
                lootName.Add("Cash");
                lootList.Add("$" + Cash.ToString());
            }
            WriteLoot();
        }

        //===========================================================================================================
        //===
        //===========================================================================================================
        private void WriteLoot()
        {
            foreach (string s in lootName)
            {
                lbItems.Items.Add(s);
            }
        }

        //===========================================================================================================
        //=== SetItem is used to set the Item Image in the correct place to keep it centered based on the varying ===
        //===== size of the image. ==================================================================================
        //===========================================================================================================
        private void SetItem()
        {
            pkItem.Size = pkItem.Image.Size;
            pkItem.Location = new Point(538 - (pkItem.Width / 2), 177 - (pkItem.Height));
        }

        //===========================================================================================================
        //=== GetItem rolls to determine what tier the first item held by the Pokemon is, and to determine if the ==
        //===== Pokemon is holding a second item or not. ============================================================
        //===========================================================================================================
        private void GetItem()
        {
            int i = rng.Next(ItemTiers.Count);
            ItemGenByTier(ItemTiers[i]);
        }

        //===========================================================================================================
        //=== ItemGenByTier is used to determine what item is going to be placed in Item1 or Item2 using the tier ===
        //===== generated in GetItem1 or GetItem2. This is also used in the GetLoot function. =======================
        //===========================================================================================================
        private void ItemGenByTier(int tier)
        {
            itemList = itemXML.createList(tier.ToString());
            int i = rng.Next(0, itemList.Count);
            if (itemList.Count == 0)
            {
                if (tier == 1)
                    ItemGenByTier(optionsList[0].MaxItemTier);
                else
                    ItemGenByTier(tier - 1);
            }
            lootName.Add(itemList[i].id);
            lootList.Add(itemList[i].desc);
        }

        //===========================================================================================================
        //=== GetImage is used to check to see if the image requested actually exists. If it does not, it is then ===
        //===== replaced with teh MissingNo image. ==================================================================
        //===========================================================================================================
        private System.Drawing.Image getImage(string x)
        {
            string path = (x);
            if (File.Exists(x) == true)
            {
                return System.Drawing.Image.FromFile(path);
            }
            else if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\MissingNo.gif"))
            {
                return System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\MissingNo.gif");
            }
            else
            {
                return System.Drawing.Image.FromFile(null);
            }
        }

        //===========================================================================================================
        //=== btnExit if the exit button at the top of this form. ====================================================
        //===========================================================================================================
        private void btnExit_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Close();
        }
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButtonHover.png");
        }
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\CloseButton.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            WindowState = FormWindowState.Minimized;
        }
        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MinimizeButtonHover.png");
        }
        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\MinimizeButton.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            pkItem.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\Images\\Items\\" + lootName[lbItems.SelectedIndex] + ".png");
            ttDescription.SetToolTip(this.pkItem, lootList[lbItems.SelectedIndex]);
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void btnScanLoot_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            GetLoot();
        }
        private void btnScanLoot_MouseEnter(object sender, EventArgs e)
        {
            btnScanLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLootHover.png");
        }
        private void btnScanLoot_MouseLeave(object sender, EventArgs e)
        {
            btnScanLoot.Image = getImage(AppDomain.CurrentDomain.BaseDirectory + "Data\\GUI\\ScanLoot.png");
        }

        //===========================================================================================================
        //=== 
        //===========================================================================================================
        private void pkItem_MouseEnter(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex != -1)
                ttDescription.Show(ttDescription.GetToolTip(pkItem), this.pkItem, new Point(pkItem.Width, this.pkItem.Top));
        }
        private void pkItem_MouseLeave(object sender, EventArgs e)
        {
            ttDescription.Hide(pkItem);
        }
    }
}
