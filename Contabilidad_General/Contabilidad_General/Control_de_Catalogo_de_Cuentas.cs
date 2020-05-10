using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Catalogo_de_Cuentas : Gtk.Window
    {
        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();

        public Control_de_Catalogo_de_Cuentas() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDNaturaleza();
            llenarcmbIDUsuario();
            llenarcmbIDCuentaPadre();
            llenarcmbIDEmpresa();
        }

        ListStore ls = new ListStore( typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTCatalogoCuentas dta = new Datos.DTCatalogoCuentas();
            List<Entidades.Catalogo_de_cuenta> lista = new List<Entidades.Catalogo_de_cuenta>();
            lista = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in lista)
            {
                ls.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
            }

            //Crear el modelo de datos
            tvCatalogoCuentas.Model = ls;

            tvCatalogoCuentas.AppendColumn("idCatalogo_cuentas", new CellRendererText(), "text", 0);
            tvCatalogoCuentas.AppendColumn("numero_cuenta", new CellRendererText(), "text", 1);
            tvCatalogoCuentas.AppendColumn("nombre_cuenta", new CellRendererText(), "text", 2);
            tvCatalogoCuentas.AppendColumn("descripcion_cuenta", new CellRendererText(), "text", 3);
            tvCatalogoCuentas.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvCatalogoCuentas.AppendColumn("pais_cuenta", new CellRendererText(), "text", 5);
            tvCatalogoCuentas.AppendColumn("id_cuentaPadre", new CellRendererText(), "text", 6);
            tvCatalogoCuentas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvCatalogoCuentas.AppendColumn("Tipos_naturaleza_id_naturalezaCuenta", new CellRendererText(), "text", 8);
            tvCatalogoCuentas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);




        }






        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvCatalogoCuentasRowActivated(object o, RowActivatedArgs args)
        {
            var model = tvCatalogoCuentas.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idCatalogo_cuentas = model.GetValue(iter, 0);
            var numero_cuenta = model.GetValue(iter, 1);
            var nombre_cuenta = model.GetValue(iter, 2);
            var descripcion_cuenta = model.GetValue(iter, 3);
            var activo = model.GetValue(iter, 4);
            var pais_cuenta = model.GetValue(iter, 5);
            var id_cuentaPadre = model.GetValue(iter, 6);



            this.txtIDCatalogoCuentas.Text = Convert.ToString(idCatalogo_cuentas);
            this.txtNumeroCuenta.Text = numero_cuenta.ToString();
            this.txtNombreCuenta.Text = nombre_cuenta.ToString();
            this.txtDescripcionCuenta.Text = descripcion_cuenta.ToString();
            this.txtPaisCuenta.Text = pais_cuenta.ToString();






        }

        protected void OnBtnNuevaClicked(object sender, EventArgs e)
        {
            txtIDCatalogoCuentas.Text = "";
            txtNumeroCuenta.Text = "";
            txtNombreCuenta.Text = "";
            txtDescripcionCuenta.Text = "";
            txtPaisCuenta.Text = "";
        }



        ListStore cmNaturaleza = new ListStore(typeof(String), typeof(string), typeof(string), typeof(string));

        public void llenarcmbIDNaturaleza()
        {
            DTTipo_naturaleza dta = new DTTipo_naturaleza();
            List<Entidades.Tipo_de_naturaleza> listacmb = new List<Entidades.Tipo_de_naturaleza>();
            listacmb = dta.ListarNaturalezas();

            foreach (Entidades.Tipo_de_naturaleza a in listacmb)
            {
                cmNaturaleza.AppendValues(a.NombreNaturaleza.ToString());
            }
            cmbIDNaturalezaCuenta.Model = cmNaturaleza;
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

        public void llenarcmbIDCuentaPadre()
        {
            DTCatalogoCuentas dta = new DTCatalogoCuentas();
            List<Entidades.Catalogo_de_cuenta> listacmb = new List<Entidades.Catalogo_de_cuenta>();
            listacmb = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in listacmb)
            {
                cmCatalogo.AppendValues(a.Numero_cuenta.ToString());
            }
            cmbIDCuentaPadre.Model = cmCatalogo;
        }




        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvCatalogoCuentas.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvCatalogoCuentas.RemoveColumn(tvc);
            }
            ls.Clear();
        }



        public void llenarTreeporBusquedaNumero(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTCatalogoCuentas dta = new DTCatalogoCuentas();

            List<Entidades.Catalogo_de_cuenta> lista = new List<Entidades.Catalogo_de_cuenta>();
            lista = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in lista)
            {
                if (busqueda == a.Numero_cuenta)
                    ls.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Catalogo_de_cuenta a in lista)
                {
                    ls.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
                }


            }

            //Crear el modelo de datos
            tvCatalogoCuentas.Model = ls;

            tvCatalogoCuentas.AppendColumn("idCatalogo_cuentas", new CellRendererText(), "text", 0);
            tvCatalogoCuentas.AppendColumn("numero_cuenta", new CellRendererText(), "text", 1);
            tvCatalogoCuentas.AppendColumn("nombre_cuenta", new CellRendererText(), "text", 2);
            tvCatalogoCuentas.AppendColumn("descripcion_cuenta", new CellRendererText(), "text", 3);
            tvCatalogoCuentas.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvCatalogoCuentas.AppendColumn("pais_cuenta", new CellRendererText(), "text", 5);
            tvCatalogoCuentas.AppendColumn("id_cuentaPadre", new CellRendererText(), "text", 6);
            tvCatalogoCuentas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvCatalogoCuentas.AppendColumn("Tipos_naturaleza_id_naturalezaCuenta", new CellRendererText(), "text", 8);
            tvCatalogoCuentas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);


        }

        protected void OnBtnBuscarNumeroClicked(object sender, EventArgs e)
        {
            string numeroBusqueda = txtBuscarNumero.Text;
            llenarTreeporBusquedaNumero(numeroBusqueda);
        }

        public void llenarTreeporBusquedaNombre(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTCatalogoCuentas dta = new DTCatalogoCuentas();

            List<Entidades.Catalogo_de_cuenta> lista = new List<Entidades.Catalogo_de_cuenta>();
            lista = dta.ListarCatalogo();

            foreach (Entidades.Catalogo_de_cuenta a in lista)
            {
                if (busqueda == a.Nombre_cuenta)
                    ls.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Catalogo_de_cuenta a in lista)
                {
                    ls.AppendValues(a.IdCatalogo_cuentas.ToString(), a.Numero_cuenta.ToString(), a.Nombre_cuenta.ToString(), a.Descripcion_cuenta.ToString(), a.Activo.ToString(), a.Pais_cuenta.ToString(), a.Id_cuentaPadre.ToString(), a.Detalles_empresa_id_empresa.ToString(), a.Tipos_naturaleza_id_naturalezaCuenta.ToString(), a.Usuario_idUsuario.ToString());
                }


            }

            //Crear el modelo de datos
            tvCatalogoCuentas.Model = ls;

            tvCatalogoCuentas.AppendColumn("idCatalogo_cuentas", new CellRendererText(), "text", 0);
            tvCatalogoCuentas.AppendColumn("numero_cuenta", new CellRendererText(), "text", 1);
            tvCatalogoCuentas.AppendColumn("nombre_cuenta", new CellRendererText(), "text", 2);
            tvCatalogoCuentas.AppendColumn("descripcion_cuenta", new CellRendererText(), "text", 3);
            tvCatalogoCuentas.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvCatalogoCuentas.AppendColumn("pais_cuenta", new CellRendererText(), "text", 5);
            tvCatalogoCuentas.AppendColumn("id_cuentaPadre", new CellRendererText(), "text", 6);
            tvCatalogoCuentas.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 7);
            tvCatalogoCuentas.AppendColumn("Tipos_naturaleza_id_naturalezaCuenta", new CellRendererText(), "text", 8);
            tvCatalogoCuentas.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 9);


        }

        protected void OnBtnBuscarNombreClicked(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBuscarNombre.Text;
            llenarTreeporBusquedaNombre(nombreBusqueda);
        }
    }
}
