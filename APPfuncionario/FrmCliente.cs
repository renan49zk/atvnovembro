using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPfuncionario
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }


        public void DesabilitarCampos()
        {
            txtname.Enabled = false;
            txtidade.Enabled = false;
            txtcodigo.Enabled = false;
        }

        public void HabilitarCampos()
        {
            txtname.Enabled = false;
            txtidade.Enabled = false;
            txtcodigo.Enabled = false;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
