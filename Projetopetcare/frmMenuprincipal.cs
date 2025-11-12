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
    public partial class frmMenuprincipal : Form
    {
        public frmMenuprincipal()
        {
            InitializeComponent();
        }

        private void btncadastrocliente_Click(object sender, EventArgs e)
        {
            frmcliente abrir = new frmcliente();
            abrir.Show();
            this.Hide();
        }

        private void btncadastroanimal_Click(object sender, EventArgs e)
        {
            frmanimal abrir = new frmanimal();
            abrir.Show();
            this.Hide();
        }

        private void btncadastroveterinario_Click(object sender, EventArgs e)
        {
            frmveterinario abrir = new frmveterinario();
            abrir.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
