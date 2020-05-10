using System;
using System.Collections.Generic;
using Contabilidad_General.Datos;
using Contabilidad_General.Utilidades;
using Gtk;

namespace Contabilidad_General
{
    public partial class Control_de_Empleados : Gtk.Window
    {


        Mensaje _msj = new Mensaje();
        conexion cn = new conexion();

        public Control_de_Empleados() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            llenarTreeview();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String),typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTEmpleados dta = new Datos.DTEmpleados();
            List<Entidades.Empleado> lista = new List<Entidades.Empleado>();
            lista = dta.ListarEmpleados();

            foreach (Entidades.Empleado a in lista)
            {
                ls.AppendValues(a.IdEmpleado.ToString(), a.Fecha_ingreso.ToString(), a.Cedula.ToString() ,a.Nombre_cargo.ToString(), a.Nombre_empleado.ToString(),a.Apellido_empleado.ToString(),a.Telefono_empleado.ToString(),a.Celular_empleado.ToString(),a.Correo_empleado.ToString(),a.Direccion_empleado.ToString(),a.Sueldo.ToString(),a.Activo.ToString());
            }

            //Crear el modelo de datos
            tvEmpleados.Model = ls;

            tvEmpleados.AppendColumn("idEmpleado", new CellRendererText(), "text", 0);
            tvEmpleados.AppendColumn("fecha_ingreso", new CellRendererText(), "text", 1);
            tvEmpleados.AppendColumn("cedula", new CellRendererText(), "text", 2);
            tvEmpleados.AppendColumn("nombre_cargo", new CellRendererText(), "text", 3);
            tvEmpleados.AppendColumn("nombre_empleado", new CellRendererText(), "text", 4);
            tvEmpleados.AppendColumn("apellido_empleado", new CellRendererText(), "text", 5);
            tvEmpleados.AppendColumn("telefono_empleado", new CellRendererText(), "text", 6);
            tvEmpleados.AppendColumn("celular_empleado", new CellRendererText(), "text", 7);
            tvEmpleados.AppendColumn("correo_empleado", new CellRendererText(), "text", 8);
            tvEmpleados.AppendColumn("direccion_empleado", new CellRendererText(), "text", 9);
            tvEmpleados.AppendColumn("sueldo", new CellRendererText(), "text", 10);
            tvEmpleados.AppendColumn("activo", new CellRendererText(), "text", 11);



        }




        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvEmpleadosRowActivated(object o, RowActivatedArgs args)
        {
            var model = tvEmpleados.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idEmpleado = model.GetValue(iter, 0);
            var fecha_ingreso = model.GetValue(iter, 1);
            var cedula = model.GetValue(iter, 2);
            var nombre_cargo = model.GetValue(iter, 3);
            var nombre_empleado = model.GetValue(iter, 4);
            var apellido_empleado = model.GetValue(iter, 5);
            var telefono_empleado = model.GetValue(iter, 6);
            var celular_empleado = model.GetValue(iter, 7);
            var correo_empleado = model.GetValue(iter, 8);
            var direccion_empleado = model.GetValue(iter, 9);
            var sueldo = model.GetValue(iter, 10);



            this.txtIDEmpleado.Text = idEmpleado.ToString();
            this.txtFechaIngreso1.Text = fecha_ingreso.ToString();
            this.txtCedulaEmpleado.Text = cedula.ToString();
            this.txtCargoEmpleado1.Text = nombre_cargo.ToString();
            this.txtNombresEmpleado.Text = nombre_empleado.ToString();
            this.txtApellidosEmpleado.Text = apellido_empleado.ToString();
            this.txtTelefonoEmpleado.Text = telefono_empleado.ToString();
            this.txtCelularEmpleado.Text = celular_empleado.ToString();
            this.txtCorreoEmpleado.Text = correo_empleado.ToString();
            this.txtDireccionEmpleado.Text = direccion_empleado.ToString();
            this.txtSueldoEmpleado.Text = sueldo.ToString();
        }

        protected void OnBtnNuevoClicked(object sender, EventArgs e)
        {
            txtIDEmpleado.Text = "";
            txtFechaIngreso1.Text = "";
            txtCedulaEmpleado.Text = "";
            txtCargoEmpleado1.Text = "";
            txtNombresEmpleado.Text = "";
            txtApellidosEmpleado.Text = "";
            txtTelefonoEmpleado.Text = "";
            txtCelularEmpleado.Text = "";
            txtCorreoEmpleado.Text = "";
            txtDireccionEmpleado.Text = "";
            txtSueldoEmpleado.Text = "";

                  }

        //Método para recargar TreeView
        public void recargarTreeView()
        {
            TreeViewColumn[] listColumns;
            listColumns = tvEmpleados.Columns;
            foreach (TreeViewColumn tvc in listColumns)
            {
                tvEmpleados.RemoveColumn(tvc);
            }
            ls.Clear();
        }




        public void llenarTreeporBusquedaNombre(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTEmpleados dta = new DTEmpleados();

            List<Entidades.Empleado> lista = new List<Entidades.Empleado>();
            lista = dta.ListarEmpleados();

            foreach (Entidades.Empleado a in lista)
            {
                if (busqueda == a.Nombre_empleado)
                    ls.AppendValues(a.IdEmpleado.ToString(), a.Fecha_ingreso.ToString(), a.Cedula.ToString(), a.Nombre_cargo.ToString(), a.Nombre_empleado.ToString(), a.Apellido_empleado.ToString(), a.Telefono_empleado.ToString(), a.Celular_empleado.ToString(), a.Correo_empleado.ToString(), a.Direccion_empleado.ToString(), a.Sueldo.ToString(), a.Activo.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Empleado a in lista)
                {
                    ls.AppendValues(a.IdEmpleado.ToString(), a.Fecha_ingreso.ToString(), a.Cedula.ToString(), a.Nombre_cargo.ToString(), a.Nombre_empleado.ToString(), a.Apellido_empleado.ToString(), a.Telefono_empleado.ToString(), a.Celular_empleado.ToString(), a.Correo_empleado.ToString(), a.Direccion_empleado.ToString(), a.Sueldo.ToString(), a.Activo.ToString());
                }


            }


            //Crear el modelo de datos
            tvEmpleados.Model = ls;

            tvEmpleados.AppendColumn("idEmpleado", new CellRendererText(), "text", 0);
            tvEmpleados.AppendColumn("fecha_ingreso", new CellRendererText(), "text", 1);
            tvEmpleados.AppendColumn("cedula", new CellRendererText(), "text", 2);
            tvEmpleados.AppendColumn("nombre_cargo", new CellRendererText(), "text", 3);
            tvEmpleados.AppendColumn("nombre_empleado", new CellRendererText(), "text", 4);
            tvEmpleados.AppendColumn("apellido_empleado", new CellRendererText(), "text", 5);
            tvEmpleados.AppendColumn("telefono_empleado", new CellRendererText(), "text", 6);
            tvEmpleados.AppendColumn("celular_empleado", new CellRendererText(), "text", 7);
            tvEmpleados.AppendColumn("correo_empleado", new CellRendererText(), "text", 8);
            tvEmpleados.AppendColumn("direccion_empleado", new CellRendererText(), "text", 9);
            tvEmpleados.AppendColumn("sueldo", new CellRendererText(), "text", 10);
            tvEmpleados.AppendColumn("activo", new CellRendererText(), "text", 11);

        }

        protected void OnBtnBuscarNombreClicked(object sender, EventArgs e)
        {

            string nombreBusqueda = txtBuscarNombre.Text;
            llenarTreeporBusquedaNombre(nombreBusqueda);
        }


        public void llenarTreeporBusquedaID(string busqueda)
        {
            int existe = 0;
            recargarTreeView();
            DTEmpleados dta = new DTEmpleados();

            List<Entidades.Empleado> lista = new List<Entidades.Empleado>();
            lista = dta.ListarEmpleados();

            foreach (Entidades.Empleado a in lista)
            {
                if (busqueda == a.IdEmpleado)
                    ls.AppendValues(a.IdEmpleado.ToString(), a.Fecha_ingreso.ToString(), a.Cedula.ToString(), a.Nombre_cargo.ToString(), a.Nombre_empleado.ToString(), a.Apellido_empleado.ToString(), a.Telefono_empleado.ToString(), a.Celular_empleado.ToString(), a.Correo_empleado.ToString(), a.Direccion_empleado.ToString(), a.Sueldo.ToString(), a.Activo.ToString());
                existe = 1;
            }

            if (existe == 0)
            {
                foreach (Entidades.Empleado a in lista)
                {
                    ls.AppendValues(a.IdEmpleado.ToString(), a.Fecha_ingreso.ToString(), a.Cedula.ToString(), a.Nombre_cargo.ToString(), a.Nombre_empleado.ToString(), a.Apellido_empleado.ToString(), a.Telefono_empleado.ToString(), a.Celular_empleado.ToString(), a.Correo_empleado.ToString(), a.Direccion_empleado.ToString(), a.Sueldo.ToString(), a.Activo.ToString());
                }


            }


            //Crear el modelo de datos
            tvEmpleados.Model = ls;

            tvEmpleados.AppendColumn("idEmpleado", new CellRendererText(), "text", 0);
            tvEmpleados.AppendColumn("fecha_ingreso", new CellRendererText(), "text", 1);
            tvEmpleados.AppendColumn("cedula", new CellRendererText(), "text", 2);
            tvEmpleados.AppendColumn("nombre_cargo", new CellRendererText(), "text", 3);
            tvEmpleados.AppendColumn("nombre_empleado", new CellRendererText(), "text", 4);
            tvEmpleados.AppendColumn("apellido_empleado", new CellRendererText(), "text", 5);
            tvEmpleados.AppendColumn("telefono_empleado", new CellRendererText(), "text", 6);
            tvEmpleados.AppendColumn("celular_empleado", new CellRendererText(), "text", 7);
            tvEmpleados.AppendColumn("correo_empleado", new CellRendererText(), "text", 8);
            tvEmpleados.AppendColumn("direccion_empleado", new CellRendererText(), "text", 9);
            tvEmpleados.AppendColumn("sueldo", new CellRendererText(), "text", 10);
            tvEmpleados.AppendColumn("activo", new CellRendererText(), "text", 11);

        }

        protected void OnBtnBuscarIDClicked(object sender, EventArgs e)
        {

            string IDBusqueda = txtBuscarID.Text;
            llenarTreeporBusquedaID(IDBusqueda);
        }
    }
}
