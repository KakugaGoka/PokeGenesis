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
            this.pbOverlay = new System.Windows.Forms.PictureBox();
            this.infoBack = new System.Windows.Forms.PictureBox();
            this.infoForward = new System.Windows.Forms.PictureBox();
            this.rtbInfo1 = new System.Windows.Forms.RichTextBox();
            this.lbPokemon = new System.Windows.Forms.ListBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.pbScan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOverlay
            // 
            this.pbOverlay.BackColor = System.Drawing.Color.Transparent;
            this.pbOverlay.BackgroundImage = global::GenesisDex.Properties.Resources.MainMenuOverlay;
            this.pbOverlay.Location = new System.Drawing.Point(15, 139);
            this.pbOverlay.Name = "pbOverlay";
            this.pbOverlay.Size = new System.Drawing.Size(377, 23);
            this.pbOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOverlay.TabIndex = 43;
            this.pbOverlay.TabStop = false;
            // 
            // infoBack
            // 
            this.infoBack.BackColor = System.Drawing.Color.Transparent;
            this.infoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoBack.BackgroundImage")));
            this.infoBack.Location = new System.Drawing.Point(468, 551);
            this.infoBack.Name = "infoBack";
            this.infoBack.Size = new System.Drawing.Size(38, 35);
            this.infoBack.TabIndex = 37;
            this.infoBack.TabStop = false;
            // 
            // infoForward
            // 
            this.infoForward.BackColor = System.Drawing.Color.Transparent;
            this.infoForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoForward.BackgroundImage")));
            this.infoForward.Location = new System.Drawing.Point(729, 551);
            this.infoForward.Name = "infoForward";
            this.infoForward.Size = new System.Drawing.Size(33, 35);
            this.infoForward.TabIndex = 36;
            this.infoForward.TabStop = false;
            // 
            // rtbInfo1
            // 
            this.rtbInfo1.AcceptsTab = true;
            this.rtbInfo1.BackColor = System.Drawing.Color.Black;
            this.rtbInfo1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbInfo1.Location = new System.Drawing.Point(468, 158);
            this.rtbInfo1.Name = "rtbInfo1";
            this.rtbInfo1.ReadOnly = true;
            this.rtbInfo1.Size = new System.Drawing.Size(294, 387);
            this.rtbInfo1.TabIndex = 35;
            this.rtbInfo1.Text = "";
            // 
            // lbPokemon
            // 
            this.lbPokemon.BackColor = System.Drawing.Color.Black;
            this.lbPokemon.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPokemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPokemon.FormattingEnabled = true;
            this.lbPokemon.ItemHeight = 18;
            this.lbPokemon.Location = new System.Drawing.Point(23, 375);
            this.lbPokemon.Name = "lbPokemon";
            this.lbPokemon.Size = new System.Drawing.Size(360, 166);
            this.lbPokemon.TabIndex = 33;
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
            this.pbPokemon.Location = new System.Drawing.Point(114, 165);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(175, 140);
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
            // FormScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GenesisDex.Properties.Resources.MainMenu;
            this.ClientSize = new System.Drawing.Size(822, 616);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.pbOverlay);
            this.Controls.Add(this.infoBack);
            this.Controls.Add(this.infoForward);
            this.Controls.Add(this.rtbInfo1);
            this.Controls.Add(this.lbPokemon);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbPokemon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOverlay;
        private System.Windows.Forms.PictureBox infoBack;
        private System.Windows.Forms.PictureBox infoForward;
        private System.Windows.Forms.RichTextBox rtbInfo1;
        private System.Windows.Forms.ListBox lbPokemon;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.PictureBox pbScan;
    }
}