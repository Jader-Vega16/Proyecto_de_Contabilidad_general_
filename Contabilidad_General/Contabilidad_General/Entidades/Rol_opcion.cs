using System;
namespace Contabilidad_General.Entidades
{
    public class Rol_opcion
    {
        private int idRolOpc;
        private int habilitado;
        private DateTime fechaCreacion;
        private int rol_idRol;
        private int tabla_opciones_idOpciones;

        public int IdRolOpc { get => idRolOpc; set => idRolOpc = value; }
        public int Habilitado { get => habilitado; set => habilitado = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int Rol_idRol { get => rol_idRol; set => rol_idRol = value; }
        public int Tabla_opciones_idOpciones { get => tabla_opciones_idOpciones; set => tabla_opciones_idOpciones = value; }

        public Rol_opcion()
        {
        }
    }
}
