using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTTipo_naturaleza
    {

        conexion con = new conexion();

        public List<Entidades.Tipo_de_naturaleza> ListarNaturalezas()
        {
            List<Entidades.Tipo_de_naturaleza> listaNaturalezas = new List<Entidades.Tipo_de_naturaleza>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Tipos_naturaleza;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Tipo_de_naturaleza a = new Entidades.Tipo_de_naturaleza()
                    {



                        Id_naturalezaCuenta = Convert.ToInt32(idr["id_naturalezaCuenta"]),
                        NombreNaturaleza = idr["nombreNaturaleza"].ToString(),
                        Descripcion_naturaleza = idr["descripcion_naturaleza"].ToString(),
                        Activo = Convert.ToInt32(idr["activo"]),
                     



                    };

                    listaNaturalezas.Add(a);

                }
                idr.Close();

                return listaNaturalezas;
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
            return listaNaturalezas;
        }
        public DTTipo_naturaleza()
        {
        }
    }
}
