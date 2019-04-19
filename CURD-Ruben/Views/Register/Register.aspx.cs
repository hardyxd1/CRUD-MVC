using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CURD_Ruben.Views.Register
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                Controllers.clsCrearcuentaController clsCrearcuentaController = new Controllers.clsCrearcuentaController();
                //Validamos la seleccionde la imagen
                if (fuimage.HasFile)
                {
                    if (!Path.GetExtension(fuimage.FileName).Equals(".jpg"))
                        throw new Exception("Solo se admiten formatos.JPG");
                    string stRuta = Server.MapPath(@"~\tmp\") + txt_email.Text + Path.GetExtension(fuimage.FileName);//Ruta temporal
                    fuimage.PostedFile.SaveAs(stRuta);//Guardando el archivo dentro del proyecto     

                  //  string stRutaDestino = Server.MapPath(@"~\imgEmail\") + txt_email.Text + Path.GetExtension(fuimage.FileName);//Ruta destino
               /*     if (File.Exists(stRutaDestino))
                    {
                        File.SetAttributes(stRutaDestino, FileAttributes.Normal);
                        File.Delete(stRutaDestino);
                    }
                    File.Copy(stRuta, stRutaDestino);
                    File.SetAttributes(stRutaDestino, FileAttributes.Normal);
                    File.Delete(stRutaDestino);*/
                    CRUD_Logica.clsUsuarios clsUsuarios = new CRUD_Logica.clsUsuarios
                    {
                        User = txt_email.Text,
                        Password = txt_password.Text,
                        usaImagen=  stRuta
                       
                    };
                    //validate that the text boxes are not empty 
                    /*  string Estemensaje = string.Empty;
                      if (string.IsNullOrEmpty(txt_email.Text)) Estemensaje += "Enter your email, ";
                      if (string.IsNullOrEmpty(txt_password.Text)) Estemensaje += "Enter your password, ";
                      if (string.IsNullOrEmpty(txt_confirmpassword.Text)) Estemensaje += " Confirm your password";
                      if (!string.IsNullOrEmpty(Estemensaje)) throw new Exception(Estemensaje.TrimEnd(',')); */
                    // esto es para mostrar en pantalla los text box que estan vacios, por ejemplo si coloca su primer nombre,
                    // pero no coloca lo demas se mostrar:
                    //"Enter your Last Name, Enter your email, Enter you password, Confirm your password
                    // se van concatenando dependiendo de cual text box esta vacio, 
                    //y el TrimEnd es para que al final de el ultimo mensaje se quita la ','

                    ClientScript.RegisterStartupScript(this.GetType(),
                  "mensaje", "<script> swal('Mensaje!', '" + clsCrearcuentaController.setCrearCuentaController(clsUsuarios, 1) + "', 'success')</script>");
                }
            }
            catch (Exception ex)
            {
                 ClientScript.RegisterStartupScript(this.GetType(),
                     "mensaje", "<script> swal('Error!', '" + ex.Message + "', 'error')</script>");
            }
        }
    }
}