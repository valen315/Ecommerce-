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
using CapaComun.Cache;

namespace proyecto3.Administrador
{
    public partial class FormMarcas : Form
    {
        private bool NuevaMarca;
        //private bool EditarMarca;
        private int n = 0;
        private string idM;

        public FormMarcas()
        {
            InitializeComponent();
            Reset();
        }

        ModeloDominioProducto Fmarca = new ModeloDominioProducto();
        CacheCategoriaMarca marca = new CacheCategoriaMarca();

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            Actualizar();
            MostrarBotones();
            DgvMarcas.Columns["ID"].Visible = false;
            DgvMarcas.Columns[2].Width = 30;
            DgvMarcas.Columns[3].Width = 70;
        }
        public void Actualizar()
        {
            Fmarca.ListarTablaMarca(DgvMarcas);
        }
        public void MostrarBotones()
        {
            Botones botones = new Botones();
            botones.Boton(DgvMarcas);
        }
        private void Reset()
        {
            txtNombreMarca.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtNombreMarca.Text = "";
            btnNuevaMarca.Enabled = true;

        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            txtNombreMarca.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombreMarca.Enabled = true;
            txtNombreMarca.Text = "";
            txtNombreMarca.Focus();

            NuevaMarca = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreMarca.Text.Length == 0)
            {
                MessageBox.Show("Este campo no puede estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NuevaMarca == true)
            {
                marca.NombreMarca_ = txtNombreMarca.Text.Trim();
                Fmarca.InsertarMarca(marca);
                Actualizar();
                txtNombreMarca.Text = "";
                txtNombreMarca.Focus();

            }
            else if (NuevaMarca == false)
            {
                marca.IdM = Convert.ToInt32(idM);
                marca.NombreMarca_= txtNombreMarca.Text.Trim();
                Fmarca.EditarMarca(marca);
                Reset();
                Actualizar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            try
            {
                if (n != -1)
                {
                    if (DgvMarcas.Columns[e.ColumnIndex].Name == "EDITAR")
                    {
                        txtNombreMarca.Enabled = true;
                        btnGuardar.Enabled = true;
                        btnCancelar.Enabled = true;
                        btnNuevaMarca.Enabled = false;
                        NuevaMarca = false;

                        txtNombreMarca.Text = DgvMarcas.CurrentRow.Cells["NOMBRE"].Value.ToString();
                        idM = DgvMarcas.CurrentRow.Cells["ID"].Value.ToString();

                    }
                    else if (DgvMarcas.Columns[e.ColumnIndex].Name == "ELIMINAR")
                    {
                        try
                        {
                            DialogResult resultado = new DialogResult();
                            MensajeEliminar mensaje = new MensajeEliminar("Esta seguro de eliminar esta marca?");
                            resultado = mensaje.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                marca.IdM = Convert.ToInt32(DgvMarcas.CurrentRow.Cells["ID"].Value.ToString());
                                Fmarca.EliminarMarca(marca);
                                Mensaje.Notificacion("ELIMINADO");
                            }
                            Actualizar();
                            Reset();
                        }
                        catch
                        {
                            MensajeError.TextoMensaje("Esta marca sigue añadida a un producto actual");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fmarca.BucarMarca(DgvMarcas, txtBuscar.Text);
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
