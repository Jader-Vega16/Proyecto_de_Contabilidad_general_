using System;
namespace Contabilidad_General
{
    public partial class Interfaz_de_Usuario : Gtk.Window
    {
        public Interfaz_de_Usuario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
