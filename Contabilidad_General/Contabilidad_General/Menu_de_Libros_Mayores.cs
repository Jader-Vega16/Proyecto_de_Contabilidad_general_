using System;
namespace Contabilidad_General
{
    public partial class Menu_de_Libros_Mayores : Gtk.Window
    {
        public Menu_de_Libros_Mayores() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnControlLibrosMayoresClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Libro_Mayor conta = new Contabilidad_General.Control_de_Libro_Mayor();
            conta.Show();
            this.Destroy();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnBtnAgregarLibrosMayoresClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Agregar_Libro_mayor conta = new Contabilidad_General.Agregar_Libro_mayor();
            conta.Show();
            this.Destroy();
        }
    }
}
