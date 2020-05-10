using System;
namespace Contabilidad_General.Entidades
{
    public class Periodo_contable
    {
        private int idPeriodos_contables;
        private String codigoPeriodo;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int activo;
        private String detalles_empresa_id_empresa;
        private int usuario_idUsuario;

        public int IdPeriodos_contables { get => idPeriodos_contables; set => idPeriodos_contables = value; }
        public String CodigoPeriodo { get => codigoPeriodo; set => codigoPeriodo = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Activo { get => activo; set => activo = value; }
        public  String Detalles_empresa_id_empresa { get => detalles_empresa_id_empresa; set => detalles_empresa_id_empresa = value; }
        public int Usuario_idUsuario { get => usuario_idUsuario; set => usuario_idUsuario = value; }

        public Periodo_contable()
        {
        }
    }
}
