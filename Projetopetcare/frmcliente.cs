using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            Desabilitarcampos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            Habilitarcampos();
        }

        private void Desabilitarcampos()
        {
            txtnome.Enabled = false;
            txtcodigo.Enabled = false;
            txtidade.Enabled = false;
        }
        private void Habilitarcampos()
        {
            txtcodigo.Enabled = true;
            txtidade.Enabled = true;
            txtnome.Enabled = true;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.ResetText();
            txtcodigo.ResetText();
            txtidade.ResetText();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmlogin abrir = new frmlogin();
            abrir.Show();
            this.Hide();

        }
    }
}