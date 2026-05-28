using Proyecto.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CobrarCuota : Form
    {
        public ComprobanteCuota doc = new ComprobanteCuota();
        public CobrarCuota()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                /* Consulta simple que proyecta los datos necesarios para rellenar el documento*/

                string query = "SELECT NCliente, NombreC, ApellidoC, TipoCliente " +
                               "FROM cliente " +

                               "WHERE NCliente =  + @id"; //<-- usamos el dato ingresado por el usuario
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@id", txtID.Text);

                //Usamos la consulta y la conexion
                comando.CommandType = CommandType.Text;

                sqlCon.Open();

                MySqlDataReader reader; //el datareader almacena todas las filas

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); //en este caso sabemos que si tiene datos es una sola fila

                    doc.numero_c = reader.GetInt32(0);

                    doc.cliente_c = reader.GetString(1) + " " + reader.GetString(2);

                    doc.tipo_c = reader.GetString(3);

                    //Diferenciamos el tipo de cuota

                    if (doc.tipo_c == "Socio")
                    {
                        doc.monto_c = 50000;

                    }
                    else
                    {
                        doc.monto_c = 10000;
                    }

                    doc.fecha_c = DateTime.Now;

                    //forma de pago
                    if (optEfectivo.Checked == true) //si seleccionó efectivo
                    {
                        doc.forma_c = "Efectivo";

                        doc.cuotas_c = 1;

                        doc.valorCuota_c = doc.monto_c;
                        //oculta cuotas
                        cmbCuotas.Visible = false;
                        lblCuotas.Visible = false;
                    }
                    else if(optTarjeta.Checked == true) //si seleccionó tarjeta
                    {
                        //muestra cuotas
                        cmbCuotas.Visible = true;
                        lblCuotas.Visible = true;

                        doc.forma_c = "Tarjeta";

                        //validamos que haya seleccionado cuotas
                        if (cmbCuotas.Text == "")
                        {
                            MessageBox.Show("Seleccione cantidad de cuotas");
                            return;
                        }
                        doc.cuotas_c = Convert.ToInt32(cmbCuotas.Text);
                        doc.valorCuota_c = doc.monto_c / doc.cuotas_c;

                        //interés según cuotas
                        if (cmbCuotas.Text == "3")
                        {
                            doc.monto_c = doc.monto_c * 1.10f;
                        }
                        else if (cmbCuotas.Text == "6")
                        {
                            doc.monto_c = doc.monto_c * 1.20f;
                        }
                        doc.valorCuota_c = doc.monto_c / doc.cuotas_c;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un método de pago");
                        return;
                    }

                    btnComprobante.Enabled = true;

                    MessageBox.Show("Cobro realizado correctamente");
                }
                else
                {
                    MessageBox.Show("Cliente inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
        }

        private void CobrarCuota_Load(object sender, EventArgs e)
        {
            cmbCuotas.Items.Add("3");
            cmbCuotas.Items.Add("6");

            cmbCuotas.Enabled = false;

            btnComprobante.Enabled = false;
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbCuotas.Visible = optTarjeta.Checked;
            lblCuotas.Visible = optTarjeta.Checked;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbCuotas.Visible = false;
            lblCuotas.Visible = false;
        }
    }
}
