using System;
namespace Contabilidad_General.Entidades
{
    public class Asiento_contable
    {
        private int idAsiento;
        private int codigoAsiento;
        private String cuentaDebeID;
        private float importeDebe;
        private String cuentaHaberID;
        private float importeHaber;
        private int activo;
        private DateTime fecha_asiento;
        private int catalogo_cuentas_idCatalogo_cuentas;
        private int usuario_idUsuario;
        private String detalles_empresa_id_empresa;

        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int CodigoAsiento { get => codigoAsiento; set => codigoAsiento = value; }
        public String CuentaDebeID { get => cuentaDebeID; set => cuentaDebeID = value; }
        public float ImporteDebe { get => importeDebe; set => importeDebe = value; }
        public String CuentaHaberID { get => cuentaHaberID; set => cuentaHaberID = value; }
        public float ImporteHaber { get => importeHaber; set => importeHaber = value; }
        public int Activo { get => activo; set => activo = value; }
        public DateTime Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public int Catalogo_cuentas_idCatalogo_cuentas { get => catalogo_cuentas_idCatalogo_cuentas; set => catalogo_cuentas_idCatalogo_cuentas = value; }
        public int Usuario_idUsuario { get => usuario_idUsuario; set => usuario_idUsuario = value; }
        public String Detalles_empresa_id_empresa { get => detalles_empresa_id_empresa; set => detalles_empresa_id_empresa = value; }

        public Asiento_contable()
        {
        }
    }
}
