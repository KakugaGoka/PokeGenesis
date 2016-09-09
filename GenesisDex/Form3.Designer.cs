﻿namespace GenesisDex
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
            this.pbOverlay = new System.Windows.Forms.PictureBox();
            this.infoBack = new System.Windows.Forms.PictureBox();
            this.infoForward = new System.Windows.Forms.PictureBox();
            this.rtbInfo1 = new System.Windows.Forms.RichTextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.pbScanPokemon = new System.Windows.Forms.PictureBox();
            this.pkLevelMin = new System.Windows.Forms.NumericUpDown();
            this.pkHabitat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pkType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pkLevelMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pkHasItem = new System.Windows.Forms.CheckBox();
            this.pkCanBeShiny = new System.Windows.Forms.CheckBox();
            this.pkItem = new System.Windows.Forms.PictureBox();
            this.pkHeld = new System.Windows.Forms.Label();
            this.pkGasp = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pkPokemon = new System.Windows.Forms.ComboBox();
            this.pkCanBeLegend = new System.Windows.Forms.CheckBox();
            this.pkStageAllowed = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pkAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.pbPokeRight = new System.Windows.Forms.PictureBox();
            this.pbPokeLeft = new System.Windows.Forms.PictureBox();
            this.tbPokeCount = new System.Windows.Forms.RichTextBox();
            this.tbPageCount = new System.Windows.Forms.RichTextBox();
            this.pbGotoPage = new System.Windows.Forms.PictureBox();
            this.pkGoto = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkLevelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkLevelMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGotoPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkGoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // infoBack
            // 
            this.infoBack.BackColor = System.Drawing.Color.Transparent;
            this.infoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoBack.BackgroundImage")));
            this.infoBack.Location = new System.Drawing.Point(156, 550);
            this.infoBack.Name = "infoBack";
            this.infoBack.Size = new System.Drawing.Size(38, 35);
            this.infoBack.TabIndex = 37;
            this.infoBack.TabStop = false;
            this.infoBack.Click += new System.EventHandler(this.infoBack_Click);
            // 
            // infoForward
            // 
            this.infoForward.BackColor = System.Drawing.Color.Transparent;
            this.infoForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoForward.BackgroundImage")));
            this.infoForward.Location = new System.Drawing.Point(231, 550);
            this.infoForward.Name = "infoForward";
            this.infoForward.Size = new System.Drawing.Size(33, 35);
            this.infoForward.TabIndex = 36;
            this.infoForward.TabStop = false;
            this.infoForward.Click += new System.EventHandler(this.infoForward_Click);
            // 
            // rtbInfo1
            // 
            this.rtbInfo1.AcceptsTab = true;
            this.rtbInfo1.BackColor = System.Drawing.Color.Black;
            this.rtbInfo1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbInfo1.Location = new System.Drawing.Point(22, 375);
            this.rtbInfo1.Name = "rtbInfo1";
            this.rtbInfo1.ReadOnly = true;
            this.rtbInfo1.Size = new System.Drawing.Size(366, 169);
            this.rtbInfo1.TabIndex = 35;
            this.rtbInfo1.Text = "";
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
            // pbScan
            // 
            this.pbScan.BackColor = System.Drawing.Color.Transparent;
            this.pbScan.Image = global::GenesisDex.Properties.Resources.Pokedex;
            this.pbScan.Location = new System.Drawing.Point(22, 23);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(86, 86);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbScan.TabIndex = 44;
            this.pbScan.TabStop = false;
            this.pbScan.Click += new System.EventHandler(this.pbScan_Click_1);
            // 
            // pbScanPokemon
            // 
            this.pbScanPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbScanPokemon.Image = global::GenesisDex.Properties.Resources.ScanPokemon;
            this.pbScanPokemon.Location = new System.Drawing.Point(611, 531);
            this.pbScanPokemon.Name = "pbScanPokemon";
            this.pbScanPokemon.Size = new System.Drawing.Size(157, 33);
            this.pbScanPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbScanPokemon.TabIndex = 45;
            this.pbScanPokemon.TabStop = false;
            this.pbScanPokemon.Click += new System.EventHandler(this.pbScanPokemon_Click);
            this.pbScanPokemon.MouseLeave += new System.EventHandler(this.pbScanPokemon_MouseLeave);
            this.pbScanPokemon.MouseHover += new System.EventHandler(this.pbScanPokemon_MouseHover);
            // 
            // pkLevelMin
            // 
            this.pkLevelMin.BackColor = System.Drawing.Color.Black;
            this.pkLevelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkLevelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkLevelMin.Location = new System.Drawing.Point(598, 445);
            this.pkLevelMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.pkLevelMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkLevelMin.Name = "pkLevelMin";
            this.pkLevelMin.Size = new System.Drawing.Size(86, 62);
            this.pkLevelMin.TabIndex = 46;
            this.pkLevelMin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.pkLevelMin.ValueChanged += new System.EventHandler(this.pkLevelMin_ValueChanged);
            // 
            // pkHabitat
            // 
            this.pkHabitat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pkHabitat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pkHabitat.BackColor = System.Drawing.Color.Black;
            this.pkHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkHabitat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkHabitat.FormattingEnabled = true;
            this.pkHabitat.Location = new System.Drawing.Point(474, 323);
            this.pkHabitat.Name = "pkHabitat";
            this.pkHabitat.Size = new System.Drawing.Size(143, 33);
            this.pkHabitat.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(667, 415);
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
            this.label2.Location = new System.Drawing.Point(474, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Habitat";
            // 
            // pkType
            // 
            this.pkType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pkType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pkType.BackColor = System.Drawing.Color.Black;
            this.pkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkType.FormattingEnabled = true;
            this.pkType.Location = new System.Drawing.Point(474, 382);
            this.pkType.Name = "pkType";
            this.pkType.Size = new System.Drawing.Size(143, 33);
            this.pkType.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(474, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Type";
            // 
            // pkLevelMax
            // 
            this.pkLevelMax.BackColor = System.Drawing.Color.Black;
            this.pkLevelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkLevelMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkLevelMax.Location = new System.Drawing.Point(690, 445);
            this.pkLevelMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.pkLevelMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkLevelMax.Name = "pkLevelMax";
            this.pkLevelMax.Size = new System.Drawing.Size(86, 62);
            this.pkLevelMax.TabIndex = 52;
            this.pkLevelMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.pkLevelMax.ValueChanged += new System.EventHandler(this.pkLevelMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(747, 427);
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
            this.label5.Location = new System.Drawing.Point(598, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Min";
            // 
            // pkHasItem
            // 
            this.pkHasItem.AutoSize = true;
            this.pkHasItem.BackColor = System.Drawing.Color.Silver;
            this.pkHasItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pkHasItem.FlatAppearance.BorderSize = 5;
            this.pkHasItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkHasItem.Location = new System.Drawing.Point(641, 231);
            this.pkHasItem.Name = "pkHasItem";
            this.pkHasItem.Size = new System.Drawing.Size(125, 20);
            this.pkHasItem.TabIndex = 55;
            this.pkHasItem.Text = "Generate Items?";
            this.pkHasItem.UseVisualStyleBackColor = false;
            // 
            // pkCanBeShiny
            // 
            this.pkCanBeShiny.AutoSize = true;
            this.pkCanBeShiny.BackColor = System.Drawing.Color.Silver;
            this.pkCanBeShiny.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pkCanBeShiny.FlatAppearance.BorderSize = 5;
            this.pkCanBeShiny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkCanBeShiny.Location = new System.Drawing.Point(641, 195);
            this.pkCanBeShiny.Name = "pkCanBeShiny";
            this.pkCanBeShiny.Size = new System.Drawing.Size(126, 20);
            this.pkCanBeShiny.TabIndex = 57;
            this.pkCanBeShiny.Text = "Generate Shiny?";
            this.pkCanBeShiny.UseVisualStyleBackColor = false;
            // 
            // pkItem
            // 
            this.pkItem.BackColor = System.Drawing.Color.Black;
            this.pkItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkItem.Location = new System.Drawing.Point(474, 427);
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
            this.pkHeld.Location = new System.Drawing.Point(471, 138);
            this.pkHeld.Name = "pkHeld";
            this.pkHeld.Size = new System.Drawing.Size(0, 13);
            this.pkHeld.TabIndex = 58;
            // 
            // pkGasp
            // 
            this.pkGasp.AcceptsTab = true;
            this.pkGasp.BackColor = System.Drawing.Color.Black;
            this.pkGasp.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkGasp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkGasp.Location = new System.Drawing.Point(633, 264);
            this.pkGasp.Name = "pkGasp";
            this.pkGasp.ReadOnly = true;
            this.pkGasp.Size = new System.Drawing.Size(143, 98);
            this.pkGasp.TabIndex = 61;
            this.pkGasp.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(474, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Pokemon";
            // 
            // pkPokemon
            // 
            this.pkPokemon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pkPokemon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pkPokemon.BackColor = System.Drawing.Color.Black;
            this.pkPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkPokemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkPokemon.FormattingEnabled = true;
            this.pkPokemon.Location = new System.Drawing.Point(474, 205);
            this.pkPokemon.Name = "pkPokemon";
            this.pkPokemon.Size = new System.Drawing.Size(143, 33);
            this.pkPokemon.TabIndex = 62;
            this.pkPokemon.TextChanged += new System.EventHandler(this.pkPokemon_TextChanged);
            // 
            // pkCanBeLegend
            // 
            this.pkCanBeLegend.AutoSize = true;
            this.pkCanBeLegend.BackColor = System.Drawing.Color.Silver;
            this.pkCanBeLegend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pkCanBeLegend.FlatAppearance.BorderSize = 5;
            this.pkCanBeLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkCanBeLegend.Location = new System.Drawing.Point(611, 160);
            this.pkCanBeLegend.Name = "pkCanBeLegend";
            this.pkCanBeLegend.Size = new System.Drawing.Size(156, 20);
            this.pkCanBeLegend.TabIndex = 65;
            this.pkCanBeLegend.Text = "Include Legendaries?";
            this.pkCanBeLegend.UseVisualStyleBackColor = false;
            // 
            // pkStageAllowed
            // 
            this.pkStageAllowed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pkStageAllowed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pkStageAllowed.BackColor = System.Drawing.Color.Black;
            this.pkStageAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkStageAllowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkStageAllowed.FormattingEnabled = true;
            this.pkStageAllowed.Location = new System.Drawing.Point(474, 264);
            this.pkStageAllowed.Name = "pkStageAllowed";
            this.pkStageAllowed.Size = new System.Drawing.Size(143, 33);
            this.pkStageAllowed.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(474, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 67;
            this.label7.Text = "Stage";
            // 
            // pkAmount
            // 
            this.pkAmount.BackColor = System.Drawing.Color.Black;
            this.pkAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkAmount.Location = new System.Drawing.Point(474, 118);
            this.pkAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkAmount.Name = "pkAmount";
            this.pkAmount.Size = new System.Drawing.Size(95, 62);
            this.pkAmount.TabIndex = 68;
            this.pkAmount.Value = new decimal(new int[] {
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
            this.label8.Location = new System.Drawing.Point(474, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Amount";
            // 
            // pbPokeRight
            // 
            this.pbPokeRight.BackColor = System.Drawing.Color.Transparent;
            this.pbPokeRight.Location = new System.Drawing.Point(296, 254);
            this.pbPokeRight.Name = "pbPokeRight";
            this.pbPokeRight.Size = new System.Drawing.Size(54, 50);
            this.pbPokeRight.TabIndex = 71;
            this.pbPokeRight.TabStop = false;
            this.pbPokeRight.Click += new System.EventHandler(this.pbPokeRight_Click);
            // 
            // pbPokeLeft
            // 
            this.pbPokeLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbPokeLeft.Location = new System.Drawing.Point(55, 254);
            this.pbPokeLeft.Name = "pbPokeLeft";
            this.pbPokeLeft.Size = new System.Drawing.Size(54, 50);
            this.pbPokeLeft.TabIndex = 70;
            this.pbPokeLeft.TabStop = false;
            this.pbPokeLeft.Click += new System.EventHandler(this.pbPokeLeft_Click);
            // 
            // tbPokeCount
            // 
            this.tbPokeCount.AcceptsTab = true;
            this.tbPokeCount.BackColor = System.Drawing.Color.Black;
            this.tbPokeCount.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPokeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPokeCount.Location = new System.Drawing.Point(196, 323);
            this.tbPokeCount.Name = "tbPokeCount";
            this.tbPokeCount.ReadOnly = true;
            this.tbPokeCount.Size = new System.Drawing.Size(68, 25);
            this.tbPokeCount.TabIndex = 72;
            this.tbPokeCount.Text = "";
            // 
            // tbPageCount
            // 
            this.tbPageCount.AcceptsTab = true;
            this.tbPageCount.BackColor = System.Drawing.Color.Black;
            this.tbPageCount.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPageCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbPageCount.Location = new System.Drawing.Point(197, 550);
            this.tbPageCount.Name = "tbPageCount";
            this.tbPageCount.ReadOnly = true;
            this.tbPageCount.Size = new System.Drawing.Size(28, 25);
            this.tbPageCount.TabIndex = 73;
            this.tbPageCount.Text = "";
            // 
            // pbGotoPage
            // 
            this.pbGotoPage.BackColor = System.Drawing.Color.Transparent;
            this.pbGotoPage.Image = global::GenesisDex.Properties.Resources.GotoPage;
            this.pbGotoPage.Location = new System.Drawing.Point(262, 133);
            this.pbGotoPage.Name = "pbGotoPage";
            this.pbGotoPage.Size = new System.Drawing.Size(126, 26);
            this.pbGotoPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGotoPage.TabIndex = 75;
            this.pbGotoPage.TabStop = false;
            this.pbGotoPage.Click += new System.EventHandler(this.pbGotoPage_Click);
            this.pbGotoPage.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pbGotoPage.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pkGoto
            // 
            this.pkGoto.BackColor = System.Drawing.Color.Black;
            this.pkGoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkGoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pkGoto.Location = new System.Drawing.Point(283, 65);
            this.pkGoto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkGoto.Name = "pkGoto";
            this.pkGoto.Size = new System.Drawing.Size(95, 62);
            this.pkGoto.TabIndex = 76;
            this.pkGoto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pkGoto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkGoto_KeyDown);
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
            // FormScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GenesisDex.Properties.Resources.MainMenu;
            this.ClientSize = new System.Drawing.Size(822, 616);
            this.Controls.Add(this.tbPokeCount);
            this.Controls.Add(this.pkGoto);
            this.Controls.Add(this.pbGotoPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPageCount);
            this.Controls.Add(this.pbPokeRight);
            this.Controls.Add(this.pbPokeLeft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pkAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pkStageAllowed);
            this.Controls.Add(this.pbOverlay);
            this.Controls.Add(this.pkCanBeLegend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pkPokemon);
            this.Controls.Add(this.pkGasp);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.pkItem);
            this.Controls.Add(this.pkHeld);
            this.Controls.Add(this.pkCanBeShiny);
            this.Controls.Add(this.pkHasItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pkLevelMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pkType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pkHabitat);
            this.Controls.Add(this.pkLevelMin);
            this.Controls.Add(this.pbScanPokemon);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.infoBack);
            this.Controls.Add(this.infoForward);
            this.Controls.Add(this.rtbInfo1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkLevelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkLevelMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGotoPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkGoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOverlay;
        private System.Windows.Forms.PictureBox infoBack;
        private System.Windows.Forms.PictureBox infoForward;
        private System.Windows.Forms.RichTextBox rtbInfo1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.PictureBox pbScanPokemon;
        private System.Windows.Forms.NumericUpDown pkLevelMin;
        private System.Windows.Forms.ComboBox pkHabitat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pkType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pkLevelMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox pkHasItem;
        private System.Windows.Forms.CheckBox pkCanBeShiny;
        private System.Windows.Forms.PictureBox pkItem;
        private System.Windows.Forms.Label pkHeld;
        private System.Windows.Forms.RichTextBox pkGasp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pkPokemon;
        private System.Windows.Forms.CheckBox pkCanBeLegend;
        private System.Windows.Forms.ComboBox pkStageAllowed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown pkAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbPokeRight;
        private System.Windows.Forms.PictureBox pbPokeLeft;
        private System.Windows.Forms.RichTextBox tbPokeCount;
        private System.Windows.Forms.RichTextBox tbPageCount;
        private System.Windows.Forms.PictureBox pbGotoPage;
        private System.Windows.Forms.NumericUpDown pkGoto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}