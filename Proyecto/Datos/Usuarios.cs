using MySql.Data.MySqlClient;
using Proyecto.Datos;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Proyecto.Datos
{
    internal class Usuarios
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                // el comando es un elemento que almacena en este caso e nombre
                // del procedimiento almacenado y la referencia a la conexion
            MySqlCommand comando = new MySqlCommand
            ("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                // definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu",MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Clave", MySqlDbType.VarChar).Value = P_Usu;
                // abrimos la conexion
                sqlCon.Open();
                resultado = comando.ExecuteReader(); 
                tabla.Load(resultado); 
            return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }
    }
}