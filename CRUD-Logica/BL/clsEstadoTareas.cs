﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CRUD_Logica.BL
{
    public class clsEstadoTareas
    {
        SqlConnection sqlConnection = null;// me permite establecer comunicacion con la base de datos
        SqlCommand sqlCommand = null;// me permite establecer comandos SQL
        SqlDataAdapter sqlDataAdapter = null; // me permite adaptar conjunto de datos
        string sConexion = string.Empty;// cadena de conexion
        

      
        public clsEstadoTareas()
        {
            clsConexion cls_conexion = new clsConexion();
            sConexion = cls_conexion.getConexion();
        }
        /// <summary>
        /// ESTADO TAREAS 
        /// </summary>
        /// <returns>Registro Estado Tareas</returns>
        public DataSet getConsultaEstadoTareas()
        {
            try
            {
                DataSet dtConsulta = new DataSet();
                sqlConnection = new SqlConnection(sConexion);
                sqlConnection.Open();
                sqlCommand = new SqlCommand("spConsultarEstadoTareas", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtConsulta);
                return dtConsulta;

            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnection.Close(); }
        }
    }
}
