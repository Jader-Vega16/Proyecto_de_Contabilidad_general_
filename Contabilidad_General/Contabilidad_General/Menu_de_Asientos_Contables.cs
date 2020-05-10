using System;
namespace Contabilidad_General
{
    public partial class Menu_de_Asientos_Contables : Gtk.Window
    {
        public Menu_de_Asientos_Contables() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnControldeAsientosClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Asientos_Contables conta = new Contabilidad_General.Control_de_Asientos_Contables();
            conta.Show();
            this.Destroy();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnBtnAgregarAsientoClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Agregar_Asiento_contable conta = new Contabilidad_General.Agregar_Asiento_contable();
            conta.Show();
            this.Destroy();
        }
    }
}
