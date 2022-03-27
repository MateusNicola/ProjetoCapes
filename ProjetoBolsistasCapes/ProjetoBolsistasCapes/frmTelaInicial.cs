using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBolsistasCapes
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultarBolsaZeroAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarBolsa frmConsultarBolsa = new frmConsultarBolsa();
            frmConsultarBolsa.Show();
        }
    }
}
