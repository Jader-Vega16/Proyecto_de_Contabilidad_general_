using System;
using Gtk;

namespace Contabilidad_General
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Datos.conexion cn = new Datos.conexion();


            cn.Open();
            cn.Close();

            Application.Run();


        }
    }
}
