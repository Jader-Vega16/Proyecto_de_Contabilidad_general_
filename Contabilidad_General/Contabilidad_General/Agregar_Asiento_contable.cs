using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Agregar_Asiento_contable : Gtk.Window
    {
        public Agregar_Asiento_contable() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarcmbIDEmpresa();
            llenarcmbIDUsuario();
            llenarTreeviewHaber();
            llenarTreeviewDebe();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Contabilidad_General.Menu_de_Asientos_Contables conta = new Contabilidad_General.Menu_de_Asientos_Contables();
            conta.Show();
        }

        ListStore cmUsuario = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDUsuario()
        {
            DTUsuario dta = new DTUsuario();
            List<Entidades.Usuario> listacmb = new List<Entidades.Usuario>();
            listacmb = dta.ListarUsuarios();

            foreach (Entidades.Usuario a in listacmb)
            {
                cmUsuario.AppendValues(a.Usuario_.ToString());
            }
            cmbIDUsuario.Model = cmUsuario;
        }

        ListStore cmEmpresa = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDEmpresa()
        {
            DTEmpresa dta = new DTEmpresa();
            List<Entidades.Empresa> listacmb = new List<Entidades.Empresa>();
            listacmb = dta.ListarEmpresas();

            foreach (Entidades.Empresa a in listacmb)
            {
                cmEmpresa.AppendValues(a.Nombre_empresa.ToString());
            }
            cmbIDEmpresa.Model = cmEmpresa;
        }





        ListStore lsHaber = new ListStore(typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeviewHaber()
        {
            Datos.DTCatalogoCuentas dta = new Datos.DTCatalogoCuentas();
            List<Entidades.Catalogo_de_cuenta> lista = new List<Entidades.Catalogo_de_cuenta>();
            lista = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in lista)
            {
                lsHaber.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
            }

            //Crear el modelo de datos
            tvCuentasHaber.Model = lsHaber;

            tvCuentasHaber.AppendColumn("Numero", new CellRendererText(), "text", 1);
            tvCuentasHaber.AppendColumn("Nombre", new CellRendererText(), "text", 2);


        }


        ListStore lsDebe = new ListStore(typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeviewDebe()
        {
            Datos.DTCatalogoCuentas dta = new Datos.DTCatalogoCuentas();
            List<Entidades.Catalogo_de_cuenta> lista = new List<Entidades.Catalogo_de_cuenta>();
            lista = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in lista)
            {
                lsDebe.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
            }

            //Crear el modelo de datos
            tvtCuentasDebe.Model = lsDebe;

            tvtCuentasDebe.AppendColumn("Numero", new CellRendererText(), "text", 1);
            tvtCuentasDebe.AppendColumn("Nombre", new CellRendererText(), "text", 2);


        }

        protected void OnTvtCuentasDebeRowActivated(object o, RowActivatedArgs args)
        {

            var model = tvtCuentasDebe.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idCatalogo_cuentas = model.GetValue(iter, 0);
            var numero_cuenta = model.GetValue(iter, 1);
     



            this.txtCatalgoDeCuentas.Text = Convert.ToString(idCatalogo_cuentas);
            this.txtIDCuentaDebe.Text = numero_cuenta.ToString();
            this.txtIDCuentaHaber.Text = "-";
            this.txtImporteHaber.Text = "0";


        }

        protected void OnTvCuentasHaberRowActivated(object o, RowActivatedArgs args)
        {

            var model = tvCuentasHaber.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idCatalogo_cuentas = model.GetValue(iter, 0);
            var numero_cuenta = model.GetValue(iter, 1);




            this.txtCatalgoDeCuentas.Text = Convert.ToString(idCatalogo_cuentas);
            this.txtIDCuentaHaber.Text = numero_cuenta.ToString();
            this.txtIDCuentaDebe.Text = "-";
            this.txtImporteDebe.Text = "0";
        }

        protected void OnBtnNuevoElementoClicked(object sender, EventArgs e)
        {
            this.txtCatalgoDeCuentas.Text = "";
            this.txtImporteDebe.Text = "";
            this.txtImporteHaber.Text = "";
            this.txtIDCuentaDebe.Text = "";
            this.txtIDCuentaHaber.Text = "";
        }

        protected void OnBtnNuevoAsientoClicked(object sender, EventArgs e)
        {
            this.txtCatalgoDeCuentas.Text = "";
            this.txtImporteDebe.Text = "";
            this.txtImporteHaber.Text = "";
            this.txtIDCuentaDebe.Text = "";
            this.txtIDCuentaHaber.Text = "";
            this.txtFecha.Text = "";
            this.txtCodigoAsiento.Text = "";
        }
    }
}
