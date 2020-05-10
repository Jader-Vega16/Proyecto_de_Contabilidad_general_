using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTEmpleados
    {
        conexion con = new conexion();

        public List<Entidades.Empleado> ListarEmpleados()
        {
            List<Entidades.Empleado> listaEmpleados = new List<Entidades.Empleado>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Empleados;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Empleado a = new Entidades.Empleado()
                    {


                        IdEmpleado = idr["idEmpleado"].ToString(),
                        Fecha_ingreso = Convert.ToDateTime(idr["fecha_ingreso"]),
                        Cedula = idr["cedula"].ToString(),
                        Nombre_cargo = idr["nombre_cargo"].ToString(),
                        Nombre_empleado = idr["nombre_empleado"].ToString(),
                        Apellido_empleado = idr["apellido_empleado"].ToString(),
                        Telefono_empleado =idr["telefono_empleado"].ToString(),
                        Celular_empleado = idr["celular_empleado"].ToString(),
                        Correo_empleado = idr["correo_empleado"].ToString(),
                        Direccion_empleado = idr["direccion_empleado"].ToString(),
                        Sueldo = (float)Convert.ToDouble(idr["sueldo"]),
                        Activo = Convert.ToInt32(idr["activo"]),
                  
                    };

                    listaEmpleados.Add(a);

                }
                idr.Close();

                return listaEmpleados;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                con.Close();
            }
            return listaEmpleados;
        }




        public DTEmpleados()
        {
        }
    }
}
