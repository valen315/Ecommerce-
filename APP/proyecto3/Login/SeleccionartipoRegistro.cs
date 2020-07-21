using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class SeleccionartipoRegistro : Form
    {
        public SeleccionartipoRegistro()
        {
            InitializeComponent();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            RegistroEmpresa registroEmpresa = new RegistroEmpresa();
            this.Hide();
            registroEmpresa.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
        }
        private void SeleccionartipoRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
