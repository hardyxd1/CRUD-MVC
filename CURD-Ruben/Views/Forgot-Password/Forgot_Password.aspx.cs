using System;
using System.Configuration;
using System.Data;

namespace CURD_Ruben.Views.Forgot_Password
{
    public partial class Forgot_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                // validate that the text boxes are not empty
                string Estemensaje = string.Empty;

                if (string.IsNullOrEmpty(txt_Email.Text)) Estemensaje += "Enter your email";
                //solamente valida que el text box de email no este vacio, si esta vacio lanza la expecion.

                Controllers.clsRecuperarPasswordController obclsRecuperarPasswordController = new Controllers.clsRecuperarPasswordController();
                CRUD_Logica.clsUsuarios obclsUsuarios = new CRUD_Logica.clsUsuarios
                {
                    User = txt_Email.Text
                };

                DataSet dsConsulta = obclsRecuperarPasswordController.getConsultarPasswordController(obclsUsuarios);
                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    string[] stUser= dsConsulta.Tables[0].Rows[0]["User"].ToString().Split('@');
                    string stCuerpoHTML = "<!DOCTYPE html>";
                    stCuerpoHTML += "<html lang='es'>";
                    stCuerpoHTML += "<head>";
                    stCuerpoHTML += "<meta charset='utf - 8'>";
                    stCuerpoHTML += "<title>Recuperacion de correo</title>";
                    stCuerpoHTML += "</head>";
                    stCuerpoHTML += "<body style='background - color: black '>";
                    stCuerpoHTML += "<table style='max - width: 600px; padding: 10px; margin: 0 auto; border - collapse: collapse; '>	";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='padding: 0'>";
                    stCuerpoHTML += "<img style='padding: 0; display: block' src='cid:Fondo' width='100%' height='10%'>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='background - color: #ecf0f1'>";
                    stCuerpoHTML += "<div style='color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>";
                    stCuerpoHTML += "<h2 style='color: #e67e22; margin: 0 0 7px'>Hola " + stUser[0] + "</h2>";
                    stCuerpoHTML += "<p style='margin: 2px; font - size: 15px'>";
                    stCuerpoHTML += "Hemos recibido una solicitud para restablecer el password de su cuenta asociada con ";
                    stCuerpoHTML += "esta dirección de correo electrónico. Si no ha realizado esta solicitud, puede ignorar este ";
                    stCuerpoHTML += "correo electrónico y le garantizamos que su cuenta es completamente segura.";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "Su password es: " + dsConsulta.Tables[0].Rows[0]["password"].ToString();
                    stCuerpoHTML += "</p>";
                    stCuerpoHTML += "<p style='color: #b3b3b3; font-size: 12px; text-align: center;margin: 30px 0 0'>Copyright © CRM 2018</p>";
                    stCuerpoHTML += "</div>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "</table>";
                    stCuerpoHTML += "</body>";
                    stCuerpoHTML += "</html>";
                    CRUD_Logica.Models.clsCorreo obclsCorreo = new CRUD_Logica.Models.clsCorreo
                    {
                        stServidor = ConfigurationManager.AppSettings["stServidor"].ToString(),
                        stUsuario = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stPassword = ConfigurationManager.AppSettings["stPassword"].ToString(),
                        stPuerto = ConfigurationManager.AppSettings["stPuerto"].ToString(),
                        blAutenticacion = true,
                        blConexionSegura = true,
                        inPrioridad = 0,
                        inTipo = 1,
                        stAsunto = "Recuperar password",
                        stFrom = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stTo = txt_Email.Text,
                        stImagen = Server.MapPath("~") + @"'\img\Fondo.gif'",
                        stIDimagen = "Fondo",
                        stMensaje = stCuerpoHTML
                    };
                    obclsRecuperarPasswordController.setEmailController(obclsCorreo);
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', 'Se realizo proceso con exito!', 'success') </script>");
                }
                else
                {
                    throw new Exception("No se encontro informacion asociada a este correo");
                }


            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}