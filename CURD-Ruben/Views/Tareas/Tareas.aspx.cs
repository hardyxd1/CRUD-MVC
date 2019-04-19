using System;
using System.Data;
namespace CURD_Ruben.Views.Tareas
{
    public partial class Tareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {
                Controllers.TareasController tareasController = new Controllers.TareasController();
                DataSet dsConsultaEstadoTarea = tareasController.getConsultaEstadoTareasController();
                DataSet dsConsultaPrioridad = tareasController.getConsultaPrioridadController();

                //asigno origen de datos
                ddl_Estado.DataSource = dsConsultaEstadoTarea;
                ddl_Estado.DataTextField = "usaDescripcion";// LO QUE MUSTRA
                ddl_Estado.DataValueField= "usaCodigo";// LO QUE EQUIVALE
                ddl_Estado.DataBind();// ACEPTE LOS CAMBIOS

                //asigno origen de datos
                ddl_Prioridad.DataSource = dsConsultaPrioridad;
                ddl_Prioridad.DataTextField = "Descripcion";// LO QUE MUSTRA
                ddl_Prioridad.DataValueField = "ID";// LO QUE EQUIVALE
                    
                ddl_Prioridad.DataBind();// ACEPTE LOS CAMBIOS

            }
        }

        protected void btn_Guardad_Click(object sender, EventArgs e)
        {

        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}