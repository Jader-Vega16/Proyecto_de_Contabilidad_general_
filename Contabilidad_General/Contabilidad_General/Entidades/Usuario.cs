using System;
namespace Contabilidad_General.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private String usuario;
        private String pwd;
        private DateTime fechaCreacion;
        private int activo;
        private String empleados_idEmpleado;
        private String detalles_empresa_id_empresa;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario_ { get => usuario; set => usuario = value; }
        public String Pwd { get => pwd; set => pwd = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Activo { get => activo; set => activo = value; }
        public String Empleados_idEmpleado { get => empleados_idEmpleado; set => empleados_idEmpleado = value; }
        public String Detalles_empresa_id_empresa { get => detalles_empresa_id_empresa; set => detalles_empresa_id_empresa = value; }


        public Usuario()
        {
        }
    }
}
