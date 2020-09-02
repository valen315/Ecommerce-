using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace proyecto3
{
    public partial class FormRecuperarContraseña : Form
    {
        public FormRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var User = new ModeloDominioUser();
            var result = User.recuperarContraseña(txtMail.Text);
            label2.Text = result;
        }
    }
}
