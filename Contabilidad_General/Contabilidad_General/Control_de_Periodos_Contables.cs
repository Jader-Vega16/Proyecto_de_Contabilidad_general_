using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;


namespace Contabilidad_General
{
    public partial class Control_de_Periodos_Contables : Gtk.Window
    {
        public Control_de_Periodos_Contables() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDUsuario();
            llenarcmbIDEmpresa();

        }


        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTPeriodo_Contable dta = new Datos.DTPeriodo_Contable();
            List<Entidades.Periodo_contable> lista = new List<Entidades.Periodo_contable>();
            lista = dta.ListarPeriodos_Contables();

            foreach (Entidades.Periodo_contable a in lista)
            {
                ls.AppendValues(a.IdPeriodos_contables.ToString(), a.CodigoPeriodo.ToString(), a.Fecha_inicio.ToString(), a.Fecha_fin.ToString(), a.Activo.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Usuario_idUsuario.ToString());
            }

            //Crear el modelo de datos
            tvPeriodosContables.Model = ls;

            tvPeriodosContables.AppendColumn("idPeriodos_contables", new CellRendererText(), "text", 0);
            tvPeriodosContables.AppendColumn("codigoPeriodo", new CellRendererText(), "text", 1);
            tvPeriodosContables.AppendColumn("fecha_incio", new CellRendererText(), "text", 2);
            tvPeriodosContables.AppendColumn("fecha_fin", new CellRendererText(), "text", 3);
            tvPeriodosContables.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvPeriodosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 5);
            tvPeriodosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);



        }



        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvPeriodosContablesRowActivated(object o, RowActivatedArgs args)
        {
            var model = tvPeriodosContables.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idPeriodos_contables = model.GetValue(iter, 0);
            var codigoPeriodo = model.GetValue(iter, 1);
            var fecha_inicio = model.GetValue(iter, 2);
            var fecha_fin = model.GetValue(iter, 3);

            this.txtIDPeriodoContable.Text = Convert.ToString(idPeriodos_contables);
            this.txtCodigoPeriodoContable.Text = codigoPeriodo.ToString();
            this.txtFechaInicio.Text = fecha_inicio.ToString();
            this.txtFechaFin.Text = fecha_fin.ToString();




        }

        protected void OnBtnNuevoClicked(object sender, EventArgs e)
        {
            txtIDPeriodoContable.Text = "";
            txtCodigoPeriodoContable.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";


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
        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvPeriodosContables.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvPeriodosContables.RemoveColumn(tvc);
            }
            ls.Clear();
        }


        public void llenarTreeporBusquedaCodigo(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTPeriodo_Contable dta = new DTPeriodo_Contable();

            List<Entidades.Periodo_contable> lista = new List<Entidades.Periodo_contable>();
            lista = dta.ListarPeriodos_Contables();

            foreach (Entidades.Periodo_contable a in lista)
            {
                if (busqueda == a.CodigoPeriodo)
                    ls.AppendValues(a.IdPeriodos_contables.ToString(), a.CodigoPeriodo.ToString(), a.Fecha_inicio.ToString(), a.Fecha_fin.ToString(), a.Activo.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Usuario_idUsuario.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Periodo_contable a in lista)
                {
                    ls.AppendValues(a.IdPeriodos_contables.ToString(), a.CodigoPeriodo.ToString(), a.Fecha_inicio.ToString(), a.Fecha_fin.ToString(), a.Activo.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Usuario_idUsuario.ToString());
                }


            }

            //Crear el modelo de datos
            tvPeriodosContables.Model = ls;

            tvPeriodosContables.AppendColumn("idPeriodos_contables", new CellRendererText(), "text", 0);
            tvPeriodosContables.AppendColumn("codigoPeriodo", new CellRendererText(), "text", 1);
            tvPeriodosContables.AppendColumn("fecha_incio", new CellRendererText(), "text", 2);
            tvPeriodosContables.AppendColumn("fecha_fin", new CellRendererText(), "text", 3);
            tvPeriodosContables.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvPeriodosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 5);
            tvPeriodosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);


        }


        protected void OnBtnBuscarIDClicked(object sender, EventArgs e)
        {
            string codigoBusqueda = txtBuscarID.Text;
            llenarTreeporBusquedaCodigo(codigoBusqueda);
        }



        public void llenarTreeporBusquedaFecha(DateTime busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTPeriodo_Contable dta = new DTPeriodo_Contable();

            List<Entidades.Periodo_contable> lista = new List<Entidades.Periodo_contable>();
            lista = dta.ListarPeriodos_Contables();

            foreach (Entidades.Periodo_contable a in lista)
            {
                if (busqueda == a.Fecha_inicio)
                    ls.AppendValues(a.IdPeriodos_contables.ToString(), a.CodigoPeriodo.ToString(), a.Fecha_inicio.ToString(), a.Fecha_fin.ToString(), a.Activo.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Usuario_idUsuario.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Periodo_contable a in lista)
                {
                    ls.AppendValues(a.IdPeriodos_contables.ToString(), a.CodigoPeriodo.ToString(), a.Fecha_inicio.ToString(), a.Fecha_fin.ToString(), a.Activo.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Usuario_idUsuario.ToString());
                }


            }

            //Crear el modelo de datos
            tvPeriodosContables.Model = ls;

            tvPeriodosContables.AppendColumn("idPeriodos_contables", new CellRendererText(), "text", 0);
            tvPeriodosContables.AppendColumn("codigoPeriodo", new CellRendererText(), "text", 1);
            tvPeriodosContables.AppendColumn("fecha_incio", new CellRendererText(), "text", 2);
            tvPeriodosContables.AppendColumn("fecha_fin", new CellRendererText(), "text", 3);
            tvPeriodosContables.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvPeriodosContables.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 5);
            tvPeriodosContables.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);


        }

        protected void OnBtnBuscarFechaClicked(object sender, EventArgs e)
        {
            DateTime fechaBusqueda = DateTime.Parse(txtFechaInicio.Text);
            llenarTreeporBusquedaFecha(fechaBusqueda);
        }
    }
}
