﻿using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnSalirClicked(object sender, EventArgs e)
    {
        Application.Quit();
      
    }

    protected void OnBtnAccederClicked(object sender, EventArgs e)
    {
        Contabilidad_General.Menu_Principal conta = new Contabilidad_General.Menu_Principal();
        conta.Show();
        this.Destroy();
    }
}
