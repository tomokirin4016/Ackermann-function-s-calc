
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action Action;

	private global::Gtk.Action Action1;

	private global::Gtk.Action Action2;

	private global::Gtk.Action Action3;

	private global::Gtk.Action Action4;

	private global::Gtk.Alignment alignment1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.VBox vbox5;

	private global::Gtk.MenuBar menubar2;

	private global::Gtk.Fixed fixed7;

	private global::Gtk.Label label4;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label Label1;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Entry entry1;

	private global::Gtk.Label label3;

	private global::Gtk.Entry entry2;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label Label2;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Entry entry4;

	private global::Gtk.Fixed fixed8;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Fixed fixed5;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Fixed fixed3;

	private global::Gtk.Button Button2;

	private global::Gtk.Fixed fixed4;

	private global::Gtk.Fixed fixed11;

	private global::Gtk.VBox vbox7;

	private global::Gtk.HBox hbox6;

	private global::Gtk.HBox hbox7;

	private global::Gtk.Fixed fixed2;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Entry entry3;

	private global::Gtk.ComboBoxEntry comboboxentry1;

	private global::Gtk.Label label1;

	private global::Gtk.Fixed fixed9;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label label5;

	private global::Gtk.Fixed fixed6;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.Action = new global::Gtk.Action("Action", global::Mono.Unix.Catalog.GetString("ファイル"), null, null);
		this.Action.ShortLabel = global::Mono.Unix.Catalog.GetString("ファイル");
		w1.Add(this.Action, null);
		this.Action1 = new global::Gtk.Action("Action1", global::Mono.Unix.Catalog.GetString("終了"), null, null);
		this.Action1.ShortLabel = global::Mono.Unix.Catalog.GetString("終了");
		w1.Add(this.Action1, null);
		this.Action2 = new global::Gtk.Action("Action2", global::Mono.Unix.Catalog.GetString("終了"), null, null);
		this.Action2.ShortLabel = global::Mono.Unix.Catalog.GetString("終了");
		w1.Add(this.Action2, null);
		this.Action3 = new global::Gtk.Action("Action3", global::Mono.Unix.Catalog.GetString("ベンチマーク"), null, null);
		this.Action3.ShortLabel = global::Mono.Unix.Catalog.GetString("ベンチマーク");
		w1.Add(this.Action3, null);
		this.Action4 = new global::Gtk.Action("Action4", global::Mono.Unix.Catalog.GetString("実行"), null, null);
		this.Action4.ShortLabel = global::Mono.Unix.Catalog.GetString("実行");
		w1.Add(this.Action4, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Ackermann function");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.HeightRequest = 150;
		this.vbox1.Name = "vbox1";
		this.vbox1.Homogeneous = true;
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		// Container child vbox5.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar2\'><menu name=\'Action\' action=\'Action\'><menuitem name=\'" +
				"Action2\' action=\'Action2\'/></menu><menu name=\'Action3\' action=\'Action3\'><menuite" +
				"m name=\'Action4\' action=\'Action4\'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar2")));
		this.menubar2.HeightRequest = 20;
		this.menubar2.Name = "menubar2";
		this.vbox5.Add(this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.menubar2]));
		w2.Position = 0;
		// Container child vbox5.Gtk.Box+BoxChild
		this.fixed7 = new global::Gtk.Fixed();
		this.fixed7.Name = "fixed7";
		this.fixed7.HasWindow = false;
		this.vbox5.Add(this.fixed7);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.fixed7]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.HeightRequest = 100;
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("アッカーマン関数計算");
		this.vbox5.Add(this.label4);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label4]));
		w4.Position = 2;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.Label1 = new global::Gtk.Label();
		this.Label1.Name = "Label1";
		this.Label1.Xalign = 1F;
		this.Label1.LabelProp = global::Mono.Unix.Catalog.GetString("Ack(");
		this.Label1.Justify = ((global::Gtk.Justification)(2));
		this.hbox2.Add(this.Label1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.Label1]));
		w5.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.WidthRequest = 50;
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.hbox3.Add(this.entry1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry1]));
		w6.Position = 0;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString(", ");
		this.hbox3.Add(this.label3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label3]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.WidthRequest = 50;
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.hbox3.Add(this.entry2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry2]));
		w8.Position = 2;
		this.hbox2.Add(this.hbox3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox3]));
		w9.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.Label2 = new global::Gtk.Label();
		this.Label2.Name = "Label2";
		this.Label2.LabelProp = global::Mono.Unix.Catalog.GetString(")  =");
		this.hbox4.Add(this.Label2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.Label2]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = false;
		this.entry4.InvisibleChar = '•';
		this.hbox5.Add(this.entry4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entry4]));
		w11.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.fixed8 = new global::Gtk.Fixed();
		this.fixed8.Name = "fixed8";
		this.fixed8.HasWindow = false;
		this.hbox5.Add(this.fixed8);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.fixed8]));
		w12.Position = 1;
		this.hbox4.Add(this.hbox5);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
		w13.Position = 1;
		w13.Padding = ((uint)(6));
		this.hbox2.Add(this.hbox4);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox4]));
		w14.Position = 2;
		this.vbox5.Add(this.hbox2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox2]));
		w15.Position = 3;
		w15.Expand = false;
		w15.Fill = false;
		this.vbox4.Add(this.vbox5);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox5]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox1.Add(this.vbox4);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox4]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fixed5 = new global::Gtk.Fixed();
		this.fixed5.Name = "fixed5";
		this.fixed5.HasWindow = false;
		this.vbox2.Add(this.fixed5);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.fixed5]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.fixed3 = new global::Gtk.Fixed();
		this.fixed3.HeightRequest = 30;
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		this.hbox1.Add(this.fixed3);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed3]));
		w19.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.Button2 = new global::Gtk.Button();
		this.Button2.HeightRequest = 30;
		this.Button2.CanFocus = true;
		this.Button2.Name = "Button2";
		this.Button2.UseUnderline = true;
		this.Button2.Label = global::Mono.Unix.Catalog.GetString("計算");
		this.hbox1.Add(this.Button2);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.Button2]));
		w20.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.fixed4 = new global::Gtk.Fixed();
		this.fixed4.HeightRequest = 10;
		this.fixed4.Name = "fixed4";
		this.fixed4.HasWindow = false;
		this.hbox1.Add(this.fixed4);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed4]));
		w21.Position = 2;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fixed11 = new global::Gtk.Fixed();
		this.fixed11.Name = "fixed11";
		this.fixed11.HasWindow = false;
		this.vbox2.Add(this.fixed11);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.fixed11]));
		w23.Position = 2;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.fixed2 = new global::Gtk.Fixed();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		this.hbox7.Add(this.fixed2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed2]));
		w24.Position = 0;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry();
		this.entry3.WidthRequest = 200;
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.hbox8.Add(this.entry3);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.entry3]));
		w25.Position = 0;
		// Container child hbox8.Gtk.Box+BoxChild
		this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText();
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("一"));
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("万"));
		this.comboboxentry1.AppendText(global::Mono.Unix.Catalog.GetString("億"));
		this.comboboxentry1.WidthRequest = 100;
		this.comboboxentry1.Name = "comboboxentry1";
		this.comboboxentry1.Active = 2;
		this.hbox8.Add(this.comboboxentry1);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.comboboxentry1]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("回計算終了ごとに通知する");
		this.hbox8.Add(this.label1);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label1]));
		w27.Position = 2;
		w27.Expand = false;
		w27.Fill = false;
		this.hbox7.Add(this.hbox8);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hbox8]));
		w28.Position = 1;
		// Container child hbox7.Gtk.Box+BoxChild
		this.fixed9 = new global::Gtk.Fixed();
		this.fixed9.Name = "fixed9";
		this.fixed9.HasWindow = false;
		this.hbox7.Add(this.fixed9);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed9]));
		w29.Position = 2;
		this.hbox6.Add(this.hbox7);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox7]));
		w30.Position = 0;
		this.vbox7.Add(this.hbox6);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox6]));
		w31.Position = 0;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.vbox7.Add(this.fixed1);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.fixed1]));
		w32.Position = 1;
		w32.Expand = false;
		w32.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("( 計算にかかった時間を表示します。)");
		this.vbox7.Add(this.label5);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label5]));
		w33.Position = 2;
		w33.Expand = false;
		w33.Fill = false;
		this.vbox2.Add(this.vbox7);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox7]));
		w34.Position = 3;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.fixed6 = new global::Gtk.Fixed();
		this.fixed6.Name = "fixed6";
		this.fixed6.HasWindow = false;
		this.vbox2.Add(this.fixed6);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.fixed6]));
		w35.Position = 4;
		w35.Expand = false;
		w35.Fill = false;
		this.vbox1.Add(this.vbox2);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
		w36.Position = 1;
		w36.Fill = false;
		this.alignment1.Add(this.vbox1);
		this.Add(this.alignment1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 560;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.Action1.Activated += new global::System.EventHandler(this.OnAction1Activated);
		this.Action2.Activated += new global::System.EventHandler(this.OnAction1Activated);
		this.Action4.Activated += new global::System.EventHandler(this.OnAction4Activated);
		this.Button2.Clicked += new global::System.EventHandler(this.Button1_Clicked);
	}
}
