using MySql.Data.MySqlClient;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    internal class Clientes
    {
        public string Nuevo_Cliente(E_Cliente client)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoCli", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = client.NombreC;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = client.ApellidoC;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = client.TDocC;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = client.DocC;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = client.Telefono;
                comando.Parameters.Add("Mail", MySqlDbType.VarChar).Value = client.Email;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                };
            }

            return salida;
        }
    }
}
