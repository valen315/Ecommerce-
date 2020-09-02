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
    public partial class Mensaje : Form
    {
        public Mensaje(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            //esclarecerForm.ShowAsyc(this);
        }
        public static void Notificacion(string mensaje)
        {
            
            Mensaje frmMensaje = new Mensaje(mensaje);
            frmMensaje.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
