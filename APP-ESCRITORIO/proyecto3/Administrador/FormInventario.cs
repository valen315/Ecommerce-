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

namespace proyecto3.Administrador
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }
        ModeloDominioProducto producto = new ModeloDominioProducto();
        private void FormInventario_Load(object sender, EventArgs e)
        {
            producto.MostrarTabla(dataGridView1);
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["IMAGEN"].Visible = false;
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            producto.BuscarProducto(dataGridView1, txtBuscar.Text);
        }
        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
                this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                producto.MostrarTabla(dataGridView1);
            }
        }

    }
}
