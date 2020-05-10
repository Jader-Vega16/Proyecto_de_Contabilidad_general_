using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTUsuario
    {

        conexion con = new conexion();

        public List<Entidades.Usuario> ListarUsuarios()
        {
            List<Entidades.Usuario> listaUsuario = new List<Entidades.Usuario>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Usuario;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Usuario a = new Entidades.Usuario()
                    {

                        IdUsuario = Convert.ToInt32(idr["idUsuario"]),
                        Usuario_ = idr["usuario"].ToString(),
                        Pwd = idr["pwd"].ToString(),
                        FechaCreacion = Convert.ToDateTime(idr["fechaCreacion"]),
                        Activo = Convert.ToInt32(idr["activo"]),
                        Empleados_idEmpleado = idr["Empleados_idEmpleado"].ToString(),
                        Detalles_empresa_id_empresa = idr["Detalles_empresa_id_empresa"].ToString(),


                    };

                    listaUsuario.Add(a);

                }
                idr.Close();

                return listaUsuario;
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
            return listaUsuario;
        }




        public DTUsuario()
        {
        }
    }
}
