using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace CURD_Ruben.Controllers
{
    public class clsRecuperarPasswordController
    {
        public DataSet getConsultarPasswordController(CRUD_Logica.clsUsuarios obclsUsuarios)
        {
            try
            {
                CRUD_Logica.BL.clsRecuperar_Password obclsRecuperar_Password = new CRUD_Logica.BL.clsRecuperar_Password();
                return obclsRecuperar_Password.getConsultaPassword(obclsUsuarios);
            }catch(Exception ex) { throw ex; }
        }
        public void setEmailController(CRUD_Logica.Models.clsCorreo obclsCorreo)
        {
            try
            {
                CRUD_Logica.BL.clsGeneral obclsGeneral = new CRUD_Logica.BL.clsGeneral();
                obclsGeneral.setEmail(obclsCorreo);

            }
            catch (Exception ex) { throw ex; }

        }
    }
}