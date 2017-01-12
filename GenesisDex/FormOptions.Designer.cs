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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listAllowed = new System.Windows.Forms.ListBox();
            this.listBanned = new System.Windows.Forms.ListBox();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.btnAllow = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCashPerLevel = new System.Windows.Forms.NumericUpDown();
            this.btnRestoreOptions = new System.Windows.Forms.Button();
            this.btnAddPoke = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCryVolume = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudDexSkin = new System.Windows.Forms.NumericUpDown();
            this.listRegionAllowed = new System.Windows.Forms.ListBox();
            this.listRegionBanned = new System.Windows.Forms.ListBox();
            this.btnAddRegion = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRegionAdd = new System.Windows.Forms.Button();
            this.btnRegionRemove = new System.Windows.Forms.Button();
            this.listRegions = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSaveRegion = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.nudRegionMin = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nudRegionMax = new System.Windows.Forms.NumericUpDown();
            this.tbRegionName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDeleteRegion = new System.Windows.Forms.Button();
            this.btnRestoreRegions = new System.Windows.Forms.Button();
            this.btnDeletePoke = new System.Windows.Forms.Button();
            this.listPokeDex = new System.Windows.Forms.ListBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.gbPokedex = new System.Windows.Forms.GroupBox();
            this.gbRegion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSpawn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemTier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPokeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCashPerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCryVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegionMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegionMax)).BeginInit();
            this.gbOptions.SuspendLayout();
            this.gbPokedex.SuspendLayout();
            this.gbRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawn)).BeginInit();
            this.SuspendLayout();
            // 
            // nudItemTier
            // 
            this.nudItemTier.Location = new System.Drawing.Point(114, 30);
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
            this.nudScanLimit.Location = new System.Drawing.Point(114, 108);
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
            this.nudPokeLevel.Location = new System.Drawing.Point(114, 82);
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
            this.nudPlayerLevel.Location = new System.Drawing.Point(114, 56);
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
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max Item Tier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Player Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Pokemon Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pokemon Scan Limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Allowed Pokemon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(544, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Banned Pokemon";
            // 
            // listAllowed
            // 
            this.listAllowed.FormattingEnabled = true;
            this.listAllowed.Location = new System.Drawing.Point(316, 44);
            this.listAllowed.Name = "listAllowed";
            this.listAllowed.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listAllowed.Size = new System.Drawing.Size(180, 225);
            this.listAllowed.TabIndex = 16;
            // 
            // listBanned
            // 
            this.listBanned.FormattingEnabled = true;
            this.listBanned.Location = new System.Drawing.Point(547, 44);
            this.listBanned.Name = "listBanned";
            this.listBanned.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBanned.Size = new System.Drawing.Size(180, 225);
            this.listBanned.TabIndex = 17;
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Location = new System.Drawing.Point(111, 234);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(94, 23);
            this.btnSaveOptions.TabIndex = 18;
            this.btnSaveOptions.Text = "Save Options";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBan
            // 
            this.btnBan.Location = new System.Drawing.Point(502, 123);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(39, 23);
            this.btnBan.TabIndex = 19;
            this.btnBan.Text = " ----->";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // btnAllow
            // 
            this.btnAllow.Location = new System.Drawing.Point(502, 154);
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
            this.pbExit.Location = new System.Drawing.Point(188, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(24, 23);
            this.pbExit.TabIndex = 21;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cash Per Level";
            // 
            // nudCashPerLevel
            // 
            this.nudCashPerLevel.Location = new System.Drawing.Point(114, 134);
            this.nudCashPerLevel.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCashPerLevel.Name = "nudCashPerLevel";
            this.nudCashPerLevel.Size = new System.Drawing.Size(58, 20);
            this.nudCashPerLevel.TabIndex = 26;
            // 
            // btnRestoreOptions
            // 
            this.btnRestoreOptions.Location = new System.Drawing.Point(11, 234);
            this.btnRestoreOptions.Name = "btnRestoreOptions";
            this.btnRestoreOptions.Size = new System.Drawing.Size(94, 23);
            this.btnRestoreOptions.TabIndex = 28;
            this.btnRestoreOptions.Text = "Restore Options";
            this.btnRestoreOptions.UseVisualStyleBackColor = true;
            this.btnRestoreOptions.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnAddPoke
            // 
            this.btnAddPoke.Location = new System.Drawing.Point(6, 562);
            this.btnAddPoke.Name = "btnAddPoke";
            this.btnAddPoke.Size = new System.Drawing.Size(94, 23);
            this.btnAddPoke.TabIndex = 29;
            this.btnAddPoke.Text = "Add Pokemon";
            this.btnAddPoke.UseVisualStyleBackColor = true;
            this.btnAddPoke.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cry Volume";
            // 
            // nudCryVolume
            // 
            this.nudCryVolume.Location = new System.Drawing.Point(114, 160);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Pokedex Skin";
            // 
            // nudDexSkin
            // 
            this.nudDexSkin.Location = new System.Drawing.Point(114, 186);
            this.nudDexSkin.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDexSkin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDexSkin.Name = "nudDexSkin";
            this.nudDexSkin.Size = new System.Drawing.Size(58, 20);
            this.nudDexSkin.TabIndex = 32;
            this.nudDexSkin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listRegionAllowed
            // 
            this.listRegionAllowed.FormattingEnabled = true;
            this.listRegionAllowed.Location = new System.Drawing.Point(316, 313);
            this.listRegionAllowed.Name = "listRegionAllowed";
            this.listRegionAllowed.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRegionAllowed.Size = new System.Drawing.Size(180, 225);
            this.listRegionAllowed.TabIndex = 34;
            this.listRegionAllowed.SelectedIndexChanged += new System.EventHandler(this.listRegionAllowed_SelectedIndexChanged);
            // 
            // listRegionBanned
            // 
            this.listRegionBanned.FormattingEnabled = true;
            this.listRegionBanned.Location = new System.Drawing.Point(547, 313);
            this.listRegionBanned.Name = "listRegionBanned";
            this.listRegionBanned.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRegionBanned.Size = new System.Drawing.Size(180, 225);
            this.listRegionBanned.TabIndex = 35;
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.Location = new System.Drawing.Point(11, 267);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(94, 23);
            this.btnAddRegion.TabIndex = 36;
            this.btnAddRegion.Text = "Add Region";
            this.btnAddRegion.UseVisualStyleBackColor = true;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(544, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Foreign Pokemon";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Regional Pokemon";
            // 
            // btnRegionAdd
            // 
            this.btnRegionAdd.Location = new System.Drawing.Point(502, 421);
            this.btnRegionAdd.Name = "btnRegionAdd";
            this.btnRegionAdd.Size = new System.Drawing.Size(39, 23);
            this.btnRegionAdd.TabIndex = 40;
            this.btnRegionAdd.Text = "<----- ";
            this.btnRegionAdd.UseVisualStyleBackColor = true;
            this.btnRegionAdd.Click += new System.EventHandler(this.btnRegionRemove_Click);
            // 
            // btnRegionRemove
            // 
            this.btnRegionRemove.Location = new System.Drawing.Point(502, 390);
            this.btnRegionRemove.Name = "btnRegionRemove";
            this.btnRegionRemove.Size = new System.Drawing.Size(39, 23);
            this.btnRegionRemove.TabIndex = 39;
            this.btnRegionRemove.Text = " ----->";
            this.btnRegionRemove.UseVisualStyleBackColor = true;
            this.btnRegionRemove.Click += new System.EventHandler(this.btnRegionAdd_Click);
            // 
            // listRegions
            // 
            this.listRegions.FormattingEnabled = true;
            this.listRegions.Location = new System.Drawing.Point(30, 313);
            this.listRegions.Name = "listRegions";
            this.listRegions.Size = new System.Drawing.Size(180, 225);
            this.listRegions.TabIndex = 41;
            this.listRegions.SelectedIndexChanged += new System.EventHandler(this.listRegions_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Regions List";
            // 
            // btnSaveRegion
            // 
            this.btnSaveRegion.Location = new System.Drawing.Point(111, 296);
            this.btnSaveRegion.Name = "btnSaveRegion";
            this.btnSaveRegion.Size = new System.Drawing.Size(94, 23);
            this.btnSaveRegion.TabIndex = 43;
            this.btnSaveRegion.Text = "Save Region";
            this.btnSaveRegion.UseVisualStyleBackColor = true;
            this.btnSaveRegion.Click += new System.EventHandler(this.btnSaveRegion_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Min Level";
            // 
            // nudRegionMin
            // 
            this.nudRegionMin.Location = new System.Drawing.Point(271, 355);
            this.nudRegionMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRegionMin.Name = "nudRegionMin";
            this.nudRegionMin.Size = new System.Drawing.Size(39, 20);
            this.nudRegionMin.TabIndex = 44;
            this.nudRegionMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(214, 383);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Max Level";
            // 
            // nudRegionMax
            // 
            this.nudRegionMax.Location = new System.Drawing.Point(271, 381);
            this.nudRegionMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRegionMax.Name = "nudRegionMax";
            this.nudRegionMax.Size = new System.Drawing.Size(39, 20);
            this.nudRegionMax.TabIndex = 46;
            this.nudRegionMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tbRegionName
            // 
            this.tbRegionName.Location = new System.Drawing.Point(216, 329);
            this.tbRegionName.Name = "tbRegionName";
            this.tbRegionName.Size = new System.Drawing.Size(94, 20);
            this.tbRegionName.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(216, 313);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "Region Name";
            // 
            // btnDeleteRegion
            // 
            this.btnDeleteRegion.Location = new System.Drawing.Point(111, 267);
            this.btnDeleteRegion.Name = "btnDeleteRegion";
            this.btnDeleteRegion.Size = new System.Drawing.Size(94, 23);
            this.btnDeleteRegion.TabIndex = 50;
            this.btnDeleteRegion.Text = "Delete Region";
            this.btnDeleteRegion.UseVisualStyleBackColor = true;
            this.btnDeleteRegion.Click += new System.EventHandler(this.btnDeleteRegion_Click);
            // 
            // btnRestoreRegions
            // 
            this.btnRestoreRegions.Location = new System.Drawing.Point(10, 585);
            this.btnRestoreRegions.Name = "btnRestoreRegions";
            this.btnRestoreRegions.Size = new System.Drawing.Size(94, 23);
            this.btnRestoreRegions.TabIndex = 51;
            this.btnRestoreRegions.Text = "Restore Regions";
            this.btnRestoreRegions.UseVisualStyleBackColor = true;
            this.btnRestoreRegions.Click += new System.EventHandler(this.btnRestoreRegions_Click);
            // 
            // btnDeletePoke
            // 
            this.btnDeletePoke.Location = new System.Drawing.Point(112, 561);
            this.btnDeletePoke.Name = "btnDeletePoke";
            this.btnDeletePoke.Size = new System.Drawing.Size(94, 23);
            this.btnDeletePoke.TabIndex = 52;
            this.btnDeletePoke.Text = "Delete Pokemon";
            this.btnDeletePoke.UseVisualStyleBackColor = true;
            this.btnDeletePoke.Click += new System.EventHandler(this.btnDeletePoke_Click);
            // 
            // listPokeDex
            // 
            this.listPokeDex.FormattingEnabled = true;
            this.listPokeDex.Location = new System.Drawing.Point(16, 32);
            this.listPokeDex.Name = "listPokeDex";
            this.listPokeDex.Size = new System.Drawing.Size(180, 524);
            this.listPokeDex.TabIndex = 54;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnRestoreRegions);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.nudItemTier);
            this.gbOptions.Controls.Add(this.nudScanLimit);
            this.gbOptions.Controls.Add(this.nudPokeLevel);
            this.gbOptions.Controls.Add(this.nudPlayerLevel);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Controls.Add(this.label3);
            this.gbOptions.Controls.Add(this.label4);
            this.gbOptions.Controls.Add(this.nudCashPerLevel);
            this.gbOptions.Controls.Add(this.label12);
            this.gbOptions.Controls.Add(this.nudCryVolume);
            this.gbOptions.Controls.Add(this.label10);
            this.gbOptions.Controls.Add(this.nudDexSkin);
            this.gbOptions.Controls.Add(this.label13);
            this.gbOptions.Controls.Add(this.btnSaveOptions);
            this.gbOptions.Controls.Add(this.btnRestoreOptions);
            this.gbOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbOptions.Location = new System.Drawing.Point(12, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(731, 268);
            this.gbOptions.TabIndex = 55;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // gbPokedex
            // 
            this.gbPokedex.Controls.Add(this.listPokeDex);
            this.gbPokedex.Controls.Add(this.pbExit);
            this.gbPokedex.Controls.Add(this.btnDeletePoke);
            this.gbPokedex.Controls.Add(this.btnAddPoke);
            this.gbPokedex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbPokedex.Location = new System.Drawing.Point(747, 12);
            this.gbPokedex.Name = "gbPokedex";
            this.gbPokedex.Size = new System.Drawing.Size(212, 591);
            this.gbPokedex.TabIndex = 56;
            this.gbPokedex.TabStop = false;
            this.gbPokedex.Text = "Pokedex";
            // 
            // gbRegion
            // 
            this.gbRegion.Controls.Add(this.label6);
            this.gbRegion.Controls.Add(this.label5);
            this.gbRegion.Controls.Add(this.nudSpawn);
            this.gbRegion.Controls.Add(this.btnDeleteRegion);
            this.gbRegion.Controls.Add(this.btnAddRegion);
            this.gbRegion.Controls.Add(this.btnSaveRegion);
            this.gbRegion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbRegion.Location = new System.Drawing.Point(12, 277);
            this.gbRegion.Name = "gbRegion";
            this.gbRegion.Size = new System.Drawing.Size(731, 326);
            this.gbRegion.TabIndex = 57;
            this.gbRegion.TabStop = false;
            this.gbRegion.Text = "Regions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Rarity Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Current Selection\'s";
            // 
            // nudSpawn
            // 
            this.nudSpawn.Location = new System.Drawing.Point(416, 267);
            this.nudSpawn.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudSpawn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpawn.Name = "nudSpawn";
            this.nudSpawn.Size = new System.Drawing.Size(60, 20);
            this.nudSpawn.TabIndex = 58;
            this.nudSpawn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpawn.ValueChanged += new System.EventHandler(this.nudSpawn_ValueChanged);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(971, 615);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbRegionName);
            this.Controls.Add(this.nudRegionMax);
            this.Controls.Add(this.nudRegionMin);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.listRegions);
            this.Controls.Add(this.btnRegionAdd);
            this.Controls.Add(this.btnRegionRemove);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listRegionBanned);
            this.Controls.Add(this.listRegionAllowed);
            this.Controls.Add(this.btnAllow);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.listBanned);
            this.Controls.Add(this.listAllowed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbPokedex);
            this.Controls.Add(this.gbRegion);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDexSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegionMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegionMax)).EndInit();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbPokedex.ResumeLayout(false);
            this.gbRegion.ResumeLayout(false);
            this.gbRegion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawn)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listAllowed;
        private System.Windows.Forms.ListBox listBanned;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Button btnAllow;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudCashPerLevel;
        private System.Windows.Forms.Button btnRestoreOptions;
        private System.Windows.Forms.Button btnAddPoke;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCryVolume;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudDexSkin;
        private System.Windows.Forms.ListBox listRegionAllowed;
        private System.Windows.Forms.ListBox listRegionBanned;
        private System.Windows.Forms.Button btnAddRegion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRegionAdd;
        private System.Windows.Forms.Button btnRegionRemove;
        private System.Windows.Forms.ListBox listRegions;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSaveRegion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudRegionMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudRegionMax;
        private System.Windows.Forms.TextBox tbRegionName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDeleteRegion;
        private System.Windows.Forms.Button btnRestoreRegions;
        private System.Windows.Forms.Button btnDeletePoke;
        private System.Windows.Forms.ListBox listPokeDex;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbPokedex;
        private System.Windows.Forms.GroupBox gbRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSpawn;
    }
}