namespace GenesisDex
{
    partial class FormScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScan));
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.btnScanPokemon = new System.Windows.Forms.PictureBox();
            this.nudLevelMin = new System.Windows.Forms.NumericUpDown();
            this.cbHabitat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLevelMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHasItem = new System.Windows.Forms.CheckBox();
            this.chkCanBeShiny = new System.Windows.Forms.CheckBox();
            this.pkItem = new System.Windows.Forms.PictureBox();
            this.pkHeld = new System.Windows.Forms.Label();
            this.chkCanBeLegend = new System.Windows.Forms.CheckBox();
            this.cbStageAllowed = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPokeRight = new System.Windows.Forms.PictureBox();
            this.btnPokeLeft = new System.Windows.Forms.PictureBox();
            this.btnLoot = new System.Windows.Forms.PictureBox();
            this.nudPlayerLevel = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPokeRefresh = new System.Windows.Forms.PictureBox();
            this.btnLootRefresh = new System.Windows.Forms.PictureBox();
            this.pkDamage = new System.Windows.Forms.NumericUpDown();
            this.btnDealDamage = new System.Windows.Forms.PictureBox();
            this.PokeGenerator = new System.ComponentModel.BackgroundWorker();
            this.prbGenerationProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.rtbGasp = new System.Windows.Forms.RichTextBox();
            this.tbPageCount = new System.Windows.Forms.RichTextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.PictureBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.btnInfoBack = new System.Windows.Forms.PictureBox();
            this.btnInfoForward = new System.Windows.Forms.PictureBox();
            this.lbPokemon = new System.Windows.Forms.ListBox();
            this.tbPokeCount = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLootRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDealDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(131, 68);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(205, 190);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPokemon.TabIndex = 31;
            this.pbPokemon.TabStop = false;
            // 
            // btnScanPokemon
            // 
            this.btnScanPokemon.BackColor = System.Drawing.Color.Transparent;
            this.btnScanPokemon.Location = new System.Drawing.Point(425, 576);
            this.btnScanPokemon.Name = "btnScanPokemon";
            this.btnScanPokemon.Size = new System.Drawing.Size(157, 33);
            this.btnScanPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnScanPokemon.TabIndex = 45;
            this.btnScanPokemon.TabStop = false;
            this.btnScanPokemon.Click += new System.EventHandler(this.btnScanPokemon_Click);
            this.btnScanPokemon.MouseLeave += new System.EventHandler(this.btnScanPokemon_MouseLeave);
            this.btnScanPokemon.MouseHover += new System.EventHandler(this.btnScanPokemon_MouseHover);
            // 
            // nudLevelMin
            // 
            this.nudLevelMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudLevelMin.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelMin.ForeColor = System.Drawing.Color.Black;
            this.nudLevelMin.Location = new System.Drawing.Point(466, 516);
            this.nudLevelMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudLevelMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevelMin.Name = "nudLevelMin";
            this.nudLevelMin.Size = new System.Drawing.Size(44, 24);
            this.nudLevelMin.TabIndex = 9;
            this.nudLevelMin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLevelMin.ValueChanged += new System.EventHandler(this.pkLevelMin_ValueChanged);
            // 
            // cbHabitat
            // 
            this.cbHabitat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHabitat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHabitat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHabitat.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHabitat.ForeColor = System.Drawing.Color.Black;
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(462, 360);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(128, 27);
            this.cbHabitat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(425, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(413, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Habitat";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(462, 393);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(128, 27);
            this.cbType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(423, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Type";
            // 
            // nudLevelMax
            // 
            this.nudLevelMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudLevelMax.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelMax.ForeColor = System.Drawing.Color.Black;
            this.nudLevelMax.Location = new System.Drawing.Point(524, 516);
            this.nudLevelMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudLevelMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevelMax.Name = "nudLevelMax";
            this.nudLevelMax.Size = new System.Drawing.Size(44, 24);
            this.nudLevelMax.TabIndex = 10;
            this.nudLevelMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLevelMax.ValueChanged += new System.EventHandler(this.pkLevelMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(524, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(466, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Min";
            // 
            // chkHasItem
            // 
            this.chkHasItem.AutoSize = true;
            this.chkHasItem.BackColor = System.Drawing.Color.Silver;
            this.chkHasItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkHasItem.FlatAppearance.BorderSize = 5;
            this.chkHasItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasItem.Location = new System.Drawing.Point(423, 426);
            this.chkHasItem.Name = "chkHasItem";
            this.chkHasItem.Size = new System.Drawing.Size(125, 20);
            this.chkHasItem.TabIndex = 6;
            this.chkHasItem.Text = "Generate Items?";
            this.chkHasItem.UseVisualStyleBackColor = false;
            this.chkHasItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkHasItem_KeyDown);
            // 
            // chkCanBeShiny
            // 
            this.chkCanBeShiny.AutoSize = true;
            this.chkCanBeShiny.BackColor = System.Drawing.Color.Silver;
            this.chkCanBeShiny.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkCanBeShiny.FlatAppearance.BorderSize = 5;
            this.chkCanBeShiny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanBeShiny.Location = new System.Drawing.Point(423, 451);
            this.chkCanBeShiny.Name = "chkCanBeShiny";
            this.chkCanBeShiny.Size = new System.Drawing.Size(126, 20);
            this.chkCanBeShiny.TabIndex = 7;
            this.chkCanBeShiny.Text = "Generate Shiny?";
            this.chkCanBeShiny.UseVisualStyleBackColor = false;
            this.chkCanBeShiny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkCanBeShiny_KeyDown);
            // 
            // pkItem
            // 
            this.pkItem.BackColor = System.Drawing.Color.Transparent;
            this.pkItem.Location = new System.Drawing.Point(880, 461);
            this.pkItem.Name = "pkItem";
            this.pkItem.Size = new System.Drawing.Size(118, 117);
            this.pkItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pkItem.TabIndex = 59;
            this.pkItem.TabStop = false;
            // 
            // pkHeld
            // 
            this.pkHeld.AutoSize = true;
            this.pkHeld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pkHeld.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pkHeld.Location = new System.Drawing.Point(451, 557);
            this.pkHeld.Name = "pkHeld";
            this.pkHeld.Size = new System.Drawing.Size(0, 13);
            this.pkHeld.TabIndex = 58;
            // 
            // chkCanBeLegend
            // 
            this.chkCanBeLegend.AutoSize = true;
            this.chkCanBeLegend.BackColor = System.Drawing.Color.Silver;
            this.chkCanBeLegend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkCanBeLegend.FlatAppearance.BorderSize = 5;
            this.chkCanBeLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanBeLegend.Location = new System.Drawing.Point(423, 476);
            this.chkCanBeLegend.Name = "chkCanBeLegend";
            this.chkCanBeLegend.Size = new System.Drawing.Size(156, 20);
            this.chkCanBeLegend.TabIndex = 8;
            this.chkCanBeLegend.Text = "Include Legendaries?";
            this.chkCanBeLegend.UseVisualStyleBackColor = false;
            this.chkCanBeLegend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkCanBeLegend_KeyDown);
            // 
            // cbStageAllowed
            // 
            this.cbStageAllowed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStageAllowed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStageAllowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbStageAllowed.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStageAllowed.ForeColor = System.Drawing.Color.Black;
            this.cbStageAllowed.FormattingEnabled = true;
            this.cbStageAllowed.Location = new System.Drawing.Point(462, 327);
            this.cbStageAllowed.Name = "cbStageAllowed";
            this.cbStageAllowed.Size = new System.Drawing.Size(128, 27);
            this.cbStageAllowed.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(419, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Stage";
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudAmount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.ForeColor = System.Drawing.Color.Black;
            this.nudAmount.Location = new System.Drawing.Point(493, 546);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(51, 24);
            this.nudAmount.TabIndex = 11;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(441, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Amount";
            // 
            // btnPokeRight
            // 
            this.btnPokeRight.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeRight.Location = new System.Drawing.Point(309, 279);
            this.btnPokeRight.Name = "btnPokeRight";
            this.btnPokeRight.Size = new System.Drawing.Size(37, 22);
            this.btnPokeRight.TabIndex = 71;
            this.btnPokeRight.TabStop = false;
            this.btnPokeRight.Click += new System.EventHandler(this.pbPokeRight_Click);
            // 
            // btnPokeLeft
            // 
            this.btnPokeLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeLeft.Location = new System.Drawing.Point(122, 279);
            this.btnPokeLeft.Name = "btnPokeLeft";
            this.btnPokeLeft.Size = new System.Drawing.Size(37, 22);
            this.btnPokeLeft.TabIndex = 70;
            this.btnPokeLeft.TabStop = false;
            this.btnPokeLeft.Click += new System.EventHandler(this.pbPokeLeft_Click);
            // 
            // btnLoot
            // 
            this.btnLoot.BackColor = System.Drawing.Color.Transparent;
            this.btnLoot.Location = new System.Drawing.Point(960, 72);
            this.btnLoot.Name = "btnLoot";
            this.btnLoot.Size = new System.Drawing.Size(126, 26);
            this.btnLoot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLoot.TabIndex = 78;
            this.btnLoot.TabStop = false;
            this.btnLoot.Click += new System.EventHandler(this.pbLoot_Click);
            this.btnLoot.MouseLeave += new System.EventHandler(this.pbLoot_MouseLeave);
            this.btnLoot.MouseHover += new System.EventHandler(this.pbLoot_MouseHover);
            // 
            // nudPlayerLevel
            // 
            this.nudPlayerLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nudPlayerLevel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlayerLevel.ForeColor = System.Drawing.Color.Black;
            this.nudPlayerLevel.Location = new System.Drawing.Point(1002, 105);
            this.nudPlayerLevel.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPlayerLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayerLevel.Name = "nudPlayerLevel";
            this.nudPlayerLevel.Size = new System.Drawing.Size(49, 24);
            this.nudPlayerLevel.TabIndex = 12;
            this.nudPlayerLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(466, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 28);
            this.label9.TabIndex = 80;
            this.label9.Text = "Player\r\nLevel";
            // 
            // btnPokeRefresh
            // 
            this.btnPokeRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeRefresh.Location = new System.Drawing.Point(1090, 103);
            this.btnPokeRefresh.Name = "btnPokeRefresh";
            this.btnPokeRefresh.Size = new System.Drawing.Size(98, 26);
            this.btnPokeRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPokeRefresh.TabIndex = 81;
            this.btnPokeRefresh.TabStop = false;
            this.btnPokeRefresh.Click += new System.EventHandler(this.pbPokeRefresh_Click);
            this.btnPokeRefresh.MouseLeave += new System.EventHandler(this.pbPokeRefresh_MouseLeave);
            this.btnPokeRefresh.MouseHover += new System.EventHandler(this.pbPokeRefresh_MouseHover);
            // 
            // btnLootRefresh
            // 
            this.btnLootRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnLootRefresh.Location = new System.Drawing.Point(1090, 72);
            this.btnLootRefresh.Name = "btnLootRefresh";
            this.btnLootRefresh.Size = new System.Drawing.Size(98, 26);
            this.btnLootRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnLootRefresh.TabIndex = 82;
            this.btnLootRefresh.TabStop = false;
            this.btnLootRefresh.Click += new System.EventHandler(this.pbLootRefresh_Click);
            this.btnLootRefresh.MouseLeave += new System.EventHandler(this.pbLootRefresh_MouseLeave);
            this.btnLootRefresh.MouseHover += new System.EventHandler(this.pbLootRefresh_MouseHover);
            // 
            // pkDamage
            // 
            this.pkDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pkDamage.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkDamage.ForeColor = System.Drawing.Color.Black;
            this.pkDamage.Location = new System.Drawing.Point(827, 605);
            this.pkDamage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pkDamage.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.pkDamage.Name = "pkDamage";
            this.pkDamage.Size = new System.Drawing.Size(53, 24);
            this.pkDamage.TabIndex = 83;
            this.pkDamage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkDamage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkDamage_KeyDown);
            // 
            // btnDealDamage
            // 
            this.btnDealDamage.BackColor = System.Drawing.Color.Transparent;
            this.btnDealDamage.Location = new System.Drawing.Point(695, 605);
            this.btnDealDamage.Name = "btnDealDamage";
            this.btnDealDamage.Size = new System.Drawing.Size(126, 26);
            this.btnDealDamage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDealDamage.TabIndex = 85;
            this.btnDealDamage.TabStop = false;
            this.btnDealDamage.Click += new System.EventHandler(this.pbDealDamage_Click);
            this.btnDealDamage.MouseLeave += new System.EventHandler(this.pbDealDamage_MouseLeave);
            this.btnDealDamage.MouseHover += new System.EventHandler(this.pbDealDamage_MouseHover);
            // 
            // PokeGenerator
            // 
            this.PokeGenerator.WorkerReportsProgress = true;
            this.PokeGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PokeGenerator_DoWork);
            this.PokeGenerator.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PokeGenerator_ProgressChanged);
            this.PokeGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PokeGenerator_RunWorkerCompleted);
            // 
            // prbGenerationProgress
            // 
            this.prbGenerationProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prbGenerationProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prbGenerationProgress.Location = new System.Drawing.Point(415, 655);
            this.prbGenerationProgress.Name = "prbGenerationProgress";
            this.prbGenerationProgress.Size = new System.Drawing.Size(181, 12);
            this.prbGenerationProgress.TabIndex = 86;
            this.prbGenerationProgress.Value = 100;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProgress.Location = new System.Drawing.Point(466, 637);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(80, 15);
            this.lblProgress.TabIndex = 87;
            this.lblProgress.Text = "Ready to Scan";
            // 
            // rtbGasp
            // 
            this.rtbGasp.AcceptsTab = true;
            this.rtbGasp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbGasp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGasp.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGasp.ForeColor = System.Drawing.Color.Black;
            this.rtbGasp.Location = new System.Drawing.Point(420, 63);
            this.rtbGasp.Name = "rtbGasp";
            this.rtbGasp.ReadOnly = true;
            this.rtbGasp.Size = new System.Drawing.Size(168, 203);
            this.rtbGasp.TabIndex = 93;
            this.rtbGasp.TabStop = false;
            this.rtbGasp.Text = "";
            // 
            // tbPageCount
            // 
            this.tbPageCount.AcceptsTab = true;
            this.tbPageCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPageCount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPageCount.ForeColor = System.Drawing.Color.Black;
            this.tbPageCount.Location = new System.Drawing.Point(921, 604);
            this.tbPageCount.Name = "tbPageCount";
            this.tbPageCount.ReadOnly = true;
            this.tbPageCount.Size = new System.Drawing.Size(33, 25);
            this.tbPageCount.TabIndex = 92;
            this.tbPageCount.TabStop = false;
            this.tbPageCount.Text = "";
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.Location = new System.Drawing.Point(67, 643);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(324, 17);
            this.tbSearch.TabIndex = 89;
            this.tbSearch.Tag = "";
            this.tbSearch.Text = "Search";
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.Location = new System.Drawing.Point(425, 275);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(157, 33);
            this.btnScan.TabIndex = 91;
            this.btnScan.TabStop = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            this.btnScan.MouseLeave += new System.EventHandler(this.btnScan_MouseLeave);
            this.btnScan.MouseHover += new System.EventHandler(this.btnScan_MouseHover);
            // 
            // rtbInfo
            // 
            this.rtbInfo.AcceptsTab = true;
            this.rtbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.ForeColor = System.Drawing.Color.Black;
            this.rtbInfo.Location = new System.Drawing.Point(695, 139);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(493, 454);
            this.rtbInfo.TabIndex = 90;
            this.rtbInfo.TabStop = false;
            this.rtbInfo.Text = "";
            // 
            // btnInfoBack
            // 
            this.btnInfoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoBack.Location = new System.Drawing.Point(883, 601);
            this.btnInfoBack.Name = "btnInfoBack";
            this.btnInfoBack.Size = new System.Drawing.Size(34, 34);
            this.btnInfoBack.TabIndex = 95;
            this.btnInfoBack.TabStop = false;
            this.btnInfoBack.Click += new System.EventHandler(this.btnInfoBack_Click);
            // 
            // btnInfoForward
            // 
            this.btnInfoForward.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoForward.Location = new System.Drawing.Point(960, 601);
            this.btnInfoForward.Name = "btnInfoForward";
            this.btnInfoForward.Size = new System.Drawing.Size(34, 34);
            this.btnInfoForward.TabIndex = 94;
            this.btnInfoForward.TabStop = false;
            this.btnInfoForward.Click += new System.EventHandler(this.btnInfoForward_Click);
            // 
            // lbPokemon
            // 
            this.lbPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbPokemon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPokemon.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPokemon.ForeColor = System.Drawing.Color.Black;
            this.lbPokemon.FormattingEnabled = true;
            this.lbPokemon.ItemHeight = 19;
            this.lbPokemon.Location = new System.Drawing.Point(67, 330);
            this.lbPokemon.Name = "lbPokemon";
            this.lbPokemon.Size = new System.Drawing.Size(324, 304);
            this.lbPokemon.TabIndex = 96;
            this.lbPokemon.SelectedIndexChanged += new System.EventHandler(this.lbPokemon_SelectedIndexChanged);
            // 
            // tbPokeCount
            // 
            this.tbPokeCount.AcceptsTab = true;
            this.tbPokeCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbPokeCount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPokeCount.ForeColor = System.Drawing.Color.Black;
            this.tbPokeCount.Location = new System.Drawing.Point(199, 276);
            this.tbPokeCount.Name = "tbPokeCount";
            this.tbPokeCount.ReadOnly = true;
            this.tbPokeCount.Size = new System.Drawing.Size(65, 25);
            this.tbPokeCount.TabIndex = 97;
            this.tbPokeCount.TabStop = false;
            this.tbPokeCount.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Location = new System.Drawing.Point(1220, 46);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 98;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.Location = new System.Drawing.Point(695, 72);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(82, 25);
            this.btnOptions.TabIndex = 99;
            this.btnOptions.TabStop = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnOptions_MouseLeave);
            this.btnOptions.MouseHover += new System.EventHandler(this.btnOptions_MouseHover);
            // 
            // FormScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbPokeCount);
            this.Controls.Add(this.lbPokemon);
            this.Controls.Add(this.btnInfoBack);
            this.Controls.Add(this.btnInfoForward);
            this.Controls.Add(this.rtbGasp);
            this.Controls.Add(this.tbPageCount);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prbGenerationProgress);
            this.Controls.Add(this.btnDealDamage);
            this.Controls.Add(this.pkDamage);
            this.Controls.Add(this.btnLootRefresh);
            this.Controls.Add(this.btnPokeRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPlayerLevel);
            this.Controls.Add(this.btnLoot);
            this.Controls.Add(this.btnPokeRight);
            this.Controls.Add(this.btnPokeLeft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbStageAllowed);
            this.Controls.Add(this.chkCanBeLegend);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.pkItem);
            this.Controls.Add(this.pkHeld);
            this.Controls.Add(this.chkCanBeShiny);
            this.Controls.Add(this.chkHasItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudLevelMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHabitat);
            this.Controls.Add(this.nudLevelMin);
            this.Controls.Add(this.btnScanPokemon);
            this.Controls.Add(this.rtbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeGenesis";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLootRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDealDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.PictureBox btnScanPokemon;
        private System.Windows.Forms.NumericUpDown nudLevelMin;
        private System.Windows.Forms.ComboBox cbHabitat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLevelMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkHasItem;
        private System.Windows.Forms.CheckBox chkCanBeShiny;
        private System.Windows.Forms.PictureBox pkItem;
        private System.Windows.Forms.Label pkHeld;
        private System.Windows.Forms.CheckBox chkCanBeLegend;
        private System.Windows.Forms.ComboBox cbStageAllowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnPokeRight;
        private System.Windows.Forms.PictureBox btnPokeLeft;
        private System.Windows.Forms.PictureBox btnLoot;
        private System.Windows.Forms.NumericUpDown nudPlayerLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnPokeRefresh;
        private System.Windows.Forms.PictureBox btnLootRefresh;
        private System.Windows.Forms.NumericUpDown pkDamage;
        private System.Windows.Forms.PictureBox btnDealDamage;
        private System.ComponentModel.BackgroundWorker PokeGenerator;
        private System.Windows.Forms.ProgressBar prbGenerationProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.RichTextBox rtbGasp;
        private System.Windows.Forms.RichTextBox tbPageCount;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox btnScan;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.PictureBox btnInfoBack;
        private System.Windows.Forms.PictureBox btnInfoForward;
        private System.Windows.Forms.ListBox lbPokemon;
        private System.Windows.Forms.RichTextBox tbPokeCount;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnOptions;
    }
}