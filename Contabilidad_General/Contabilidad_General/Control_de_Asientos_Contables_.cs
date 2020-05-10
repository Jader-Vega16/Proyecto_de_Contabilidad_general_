using System;
namespace Contabilidad_General
{
    public partial class Control_de_Asientos_Contables_ : Gtk.Window
    {
        public Control_de_Asientos_Contables_() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
