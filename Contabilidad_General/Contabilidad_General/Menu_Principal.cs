using System;
using Gtk;

namespace Contabilidad_General
{
    public partial class Menu_Principal : Gtk.Window
    {
        public Menu_Principal() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnGenerarEmpresaClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Generar_Empresa conta = new Contabilidad_General.Generar_Empresa();
            conta.Show();
        }

        protected void OnBtnControlEmpresaClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Empresa conta = new Contabilidad_General.Control_de_Empresa();
            conta.Show();
        }

        protected void OnBtnBalanceGeneralClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Balance_General conta = new Contabilidad_General.Balance_General();
            conta.Show();
        }

        protected void OnBtnBalanceComprobacionClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Balance_de_Comprobacion conta = new Contabilidad_General.Balance_de_Comprobacion();
            conta.Show();
        }

        protected void OnBtnControlEmpleadosClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Empleados conta = new Contabilidad_General.Control_de_Empleados();
            conta.Show();
        }

        protected void OnBtnControlUsuarioRolClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Usuarios_con_Rol conta = new Contabilidad_General.Control_de_Usuarios_con_Rol();
            conta.Show();
        }

        protected void OnBtnControlMonedasClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Monedas conta = new Contabilidad_General.Control_de_Monedas();
            conta.Show();
        }

        protected void OnBtnControlUsuariosClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Usuarios conta = new Contabilidad_General.Control_de_Usuarios();
            conta.Show();
        }

        protected void OnBtnPeriodosContablesClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Periodos_Contables conta = new Contabilidad_General.Control_de_Periodos_Contables();
            conta.Show();
        }

        protected void OnBtnCatalogoCuentasClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Control_de_Catalogo_de_Cuentas conta = new Contabilidad_General.Control_de_Catalogo_de_Cuentas();
            conta.Show();

        }

        protected void OnBtnAsientosContablesClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Menu_de_Asientos_Contables conta = new Contabilidad_General.Menu_de_Asientos_Contables();
            conta.Show();
        }

        protected void OnBtnLibrosDiariosClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Menu_de_Libros_diarios conta = new Contabilidad_General.Menu_de_Libros_diarios();
            conta.Show();

        }

        protected void OnBtnLibroMayorClicked(object sender, EventArgs e)
        {
            Contabilidad_General.Menu_de_Libros_Mayores conta = new Contabilidad_General.Menu_de_Libros_Mayores();
            conta.Show();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            Application.Quit();


        }
    }
}
