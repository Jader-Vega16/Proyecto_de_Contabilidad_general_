using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Contabilidad_General.Entidades;
using MySql.Data.MySqlClient;
using Contabilidad_General.Datos;

namespace Contabilidad_General.Datos
{
    public class DTCatalogoCuentas
    {
        conexion con = new conexion();

        public List<Entidades.Catalogo_de_cuenta> ListarCatalogo()
        {
            List<Entidades.Catalogo_de_cuenta> listaCatalogos = new List<Entidades.Catalogo_de_cuenta>();
            IDataReader idr = null;
            StringBuilder sb = new StringBuilder();
            sb.Append("USE Contabilidad_JPR;");
            sb.Append("Select * from Catalogo_cuentas;");

            try
            {
                con.Open();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    Entidades.Catalogo_de_cuenta a = new Entidades.Catalogo_de_cuenta()
                    {

                        IdCatalogo_cuentas = Convert.ToInt32(idr["idCatalogo_cuentas"]),
                        Numero_cuenta = idr["numero_cuenta"].ToString(),
                        Nombre_cuenta = idr["nombre_cuenta"].ToString(),
                        Descripcion_cuenta = idr["descripcion_cuenta"].ToString(),
                        Activo = Convert.ToInt32(idr["activo"]),
                        Pais_cuenta = idr["pais_cuenta"].ToString(),
                        Id_cuentaPadre = Convert.ToInt32(idr["id_cuentaPadre"]),
                        Detalles_empresa_id_empresa = idr["Detalles_empresa_id_empresa"].ToString(),
                        Tipos_naturaleza_id_naturalezaCuenta = Convert.ToInt32(idr["Tipos_naturaleza_id_naturalezaCuenta"]),
                        Usuario_idUsuario = Convert.ToInt32(idr["Usuario_idUsuario"]),


                    };

                    listaCatalogos.Add(a);

                }
                idr.Close();

                return listaCatalogos;
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
            return listaCatalogos;
        }



        public DTCatalogoCuentas()
        {
        }
    }
}
