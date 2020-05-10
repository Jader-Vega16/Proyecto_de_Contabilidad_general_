using System;
namespace Contabilidad_General
{
    public partial class Menu_de_Libros_diarios : Gtk.Window
    {
        public Menu_de_Libros_diarios() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnControlLibrosDiariosClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Libro_Diario conta = new Contabilidad_General.Control_de_Libro_Diario();
            conta.Show();
            this.Destroy();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnBtnAgregarLibrosDiariosClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Agregar_Libro_diario conta = new Contabilidad_General.Agregar_Libro_diario();
            conta.Show();
            this.Destroy();

        }
    }
}
