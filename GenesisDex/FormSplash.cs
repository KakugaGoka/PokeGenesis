using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenesisDexEngine;

namespace GenesisDex
{

    public partial class FormSplash : Form
    {
        int? currentDPI;

        public FormSplash()
        {
            InitializeComponent();
            DPISense dpiSense = new DPISense();
            currentDPI = dpiSense.CheckDPI();
            GotoPokeGenesis();
        }

        private void GotoPokeGenesis()
        {
            bwSpalshTimeout.RunWorkerAsync();
        }

        private void bwSpalshTimeout_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
            if (currentDPI != 96)
            {
                DialogResult dpiWrong = MessageBox.Show("Text Scaling must be set to 100% in order to use this application. Please change this in your display settings and relaunch afterwards.", "DPI is not 96", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dpiWrong == DialogResult.OK)
                    Application.Exit();
            }
        }

        private void bwSpalshTimeout_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormMain fm = new FormMain();
            this.Hide();
            fm.Show();
        }
    }
}
