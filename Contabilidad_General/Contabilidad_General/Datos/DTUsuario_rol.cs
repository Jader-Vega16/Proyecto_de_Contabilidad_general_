using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;
namespace Contabilidad_General.Datos
{
    public class DTUsuario_rol
    {

        conexion con = new conexion();

        public List<Entidades.Usuario_con_rol> ListarUsuariosRol()
        {
            List<Entidades.Usuario_con_rol> listaUsuarioRol = new List<Entidades.Usuario_con_rol>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Usuario_rol;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Usuario_con_rol a = new Entidades.Usuario_con_rol()
                    {

                        Idusurio_rol = Convert.ToInt32(idr["idusuario_rol"]),
                        FechaCreacion = Convert.ToDateTime(idr["fechaCreacion"]),
                        Usuario_idUsuario = Convert.ToInt32(idr["Usuario_idUsuario"]),
                        Rol_idRol = Convert.ToInt32(idr["Rol_idRol"]),



                    };

                    listaUsuarioRol.Add(a);

                }
                idr.Close();

                return listaUsuarioRol;
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
            return listaUsuarioRol;
        }

        public DTUsuario_rol()
        {
        }
    }
}
