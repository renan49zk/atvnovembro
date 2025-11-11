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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsenha.Clear();
            txtusuario.Clear();

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txtusuario.Text;
            senha = Convert.ToInt32(txtsenha.Text);

            if (usuario == "admin" & senha == 123)
            {
                frmMenuprincipal abrir = new frmMenuprincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Usuario ou senha incorretos");
            }

        }
    }
    }
