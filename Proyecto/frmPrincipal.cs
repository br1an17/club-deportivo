using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Variables tipo internal
        internal string? rol;
        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO:       " + usuario + "        " + "(" + rol + ")";
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registro = new frmRegistrar();
            registro.Show();
            this.Hide();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            CobrarCuota cobrar = new CobrarCuota();

            cobrar.Show();

            this.Hide();
      
        }
    }
}
