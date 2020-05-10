using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Libro_Mayor : Gtk.Window
    {
        public Control_de_Libro_Mayor() :
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
            Datos.DTLibro_Mayor dta = new Datos.DTLibro_Mayor();
            List<Entidades.Libro_mayor> lista = new List<Entidades.Libro_mayor>();
            lista = dta.ListarLibroMayor();

            foreach (Entidades.Libro_mayor a in lista)
            {
                ls.AppendValues(a.IdLibro_mayor.ToString(), a.Mes_libro_mayor.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
            }

            //Crear el modelo de datos

            tvLibroMayor.Model = ls;

            tvLibroMayor.AppendColumn("idLibro_mayor", new CellRendererText(), "text", 0);
            tvLibroMayor.AppendColumn("mes_libro_mayor", new CellRendererText(), "text", 1);
            tvLibroMayor.AppendColumn("concepto_movimiento", new CellRendererText(), "text", 2);
            tvLibroMayor.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroMayor.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroMayor.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvLibroMayor.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvLibroMayor.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvLibroMayor.AppendColumn("Asiento_contable_idAsiento", new CellRendererText(), "text", 8);
            tvLibroMayor.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroMayor.AppendColumn("Periodos_contables_idPeriodos_contables", new CellRendererText(), "text", 10);










        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
            Contabilidad_General.Menu_de_Libros_Mayores conta = new Contabilidad_General.Menu_de_Libros_Mayores();
            conta.Show();
        }

        protected void OnTvLibroMayorRowActivated(object o, RowActivatedArgs args)
        {

            var model = tvLibroMayor.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idLibro_mayor = model.GetValue(iter, 0);
            var concepto_movimiento = model.GetValue(iter, 2);
            var totalDebe = model.GetValue(iter, 3);
            var totalHaber = model.GetValue(iter, 4);

            this.txtIDLibroMayor.Text = Convert.ToString(idLibro_mayor);
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
            cmbIDAsientoContable.Model = cmIDAsiento;
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
            cmbIDPeridoContable.Model = cmPeriodo;
        }


        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvLibroMayor.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvLibroMayor.RemoveColumn(tvc);
            }
            ls.Clear();
        }




        public void llenarTreeporBusquedaID(int busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTLibro_Mayor dta = new DTLibro_Mayor();

            List<Entidades.Libro_mayor> lista = new List<Entidades.Libro_mayor>();
            lista = dta.ListarLibroMayor();

            foreach (Entidades.Libro_mayor a in lista)
            {
                if (busqueda == a.IdLibro_mayor)
                    ls.AppendValues(a.IdLibro_mayor.ToString(), a.Mes_libro_mayor.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Libro_mayor a in lista)
                {
                    ls.AppendValues(a.IdLibro_mayor.ToString(), a.Mes_libro_mayor.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
                }


            }


            //Crear el modelo de datos

            tvLibroMayor.Model = ls;

            tvLibroMayor.AppendColumn("idLibro_mayor", new CellRendererText(), "text", 0);
            tvLibroMayor.AppendColumn("mes_libro_mayor", new CellRendererText(), "text", 1);
            tvLibroMayor.AppendColumn("concepto_movimiento", new CellRendererText(), "text", 2);
            tvLibroMayor.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroMayor.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroMayor.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvLibroMayor.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvLibroMayor.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvLibroMayor.AppendColumn("Asiento_contable_idAsiento", new CellRendererText(), "text", 8);
            tvLibroMayor.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroMayor.AppendColumn("Periodos_contables_idPeriodos_contables", new CellRendererText(), "text", 10);



        }

        protected void OnBtnBuscarIDClicked(object sender, EventArgs e)
        {
            int IDBusqueda = int.Parse(txtBuscarID.Text);
            llenarTreeporBusquedaID(IDBusqueda);
        }



        public void llenarTreeporBusquedaMes(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTLibro_Mayor dta = new DTLibro_Mayor();

            List<Entidades.Libro_mayor> lista = new List<Entidades.Libro_mayor>();
            lista = dta.ListarLibroMayor();

            foreach (Entidades.Libro_mayor a in lista)
            {
                if (busqueda == a.Mes_libro_mayor)
                    ls.AppendValues(a.IdLibro_mayor.ToString(), a.Mes_libro_mayor.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Libro_mayor a in lista)
                {
                    ls.AppendValues(a.IdLibro_mayor.ToString(), a.Mes_libro_mayor.ToString(), a.Concepto_movimiento.ToString(), a.TotalDebe.ToString(), a.TotalHaber.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Asiento_contable_idAsiento.ToString(), a.Catalogo_cuentas_idCatalogo_cuentas.ToString(), a.Periodos_contables_idPeriodos_contables.ToString());
                }


            }


            //Crear el modelo de datos

            tvLibroMayor.Model = ls;

            tvLibroMayor.AppendColumn("idLibro_mayor", new CellRendererText(), "text", 0);
            tvLibroMayor.AppendColumn("mes_libro_mayor", new CellRendererText(), "text", 1);
            tvLibroMayor.AppendColumn("concepto_movimiento", new CellRendererText(), "text", 2);
            tvLibroMayor.AppendColumn("totalDebe", new CellRendererText(), "text", 3);
            tvLibroMayor.AppendColumn("totalHaber", new CellRendererText(), "text", 4);
            tvLibroMayor.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvLibroMayor.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvLibroMayor.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvLibroMayor.AppendColumn("Asiento_contable_idAsiento", new CellRendererText(), "text", 8);
            tvLibroMayor.AppendColumn("Catalogo_cuentas_idCatalogo_cuentas", new CellRendererText(), "text", 9);
            tvLibroMayor.AppendColumn("Periodos_contables_idPeriodos_contables", new CellRendererText(), "text", 10);



        }

        protected void OnBtnBuscarMesClicked(object sender, EventArgs e)
        {
            string mesBusqueda = txtBuscarMes.Text;
            llenarTreeporBusquedaMes(mesBusqueda);
        }
    }
}