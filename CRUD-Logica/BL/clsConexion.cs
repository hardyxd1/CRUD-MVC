using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CRUD_Logica.BL
{
    public class clsConexion
    {
        /// <summary>
        /// Para obtener la conexion de la base de datos
        /// </summary>
        /// <returns> Cadena de conexion</returns>
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
