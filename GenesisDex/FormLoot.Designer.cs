namespace GenesisDex
{
    partial class FormLoot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoot));
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pkItem = new System.Windows.Forms.PictureBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.nudPlayerLevel = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.btnScanLoot = new System.Windows.Forms.PictureBox();
            this.ttDescription = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxTier = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.Location = new System.Drawing.Point(836, 67);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.TabIndex = 194;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Location = new System.Drawing.Point(836, 46);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 193;
            this.btnExit.TabStop = false;
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseUp);
            // 
            // pkItem
            // 
            this.pkItem.BackColor = System.Drawing.Color.Transparent;
            this.pkItem.Location = new System.Drawing.Point(696, 79);
            this.pkItem.Name = "pkItem";
            this.pkItem.Size = new System.Drawing.Size(118, 117);
            this.pkItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pkItem.TabIndex = 195;
            this.pkItem.TabStop = false;
            this.pkItem.MouseEnter += new System.EventHandler(this.pkItem_MouseEnter);
            this.pkItem.MouseLeave += new System.EventHandler(this.pkItem_MouseLeave);
            // 
            // lbItems
            // 
            this.lbItems.BackColor = System.Drawing.Color.Beige;
            this.lbItems.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 18;
            this.lbItems.Location = new System.Drawing.Point(436, 54);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(170, 166);
            this.lbItems.TabIndex = 196;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // nudPlayerLevel
            // 
            this.nudPlayerLevel.BackColor = System.Drawing.Color.Beige;
            this.nudPlayerLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPlayerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudPlayerLevel.Location = new System.Drawing.Point(124, 58);
            this.nudPlayerLevel.Name = "nudPlayerLevel";
            this.nudPlayerLevel.Size = new System.Drawing.Size(46, 20);
            this.nudPlayerLevel.TabIndex = 197;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(61, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 14);
            this.label11.TabIndex = 198;
            this.label11.Text = "Player Level";
            // 
            // btnScanLoot
            // 
            this.btnScanLoot.BackColor = System.Drawing.Color.Transparent;
            this.btnScanLoot.Location = new System.Drawing.Point(294, 191);
            this.btnScanLoot.Name = "btnScanLoot";
            this.btnScanLoot.Size = new System.Drawing.Size(126, 26);
            this.btnScanLoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnScanLoot.TabIndex = 199;
            this.btnScanLoot.TabStop = false;
            this.btnScanLoot.MouseEnter += new System.EventHandler(this.btnScanLoot_MouseEnter);
            this.btnScanLoot.MouseLeave += new System.EventHandler(this.btnScanLoot_MouseLeave);
            this.btnScanLoot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScanLoot_MouseUp);
            // 
            // ttDescription
            // 
            this.ttDescription.AutoPopDelay = 5000;
            this.ttDescription.InitialDelay = 300;
            this.ttDescription.IsBalloon = true;
            this.ttDescription.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 201;
            this.label1.Text = "Max Tier";
            // 
            // nudMaxTier
            // 
            this.nudMaxTier.BackColor = System.Drawing.Color.Beige;
            this.nudMaxTier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudMaxTier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudMaxTier.Location = new System.Drawing.Point(124, 84);
            this.nudMaxTier.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxTier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxTier.Name = "nudMaxTier";
            this.nudMaxTier.Size = new System.Drawing.Size(46, 20);
            this.nudMaxTier.TabIndex = 200;
            this.nudMaxTier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormLoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMaxTier);
            this.Controls.Add(this.btnScanLoot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudPlayerLevel);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.pkItem);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLoot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLoot_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLoot_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLoot_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox pkItem;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.NumericUpDown nudPlayerLevel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnScanLoot;
        private System.Windows.Forms.ToolTip ttDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxTier;
    }
}