using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Libro_Diario : Gtk.Window
    {
        public Control_de_Libro_Diario() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDAsiento();
            llenarcmbIDEmpresa();
            llenarcmbIDUsuario();
            llenarcmbIDCatalogo();
            llenarcmbIDPeriodo();
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

            tvLibroDiario.AppendColumn("idLibro_diario", new CellRendererText(), "text", 0);
            tvLibroDiario.AppendColumn("fecha_libroDiario", new CellRendererText(), "text", 1);
            tvLibroDiario.AppendColumn("concepto_movimiento", new CellRendererText(), "text", 2);
            tvLibroDiario.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroDiario.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroDiario.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvLibroDiario.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvLibroDiario.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvLibroDiario.AppendColumn("Asiento_contable_idAsiento", new CellRendererText(), "text", 8);
            tvLibroDiario.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroDiario.AppendColumn("Periodos_contables_idPeriodos_contables", new CellRendererText(), "text", 10);













        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Contabilidad_General.Menu_de_Libros_diarios conta = new Contabilidad_General.Menu_de_Libros_diarios();
            conta.Show();

        }

        protected void OnTvLibroDiarioRowActivated(object o, RowActivatedArgs args)
        {
            var model = tvLibroDiario.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idLibro_diario = model.GetValue(iter, 0);
            var fecha_libroDiario = model.GetValue(iter, 1);
            var concepto_movimiento = model.GetValue(iter, 2);
            var totalDebe = model.GetValue(iter, 3);
            var totalHaber = model.GetValue(iter, 4);

            this.txtIDLibroDiario.Text = Convert.ToString(idLibro_diario);
            this.txtFechaLibroDiario.Text = fecha_libroDiario.ToString();
            this.txtConceptoMovimiento.Text = concepto_movimiento.ToString();
            this.txtTotalDebe.Text = totalDebe.ToString();
            this.txtTotalHaber.Text = totalHaber.ToString();
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


        ListStore cmIDAsiento = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDAsiento()
        {
            DTAsiento_Contable dta = new DTAsiento_Contable();
            List<Entidades.Asiento_contable> listacmb = new List<Entidades.Asiento_contable>();
            listacmb = dta.ListarAsientos();

            foreach (Entidades.Asiento_contable a in listacmb)
            {
                cmIDAsiento.AppendValues(a.CodigoAsiento.ToString());
            }
            cmbIDAsiento.Model = cmIDAsiento;
        }


        ListStore cmCatalogo = new ListStore(typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDCatalogo()
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
            cmbIDPeriodoContable.Model = cmPeriodo;
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



        public void llenarTreeporBusquedaID(int busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTLibro_Diario dta = new DTLibro_Diario();

            List<Entidades.Libro_diario> lista = new List<Entidades.Libro_diario>();
            lista = dta.ListarLibroDiario();

            foreach (Entidades.Libro_diario a in lista)
            {
                if (busqueda == a.IdLibro_diario)
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

            tvLibroDiario.AppendColumn("idLibro_diario", new CellRendererText(), "text", 0);
            tvLibroDiario.AppendColumn("fecha_libroDiario", new CellRendererText(), "text", 1);
            tvLibroDiario.AppendColumn("concepto_movimiento", new CellRendererText(), "text", 2);
            tvLibroDiario.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroDiario.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroDiario.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvLibroDiario.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvLibroDiario.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvLibroDiario.AppendColumn("Asiento_contable_idAsiento", new CellRendererText(), "text", 8);
            tvLibroDiario.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroDiario.AppendColumn("Periodos_contables_idPeriodos_contables", new CellRendererText(), "text", 10);

        }

        protected void OnBtnBuscarIDClicked(object sender, EventArgs e)
        {
            int IDBusqueda = int.Parse(txtBuscarID.Text);
            llenarTreeporBusquedaID(IDBusqueda);
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

            tvLibroDiario.AppendColumn("idLibro_diario", new CellRendererText(), "text", 0);
            tvLibroDiario.AppendColumn("fecha_libroDiario", new CellRendererText(), "text", 1);
            tvLibroDiario.AppendColumn("concepto_movimiento", new CellRendererText(), "text", 2);
            tvLibroDiario.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroDiario.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroDiario.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvLibroDiario.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvLibroDiario.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvLibroDiario.AppendColumn("Asiento_contable_idAsiento", new CellRendererText(), "text", 8);
            tvLibroDiario.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroDiario.AppendColumn("Periodos_contables_idPeriodos_contables", new CellRendererText(), "text", 10);

        }

        protected void OnBtnBuscarFechaClicked(object sender, EventArgs e)
        {

            DateTime fechaBusqueda = DateTime.Parse(txtBuscarFecha.Text);
            llenarTreeporBusquedaFecha(fechaBusqueda);
        }
    }
}
