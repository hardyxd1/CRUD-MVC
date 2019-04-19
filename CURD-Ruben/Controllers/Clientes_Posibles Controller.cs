using System;
using System.Data;
namespace CURD_Ruben.Controllers
{
    public class Clientes_Posibles_Controller
    {
        public DataSet getConsultaosiblesClientesController()
        {
            /// <summary>
            ///Obtener Registros Posibles Clientes
            /// </summary>
            /// <returns>DATA POSIBLES CLIENTES</returns>
            try
            {
                CRUD_Logica.BL.clsPosiblesClientes ob = new CRUD_Logica.BL.clsPosiblesClientes();
                return ob.getConsultarPosiblesClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //
        /// <summary> 
        ///Administrar posibles clientes
        /// </summary>
        /// <param name="clsPosiblesClientesM"></param>
        /// <param name="opc"></param>
        /// <returns></returns>
        public string setAdministrarPosiblesClientes(CRUD_Logica.Models.clsPosiblesClientes clsPosiblesClientesM, int opc)
        {

            try
            {
                CRUD_Logica.BL.clsPosiblesClientes ob2 = new CRUD_Logica.BL.clsPosiblesClientes();
                return ob2.setAdministrarPosiblesClientes(clsPosiblesClientesM, opc);
            }
            catch (Exception ex) { throw ex; }



        }
    }
}
