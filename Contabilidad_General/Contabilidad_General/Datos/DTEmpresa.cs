using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTEmpresa
    {
        conexion con = new conexion();

        public List<Entidades.Empresa> ListarEmpresas()
        {
            List<Entidades.Empresa> listaEmpresas = new List<Entidades.Empresa>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Detalles_empresa;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Empresa a = new Entidades.Empresa()
                    {


                        Id_empresa = idr["id_empresa"].ToString(),
                        Nombre_empresa = idr["nombre_empresa"].ToString(),
                        Nombre_comercial= idr["nombre_comercial"].ToString(),
                        Direccion_empresa= idr["direccion_empresa"].ToString(),
                        Localidad_empresa= idr["localidad_empresa"].ToString(),
                        Correo_empresa= idr["correo_empresa"].ToString(),
                        Activo = Convert.ToInt32(idr["activo"]),

                    };

                    listaEmpresas.Add(a);

                }
                idr.Close();

                return listaEmpresas;
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
            return listaEmpresas;
        }


        public DTEmpresa()
        {
        }
    }
}
