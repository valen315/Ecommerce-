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
    public partial class RegistroEmpresa : Form
    {
        public RegistroEmpresa()
        {
            InitializeComponent();
        }

        private void RegistroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void RegistroEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SeleccionartipoRegistro registro = new SeleccionartipoRegistro();
            registro.Show();
        }
    }
}
