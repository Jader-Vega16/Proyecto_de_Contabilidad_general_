using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTPeriodo_Contable
    {
        conexion con = new conexion();

        public List<Entidades.Periodo_contable> ListarPeriodos_Contables()
        {
            List<Entidades.Periodo_contable> listaPeriodos_Contables = new List<Entidades.Periodo_contable>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Periodos_contables;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Periodo_contable a = new Entidades.Periodo_contable()
                    {

                        IdPeriodos_contables = Convert.ToInt32(idr["idPeriodos_contables"]),
                        CodigoPeriodo = idr["codigoPeriodo"].ToString(),
                        Fecha_inicio = Convert.ToDateTime(idr["fecha_incio"]),
                        Fecha_fin = Convert.ToDateTime(idr["fecha_fin"]),
                        Activo = Convert.ToInt32(idr["activo"]),
                        Detalles_empresa_id_empresa = idr["Detalles_empresa_id_empresa"].ToString(),
                        Usuario_idUsuario = Convert.ToInt32(idr["Usuario_idUsuario"]),


                    };

                    listaPeriodos_Contables.Add(a);

                }
                idr.Close();

                return listaPeriodos_Contables;
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
            return listaPeriodos_Contables;
        }





        public DTPeriodo_Contable()
        {
        }
    }
}
