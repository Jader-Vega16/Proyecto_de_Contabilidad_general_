using System;
namespace Contabilidad_General.Entidades
{
    public class Opcion
    {
        private int idOpciones;
        private String nombre_opcion;
        private String formulario_opcion;

        public int IdOpciones { get => idOpciones; set => idOpciones = value; }
        public String Nombre_opcion { get => nombre_opcion; set => nombre_opcion = value; }
        public String Formulario_opcion { get => formulario_opcion; set => formulario_opcion = value; }

        public Opcion()
        {
        }
    }
}
