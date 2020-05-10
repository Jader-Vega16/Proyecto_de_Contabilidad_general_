using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTAsiento_Contable
    {


        conexion con = new conexion();

        public List<Entidades.Asiento_contable> ListarAsientos()
        {
            List<Entidades.Asiento_contable> listaAsientos = new List<Entidades.Asiento_contable>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Asiento_contable;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Asiento_contable a = new Entidades.Asiento_contable()
                    {



                        IdAsiento = Convert.ToInt32(idr["idAsiento"]),
                        CodigoAsiento = Convert.ToInt32(idr["codigoAsiento"]),
                        CuentaDebeID = idr["cuentaDebeID"].ToString(),
                        ImporteDebe = (float)Convert.ToDouble(idr["importeDebe"]),
                        CuentaHaberID = idr["cuentaHaberID"].ToString(),
                        ImporteHaber = (float)Convert.ToDouble(idr["importeHaber"]),
                        Activo = Convert.ToInt32(idr["activo"]),
                        Fecha_asiento = Convert.ToDateTime(idr["fecha_asiento"]),
                        Catalogo_cuentas_idCatalogo_cuentas = Convert.ToInt32(idr["Catalogo_cuentas_idCatalogo_cuentas"]),
                        Usuario_idUsuario = Convert.ToInt32(idr["Usuario_idUsuario"]),
                        Detalles_empresa_id_empresa = idr["Detalles_empresa_id_empresa"].ToString(),




                    };

                    listaAsientos.Add(a);

                }
                idr.Close();

                return listaAsientos;
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
            return listaAsientos;
        }
        public DTAsiento_Contable()
        {
        }
    }
}
