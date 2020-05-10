using System;
namespace Contabilidad_General.Entidades
{
    public class Usuario_con_rol
    {
        private int idusuario_rol;
        private DateTime fechaCreacion;
        private int usuario_idUsuario;
        private int rol_idRol;

        public int Idusurio_rol { get => idusuario_rol; set => idusuario_rol = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Usuario_idUsuario { get => usuario_idUsuario; set => usuario_idUsuario = value; }
        public int Rol_idRol { get => rol_idRol; set => rol_idRol = value; }
        public Usuario_con_rol()
        {
        }
    }
}
