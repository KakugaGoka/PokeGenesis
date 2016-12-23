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

namespace GenesisDex
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
            GotoPokeGenesis();
        }

        private void GotoPokeGenesis()
        {
            bwSpalshTimeout.RunWorkerAsync();
        }

        private void bwSpalshTimeout_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }

        private void bwSpalshTimeout_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormMain fm = new FormMain();
            this.Hide();
            fm.Show();
        }
    }
}
