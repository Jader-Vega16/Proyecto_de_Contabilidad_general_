using System;
using System.Collections.Generic;
using Gtk;
using Contabilidad_General.Datos;
using Contabilidad_General.Entidades;
using Contabilidad_General.Utilidades;
namespace Contabilidad_General
{
    public partial class Control_de_Usuarios_con_Rol : Gtk.Window
    {
        public Control_de_Usuarios_con_Rol() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            llenarTreeview();
            llenarcmbIDUsuario();
            llenarcmbIDRol();
        }

        ListStore ls = new ListStore(typeof(String), typeof(String), typeof(String), typeof(string));

        //Método para llenar treeview
        public void llenarTreeview()
        {
            Datos.DTUsuario_rol dta = new Datos.DTUsuario_rol();
            List<Entidades.Usuario_con_rol> lista = new List<Entidades.Usuario_con_rol>();
            lista = dta.ListarUsuariosRol();

            foreach (Entidades.Usuario_con_rol a in lista)
            {
                ls.AppendValues(a.Idusurio_rol.ToString(), a.FechaCreacion.ToString(), a.Usuario_idUsuario.ToString(), a.Rol_idRol.ToString());
            }

            //Crear el modelo de datos

            tvUsuariosRol.Model = ls;

            tvUsuariosRol.AppendColumn("idusuario_rol", new CellRendererText(), "text", 0);
            tvUsuariosRol.AppendColumn("fechaCreacion", new CellRendererText(), "text", 1);
            tvUsuariosRol.AppendColumn("Usuario_idUsuario", new CellRendererText(), "text", 2);
            tvUsuariosRol.AppendColumn("Rol_idRol", new CellRendererText(), "text", 3);
    



        }



        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        protected void OnTvUsuariosRolRowActivated(object o, Gtk.RowActivatedArgs args)
        {
            var model = tvUsuariosRol.Model;
            TreeIter iter;
            model.GetIter(out iter, args.Path);

            var idusuario_rol = model.GetValue(iter, 0);
            var fechaCreacion = model.GetValue(iter, 1);

            this.txtIDUsuarioRol.Text = Convert.ToString(idusuario_rol);
            this.txtFecha.Text = fechaCreacion.ToString();


        }

        protected void OnBtnNuevoClicked(object sender, EventArgs e)
        {
            txtIDUsuarioRol.Text = "";
            txtFecha.Text = "";
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


        ListStore cmRol = new ListStore(typeof(String), typeof(String));

        public void llenarcmbIDRol()
        {
            DTRol dta = new DTRol();
            List<Entidades.Rol> listacmb = new List<Entidades.Rol>();
            listacmb = dta.ListarRoles();

            foreach (Entidades.Rol a in listacmb)
            {
                cmRol.AppendValues(a.Nombre.ToString());
            }
            cmbRol.Model = cmRol;
        }

    }
}
