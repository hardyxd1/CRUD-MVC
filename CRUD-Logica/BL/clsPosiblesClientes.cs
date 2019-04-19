using System;
using System.Data;
using System.Data.SqlClient;
namespace CRUD_Logica.BL
{
    public class clsPosiblesClientes
    {


        SqlConnection sqlConnection = null;// me permite establecer comunicacion con la base de datos
        SqlCommand sqlCommand = null;// me permite establecer comandos SQL
        SqlDataAdapter sqlDataAdapter = null; // me permite adaptar conjunto de datos
        string sConexion = string.Empty;// cadena de conexion
        SqlParameter sqlParameter = null;

        /// <summary>
        ///Validar Usuario
        /// </summary>
        /// <param name="objPosiblesClientes ">Objeto Usuario</param>
        /// <returns>Confirmacion</returns> 
        public clsPosiblesClientes()
        {
            clsConexion cls_conexion = new clsConexion();
            sConexion = cls_conexion.getConexion();
        }
        /// <summary>
        /// Posibles Clientes
        /// </summary>
        /// <returns>Registro de posibles clientes</returns>
        public DataSet getConsultarPosiblesClientes()
        {
            try
            {
                DataSet dtConsulta = new DataSet();
                sqlConnection = new SqlConnection(sConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("spConsultrarPosiblesClientes", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtConsulta);
                return dtConsulta;

            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }

        /// <summary>
        /// Administrar Posibles Clientes
        /// </summary>
        /// <param name="obclsPosiblesClientes"></param>
        /// <param name="opc"></param>
        /// <returns>Mensaje de operacion</returns>
        public string setAdministrarPosiblesClientes(Models.clsPosiblesClientes obclsPosiblesClientes, int opc)
        {
            try
            {
                DataSet dtConsulta = new DataSet();
                sqlConnection = new SqlConnection(sConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("spAdministrarPosiblesClientes", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@cIdentificacin", obclsPosiblesClientes.Idenftificacion));
                sqlCommand.Parameters.Add(new SqlParameter("@cPrimerNombre", obclsPosiblesClientes.Primer_Nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@cSegundoNombre", obclsPosiblesClientes.Segundo_Nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@cPrimerApellido", obclsPosiblesClientes.Primer_Apellido));
                sqlCommand.Parameters.Add(new SqlParameter("@cSegundoApellido", obclsPosiblesClientes.Segundo_Apellido));
                sqlCommand.Parameters.Add(new SqlParameter("@cTelefono", obclsPosiblesClientes.Telefono));
                sqlCommand.Parameters.Add(new SqlParameter("@cDirreccion", obclsPosiblesClientes.Dirreccion));
                sqlCommand.Parameters.Add(new SqlParameter("@cEmail", obclsPosiblesClientes.Correo));
                sqlCommand.Parameters.Add(new SqlParameter("@cEmpresa", obclsPosiblesClientes.Empresa));
                sqlCommand.Parameters.Add(new SqlParameter("@cOpcion", opc));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
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
