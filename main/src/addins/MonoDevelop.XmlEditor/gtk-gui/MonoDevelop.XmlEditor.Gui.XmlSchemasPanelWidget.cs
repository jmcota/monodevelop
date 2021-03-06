
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.XmlEditor.Gui
{
	public partial class XmlSchemasPanelWidget
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label label1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView registeredSchemasView;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Button registeredSchemasAddButton;
		private global::Gtk.Button registeredSchemasRemoveButton;
		private global::Gtk.Label label3;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView defaultAssociationsView;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Button defaultAssociationsAddButton;
		private global::Gtk.Button defaultAssociationsRemoveButton;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.XmlEditor.Gui.XmlSchemasPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.XmlEditor.Gui.XmlSchemasPanelWidget";
			// Container child MonoDevelop.XmlEditor.Gui.XmlSchemasPanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Registered Schemas</b>");
			this.label1.UseMarkup = true;
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.registeredSchemasView = new global::Gtk.TreeView ();
			this.registeredSchemasView.CanFocus = true;
			this.registeredSchemasView.Name = "registeredSchemasView";
			this.GtkScrolledWindow.Add (this.registeredSchemasView);
			this.hbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.registeredSchemasAddButton = new global::Gtk.Button ();
			this.registeredSchemasAddButton.CanFocus = true;
			this.registeredSchemasAddButton.Name = "registeredSchemasAddButton";
			this.registeredSchemasAddButton.UseStock = true;
			this.registeredSchemasAddButton.UseUnderline = true;
			this.registeredSchemasAddButton.Label = "gtk-add";
			this.vbox2.Add (this.registeredSchemasAddButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.registeredSchemasAddButton]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.registeredSchemasRemoveButton = new global::Gtk.Button ();
			this.registeredSchemasRemoveButton.CanFocus = true;
			this.registeredSchemasRemoveButton.Name = "registeredSchemasRemoveButton";
			this.registeredSchemasRemoveButton.UseStock = true;
			this.registeredSchemasRemoveButton.UseUnderline = true;
			this.registeredSchemasRemoveButton.Label = "gtk-remove";
			this.vbox2.Add (this.registeredSchemasRemoveButton);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.registeredSchemasRemoveButton]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w7.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.vbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label3]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Default File Associations</b>");
			this.label2.UseMarkup = true;
			this.vbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label2]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.defaultAssociationsView = new global::Gtk.TreeView ();
			this.defaultAssociationsView.CanFocus = true;
			this.defaultAssociationsView.Name = "defaultAssociationsView";
			this.GtkScrolledWindow1.Add (this.defaultAssociationsView);
			this.hbox2.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.GtkScrolledWindow1]));
			w11.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.defaultAssociationsAddButton = new global::Gtk.Button ();
			this.defaultAssociationsAddButton.CanFocus = true;
			this.defaultAssociationsAddButton.Name = "defaultAssociationsAddButton";
			this.defaultAssociationsAddButton.UseStock = true;
			this.defaultAssociationsAddButton.UseUnderline = true;
			this.defaultAssociationsAddButton.Label = "gtk-add";
			this.vbox3.Add (this.defaultAssociationsAddButton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.defaultAssociationsAddButton]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.defaultAssociationsRemoveButton = new global::Gtk.Button ();
			this.defaultAssociationsRemoveButton.CanFocus = true;
			this.defaultAssociationsRemoveButton.Name = "defaultAssociationsRemoveButton";
			this.defaultAssociationsRemoveButton.UseStock = true;
			this.defaultAssociationsRemoveButton.UseUnderline = true;
			this.defaultAssociationsRemoveButton.Label = "gtk-remove";
			this.vbox3.Add (this.defaultAssociationsRemoveButton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.defaultAssociationsRemoveButton]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w15.Position = 4;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.registeredSchemasAddButton.Clicked += new global::System.EventHandler (this.addRegisteredSchema);
			this.registeredSchemasRemoveButton.Clicked += new global::System.EventHandler (this.removeRegisteredSchema);
			this.defaultAssociationsAddButton.Clicked += new global::System.EventHandler (this.addFileAssociation);
			this.defaultAssociationsRemoveButton.Clicked += new global::System.EventHandler (this.removeFileAssocation);
		}
	}
}
