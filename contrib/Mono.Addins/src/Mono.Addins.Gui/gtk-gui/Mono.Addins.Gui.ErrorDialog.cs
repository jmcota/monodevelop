// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Mono.Addins.Gui {
    
    
    internal partial class ErrorDialog {
        
        private Gtk.HBox hbox59;
        
        private Gtk.VBox vbox72;
        
        private Gtk.Image icon;
        
        private Gtk.VBox vbox73;
        
        private Gtk.Label descriptionLabel;
        
        private Gtk.Expander expander;
        
        private Gtk.ScrolledWindow scrolledwindow10;
        
        private Gtk.TextView detailsTextView;
        
        private Gtk.Label label102;
        
        private Gtk.Button okButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Mono.Addins.Gui.ErrorDialog
            this.Name = "Mono.Addins.Gui.ErrorDialog";
            this.Title = Mono.Unix.Catalog.GetString("Error");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.BorderWidth = ((uint)(6));
            // Internal child Mono.Addins.Gui.ErrorDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog-vbox5";
            w1.Spacing = 6;
            // Container child dialog-vbox5.Gtk.Box+BoxChild
            this.hbox59 = new Gtk.HBox();
            this.hbox59.Name = "hbox59";
            this.hbox59.Spacing = 6;
            this.hbox59.BorderWidth = ((uint)(6));
            // Container child hbox59.Gtk.Box+BoxChild
            this.vbox72 = new Gtk.VBox();
            this.vbox72.Name = "vbox72";
            // Container child vbox72.Gtk.Box+BoxChild
            this.icon = new Gtk.Image();
            this.icon.Name = "icon";
            this.icon.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-error", Gtk.IconSize.Dialog, 48);
            this.vbox72.Add(this.icon);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox72[this.icon]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.hbox59.Add(this.vbox72);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox59[this.vbox72]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox59.Gtk.Box+BoxChild
            this.vbox73 = new Gtk.VBox();
            this.vbox73.Name = "vbox73";
            this.vbox73.Spacing = 12;
            // Container child vbox73.Gtk.Box+BoxChild
            this.descriptionLabel = new Gtk.Label();
            this.descriptionLabel.WidthRequest = 540;
            this.descriptionLabel.CanFocus = true;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Xalign = 0F;
            this.descriptionLabel.LabelProp = "An exception has been thrown 1 2 3 4 5 6 7 8 9 10 11 12 13 14";
            this.descriptionLabel.Wrap = true;
            this.descriptionLabel.Selectable = true;
            this.vbox73.Add(this.descriptionLabel);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox73[this.descriptionLabel]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox73.Gtk.Box+BoxChild
            this.expander = new Gtk.Expander(null);
            this.expander.CanFocus = true;
            this.expander.Name = "expander";
            // Container child expander.Gtk.Container+ContainerChild
            this.scrolledwindow10 = new Gtk.ScrolledWindow();
            this.scrolledwindow10.CanFocus = true;
            this.scrolledwindow10.Name = "scrolledwindow10";
            this.scrolledwindow10.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow10.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow10.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow10.Gtk.Container+ContainerChild
            this.detailsTextView = new Gtk.TextView();
            this.detailsTextView.HeightRequest = 250;
            this.detailsTextView.CanFocus = true;
            this.detailsTextView.Name = "detailsTextView";
            this.detailsTextView.PixelsAboveLines = 2;
            this.detailsTextView.PixelsBelowLines = 2;
            this.detailsTextView.LeftMargin = 6;
            this.detailsTextView.RightMargin = 6;
            this.scrolledwindow10.Add(this.detailsTextView);
            this.expander.Add(this.scrolledwindow10);
            this.label102 = new Gtk.Label();
            this.label102.Name = "label102";
            this.label102.LabelProp = Mono.Unix.Catalog.GetString("Details");
            this.expander.LabelWidget = this.label102;
            this.vbox73.Add(this.expander);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox73[this.expander]));
            w7.Position = 1;
            this.hbox59.Add(this.vbox73);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox59[this.vbox73]));
            w8.Position = 1;
            w1.Add(this.hbox59);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.hbox59]));
            w9.Position = 0;
            // Internal child Mono.Addins.Gui.ErrorDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "dialog-action_area5";
            w10.Spacing = 10;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog-action_area5.Gtk.ButtonBox+ButtonBoxChild
            this.okButton = new Gtk.Button();
            this.okButton.CanDefault = true;
            this.okButton.CanFocus = true;
            this.okButton.Name = "okButton";
            this.okButton.UseStock = true;
            this.okButton.UseUnderline = true;
            this.okButton.Label = "gtk-ok";
            this.AddActionWidget(this.okButton, -5);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 632;
            this.DefaultHeight = 155;
            this.Show();
        }
    }
}
