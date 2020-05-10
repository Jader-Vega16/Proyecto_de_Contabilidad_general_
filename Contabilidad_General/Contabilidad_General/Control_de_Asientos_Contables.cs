using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;
namespace Contabilidad_General
{
    public partial class Control_de_Asientos_Contables : Gtk.Window
    {
        public Control_de_Asientos_Contables() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDUsuario();
            llenarcmbIDEmpresa();
            llenarcmbIDCuenta();
        }


        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTAsiento_Contable dta = new Datos.DTAsiento_Contable();
            List<Entidades.Asiento_contable> lista = new List<Entidades.Asiento_contable>();
            lista = dta.ListarAsientos();

            foreach (Entidades.Asiento_contable a in lista)
            {
                ls.AppendValues(a.IdAsiento.ToString(), a.CodigoAsiento.ToString(), a.CuentaDebeID.ToString(), a.ImporteDebe.ToString(), a.CuentaHaberID.ToString(), a.ImporteHaber.ToString(), a.Activo.ToString(), a.Fecha_asiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
            }

            //Crear el modelo de datos

            tvAsientosContables.Model = ls;

            tvAsientosContables.AppendColumn("idAsiento", new CellRendererText(), "text", 0);
            tvAsientosContables.AppendColumn("codigoAsiento", new CellRendererText(), "text", 1);
            tvAsientosContables.AppendColumn("cuentaDebeID", new CellRendererText(), "text", 2);
            tvAsientosContables.AppendColumn("importeDebe", new CellRendererText(), "text", 3);
            tvAsientosContables.AppendColumn("cuentaHaberID", new CellRendererText(), "text", 4);
            tvAsientosContables.AppendColumn("importeHaber", new CellRendererText(), "text", 5);
            tvAsientosContables.AppendColumn("activo", new CellRendererText(), "text", 6);
            tvAsientosContables.AppendColumn("fecha_asiento", new CellRendererText(), "text", 7);
            tvAsientosContables.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 8);
            tvAsientosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);
            tvAsientosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 10);


        }






        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Contabilidad_General.Menu_de_Asientos_Contables conta = new Contabilidad_General.Menu_de_Asientos_Contables();
            conta.Show();
        }

        protected void OnTvAsientosContablesRowActivated(object o, Gtk.RowActivatedArgs args)
        {

            var model = tvAsientosContables.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idAsiento = model.GetValue(iter, 0);
            var codigoAsiento = model.GetValue(iter, 1);
            var cuentaDebeID = model.GetValue(iter, 2);
            var importeDebe = model.GetValue(iter, 3);
            var cuentaHaberID = model.GetValue(iter, 4);
            var importeHaber = model.GetValue(iter, 5);
            var fecha_asiento = model.GetValue(iter, 7);

            this.txtIDAsiento.Text = Convert.ToString(idAsiento);
            this.txtCodigoAsiento.Text = Convert.ToString(codigoAsiento);
            this.txtCuentaDebe.Text = cuentaDebeID.ToString();
            this.txtImporteDebe.Text = importeDebe.ToString();
            this.txtCuentaHaber.Text = cuentaHaberID.ToString();
            this.txtImporteHaber.Text = importeHaber.ToString();
            this.txtFechaAsiento.Text = fecha_asiento.ToString();


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



        ListStore cmCatalogo = new ListStore(typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDCuenta()
        {
            DTCatalogoCuentas dta = new DTCatalogoCuentas();
            List<Entidades.Catalogo_de_cuenta> listacmb = new List<Entidades.Catalogo_de_cuenta>();
            listacmb = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in listacmb)
            {
                cmCatalogo.AppendValues(a.Numero_cuenta.ToString());
            }
            cmbIDCatalogoCuentas.Model = cmCatalogo;
        }

        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvAsientosContables.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvAsientosContables.RemoveColumn(tvc);
            }
            ls.Clear();
        }



        public void llenarTreeporBusquedaCodigo(int busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTAsiento_Contable dta = new DTAsiento_Contable();

            List<Entidades.Asiento_contable> lista = new List<Entidades.Asiento_contable>();
            lista = dta.ListarAsientos();

            foreach (Entidades.Asiento_contable a in lista)
            {
                if (busqueda == a.CodigoAsiento)
                    ls.AppendValues(a.IdAsiento.ToString(), a.CodigoAsiento.ToString(), a.CuentaDebeID.ToString(), a.ImporteDebe.ToString(), a.CuentaHaberID.ToString(), a.ImporteHaber.ToString(), a.Activo.ToString(), a.Fecha_asiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Asiento_contable a in lista)
                {
                    ls.AppendValues(a.IdAsiento.ToString(), a.CodigoAsiento.ToString(), a.CuentaDebeID.ToString(), a.ImporteDebe.ToString(), a.CuentaHaberID.ToString(), a.ImporteHaber.ToString(), a.Activo.ToString(), a.Fecha_asiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                }


            }

            //Crear el modelo de datos

            tvAsientosContables.Model = ls;

            tvAsientosContables.AppendColumn("idAsiento", new CellRendererText(), "text", 0);
            tvAsientosContables.AppendColumn("codigoAsiento", new CellRendererText(), "text", 1);
            tvAsientosContables.AppendColumn("cuentaDebeID", new CellRendererText(), "text", 2);
            tvAsientosContables.AppendColumn("importeDebe", new CellRendererText(), "text", 3);
            tvAsientosContables.AppendColumn("cuentaHaberID", new CellRendererText(), "text", 4);
            tvAsientosContables.AppendColumn("importeHaber", new CellRendererText(), "text", 5);
            tvAsientosContables.AppendColumn("activo", new CellRendererText(), "text", 6);
            tvAsientosContables.AppendColumn("fecha_asiento", new CellRendererText(), "text", 7);
            tvAsientosContables.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 8);
            tvAsientosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);
            tvAsientosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 10);
        }

        protected void OnBtnBuscarCodigoClicked(object sender, EventArgs e)
        {
            int codigoBusqueda = int.Parse(txtBuscarCodigo.Text);
            llenarTreeporBusquedaCodigo(codigoBusqueda);
        }



        public void llenarTreeporBusquedaFecha(DateTime busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTAsiento_Contable dta = new DTAsiento_Contable();

            List<Entidades.Asiento_contable> lista = new List<Entidades.Asiento_contable>();
            lista = dta.ListarAsientos();

            foreach (Entidades.Asiento_contable a in lista)
            {
                if (busqueda == a.Fecha_asiento)
                    ls.AppendValues(a.IdAsiento.ToString(), a.CodigoAsiento.ToString(), a.CuentaDebeID.ToString(), a.ImporteDebe.ToString(), a.CuentaHaberID.ToString(), a.ImporteHaber.ToString(), a.Activo.ToString(), a.Fecha_asiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Asiento_contable a in lista)
                {
                    ls.AppendValues(a.IdAsiento.ToString(), a.CodigoAsiento.ToString(), a.CuentaDebeID.ToString(), a.ImporteDebe.ToString(), a.CuentaHaberID.ToString(), a.ImporteHaber.ToString(), a.Activo.ToString(), a.Fecha_asiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                }


            }

            //Crear el modelo de datos

            tvAsientosContables.Model = ls;

            tvAsientosContables.AppendColumn("idAsiento", new CellRendererText(), "text", 0);
            tvAsientosContables.AppendColumn("codigoAsiento", new CellRendererText(), "text", 1);
            tvAsientosContables.AppendColumn("cuentaDebeID", new CellRendererText(), "text", 2);
            tvAsientosContables.AppendColumn("importeDebe", new CellRendererText(), "text", 3);
            tvAsientosContables.AppendColumn("cuentaHaberID", new CellRendererText(), "text", 4);
            tvAsientosContables.AppendColumn("importeHaber", new CellRendererText(), "text", 5);
            tvAsientosContables.AppendColumn("activo", new CellRendererText(), "text", 6);
            tvAsientosContables.AppendColumn("fecha_asiento", new CellRendererText(), "text", 7);
            tvAsientosContables.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 8);
            tvAsientosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);
            tvAsientosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 10);
        }

        protected void OnBtnBuscarFechaClicked(object sender, EventArgs e)
        {

            DateTime fechaBusqueda = DateTime.Parse(txtBuscarFecha.Text);
            llenarTreeporBusquedaFecha(fechaBusqueda);
        }
    }
}
