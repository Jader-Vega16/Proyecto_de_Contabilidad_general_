using System;
namespace Contabilidad_General.Entidades
{
    public class Libro_diario
    {
        private int idLibro_diario;
        private DateTime fecha_libroDiario;
        private String concepto_movimiento;
        private float totalDebe;
        private float totalHaber;
        private int activo;
        private int usuario_idUsuario;
        private String detalles_empresa_id_empresa;
        private int asiento_contable_idAsiento;
        private int catalogo_cuentas_idCatalogo_cuentas;
        private int periodos_contables_idPeriodos_contables;


        public int IdLibro_diario { get => idLibro_diario; set => idLibro_diario = value; }
        public DateTime Fecha_libroDiario { get => fecha_libroDiario; set => fecha_libroDiario = value; }
        public float TotalHaber { get => totalHaber; set => totalHaber = value; }
        public float TotalDebe { get => totalDebe; set => totalDebe = value; }
        public String Concepto_movimiento { get => concepto_movimiento; set => concepto_movimiento = value; }
        public int Activo { get => activo; set => activo = value; }
        public int Usuario_idUsuario { get => usuario_idUsuario; set => usuario_idUsuario = value; }
        public String Detalles_empresa_id_empresa { get => detalles_empresa_id_empresa; set => detalles_empresa_id_empresa = value; }
        public int Asiento_contable_idAsiento { get => asiento_contable_idAsiento; set => asiento_contable_idAsiento = value; }
        public int Catalogo_cuentas_idCatalogo_cuentas { get => catalogo_cuentas_idCatalogo_cuentas; set => catalogo_cuentas_idCatalogo_cuentas = value; }
        public int Periodos_contables_idPeriodos_contables { get => periodos_contables_idPeriodos_contables; set => periodos_contables_idPeriodos_contables = value; }

        public Libro_diario()
        {
        }
    }
}
