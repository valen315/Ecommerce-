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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            SeleccionartipoRegistro seleccionartipo = new SeleccionartipoRegistro();
            seleccionartipo.Show();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}