using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;
namespace Contabilidad_General.Datos
{
    public class DTRol
    {

        conexion con = new conexion();

        public List<Entidades.Rol> ListarRoles()
        {
            List<Entidades.Rol> listaRol= new List<Entidades.Rol>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Rol;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Rol a = new Entidades.Rol()
                    {



                        IdRol = Convert.ToInt32(idr["idRol"]),
                        Nombre = idr["nombre"].ToString(),
                       




                    };

                    listaRol.Add(a);

                }
                idr.Close();

                return listaRol;
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
            return listaRol;
        }




        public DTRol()
        {
        }
    }
}
