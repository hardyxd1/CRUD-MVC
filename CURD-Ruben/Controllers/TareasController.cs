using System;
using System.Data;
namespace CURD_Ruben.Controllers
{
    public class TareasController
    {
        /// <summary>
        /// ESTADO TAREAS 
        /// </summary>
        /// <returns>DATA Estado Tareas</returns>
        public DataSet getConsultaEstadoTareasController()
        {
            try
            {
                CRUD_Logica.BL.clsEstadoTareas objclsEstadoTareas = new CRUD_Logica.BL.clsEstadoTareas();
                return objclsEstadoTareas.getConsultaEstadoTareas();

            }
            catch (Exception ex) { throw ex; }

        }
        /// <summary>
        /// ESTADO PRIORIDAD
        /// </summary>
        /// <returns>Registro Prioridad</returns>
        /// 
        public DataSet getConsultaPrioridadController()
        {
            try
            {
                CRUD_Logica.BL.clsPrioridad objclsPrioridad = new CRUD_Logica.BL.clsPrioridad();
                return objclsPrioridad.getConsultaPrioridad();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
        