using System;
using System.Collections.Generic;
using System.Linq;
namespace CRUD_Logica.BL
{
    public class clsTareas
    {
        /// <summary>
        /// Adicionar una tarea
        /// </summary>
        /// <param name="obclsTarea"> Modelo  de tareas</param>
        /// <returns></returns>

        public string addTareas(Models.clsTarea obclsTarea)
        {
            try
            {
                using (Entity.NorthwindEntities obnorthwindEntities = new Entity.NorthwindEntities())
                {
                    Entity.Tarea obtarea = new Entity.Tarea
                    {
                        tareaCodigo = obclsTarea.incodTarea,
                        tareaTitular = obclsTarea.sttareaTitular,
                        tareaAsunto = obclsTarea.sttareaAsunto,
                        tareaCuenta = obclsTarea.sttareaCuenta,
                        tareaFechaVencimiento = obclsTarea.sttareaFechaVencimiento,
                        tareaContacto = obclsTarea.sttareaContacto,
                        estadoCodigo = obclsTarea.obclsEstadoTarea.inCodigo,
                        prioridaCodigo = obclsTarea.obclsprioridad.prioCodigp,
                        tareaEnviarMensaje = obclsTarea.chtareaEnviar_Tarea.ToString(),
                        tareaRepetir = obclsTarea.chtareaRepetir_Tarea.ToString(),
                        tareaDescripcion = obclsTarea.sttareaDescripcion
                    };
                    obnorthwindEntities.Tarea.Add(obtarea);
                    obnorthwindEntities.SaveChanges();
                    return "Proceso exitoso";
                }
            }
            catch (Exception ex) { throw ex; }


        }
        /// <summary>
        /// Modifica una tarea
        /// </summary>
        /// <param name="obclsTarea">Modelo de tarea</param>
        /// <returns></returns>
        public string updateTareas(Models.clsTarea obclsTarea)
        {
            try
            {
                using (Entity.NorthwindEntities obnorthwindEntities = new Entity.NorthwindEntities())
                {
                    Entity.Tarea obtarea = (from q in obnorthwindEntities.Tarea
                                            where q.tareaCodigo == obclsTarea.incodTarea
                                            select q).FirstOrDefault();
                    obtarea.tareaTitular = obclsTarea.sttareaTitular;
                    obtarea.tareaAsunto = obclsTarea.sttareaAsunto;
                    obtarea.tareaDescripcion = obclsTarea.sttareaDescripcion;
                    obtarea.tareaFechaVencimiento = obclsTarea.sttareaFechaVencimiento;
                    obtarea.tareaContacto = obclsTarea.sttareaContacto;
                    obtarea.tareaCuenta = obclsTarea.sttareaCuenta;
                    obtarea.tareaEnviarMensaje = obclsTarea.chtareaEnviar_Tarea.ToString();
                    obtarea.tareaRepetir = obclsTarea.chtareaRepetir_Tarea.ToString();
                    obtarea.estadoCodigo = obclsTarea.obclsEstadoTarea.inCodigo;
                    obtarea.prioridaCodigo = obclsTarea.obclsprioridad.prioCodigp;

                    obnorthwindEntities.SaveChanges();
                    return "Proceso exitoso";
                }

            }
            catch (Exception ex) { throw ex; }


        }
        /// <summary>
        /// Eliminar una tarea
        /// </summary>
        /// <param name="obclsTarea">Modelo de tarea</param>
        /// <returns></returns>
        public string deleteTareas(Models.clsTarea obclsTarea)
        {
            try
            {
                using (Entity.NorthwindEntities obnorthwindEntities = new Entity.NorthwindEntities())
                {
                    Entity.Tarea obtarea = (from q in obnorthwindEntities.Tarea
                                            where q.tareaCodigo == obclsTarea.incodTarea
                                            select q).FirstOrDefault();

                    obnorthwindEntities.Tarea.Remove(obtarea);
                    obnorthwindEntities.SaveChanges();
                    return "Proceso exitoso";
                }

            }
            catch (Exception ex) { throw ex; }

        }
        /// <summary>
        /// Consulta de todas las tareas
        /// </summary>
        /// <returns></returns>
        public List<Models.clsTarea> getTareas()
        {
            try
            {
                using (Entity.NorthwindEntities obnorthwindEntities = new Entity.NorthwindEntities())
                {
                    return (from q in obnorthwindEntities.Tarea
                            select new Models.clsTarea
                            {
                                incodTarea = q.tareaCodigo,
                                sttareaTitular = q.tareaTitular,
                                sttareaAsunto = q.tareaAsunto,
                                sttareaDescripcion = q.tareaDescripcion,
                                sttareaContacto = q.tareaContacto,
                                sttareaCuenta = q.tareaCuenta,
                                chtareaEnviar_Tarea = Convert.ToChar(q.tareaEnviarMensaje),
                                sttareaFechaVencimiento = q.tareaFechaVencimiento,
                                chtareaRepetir_Tarea = Convert.ToChar(q.tareaRepetir),
                                obclsEstadoTarea = new Models.clsEstadoTarea
                                {
                                    inCodigo = Convert.ToInt32(q.estadoCodigo)
                                },
                                obclsprioridad = new Models.clsPrioridad
                                {
                                    prioCodigp = Convert.ToInt32(q.prioridaCodigo)
                                }

                            }).ToList();
                }

            }
            catch (Exception ex) { throw ex; }

        }
        /// <summary>
        /// Consulta de una tarea
        /// </summary>
        /// <param name="obclsTarea">Modelo de tareas</param>
        /// <returns></returns>
        public List<Models.clsTarea> getTareas(Models.clsTarea obclsTarea )
        {
            try
            {
                using (Entity.NorthwindEntities obnorthwindEntities = new Entity.NorthwindEntities())
                {
                    return (from q in obnorthwindEntities.Tarea
                            where q.tareaCodigo == obclsTarea.incodTarea
                            select new Models.clsTarea
                            {
                                incodTarea = q.tareaCodigo,
                                sttareaTitular = q.tareaTitular,
                                sttareaAsunto = q.tareaAsunto,
                                sttareaDescripcion = q.tareaDescripcion,
                                sttareaContacto = q.tareaContacto,
                                sttareaCuenta = q.tareaCuenta,
                                chtareaEnviar_Tarea = Convert.ToChar(q.tareaEnviarMensaje),
                                sttareaFechaVencimiento = q.tareaFechaVencimiento,
                                chtareaRepetir_Tarea = Convert.ToChar(q.tareaRepetir),
                                obclsEstadoTarea = new Models.clsEstadoTarea
                                {
                                    inCodigo = Convert.ToInt32(q.estadoCodigo)
                                },
                                obclsprioridad = new Models.clsPrioridad
                                {
                                    prioCodigp = Convert.ToInt32(q.prioridaCodigo)
                                }

                            }).ToList();
                }

            }
            catch (Exception ex) { throw ex; }

        }
    }
}
