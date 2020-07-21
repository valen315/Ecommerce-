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
    public partial class FormPrincipalClientes : Form
    {
        public FormPrincipalClientes()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FormConfiguracion perfil = new FormConfiguracion();
            perfil.Show();
        }
    }
}
