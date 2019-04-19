using System;
using System.Data;
using System.Data.SqlClient;
namespace CRUD_Logica.BL
{
    public class clsRecuperar_Password
    {
        SqlConnection sqlConnection = null;// me permite establecer comunicacion con la base de datos
        SqlCommand sqlCommand = null;// me permite establecer comandos SQL
        SqlDataAdapter sqlDataAdapter = null; // me permite adaptar conjunto de datos
        string sConexion = string.Empty;// cadena de conexion
        SqlParameter sqlParameter = null;


        public clsRecuperar_Password()
        {
            clsConexion cls_conexion = new clsConexion();
            sConexion = cls_conexion.getConexion();
        }
        /// <summary>
        /// Consultar PASSWORD
        /// </summary>
        /// <returns>Registro Usuario</returns>
        public DataSet getConsultaPassword(CRUD_Logica.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dtConsulta = new DataSet();
                sqlConnection = new SqlConnection(sConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("spConsultaPassword", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@cUser", obclsUsuarios.User));
                sqlCommand.ExecuteNonQuery();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtConsulta);
                return dtConsulta;

            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
    }
}
