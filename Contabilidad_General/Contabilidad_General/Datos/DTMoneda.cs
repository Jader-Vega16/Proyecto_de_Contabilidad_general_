using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;
namespace Contabilidad_General.Datos
{
    public class DTMoneda
    {
        conexion con = new conexion();

        public List<Entidades.Moneda> ListarMonedas()
        {
            List<Entidades.Moneda> listaMoneda = new List<Entidades.Moneda>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Tabla_moneda;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Moneda a = new Entidades.Moneda()
                    {



                        Id_moneda = Convert.ToInt32(idr["id_moneda"]),
                        Nombre_moneda = idr["nombre_moneda"].ToString(),
                        Codigo_ISO_Alfab = idr["cod_ISO_Alfab"].ToString(),
                        Pais = idr["pais"].ToString(),
                        Tasa_conversion = (float)Convert.ToDouble(idr["tasa_conversion"]),
                        Activo = Convert.ToInt32(idr["activo"]),
                        Usuario_idUsuario  = Convert.ToInt32(idr["Usuario_idUsuario"]),
                        Detalles_empresa_id_empresa = idr["Detalles_empresa_id_empresa"].ToString(),




                    };

                    listaMoneda.Add(a);

                }
                idr.Close();

                return listaMoneda;
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
            return listaMoneda;
        }



        public DTMoneda()
        {
        }
    }
}
