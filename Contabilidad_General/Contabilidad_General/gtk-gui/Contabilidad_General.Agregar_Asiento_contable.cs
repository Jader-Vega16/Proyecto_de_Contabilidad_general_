
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Agregar_Asiento_contable
	{
		private global::Gtk.VBox vbox8;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Alignment alignment23;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox9;

		private global::Gtk.Label label4;

		private global::Gtk.HBox hbox11;

		private global::Gtk.HBox hbox14;

		private global::Gtk.Label label5;

		private global::Gtk.Entry txtCodigoAsiento;

		private global::Gtk.HBox hbox15;

		private global::Gtk.Label label7;

		private global::Gtk.Entry txtFecha;

		private global::Gtk.HBox hbox23;

		private global::Gtk.Label label13;

		private global::Gtk.ComboBox cmbIDUsuario;

		private global::Gtk.Label label15;

		private global::Gtk.ComboBox cmbIDEmpresa;

		private global::Gtk.Label label14;

		private global::Gtk.ComboBox cmbEstadoAsiento;

		private global::Gtk.HBox hbox24;

		private global::Gtk.VBox vbox15;

		private global::Gtk.Label label22;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView tvAsiento;

		private global::Gtk.VBox vbox16;

		private global::Gtk.Label label23;

		private global::Gtk.HBox hbox30;

		private global::Gtk.VBox vbox17;

		private global::Gtk.Label label25;

		private global::Gtk.ScrolledWindow scrolledwindow4;

		private global::Gtk.TreeView tvCuentasHaber;

		private global::Gtk.VBox vbox18;

		private global::Gtk.Label label24;

		private global::Gtk.ScrolledWindow scrolledwindow3;

		private global::Gtk.TreeView tvtCuentasDebe;

		private global::Gtk.VBox vbox10;

		private global::Gtk.HBox hbox25;

		private global::Gtk.Label label16;

		private global::Gtk.Entry txtIDCuentaDebe;

		private global::Gtk.HBox hbox26;

		private global::Gtk.Label label17;

		private global::Gtk.Entry txtImporteDebe;

		private global::Gtk.VBox vbox11;

		private global::Gtk.HBox hbox27;

		private global::Gtk.Label label18;

		private global::Gtk.Entry txtIDCuentaHaber;

		private global::Gtk.HBox hbox28;

		private global::Gtk.VBox vbox14;

		private global::Gtk.Label label19;

		private global::Gtk.Label label20;

		private global::Gtk.VBox vbox12;

		private global::Gtk.Entry txtImporteHaber;

		private global::Gtk.Entry txtCatalgoDeCuentas;

		private global::Gtk.HBox hbox29;

		private global::Gtk.Button btnNuevoAsiento;

		private global::Gtk.Button btnNuevoElemento;

		private global::Gtk.Button btnGuardar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Agregar_Asiento_contable
			this.Name = "Contabilidad_General.Agregar_Asiento_contable";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar_Asiento_contable");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Agregar_Asiento_contable.Gtk.Container+ContainerChild
			this.vbox8 = new global::Gtk.VBox();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.alignment23 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment23.Name = "alignment23";
			this.hbox10.Add(this.alignment23);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.alignment23]));
			w1.Position = 0;
			// Container child hbox10.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox10.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.btnSalir]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox8.Add(this.hbox10);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox10]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			this.vbox9.BorderWidth = ((uint)(3));
			// Container child vbox9.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Asiento Contable\n");
			this.vbox9.Add(this.label4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label4]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Codigo del Asiento:");
			this.hbox14.Add(this.label5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.label5]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.txtCodigoAsiento = new global::Gtk.Entry();
			this.txtCodigoAsiento.CanFocus = true;
			this.txtCodigoAsiento.Name = "txtCodigoAsiento";
			this.txtCodigoAsiento.IsEditable = true;
			this.txtCodigoAsiento.InvisibleChar = '•';
			this.hbox14.Add(this.txtCodigoAsiento);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.txtCodigoAsiento]));
			w6.Position = 1;
			this.hbox11.Add(this.hbox14);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.hbox14]));
			w7.Position = 0;
			// Container child hbox11.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha:");
			this.hbox15.Add(this.label7);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.label7]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.txtFecha = new global::Gtk.Entry();
			this.txtFecha.CanFocus = true;
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.IsEditable = true;
			this.txtFecha.InvisibleChar = '•';
			this.hbox15.Add(this.txtFecha);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.txtFecha]));
			w9.Position = 1;
			this.hbox11.Add(this.hbox15);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.hbox15]));
			w10.Position = 1;
			this.vbox9.Add(this.hbox11);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox11]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox23 = new global::Gtk.HBox();
			this.hbox23.Name = "hbox23";
			this.hbox23.Spacing = 6;
			this.hbox23.BorderWidth = ((uint)(3));
			// Container child hbox23.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario:");
			this.hbox23.Add(this.label13);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.label13]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox23.Gtk.Box+BoxChild
			this.cmbIDUsuario = global::Gtk.ComboBox.NewText();
			this.cmbIDUsuario.Name = "cmbIDUsuario";
			this.hbox23.Add(this.cmbIDUsuario);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.cmbIDUsuario]));
			w13.Position = 1;
			// Container child hbox23.Gtk.Box+BoxChild
			this.label15 = new global::Gtk.Label();
			this.label15.Name = "label15";
			this.label15.Xalign = 1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString("Empresa:");
			this.hbox23.Add(this.label15);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.label15]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox23.Gtk.Box+BoxChild
			this.cmbIDEmpresa = global::Gtk.ComboBox.NewText();
			this.cmbIDEmpresa.Name = "cmbIDEmpresa";
			this.hbox23.Add(this.cmbIDEmpresa);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.cmbIDEmpresa]));
			w15.Position = 3;
			// Container child hbox23.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label();
			this.label14.Name = "label14";
			this.label14.Xalign = 1F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString("Estado del Asiento:");
			this.hbox23.Add(this.label14);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.label14]));
			w16.Position = 4;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox23.Gtk.Box+BoxChild
			this.cmbEstadoAsiento = global::Gtk.ComboBox.NewText();
			this.cmbEstadoAsiento.AppendText(global::Mono.Unix.Catalog.GetString("Si"));
			this.cmbEstadoAsiento.AppendText(global::Mono.Unix.Catalog.GetString("No"));
			this.cmbEstadoAsiento.Name = "cmbEstadoAsiento";
			this.hbox23.Add(this.cmbEstadoAsiento);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.cmbEstadoAsiento]));
			w17.Position = 5;
			this.vbox9.Add(this.hbox23);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox23]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox8.Add(this.vbox9);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.vbox9]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox24 = new global::Gtk.HBox();
			this.hbox24.Name = "hbox24";
			this.hbox24.Spacing = 6;
			// Container child hbox24.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.label22 = new global::Gtk.Label();
			this.label22.Name = "label22";
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString("                                                                  Detalles del As" +
					"iento                                                                        ");
			this.vbox15.Add(this.label22);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.label22]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox15.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.scrolledwindow1.BorderWidth = ((uint)(3));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.tvAsiento = new global::Gtk.TreeView();
			this.tvAsiento.CanFocus = true;
			this.tvAsiento.Name = "tvAsiento";
			this.scrolledwindow1.Add(this.tvAsiento);
			this.vbox15.Add(this.scrolledwindow1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.scrolledwindow1]));
			w22.Position = 1;
			// Container child vbox15.Gtk.Box+BoxChild
			this.vbox16 = new global::Gtk.VBox();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 6;
			this.vbox16.BorderWidth = ((uint)(6));
			// Container child vbox16.Gtk.Box+BoxChild
			this.label23 = new global::Gtk.Label();
			this.label23.Name = "label23";
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString("Detalles de las cuentas");
			this.vbox16.Add(this.label23);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.label23]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.hbox30 = new global::Gtk.HBox();
			this.hbox30.Name = "hbox30";
			this.hbox30.Spacing = 6;
			// Container child hbox30.Gtk.Box+BoxChild
			this.vbox17 = new global::Gtk.VBox();
			this.vbox17.Name = "vbox17";
			this.vbox17.Spacing = 6;
			// Container child vbox17.Gtk.Box+BoxChild
			this.label25 = new global::Gtk.Label();
			this.label25.Name = "label25";
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString("Cuentas Haber                                                          ");
			this.vbox17.Add(this.label25);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.label25]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.scrolledwindow4 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow4.CanFocus = true;
			this.scrolledwindow4.Name = "scrolledwindow4";
			this.scrolledwindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow4.Gtk.Container+ContainerChild
			this.tvCuentasHaber = new global::Gtk.TreeView();
			this.tvCuentasHaber.CanFocus = true;
			this.tvCuentasHaber.Name = "tvCuentasHaber";
			this.scrolledwindow4.Add(this.tvCuentasHaber);
			this.vbox17.Add(this.scrolledwindow4);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.scrolledwindow4]));
			w26.Position = 1;
			this.hbox30.Add(this.vbox17);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.vbox17]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox30.Gtk.Box+BoxChild
			this.vbox18 = new global::Gtk.VBox();
			this.vbox18.Name = "vbox18";
			this.vbox18.Spacing = 6;
			// Container child vbox18.Gtk.Box+BoxChild
			this.label24 = new global::Gtk.Label();
			this.label24.Name = "label24";
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString("Cuentas Debe                                                         ");
			this.vbox18.Add(this.label24);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.label24]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox18.Gtk.Box+BoxChild
			this.scrolledwindow3 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow3.CanFocus = true;
			this.scrolledwindow3.Name = "scrolledwindow3";
			this.scrolledwindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow3.Gtk.Container+ContainerChild
			this.tvtCuentasDebe = new global::Gtk.TreeView();
			this.tvtCuentasDebe.CanFocus = true;
			this.tvtCuentasDebe.Name = "tvtCuentasDebe";
			this.scrolledwindow3.Add(this.tvtCuentasDebe);
			this.vbox18.Add(this.scrolledwindow3);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.scrolledwindow3]));
			w30.Position = 1;
			this.hbox30.Add(this.vbox18);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.vbox18]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			this.vbox16.Add(this.hbox30);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.hbox30]));
			w32.Position = 1;
			this.vbox15.Add(this.vbox16);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.vbox16]));
			w33.Position = 2;
			this.hbox24.Add(this.vbox15);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox24[this.vbox15]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbox24.Gtk.Box+BoxChild
			this.vbox10 = new global::Gtk.VBox();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			this.vbox10.BorderWidth = ((uint)(18));
			// Container child vbox10.Gtk.Box+BoxChild
			this.hbox25 = new global::Gtk.HBox();
			this.hbox25.Name = "hbox25";
			this.hbox25.Spacing = 6;
			// Container child hbox25.Gtk.Box+BoxChild
			this.label16 = new global::Gtk.Label();
			this.label16.Name = "label16";
			this.label16.Xalign = 1F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString("            ID de la Cuenta debe:");
			this.hbox25.Add(this.label16);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.label16]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			w35.Padding = ((uint)(2));
			// Container child hbox25.Gtk.Box+BoxChild
			this.txtIDCuentaDebe = new global::Gtk.Entry();
			this.txtIDCuentaDebe.CanFocus = true;
			this.txtIDCuentaDebe.Name = "txtIDCuentaDebe";
			this.txtIDCuentaDebe.IsEditable = true;
			this.txtIDCuentaDebe.InvisibleChar = '•';
			this.hbox25.Add(this.txtIDCuentaDebe);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.txtIDCuentaDebe]));
			w36.Position = 1;
			this.vbox10.Add(this.hbox25);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.hbox25]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.hbox26 = new global::Gtk.HBox();
			this.hbox26.Name = "hbox26";
			this.hbox26.Spacing = 6;
			// Container child hbox26.Gtk.Box+BoxChild
			this.label17 = new global::Gtk.Label();
			this.label17.Name = "label17";
			this.label17.Xalign = 1F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString("                           Importe Debe:");
			this.hbox26.Add(this.label17);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox26[this.label17]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			w38.Padding = ((uint)(1));
			// Container child hbox26.Gtk.Box+BoxChild
			this.txtImporteDebe = new global::Gtk.Entry();
			this.txtImporteDebe.CanFocus = true;
			this.txtImporteDebe.Name = "txtImporteDebe";
			this.txtImporteDebe.IsEditable = true;
			this.txtImporteDebe.InvisibleChar = '•';
			this.hbox26.Add(this.txtImporteDebe);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox26[this.txtImporteDebe]));
			w39.Position = 1;
			this.vbox10.Add(this.hbox26);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.hbox26]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox10.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox27 = new global::Gtk.HBox();
			this.hbox27.Name = "hbox27";
			this.hbox27.Spacing = 6;
			// Container child hbox27.Gtk.Box+BoxChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.Xalign = 1F;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("           ID de la Cuenta Haber:");
			this.hbox27.Add(this.label18);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox27[this.label18]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbox27.Gtk.Box+BoxChild
			this.txtIDCuentaHaber = new global::Gtk.Entry();
			this.txtIDCuentaHaber.CanFocus = true;
			this.txtIDCuentaHaber.Name = "txtIDCuentaHaber";
			this.txtIDCuentaHaber.IsEditable = true;
			this.txtIDCuentaHaber.InvisibleChar = '•';
			this.hbox27.Add(this.txtIDCuentaHaber);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox27[this.txtIDCuentaHaber]));
			w42.Position = 1;
			this.vbox11.Add(this.hbox27);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox27]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox28 = new global::Gtk.HBox();
			this.hbox28.Name = "hbox28";
			this.hbox28.Spacing = 6;
			// Container child hbox28.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.Xalign = 1F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Importe Haber:");
			this.vbox14.Add(this.label19);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label19]));
			w44.Position = 0;
			w44.Expand = false;
			w44.Fill = false;
			w44.Padding = ((uint)(8));
			// Container child vbox14.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label();
			this.label20.Name = "label20";
			this.label20.Xalign = 1F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Catalogo de Cuentas:");
			this.vbox14.Add(this.label20);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label20]));
			w45.Position = 1;
			w45.Expand = false;
			w45.Fill = false;
			this.hbox28.Add(this.vbox14);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.vbox14]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox28.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.txtImporteHaber = new global::Gtk.Entry();
			this.txtImporteHaber.CanFocus = true;
			this.txtImporteHaber.Name = "txtImporteHaber";
			this.txtImporteHaber.IsEditable = true;
			this.txtImporteHaber.InvisibleChar = '•';
			this.vbox12.Add(this.txtImporteHaber);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.txtImporteHaber]));
			w47.Position = 0;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.txtCatalgoDeCuentas = new global::Gtk.Entry();
			this.txtCatalgoDeCuentas.CanFocus = true;
			this.txtCatalgoDeCuentas.Name = "txtCatalgoDeCuentas";
			this.txtCatalgoDeCuentas.IsEditable = true;
			this.txtCatalgoDeCuentas.InvisibleChar = '•';
			this.vbox12.Add(this.txtCatalgoDeCuentas);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.txtCatalgoDeCuentas]));
			w48.Position = 1;
			w48.Expand = false;
			w48.Fill = false;
			this.hbox28.Add(this.vbox12);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.vbox12]));
			w49.Position = 1;
			this.vbox11.Add(this.hbox28);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox28]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox29 = new global::Gtk.HBox();
			this.hbox29.Name = "hbox29";
			this.hbox29.Spacing = 6;
			// Container child hbox29.Gtk.Box+BoxChild
			this.btnNuevoAsiento = new global::Gtk.Button();
			this.btnNuevoAsiento.CanFocus = true;
			this.btnNuevoAsiento.Name = "btnNuevoAsiento";
			this.btnNuevoAsiento.UseUnderline = true;
			this.btnNuevoAsiento.Label = global::Mono.Unix.Catalog.GetString("Nuevo Asiento");
			this.hbox29.Add(this.btnNuevoAsiento);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.btnNuevoAsiento]));
			w51.Position = 0;
			w51.Expand = false;
			w51.Fill = false;
			// Container child hbox29.Gtk.Box+BoxChild
			this.btnNuevoElemento = new global::Gtk.Button();
			this.btnNuevoElemento.CanFocus = true;
			this.btnNuevoElemento.Name = "btnNuevoElemento";
			this.btnNuevoElemento.UseUnderline = true;
			this.btnNuevoElemento.Label = global::Mono.Unix.Catalog.GetString("Nuevo Elemento");
			this.hbox29.Add(this.btnNuevoElemento);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.btnNuevoElemento]));
			w52.Position = 1;
			w52.Expand = false;
			w52.Fill = false;
			// Container child hbox29.Gtk.Box+BoxChild
			this.btnGuardar = new global::Gtk.Button();
			this.btnGuardar.CanFocus = true;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.UseUnderline = true;
			this.btnGuardar.Label = global::Mono.Unix.Catalog.GetString("    Guardar    ");
			this.hbox29.Add(this.btnGuardar);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.btnGuardar]));
			w53.Position = 2;
			w53.Expand = false;
			w53.Fill = false;
			this.vbox11.Add(this.hbox29);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox29]));
			w54.Position = 2;
			w54.Expand = false;
			w54.Fill = false;
			this.vbox10.Add(this.vbox11);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.vbox11]));
			w55.Position = 2;
			w55.Expand = false;
			w55.Fill = false;
			this.hbox24.Add(this.vbox10);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox24[this.vbox10]));
			w56.Position = 1;
			this.vbox8.Add(this.hbox24);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox24]));
			w57.Position = 2;
			this.Add(this.vbox8);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 944;
			this.DefaultHeight = 451;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
			this.tvCuentasHaber.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTvCuentasHaberRowActivated);
			this.tvtCuentasDebe.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTvtCuentasDebeRowActivated);
			this.btnNuevoAsiento.Clicked += new global::System.EventHandler(this.OnBtnNuevoAsientoClicked);
			this.btnNuevoElemento.Clicked += new global::System.EventHandler(this.OnBtnNuevoElementoClicked);
		}
	}
}
