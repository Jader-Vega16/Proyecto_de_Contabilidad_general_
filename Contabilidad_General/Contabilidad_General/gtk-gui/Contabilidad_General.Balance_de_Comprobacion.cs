
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Balance_de_Comprobacion
	{
		private global::Gtk.VBox vbox13;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Alignment alignment14;

		private global::Gtk.Alignment alignment13;

		private global::Gtk.Button btnSalir;

		private global::Gtk.EventBox eventbox1;

		private global::Gtk.VBox vbox14;

		private global::Gtk.Label label16;

		private global::Gtk.HBox hbox17;

		private global::Gtk.Alignment alignment19;

		private global::Gtk.Label label17;

		private global::Gtk.Entry txtFechaInicio;

		private global::Gtk.HBox hbox16;

		private global::Gtk.Alignment alignment20;

		private global::Gtk.Label label18;

		private global::Gtk.Entry txtFechaFin;

		private global::Gtk.HBox hbox18;

		private global::Gtk.Alignment alignment16;

		private global::Gtk.Alignment alignment15;

		private global::Gtk.Button btnNuevo;

		private global::Gtk.Button btnCalcular;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Balance_de_Comprobacion
			this.Name = "Contabilidad_General.Balance_de_Comprobacion";
			this.Title = global::Mono.Unix.Catalog.GetString("Balance_de_Comprobacion");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Balance_de_Comprobacion.Gtk.Container+ContainerChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.alignment14 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment14.Name = "alignment14";
			this.hbox11.Add(this.alignment14);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.alignment14]));
			w1.Position = 0;
			// Container child hbox11.Gtk.Box+BoxChild
			this.alignment13 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment13.Name = "alignment13";
			this.hbox11.Add(this.alignment13);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.alignment13]));
			w2.Position = 1;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox11.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.btnSalir]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox13.Add(this.hbox11);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox11]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.eventbox1 = new global::Gtk.EventBox();
			this.eventbox1.Name = "eventbox1";
			// Container child eventbox1.Gtk.Container+ContainerChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			this.vbox14.BorderWidth = ((uint)(12));
			// Container child vbox14.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("Balance de Comprobacion\n");
			this.vbox14.Add(this.label16);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label16]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox17 = new global::Gtk.HBox();
			this.hbox17.Name = "hbox17";
			this.hbox17.Spacing = 6;
			// Container child hbox17.Gtk.Box+BoxChild
			this.alignment19 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment19.Name = "alignment19";
			this.hbox17.Add(this.alignment19);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.alignment19]));
			w6.Position = 0;
			// Container child hbox17.Gtk.Box+BoxChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de inicio:");
			this.hbox17.Add(this.label17);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.label17]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox17.Gtk.Box+BoxChild
			this.txtFechaInicio = new global::Gtk.Entry();
			this.txtFechaInicio.CanFocus = true;
			this.txtFechaInicio.Name = "txtFechaInicio";
			this.txtFechaInicio.IsEditable = true;
			this.txtFechaInicio.InvisibleChar = '•';
			this.hbox17.Add(this.txtFechaInicio);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.txtFechaInicio]));
			w8.Position = 2;
			this.vbox14.Add(this.hbox17);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox17]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox16 = new global::Gtk.HBox();
			this.hbox16.Name = "hbox16";
			this.hbox16.Spacing = 6;
			// Container child hbox16.Gtk.Box+BoxChild
			this.alignment20 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment20.Name = "alignment20";
			this.hbox16.Add(this.alignment20);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.alignment20]));
			w10.Position = 0;
			// Container child hbox16.Gtk.Box+BoxChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("      Fecha de fin:");
			this.hbox16.Add(this.label18);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.label18]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox16.Gtk.Box+BoxChild
			this.txtFechaFin = new global::Gtk.Entry();
			this.txtFechaFin.CanFocus = true;
			this.txtFechaFin.Name = "txtFechaFin";
			this.txtFechaFin.IsEditable = true;
			this.txtFechaFin.InvisibleChar = '•';
			this.hbox16.Add(this.txtFechaFin);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox16[this.txtFechaFin]));
			w12.Position = 2;
			this.vbox14.Add(this.hbox16);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox16]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.eventbox1.Add(this.vbox14);
			this.vbox13.Add(this.eventbox1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.eventbox1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox18 = new global::Gtk.HBox();
			this.hbox18.Name = "hbox18";
			this.hbox18.Spacing = 6;
			// Container child hbox18.Gtk.Box+BoxChild
			this.alignment16 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment16.Name = "alignment16";
			this.hbox18.Add(this.alignment16);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.alignment16]));
			w16.Position = 0;
			// Container child hbox18.Gtk.Box+BoxChild
			this.alignment15 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment15.Name = "alignment15";
			this.hbox18.Add(this.alignment15);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.alignment15]));
			w17.Position = 1;
			// Container child hbox18.Gtk.Box+BoxChild
			this.btnNuevo = new global::Gtk.Button();
			this.btnNuevo.CanFocus = true;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.UseUnderline = true;
			this.btnNuevo.Label = global::Mono.Unix.Catalog.GetString("Nuevo");
			this.hbox18.Add(this.btnNuevo);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.btnNuevo]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox18.Gtk.Box+BoxChild
			this.btnCalcular = new global::Gtk.Button();
			this.btnCalcular.CanFocus = true;
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.UseUnderline = true;
			this.btnCalcular.Label = global::Mono.Unix.Catalog.GetString("Calcular");
			this.hbox18.Add(this.btnCalcular);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox18[this.btnCalcular]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			w19.Padding = ((uint)(34));
			this.vbox13.Add(this.hbox18);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox18]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			this.Add(this.vbox13);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 225;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
			this.btnNuevo.Clicked += new global::System.EventHandler(this.OnBtnNuevoClicked);
		}
	}
}
