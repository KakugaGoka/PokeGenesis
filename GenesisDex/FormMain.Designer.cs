namespace GenesisDex
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lbPokemon = new System.Windows.Forms.ListBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbPageCount = new System.Windows.Forms.RichTextBox();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.PictureBox();
            this.pbMega = new System.Windows.Forms.PictureBox();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.pbY = new System.Windows.Forms.PictureBox();
            this.pbX = new System.Windows.Forms.PictureBox();
            this.pbPokeRight = new System.Windows.Forms.PictureBox();
            this.pbPokeLeft = new System.Windows.Forms.PictureBox();
            this.infoBack = new System.Windows.Forms.PictureBox();
            this.infoForward = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.rtbEntry = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
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
            this.lbPokemon.TabIndex = 1;
            this.lbPokemon.SelectedIndexChanged += new System.EventHandler(this.lbPokemon_SelectedIndexChanged);
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
            this.rtbInfo.TabIndex = 20;
            this.rtbInfo.TabStop = false;
            this.rtbInfo.Text = "";
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.Location = new System.Drawing.Point(67, 644);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(324, 17);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Tag = "";
            this.tbSearch.Text = "Search";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            this.tbPageCount.TabIndex = 74;
            this.tbPageCount.TabStop = false;
            this.tbPageCount.Text = "";
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(131, 68);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(205, 190);
            this.pbPokemon.TabIndex = 80;
            this.pbPokemon.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.Location = new System.Drawing.Point(1106, 613);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(82, 25);
            this.btnOptions.TabIndex = 79;
            this.btnOptions.TabStop = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnOptions_MouseLeave);
            this.btnOptions.MouseHover += new System.EventHandler(this.btnOptions_MouseHover);
            // 
            // pbMega
            // 
            this.pbMega.BackColor = System.Drawing.Color.Transparent;
            this.pbMega.Location = new System.Drawing.Point(169, 275);
            this.pbMega.Name = "pbMega";
            this.pbMega.Size = new System.Drawing.Size(129, 33);
            this.pbMega.TabIndex = 17;
            this.pbMega.TabStop = false;
            this.pbMega.Click += new System.EventHandler(this.pbMega_Click);
            this.pbMega.MouseLeave += new System.EventHandler(this.pbMega_MouseLeave);
            this.pbMega.MouseHover += new System.EventHandler(this.pbMega_MouseHover);
            // 
            // pbScan
            // 
            this.pbScan.BackColor = System.Drawing.Color.Transparent;
            this.pbScan.Location = new System.Drawing.Point(425, 275);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(157, 33);
            this.pbScan.TabIndex = 32;
            this.pbScan.TabStop = false;
            this.pbScan.Click += new System.EventHandler(this.pbScan_Click);
            this.pbScan.MouseLeave += new System.EventHandler(this.pbScan_MouseLeave);
            // 
            // pbY
            // 
            this.pbY.BackColor = System.Drawing.Color.Transparent;
            this.pbY.Location = new System.Drawing.Point(342, 68);
            this.pbY.Name = "pbY";
            this.pbY.Size = new System.Drawing.Size(54, 50);
            this.pbY.TabIndex = 28;
            this.pbY.TabStop = false;
            this.pbY.Click += new System.EventHandler(this.pbY_Click);
            // 
            // pbX
            // 
            this.pbX.BackColor = System.Drawing.Color.Transparent;
            this.pbX.Location = new System.Drawing.Point(71, 68);
            this.pbX.Name = "pbX";
            this.pbX.Size = new System.Drawing.Size(54, 50);
            this.pbX.TabIndex = 27;
            this.pbX.TabStop = false;
            this.pbX.Click += new System.EventHandler(this.pbX_Click);
            // 
            // pbPokeRight
            // 
            this.pbPokeRight.BackColor = System.Drawing.Color.Transparent;
            this.pbPokeRight.Image = ((System.Drawing.Image)(resources.GetObject("pbPokeRight.Image")));
            this.pbPokeRight.Location = new System.Drawing.Point(304, 275);
            this.pbPokeRight.Name = "pbPokeRight";
            this.pbPokeRight.Size = new System.Drawing.Size(68, 33);
            this.pbPokeRight.TabIndex = 26;
            this.pbPokeRight.TabStop = false;
            this.pbPokeRight.Click += new System.EventHandler(this.pbPokeRight_Click);
            // 
            // pbPokeLeft
            // 
            this.pbPokeLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbPokeLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbPokeLeft.Image")));
            this.pbPokeLeft.Location = new System.Drawing.Point(95, 275);
            this.pbPokeLeft.Name = "pbPokeLeft";
            this.pbPokeLeft.Size = new System.Drawing.Size(68, 33);
            this.pbPokeLeft.TabIndex = 25;
            this.pbPokeLeft.TabStop = false;
            this.pbPokeLeft.Click += new System.EventHandler(this.pbPokeLeft_Click);
            // 
            // infoBack
            // 
            this.infoBack.BackColor = System.Drawing.Color.Transparent;
            this.infoBack.Location = new System.Drawing.Point(882, 604);
            this.infoBack.Name = "infoBack";
            this.infoBack.Size = new System.Drawing.Size(34, 34);
            this.infoBack.TabIndex = 24;
            this.infoBack.TabStop = false;
            this.infoBack.Click += new System.EventHandler(this.infoBack_Click);
            this.infoBack.MouseLeave += new System.EventHandler(this.infoBack_MouseLeave);
            this.infoBack.MouseHover += new System.EventHandler(this.infoBack_MouseHover);
            // 
            // infoForward
            // 
            this.infoForward.BackColor = System.Drawing.Color.Transparent;
            this.infoForward.Location = new System.Drawing.Point(959, 604);
            this.infoForward.Name = "infoForward";
            this.infoForward.Size = new System.Drawing.Size(34, 34);
            this.infoForward.TabIndex = 23;
            this.infoForward.TabStop = false;
            this.infoForward.Click += new System.EventHandler(this.infoForward_Click);
            this.infoForward.MouseLeave += new System.EventHandler(this.infoForward_MouseLeave);
            this.infoForward.MouseHover += new System.EventHandler(this.infoForward_MouseHover);
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExit.BackgroundImage")));
            this.pbExit.Location = new System.Drawing.Point(1220, 46);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(15, 15);
            this.pbExit.TabIndex = 15;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // rtbEntry
            // 
            this.rtbEntry.AcceptsTab = true;
            this.rtbEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbEntry.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEntry.ForeColor = System.Drawing.Color.Black;
            this.rtbEntry.Location = new System.Drawing.Point(420, 62);
            this.rtbEntry.Name = "rtbEntry";
            this.rtbEntry.ReadOnly = true;
            this.rtbEntry.Size = new System.Drawing.Size(168, 204);
            this.rtbEntry.TabIndex = 81;
            this.rtbEntry.TabStop = false;
            this.rtbEntry.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.rtbEntry);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.pbMega);
            this.Controls.Add(this.tbPageCount);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.pbY);
            this.Controls.Add(this.pbX);
            this.Controls.Add(this.pbPokeRight);
            this.Controls.Add(this.pbPokeLeft);
            this.Controls.Add(this.infoBack);
            this.Controls.Add(this.infoForward);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.lbPokemon);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeGenesis";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.ListBox lbPokemon;
        private System.Windows.Forms.PictureBox pbMega;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.PictureBox infoForward;
        private System.Windows.Forms.PictureBox infoBack;
        private System.Windows.Forms.PictureBox pbPokeLeft;
        private System.Windows.Forms.PictureBox pbPokeRight;
        private System.Windows.Forms.PictureBox pbX;
        private System.Windows.Forms.PictureBox pbY;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.RichTextBox tbPageCount;
        private System.Windows.Forms.PictureBox btnOptions;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.RichTextBox rtbEntry;
    }
}

