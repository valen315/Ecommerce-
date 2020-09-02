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
    public partial class MensajeError : Form
    {
        public MensajeError(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MensajeError_Load(object sender, EventArgs e)
        {
        }
        public static void TextoMensaje(string mensaje)
        {

            MensajeError mensajeError= new MensajeError(mensaje);
            mensajeError.ShowDialog();
        }
    }
}
