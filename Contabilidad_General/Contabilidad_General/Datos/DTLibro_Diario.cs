using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;
namespace Contabilidad_General.Datos
{
    public class DTLibro_Diario
    {
        conexion con = new conexion();

        public List<Entidades.Libro_diario> ListarLibroDiario()
        {
            List<Entidades.Libro_diario> listaLibrosDiarios = new List<Entidades.Libro_diario>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Libro_diario;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Libro_diario a = new Entidades.Libro_diario()
                    {



                        IdLibro_diario = Convert.ToInt32(idr["idLibro_diario"]),
                        Fecha_libroDiario = Convert.ToDateTime(idr["fecha_libroDiario"]),
                        Concepto_movimiento = idr["concepto_movimiento"].ToString(),
                        TotalDebe = (float)Convert.ToDouble(idr["totalDebe"]),
                        TotalHaber = (float)Convert.ToDouble(idr["totalHaber"]),
                        Activo = Convert.ToInt32(idr["activo"]),
                        Usuario_idUsuario = Convert.ToInt32(idr["Usuario_idUsuario"]),
                        Detalles_empresa_id_empresa = idr["Detalles_empresa_id_empresa"].ToString(),
                        Asiento_contable_idAsiento = Convert.ToInt32(idr["Asiento_contable_idAsiento"]),
                        Catalogo_cuentas_idCatalogo_cuentas = Convert.ToInt32(idr["Catalogo_cuentas_idCatalogo_cuentas"]),
                        Periodos_contables_idPeriodos_contables = Convert.ToInt32(idr["Periodos_contables_idPeriodos_contables"]),





                    };

                    listaLibrosDiarios.Add(a);

                }
                idr.Close();

                return listaLibrosDiarios;
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
            return listaLibrosDiarios;
        }



        public DTLibro_Diario()
        {
        }
    }
}
