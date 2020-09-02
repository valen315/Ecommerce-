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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ModeloDominioUser user = new ModeloDominioUser();
            user.MostrarTablaUsuarios(dataGridViewCliente);
        }
    }
}
