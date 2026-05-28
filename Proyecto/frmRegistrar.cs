using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
            cboTipo.Items.Add("DNI");
            cboTipo.Items.Add("Pasaporte");
            cboTipo.Items.Add("Extranjero");
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string TipoCliente = "";
            if (rbSocio.Checked)
            {
                TipoCliente = "Socio";
            }
            else
            {
                TipoCliente = "No Socio";
            }
            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipo.Text == "" ||
txtDocumento.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
            else
            {
                string respuesta;
                E_Cliente client = new E_Cliente();
                client.NombreC = txtNombre.Text;
                client.ApellidoC = txtApellido.Text;
                client.TipoDocC = cboTipo.Text;
                client.DocC = Convert.ToInt32(txtDocumento.Text);
                client.Telefono = txtTelefono.Text;
                client.Email = txtEmail.Text;
                
                // instanciamos para usar el metodo dentro de postulantes
                Datos.Clientes clientes = new Datos.Clientes();
                respuesta = clientes.Nuevo_Cliente(client);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        cboTipo.Text = "";
                        txtDocumento.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";
                        txtNombre.Focus();
                    }
                }

            }
        }

        //Limpiamos los objetos para un nuevo ingreso
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cboTipo.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombre.Focus();

        }
    }
}
