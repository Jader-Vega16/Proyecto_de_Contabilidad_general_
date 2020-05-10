using System;
namespace Contabilidad_General.Entidades
{
    public class Balance_de_comprobacion
    {
        private DateTime fecha_de_inicio;
        private DateTime fecha_de_fin;

        public DateTime Fecha_de_inicio { get => fecha_de_inicio; set => fecha_de_inicio = value; }
        public DateTime Fecha_de_fin { get => fecha_de_fin; set => fecha_de_fin = value; }

        public Balance_de_comprobacion()
        {
        }
    }
}
