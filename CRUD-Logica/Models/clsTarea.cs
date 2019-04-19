using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Logica.Models
{
    public class clsTarea
    {
        public int incodTarea { get; set; }
        public string sttareaTitular { get; set; }
        public string sttareaAsunto { get; set; }
        public string sttareaFechaVencimiento { get; set; }
        public string sttareaContacto{ get; set; }
        public string sttareaCuenta { get; set; }
        public clsEstadoTarea obclsEstadoTarea { get; set; }
        public clsPrioridad obclsprioridad { get; set; }
        public char chtareaEnviar_Tarea { get; set; }
        public char chtareaRepetir_Tarea { get; set; }
        public string sttareaDescripcion { get; set; }
    }
}
