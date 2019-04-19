using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CRUD_Logica.BL
{
    public class clsUsuarios
    {
        SqlConnection sqlConnection = null;// me permite establecer comunicacion con la base de datos
        SqlCommand sqlCommand = null;// me permite establecer comandos SQL
        SqlDataAdapter sqlDataAdapter = null; // me permite adaptar conjunto de datos
        string sConexion = string.Empty;// cadena de conexion
        SqlParameter sqlParameter = null;

        /// <summary>
        ///Validar Usuario
        /// </summary>
        /// <param name="objUsuario">Objeto Usuario</param>
        /// <returns>Confirmacion</returns> 
        public clsUsuarios()
        {
            clsConexion cls_conexion = new clsConexion();
            sConexion = cls_conexion.getConexion();
        }
        public bool getValidarUsuarios(CRUD_Logica.clsUsuarios objUsuarios)
        {
            try
            {
                DataSet dtConsulta = new DataSet();
                sqlConnection = new SqlConnection(sConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("ConsultaUsuarios", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@cUser", objUsuarios.User));
                sqlCommand.Parameters.Add(new SqlParameter("@cpassword", objUsuarios.Password));
                sqlCommand.ExecuteNonQuery();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtConsulta);
                if (dtConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex) { throw ex; }
           finally { sqlConnection.Close(); }
        }
        public string setCrearUsuarios(CRUD_Logica.clsUsuarios objUsuarios, int opc)
        {
            try
            {
                DataSet dtConsulta = new DataSet();
                sqlConnection = new SqlConnection(sConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("spAdministrarUsuario", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                //PARAMETROS DE ENTRADA
                sqlCommand.Parameters.Add(new SqlParameter("@cUser", objUsuarios.User));
                sqlCommand.Parameters.Add(new SqlParameter("@cPassword", objUsuarios.Password));
                sqlCommand.Parameters.Add(new SqlParameter("@cImagen", objUsuarios.usaImagen));
                sqlCommand.Parameters.Add(new SqlParameter("@nOpc", opc));

                //PARAMETROS DE SALIDA
                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@nMensaje";
                sqlParameter.Direction = ParameterDirection.Output;
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 50;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();
                return sqlParameter.Value.ToString();

            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
    }


}
