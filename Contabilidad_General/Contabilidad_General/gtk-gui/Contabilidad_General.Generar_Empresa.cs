
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Generar_Empresa
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.VBox vbox5;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Label label6;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Alignment alignment7;

		private global::Gtk.VBox vbox7;

		private global::Gtk.Label label12;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.VBox vbox9;

		private global::Gtk.Label label9;

		private global::Gtk.Label label10;

		private global::Gtk.Label label11;

		private global::Gtk.Label label13;

		private global::Gtk.VBox vbox8;

		private global::Gtk.Entry txtIDEmpresa;

		private global::Gtk.Entry txtNombreEmpresa;

		private global::Gtk.Entry txtNombreComercialEmpresa;

		private global::Gtk.Entry txtDireccionEmpresa;

		private global::Gtk.VBox vbox10;

		private global::Gtk.Entry txtLocalidadEmpresa;

		private global::Gtk.Entry txtCorreoEmpresa;

		private global::Gtk.ComboBox cmbActiva;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Alignment alignment6;

		private global::Gtk.Alignment alignment2;

		private global::Gtk.Alignment alignment5;

		private global::Gtk.Alignment alignment1;

		private global::Gtk.Button btnNueva;

		private global::Gtk.Button btnGenerar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Generar_Empresa
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "Contabilidad_General.Generar_Empresa";
			this.Title = global::Mono.Unix.Catalog.GetString("Generar_Empresa");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Generar_Empresa.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox4.Add(this.alignment4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.alignment4]));
			w2.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.hbox4.Add(this.alignment3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.alignment3]));
			w3.Position = 1;
			// Container child hbox4.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox4.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnSalir]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox5.Add(this.hbox4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Generar Empresa\n");
			this.vbox6.Add(this.label6);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label6]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.alignment7 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment7.Name = "alignment7";
			this.hbox5.Add(this.alignment7);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.alignment7]));
			w7.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			this.vbox7.BorderWidth = ((uint)(12));
			// Container child vbox7.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.Xalign = 1F;
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("ID de la Empresa:");
			this.vbox7.Add(this.label12);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label12]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			w8.Padding = ((uint)(5));
			// Container child vbox7.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre de la Empresa:");
			this.vbox7.Add(this.label7);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label7]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			w9.Padding = ((uint)(6));
			// Container child vbox7.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre Comercial de la Empresa:");
			this.vbox7.Add(this.label8);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label8]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(9));
			// Container child vbox7.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Direccion de la Empresa:");
			this.vbox9.Add(this.label9);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label9]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			w11.Padding = ((uint)(5));
			// Container child vbox9.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Localidad de la Empresa:");
			this.vbox9.Add(this.label10);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label10]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			w12.Padding = ((uint)(13));
			// Container child vbox9.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Correo de la Empresa:");
			this.vbox9.Add(this.label11);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label11]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Activa:");
			this.vbox9.Add(this.label13);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label13]));
			w14.Position = 3;
			w14.Expand = false;
			w14.Fill = false;
			w14.Padding = ((uint)(12));
			this.vbox7.Add(this.vbox9);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.vbox9]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			this.hbox5.Add(this.vbox7);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox7]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			this.vbox8.BorderWidth = ((uint)(12));
			// Container child vbox8.Gtk.Box+BoxChild
			this.txtIDEmpresa = new global::Gtk.Entry();
			this.txtIDEmpresa.CanFocus = true;
			this.txtIDEmpresa.Name = "txtIDEmpresa";
			this.txtIDEmpresa.IsEditable = true;
			this.txtIDEmpresa.InvisibleChar = '•';
			this.vbox8.Add(this.txtIDEmpresa);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.txtIDEmpresa]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.txtNombreEmpresa = new global::Gtk.Entry();
			this.txtNombreEmpresa.CanFocus = true;
			this.txtNombreEmpresa.Name = "txtNombreEmpresa";
			this.txtNombreEmpresa.IsEditable = true;
			this.txtNombreEmpresa.InvisibleChar = '•';
			this.vbox8.Add(this.txtNombreEmpresa);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.txtNombreEmpresa]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			w18.Padding = ((uint)(2));
			// Container child vbox8.Gtk.Box+BoxChild
			this.txtNombreComercialEmpresa = new global::Gtk.Entry();
			this.txtNombreComercialEmpresa.CanFocus = true;
			this.txtNombreComercialEmpresa.Name = "txtNombreComercialEmpresa";
			this.txtNombreComercialEmpresa.IsEditable = true;
			this.txtNombreComercialEmpresa.InvisibleChar = '•';
			this.vbox8.Add(this.txtNombreComercialEmpresa);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.txtNombreComercialEmpresa]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Padding = ((uint)(2));
			// Container child vbox8.Gtk.Box+BoxChild
			this.txtDireccionEmpresa = new global::Gtk.Entry();
			this.txtDireccionEmpresa.CanFocus = true;
			this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
			this.txtDireccionEmpresa.IsEditable = true;
			this.txtDireccionEmpresa.InvisibleChar = '•';
			this.vbox8.Add(this.txtDireccionEmpresa);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.txtDireccionEmpresa]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			w20.Padding = ((uint)(2));
			// Container child vbox8.Gtk.Box+BoxChild
			this.vbox10 = new global::Gtk.VBox();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.txtLocalidadEmpresa = new global::Gtk.Entry();
			this.txtLocalidadEmpresa.CanFocus = true;
			this.txtLocalidadEmpresa.Name = "txtLocalidadEmpresa";
			this.txtLocalidadEmpresa.IsEditable = true;
			this.txtLocalidadEmpresa.InvisibleChar = '•';
			this.vbox10.Add(this.txtLocalidadEmpresa);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.txtLocalidadEmpresa]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			w21.Padding = ((uint)(3));
			// Container child vbox10.Gtk.Box+BoxChild
			this.txtCorreoEmpresa = new global::Gtk.Entry();
			this.txtCorreoEmpresa.CanFocus = true;
			this.txtCorreoEmpresa.Name = "txtCorreoEmpresa";
			this.txtCorreoEmpresa.IsEditable = true;
			this.txtCorreoEmpresa.InvisibleChar = '•';
			this.vbox10.Add(this.txtCorreoEmpresa);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.txtCorreoEmpresa]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			w22.Padding = ((uint)(2));
			// Container child vbox10.Gtk.Box+BoxChild
			this.cmbActiva = global::Gtk.ComboBox.NewText();
			this.cmbActiva.AppendText(global::Mono.Unix.Catalog.GetString("Si"));
			this.cmbActiva.AppendText(global::Mono.Unix.Catalog.GetString("No"));
			this.cmbActiva.Name = "cmbActiva";
			this.vbox10.Add(this.cmbActiva);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.cmbActiva]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox8.Add(this.vbox10);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.vbox10]));
			w24.Position = 4;
			w24.Expand = false;
			w24.Fill = false;
			this.hbox5.Add(this.vbox8);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vbox8]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.vbox6.Add(this.hbox5);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox5]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox5.Add(this.vbox6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox6]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.alignment6 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment6.Name = "alignment6";
			// Container child alignment6.Gtk.Container+ContainerChild
			this.alignment2 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment2.Name = "alignment2";
			this.alignment6.Add(this.alignment2);
			this.hbox6.Add(this.alignment6);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.alignment6]));
			w29.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.alignment5 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment5.Name = "alignment5";
			// Container child alignment5.Gtk.Container+ContainerChild
			this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.btnNueva = new global::Gtk.Button();
			this.btnNueva.CanFocus = true;
			this.btnNueva.Name = "btnNueva";
			this.btnNueva.UseUnderline = true;
			this.btnNueva.Label = global::Mono.Unix.Catalog.GetString("Nueva");
			this.alignment1.Add(this.btnNueva);
			this.alignment5.Add(this.alignment1);
			this.hbox6.Add(this.alignment5);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.alignment5]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnGenerar = new global::Gtk.Button();
			this.btnGenerar.CanFocus = true;
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.UseUnderline = true;
			this.btnGenerar.Label = global::Mono.Unix.Catalog.GetString("Generar");
			this.hbox6.Add(this.btnGenerar);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.btnGenerar]));
			w33.Position = 3;
			w33.Expand = false;
			w33.Fill = false;
			w33.Padding = ((uint)(20));
			this.vbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox6]));
			w34.Position = 2;
			w34.Expand = false;
			w34.Fill = false;
			this.Add(this.vbox5);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 458;
			this.DefaultHeight = 414;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
			this.btnNueva.Clicked += new global::System.EventHandler(this.OnBtnNuevaClicked);
			this.btnGenerar.Clicked += new global::System.EventHandler(this.OnBtnGenerarClicked);
		}
	}
}
