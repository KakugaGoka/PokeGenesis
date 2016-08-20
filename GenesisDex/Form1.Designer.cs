namespace GenesisDex
{
    partial class Form1
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
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.cbDex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSPD = new System.Windows.Forms.Label();
            this.lblSPDEF = new System.Windows.Forms.Label();
            this.lblSPATK = new System.Windows.Forms.Label();
            this.lblDEF = new System.Windows.Forms.Label();
            this.lblATK = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPokemon
            // 
            this.pbPokemon.BackColor = System.Drawing.Color.Transparent;
            this.pbPokemon.Location = new System.Drawing.Point(18, 47);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(122, 122);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPokemon.TabIndex = 0;
            this.pbPokemon.TabStop = false;
            // 
            // cbDex
            // 
            this.cbDex.FormattingEnabled = true;
            this.cbDex.Location = new System.Drawing.Point(12, 12);
            this.cbDex.Name = "cbDex";
            this.cbDex.Size = new System.Drawing.Size(264, 21);
            this.cbDex.TabIndex = 1;
            this.cbDex.SelectedIndexChanged += new System.EventHandler(this.cbDex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ATK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DEF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SPATK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SPDEF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "SPD:";
            // 
            // lblSPD
            // 
            this.lblSPD.AutoSize = true;
            this.lblSPD.Location = new System.Drawing.Point(190, 112);
            this.lblSPD.Name = "lblSPD";
            this.lblSPD.Size = new System.Drawing.Size(0, 13);
            this.lblSPD.TabIndex = 13;
            // 
            // lblSPDEF
            // 
            this.lblSPDEF.AutoSize = true;
            this.lblSPDEF.Location = new System.Drawing.Point(190, 99);
            this.lblSPDEF.Name = "lblSPDEF";
            this.lblSPDEF.Size = new System.Drawing.Size(0, 13);
            this.lblSPDEF.TabIndex = 12;
            // 
            // lblSPATK
            // 
            this.lblSPATK.AutoSize = true;
            this.lblSPATK.Location = new System.Drawing.Point(190, 86);
            this.lblSPATK.Name = "lblSPATK";
            this.lblSPATK.Size = new System.Drawing.Size(0, 13);
            this.lblSPATK.TabIndex = 11;
            // 
            // lblDEF
            // 
            this.lblDEF.AutoSize = true;
            this.lblDEF.Location = new System.Drawing.Point(190, 73);
            this.lblDEF.Name = "lblDEF";
            this.lblDEF.Size = new System.Drawing.Size(0, 13);
            this.lblDEF.TabIndex = 10;
            // 
            // lblATK
            // 
            this.lblATK.AutoSize = true;
            this.lblATK.Location = new System.Drawing.Point(190, 60);
            this.lblATK.Name = "lblATK";
            this.lblATK.Size = new System.Drawing.Size(0, 13);
            this.lblATK.TabIndex = 9;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(190, 47);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(0, 13);
            this.lblHP.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(288, 184);
            this.Controls.Add(this.lblSPD);
            this.Controls.Add(this.lblSPDEF);
            this.Controls.Add(this.lblSPATK);
            this.Controls.Add(this.lblDEF);
            this.Controls.Add(this.lblATK);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDex);
            this.Controls.Add(this.pbPokemon);
            this.Name = "Form1";
            this.Text = "GenesisDex";
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.ComboBox cbDex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSPD;
        private System.Windows.Forms.Label lblSPDEF;
        private System.Windows.Forms.Label lblSPATK;
        private System.Windows.Forms.Label lblDEF;
        private System.Windows.Forms.Label lblATK;
        private System.Windows.Forms.Label lblHP;
    }
}

