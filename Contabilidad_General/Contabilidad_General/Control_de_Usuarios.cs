using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;

namespace Contabilidad_General
{
    public partial class Control_de_Usuarios : Gtk.Window
    {

        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();


        public Control_de_Usuarios() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDEmpleado();
            llenarcmbIDEmpresa();

        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTUsuario dta = new Datos.DTUsuario();
            List<Entidades.Usuario> lista = new List<Entidades.Usuario>();
            lista = dta.ListarUsuarios();

            foreach (Entidades.Usuario a in lista)
            {
                ls.AppendValues(a.IdUsuario.ToString(), a.Usuario_.ToString(), a.Pwd.ToString(), a.FechaCreacion.ToString(), a.Activo.ToString(), a.Empleados_idEmpleado.ToString(), a.Detalles_empresa_id_empresa.ToString());
            }

            //Crear el modelo de datos

            tvUsuarios.Model = ls;

            tvUsuarios.AppendColumn("idUsuario", new CellRendererText(), "text", 0);
            tvUsuarios.AppendColumn("usuario", new CellRendererText(), "text", 1);
            tvUsuarios.AppendColumn("fechaCreacion", new CellRendererText(), "text", 3);
            tvUsuarios.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvUsuarios.AppendColumn("Empleados_idEmpleado", new CellRendererText(), "text", 5);
            tvUsuarios.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 6);



        }






        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvUsuariosRowActivated(object o, RowActivatedArgs args)
        {

            var model = tvUsuarios.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idUsuario = model.GetValue(iter, 0);
            var usuario = model.GetValue(iter, 1);
            var pwd = model.GetValue(iter, 2);
            var fechaCreacion = model.GetValue(iter, 3);


            this.txtIDUsuario.Text = Convert.ToString(idUsuario);
            this.txtUsuario.Text = usuario.ToString();
            this.txtContrasenya.Text = pwd.ToString();
            this.txtFechaCreacion.Text = fechaCreacion.ToString();
        }

        protected void OnBtnNuevoClicked(object sender, EventArgs e)
        {
            txtIDUsuario.Text = "";
            txtUsuario.Text = "";
            txtContrasenya.Text = "";
            txtFechaCreacion.Text = "";
 
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

            ListStore cmEmpleado = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));


            public void llenarcmbIDEmpleado()
            {
                DTEmpleados dta = new DTEmpleados();
                List<Entidades.Empleado> listacmb = new List<Entidades.Empleado>();
                listacmb = dta.ListarEmpleados();

                foreach (Entidades.Empleado a in listacmb)
                {
                    cmEmpleado.AppendValues(a.IdEmpleado.ToString());
                }
                cmbIDEmpleado.Model = cmEmpleado;
            }



        public void llenarTreeporBusquedaUsuario(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTUsuario dta = new DTUsuario();

            List<Entidades.Usuario> lista = new List<Entidades.Usuario>();
            lista = dta.ListarUsuarios();

            foreach (Entidades.Usuario a in lista)
            {
                if (busqueda == a.Usuario_)
                    ls.AppendValues(a.IdUsuario.ToString(), a.Usuario_.ToString(), a.Pwd.ToString(), a.FechaCreacion.ToString(), a.Activo.ToString(), a.Empleados_idEmpleado.ToString(), a.Detalles_empresa_id_empresa.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Usuario a in lista)
                {
                    ls.AppendValues(a.IdUsuario.ToString(), a.Usuario_.ToString(), a.Pwd.ToString(), a.FechaCreacion.ToString(), a.Activo.ToString(), a.Empleados_idEmpleado.ToString(), a.Detalles_empresa_id_empresa.ToString());
                }


            }


            //Crear el modelo de datos

            tvUsuarios.Model = ls;

            tvUsuarios.AppendColumn("idUsuario", new CellRendererText(), "text", 0);
            tvUsuarios.AppendColumn("usuario", new CellRendererText(), "text", 1);
            tvUsuarios.AppendColumn("fechaCreacion", new CellRendererText(), "text", 3);
            tvUsuarios.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvUsuarios.AppendColumn("Empleados_idEmpleado", new CellRendererText(), "text", 5);
            tvUsuarios.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 6);
        }



        public void llenarTreeporBusquedaEmpleado(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTUsuario dta = new DTUsuario();

            List<Entidades.Usuario> lista = new List<Entidades.Usuario>();
            lista = dta.ListarUsuarios();

            foreach (Entidades.Usuario a in lista)
            {
                if (busqueda == a.Empleados_idEmpleado)
                    ls.AppendValues(a.IdUsuario.ToString(), a.Usuario_.ToString(), a.Pwd.ToString(), a.FechaCreacion.ToString(), a.Activo.ToString(), a.Empleados_idEmpleado.ToString(), a.Detalles_empresa_id_empresa.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Usuario a in lista)
                {
                    ls.AppendValues(a.IdUsuario.ToString(), a.Usuario_.ToString(), a.Pwd.ToString(), a.FechaCreacion.ToString(), a.Activo.ToString(), a.Empleados_idEmpleado.ToString(), a.Detalles_empresa_id_empresa.ToString());
                }


            }


            //Crear el modelo de datos

            tvUsuarios.Model = ls;

            tvUsuarios.AppendColumn("idUsuario", new CellRendererText(), "text", 0);
            tvUsuarios.AppendColumn("usuario", new CellRendererText(), "text", 1);
            tvUsuarios.AppendColumn("fechaCreacion", new CellRendererText(), "text", 3);
            tvUsuarios.AppendColumn("activo", new CellRendererText(), "text", 4);
            tvUsuarios.AppendColumn("Empleados_idEmpleado", new CellRendererText(), "text", 5);
            tvUsuarios.AppendColumn("Detalles_empresa_id_empresa", new CellRendererText(), "text", 6);
        }


        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvUsuarios.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvUsuarios.RemoveColumn(tvc);
            }
            ls.Clear();
        }

        protected void OnBtnBuscarUsuarioClicked(object sender, EventArgs e)
        {
            string usuarioBusqueda = txtBuscarUsuario.Text;
            llenarTreeporBusquedaUsuario(usuarioBusqueda);
        }

        protected void OnBtnBuscarIDClicked(object sender, EventArgs e)
        {

            string empleadoBusqueda = txtBuscarID.Text;
            llenarTreeporBusquedaEmpleado(empleadoBusqueda);

        }
    }
} 
