namespace GenesisDex
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.nudItemTier = new System.Windows.Forms.NumericUpDown();
            this.nudScanLimit = new System.Windows.Forms.NumericUpDown();
            this.nudPokeLevel = new System.Windows.Forms.NumericUpDown();
            this.nudPlayerLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemGasp1 = new System.Windows.Forms.TextBox();
            this.txtItemGasp2 = new System.Windows.Forms.TextBox();
            this.txtPokeGasp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listAllowed = new System.Windows.Forms.ListBox();
            this.listBanned = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnAllow = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.txtShinyGasp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCashPerLevel = new System.Windows.Forms.NumericUpDown();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCryVolume = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPokeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashPerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCryVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // nudItemTier
            // 
            this.nudItemTier.Location = new System.Drawing.Point(127, 140);
            this.nudItemTier.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudItemTier.Name = "nudItemTier";
            this.nudItemTier.Size = new System.Drawing.Size(58, 20);
            this.nudItemTier.TabIndex = 0;
            // 
            // nudScanLimit
            // 
            this.nudScanLimit.Location = new System.Drawing.Point(127, 218);
            this.nudScanLimit.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScanLimit.Name = "nudScanLimit";
            this.nudScanLimit.Size = new System.Drawing.Size(58, 20);
            this.nudScanLimit.TabIndex = 1;
            // 
            // nudPokeLevel
            // 
            this.nudPokeLevel.Location = new System.Drawing.Point(127, 192);
            this.nudPokeLevel.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPokeLevel.Name = "nudPokeLevel";
            this.nudPokeLevel.Size = new System.Drawing.Size(58, 20);
            this.nudPokeLevel.TabIndex = 2;
            // 
            // nudPlayerLevel
            // 
            this.nudPlayerLevel.Location = new System.Drawing.Point(127, 166);
            this.nudPlayerLevel.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPlayerLevel.Name = "nudPlayerLevel";
            this.nudPlayerLevel.Size = new System.Drawing.Size(58, 20);
            this.nudPlayerLevel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max Item Tier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Player Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Pokemon Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pokemon Scan Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "One Item Gasp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Two Items Gasp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pokemon Gasp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Allowed Pokemon";
            // 
            // txtItemGasp1
            // 
            this.txtItemGasp1.Location = new System.Drawing.Point(127, 36);
            this.txtItemGasp1.Name = "txtItemGasp1";
            this.txtItemGasp1.Size = new System.Drawing.Size(148, 20);
            this.txtItemGasp1.TabIndex = 12;
            // 
            // txtItemGasp2
            // 
            this.txtItemGasp2.Location = new System.Drawing.Point(127, 62);
            this.txtItemGasp2.Name = "txtItemGasp2";
            this.txtItemGasp2.Size = new System.Drawing.Size(148, 20);
            this.txtItemGasp2.TabIndex = 13;
            // 
            // txtPokeGasp
            // 
            this.txtPokeGasp.Location = new System.Drawing.Point(127, 88);
            this.txtPokeGasp.Name = "txtPokeGasp";
            this.txtPokeGasp.Size = new System.Drawing.Size(148, 20);
            this.txtPokeGasp.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Banned Pokemon";
            // 
            // listAllowed
            // 
            this.listAllowed.FormattingEnabled = true;
            this.listAllowed.Location = new System.Drawing.Point(316, 34);
            this.listAllowed.Name = "listAllowed";
            this.listAllowed.Size = new System.Drawing.Size(180, 316);
            this.listAllowed.TabIndex = 16;
            // 
            // listBanned
            // 
            this.listBanned.FormattingEnabled = true;
            this.listBanned.Location = new System.Drawing.Point(547, 34);
            this.listBanned.Name = "listBanned";
            this.listBanned.Size = new System.Drawing.Size(180, 316);
            this.listBanned.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(502, 145);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(39, 23);
            this.btnBan.TabIndex = 19;
            this.btnBan.Text = " ----->";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnAllow
            // 
            this.btnAllow.Location = new System.Drawing.Point(502, 176);
            this.btnAllow.Name = "btnAllow";
            this.btnAllow.Size = new System.Drawing.Size(39, 23);
            this.btnAllow.TabIndex = 20;
            this.btnAllow.Text = "<----- ";
            this.btnAllow.UseVisualStyleBackColor = true;
            this.btnAllow.Click += new System.EventHandler(this.btnAllow_Click);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Location = new System.Drawing.Point(734, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(24, 23);
            this.pbExit.TabIndex = 21;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // txtShinyGasp
            // 
            this.txtShinyGasp.Location = new System.Drawing.Point(127, 114);
            this.txtShinyGasp.Name = "txtShinyGasp";
            this.txtShinyGasp.Size = new System.Drawing.Size(148, 20);
            this.txtShinyGasp.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Shiny Gasp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cash Per Level";
            // 
            // nudCashPerLevel
            // 
            this.nudCashPerLevel.Location = new System.Drawing.Point(127, 244);
            this.nudCashPerLevel.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCashPerLevel.Name = "nudCashPerLevel";
            this.nudCashPerLevel.Size = new System.Drawing.Size(58, 20);
            this.nudCashPerLevel.TabIndex = 26;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(112, 327);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(94, 23);
            this.btnDefault.TabIndex = 28;
            this.btnDefault.Text = "Restore Defaults";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 327);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add Pokemon";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cry Volume";
            // 
            // nudCryVolume
            // 
            this.nudCryVolume.Location = new System.Drawing.Point(127, 270);
            this.nudCryVolume.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCryVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCryVolume.Name = "nudCryVolume";
            this.nudCryVolume.Size = new System.Drawing.Size(58, 20);
            this.nudCryVolume.TabIndex = 30;
            this.nudCryVolume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 362);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudCryVolume);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudCashPerLevel);
            this.Controls.Add(this.txtShinyGasp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnAllow);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBanned);
            this.Controls.Add(this.listAllowed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPokeGasp);
            this.Controls.Add(this.txtItemGasp2);
            this.Controls.Add(this.txtItemGasp1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPlayerLevel);
            this.Controls.Add(this.nudPokeLevel);
            this.Controls.Add(this.nudScanLimit);
            this.Controls.Add(this.nudItemTier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOptions";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormOptions_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormOptions_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormOptions_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.nudItemTier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPokeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashPerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCryVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudItemTier;
        private System.Windows.Forms.NumericUpDown nudScanLimit;
        private System.Windows.Forms.NumericUpDown nudPokeLevel;
        private System.Windows.Forms.NumericUpDown nudPlayerLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemGasp1;
        private System.Windows.Forms.TextBox txtItemGasp2;
        private System.Windows.Forms.TextBox txtPokeGasp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listAllowed;
        private System.Windows.Forms.ListBox listBanned;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnAllow;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.TextBox txtShinyGasp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudCashPerLevel;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCryVolume;
    }
}