using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;
namespace Contabilidad_General
{
    public partial class Agregar_Libro_diario : Gtk.Window
    {
        public Agregar_Libro_diario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDEmpresa();
            llenarcmbIDUsuario();
            llenarcmbIDPeriodo();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Contabilidad_General.Menu_de_Libros_diarios conta = new Contabilidad_General.Menu_de_Libros_diarios();
            conta.Show();
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

            tvAsiento.Model = ls;

            tvAsiento.AppendColumn("codigoAsiento", new CellRendererText(), "text", 1);
            tvAsiento.AppendColumn("cuentaDebeID", new CellRendererText(), "text", 2);
            tvAsiento.AppendColumn("importeDebe", new CellRendererText(), "text", 3);
            tvAsiento.AppendColumn("cuentaHaberID", new CellRendererText(), "text", 4);
            tvAsiento.AppendColumn("importeHaber", new CellRendererText(), "text", 5);
       
        }


        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvAsiento.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvAsiento.RemoveColumn(tvc);
            }
            ls.Clear();
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

        protected void OnTvAsientoRowActivated(object o, RowActivatedArgs args)
        {
            var model = tvAsiento.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);



            var idAsiento = model.GetValue(iter, 0);
          
            var importeDebe = model.GetValue(iter, 3);
            var importeHaber = model.GetValue(iter, 5);
            var catalogo_cuentas_idCatalogo_cuentas = model.GetValue(iter, 8);

            this.txtIDAsiento.Text = Convert.ToString(idAsiento);
            this.txtTotalDebe.Text = importeDebe.ToString();
            this.txtTotalHaber.Text = importeHaber.ToString();
            this.txtIDCatalogo.Text = Convert.ToString(catalogo_cuentas_idCatalogo_cuentas);

        }


        ListStore cmPeriodo = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDPeriodo()
        {
            DTPeriodo_Contable dta = new DTPeriodo_Contable();
            List<Entidades.Periodo_contable> listacmb = new List<Entidades.Periodo_contable>();
            listacmb = dta.ListarPeriodos_Contables();

            foreach (Entidades.Periodo_contable a in listacmb)
            {
                cmPeriodo.AppendValues(a.CodigoPeriodo.ToString());
            }
            cmbIDPeriodo.Model = cmPeriodo;
        }

        protected void OnBtnNuevoLibroClicked(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtConcepto.Text = "";
            txtIDAsiento.Text = "";
            txtTotalDebe.Text = "";
            txtTotalHaber.Text = "";
            txtIDCatalogo.Text = "";
        }

        protected void OnBtnNuevoElementoClicked(object sender, EventArgs e)
        {
            txtIDAsiento.Text = "";
            txtTotalDebe.Text = "";
            txtTotalHaber.Text = "";
            txtIDCatalogo.Text = "";
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

            tvAsiento.Model = ls;

            tvAsiento.AppendColumn("codigoAsiento", new CellRendererText(), "text", 1);
            tvAsiento.AppendColumn("cuentaDebeID", new CellRendererText(), "text", 2);
            tvAsiento.AppendColumn("importeDebe", new CellRendererText(), "text", 3);
            tvAsiento.AppendColumn("cuentaHaberID", new CellRendererText(), "text", 4);
            tvAsiento.AppendColumn("importeHaber", new CellRendererText(), "text", 5);
        }

        protected void OnBtnDefinirClicked(object sender, EventArgs e)
        {
            int codigoBusqueda = int.Parse(txtCodigoAsiento.Text);
            llenarTreeporBusquedaCodigo(codigoBusqueda);
        }
    }







}





