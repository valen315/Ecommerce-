using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using Dominio;

namespace proyecto3.Administrador
{
    public partial class FormCategoria : Form
    {
        private bool NuevaCategoria;
        //private bool EditarCategoria;
        private int n = 0;
        private string idC;

        ModeloDominioProducto Mcategoria = new ModeloDominioProducto();
        CacheCategoriaMarca categoria = new CacheCategoriaMarca();

        public FormCategoria()
        {
            InitializeComponent();
            Reset();
        }

        public void Actualizar()
        {
            Mcategoria.ListarTablaCategoria(dgvCategorias);
        }
        public void MostrarBotones()
        {
            Botones botones = new Botones();
            botones.Boton(dgvCategorias);
        }
        private void Reset()
        {
            txtNombreCategoria.Enabled = false;
            btnOk.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombreCategoria.Text = "";
            btnNuevaCategoria.Enabled = true;

           // EditarCategoria = false;
        }
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            Actualizar();
            MostrarBotones();
            dgvCategorias.Columns["ID"].Visible = false;
            dgvCategorias.Columns[2].Width = 30;
            dgvCategorias.Columns[3].Width = 70;


        }
        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            btnNuevaCategoria.Enabled = false;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombreCategoria.Enabled = true;
            txtNombreCategoria.Text = "";
            txtNombreCategoria.Focus();

            NuevaCategoria = true;
            
        }
       
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNombreCategoria.Text.Length == 0)
            {
                MessageBox.Show("Este campo no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
            if (NuevaCategoria == true)
            {
                categoria.NombreCategoria_ = txtNombreCategoria.Text.Trim();
                Mcategoria.InsertarCategoria(categoria);
                Actualizar();
                txtNombreCategoria.Text = "";
                txtNombreCategoria.Focus();
              
            }
            else if (NuevaCategoria==false)
            {
                categoria.IdC =Convert.ToInt32(idC);
                categoria.NombreCategoria_ = txtNombreCategoria.Text.Trim();
                Mcategoria.EditarCategoria(categoria);
                Reset();
                Actualizar();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            n = e.RowIndex;
            try
            {
                if (n != -1)
                {
                    if (dgvCategorias.Columns[e.ColumnIndex].Name == "EDITAR")
                    {
                        txtNombreCategoria.Enabled = true;
                        btnOk.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnNuevaCategoria.Enabled = false;
                        NuevaCategoria = false;
                        
                        txtNombreCategoria.Text = dgvCategorias.CurrentRow.Cells["NOMBRE"].Value.ToString();
                        idC = dgvCategorias.CurrentRow.Cells["ID"].Value.ToString();
                        
                    }
                    else if (dgvCategorias.Columns[e.ColumnIndex].Name == "ELIMINAR")
                    {
                        try
                        {
                            DialogResult resultado = new DialogResult();
                            MensajeEliminar mensaje = new MensajeEliminar("Esta seguro de eliminar esta categoria?");
                            resultado = mensaje.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                categoria.IdC = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["ID"].Value.ToString());
                                Mcategoria.EliminarCategoria(categoria);
                                Mensaje.Notificacion("ELIMINADO");
                            }
                            Actualizar();
                            Reset();
                        }
                        catch
                        {
                            MensajeError.TextoMensaje("Esta categoria sigue añadida a un producto actual");
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mcategoria.BuscarCategoria(dgvCategorias, txtBuscar.Text);
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            //txtBuscar.Text = "";
            //this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                //txtBuscar.Text = "Buscar";
                //this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                Actualizar();
            }
        }
    }
}
