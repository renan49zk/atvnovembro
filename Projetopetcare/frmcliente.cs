using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetopetcare
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.ResetText();
            txtidade.ResetText();
            txtnome.ResetText();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmMenuprincipal voltar = new frmMenuprincipal();
            voltar.Show();
            this.Hide();
        }
    }
}
