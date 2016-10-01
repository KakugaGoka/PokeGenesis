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
            this.btnInfoBack = new System.Windows.Forms.PictureBox();
            this.btnInfoForward = new System.Windows.Forms.PictureBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.btnScan = new System.Windows.Forms.PictureBox();
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
            this.rtbGasp = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPokemon = new System.Windows.Forms.ComboBox();
            this.chkCanBeLegend = new System.Windows.Forms.CheckBox();
            this.cbStageAllowed = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPokeRight = new System.Windows.Forms.PictureBox();
            this.btnPokeLeft = new System.Windows.Forms.PictureBox();
            this.tbPokeCount = new System.Windows.Forms.RichTextBox();
            this.tbPageCount = new System.Windows.Forms.RichTextBox();
            this.btnGotoPage = new System.Windows.Forms.PictureBox();
            this.nudGoto = new System.Windows.Forms.NumericUpDown();
            this.btnLoot = new System.Windows.Forms.PictureBox();
            this.nudPlayerLevel = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPokeRefresh = new System.Windows.Forms.PictureBox();
            this.btnLootRefresh = new System.Windows.Forms.PictureBox();
            this.pkDamage = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbOverlay = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbDealDamage = new System.Windows.Forms.PictureBox();
            this.PokeGenerator = new System.ComponentModel.BackgroundWorker();
            this.prbGenerationProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGotoPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLootRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfoBack
            // 
            this.btnInfoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfoBack.BackgroundImage")));
            this.btnInfoBack.Location = new System.Drawing.Point(563, 551);
            this.btnInfoBack.Name = "btnInfoBack";
            this.btnInfoBack.Size = new System.Drawing.Size(38, 35);
            this.btnInfoBack.TabIndex = 37;
            this.btnInfoBack.TabStop = false;
            this.btnInfoBack.Click += new System.EventHandler(this.infoBack_Click);
            // 
            // btnInfoForward
            // 
            this.btnInfoForward.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInfoForward.BackgroundImage")));
            this.btnInfoForward.Location = new System.Drawing.Point(643, 551);
            this.btnInfoForward.Name = "btnInfoForward";
            this.btnInfoForward.Size = new System.Drawing.Size(33, 35);
            this.btnInfoForward.TabIndex = 36;
            this.btnInfoForward.TabStop = false;
            this.btnInfoForward.Click += new System.EventHandler(this.infoForward_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.AcceptsTab = true;
            this.rtbInfo.BackColor = System.Drawing.Color.Black;
            this.rtbInfo.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbInfo.Location = new System.Drawing.Point(461, 158);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(322, 387);
            this.rtbInfo.TabIndex = 35;
            this.rtbInfo.TabStop = false;
            this.rtbInfo.Text = "";
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExit.BackgroundImage")));
            this.pbExit.Location = new System.Drawing.Point(417, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(24, 23);
            this.pbExit.TabIndex = 32;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(115, 158);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(175, 159);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPokemon.TabIndex = 31;
            this.pbPokemon.TabStop = false;
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.Image = global::GenesisDex.Properties.Resources.Pokedex;
            this.btnScan.Location = new System.Drawing.Point(22, 23);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(86, 86);
            this.btnScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnScan.TabIndex = 44;
            this.btnScan.TabStop = false;
            this.btnScan.Click += new System.EventHandler(this.pbScan_Click);
            // 
            // btnScanPokemon
            // 
            this.btnScanPokemon.BackColor = System.Drawing.Color.Transparent;
            this.btnScanPokemon.Image = global::GenesisDex.Properties.Resources.ScanPokemon;
            this.btnScanPokemon.Location = new System.Drawing.Point(216, 547);
            this.btnScanPokemon.Name = "btnScanPokemon";
            this.btnScanPokemon.Size = new System.Drawing.Size(157, 33);
            this.btnScanPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnScanPokemon.TabIndex = 45;
            this.btnScanPokemon.TabStop = false;
            this.btnScanPokemon.Click += new System.EventHandler(this.pbScanPokemon_Click);
            this.btnScanPokemon.MouseLeave += new System.EventHandler(this.pbScanPokemon_MouseLeave);
            this.btnScanPokemon.MouseHover += new System.EventHandler(this.pbScanPokemon_MouseHover);
            // 
            // nudLevelMin
            // 
            this.nudLevelMin.BackColor = System.Drawing.Color.Black;
            this.nudLevelMin.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudLevelMin.Location = new System.Drawing.Point(271, 482);
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
            this.cbHabitat.BackColor = System.Drawing.Color.Black;
            this.cbHabitat.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHabitat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(79, 442);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(143, 27);
            this.cbHabitat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(230, 488);
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
            this.label2.Location = new System.Drawing.Point(30, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Habitat";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.BackColor = System.Drawing.Color.Black;
            this.cbType.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(80, 475);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(143, 27);
            this.cbType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(40, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Type";
            // 
            // nudLevelMax
            // 
            this.nudLevelMax.BackColor = System.Drawing.Color.Black;
            this.nudLevelMax.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudLevelMax.Location = new System.Drawing.Point(329, 482);
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
            this.label4.Location = new System.Drawing.Point(329, 465);
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
            this.label5.Location = new System.Drawing.Point(271, 465);
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
            this.chkHasItem.Location = new System.Drawing.Point(41, 508);
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
            this.chkCanBeShiny.Location = new System.Drawing.Point(41, 533);
            this.chkCanBeShiny.Name = "chkCanBeShiny";
            this.chkCanBeShiny.Size = new System.Drawing.Size(126, 20);
            this.chkCanBeShiny.TabIndex = 7;
            this.chkCanBeShiny.Text = "Generate Shiny?";
            this.chkCanBeShiny.UseVisualStyleBackColor = false;
            this.chkCanBeShiny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkCanBeShiny_KeyDown);
            // 
            // pkItem
            // 
            this.pkItem.BackColor = System.Drawing.Color.Black;
            this.pkItem.Location = new System.Drawing.Point(564, 412);
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
            this.pkHeld.Location = new System.Drawing.Point(229, 528);
            this.pkHeld.Name = "pkHeld";
            this.pkHeld.Size = new System.Drawing.Size(0, 13);
            this.pkHeld.TabIndex = 58;
            // 
            // rtbGasp
            // 
            this.rtbGasp.AcceptsTab = true;
            this.rtbGasp.BackColor = System.Drawing.Color.Black;
            this.rtbGasp.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbGasp.Location = new System.Drawing.Point(232, 376);
            this.rtbGasp.Name = "rtbGasp";
            this.rtbGasp.ReadOnly = true;
            this.rtbGasp.Size = new System.Drawing.Size(156, 88);
            this.rtbGasp.TabIndex = 61;
            this.rtbGasp.TabStop = false;
            this.rtbGasp.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(19, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Pokemon";
            // 
            // cbPokemon
            // 
            this.cbPokemon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPokemon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPokemon.BackColor = System.Drawing.Color.Black;
            this.cbPokemon.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbPokemon.FormattingEnabled = true;
            this.cbPokemon.Location = new System.Drawing.Point(79, 376);
            this.cbPokemon.Name = "cbPokemon";
            this.cbPokemon.Size = new System.Drawing.Size(143, 27);
            this.cbPokemon.TabIndex = 2;
            this.cbPokemon.TextChanged += new System.EventHandler(this.pkPokemon_TextChanged);
            // 
            // chkCanBeLegend
            // 
            this.chkCanBeLegend.AutoSize = true;
            this.chkCanBeLegend.BackColor = System.Drawing.Color.Silver;
            this.chkCanBeLegend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkCanBeLegend.FlatAppearance.BorderSize = 5;
            this.chkCanBeLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanBeLegend.Location = new System.Drawing.Point(41, 558);
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
            this.cbStageAllowed.BackColor = System.Drawing.Color.Black;
            this.cbStageAllowed.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStageAllowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbStageAllowed.FormattingEnabled = true;
            this.cbStageAllowed.Location = new System.Drawing.Point(80, 409);
            this.cbStageAllowed.Name = "cbStageAllowed";
            this.cbStageAllowed.Size = new System.Drawing.Size(143, 27);
            this.cbStageAllowed.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(36, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Stage";
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.Black;
            this.nudAmount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudAmount.Location = new System.Drawing.Point(271, 517);
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
            this.label8.Location = new System.Drawing.Point(219, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Amount";
            // 
            // btnPokeRight
            // 
            this.btnPokeRight.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeRight.Location = new System.Drawing.Point(330, 273);
            this.btnPokeRight.Name = "btnPokeRight";
            this.btnPokeRight.Size = new System.Drawing.Size(37, 22);
            this.btnPokeRight.TabIndex = 71;
            this.btnPokeRight.TabStop = false;
            this.btnPokeRight.Click += new System.EventHandler(this.pbPokeRight_Click);
            // 
            // btnPokeLeft
            // 
            this.btnPokeLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeLeft.Location = new System.Drawing.Point(45, 273);
            this.btnPokeLeft.Name = "btnPokeLeft";
            this.btnPokeLeft.Size = new System.Drawing.Size(37, 22);
            this.btnPokeLeft.TabIndex = 70;
            this.btnPokeLeft.TabStop = false;
            this.btnPokeLeft.Click += new System.EventHandler(this.pbPokeLeft_Click);
            // 
            // tbPokeCount
            // 
            this.tbPokeCount.AcceptsTab = true;
            this.tbPokeCount.BackColor = System.Drawing.Color.Black;
            this.tbPokeCount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPokeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPokeCount.Location = new System.Drawing.Point(320, 75);
            this.tbPokeCount.Name = "tbPokeCount";
            this.tbPokeCount.ReadOnly = true;
            this.tbPokeCount.Size = new System.Drawing.Size(68, 25);
            this.tbPokeCount.TabIndex = 72;
            this.tbPokeCount.TabStop = false;
            this.tbPokeCount.Text = "";
            // 
            // tbPageCount
            // 
            this.tbPageCount.AcceptsTab = true;
            this.tbPageCount.BackColor = System.Drawing.Color.Black;
            this.tbPageCount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPageCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPageCount.Location = new System.Drawing.Point(604, 551);
            this.tbPageCount.Name = "tbPageCount";
            this.tbPageCount.ReadOnly = true;
            this.tbPageCount.Size = new System.Drawing.Size(33, 25);
            this.tbPageCount.TabIndex = 73;
            this.tbPageCount.TabStop = false;
            this.tbPageCount.Text = "";
            // 
            // btnGotoPage
            // 
            this.btnGotoPage.BackColor = System.Drawing.Color.Transparent;
            this.btnGotoPage.Image = global::GenesisDex.Properties.Resources.GotoPage;
            this.btnGotoPage.Location = new System.Drawing.Point(207, 106);
            this.btnGotoPage.Name = "btnGotoPage";
            this.btnGotoPage.Size = new System.Drawing.Size(126, 26);
            this.btnGotoPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnGotoPage.TabIndex = 75;
            this.btnGotoPage.TabStop = false;
            this.btnGotoPage.Click += new System.EventHandler(this.pbGotoPage_Click);
            this.btnGotoPage.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.btnGotoPage.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // nudGoto
            // 
            this.nudGoto.BackColor = System.Drawing.Color.Black;
            this.nudGoto.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudGoto.Location = new System.Drawing.Point(339, 108);
            this.nudGoto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGoto.Name = "nudGoto";
            this.nudGoto.Size = new System.Drawing.Size(49, 24);
            this.nudGoto.TabIndex = 1;
            this.nudGoto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGoto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkGoto_KeyDown);
            // 
            // btnLoot
            // 
            this.btnLoot.BackColor = System.Drawing.Color.Transparent;
            this.btnLoot.Image = global::GenesisDex.Properties.Resources.ScanLoot;
            this.btnLoot.Location = new System.Drawing.Point(461, 126);
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
            this.nudPlayerLevel.BackColor = System.Drawing.Color.Black;
            this.nudPlayerLevel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPlayerLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nudPlayerLevel.Location = new System.Drawing.Point(510, 96);
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
            this.btnPokeRefresh.Image = global::GenesisDex.Properties.Resources.PokeView;
            this.btnPokeRefresh.Location = new System.Drawing.Point(461, 554);
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
            this.btnLootRefresh.Image = global::GenesisDex.Properties.Resources.LootView;
            this.btnLootRefresh.Location = new System.Drawing.Point(685, 554);
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
            this.pkDamage.BackColor = System.Drawing.Color.Black;
            this.pkDamage.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkDamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkDamage.Location = new System.Drawing.Point(80, 324);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GenesisDex.Properties.Resources.MainMenuOverlayBottom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // pbOverlay
            // 
            this.pbOverlay.BackColor = System.Drawing.Color.Transparent;
            this.pbOverlay.BackgroundImage = global::GenesisDex.Properties.Resources.MainMenuOverlay1;
            this.pbOverlay.Location = new System.Drawing.Point(17, 108);
            this.pbOverlay.Name = "pbOverlay";
            this.pbOverlay.Size = new System.Drawing.Size(371, 53);
            this.pbOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOverlay.TabIndex = 43;
            this.pbOverlay.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(244, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 84;
            this.label10.Text = "Current Page";
            // 
            // pbDealDamage
            // 
            this.pbDealDamage.BackColor = System.Drawing.Color.Transparent;
            this.pbDealDamage.Image = global::GenesisDex.Properties.Resources.DealDamage;
            this.pbDealDamage.Location = new System.Drawing.Point(139, 323);
            this.pbDealDamage.Name = "pbDealDamage";
            this.pbDealDamage.Size = new System.Drawing.Size(126, 26);
            this.pbDealDamage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDealDamage.TabIndex = 85;
            this.pbDealDamage.TabStop = false;
            this.pbDealDamage.Click += new System.EventHandler(this.pbDealDamage_Click);
            this.pbDealDamage.MouseLeave += new System.EventHandler(this.pbDealDamage_MouseLeave);
            this.pbDealDamage.MouseHover += new System.EventHandler(this.pbDealDamage_MouseHover);
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
            this.prbGenerationProgress.Location = new System.Drawing.Point(187, 145);
            this.prbGenerationProgress.Name = "prbGenerationProgress";
            this.prbGenerationProgress.Size = new System.Drawing.Size(181, 12);
            this.prbGenerationProgress.TabIndex = 86;
            this.prbGenerationProgress.Value = 100;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Silver;
            this.lblProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProgress.Location = new System.Drawing.Point(40, 144);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(80, 15);
            this.lblProgress.TabIndex = 87;
            this.lblProgress.Text = "Ready to Scan";
            // 
            // FormScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GenesisDex.Properties.Resources.MainMenu;
            this.ClientSize = new System.Drawing.Size(822, 616);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prbGenerationProgress);
            this.Controls.Add(this.pbDealDamage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pkDamage);
            this.Controls.Add(this.btnLootRefresh);
            this.Controls.Add(this.btnPokeRefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPlayerLevel);
            this.Controls.Add(this.btnLoot);
            this.Controls.Add(this.tbPokeCount);
            this.Controls.Add(this.nudGoto);
            this.Controls.Add(this.btnGotoPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPageCount);
            this.Controls.Add(this.btnPokeRight);
            this.Controls.Add(this.btnPokeLeft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbStageAllowed);
            this.Controls.Add(this.pbOverlay);
            this.Controls.Add(this.chkCanBeLegend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPokemon);
            this.Controls.Add(this.rtbGasp);
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
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnInfoBack);
            this.Controls.Add(this.btnInfoForward);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeGenesis";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGotoPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLootRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnInfoBack;
        private System.Windows.Forms.PictureBox btnInfoForward;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.PictureBox btnScan;
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
        private System.Windows.Forms.RichTextBox rtbGasp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPokemon;
        private System.Windows.Forms.CheckBox chkCanBeLegend;
        private System.Windows.Forms.ComboBox cbStageAllowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnPokeRight;
        private System.Windows.Forms.PictureBox btnPokeLeft;
        private System.Windows.Forms.RichTextBox tbPokeCount;
        private System.Windows.Forms.RichTextBox tbPageCount;
        private System.Windows.Forms.PictureBox btnGotoPage;
        private System.Windows.Forms.NumericUpDown nudGoto;
        private System.Windows.Forms.PictureBox btnLoot;
        private System.Windows.Forms.NumericUpDown nudPlayerLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnPokeRefresh;
        private System.Windows.Forms.PictureBox btnLootRefresh;
        private System.Windows.Forms.NumericUpDown pkDamage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbOverlay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbDealDamage;
        private System.ComponentModel.BackgroundWorker PokeGenerator;
        private System.Windows.Forms.ProgressBar prbGenerationProgress;
        private System.Windows.Forms.Label lblProgress;
    }
}