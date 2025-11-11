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
    public partial class frmmenuprincipal : Form
    {
        public frmmenuprincipal()
        {
            InitializeComponent();
        }
        private void btncadastrocliente_Click(object sender, EventArgs e)
        {
            frmcliente abrir = new frmcliente();
            abrir.Show();
            this.Hide();

        }

        private void btncadastraranimal_Click(object sender, EventArgs e)
        {
            frmanimal abrir = new frmanimal();
            abrir.Show();
            this.Hide();

        }
    }
}
