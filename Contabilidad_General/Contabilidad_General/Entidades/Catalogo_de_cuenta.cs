using System;
namespace Contabilidad_General.Entidades
{
    public class Catalogo_de_cuenta
    {
        private int idCatalogo_cuentas;
        private String numero_cuenta;
        private String nombre_cuenta;
        private String descripcion_cuenta;
        private int activo;
        private String pais_cuenta;
        private int id_cuentaPadre;
        private String detalles_empresa_id_empresa;
        private int tipos_naturaleza_id_naturalezaCuenta;
        private int usuario_idUsuario;

        public int IdCatalogo_cuentas { get => idCatalogo_cuentas; set => idCatalogo_cuentas = value; }
        public String Numero_cuenta { get => numero_cuenta; set => numero_cuenta = value; }
        public String Nombre_cuenta { get => nombre_cuenta; set => nombre_cuenta = value; }
        public String Descripcion_cuenta { get => descripcion_cuenta; set => descripcion_cuenta = value; }
        public int Activo { get => activo; set => activo = value; }
        public String Pais_cuenta { get => pais_cuenta; set => pais_cuenta = value; }
        public int Id_cuentaPadre { get => id_cuentaPadre; set => id_cuentaPadre = value; }
        public String Detalles_empresa_id_empresa { get => detalles_empresa_id_empresa; set => detalles_empresa_id_empresa = value; }
        public int Tipos_naturaleza_id_naturalezaCuenta { get => tipos_naturaleza_id_naturalezaCuenta; set => tipos_naturaleza_id_naturalezaCuenta = value; }
        public int Usuario_idUsuario { get => usuario_idUsuario; set => usuario_idUsuario = value; }


        public Catalogo_de_cuenta()
        {
        }
    }
}
