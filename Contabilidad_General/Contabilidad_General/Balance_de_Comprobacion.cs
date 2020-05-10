using System;
namespace Contabilidad_General
{
    public partial class Balance_de_Comprobacion : Gtk.Window
    {
        public Balance_de_Comprobacion() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnBtnNuevoClicked(object sender, EventArgs e)
        {
            txtFechaFin.Text = "";
            txtFechaInicio.Text = "";
                   }
    }
}
