using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Agregar_Libro_mayor : Gtk.Window
    {
        public Agregar_Libro_mayor() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarcmbIDUsuario();
            llenarcmbIDEmpresa();
            llenarcmbIDPeriodo();
            llenarTreeview();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Contabilidad_General.Menu_de_Libros_Mayores conta = new Contabilidad_General.Menu_de_Libros_Mayores();
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
            cmbEmpresa.Model = cmEmpresa;
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

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));


        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTLibro_Diario dta = new Datos.DTLibro_Diario();
            List<Entidades.Libro_diario> lista = new List<Entidades.Libro_diario>();
            lista = dta.ListarLibroDiario();

            foreach (Entidades.Libro_diario a in lista)
            {
                ls.AppendValues(a.IdLibro_diario.ToString(), a.Fecha_libroDiario.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
            }

            //Crear el modelo de datos

            tvLibroDiario.Model = ls;

            tvLibroDiario.AppendColumn("fecha", new CellRendererText(), "text", 1);
            tvLibroDiario.AppendColumn("concepto", new CellRendererText(), "text", 2);
            tvLibroDiario.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroDiario.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroDiario.AppendColumn("IdAsiento", new CellRendererText(), "text", 8);
            tvLibroDiario.AppendColumn("IdCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroDiario.AppendColumn("IdPeriodos_contables", new CellRendererText(), "text", 10);







        }

        protected void OnTvLibroDiarioRowActivated(object o, RowActivatedArgs args)
        {

            var model = tvLibroDiario.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);


            var concepto_movimiento = model.GetValue(iter, 2);
            var totalDebe = model.GetValue(iter, 3);
            var totalHaber = model.GetValue(iter, 4);
            var Asiento_contable_idAsiento = model.GetValue(iter, 8);
            var Catalogo_cuentas_idCatalogo_cuentas = model.GetValue(iter, 9);

            this.txtConcepto.Text = concepto_movimiento.ToString();
            this.txtTotalDebe.Text = totalDebe.ToString();
            this.txtTotalHaber.Text = totalHaber.ToString();
            this.txtIDAsiento.Text = Asiento_contable_idAsiento.ToString();
            this.txtIDCatalogoCuenta.Text = Catalogo_cuentas_idCatalogo_cuentas.ToString();


        }

        protected void OnBtnNuevoElementoClicked(object sender, EventArgs e)
        {
            txtConcepto.Text = "";
            txtTotalDebe.Text = "";
            txtTotalHaber.Text = "";
            txtIDAsiento.Text = "";
            txtIDCatalogoCuenta.Text = "";
        }




        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvLibroDiario.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvLibroDiario.RemoveColumn(tvc);
            }
            ls.Clear();
        }


        public void llenarTreeporBusquedaFecha(DateTime busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTLibro_Diario dta = new DTLibro_Diario();

            List<Entidades.Libro_diario> lista = new List<Entidades.Libro_diario>();
            lista = dta.ListarLibroDiario();

            foreach (Entidades.Libro_diario a in lista)
            {
                if (busqueda == a.Fecha_libroDiario)
                    ls.AppendValues(a.IdLibro_diario.ToString(), a.Fecha_libroDiario.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Libro_diario a in lista)
                {
                    ls.AppendValues(a.IdLibro_diario.ToString(), a.Fecha_libroDiario.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
                }


            }


            //Crear el modelo de datos

            tvLibroDiario.Model = ls;

            tvLibroDiario.AppendColumn("fecha", new CellRendererText(), "text", 1);
            tvLibroDiario.AppendColumn("concepto", new CellRendererText(), "text", 2);
            tvLibroDiario.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroDiario.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroDiario.AppendColumn("IdAsiento", new CellRendererText(), "text", 8);
            tvLibroDiario.AppendColumn("IdCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroDiario.AppendColumn("IdPeriodos_contables", new CellRendererText(), "text", 10);

        }

        protected void OnBtnDefinirClicked(object sender, EventArgs e)
        {
            DateTime fechaBusqueda = DateTime.Parse(txtFecha.Text);
            llenarTreeporBusquedaFecha(fechaBusqueda);
        }
    }
}
