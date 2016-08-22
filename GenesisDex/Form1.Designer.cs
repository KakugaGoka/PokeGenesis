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
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lbPokemon = new System.Windows.Forms.ListBox();
            this.pbMega = new System.Windows.Forms.PictureBox();
            this.rtbInfo1 = new System.Windows.Forms.RichTextBox();
            this.infoForward = new System.Windows.Forms.PictureBox();
            this.infoBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(142, 182);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(122, 122);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPokemon.TabIndex = 0;
            this.pbPokemon.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExit.BackgroundImage")));
            this.pbExit.Location = new System.Drawing.Point(12, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(24, 23);
            this.pbExit.TabIndex = 15;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            this.pbExit.MouseHover += new System.EventHandler(this.pbExit_MouseHover);
            // 
            // lbPokemon
            // 
            this.lbPokemon.BackColor = System.Drawing.Color.Black;
            this.lbPokemon.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPokemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPokemon.FormattingEnabled = true;
            this.lbPokemon.ItemHeight = 18;
            this.lbPokemon.Location = new System.Drawing.Point(23, 382);
            this.lbPokemon.Name = "lbPokemon";
            this.lbPokemon.Size = new System.Drawing.Size(360, 184);
            this.lbPokemon.TabIndex = 16;
            this.lbPokemon.SelectedIndexChanged += new System.EventHandler(this.lbPokemon_SelectedIndexChanged);
            // 
            // pbMega
            // 
            this.pbMega.BackColor = System.Drawing.Color.Transparent;
            this.pbMega.Location = new System.Drawing.Point(71, 323);
            this.pbMega.Name = "pbMega";
            this.pbMega.Size = new System.Drawing.Size(157, 33);
            this.pbMega.TabIndex = 17;
            this.pbMega.TabStop = false;
            this.pbMega.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMega_MouseClick);
            this.pbMega.MouseLeave += new System.EventHandler(this.pbMega_MouseLeave);
            this.pbMega.MouseHover += new System.EventHandler(this.pbMega_MouseHover);
            // 
            // rtbInfo1
            // 
            this.rtbInfo1.AcceptsTab = true;
            this.rtbInfo1.BackColor = System.Drawing.Color.Black;
            this.rtbInfo1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbInfo1.Location = new System.Drawing.Point(476, 182);
            this.rtbInfo1.Name = "rtbInfo1";
            this.rtbInfo1.ReadOnly = true;
            this.rtbInfo1.Size = new System.Drawing.Size(294, 387);
            this.rtbInfo1.TabIndex = 20;
            this.rtbInfo1.Text = "";
            // 
            // infoForward
            // 
            this.infoForward.BackColor = System.Drawing.Color.Transparent;
            this.infoForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoForward.BackgroundImage")));
            this.infoForward.Location = new System.Drawing.Point(520, 137);
            this.infoForward.Name = "infoForward";
            this.infoForward.Size = new System.Drawing.Size(33, 35);
            this.infoForward.TabIndex = 23;
            this.infoForward.TabStop = false;
            this.infoForward.Click += new System.EventHandler(this.infoForward_Click);
            this.infoForward.MouseLeave += new System.EventHandler(this.infoForward_MouseLeave);
            this.infoForward.MouseHover += new System.EventHandler(this.infoForward_MouseHover);
            // 
            // infoBack
            // 
            this.infoBack.BackColor = System.Drawing.Color.Transparent;
            this.infoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoBack.BackgroundImage")));
            this.infoBack.Location = new System.Drawing.Point(480, 137);
            this.infoBack.Name = "infoBack";
            this.infoBack.Size = new System.Drawing.Size(38, 35);
            this.infoBack.TabIndex = 24;
            this.infoBack.TabStop = false;
            this.infoBack.Click += new System.EventHandler(this.infoBack_Click);
            this.infoBack.MouseLeave += new System.EventHandler(this.infoBack_MouseLeave);
            this.infoBack.MouseHover += new System.EventHandler(this.infoBack_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 616);
            this.Controls.Add(this.infoBack);
            this.Controls.Add(this.infoForward);
            this.Controls.Add(this.rtbInfo1);
            this.Controls.Add(this.pbMega);
            this.Controls.Add(this.lbPokemon);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbPokemon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "GenesisDex";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.ListBox lbPokemon;
        private System.Windows.Forms.PictureBox pbMega;
        private System.Windows.Forms.RichTextBox rtbInfo1;
        private System.Windows.Forms.PictureBox infoForward;
        private System.Windows.Forms.PictureBox infoBack;
    }
}

