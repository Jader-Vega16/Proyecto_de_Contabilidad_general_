using System;
namespace Contabilidad_General.Entidades
{
    public class Empresa
    {
        private String id_empresa;
        private String nombre_empresa;
        private String nombre_comercial;
        private String direccion_empresa;
        private String localidad_empresa;
        private String correo_empresa;
        private int activo;

        public String Id_empresa { get => id_empresa; set => id_empresa = value; }
        public String Nombre_empresa { get => nombre_empresa; set => nombre_empresa = value; }
        public String Nombre_comercial { get => nombre_comercial; set => nombre_comercial = value; }
        public String Direccion_empresa { get => direccion_empresa; set => direccion_empresa = value; }
        public String Localidad_empresa { get => localidad_empresa; set => localidad_empresa = value; }
        public String Correo_empresa { get => correo_empresa; set => correo_empresa = value; }
        public int Activo { get => activo; set => activo = value; }

        public Empresa()
        {
        }
    }
}
