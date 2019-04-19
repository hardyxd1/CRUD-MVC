using System;
using System.Data;
using System.Web.UI.WebControls;

namespace CURD_Ruben.Views.Posibles_Clientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {
        #region Metodos y Funciones
        /// <summary>
        /// Obtiene consulta   posibles clientes
        /// </summary>
        void getCliente()
        {
            try
            {
                Controllers.Clientes_Posibles_Controller obclientes_Posibles_Controller = new Controllers.Clientes_Posibles_Controller();
                DataSet dsConsulta = obclientes_Posibles_Controller.getConsultaosiblesClientesController();
                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    gv_datos.DataSource = dsConsulta;
                }
                else
                {
                    gv_datos.DataSource = null;
                }
                gv_datos.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(),
                            "mensaje", "<script> swal('Error!', '" + ex.Message + "'! 'error')</script>");
            }
        }
        #endregion
        #region Eventos 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["sessionEmail"] == null) Response.Redirect("~/Views/Login/Login.aspx");
                 
              
                getCliente();
            }
        }

        protected void btn_Guardad_Click(object sender, EventArgs e)
        {
            try
            {
                string Estemensaje = string.Empty;
                if (string.IsNullOrEmpty(txt_Identificacion.Text)) Estemensaje += "Enter ID,";
                if (!string.IsNullOrEmpty(Estemensaje)) throw new Exception(Estemensaje.TrimEnd(','));
                CRUD_Logica.Models.clsPosiblesClientes clsPosiblesClientes = new CRUD_Logica.Models.clsPosiblesClientes
                {
                    Idenftificacion = Convert.ToInt64(txt_Identificacion.Text),
                    Primer_Nombre = txt_PNombre.Text,
                    Segundo_Nombre = txt_SNombre.Text,
                    Primer_Apellido = txt_PA.Text,
                    Segundo_Apellido = txt_SA.Text,
                    Dirreccion = txt_dir.Text,
                    Telefono = txt_telefono.Text,
                    Correo = txt_email.Text,
                    Empresa = txt_Empresa.Text
                };
                Controllers.Clientes_Posibles_Controller clientes_Posibles_Controller = new Controllers.Clientes_Posibles_Controller();

                if (string.IsNullOrEmpty(lbl_opc.Text)) lbl_opc.Text = "1";
                ClientScript.RegisterStartupScript(this.GetType(),
                "mensaje", "<script> alert('" + clientes_Posibles_Controller.setAdministrarPosiblesClientes(clsPosiblesClientes, Convert.ToInt32(lbl_opc.Text)) + "')</script>");
                lbl_opc.Text = txt_Identificacion.Text = txt_Empresa.Text = txt_PNombre.Text = txt_SNombre.Text = txt_PA.Text = txt_SA.Text = txt_telefono.Text = txt_dir.Text = txt_email.Text = string.Empty;
                getCliente();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(),
                                "mensaje", "<script> alert( '" + ex.Message + "')</script>");
            }
        }
        public void gvDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                if (e.CommandName.Equals("Editar"))
                {
                    lbl_opc.Text = "2";
                    //acceder a un control web dentro de un grid
                    txt_Identificacion.Text = ((Label)gv_datos.Rows[indice].FindControl("lblIdentificacion")).Text;
                    txt_Empresa.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[1].Text) ? string.Empty : gv_datos.Rows[indice].Cells[1].Text;
                    txt_PNombre.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[2].Text) ? string.Empty : gv_datos.Rows[indice].Cells[2].Text;
                    txt_SNombre.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[3].Text) ? string.Empty : gv_datos.Rows[indice].Cells[3].Text;
                    txt_PA.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[4].Text) ? string.Empty : gv_datos.Rows[indice].Cells[4].Text;
                    txt_SA.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[5].Text) ? string.Empty : gv_datos.Rows[indice].Cells[5].Text;
                    txt_telefono.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[6].Text) ? string.Empty : gv_datos.Rows[indice].Cells[6].Text;
                    txt_email.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[7].Text) ? string.Empty : gv_datos.Rows[indice].Cells[7].Text;
                    txt_dir.Text = string.IsNullOrEmpty(gv_datos.Rows[indice].Cells[8].Text) ? string.Empty : gv_datos.Rows[indice].Cells[8].Text;


                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    lbl_opc.Text = "3";
                    CRUD_Logica.Models.clsPosiblesClientes clsPosiblesClientes = new CRUD_Logica.Models.clsPosiblesClientes
                    {
                        Idenftificacion = Convert.ToInt64(((Label)gv_datos.Rows[indice].FindControl("lblIdentificacion")).Text),
                        Primer_Nombre = string.Empty,
                        Segundo_Nombre = string.Empty,
                        Primer_Apellido = string.Empty,
                        Segundo_Apellido = string.Empty,
                        Dirreccion = string.Empty,
                        Telefono = string.Empty,
                        Correo = string.Empty,
                        Empresa = string.Empty

                    };
                    Controllers.Clientes_Posibles_Controller clientes_Posibles_Controller = new Controllers.Clientes_Posibles_Controller();

                    if (string.IsNullOrEmpty(lbl_opc.Text)) lbl_opc.Text = "1";
                    ClientScript.RegisterStartupScript(this.GetType(),
                    "mensaje", "<script> alert('" + clientes_Posibles_Controller.setAdministrarPosiblesClientes(clsPosiblesClientes, Convert.ToInt32(lbl_opc.Text)) + "')</script>");
                    lbl_opc.Text = string.Empty;
                    getCliente();
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(),
            "mensaje", "<script> alert( '" + ex.Message + "')</script>");
            }
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_opc.Text = txt_Identificacion.Text = txt_Empresa.Text = txt_PNombre.Text = txt_SNombre.Text = txt_PA.Text = txt_SA.Text = txt_telefono.Text = txt_dir.Text = txt_email.Text = string.Empty;
        }
        #endregion
    }
}