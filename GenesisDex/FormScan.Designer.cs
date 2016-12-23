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
            this.components = new System.ComponentModel.Container();
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
            this.label5 = new System.Windows.Forms.Label();
            this.chkHasItem = new System.Windows.Forms.CheckBox();
            this.chkCanBeShiny = new System.Windows.Forms.CheckBox();
            this.pkHeld = new System.Windows.Forms.Label();
            this.chkCanBeLegend = new System.Windows.Forms.CheckBox();
            this.cbStageAllowed = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPokeRight = new System.Windows.Forms.PictureBox();
            this.btnPokeLeft = new System.Windows.Forms.PictureBox();
            this.pkDamage = new System.Windows.Forms.NumericUpDown();
            this.btnDealDamage = new System.Windows.Forms.PictureBox();
            this.PokeGenerator = new System.ComponentModel.BackgroundWorker();
            this.prbGenerationProgress = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.rtbGasp = new System.Windows.Forms.RichTextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.PictureBox();
            this.lbPokemon = new System.Windows.Forms.ListBox();
            this.tbPokeCount = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCry = new System.Windows.Forms.PictureBox();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.PokeSaveScan = new System.ComponentModel.BackgroundWorker();
            this.PokeSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.chkForceShiny = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.tbMaxHealth = new System.Windows.Forms.TextBox();
            this.tbBaseHP = new System.Windows.Forms.TextBox();
            this.tbBaseATK = new System.Windows.Forms.TextBox();
            this.tbBaseDEF = new System.Windows.Forms.TextBox();
            this.tbBaseSPATK = new System.Windows.Forms.TextBox();
            this.tbBaseSPDEF = new System.Windows.Forms.TextBox();
            this.tbBaseSPD = new System.Windows.Forms.TextBox();
            this.tbCurrentHealth = new System.Windows.Forms.TextBox();
            this.tbCurrentHP = new System.Windows.Forms.TextBox();
            this.tbLevelHP = new System.Windows.Forms.TextBox();
            this.tbCurrentATK = new System.Windows.Forms.TextBox();
            this.tbLevelATK = new System.Windows.Forms.TextBox();
            this.tbCurrentDEF = new System.Windows.Forms.TextBox();
            this.tbLevelDEF = new System.Windows.Forms.TextBox();
            this.tbCurrentSPATK = new System.Windows.Forms.TextBox();
            this.tbLevelSPATK = new System.Windows.Forms.TextBox();
            this.tbCurrentSPDEF = new System.Windows.Forms.TextBox();
            this.tbLevelSPDEF = new System.Windows.Forms.TextBox();
            this.tbCurrentSPD = new System.Windows.Forms.TextBox();
            this.tbLevelSPD = new System.Windows.Forms.TextBox();
            this.nudHPCS = new System.Windows.Forms.NumericUpDown();
            this.nudATKCS = new System.Windows.Forms.NumericUpDown();
            this.nudDEFCS = new System.Windows.Forms.NumericUpDown();
            this.nudSPATKCS = new System.Windows.Forms.NumericUpDown();
            this.nudSPDEFCS = new System.Windows.Forms.NumericUpDown();
            this.nudSPDCS = new System.Windows.Forms.NumericUpDown();
            this.lbCapabilites = new System.Windows.Forms.ListBox();
            this.lbMoves = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbNature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNature = new System.Windows.Forms.ComboBox();
            this.tbCaptureRate = new System.Windows.Forms.TextBox();
            this.btnDealOneTick = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkBurned = new System.Windows.Forms.CheckBox();
            this.chkFrozen = new System.Windows.Forms.CheckBox();
            this.chkBadSleep = new System.Windows.Forms.CheckBox();
            this.chkPoisoned = new System.Windows.Forms.CheckBox();
            this.chkCursed = new System.Windows.Forms.CheckBox();
            this.chkRage = new System.Windows.Forms.CheckBox();
            this.chkInfatuation = new System.Windows.Forms.CheckBox();
            this.chkAsleep = new System.Windows.Forms.CheckBox();
            this.chkBlind = new System.Windows.Forms.CheckBox();
            this.chkTotalBlind = new System.Windows.Forms.CheckBox();
            this.chkSlowed = new System.Windows.Forms.CheckBox();
            this.chkSuppress = new System.Windows.Forms.CheckBox();
            this.chkFlinch = new System.Windows.Forms.CheckBox();
            this.chkConfused = new System.Windows.Forms.CheckBox();
            this.chkParalysis = new System.Windows.Forms.CheckBox();
            this.chkTrapped = new System.Windows.Forms.CheckBox();
            this.chkStuck = new System.Windows.Forms.CheckBox();
            this.chkFainted = new System.Windows.Forms.CheckBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.chkTripped = new System.Windows.Forms.CheckBox();
            this.chkVulnerable = new System.Windows.Forms.CheckBox();
            this.lbSkills = new System.Windows.Forms.ListBox();
            this.lbAbilities = new System.Windows.Forms.ListBox();
            this.pkItem = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnGetLoot = new System.Windows.Forms.PictureBox();
            this.btnDeletePoke = new System.Windows.Forms.PictureBox();
            this.btnGoTo = new System.Windows.Forms.PictureBox();
            this.nudGoTo = new System.Windows.Forms.NumericUpDown();
            this.PokeImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.PokeImportScan = new System.ComponentModel.BackgroundWorker();
            this.btnImport = new System.Windows.Forms.PictureBox();
            this.PokeSaveJSON = new System.ComponentModel.BackgroundWorker();
            this.btnRoll20Export = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDealDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudATKCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDEFCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPATKCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPDEFCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPDCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDealOneTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoll20Export)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(64, 60);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(250, 210);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPokemon.TabIndex = 31;
            this.pbPokemon.TabStop = false;
            // 
            // btnScanPokemon
            // 
            this.btnScanPokemon.BackColor = System.Drawing.Color.Transparent;
            this.btnScanPokemon.Location = new System.Drawing.Point(333, 493);
            this.btnScanPokemon.Name = "btnScanPokemon";
            this.btnScanPokemon.Size = new System.Drawing.Size(157, 33);
            this.btnScanPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnScanPokemon.TabIndex = 45;
            this.btnScanPokemon.TabStop = false;
            this.btnScanPokemon.MouseEnter += new System.EventHandler(this.btnScanPokemon_MouseEnter);
            this.btnScanPokemon.MouseLeave += new System.EventHandler(this.btnScanPokemon_MouseLeave);
            this.btnScanPokemon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScanPokemon_MouseUp);
            // 
            // nudLevelMin
            // 
            this.nudLevelMin.BackColor = System.Drawing.Color.Beige;
            this.nudLevelMin.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudLevelMin.Location = new System.Drawing.Point(541, 356);
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
            this.nudLevelMin.Size = new System.Drawing.Size(52, 24);
            this.nudLevelMin.TabIndex = 5;
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
            this.cbHabitat.BackColor = System.Drawing.Color.Beige;
            this.cbHabitat.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHabitat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Location = new System.Drawing.Point(373, 385);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(108, 27);
            this.cbHabitat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Max Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(331, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 49;
            this.label2.Text = "Habitat";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.BackColor = System.Drawing.Color.Beige;
            this.cbType.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(373, 415);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(108, 27);
            this.cbType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 51;
            this.label3.Text = "Type";
            // 
            // nudLevelMax
            // 
            this.nudLevelMax.BackColor = System.Drawing.Color.Beige;
            this.nudLevelMax.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudLevelMax.Location = new System.Drawing.Point(541, 326);
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
            this.nudLevelMax.Size = new System.Drawing.Size(52, 24);
            this.nudLevelMax.TabIndex = 6;
            this.nudLevelMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudLevelMax.ValueChanged += new System.EventHandler(this.pkLevelMax_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(488, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Min Level";
            // 
            // chkHasItem
            // 
            this.chkHasItem.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHasItem.AutoSize = true;
            this.chkHasItem.BackColor = System.Drawing.Color.Transparent;
            this.chkHasItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkHasItem.FlatAppearance.BorderSize = 0;
            this.chkHasItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkHasItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkHasItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkHasItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHasItem.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHasItem.ForeColor = System.Drawing.Color.White;
            this.chkHasItem.Image = ((System.Drawing.Image)(resources.GetObject("chkHasItem.Image")));
            this.chkHasItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkHasItem.Location = new System.Drawing.Point(490, 411);
            this.chkHasItem.Name = "chkHasItem";
            this.chkHasItem.Size = new System.Drawing.Size(108, 24);
            this.chkHasItem.TabIndex = 8;
            this.chkHasItem.Text = "Generate Items?";
            this.chkHasItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkHasItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkHasItem.UseVisualStyleBackColor = false;
            this.chkHasItem.CheckedChanged += new System.EventHandler(this.chkHasItem_CheckedChanged);
            this.chkHasItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkHasItem_KeyDown);
            // 
            // chkCanBeShiny
            // 
            this.chkCanBeShiny.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCanBeShiny.AutoSize = true;
            this.chkCanBeShiny.BackColor = System.Drawing.Color.Transparent;
            this.chkCanBeShiny.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkCanBeShiny.FlatAppearance.BorderSize = 0;
            this.chkCanBeShiny.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkCanBeShiny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkCanBeShiny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkCanBeShiny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCanBeShiny.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanBeShiny.ForeColor = System.Drawing.Color.White;
            this.chkCanBeShiny.Image = ((System.Drawing.Image)(resources.GetObject("chkCanBeShiny.Image")));
            this.chkCanBeShiny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkCanBeShiny.Location = new System.Drawing.Point(490, 435);
            this.chkCanBeShiny.Name = "chkCanBeShiny";
            this.chkCanBeShiny.Size = new System.Drawing.Size(106, 24);
            this.chkCanBeShiny.TabIndex = 9;
            this.chkCanBeShiny.Text = "Generate Shiny?";
            this.chkCanBeShiny.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCanBeShiny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkCanBeShiny.UseVisualStyleBackColor = false;
            this.chkCanBeShiny.CheckedChanged += new System.EventHandler(this.chkCanBeShiny_CheckedChanged);
            this.chkCanBeShiny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkCanBeShiny_KeyDown);
            // 
            // pkHeld
            // 
            this.pkHeld.AutoSize = true;
            this.pkHeld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pkHeld.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pkHeld.Location = new System.Drawing.Point(518, 356);
            this.pkHeld.Name = "pkHeld";
            this.pkHeld.Size = new System.Drawing.Size(0, 13);
            this.pkHeld.TabIndex = 58;
            // 
            // chkCanBeLegend
            // 
            this.chkCanBeLegend.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCanBeLegend.AutoSize = true;
            this.chkCanBeLegend.BackColor = System.Drawing.Color.Transparent;
            this.chkCanBeLegend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkCanBeLegend.FlatAppearance.BorderSize = 0;
            this.chkCanBeLegend.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkCanBeLegend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkCanBeLegend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkCanBeLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCanBeLegend.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCanBeLegend.ForeColor = System.Drawing.Color.White;
            this.chkCanBeLegend.Image = ((System.Drawing.Image)(resources.GetObject("chkCanBeLegend.Image")));
            this.chkCanBeLegend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkCanBeLegend.Location = new System.Drawing.Point(490, 483);
            this.chkCanBeLegend.Name = "chkCanBeLegend";
            this.chkCanBeLegend.Size = new System.Drawing.Size(92, 24);
            this.chkCanBeLegend.TabIndex = 11;
            this.chkCanBeLegend.Text = "Legendaries?";
            this.chkCanBeLegend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCanBeLegend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkCanBeLegend.UseVisualStyleBackColor = false;
            this.chkCanBeLegend.CheckedChanged += new System.EventHandler(this.chkCanBeLegend_CheckedChanged);
            this.chkCanBeLegend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkCanBeLegend_KeyDown);
            // 
            // cbStageAllowed
            // 
            this.cbStageAllowed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStageAllowed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStageAllowed.BackColor = System.Drawing.Color.Beige;
            this.cbStageAllowed.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStageAllowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStageAllowed.FormattingEnabled = true;
            this.cbStageAllowed.Location = new System.Drawing.Point(373, 355);
            this.cbStageAllowed.Name = "cbStageAllowed";
            this.cbStageAllowed.Size = new System.Drawing.Size(108, 27);
            this.cbStageAllowed.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 67;
            this.label7.Text = "Stage";
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.Beige;
            this.nudAmount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudAmount.Location = new System.Drawing.Point(541, 386);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(52, 24);
            this.nudAmount.TabIndex = 7;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(497, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 69;
            this.label8.Text = "Amount";
            // 
            // btnPokeRight
            // 
            this.btnPokeRight.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeRight.Image = ((System.Drawing.Image)(resources.GetObject("btnPokeRight.Image")));
            this.btnPokeRight.Location = new System.Drawing.Point(242, 275);
            this.btnPokeRight.Name = "btnPokeRight";
            this.btnPokeRight.Size = new System.Drawing.Size(34, 34);
            this.btnPokeRight.TabIndex = 71;
            this.btnPokeRight.TabStop = false;
            this.btnPokeRight.MouseEnter += new System.EventHandler(this.btnPokeRight_MouseEnter);
            this.btnPokeRight.MouseLeave += new System.EventHandler(this.btnPokeRight_MouseLeave);
            this.btnPokeRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPokeRight_MouseUp);
            // 
            // btnPokeLeft
            // 
            this.btnPokeLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnPokeLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnPokeLeft.Image")));
            this.btnPokeLeft.Location = new System.Drawing.Point(67, 275);
            this.btnPokeLeft.Name = "btnPokeLeft";
            this.btnPokeLeft.Size = new System.Drawing.Size(34, 34);
            this.btnPokeLeft.TabIndex = 70;
            this.btnPokeLeft.TabStop = false;
            this.btnPokeLeft.MouseEnter += new System.EventHandler(this.btnPokeLeft_MouseEnter);
            this.btnPokeLeft.MouseLeave += new System.EventHandler(this.btnPokeLeft_MouseLeave);
            this.btnPokeLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPokeLeft_MouseUp);
            // 
            // pkDamage
            // 
            this.pkDamage.BackColor = System.Drawing.Color.Beige;
            this.pkDamage.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkDamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pkDamage.Location = new System.Drawing.Point(891, 627);
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
            this.pkDamage.TabIndex = 13;
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
            this.btnDealDamage.Location = new System.Drawing.Point(950, 625);
            this.btnDealDamage.Name = "btnDealDamage";
            this.btnDealDamage.Size = new System.Drawing.Size(126, 26);
            this.btnDealDamage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDealDamage.TabIndex = 85;
            this.btnDealDamage.TabStop = false;
            this.btnDealDamage.MouseEnter += new System.EventHandler(this.pbDealDamage_MouseEnter);
            this.btnDealDamage.MouseLeave += new System.EventHandler(this.pbDealDamage_MouseLeave);
            this.btnDealDamage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDealDamage_MouseUp);
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
            this.prbGenerationProgress.Location = new System.Drawing.Point(334, 546);
            this.prbGenerationProgress.Name = "prbGenerationProgress";
            this.prbGenerationProgress.Size = new System.Drawing.Size(261, 12);
            this.prbGenerationProgress.TabIndex = 86;
            this.prbGenerationProgress.Value = 100;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgress.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(427, 532);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(70, 14);
            this.lblProgress.TabIndex = 87;
            this.lblProgress.Text = "Ready to Scan";
            // 
            // rtbGasp
            // 
            this.rtbGasp.AcceptsTab = true;
            this.rtbGasp.BackColor = System.Drawing.Color.Beige;
            this.rtbGasp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGasp.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbGasp.Location = new System.Drawing.Point(329, 63);
            this.rtbGasp.Name = "rtbGasp";
            this.rtbGasp.ReadOnly = true;
            this.rtbGasp.Size = new System.Drawing.Size(137, 203);
            this.rtbGasp.TabIndex = 93;
            this.rtbGasp.TabStop = false;
            this.rtbGasp.Text = "";
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.BackColor = System.Drawing.Color.Beige;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSearch.Location = new System.Drawing.Point(67, 643);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(243, 17);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Tag = "";
            this.tbSearch.Text = "Search";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.Location = new System.Drawing.Point(325, 275);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(130, 33);
            this.btnScan.TabIndex = 91;
            this.btnScan.TabStop = false;
            this.btnScan.MouseEnter += new System.EventHandler(this.btnScan_MouseEnter);
            this.btnScan.MouseLeave += new System.EventHandler(this.btnScan_MouseLeave);
            this.btnScan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnScan_MouseUp);
            // 
            // lbPokemon
            // 
            this.lbPokemon.BackColor = System.Drawing.Color.Beige;
            this.lbPokemon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPokemon.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPokemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPokemon.FormattingEnabled = true;
            this.lbPokemon.ItemHeight = 19;
            this.lbPokemon.Location = new System.Drawing.Point(67, 330);
            this.lbPokemon.Name = "lbPokemon";
            this.lbPokemon.Size = new System.Drawing.Size(243, 304);
            this.lbPokemon.TabIndex = 96;
            this.lbPokemon.SelectedIndexChanged += new System.EventHandler(this.lbPokemon_SelectedIndexChanged);
            this.lbPokemon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbPokemon_MouseDoubleClick);
            // 
            // tbPokeCount
            // 
            this.tbPokeCount.AcceptsTab = true;
            this.tbPokeCount.BackColor = System.Drawing.Color.Beige;
            this.tbPokeCount.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPokeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbPokeCount.Location = new System.Drawing.Point(139, 280);
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
            this.btnExit.Location = new System.Drawing.Point(1221, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 98;
            this.btnExit.TabStop = false;
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnExit_MouseUp);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.Location = new System.Drawing.Point(695, 617);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(82, 25);
            this.btnOptions.TabIndex = 99;
            this.btnOptions.TabStop = false;
            this.btnOptions.MouseEnter += new System.EventHandler(this.btnOptions_MouseEnter);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnOptions_MouseLeave);
            this.btnOptions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOptions_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(843, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 14);
            this.label10.TabIndex = 101;
            this.label10.Text = "Damage:";
            // 
            // btnCry
            // 
            this.btnCry.BackColor = System.Drawing.Color.Transparent;
            this.btnCry.Image = ((System.Drawing.Image)(resources.GetObject("btnCry.Image")));
            this.btnCry.Location = new System.Drawing.Point(282, 275);
            this.btnCry.Name = "btnCry";
            this.btnCry.Size = new System.Drawing.Size(33, 33);
            this.btnCry.TabIndex = 102;
            this.btnCry.TabStop = false;
            this.btnCry.MouseEnter += new System.EventHandler(this.btnCry_MouseEnter);
            this.btnCry.MouseLeave += new System.EventHandler(this.btnCry_MouseLeave);
            this.btnCry.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCry_MouseUp);
            // 
            // chkAppend
            // 
            this.chkAppend.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAppend.AutoSize = true;
            this.chkAppend.BackColor = System.Drawing.Color.Transparent;
            this.chkAppend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkAppend.FlatAppearance.BorderSize = 0;
            this.chkAppend.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAppend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkAppend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAppend.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppend.ForeColor = System.Drawing.Color.White;
            this.chkAppend.Image = ((System.Drawing.Image)(resources.GetObject("chkAppend.Image")));
            this.chkAppend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkAppend.Location = new System.Drawing.Point(490, 506);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.Size = new System.Drawing.Size(100, 24);
            this.chkAppend.TabIndex = 12;
            this.chkAppend.Text = "Append to List";
            this.chkAppend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAppend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkAppend.UseVisualStyleBackColor = false;
            this.chkAppend.CheckedChanged += new System.EventHandler(this.chkAppend_CheckedChanged);
            // 
            // PokeSaveScan
            // 
            this.PokeSaveScan.WorkerReportsProgress = true;
            this.PokeSaveScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PokeSaveScan_DoWork);
            this.PokeSaveScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PokeSaveScan_ProgressChanged);
            this.PokeSaveScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PokeSaveScan_RunWorkerCompleted);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(508, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 104;
            this.btnSave.TabStop = false;
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseUp);
            // 
            // chkForceShiny
            // 
            this.chkForceShiny.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkForceShiny.AutoSize = true;
            this.chkForceShiny.BackColor = System.Drawing.Color.Transparent;
            this.chkForceShiny.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkForceShiny.FlatAppearance.BorderSize = 0;
            this.chkForceShiny.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkForceShiny.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkForceShiny.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkForceShiny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkForceShiny.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkForceShiny.ForeColor = System.Drawing.Color.White;
            this.chkForceShiny.Image = ((System.Drawing.Image)(resources.GetObject("chkForceShiny.Image")));
            this.chkForceShiny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkForceShiny.Location = new System.Drawing.Point(505, 459);
            this.chkForceShiny.Name = "chkForceShiny";
            this.chkForceShiny.Size = new System.Drawing.Size(97, 24);
            this.chkForceShiny.TabIndex = 10;
            this.chkForceShiny.Text = "Always Shiny?";
            this.chkForceShiny.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkForceShiny.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkForceShiny.UseVisualStyleBackColor = false;
            this.chkForceShiny.CheckedChanged += new System.EventHandler(this.chkForceShiny_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(335, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 107;
            this.label11.Text = "Region";
            // 
            // cbRegion
            // 
            this.cbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRegion.BackColor = System.Drawing.Color.Beige;
            this.cbRegion.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(373, 325);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(108, 27);
            this.cbRegion.TabIndex = 1;
            this.cbRegion.SelectedIndexChanged += new System.EventHandler(this.cbRegion_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Beige;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbName.Location = new System.Drawing.Point(749, 141);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(158, 22);
            this.tbName.TabIndex = 108;
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.Color.Beige;
            this.tbType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbType.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbType.Location = new System.Drawing.Point(749, 162);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(158, 22);
            this.tbType.TabIndex = 109;
            this.tbType.MouseEnter += new System.EventHandler(this.tbType_MouseEnter);
            this.tbType.MouseLeave += new System.EventHandler(this.tbType_MouseLeave);
            // 
            // tbLevel
            // 
            this.tbLevel.BackColor = System.Drawing.Color.Beige;
            this.tbLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevel.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevel.Location = new System.Drawing.Point(749, 183);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.ReadOnly = true;
            this.tbLevel.Size = new System.Drawing.Size(158, 22);
            this.tbLevel.TabIndex = 110;
            // 
            // tbMaxHealth
            // 
            this.tbMaxHealth.BackColor = System.Drawing.Color.Beige;
            this.tbMaxHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMaxHealth.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbMaxHealth.Location = new System.Drawing.Point(749, 225);
            this.tbMaxHealth.Name = "tbMaxHealth";
            this.tbMaxHealth.ReadOnly = true;
            this.tbMaxHealth.Size = new System.Drawing.Size(38, 21);
            this.tbMaxHealth.TabIndex = 113;
            // 
            // tbBaseHP
            // 
            this.tbBaseHP.BackColor = System.Drawing.Color.Beige;
            this.tbBaseHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBaseHP.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBaseHP.Location = new System.Drawing.Point(749, 249);
            this.tbBaseHP.Name = "tbBaseHP";
            this.tbBaseHP.ReadOnly = true;
            this.tbBaseHP.Size = new System.Drawing.Size(38, 21);
            this.tbBaseHP.TabIndex = 114;
            // 
            // tbBaseATK
            // 
            this.tbBaseATK.BackColor = System.Drawing.Color.Beige;
            this.tbBaseATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBaseATK.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBaseATK.Location = new System.Drawing.Point(749, 273);
            this.tbBaseATK.Name = "tbBaseATK";
            this.tbBaseATK.ReadOnly = true;
            this.tbBaseATK.Size = new System.Drawing.Size(38, 21);
            this.tbBaseATK.TabIndex = 115;
            // 
            // tbBaseDEF
            // 
            this.tbBaseDEF.BackColor = System.Drawing.Color.Beige;
            this.tbBaseDEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBaseDEF.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBaseDEF.Location = new System.Drawing.Point(749, 297);
            this.tbBaseDEF.Name = "tbBaseDEF";
            this.tbBaseDEF.ReadOnly = true;
            this.tbBaseDEF.Size = new System.Drawing.Size(38, 21);
            this.tbBaseDEF.TabIndex = 116;
            // 
            // tbBaseSPATK
            // 
            this.tbBaseSPATK.BackColor = System.Drawing.Color.Beige;
            this.tbBaseSPATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBaseSPATK.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseSPATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBaseSPATK.Location = new System.Drawing.Point(749, 321);
            this.tbBaseSPATK.Name = "tbBaseSPATK";
            this.tbBaseSPATK.ReadOnly = true;
            this.tbBaseSPATK.Size = new System.Drawing.Size(38, 21);
            this.tbBaseSPATK.TabIndex = 117;
            // 
            // tbBaseSPDEF
            // 
            this.tbBaseSPDEF.BackColor = System.Drawing.Color.Beige;
            this.tbBaseSPDEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBaseSPDEF.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseSPDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBaseSPDEF.Location = new System.Drawing.Point(749, 345);
            this.tbBaseSPDEF.Name = "tbBaseSPDEF";
            this.tbBaseSPDEF.ReadOnly = true;
            this.tbBaseSPDEF.Size = new System.Drawing.Size(38, 21);
            this.tbBaseSPDEF.TabIndex = 118;
            // 
            // tbBaseSPD
            // 
            this.tbBaseSPD.BackColor = System.Drawing.Color.Beige;
            this.tbBaseSPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBaseSPD.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseSPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBaseSPD.Location = new System.Drawing.Point(749, 369);
            this.tbBaseSPD.Name = "tbBaseSPD";
            this.tbBaseSPD.ReadOnly = true;
            this.tbBaseSPD.Size = new System.Drawing.Size(38, 21);
            this.tbBaseSPD.TabIndex = 119;
            // 
            // tbCurrentHealth
            // 
            this.tbCurrentHealth.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentHealth.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentHealth.Location = new System.Drawing.Point(869, 225);
            this.tbCurrentHealth.Name = "tbCurrentHealth";
            this.tbCurrentHealth.ReadOnly = true;
            this.tbCurrentHealth.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentHealth.TabIndex = 120;
            // 
            // tbCurrentHP
            // 
            this.tbCurrentHP.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentHP.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentHP.Location = new System.Drawing.Point(869, 249);
            this.tbCurrentHP.Name = "tbCurrentHP";
            this.tbCurrentHP.ReadOnly = true;
            this.tbCurrentHP.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentHP.TabIndex = 123;
            // 
            // tbLevelHP
            // 
            this.tbLevelHP.BackColor = System.Drawing.Color.Beige;
            this.tbLevelHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelHP.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevelHP.Location = new System.Drawing.Point(789, 249);
            this.tbLevelHP.Name = "tbLevelHP";
            this.tbLevelHP.ReadOnly = true;
            this.tbLevelHP.Size = new System.Drawing.Size(38, 21);
            this.tbLevelHP.TabIndex = 122;
            // 
            // tbCurrentATK
            // 
            this.tbCurrentATK.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentATK.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentATK.Location = new System.Drawing.Point(869, 273);
            this.tbCurrentATK.Name = "tbCurrentATK";
            this.tbCurrentATK.ReadOnly = true;
            this.tbCurrentATK.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentATK.TabIndex = 125;
            // 
            // tbLevelATK
            // 
            this.tbLevelATK.BackColor = System.Drawing.Color.Beige;
            this.tbLevelATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelATK.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevelATK.Location = new System.Drawing.Point(789, 273);
            this.tbLevelATK.Name = "tbLevelATK";
            this.tbLevelATK.ReadOnly = true;
            this.tbLevelATK.Size = new System.Drawing.Size(38, 21);
            this.tbLevelATK.TabIndex = 124;
            // 
            // tbCurrentDEF
            // 
            this.tbCurrentDEF.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentDEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentDEF.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentDEF.Location = new System.Drawing.Point(869, 297);
            this.tbCurrentDEF.Name = "tbCurrentDEF";
            this.tbCurrentDEF.ReadOnly = true;
            this.tbCurrentDEF.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentDEF.TabIndex = 127;
            // 
            // tbLevelDEF
            // 
            this.tbLevelDEF.BackColor = System.Drawing.Color.Beige;
            this.tbLevelDEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelDEF.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevelDEF.Location = new System.Drawing.Point(789, 297);
            this.tbLevelDEF.Name = "tbLevelDEF";
            this.tbLevelDEF.Size = new System.Drawing.Size(38, 21);
            this.tbLevelDEF.TabIndex = 126;
            // 
            // tbCurrentSPATK
            // 
            this.tbCurrentSPATK.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentSPATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentSPATK.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentSPATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentSPATK.Location = new System.Drawing.Point(869, 321);
            this.tbCurrentSPATK.Name = "tbCurrentSPATK";
            this.tbCurrentSPATK.ReadOnly = true;
            this.tbCurrentSPATK.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentSPATK.TabIndex = 129;
            // 
            // tbLevelSPATK
            // 
            this.tbLevelSPATK.BackColor = System.Drawing.Color.Beige;
            this.tbLevelSPATK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelSPATK.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelSPATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevelSPATK.Location = new System.Drawing.Point(789, 321);
            this.tbLevelSPATK.Name = "tbLevelSPATK";
            this.tbLevelSPATK.Size = new System.Drawing.Size(38, 21);
            this.tbLevelSPATK.TabIndex = 128;
            // 
            // tbCurrentSPDEF
            // 
            this.tbCurrentSPDEF.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentSPDEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentSPDEF.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentSPDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentSPDEF.Location = new System.Drawing.Point(869, 345);
            this.tbCurrentSPDEF.Name = "tbCurrentSPDEF";
            this.tbCurrentSPDEF.ReadOnly = true;
            this.tbCurrentSPDEF.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentSPDEF.TabIndex = 131;
            // 
            // tbLevelSPDEF
            // 
            this.tbLevelSPDEF.BackColor = System.Drawing.Color.Beige;
            this.tbLevelSPDEF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelSPDEF.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelSPDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevelSPDEF.Location = new System.Drawing.Point(789, 345);
            this.tbLevelSPDEF.Name = "tbLevelSPDEF";
            this.tbLevelSPDEF.ReadOnly = true;
            this.tbLevelSPDEF.Size = new System.Drawing.Size(38, 21);
            this.tbLevelSPDEF.TabIndex = 130;
            // 
            // tbCurrentSPD
            // 
            this.tbCurrentSPD.BackColor = System.Drawing.Color.Beige;
            this.tbCurrentSPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentSPD.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentSPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCurrentSPD.Location = new System.Drawing.Point(869, 369);
            this.tbCurrentSPD.Name = "tbCurrentSPD";
            this.tbCurrentSPD.ReadOnly = true;
            this.tbCurrentSPD.Size = new System.Drawing.Size(38, 21);
            this.tbCurrentSPD.TabIndex = 133;
            // 
            // tbLevelSPD
            // 
            this.tbLevelSPD.BackColor = System.Drawing.Color.Beige;
            this.tbLevelSPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevelSPD.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelSPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbLevelSPD.Location = new System.Drawing.Point(789, 369);
            this.tbLevelSPD.Name = "tbLevelSPD";
            this.tbLevelSPD.ReadOnly = true;
            this.tbLevelSPD.Size = new System.Drawing.Size(38, 21);
            this.tbLevelSPD.TabIndex = 132;
            // 
            // nudHPCS
            // 
            this.nudHPCS.BackColor = System.Drawing.Color.Beige;
            this.nudHPCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHPCS.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHPCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudHPCS.Location = new System.Drawing.Point(829, 249);
            this.nudHPCS.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHPCS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudHPCS.Name = "nudHPCS";
            this.nudHPCS.Size = new System.Drawing.Size(38, 21);
            this.nudHPCS.TabIndex = 135;
            this.nudHPCS.ValueChanged += new System.EventHandler(this.nudHPCS_ValueChanged);
            // 
            // nudATKCS
            // 
            this.nudATKCS.BackColor = System.Drawing.Color.Beige;
            this.nudATKCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudATKCS.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudATKCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudATKCS.Location = new System.Drawing.Point(829, 273);
            this.nudATKCS.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudATKCS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudATKCS.Name = "nudATKCS";
            this.nudATKCS.Size = new System.Drawing.Size(38, 21);
            this.nudATKCS.TabIndex = 136;
            this.nudATKCS.ValueChanged += new System.EventHandler(this.nudATKCS_ValueChanged);
            // 
            // nudDEFCS
            // 
            this.nudDEFCS.BackColor = System.Drawing.Color.Beige;
            this.nudDEFCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDEFCS.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDEFCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudDEFCS.Location = new System.Drawing.Point(829, 297);
            this.nudDEFCS.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDEFCS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudDEFCS.Name = "nudDEFCS";
            this.nudDEFCS.Size = new System.Drawing.Size(38, 21);
            this.nudDEFCS.TabIndex = 137;
            this.nudDEFCS.ValueChanged += new System.EventHandler(this.nudDEFCS_ValueChanged);
            // 
            // nudSPATKCS
            // 
            this.nudSPATKCS.BackColor = System.Drawing.Color.Beige;
            this.nudSPATKCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSPATKCS.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSPATKCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudSPATKCS.Location = new System.Drawing.Point(829, 321);
            this.nudSPATKCS.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSPATKCS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudSPATKCS.Name = "nudSPATKCS";
            this.nudSPATKCS.Size = new System.Drawing.Size(38, 21);
            this.nudSPATKCS.TabIndex = 138;
            this.nudSPATKCS.ValueChanged += new System.EventHandler(this.nudSPATKCS_ValueChanged);
            // 
            // nudSPDEFCS
            // 
            this.nudSPDEFCS.BackColor = System.Drawing.Color.Beige;
            this.nudSPDEFCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSPDEFCS.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSPDEFCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudSPDEFCS.Location = new System.Drawing.Point(829, 345);
            this.nudSPDEFCS.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSPDEFCS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudSPDEFCS.Name = "nudSPDEFCS";
            this.nudSPDEFCS.Size = new System.Drawing.Size(38, 21);
            this.nudSPDEFCS.TabIndex = 139;
            this.nudSPDEFCS.ValueChanged += new System.EventHandler(this.nudSPDEFCS_ValueChanged);
            // 
            // nudSPDCS
            // 
            this.nudSPDCS.BackColor = System.Drawing.Color.Beige;
            this.nudSPDCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSPDCS.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSPDCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudSPDCS.Location = new System.Drawing.Point(829, 369);
            this.nudSPDCS.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSPDCS.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudSPDCS.Name = "nudSPDCS";
            this.nudSPDCS.Size = new System.Drawing.Size(38, 21);
            this.nudSPDCS.TabIndex = 140;
            this.nudSPDCS.ValueChanged += new System.EventHandler(this.nudSPDCS_ValueChanged);
            // 
            // lbCapabilites
            // 
            this.lbCapabilites.BackColor = System.Drawing.Color.Beige;
            this.lbCapabilites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCapabilites.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapabilites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCapabilites.FormattingEnabled = true;
            this.lbCapabilites.ItemHeight = 18;
            this.lbCapabilites.Location = new System.Drawing.Point(701, 408);
            this.lbCapabilites.Name = "lbCapabilites";
            this.lbCapabilites.Size = new System.Drawing.Size(238, 182);
            this.lbCapabilites.TabIndex = 141;
            this.lbCapabilites.MouseLeave += new System.EventHandler(this.lbCapabilites_MouseLeave);
            this.lbCapabilites.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbCaps_MouseMove);
            // 
            // lbMoves
            // 
            this.lbMoves.BackColor = System.Drawing.Color.Beige;
            this.lbMoves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMoves.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMoves.FormattingEnabled = true;
            this.lbMoves.ItemHeight = 18;
            this.lbMoves.Location = new System.Drawing.Point(945, 208);
            this.lbMoves.Name = "lbMoves";
            this.lbMoves.Size = new System.Drawing.Size(238, 146);
            this.lbMoves.TabIndex = 142;
            this.lbMoves.MouseLeave += new System.EventHandler(this.lbMoves_MouseLeave);
            this.lbMoves.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbMoves_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Beige;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(699, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 143;
            this.label12.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Beige;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(704, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 18);
            this.label13.TabIndex = 144;
            this.label13.Text = "Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Beige;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(701, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 18);
            this.label14.TabIndex = 145;
            this.label14.Text = "Level:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Beige;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(693, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 18);
            this.label15.TabIndex = 146;
            this.label15.Text = "Health:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Beige;
            this.label16.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(717, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 18);
            this.label16.TabIndex = 147;
            this.label16.Text = "HP:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Beige;
            this.label17.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(710, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 18);
            this.label17.TabIndex = 148;
            this.label17.Text = "ATK:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Beige;
            this.label18.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(710, 296);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 18);
            this.label18.TabIndex = 149;
            this.label18.Text = "DEF:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Beige;
            this.label19.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(711, 368);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 18);
            this.label19.TabIndex = 150;
            this.label19.Text = "SPD:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Beige;
            this.label20.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(696, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 18);
            this.label20.TabIndex = 151;
            this.label20.Text = "SPDEF:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Beige;
            this.label21.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(696, 320);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 18);
            this.label21.TabIndex = 152;
            this.label21.Text = "SPATK:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Beige;
            this.label22.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(750, 207);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 18);
            this.label22.TabIndex = 153;
            this.label22.Text = "Base";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Beige;
            this.label23.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(836, 207);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 18);
            this.label23.TabIndex = 154;
            this.label23.Text = "CS";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Beige;
            this.label24.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(869, 207);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 18);
            this.label24.TabIndex = 155;
            this.label24.Text = "Total";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Beige;
            this.label25.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(787, 207);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 18);
            this.label25.TabIndex = 156;
            this.label25.Text = "Level";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Beige;
            this.label26.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(698, 390);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 18);
            this.label26.TabIndex = 157;
            this.label26.Text = "Capabilities:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Beige;
            this.label28.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(931, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 18);
            this.label28.TabIndex = 160;
            this.label28.Text = "Nature:";
            // 
            // tbNature
            // 
            this.tbNature.BackColor = System.Drawing.Color.Beige;
            this.tbNature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNature.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbNature.Location = new System.Drawing.Point(989, 141);
            this.tbNature.Name = "tbNature";
            this.tbNature.ReadOnly = true;
            this.tbNature.Size = new System.Drawing.Size(158, 22);
            this.tbNature.TabIndex = 159;
            this.tbNature.MouseEnter += new System.EventHandler(this.tbNature_MouseEnter);
            this.tbNature.MouseLeave += new System.EventHandler(this.tbNature_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Beige;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(929, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 162;
            this.label6.Text = "Gender:";
            // 
            // tbGender
            // 
            this.tbGender.BackColor = System.Drawing.Color.Beige;
            this.tbGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGender.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbGender.Location = new System.Drawing.Point(989, 162);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(158, 22);
            this.tbGender.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(334, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 164;
            this.label4.Text = "Nature";
            // 
            // cbNature
            // 
            this.cbNature.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNature.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNature.BackColor = System.Drawing.Color.Beige;
            this.cbNature.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbNature.FormattingEnabled = true;
            this.cbNature.Location = new System.Drawing.Point(373, 445);
            this.cbNature.Name = "cbNature";
            this.cbNature.Size = new System.Drawing.Size(108, 27);
            this.cbNature.TabIndex = 163;
            // 
            // tbCaptureRate
            // 
            this.tbCaptureRate.BackColor = System.Drawing.Color.Beige;
            this.tbCaptureRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCaptureRate.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCaptureRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbCaptureRate.Location = new System.Drawing.Point(1050, 601);
            this.tbCaptureRate.Name = "tbCaptureRate";
            this.tbCaptureRate.ReadOnly = true;
            this.tbCaptureRate.Size = new System.Drawing.Size(138, 21);
            this.tbCaptureRate.TabIndex = 166;
            // 
            // btnDealOneTick
            // 
            this.btnDealOneTick.BackColor = System.Drawing.Color.Transparent;
            this.btnDealOneTick.Location = new System.Drawing.Point(1082, 625);
            this.btnDealOneTick.Name = "btnDealOneTick";
            this.btnDealOneTick.Size = new System.Drawing.Size(106, 26);
            this.btnDealOneTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDealOneTick.TabIndex = 167;
            this.btnDealOneTick.TabStop = false;
            this.btnDealOneTick.MouseEnter += new System.EventHandler(this.btnDealOneTick_MouseEnter);
            this.btnDealOneTick.MouseLeave += new System.EventHandler(this.btnDealOneTick_MouseLeave);
            this.btnDealOneTick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDealOneTick_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(980, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 14);
            this.label9.TabIndex = 168;
            this.label9.Text = "Capture Rate:";
            // 
            // chkBurned
            // 
            this.chkBurned.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBurned.AutoSize = true;
            this.chkBurned.BackColor = System.Drawing.Color.Transparent;
            this.chkBurned.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkBurned.FlatAppearance.BorderSize = 0;
            this.chkBurned.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkBurned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkBurned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkBurned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBurned.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBurned.ForeColor = System.Drawing.Color.White;
            this.chkBurned.Image = ((System.Drawing.Image)(resources.GetObject("chkBurned.Image")));
            this.chkBurned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkBurned.Location = new System.Drawing.Point(685, 68);
            this.chkBurned.Margin = new System.Windows.Forms.Padding(0);
            this.chkBurned.Name = "chkBurned";
            this.chkBurned.Size = new System.Drawing.Size(65, 24);
            this.chkBurned.TabIndex = 169;
            this.chkBurned.Text = "Burned";
            this.chkBurned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBurned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkBurned, resources.GetString("chkBurned.ToolTip"));
            this.chkBurned.UseVisualStyleBackColor = false;
            this.chkBurned.CheckedChanged += new System.EventHandler(this.chkBurned_CheckedChanged);
            this.chkBurned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkBurned_KeyDown);
            this.chkBurned.MouseLeave += new System.EventHandler(this.chkBurned_MouseLeave);
            this.chkBurned.MouseHover += new System.EventHandler(this.chkBurned_MouseHover);
            // 
            // chkFrozen
            // 
            this.chkFrozen.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFrozen.AutoSize = true;
            this.chkFrozen.BackColor = System.Drawing.Color.Transparent;
            this.chkFrozen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkFrozen.FlatAppearance.BorderSize = 0;
            this.chkFrozen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkFrozen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkFrozen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkFrozen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFrozen.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFrozen.ForeColor = System.Drawing.Color.White;
            this.chkFrozen.Image = ((System.Drawing.Image)(resources.GetObject("chkFrozen.Image")));
            this.chkFrozen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkFrozen.Location = new System.Drawing.Point(685, 90);
            this.chkFrozen.Margin = new System.Windows.Forms.Padding(0);
            this.chkFrozen.Name = "chkFrozen";
            this.chkFrozen.Size = new System.Drawing.Size(63, 24);
            this.chkFrozen.TabIndex = 170;
            this.chkFrozen.Text = "Frozen";
            this.chkFrozen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFrozen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkFrozen, resources.GetString("chkFrozen.ToolTip"));
            this.chkFrozen.UseVisualStyleBackColor = false;
            this.chkFrozen.CheckedChanged += new System.EventHandler(this.chkFrozen_CheckedChanged);
            this.chkFrozen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkFrozen_KeyDown);
            this.chkFrozen.MouseLeave += new System.EventHandler(this.chkFrozen_MouseLeave);
            this.chkFrozen.MouseHover += new System.EventHandler(this.chkFrozen_MouseHover);
            // 
            // chkBadSleep
            // 
            this.chkBadSleep.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBadSleep.AutoSize = true;
            this.chkBadSleep.BackColor = System.Drawing.Color.Transparent;
            this.chkBadSleep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkBadSleep.FlatAppearance.BorderSize = 0;
            this.chkBadSleep.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkBadSleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkBadSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkBadSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBadSleep.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBadSleep.ForeColor = System.Drawing.Color.White;
            this.chkBadSleep.Image = ((System.Drawing.Image)(resources.GetObject("chkBadSleep.Image")));
            this.chkBadSleep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkBadSleep.Location = new System.Drawing.Point(750, 90);
            this.chkBadSleep.Margin = new System.Windows.Forms.Padding(0);
            this.chkBadSleep.Name = "chkBadSleep";
            this.chkBadSleep.Size = new System.Drawing.Size(76, 24);
            this.chkBadSleep.TabIndex = 171;
            this.chkBadSleep.Text = "Bad Sleep";
            this.chkBadSleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBadSleep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkBadSleep, resources.GetString("chkBadSleep.ToolTip"));
            this.chkBadSleep.UseVisualStyleBackColor = false;
            this.chkBadSleep.CheckedChanged += new System.EventHandler(this.chkBadSleep_CheckedChanged);
            this.chkBadSleep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkBadSleep_KeyDown);
            this.chkBadSleep.MouseLeave += new System.EventHandler(this.chkBadSleep_MouseLeave);
            this.chkBadSleep.MouseHover += new System.EventHandler(this.chkBadSleep_MouseHover);
            // 
            // chkPoisoned
            // 
            this.chkPoisoned.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPoisoned.AutoSize = true;
            this.chkPoisoned.BackColor = System.Drawing.Color.Transparent;
            this.chkPoisoned.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkPoisoned.FlatAppearance.BorderSize = 0;
            this.chkPoisoned.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkPoisoned.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkPoisoned.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkPoisoned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPoisoned.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPoisoned.ForeColor = System.Drawing.Color.White;
            this.chkPoisoned.Image = ((System.Drawing.Image)(resources.GetObject("chkPoisoned.Image")));
            this.chkPoisoned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkPoisoned.Location = new System.Drawing.Point(750, 68);
            this.chkPoisoned.Margin = new System.Windows.Forms.Padding(0);
            this.chkPoisoned.Name = "chkPoisoned";
            this.chkPoisoned.Size = new System.Drawing.Size(73, 24);
            this.chkPoisoned.TabIndex = 172;
            this.chkPoisoned.Text = "Poisoned";
            this.chkPoisoned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPoisoned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkPoisoned, resources.GetString("chkPoisoned.ToolTip"));
            this.chkPoisoned.UseVisualStyleBackColor = false;
            this.chkPoisoned.CheckedChanged += new System.EventHandler(this.chkPoisoned_CheckedChanged);
            this.chkPoisoned.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkPoisoned_KeyDown);
            this.chkPoisoned.MouseLeave += new System.EventHandler(this.chkPoisoned_MouseLeave);
            this.chkPoisoned.MouseHover += new System.EventHandler(this.chkPoisoned_MouseHover);
            // 
            // chkCursed
            // 
            this.chkCursed.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCursed.AutoSize = true;
            this.chkCursed.BackColor = System.Drawing.Color.Transparent;
            this.chkCursed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkCursed.FlatAppearance.BorderSize = 0;
            this.chkCursed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkCursed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkCursed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkCursed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCursed.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCursed.ForeColor = System.Drawing.Color.White;
            this.chkCursed.Image = ((System.Drawing.Image)(resources.GetObject("chkCursed.Image")));
            this.chkCursed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkCursed.Location = new System.Drawing.Point(815, 68);
            this.chkCursed.Margin = new System.Windows.Forms.Padding(0);
            this.chkCursed.Name = "chkCursed";
            this.chkCursed.Size = new System.Drawing.Size(64, 24);
            this.chkCursed.TabIndex = 173;
            this.chkCursed.Text = "Cursed";
            this.chkCursed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCursed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkCursed, "Cursed: If a Cursed Target takes a Standard Action,\r\nthey lose two ticks of Hit P" +
        "oints at the end of that turn.");
            this.chkCursed.UseVisualStyleBackColor = false;
            this.chkCursed.CheckedChanged += new System.EventHandler(this.chkCursed_CheckedChanged);
            this.chkCursed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkCursed_KeyDown);
            this.chkCursed.MouseLeave += new System.EventHandler(this.chkCursed_MouseLeave);
            this.chkCursed.MouseHover += new System.EventHandler(this.chkCursed_MouseHover);
            // 
            // chkRage
            // 
            this.chkRage.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRage.AutoSize = true;
            this.chkRage.BackColor = System.Drawing.Color.Transparent;
            this.chkRage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkRage.FlatAppearance.BorderSize = 0;
            this.chkRage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkRage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkRage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkRage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRage.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRage.ForeColor = System.Drawing.Color.White;
            this.chkRage.Image = ((System.Drawing.Image)(resources.GetObject("chkRage.Image")));
            this.chkRage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkRage.Location = new System.Drawing.Point(815, 90);
            this.chkRage.Margin = new System.Windows.Forms.Padding(0);
            this.chkRage.Name = "chkRage";
            this.chkRage.Size = new System.Drawing.Size(53, 24);
            this.chkRage.TabIndex = 174;
            this.chkRage.Text = "Rage";
            this.chkRage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkRage, "Rage: While enraged, the target must use a Damaging\r\nPhysical or Special Move or " +
        "Struggle Attack. At the end\r\nof each turn, roll a DC15 Save Check; if they succe" +
        "ed,\r\nthey are cured of Rage.");
            this.chkRage.UseVisualStyleBackColor = false;
            this.chkRage.CheckedChanged += new System.EventHandler(this.chkRage_CheckedChanged);
            this.chkRage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkRage_KeyDown);
            this.chkRage.MouseLeave += new System.EventHandler(this.chkRage_MouseLeave);
            this.chkRage.MouseHover += new System.EventHandler(this.chkRage_MouseHover);
            // 
            // chkInfatuation
            // 
            this.chkInfatuation.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInfatuation.AutoSize = true;
            this.chkInfatuation.BackColor = System.Drawing.Color.Transparent;
            this.chkInfatuation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkInfatuation.FlatAppearance.BorderSize = 0;
            this.chkInfatuation.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkInfatuation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkInfatuation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkInfatuation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInfatuation.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfatuation.ForeColor = System.Drawing.Color.White;
            this.chkInfatuation.Image = ((System.Drawing.Image)(resources.GetObject("chkInfatuation.Image")));
            this.chkInfatuation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkInfatuation.Location = new System.Drawing.Point(880, 68);
            this.chkInfatuation.Margin = new System.Windows.Forms.Padding(0);
            this.chkInfatuation.Name = "chkInfatuation";
            this.chkInfatuation.Size = new System.Drawing.Size(81, 24);
            this.chkInfatuation.TabIndex = 175;
            this.chkInfatuation.Text = "Infatuated";
            this.chkInfatuation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkInfatuation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkInfatuation, resources.GetString("chkInfatuation.ToolTip"));
            this.chkInfatuation.UseVisualStyleBackColor = false;
            this.chkInfatuation.CheckedChanged += new System.EventHandler(this.chkInfatuation_CheckedChanged);
            this.chkInfatuation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkInfatuation_KeyDown);
            this.chkInfatuation.MouseLeave += new System.EventHandler(this.chkInfatuation_MouseLeave);
            this.chkInfatuation.MouseHover += new System.EventHandler(this.chkInfatuation_MouseHover);
            // 
            // chkAsleep
            // 
            this.chkAsleep.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAsleep.AutoSize = true;
            this.chkAsleep.BackColor = System.Drawing.Color.Transparent;
            this.chkAsleep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkAsleep.FlatAppearance.BorderSize = 0;
            this.chkAsleep.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAsleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkAsleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkAsleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAsleep.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsleep.ForeColor = System.Drawing.Color.White;
            this.chkAsleep.Image = ((System.Drawing.Image)(resources.GetObject("chkAsleep.Image")));
            this.chkAsleep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkAsleep.Location = new System.Drawing.Point(960, 90);
            this.chkAsleep.Margin = new System.Windows.Forms.Padding(0);
            this.chkAsleep.Name = "chkAsleep";
            this.chkAsleep.Size = new System.Drawing.Size(62, 24);
            this.chkAsleep.TabIndex = 176;
            this.chkAsleep.Text = "Asleep";
            this.chkAsleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAsleep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkAsleep, resources.GetString("chkAsleep.ToolTip"));
            this.chkAsleep.UseVisualStyleBackColor = false;
            this.chkAsleep.CheckedChanged += new System.EventHandler(this.chkAsleep_CheckedChanged);
            this.chkAsleep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkAsleep_KeyDown);
            this.chkAsleep.MouseLeave += new System.EventHandler(this.chkAsleep_MouseLeave);
            this.chkAsleep.MouseHover += new System.EventHandler(this.chkAsleep_MouseHover);
            // 
            // chkBlind
            // 
            this.chkBlind.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBlind.AutoSize = true;
            this.chkBlind.BackColor = System.Drawing.Color.Transparent;
            this.chkBlind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkBlind.FlatAppearance.BorderSize = 0;
            this.chkBlind.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkBlind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkBlind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkBlind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBlind.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlind.ForeColor = System.Drawing.Color.White;
            this.chkBlind.Image = ((System.Drawing.Image)(resources.GetObject("chkBlind.Image")));
            this.chkBlind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkBlind.Location = new System.Drawing.Point(960, 68);
            this.chkBlind.Margin = new System.Windows.Forms.Padding(0);
            this.chkBlind.Name = "chkBlind";
            this.chkBlind.Size = new System.Drawing.Size(56, 24);
            this.chkBlind.TabIndex = 177;
            this.chkBlind.Text = "Blind";
            this.chkBlind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBlind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkBlind, resources.GetString("chkBlind.ToolTip"));
            this.chkBlind.UseVisualStyleBackColor = false;
            this.chkBlind.CheckedChanged += new System.EventHandler(this.chkBlind_CheckedChanged);
            this.chkBlind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkBlind_KeyDown);
            this.chkBlind.MouseLeave += new System.EventHandler(this.chkBlind_MouseLeave);
            this.chkBlind.MouseHover += new System.EventHandler(this.chkBlind_MouseHover);
            // 
            // chkTotalBlind
            // 
            this.chkTotalBlind.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTotalBlind.AutoSize = true;
            this.chkTotalBlind.BackColor = System.Drawing.Color.Transparent;
            this.chkTotalBlind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkTotalBlind.FlatAppearance.BorderSize = 0;
            this.chkTotalBlind.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkTotalBlind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkTotalBlind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkTotalBlind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTotalBlind.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTotalBlind.ForeColor = System.Drawing.Color.White;
            this.chkTotalBlind.Image = ((System.Drawing.Image)(resources.GetObject("chkTotalBlind.Image")));
            this.chkTotalBlind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTotalBlind.Location = new System.Drawing.Point(880, 90);
            this.chkTotalBlind.Margin = new System.Windows.Forms.Padding(0);
            this.chkTotalBlind.Name = "chkTotalBlind";
            this.chkTotalBlind.Size = new System.Drawing.Size(89, 24);
            this.chkTotalBlind.TabIndex = 178;
            this.chkTotalBlind.Text = "Totally Blind";
            this.chkTotalBlind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTotalBlind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkTotalBlind, resources.GetString("chkTotalBlind.ToolTip"));
            this.chkTotalBlind.UseVisualStyleBackColor = false;
            this.chkTotalBlind.CheckedChanged += new System.EventHandler(this.chkTotalBlind_CheckedChanged);
            this.chkTotalBlind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTotalBlind_KeyDown);
            this.chkTotalBlind.MouseLeave += new System.EventHandler(this.chkTotalBlind_MouseLeave);
            this.chkTotalBlind.MouseHover += new System.EventHandler(this.chkTotalBlind_MouseHover);
            // 
            // chkSlowed
            // 
            this.chkSlowed.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSlowed.AutoSize = true;
            this.chkSlowed.BackColor = System.Drawing.Color.Transparent;
            this.chkSlowed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkSlowed.FlatAppearance.BorderSize = 0;
            this.chkSlowed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkSlowed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkSlowed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkSlowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSlowed.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSlowed.ForeColor = System.Drawing.Color.White;
            this.chkSlowed.Image = ((System.Drawing.Image)(resources.GetObject("chkSlowed.Image")));
            this.chkSlowed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkSlowed.Location = new System.Drawing.Point(960, 112);
            this.chkSlowed.Margin = new System.Windows.Forms.Padding(0);
            this.chkSlowed.Name = "chkSlowed";
            this.chkSlowed.Size = new System.Drawing.Size(64, 24);
            this.chkSlowed.TabIndex = 183;
            this.chkSlowed.Text = "Slowed";
            this.chkSlowed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSlowed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkSlowed, "Slowed: A Pokémon that is Slowed has its Movement\r\nhalved (minimum 1). This condi" +
        "tion may be removed\r\nby switching, or at the end of a Scene as an Extended\r\nActi" +
        "on.");
            this.chkSlowed.UseVisualStyleBackColor = false;
            this.chkSlowed.CheckedChanged += new System.EventHandler(this.chkSlowed_CheckedChanged);
            this.chkSlowed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkSlowed_KeyDown);
            this.chkSlowed.MouseLeave += new System.EventHandler(this.chkSlowed_MouseLeave);
            this.chkSlowed.MouseHover += new System.EventHandler(this.chkSlowed_MouseHover);
            // 
            // chkSuppress
            // 
            this.chkSuppress.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSuppress.AutoSize = true;
            this.chkSuppress.BackColor = System.Drawing.Color.Transparent;
            this.chkSuppress.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkSuppress.FlatAppearance.BorderSize = 0;
            this.chkSuppress.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkSuppress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkSuppress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkSuppress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSuppress.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuppress.ForeColor = System.Drawing.Color.White;
            this.chkSuppress.Image = ((System.Drawing.Image)(resources.GetObject("chkSuppress.Image")));
            this.chkSuppress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkSuppress.Location = new System.Drawing.Point(880, 112);
            this.chkSuppress.Margin = new System.Windows.Forms.Padding(0);
            this.chkSuppress.Name = "chkSuppress";
            this.chkSuppress.Size = new System.Drawing.Size(85, 24);
            this.chkSuppress.TabIndex = 182;
            this.chkSuppress.Text = "Suppressed";
            this.chkSuppress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSuppress.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkSuppress, "Suppressed: While Suppressed, Pokémon and Trainers\r\ncannot benefit from PP Ups, a" +
        "nd have the frequency of\r\ntheir Moves lowered; At-Will Moves become EOT, and\r\nEO" +
        "T and Scene x2 Moves become Scene.");
            this.chkSuppress.UseVisualStyleBackColor = false;
            this.chkSuppress.CheckedChanged += new System.EventHandler(this.chkSuppress_CheckedChanged);
            this.chkSuppress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkSuppress_KeyDown);
            this.chkSuppress.MouseLeave += new System.EventHandler(this.chkSuppress_MouseLeave);
            this.chkSuppress.MouseHover += new System.EventHandler(this.chkSuppress_MouseHover);
            // 
            // chkFlinch
            // 
            this.chkFlinch.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFlinch.AutoSize = true;
            this.chkFlinch.BackColor = System.Drawing.Color.Transparent;
            this.chkFlinch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkFlinch.FlatAppearance.BorderSize = 0;
            this.chkFlinch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkFlinch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkFlinch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkFlinch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFlinch.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlinch.ForeColor = System.Drawing.Color.White;
            this.chkFlinch.Image = ((System.Drawing.Image)(resources.GetObject("chkFlinch.Image")));
            this.chkFlinch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkFlinch.Location = new System.Drawing.Point(815, 112);
            this.chkFlinch.Margin = new System.Windows.Forms.Padding(0);
            this.chkFlinch.Name = "chkFlinch";
            this.chkFlinch.Size = new System.Drawing.Size(72, 24);
            this.chkFlinch.TabIndex = 181;
            this.chkFlinch.Text = "Flinched";
            this.chkFlinch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFlinch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkFlinch, "Flinch: You may not take actions during your next turn\r\nthat round. The Flinched " +
        "Status does not carry over\r\nonto the next round.");
            this.chkFlinch.UseVisualStyleBackColor = false;
            this.chkFlinch.CheckedChanged += new System.EventHandler(this.chkFlinch_CheckedChanged);
            this.chkFlinch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkFlinch_KeyDown);
            this.chkFlinch.MouseLeave += new System.EventHandler(this.chkFlinch_MouseLeave);
            this.chkFlinch.MouseHover += new System.EventHandler(this.chkFlinch_MouseHover);
            // 
            // chkConfused
            // 
            this.chkConfused.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkConfused.AutoSize = true;
            this.chkConfused.BackColor = System.Drawing.Color.Transparent;
            this.chkConfused.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkConfused.FlatAppearance.BorderSize = 0;
            this.chkConfused.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkConfused.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkConfused.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkConfused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkConfused.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfused.ForeColor = System.Drawing.Color.White;
            this.chkConfused.Image = ((System.Drawing.Image)(resources.GetObject("chkConfused.Image")));
            this.chkConfused.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkConfused.Location = new System.Drawing.Point(750, 112);
            this.chkConfused.Margin = new System.Windows.Forms.Padding(0);
            this.chkConfused.Name = "chkConfused";
            this.chkConfused.Size = new System.Drawing.Size(75, 24);
            this.chkConfused.TabIndex = 180;
            this.chkConfused.Text = "Confused";
            this.chkConfused.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConfused.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkConfused, resources.GetString("chkConfused.ToolTip"));
            this.chkConfused.UseVisualStyleBackColor = false;
            this.chkConfused.CheckedChanged += new System.EventHandler(this.chkConfused_CheckedChanged);
            this.chkConfused.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkConfused_KeyDown);
            this.chkConfused.MouseLeave += new System.EventHandler(this.chkConfused_MouseLeave);
            this.chkConfused.MouseHover += new System.EventHandler(this.chkConfused_MouseHover);
            // 
            // chkParalysis
            // 
            this.chkParalysis.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkParalysis.AutoSize = true;
            this.chkParalysis.BackColor = System.Drawing.Color.Transparent;
            this.chkParalysis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkParalysis.FlatAppearance.BorderSize = 0;
            this.chkParalysis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkParalysis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkParalysis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkParalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkParalysis.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParalysis.ForeColor = System.Drawing.Color.White;
            this.chkParalysis.Image = ((System.Drawing.Image)(resources.GetObject("chkParalysis.Image")));
            this.chkParalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkParalysis.Location = new System.Drawing.Point(685, 112);
            this.chkParalysis.Margin = new System.Windows.Forms.Padding(0);
            this.chkParalysis.Name = "chkParalysis";
            this.chkParalysis.Size = new System.Drawing.Size(76, 24);
            this.chkParalysis.TabIndex = 179;
            this.chkParalysis.Text = "Paralyzed";
            this.chkParalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkParalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkParalysis, resources.GetString("chkParalysis.ToolTip"));
            this.chkParalysis.UseVisualStyleBackColor = false;
            this.chkParalysis.CheckedChanged += new System.EventHandler(this.chkParalysis_CheckedChanged);
            this.chkParalysis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkParalysis_KeyDown);
            this.chkParalysis.MouseLeave += new System.EventHandler(this.chkParalysis_MouseLeave);
            this.chkParalysis.MouseHover += new System.EventHandler(this.chkParalysis_MouseHover);
            // 
            // chkTrapped
            // 
            this.chkTrapped.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTrapped.AutoSize = true;
            this.chkTrapped.BackColor = System.Drawing.Color.Transparent;
            this.chkTrapped.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkTrapped.FlatAppearance.BorderSize = 0;
            this.chkTrapped.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkTrapped.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkTrapped.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkTrapped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTrapped.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrapped.ForeColor = System.Drawing.Color.White;
            this.chkTrapped.Image = ((System.Drawing.Image)(resources.GetObject("chkTrapped.Image")));
            this.chkTrapped.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTrapped.Location = new System.Drawing.Point(1025, 90);
            this.chkTrapped.Margin = new System.Windows.Forms.Padding(0);
            this.chkTrapped.Name = "chkTrapped";
            this.chkTrapped.Size = new System.Drawing.Size(70, 24);
            this.chkTrapped.TabIndex = 185;
            this.chkTrapped.Text = "Trapped";
            this.chkTrapped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTrapped.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkTrapped, "Trapped: A Pokémon or Trainer that is Trapped cannot\r\nbe recalled. Ghost Type Pok" +
        "émon are immune to the\r\nTrapped Condition.");
            this.chkTrapped.UseVisualStyleBackColor = false;
            this.chkTrapped.CheckedChanged += new System.EventHandler(this.chkTrapped_CheckedChanged);
            this.chkTrapped.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTrapped_KeyDown);
            this.chkTrapped.MouseLeave += new System.EventHandler(this.chkTrapped_MouseLeave);
            this.chkTrapped.MouseHover += new System.EventHandler(this.chkTrapped_MouseHover);
            // 
            // chkStuck
            // 
            this.chkStuck.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStuck.AutoSize = true;
            this.chkStuck.BackColor = System.Drawing.Color.Transparent;
            this.chkStuck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkStuck.FlatAppearance.BorderSize = 0;
            this.chkStuck.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkStuck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkStuck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkStuck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkStuck.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStuck.ForeColor = System.Drawing.Color.White;
            this.chkStuck.Image = ((System.Drawing.Image)(resources.GetObject("chkStuck.Image")));
            this.chkStuck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkStuck.Location = new System.Drawing.Point(1025, 68);
            this.chkStuck.Margin = new System.Windows.Forms.Padding(0);
            this.chkStuck.Name = "chkStuck";
            this.chkStuck.Size = new System.Drawing.Size(57, 24);
            this.chkStuck.TabIndex = 184;
            this.chkStuck.Text = "Stuck";
            this.chkStuck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStuck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkStuck, resources.GetString("chkStuck.ToolTip"));
            this.chkStuck.UseVisualStyleBackColor = false;
            this.chkStuck.CheckedChanged += new System.EventHandler(this.chkStuck_CheckedChanged);
            this.chkStuck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkStuck_KeyDown);
            this.chkStuck.MouseLeave += new System.EventHandler(this.chkStuck_MouseLeave);
            this.chkStuck.MouseHover += new System.EventHandler(this.chkStuck_MouseHover);
            // 
            // chkFainted
            // 
            this.chkFainted.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFainted.AutoSize = true;
            this.chkFainted.BackColor = System.Drawing.Color.Transparent;
            this.chkFainted.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkFainted.FlatAppearance.BorderSize = 0;
            this.chkFainted.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkFainted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkFainted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkFainted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFainted.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFainted.ForeColor = System.Drawing.Color.White;
            this.chkFainted.Image = ((System.Drawing.Image)(resources.GetObject("chkFainted.Image")));
            this.chkFainted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkFainted.Location = new System.Drawing.Point(1084, 90);
            this.chkFainted.Margin = new System.Windows.Forms.Padding(0);
            this.chkFainted.Name = "chkFainted";
            this.chkFainted.Size = new System.Drawing.Size(67, 24);
            this.chkFainted.TabIndex = 187;
            this.chkFainted.Text = "Fainted";
            this.chkFainted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFainted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkFainted, resources.GetString("chkFainted.ToolTip"));
            this.chkFainted.UseVisualStyleBackColor = false;
            this.chkFainted.CheckedChanged += new System.EventHandler(this.chkFainted_CheckedChanged);
            this.chkFainted.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkFainted_KeyDown);
            this.chkFainted.MouseLeave += new System.EventHandler(this.chkFainted_MouseLeave);
            this.chkFainted.MouseHover += new System.EventHandler(this.chkFainted_MouseHover);
            // 
            // chkTripped
            // 
            this.chkTripped.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTripped.AutoSize = true;
            this.chkTripped.BackColor = System.Drawing.Color.Transparent;
            this.chkTripped.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkTripped.FlatAppearance.BorderSize = 0;
            this.chkTripped.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkTripped.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkTripped.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkTripped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTripped.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTripped.ForeColor = System.Drawing.Color.White;
            this.chkTripped.Image = ((System.Drawing.Image)(resources.GetObject("chkTripped.Image")));
            this.chkTripped.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkTripped.Location = new System.Drawing.Point(1025, 112);
            this.chkTripped.Margin = new System.Windows.Forms.Padding(0);
            this.chkTripped.Name = "chkTripped";
            this.chkTripped.Size = new System.Drawing.Size(68, 24);
            this.chkTripped.TabIndex = 188;
            this.chkTripped.Text = "Tripped";
            this.chkTripped.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTripped.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkTripped, "Tripped: A Pokémon or Trainer has been Tripped needs\r\nto spend a Shift Action get" +
        "ting up before they can take\r\nfurther actions.");
            this.chkTripped.UseVisualStyleBackColor = false;
            this.chkTripped.CheckedChanged += new System.EventHandler(this.chkTripped_CheckedChanged);
            this.chkTripped.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkTripped_KeyDown);
            this.chkTripped.MouseLeave += new System.EventHandler(this.chkTripped_MouseLeave);
            this.chkTripped.MouseHover += new System.EventHandler(this.chkTripped_MouseHover);
            // 
            // chkVulnerable
            // 
            this.chkVulnerable.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkVulnerable.AutoSize = true;
            this.chkVulnerable.BackColor = System.Drawing.Color.Transparent;
            this.chkVulnerable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkVulnerable.FlatAppearance.BorderSize = 0;
            this.chkVulnerable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkVulnerable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkVulnerable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkVulnerable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkVulnerable.Font = new System.Drawing.Font("Sitka Small", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVulnerable.ForeColor = System.Drawing.Color.White;
            this.chkVulnerable.Image = ((System.Drawing.Image)(resources.GetObject("chkVulnerable.Image")));
            this.chkVulnerable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkVulnerable.Location = new System.Drawing.Point(1084, 68);
            this.chkVulnerable.Margin = new System.Windows.Forms.Padding(0);
            this.chkVulnerable.Name = "chkVulnerable";
            this.chkVulnerable.Size = new System.Drawing.Size(81, 24);
            this.chkVulnerable.TabIndex = 189;
            this.chkVulnerable.Text = "Vulnerable";
            this.chkVulnerable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVulnerable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttInfo.SetToolTip(this.chkVulnerable, "Vulnerable: A Vulnerable Pokémon or Trainer cannot\r\napply Evasion of any sort aga" +
        "inst attacks.");
            this.chkVulnerable.UseVisualStyleBackColor = false;
            this.chkVulnerable.CheckedChanged += new System.EventHandler(this.chkVulnerable_CheckedChanged);
            this.chkVulnerable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkVulnerable_KeyDown);
            this.chkVulnerable.MouseLeave += new System.EventHandler(this.chkVulnerable_MouseLeave);
            this.chkVulnerable.MouseHover += new System.EventHandler(this.chkVulnerable_MouseHover);
            // 
            // lbSkills
            // 
            this.lbSkills.BackColor = System.Drawing.Color.Beige;
            this.lbSkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSkills.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSkills.FormattingEnabled = true;
            this.lbSkills.ItemHeight = 18;
            this.lbSkills.Location = new System.Drawing.Point(945, 353);
            this.lbSkills.Name = "lbSkills";
            this.lbSkills.Size = new System.Drawing.Size(238, 146);
            this.lbSkills.TabIndex = 190;
            this.lbSkills.MouseLeave += new System.EventHandler(this.lbSkills_MouseLeave);
            this.lbSkills.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbSkills_MouseMove);
            // 
            // lbAbilities
            // 
            this.lbAbilities.BackColor = System.Drawing.Color.Beige;
            this.lbAbilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAbilities.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAbilities.FormattingEnabled = true;
            this.lbAbilities.ItemHeight = 18;
            this.lbAbilities.Location = new System.Drawing.Point(945, 498);
            this.lbAbilities.Name = "lbAbilities";
            this.lbAbilities.Size = new System.Drawing.Size(238, 92);
            this.lbAbilities.TabIndex = 191;
            this.lbAbilities.MouseLeave += new System.EventHandler(this.lbAbilities_MouseLeave);
            this.lbAbilities.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbAbilities_MouseMove);
            // 
            // pkItem
            // 
            this.pkItem.BackColor = System.Drawing.Color.Transparent;
            this.pkItem.Location = new System.Drawing.Point(472, 60);
            this.pkItem.Name = "pkItem";
            this.pkItem.Size = new System.Drawing.Size(118, 117);
            this.pkItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pkItem.TabIndex = 59;
            this.pkItem.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.Location = new System.Drawing.Point(1221, 66);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.TabIndex = 192;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseUp);
            // 
            // btnGetLoot
            // 
            this.btnGetLoot.BackColor = System.Drawing.Color.Transparent;
            this.btnGetLoot.Location = new System.Drawing.Point(461, 275);
            this.btnGetLoot.Name = "btnGetLoot";
            this.btnGetLoot.Size = new System.Drawing.Size(130, 33);
            this.btnGetLoot.TabIndex = 195;
            this.btnGetLoot.TabStop = false;
            this.btnGetLoot.MouseEnter += new System.EventHandler(this.btnGetLoot_MouseEnter);
            this.btnGetLoot.MouseLeave += new System.EventHandler(this.btnGetLoot_MouseLeave);
            this.btnGetLoot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGetLoot_MouseUp);
            // 
            // btnDeletePoke
            // 
            this.btnDeletePoke.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePoke.Location = new System.Drawing.Point(335, 567);
            this.btnDeletePoke.Name = "btnDeletePoke";
            this.btnDeletePoke.Size = new System.Drawing.Size(156, 25);
            this.btnDeletePoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDeletePoke.TabIndex = 196;
            this.btnDeletePoke.TabStop = false;
            this.btnDeletePoke.MouseEnter += new System.EventHandler(this.btnDeletePoke_MouseEnter);
            this.btnDeletePoke.MouseLeave += new System.EventHandler(this.btnDeletePoke_MouseLeave);
            this.btnDeletePoke.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDeletePoke_MouseUp);
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.Transparent;
            this.btnGoTo.Location = new System.Drawing.Point(335, 603);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(82, 25);
            this.btnGoTo.TabIndex = 197;
            this.btnGoTo.TabStop = false;
            this.btnGoTo.MouseEnter += new System.EventHandler(this.btnGoTo_MouseEnter);
            this.btnGoTo.MouseLeave += new System.EventHandler(this.btnGoTo_MouseLeave);
            this.btnGoTo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGoTo_MouseUp);
            // 
            // nudGoTo
            // 
            this.nudGoTo.BackColor = System.Drawing.Color.Beige;
            this.nudGoTo.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGoTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nudGoTo.Location = new System.Drawing.Point(423, 603);
            this.nudGoTo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudGoTo.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.nudGoTo.Name = "nudGoTo";
            this.nudGoTo.Size = new System.Drawing.Size(53, 24);
            this.nudGoTo.TabIndex = 198;
            this.nudGoTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PokeImportDialog
            // 
            this.PokeImportDialog.FileName = "openFileDialog1";
            // 
            // PokeImportScan
            // 
            this.PokeImportScan.WorkerReportsProgress = true;
            this.PokeImportScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PokeImportScan_DoWork);
            this.PokeImportScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.PokeImportScan_ProgressChanged);
            this.PokeImportScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PokeImportScan_RunWorkCompleted);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Location = new System.Drawing.Point(508, 567);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(85, 25);
            this.btnImport.TabIndex = 199;
            this.btnImport.TabStop = false;
            this.btnImport.MouseEnter += new System.EventHandler(this.btnImport_MouseEnter);
            this.btnImport.MouseLeave += new System.EventHandler(this.btnImport_MouseLeave);
            this.btnImport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnImport_MouseUp);
            // 
            // PokeSaveJSON
            // 
            this.PokeSaveJSON.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PokeSaveJSON_DoWork);
            // 
            // btnRoll20Export
            // 
            this.btnRoll20Export.BackColor = System.Drawing.Color.Transparent;
            this.btnRoll20Export.Location = new System.Drawing.Point(473, 639);
            this.btnRoll20Export.Name = "btnRoll20Export";
            this.btnRoll20Export.Size = new System.Drawing.Size(120, 25);
            this.btnRoll20Export.TabIndex = 200;
            this.btnRoll20Export.TabStop = false;
            this.btnRoll20Export.MouseEnter += new System.EventHandler(this.btnRoll20Export_MouseEnter);
            this.btnRoll20Export.MouseLeave += new System.EventHandler(this.btnRoll20Export_MouseLeave);
            this.btnRoll20Export.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRoll20Export_MouseUp);
            // 
            // FormScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnRoll20Export);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.nudGoTo);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnDeletePoke);
            this.Controls.Add(this.btnGetLoot);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lbAbilities);
            this.Controls.Add(this.lbSkills);
            this.Controls.Add(this.chkVulnerable);
            this.Controls.Add(this.chkTripped);
            this.Controls.Add(this.chkAsleep);
            this.Controls.Add(this.chkFainted);
            this.Controls.Add(this.chkTrapped);
            this.Controls.Add(this.chkStuck);
            this.Controls.Add(this.chkSlowed);
            this.Controls.Add(this.chkSuppress);
            this.Controls.Add(this.chkFlinch);
            this.Controls.Add(this.chkConfused);
            this.Controls.Add(this.chkParalysis);
            this.Controls.Add(this.chkTotalBlind);
            this.Controls.Add(this.chkBlind);
            this.Controls.Add(this.chkInfatuation);
            this.Controls.Add(this.chkRage);
            this.Controls.Add(this.chkCursed);
            this.Controls.Add(this.chkPoisoned);
            this.Controls.Add(this.chkBadSleep);
            this.Controls.Add(this.chkFrozen);
            this.Controls.Add(this.chkBurned);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDealOneTick);
            this.Controls.Add(this.tbCaptureRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNature);
            this.Controls.Add(this.pkItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tbNature);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbMoves);
            this.Controls.Add(this.lbCapabilites);
            this.Controls.Add(this.nudSPDCS);
            this.Controls.Add(this.nudSPDEFCS);
            this.Controls.Add(this.nudSPATKCS);
            this.Controls.Add(this.nudDEFCS);
            this.Controls.Add(this.nudATKCS);
            this.Controls.Add(this.nudHPCS);
            this.Controls.Add(this.tbCurrentSPD);
            this.Controls.Add(this.tbLevelSPD);
            this.Controls.Add(this.tbCurrentSPDEF);
            this.Controls.Add(this.tbLevelSPDEF);
            this.Controls.Add(this.tbCurrentSPATK);
            this.Controls.Add(this.tbLevelSPATK);
            this.Controls.Add(this.tbCurrentDEF);
            this.Controls.Add(this.tbLevelDEF);
            this.Controls.Add(this.tbCurrentATK);
            this.Controls.Add(this.tbLevelATK);
            this.Controls.Add(this.tbCurrentHP);
            this.Controls.Add(this.tbLevelHP);
            this.Controls.Add(this.tbCurrentHealth);
            this.Controls.Add(this.tbBaseSPD);
            this.Controls.Add(this.tbBaseSPDEF);
            this.Controls.Add(this.tbBaseSPATK);
            this.Controls.Add(this.tbBaseDEF);
            this.Controls.Add(this.tbBaseATK);
            this.Controls.Add(this.tbBaseHP);
            this.Controls.Add(this.tbMaxHealth);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.chkForceShiny);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.btnCry);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbPokeCount);
            this.Controls.Add(this.lbPokemon);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.prbGenerationProgress);
            this.Controls.Add(this.btnDealDamage);
            this.Controls.Add(this.pkDamage);
            this.Controls.Add(this.btnPokeRight);
            this.Controls.Add(this.btnPokeLeft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbStageAllowed);
            this.Controls.Add(this.chkCanBeLegend);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.pkHeld);
            this.Controls.Add(this.chkCanBeShiny);
            this.Controls.Add(this.chkHasItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudLevelMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHabitat);
            this.Controls.Add(this.nudLevelMin);
            this.Controls.Add(this.btnScanPokemon);
            this.Controls.Add(this.rtbGasp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScan_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScanPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPokeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDealDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudATKCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDEFCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPATKCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPDEFCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSPDCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDealOneTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGoTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRoll20Export)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkHasItem;
        private System.Windows.Forms.CheckBox chkCanBeShiny;
        private System.Windows.Forms.Label pkHeld;
        private System.Windows.Forms.CheckBox chkCanBeLegend;
        private System.Windows.Forms.ComboBox cbStageAllowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnPokeRight;
        private System.Windows.Forms.PictureBox btnPokeLeft;
        private System.Windows.Forms.NumericUpDown pkDamage;
        private System.Windows.Forms.PictureBox btnDealDamage;
        private System.ComponentModel.BackgroundWorker PokeGenerator;
        private System.Windows.Forms.ProgressBar prbGenerationProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.RichTextBox rtbGasp;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox btnScan;
        private System.Windows.Forms.ListBox lbPokemon;
        private System.Windows.Forms.RichTextBox tbPokeCount;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnOptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnCry;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.ComponentModel.BackgroundWorker PokeSaveScan;
        private System.Windows.Forms.SaveFileDialog PokeSaveDialog;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.CheckBox chkForceShiny;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.TextBox tbMaxHealth;
        private System.Windows.Forms.TextBox tbBaseHP;
        private System.Windows.Forms.TextBox tbBaseATK;
        private System.Windows.Forms.TextBox tbBaseDEF;
        private System.Windows.Forms.TextBox tbBaseSPATK;
        private System.Windows.Forms.TextBox tbBaseSPDEF;
        private System.Windows.Forms.TextBox tbBaseSPD;
        private System.Windows.Forms.TextBox tbCurrentHealth;
        private System.Windows.Forms.TextBox tbCurrentHP;
        private System.Windows.Forms.TextBox tbLevelHP;
        private System.Windows.Forms.TextBox tbCurrentATK;
        private System.Windows.Forms.TextBox tbLevelATK;
        private System.Windows.Forms.TextBox tbCurrentDEF;
        private System.Windows.Forms.TextBox tbLevelDEF;
        private System.Windows.Forms.TextBox tbCurrentSPATK;
        private System.Windows.Forms.TextBox tbLevelSPATK;
        private System.Windows.Forms.TextBox tbCurrentSPDEF;
        private System.Windows.Forms.TextBox tbLevelSPDEF;
        private System.Windows.Forms.TextBox tbCurrentSPD;
        private System.Windows.Forms.TextBox tbLevelSPD;
        private System.Windows.Forms.NumericUpDown nudHPCS;
        private System.Windows.Forms.NumericUpDown nudATKCS;
        private System.Windows.Forms.NumericUpDown nudDEFCS;
        private System.Windows.Forms.NumericUpDown nudSPATKCS;
        private System.Windows.Forms.NumericUpDown nudSPDEFCS;
        private System.Windows.Forms.NumericUpDown nudSPDCS;
        private System.Windows.Forms.ListBox lbCapabilites;
        private System.Windows.Forms.ListBox lbMoves;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbNature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNature;
        private System.Windows.Forms.TextBox tbCaptureRate;
        private System.Windows.Forms.PictureBox btnDealOneTick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkBurned;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.CheckBox chkFrozen;
        private System.Windows.Forms.CheckBox chkBadSleep;
        private System.Windows.Forms.CheckBox chkPoisoned;
        private System.Windows.Forms.CheckBox chkCursed;
        private System.Windows.Forms.CheckBox chkRage;
        private System.Windows.Forms.CheckBox chkInfatuation;
        private System.Windows.Forms.CheckBox chkAsleep;
        private System.Windows.Forms.CheckBox chkBlind;
        private System.Windows.Forms.CheckBox chkTotalBlind;
        private System.Windows.Forms.CheckBox chkSlowed;
        private System.Windows.Forms.CheckBox chkSuppress;
        private System.Windows.Forms.CheckBox chkFlinch;
        private System.Windows.Forms.CheckBox chkConfused;
        private System.Windows.Forms.CheckBox chkParalysis;
        private System.Windows.Forms.CheckBox chkTrapped;
        private System.Windows.Forms.CheckBox chkStuck;
        private System.Windows.Forms.CheckBox chkFainted;
        private System.Windows.Forms.CheckBox chkTripped;
        private System.Windows.Forms.CheckBox chkVulnerable;
        private System.Windows.Forms.ListBox lbSkills;
        private System.Windows.Forms.ListBox lbAbilities;
        private System.Windows.Forms.PictureBox pkItem;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnGetLoot;
        private System.Windows.Forms.PictureBox btnDeletePoke;
        private System.Windows.Forms.PictureBox btnGoTo;
        private System.Windows.Forms.NumericUpDown nudGoTo;
        private System.Windows.Forms.OpenFileDialog PokeImportDialog;
        private System.ComponentModel.BackgroundWorker PokeImportScan;
        private System.Windows.Forms.PictureBox btnImport;
        private System.ComponentModel.BackgroundWorker PokeSaveJSON;
        private System.Windows.Forms.PictureBox btnRoll20Export;
    }
}