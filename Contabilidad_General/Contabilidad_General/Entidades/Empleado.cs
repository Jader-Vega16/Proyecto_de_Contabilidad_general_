using System;
namespace Contabilidad_General.Entidades
{
    public class Empleado
    {
        private String idEmpleado;
        private DateTime fecha_ingreso;
        private String cedula;
        private String nombre_cargo;
        private String nombre_empleado;
        private String apellido_empleado;
        private String telefono_empleado;
        private String celular_empleado;
        private String correo_empleado;
        private String direccion_empleado;
        private float sueldo;
        private int activo;

        public String IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public String Cedula { get => cedula; set => cedula = value; }
        public String Nombre_cargo { get => nombre_cargo; set => nombre_cargo = value; }
        public String Nombre_empleado { get => nombre_empleado; set => nombre_empleado = value; }
        public String Apellido_empleado { get => apellido_empleado; set => apellido_empleado = value; }
        public String Telefono_empleado { get => telefono_empleado; set => telefono_empleado = value; }
        public String Celular_empleado { get => celular_empleado; set => celular_empleado = value; }
        public String Correo_empleado { get => correo_empleado; set => correo_empleado = value; }
        public String Direccion_empleado { get => direccion_empleado; set => direccion_empleado = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public int Activo { get => activo; set => activo = value; }

        public Empleado()
        {
        }
    }
}
