using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD_Logica;
namespace CURD_Ruben.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                if (Request.Cookies["cookieEmail"]!= null)
                {
                    txt_Email.Text = Request.Cookies["cookieEmail"].Value.ToString();
                }
            }
               
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            // validate that the text boxes are not empty
            try
            {
                // this is a way
                string Estemensaje = string.Empty;
                 if(string.IsNullOrEmpty(txt_Email.Text)) Estemensaje += "Enter email,";
                if (string.IsNullOrEmpty(txt_password.Text)) Estemensaje += "Enter password,";
                if (!string.IsNullOrEmpty(Estemensaje)) throw new Exception(Estemensaje.TrimEnd(','));

                // defini el objeto con sus propiedades 
                CRUD_Logica.clsUsuarios obclsUsuarios = new CRUD_Logica.clsUsuarios
                {
                    Password = txt_password.Text,
                    User = txt_Email.Text

                };
                // Instacio el controlador
                Controllers.LogicaController obLoginController = new Controllers.LogicaController();
                bool Bandera = obLoginController.getValidarUsuarioC(obclsUsuarios);
                if (Bandera)
                {
                    Session["sessionEmail"]=txt_Email.Text;
                    if (chk_remeberpassword.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txt_Email.Text);// crear objeto de cookie
                        cookie.Expires = DateTime.Now.AddDays(2); // para de vida de la cookie
                        Response.Cookies.Add(cookie); // agrego a la coleccion de cookies
                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txt_Email.Text);
                        cookie.Expires = DateTime.Now.AddDays(-1); // expira el dia de ayer
                        Response.Cookies.Add(cookie); 
                    }  
                    Response.Redirect("../Index/Index.aspx?stEmail=" + txt_Email.Text);// redircciono al index
                }
                else
                    throw new Exception("Usuario o password invalidas");
                  
                // and this is another
                /*
                 * string Estemensaje= string.Empty;
                 * if (string.IsNullOrEmpty(txt_Email.Text)) Estemensaje+= "Enter email";
                 * if (string.IsNullOrEmpty(txt_Email.Text)) throw new Exception("Enter email");

                if (string.IsNullOrEmpty(txt_password.Text)) throw new Exception("Enter password")
                 */
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(),
                    "mensaje", "<script> swal('Error!', '" + ex.Message + "', 'error')</script>");
            }
        }
    }
}