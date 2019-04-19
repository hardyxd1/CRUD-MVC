using System;
namespace CURD_Ruben.Controllers
{
    public class LogicaController
    {
        public bool getValidarUsuarioC(CRUD_Logica.clsUsuarios objclsUsuarios)
        {
            /// <summary>
            ///Validar Usuario
            /// </summary>
            /// <param name="objUsuario">Objeto Usuario</param>
            /// <returns>Confirmacion</returns>
            try
            {
                CRUD_Logica.BL.clsUsuarios objclsUsuario = new CRUD_Logica.BL.clsUsuarios();
                return objclsUsuario.getValidarUsuarios(objclsUsuarios);
            }
            catch (Exception ex) { throw ex; }
            

            
            
        }
    }
}