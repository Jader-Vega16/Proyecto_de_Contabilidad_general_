
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Agregar_Libro_diario
	{
		private global::Gtk.VBox vbox19;

		private global::Gtk.HBox hbox31;

		private global::Gtk.Alignment alignment25;

		private global::Gtk.Alignment alignment24;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox20;

		private global::Gtk.Label label26;

		private global::Gtk.HBox hbox35;

		private global::Gtk.Label label30;

		private global::Gtk.Entry txtFecha;

		private global::Gtk.Label label31;

		private global::Gtk.ComboBox cmbIDPeriodo;

		private global::Gtk.HBox hbox36;

		private global::Gtk.Label label32;

		private global::Gtk.ComboBox cmbIDUsuario;

		private global::Gtk.Label label33;

		private global::Gtk.ComboBox cmbIDEmpresa;

		private global::Gtk.Label label34;

		private global::Gtk.ComboBox cmbActivo;

		private global::Gtk.HBox hbox46;

		private global::Gtk.Label label40;

		private global::Gtk.Entry txtConcepto;

		private global::Gtk.HBox hbox37;

		private global::Gtk.VBox vbox24;

		private global::Gtk.Label label41;

		private global::Gtk.ScrolledWindow scrolledwindow5;

		private global::Gtk.TreeView tvDetallesLibro;

		private global::Gtk.VBox vbox25;

		private global::Gtk.Label label42;

		private global::Gtk.VBox vbox26;

		private global::Gtk.HBox hbox47;

		private global::Gtk.Label label43;

		private global::Gtk.Entry txtCodigoAsiento;

		private global::Gtk.Button btnDefinir;

		private global::Gtk.ScrolledWindow scrolledwindow6;

		private global::Gtk.TreeView tvAsiento;

		private global::Gtk.VBox vbox21;

		private global::Gtk.HBox hbox39;

		private global::Gtk.Label label36;

		private global::Gtk.Entry txtTotalDebe;

		private global::Gtk.VBox vbox22;

		private global::Gtk.HBox hbox40;

		private global::Gtk.Label label37;

		private global::Gtk.Entry txtTotalHaber;

		private global::Gtk.HBox hbox41;

		private global::Gtk.Label label38;

		private global::Gtk.Entry txtIDAsiento;

		private global::Gtk.HBox hbox42;

		private global::Gtk.Label label39;

		private global::Gtk.Entry txtIDCatalogo;

		private global::Gtk.VBox vbox23;

		private global::Gtk.HBox hbox45;

		private global::Gtk.Button btnNuevoLibro;

		private global::Gtk.Button btnNuevoElemento;

		private global::Gtk.Button btnGuardar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Agregar_Libro_diario
			this.Name = "Contabilidad_General.Agregar_Libro_diario";
			this.Title = global::Mono.Unix.Catalog.GetString("Agregar_Libro_diario");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Agregar_Libro_diario.Gtk.Container+ContainerChild
			this.vbox19 = new global::Gtk.VBox();
			this.vbox19.Name = "vbox19";
			this.vbox19.Spacing = 6;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hbox31 = new global::Gtk.HBox();
			this.hbox31.Name = "hbox31";
			this.hbox31.Spacing = 6;
			// Container child hbox31.Gtk.Box+BoxChild
			this.alignment25 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment25.Name = "alignment25";
			this.hbox31.Add(this.alignment25);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.alignment25]));
			w1.Position = 0;
			// Container child hbox31.Gtk.Box+BoxChild
			this.alignment24 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment24.Name = "alignment24";
			this.hbox31.Add(this.alignment24);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.alignment24]));
			w2.Position = 1;
			// Container child hbox31.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox31.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.btnSalir]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox19.Add(this.hbox31);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hbox31]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.vbox20 = new global::Gtk.VBox();
			this.vbox20.Name = "vbox20";
			this.vbox20.Spacing = 6;
			this.vbox20.BorderWidth = ((uint)(6));
			// Container child vbox20.Gtk.Box+BoxChild
			this.label26 = new global::Gtk.Label();
			this.label26.Name = "label26";
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString("Libro Diario");
			this.vbox20.Add(this.label26);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.label26]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox20.Gtk.Box+BoxChild
			this.hbox35 = new global::Gtk.HBox();
			this.hbox35.Name = "hbox35";
			this.hbox35.Spacing = 6;
			// Container child hbox35.Gtk.Box+BoxChild
			this.label30 = new global::Gtk.Label();
			this.label30.Name = "label30";
			this.label30.Xalign = 1F;
			this.label30.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha:");
			this.hbox35.Add(this.label30);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.label30]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox35.Gtk.Box+BoxChild
			this.txtFecha = new global::Gtk.Entry();
			this.txtFecha.CanFocus = true;
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.IsEditable = true;
			this.txtFecha.InvisibleChar = '•';
			this.hbox35.Add(this.txtFecha);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.txtFecha]));
			w7.Position = 1;
			// Container child hbox35.Gtk.Box+BoxChild
			this.label31 = new global::Gtk.Label();
			this.label31.Name = "label31";
			this.label31.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Periodo Contable:");
			this.hbox35.Add(this.label31);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.label31]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox35.Gtk.Box+BoxChild
			this.cmbIDPeriodo = global::Gtk.ComboBox.NewText();
			this.cmbIDPeriodo.Name = "cmbIDPeriodo";
			this.hbox35.Add(this.cmbIDPeriodo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.cmbIDPeriodo]));
			w9.Position = 3;
			this.vbox20.Add(this.hbox35);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.hbox35]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox20.Gtk.Box+BoxChild
			this.hbox36 = new global::Gtk.HBox();
			this.hbox36.Name = "hbox36";
			this.hbox36.Spacing = 6;
			// Container child hbox36.Gtk.Box+BoxChild
			this.label32 = new global::Gtk.Label();
			this.label32.Name = "label32";
			this.label32.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario:");
			this.hbox36.Add(this.label32);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.label32]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox36.Gtk.Box+BoxChild
			this.cmbIDUsuario = global::Gtk.ComboBox.NewText();
			this.cmbIDUsuario.Name = "cmbIDUsuario";
			this.hbox36.Add(this.cmbIDUsuario);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.cmbIDUsuario]));
			w12.Position = 1;
			// Container child hbox36.Gtk.Box+BoxChild
			this.label33 = new global::Gtk.Label();
			this.label33.Name = "label33";
			this.label33.LabelProp = global::Mono.Unix.Catalog.GetString("Empresa:");
			this.hbox36.Add(this.label33);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.label33]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox36.Gtk.Box+BoxChild
			this.cmbIDEmpresa = global::Gtk.ComboBox.NewText();
			this.cmbIDEmpresa.Name = "cmbIDEmpresa";
			this.hbox36.Add(this.cmbIDEmpresa);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.cmbIDEmpresa]));
			w14.Position = 3;
			// Container child hbox36.Gtk.Box+BoxChild
			this.label34 = new global::Gtk.Label();
			this.label34.Name = "label34";
			this.label34.LabelProp = global::Mono.Unix.Catalog.GetString("Estado del Libro:");
			this.hbox36.Add(this.label34);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.label34]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox36.Gtk.Box+BoxChild
			this.cmbActivo = global::Gtk.ComboBox.NewText();
			this.cmbActivo.AppendText(global::Mono.Unix.Catalog.GetString("Si"));
			this.cmbActivo.AppendText(global::Mono.Unix.Catalog.GetString("No"));
			this.cmbActivo.Name = "cmbActivo";
			this.hbox36.Add(this.cmbActivo);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.cmbActivo]));
			w16.Position = 5;
			this.vbox20.Add(this.hbox36);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.hbox36]));
			w17.Position = 2;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox19.Add(this.vbox20);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.vbox20]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hbox46 = new global::Gtk.HBox();
			this.hbox46.Name = "hbox46";
			this.hbox46.Spacing = 6;
			// Container child hbox46.Gtk.Box+BoxChild
			this.label40 = new global::Gtk.Label();
			this.label40.Name = "label40";
			this.label40.LabelProp = global::Mono.Unix.Catalog.GetString("Concepto de Movimiento:");
			this.hbox46.Add(this.label40);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox46[this.label40]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox46.Gtk.Box+BoxChild
			this.txtConcepto = new global::Gtk.Entry();
			this.txtConcepto.CanFocus = true;
			this.txtConcepto.Name = "txtConcepto";
			this.txtConcepto.IsEditable = true;
			this.txtConcepto.InvisibleChar = '•';
			this.hbox46.Add(this.txtConcepto);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox46[this.txtConcepto]));
			w20.Position = 1;
			this.vbox19.Add(this.hbox46);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hbox46]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hbox37 = new global::Gtk.HBox();
			this.hbox37.Name = "hbox37";
			this.hbox37.Spacing = 6;
			// Container child hbox37.Gtk.Box+BoxChild
			this.vbox24 = new global::Gtk.VBox();
			this.vbox24.Name = "vbox24";
			this.vbox24.Spacing = 6;
			// Container child vbox24.Gtk.Box+BoxChild
			this.label41 = new global::Gtk.Label();
			this.label41.Name = "label41";
			this.label41.LabelProp = global::Mono.Unix.Catalog.GetString("                        Detalles del Libro Diario                          ");
			this.vbox24.Add(this.label41);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox24[this.label41]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox24.Gtk.Box+BoxChild
			this.scrolledwindow5 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow5.CanFocus = true;
			this.scrolledwindow5.Name = "scrolledwindow5";
			this.scrolledwindow5.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow5.Gtk.Container+ContainerChild
			this.tvDetallesLibro = new global::Gtk.TreeView();
			this.tvDetallesLibro.CanFocus = true;
			this.tvDetallesLibro.Name = "tvDetallesLibro";
			this.scrolledwindow5.Add(this.tvDetallesLibro);
			this.vbox24.Add(this.scrolledwindow5);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox24[this.scrolledwindow5]));
			w24.Position = 1;
			// Container child vbox24.Gtk.Box+BoxChild
			this.vbox25 = new global::Gtk.VBox();
			this.vbox25.Name = "vbox25";
			this.vbox25.Spacing = 6;
			// Container child vbox25.Gtk.Box+BoxChild
			this.label42 = new global::Gtk.Label();
			this.label42.Name = "label42";
			this.label42.LabelProp = global::Mono.Unix.Catalog.GetString("Detalles de los Asientos contables");
			this.vbox25.Add(this.label42);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox25[this.label42]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox25.Gtk.Box+BoxChild
			this.vbox26 = new global::Gtk.VBox();
			this.vbox26.Name = "vbox26";
			this.vbox26.Spacing = 6;
			// Container child vbox26.Gtk.Box+BoxChild
			this.hbox47 = new global::Gtk.HBox();
			this.hbox47.Name = "hbox47";
			this.hbox47.Spacing = 6;
			// Container child hbox47.Gtk.Box+BoxChild
			this.label43 = new global::Gtk.Label();
			this.label43.Name = "label43";
			this.label43.LabelProp = global::Mono.Unix.Catalog.GetString("Codigo Asiento:");
			this.hbox47.Add(this.label43);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox47[this.label43]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox47.Gtk.Box+BoxChild
			this.txtCodigoAsiento = new global::Gtk.Entry();
			this.txtCodigoAsiento.CanFocus = true;
			this.txtCodigoAsiento.Name = "txtCodigoAsiento";
			this.txtCodigoAsiento.IsEditable = true;
			this.txtCodigoAsiento.InvisibleChar = '•';
			this.hbox47.Add(this.txtCodigoAsiento);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox47[this.txtCodigoAsiento]));
			w27.Position = 1;
			// Container child hbox47.Gtk.Box+BoxChild
			this.btnDefinir = new global::Gtk.Button();
			this.btnDefinir.CanFocus = true;
			this.btnDefinir.Name = "btnDefinir";
			this.btnDefinir.UseUnderline = true;
			this.btnDefinir.Label = global::Mono.Unix.Catalog.GetString("Definir");
			this.hbox47.Add(this.btnDefinir);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox47[this.btnDefinir]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox26.Add(this.hbox47);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.hbox47]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox26.Gtk.Box+BoxChild
			this.scrolledwindow6 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow6.CanFocus = true;
			this.scrolledwindow6.Name = "scrolledwindow6";
			this.scrolledwindow6.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow6.Gtk.Container+ContainerChild
			this.tvAsiento = new global::Gtk.TreeView();
			this.tvAsiento.CanFocus = true;
			this.tvAsiento.Name = "tvAsiento";
			this.scrolledwindow6.Add(this.tvAsiento);
			this.vbox26.Add(this.scrolledwindow6);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox26[this.scrolledwindow6]));
			w31.Position = 1;
			this.vbox25.Add(this.vbox26);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox25[this.vbox26]));
			w32.Position = 1;
			this.vbox24.Add(this.vbox25);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox24[this.vbox25]));
			w33.Position = 2;
			this.hbox37.Add(this.vbox24);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.vbox24]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbox37.Gtk.Box+BoxChild
			this.vbox21 = new global::Gtk.VBox();
			this.vbox21.Name = "vbox21";
			this.vbox21.Spacing = 6;
			this.vbox21.BorderWidth = ((uint)(18));
			// Container child vbox21.Gtk.Box+BoxChild
			this.hbox39 = new global::Gtk.HBox();
			this.hbox39.Name = "hbox39";
			this.hbox39.Spacing = 6;
			// Container child hbox39.Gtk.Box+BoxChild
			this.label36 = new global::Gtk.Label();
			this.label36.Name = "label36";
			this.label36.LabelProp = global::Mono.Unix.Catalog.GetString("                                  Total debe:");
			this.hbox39.Add(this.label36);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.label36]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox39.Gtk.Box+BoxChild
			this.txtTotalDebe = new global::Gtk.Entry();
			this.txtTotalDebe.CanFocus = true;
			this.txtTotalDebe.Name = "txtTotalDebe";
			this.txtTotalDebe.IsEditable = true;
			this.txtTotalDebe.InvisibleChar = '•';
			this.hbox39.Add(this.txtTotalDebe);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.txtTotalDebe]));
			w36.Position = 1;
			this.vbox21.Add(this.hbox39);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox21[this.hbox39]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox21.Gtk.Box+BoxChild
			this.vbox22 = new global::Gtk.VBox();
			this.vbox22.Name = "vbox22";
			this.vbox22.Spacing = 6;
			// Container child vbox22.Gtk.Box+BoxChild
			this.hbox40 = new global::Gtk.HBox();
			this.hbox40.Name = "hbox40";
			this.hbox40.Spacing = 6;
			// Container child hbox40.Gtk.Box+BoxChild
			this.label37 = new global::Gtk.Label();
			this.label37.Name = "label37";
			this.label37.LabelProp = global::Mono.Unix.Catalog.GetString("                               Total Haber:");
			this.hbox40.Add(this.label37);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox40[this.label37]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox40.Gtk.Box+BoxChild
			this.txtTotalHaber = new global::Gtk.Entry();
			this.txtTotalHaber.CanFocus = true;
			this.txtTotalHaber.Name = "txtTotalHaber";
			this.txtTotalHaber.IsEditable = true;
			this.txtTotalHaber.InvisibleChar = '•';
			this.hbox40.Add(this.txtTotalHaber);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox40[this.txtTotalHaber]));
			w39.Position = 1;
			this.vbox22.Add(this.hbox40);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.hbox40]));
			w40.Position = 0;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.hbox41 = new global::Gtk.HBox();
			this.hbox41.Name = "hbox41";
			this.hbox41.Spacing = 6;
			// Container child hbox41.Gtk.Box+BoxChild
			this.label38 = new global::Gtk.Label();
			this.label38.Name = "label38";
			this.label38.LabelProp = global::Mono.Unix.Catalog.GetString("     ID del Asiento Contable:");
			this.hbox41.Add(this.label38);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox41[this.label38]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbox41.Gtk.Box+BoxChild
			this.txtIDAsiento = new global::Gtk.Entry();
			this.txtIDAsiento.CanFocus = true;
			this.txtIDAsiento.Name = "txtIDAsiento";
			this.txtIDAsiento.IsEditable = true;
			this.txtIDAsiento.InvisibleChar = '•';
			this.hbox41.Add(this.txtIDAsiento);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox41[this.txtIDAsiento]));
			w42.Position = 1;
			this.vbox22.Add(this.hbox41);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.hbox41]));
			w43.Position = 1;
			w43.Expand = false;
			w43.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.hbox42 = new global::Gtk.HBox();
			this.hbox42.Name = "hbox42";
			this.hbox42.Spacing = 6;
			// Container child hbox42.Gtk.Box+BoxChild
			this.label39 = new global::Gtk.Label();
			this.label39.Name = "label39";
			this.label39.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Catalogo de Cuenta:");
			this.hbox42.Add(this.label39);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox42[this.label39]));
			w44.Position = 0;
			w44.Expand = false;
			w44.Fill = false;
			// Container child hbox42.Gtk.Box+BoxChild
			this.txtIDCatalogo = new global::Gtk.Entry();
			this.txtIDCatalogo.CanFocus = true;
			this.txtIDCatalogo.Name = "txtIDCatalogo";
			this.txtIDCatalogo.IsEditable = true;
			this.txtIDCatalogo.InvisibleChar = '•';
			this.hbox42.Add(this.txtIDCatalogo);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox42[this.txtIDCatalogo]));
			w45.Position = 1;
			this.vbox22.Add(this.hbox42);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.hbox42]));
			w46.Position = 2;
			w46.Expand = false;
			w46.Fill = false;
			// Container child vbox22.Gtk.Box+BoxChild
			this.vbox23 = new global::Gtk.VBox();
			this.vbox23.Name = "vbox23";
			this.vbox23.Spacing = 6;
			// Container child vbox23.Gtk.Box+BoxChild
			this.hbox45 = new global::Gtk.HBox();
			this.hbox45.Name = "hbox45";
			this.hbox45.Spacing = 6;
			// Container child hbox45.Gtk.Box+BoxChild
			this.btnNuevoLibro = new global::Gtk.Button();
			this.btnNuevoLibro.CanFocus = true;
			this.btnNuevoLibro.Name = "btnNuevoLibro";
			this.btnNuevoLibro.UseUnderline = true;
			this.btnNuevoLibro.Label = global::Mono.Unix.Catalog.GetString("Nuevo Libro");
			this.hbox45.Add(this.btnNuevoLibro);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox45[this.btnNuevoLibro]));
			w47.Position = 0;
			w47.Expand = false;
			w47.Fill = false;
			// Container child hbox45.Gtk.Box+BoxChild
			this.btnNuevoElemento = new global::Gtk.Button();
			this.btnNuevoElemento.CanFocus = true;
			this.btnNuevoElemento.Name = "btnNuevoElemento";
			this.btnNuevoElemento.UseUnderline = true;
			this.btnNuevoElemento.Label = global::Mono.Unix.Catalog.GetString("Nuevo Elemento");
			this.hbox45.Add(this.btnNuevoElemento);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox45[this.btnNuevoElemento]));
			w48.Position = 1;
			w48.Expand = false;
			w48.Fill = false;
			// Container child hbox45.Gtk.Box+BoxChild
			this.btnGuardar = new global::Gtk.Button();
			this.btnGuardar.CanFocus = true;
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.UseUnderline = true;
			this.btnGuardar.Label = global::Mono.Unix.Catalog.GetString("     Guardar   ");
			this.hbox45.Add(this.btnGuardar);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox45[this.btnGuardar]));
			w49.Position = 2;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox23.Add(this.hbox45);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox23[this.hbox45]));
			w50.Position = 0;
			w50.Expand = false;
			w50.Fill = false;
			this.vbox22.Add(this.vbox23);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox22[this.vbox23]));
			w51.Position = 3;
			w51.Expand = false;
			w51.Fill = false;
			this.vbox21.Add(this.vbox22);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox21[this.vbox22]));
			w52.Position = 1;
			w52.Expand = false;
			w52.Fill = false;
			this.hbox37.Add(this.vbox21);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.vbox21]));
			w53.Position = 1;
			this.vbox19.Add(this.hbox37);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hbox37]));
			w54.Position = 3;
			this.Add(this.vbox19);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 770;
			this.DefaultHeight = 469;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
			this.btnDefinir.Clicked += new global::System.EventHandler(this.OnBtnDefinirClicked);
			this.tvAsiento.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTvAsientoRowActivated);
			this.btnNuevoLibro.Clicked += new global::System.EventHandler(this.OnBtnNuevoLibroClicked);
			this.btnNuevoElemento.Clicked += new global::System.EventHandler(this.OnBtnNuevoElementoClicked);
		}
	}
}