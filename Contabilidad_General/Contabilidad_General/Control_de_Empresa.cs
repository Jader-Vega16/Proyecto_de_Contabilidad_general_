using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Empresa : Gtk.Window
    {

        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();

        public Control_de_Empresa() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();

        }


        ListStore ls = new ListStore( typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTEmpresa dta = new Datos.DTEmpresa();
            List<Entidades.Empresa> lista = new List<Entidades.Empresa>();
            lista = dta.ListarEmpresas();

            foreach (Entidades.Empresa a in lista)
            {
                ls.AppendValues(a.Id_empresa.ToString(), a.Nombre_empresa.ToString(), a.Nombre_comercial.ToString(),  a.Direccion_empresa.ToString(), a.Localidad_empresa.ToString(), a.Correo_empresa.ToString(), a.Activo.ToString());
            }

            //Crear el modelo de datos
            tvEmpresa.Model = ls;

            tvEmpresa.AppendColumn("id_empresa", new CellRendererText(), "text", 0);
            tvEmpresa.AppendColumn("nombre_empresa", new CellRendererText(), "text", 1);
            tvEmpresa.AppendColumn("nombre_comercial", new CellRendererText(), "text", 2);
            tvEmpresa.AppendColumn("direccion_empresa", new CellRendererText(), "text", 3);
            tvEmpresa.AppendColumn("localidad_empresa", new CellRendererText(), "text", 4);
            tvEmpresa.AppendColumn("correo_empresa", new CellRendererText(), "text", 5);
            tvEmpresa.AppendColumn("activo", new CellRendererText(), "text", 6);
  



        }




        public void llenarTreeporBusquedaNombre(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTEmpresa dta = new DTEmpresa();
                   
            List<Entidades.Empresa> lista = new List<Entidades.Empresa>();
            lista = dta.ListarEmpresas();

            foreach (Entidades.Empresa a in lista)
            {
                if (busqueda == a.Nombre_empresa)
                ls.AppendValues(a.Id_empresa.ToString(), a.Nombre_empresa.ToString(), a.Nombre_comercial.ToString(), a.Direccion_empresa.ToString(), a.Localidad_empresa.ToString(), a.Correo_empresa.ToString(), a.Activo.ToString());
                existe = 1;
            }

            if(existe == 0)
            {
                foreach (Entidades.Empresa a in lista)
                {
                    ls.AppendValues(a.Id_empresa.ToString(), a.Nombre_empresa.ToString(), a.Nombre_comercial.ToString(), a.Direccion_empresa.ToString(), a.Localidad_empresa.ToString(), a.Correo_empresa.ToString(), a.Activo.ToString());
                }


            }

            tvEmpresa.Model = ls;

            tvEmpresa.AppendColumn("id_empresa", new CellRendererText(), "text", 0);
            tvEmpresa.AppendColumn("nombre_empresa", new CellRendererText(), "text", 1);
            tvEmpresa.AppendColumn("nombre_comercial", new CellRendererText(), "text", 2);
            tvEmpresa.AppendColumn("direccion_empresa", new CellRendererText(), "text", 3);
            tvEmpresa.AppendColumn("localidad_empresa", new CellRendererText(), "text", 4);
            tvEmpresa.AppendColumn("correo_empresa", new CellRendererText(), "text", 5);
            tvEmpresa.AppendColumn("activo", new CellRendererText(), "text", 6);

        }







        public void llenarTreeporBusquedaID(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTEmpresa dta = new DTEmpresa();

            List<Entidades.Empresa> lista = new List<Entidades.Empresa>();
            lista = dta.ListarEmpresas();

            foreach (Entidades.Empresa a in lista)
            {
                if (busqueda == a.Id_empresa)
                    ls.AppendValues(a.Id_empresa.ToString(), a.Nombre_empresa.ToString(), a.Nombre_comercial.ToString(), a.Direccion_empresa.ToString(), a.Localidad_empresa.ToString(), a.Correo_empresa.ToString(), a.Activo.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Empresa a in lista)
                {
                    ls.AppendValues(a.Id_empresa.ToString(), a.Nombre_empresa.ToString(), a.Nombre_comercial.ToString(), a.Direccion_empresa.ToString(), a.Localidad_empresa.ToString(), a.Correo_empresa.ToString(), a.Activo.ToString());
                }


            }

            tvEmpresa.Model = ls;

            tvEmpresa.AppendColumn("id_empresa", new CellRendererText(), "text", 0);
            tvEmpresa.AppendColumn("nombre_empresa", new CellRendererText(), "text", 1);
            tvEmpresa.AppendColumn("nombre_comercial", new CellRendererText(), "text", 2);
            tvEmpresa.AppendColumn("direccion_empresa", new CellRendererText(), "text", 3);
            tvEmpresa.AppendColumn("localidad_empresa", new CellRendererText(), "text", 4);
            tvEmpresa.AppendColumn("correo_empresa", new CellRendererText(), "text", 5);
            tvEmpresa.AppendColumn("activo", new CellRendererText(), "text", 6);

        }








        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvEmpresaRowActivated(object o, RowActivatedArgs args)
        {

            var model = tvEmpresa.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var id_empresa = model.GetValue(iter, 0);
            var nombre_empresa = model.GetValue(iter, 1);
            var nombre_comercial = model.GetValue(iter, 2);
            var direccion_empresa = model.GetValue(iter, 3);
            var localidad_empresa = model.GetValue(iter, 4);
            var correo_empresa = model.GetValue(iter, 5);

            this.txtIDEmpresa.Text = id_empresa.ToString();
            this.txtNombreEmpresa.Text = nombre_empresa.ToString();
            this.txtNombreComercialEmpresa.Text = nombre_comercial.ToString();
            this.txtDireccionEmpresa.Text = direccion_empresa.ToString();
            this.txtLocalidadEmpresa.Text = localidad_empresa.ToString();
            this.txtCorreoEmpresa.Text = correo_empresa.ToString();

            
        }

        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvEmpresa.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvEmpresa.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnBtnBuscarNombreClicked(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBuscarNombre.Text;
            llenarTreeporBusquedaNombre(nombreBusqueda);
        }

        protected void OnBtnBuscarIDClicked(object sender, EventArgs e)
        {
            string IDBusqueda = txtBuscarID.Text;
            llenarTreeporBusquedaID(IDBusqueda);
        }
    }
}
