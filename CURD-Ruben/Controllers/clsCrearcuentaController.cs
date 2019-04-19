using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace CURD_Ruben.Controllers
{
    public class clsCrearcuentaController
    {
         public string setCrearCuentaController(CRUD_Logica.clsUsuarios obclsUsuarios, int opc)
        {
            try
            {
                CRUD_Logica.BL.clsUsuarios clsUsuarios = new CRUD_Logica.BL.clsUsuarios();
                return clsUsuarios.setCrearUsuarios(obclsUsuarios, opc);
            }catch(Exception ex) { throw ex; }
        }
    }
}