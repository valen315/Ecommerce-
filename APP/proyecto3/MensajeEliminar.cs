﻿using System;
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
    public partial class MensajeEliminar : Form
    {
        public MensajeEliminar(string mensaje )
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }
        private void MensajeEliminar_Load(object sender, EventArgs e)
        {
            //transicionForm.ShowAsyc(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
