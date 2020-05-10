using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Monedas : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();



        public Control_de_Monedas() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDUsuario();
            llenarcmbIDEmpresa();



        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTMoneda dta = new Datos.DTMoneda();
            List<Entidades.Moneda> lista = new List<Entidades.Moneda>();
            lista = dta.ListarMonedas();

            foreach (Entidades.Moneda a in lista)
            {
                ls.AppendValues(a.Id_moneda.ToString(), a.Nombre_moneda.ToString(), a.Codigo_ISO_Alfab.ToString(), a.Pais.ToString(), a.Tasa_conversion.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
            }

            //Crear el modelo de datos
            tvMonedas.Model = ls;

            tvMonedas.AppendColumn("id_moneda", new CellRendererText(), "text", 0);
            tvMonedas.AppendColumn("nombre_moneda", new CellRendererText(), "text", 1);
            tvMonedas.AppendColumn("cod_ISO_Alfab", new CellRendererText(), "text", 2);
            tvMonedas.AppendColumn("pais", new CellRendererText(), "text", 3);
            tvMonedas.AppendColumn("tasa_conversion", new CellRendererText(), "text", 4);
            tvMonedas.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvMonedas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvMonedas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);


  


        }










        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvMonedasRowActivated(object o, RowActivatedArgs args)
        {
            var model = tvMonedas.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var id_moneda = model.GetValue(iter, 0);
            var nombre_moneda = model.GetValue(iter, 1);
            var codigo_ISO_Alfab = model.GetValue(iter, 2);
            var pais = model.GetValue(iter, 3);
            var tasa_conversion = model.GetValue(iter, 4);




            this.txtIDMoneda.Text = Convert.ToString(id_moneda);
            this.txtNombreMoneda.Text = nombre_moneda.ToString();
            this.txtCodigoISOMoneda.Text = codigo_ISO_Alfab.ToString();
            this.txtPaisMoneda.Text = pais.ToString();
            this.txtTasaConversion.Text = tasa_conversion.ToString();

        }

        protected void OnBtnNuevaClicked(object sender, EventArgs e)
        {
            txtIDMoneda.Text = "";
            txtNombreMoneda.Text = "";
            txtCodigoISOMoneda.Text = "";
            txtPaisMoneda.Text = "";
            txtTasaConversion.Text = "";
        }

        ListStore cmUsuario = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDUsuario()
        {
            DTUsuario dta = new DTUsuario();
            List<Entidades.Usuario> listacmb = new List<Entidades.Usuario>();
            listacmb = dta.ListarUsuarios();

            foreach(Entidades.Usuario a in listacmb)
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


        public void llenarTreeporBusquedaCodigo(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTMoneda dta = new DTMoneda();

            List<Entidades.Moneda> lista = new List<Entidades.Moneda>();
            lista = dta.ListarMonedas();

            foreach (Entidades.Moneda a in lista)
            {
                if (busqueda == a.Codigo_ISO_Alfab)
                    ls.AppendValues(a.Id_moneda.ToString(), a.Nombre_moneda.ToString(), a.Codigo_ISO_Alfab.ToString(), a.Pais.ToString(), a.Tasa_conversion.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Moneda a in lista)
                {
                    ls.AppendValues(a.Id_moneda.ToString(), a.Nombre_moneda.ToString(), a.Codigo_ISO_Alfab.ToString(), a.Pais.ToString(), a.Tasa_conversion.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                }


            }

            //Crear el modelo de datos
            tvMonedas.Model = ls;

            tvMonedas.AppendColumn("id_moneda", new CellRendererText(), "text", 0);
            tvMonedas.AppendColumn("nombre_moneda", new CellRendererText(), "text", 1);
            tvMonedas.AppendColumn("cod_ISO_Alfab", new CellRendererText(), "text", 2);
            tvMonedas.AppendColumn("pais", new CellRendererText(), "text", 3);
            tvMonedas.AppendColumn("tasa_conversion", new CellRendererText(), "text", 4);
            tvMonedas.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvMonedas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvMonedas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);




        }


        public void llenarTreeporBusquedaNombre(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTMoneda dta = new DTMoneda();

            List<Entidades.Moneda> lista = new List<Entidades.Moneda>();
            lista = dta.ListarMonedas();

            foreach (Entidades.Moneda a in lista)
            {
                if (busqueda == a.Nombre_moneda)
                    ls.AppendValues(a.Id_moneda.ToString(), a.Nombre_moneda.ToString(), a.Codigo_ISO_Alfab.ToString(), a.Pais.ToString(), a.Tasa_conversion.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Moneda a in lista)
                {
                    ls.AppendValues(a.Id_moneda.ToString(), a.Nombre_moneda.ToString(), a.Codigo_ISO_Alfab.ToString(), a.Pais.ToString(), a.Tasa_conversion.ToString(), a.Activo.ToString(), a.Usuario_idUsuario.ToString(), a.Detalles_empresa_id_empresa.ToString());
                }


            }

            //Crear el modelo de datos
            tvMonedas.Model = ls;

            tvMonedas.AppendColumn("id_moneda", new CellRendererText(), "text", 0);
            tvMonedas.AppendColumn("nombre_moneda", new CellRendererText(), "text", 1);
            tvMonedas.AppendColumn("cod_ISO_Alfab", new CellRendererText(), "text", 2);
            tvMonedas.AppendColumn("pais", new CellRendererText(), "text", 3);
            tvMonedas.AppendColumn("tasa_conversion", new CellRendererText(), "text", 4);
            tvMonedas.AppendColumn("activo", new CellRendererText(), "text", 5);
            tvMonedas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 6);
            tvMonedas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);




        }

        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvMonedas.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvMonedas.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnBtnBuscarISOClicked(object sender, EventArgs e)
        {
            string codigoBusqueda = txtBuscarISO.Text;
            llenarTreeporBusquedaCodigo(codigoBusqueda);
        }

        protected void OnBtnBuscarNombreClicked(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBuscarNombre.Text;
            llenarTreeporBusquedaNombre(nombreBusqueda);
        }

    }
}
