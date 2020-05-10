using System;
namespace Contabilidad_General.Entidades
{
    public class Rol
    {
        private int idRol;
        private String nombre;

        public int IdRol { get => idRol; set => idRol = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public Rol()
        {
        }
    }
}
