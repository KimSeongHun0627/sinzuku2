namespace sinzuku
{
	partial class FormOptions
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            sinzuku.Hotkey hotkey1 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey2 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey3 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey4 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey5 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey6 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey7 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey8 = new sinzuku.Hotkey();
            sinzuku.Hotkey hotkey9 = new sinzuku.Hotkey();
            this.cbEraserEnabled = new System.Windows.Forms.CheckBox();
            this.cbPointerEnabled = new System.Windows.Forms.CheckBox();
            this.cbSnapEnabled = new System.Windows.Forms.CheckBox();
            this.cbUndoEnabled = new System.Windows.Forms.CheckBox();
            this.cbClearEnabled = new System.Windows.Forms.CheckBox();
            this.cbWidthEnabled = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbSnapPath = new System.Windows.Forms.TextBox();
            this.lbSnapshotsavepath = new System.Windows.Forms.Label();
            this.btSnapPath = new System.Windows.Forms.Button();
            this.lbNote = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCanvascursor = new System.Windows.Forms.Label();
            this.comboCanvasCursor = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbInkVisibleEnabled = new System.Windows.Forms.CheckBox();
            this.cbPanEnabled = new System.Windows.Forms.CheckBox();
            this.cbAllowDragging = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbAllowHotkeyInPointer = new System.Windows.Forms.CheckBox();
            this.lbHkInkVisible = new System.Windows.Forms.Label();
            this.lbHkSnapshot = new System.Windows.Forms.Label();
            this.lbHkClear = new System.Windows.Forms.Label();
            this.lbHkPan = new System.Windows.Forms.Label();
            this.lbHkPointer = new System.Windows.Forms.Label();
            this.lbHkRedo = new System.Windows.Forms.Label();
            this.lbHkUndo = new System.Windows.Forms.Label();
            this.lbHkEraser = new System.Windows.Forms.Label();
            this.lbGlobalHotkey = new System.Windows.Forms.Label();
            this.hiInkVisible = new sinzuku.HotkeyInputBox();
            this.hiSnapshot = new sinzuku.HotkeyInputBox();
            this.hiClear = new sinzuku.HotkeyInputBox();
            this.hiPan = new sinzuku.HotkeyInputBox();
            this.hiPointer = new sinzuku.HotkeyInputBox();
            this.hiRedo = new sinzuku.HotkeyInputBox();
            this.hiUndo = new sinzuku.HotkeyInputBox();
            this.hiEraser = new sinzuku.HotkeyInputBox();
            this.hiGlobal = new sinzuku.HotkeyInputBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbEraserEnabled
            // 
            this.cbEraserEnabled.AutoSize = true;
            this.cbEraserEnabled.Location = new System.Drawing.Point(45, 75);
            this.cbEraserEnabled.Name = "cbEraserEnabled";
            this.cbEraserEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbEraserEnabled.TabIndex = 0;
            this.cbEraserEnabled.UseVisualStyleBackColor = true;
            this.cbEraserEnabled.CheckedChanged += new System.EventHandler(this.cbEraserEnabled_CheckedChanged);
            // 
            // cbPointerEnabled
            // 
            this.cbPointerEnabled.AutoSize = true;
            this.cbPointerEnabled.Location = new System.Drawing.Point(160, 75);
            this.cbPointerEnabled.Name = "cbPointerEnabled";
            this.cbPointerEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbPointerEnabled.TabIndex = 0;
            this.cbPointerEnabled.UseVisualStyleBackColor = true;
            this.cbPointerEnabled.CheckedChanged += new System.EventHandler(this.cbPointerEnabled_CheckedChanged);
            // 
            // cbSnapEnabled
            // 
            this.cbSnapEnabled.AutoSize = true;
            this.cbSnapEnabled.Location = new System.Drawing.Point(380, 76);
            this.cbSnapEnabled.Name = "cbSnapEnabled";
            this.cbSnapEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbSnapEnabled.TabIndex = 0;
            this.cbSnapEnabled.UseVisualStyleBackColor = true;
            this.cbSnapEnabled.CheckedChanged += new System.EventHandler(this.cbSnapEnabled_CheckedChanged);
            // 
            // cbUndoEnabled
            // 
            this.cbUndoEnabled.AutoSize = true;
            this.cbUndoEnabled.Location = new System.Drawing.Point(440, 76);
            this.cbUndoEnabled.Name = "cbUndoEnabled";
            this.cbUndoEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbUndoEnabled.TabIndex = 0;
            this.cbUndoEnabled.UseVisualStyleBackColor = true;
            this.cbUndoEnabled.CheckedChanged += new System.EventHandler(this.cbUndoEnabled_CheckedChanged);
            // 
            // cbClearEnabled
            // 
            this.cbClearEnabled.AutoSize = true;
            this.cbClearEnabled.Location = new System.Drawing.Point(497, 76);
            this.cbClearEnabled.Name = "cbClearEnabled";
            this.cbClearEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbClearEnabled.TabIndex = 0;
            this.cbClearEnabled.UseVisualStyleBackColor = true;
            this.cbClearEnabled.CheckedChanged += new System.EventHandler(this.cbClearEnabled_CheckedChanged);
            // 
            // cbWidthEnabled
            // 
            this.cbWidthEnabled.AutoSize = true;
            this.cbWidthEnabled.Location = new System.Drawing.Point(259, 77);
            this.cbWidthEnabled.Name = "cbWidthEnabled";
            this.cbWidthEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbWidthEnabled.TabIndex = 0;
            this.cbWidthEnabled.UseVisualStyleBackColor = true;
            this.cbWidthEnabled.CheckedChanged += new System.EventHandler(this.cbWidthEnabled_CheckedChanged);
            // 
            // tbSnapPath
            // 
            this.tbSnapPath.Location = new System.Drawing.Point(207, 182);
            this.tbSnapPath.Name = "tbSnapPath";
            this.tbSnapPath.Size = new System.Drawing.Size(293, 21);
            this.tbSnapPath.TabIndex = 1;
            this.tbSnapPath.ModifiedChanged += new System.EventHandler(this.tbSnapPath_ModifiedChanged);
            // 
            // lbSnapshotsavepath
            // 
            this.lbSnapshotsavepath.AutoSize = true;
            this.lbSnapshotsavepath.Location = new System.Drawing.Point(9, 187);
            this.lbSnapshotsavepath.Name = "lbSnapshotsavepath";
            this.lbSnapshotsavepath.Size = new System.Drawing.Size(117, 12);
            this.lbSnapshotsavepath.TabIndex = 2;
            this.lbSnapshotsavepath.Text = "Snapshot save path";
            // 
            // btSnapPath
            // 
            this.btSnapPath.Location = new System.Drawing.Point(507, 181);
            this.btSnapPath.Name = "btSnapPath";
            this.btSnapPath.Size = new System.Drawing.Size(36, 21);
            this.btSnapPath.TabIndex = 3;
            this.btSnapPath.Text = "...";
            this.btSnapPath.UseVisualStyleBackColor = true;
            this.btSnapPath.Click += new System.EventHandler(this.btSnapPath_Click);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(11, 295);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(377, 12);
            this.lbNote.TabIndex = 4;
            this.lbNote.Text = "Note: pen width panel overides each individual pen width settings";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCanvascursor
            // 
            this.lbCanvascursor.AutoSize = true;
            this.lbCanvascursor.Location = new System.Drawing.Point(11, 154);
            this.lbCanvascursor.Name = "lbCanvascursor";
            this.lbCanvascursor.Size = new System.Drawing.Size(88, 12);
            this.lbCanvascursor.TabIndex = 5;
            this.lbCanvascursor.Text = "Canvas cursor";
            // 
            // comboCanvasCursor
            // 
            this.comboCanvasCursor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCanvasCursor.FormattingEnabled = true;
            this.comboCanvasCursor.Items.AddRange(new object[] {
            "Arrow",
            "Pen tip"});
            this.comboCanvasCursor.Location = new System.Drawing.Point(207, 149);
            this.comboCanvasCursor.Name = "comboCanvasCursor";
            this.comboCanvasCursor.Size = new System.Drawing.Size(293, 20);
            this.comboCanvasCursor.TabIndex = 6;
            this.comboCanvasCursor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 423);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.comboCanvasCursor);
            this.tabPage1.Controls.Add(this.cbInkVisibleEnabled);
            this.tabPage1.Controls.Add(this.cbPanEnabled);
            this.tabPage1.Controls.Add(this.cbEraserEnabled);
            this.tabPage1.Controls.Add(this.lbCanvascursor);
            this.tabPage1.Controls.Add(this.cbWidthEnabled);
            this.tabPage1.Controls.Add(this.lbNote);
            this.tabPage1.Controls.Add(this.cbPointerEnabled);
            this.tabPage1.Controls.Add(this.btSnapPath);
            this.tabPage1.Controls.Add(this.cbSnapEnabled);
            this.tabPage1.Controls.Add(this.cbUndoEnabled);
            this.tabPage1.Controls.Add(this.cbClearEnabled);
            this.tabPage1.Controls.Add(this.lbSnapshotsavepath);
            this.tabPage1.Controls.Add(this.cbAllowDragging);
            this.tabPage1.Controls.Add(this.tbSnapPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1103, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sinzuku.Properties.Resources.paneloption;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 49);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cbInkVisibleEnabled
            // 
            this.cbInkVisibleEnabled.AutoSize = true;
            this.cbInkVisibleEnabled.Location = new System.Drawing.Point(320, 76);
            this.cbInkVisibleEnabled.Name = "cbInkVisibleEnabled";
            this.cbInkVisibleEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbInkVisibleEnabled.TabIndex = 0;
            this.cbInkVisibleEnabled.UseVisualStyleBackColor = true;
            this.cbInkVisibleEnabled.CheckedChanged += new System.EventHandler(this.cbInkVisibleEnabled_CheckedChanged);
            // 
            // cbPanEnabled
            // 
            this.cbPanEnabled.AutoSize = true;
            this.cbPanEnabled.Location = new System.Drawing.Point(101, 75);
            this.cbPanEnabled.Name = "cbPanEnabled";
            this.cbPanEnabled.Size = new System.Drawing.Size(15, 14);
            this.cbPanEnabled.TabIndex = 0;
            this.cbPanEnabled.UseVisualStyleBackColor = true;
            this.cbPanEnabled.CheckedChanged += new System.EventHandler(this.cbPanEnabled_CheckedChanged);
            // 
            // cbAllowDragging
            // 
            this.cbAllowDragging.AutoSize = true;
            this.cbAllowDragging.Location = new System.Drawing.Point(12, 247);
            this.cbAllowDragging.Name = "cbAllowDragging";
            this.cbAllowDragging.Size = new System.Drawing.Size(237, 16);
            this.cbAllowDragging.TabIndex = 0;
            this.cbAllowDragging.Text = "Allow dragging toolbar (experimental)";
            this.cbAllowDragging.UseVisualStyleBackColor = true;
            this.cbAllowDragging.CheckedChanged += new System.EventHandler(this.cbAllowDragging_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pens";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage3.Controls.Add(this.cbAllowHotkeyInPointer);
            this.tabPage3.Controls.Add(this.lbHkInkVisible);
            this.tabPage3.Controls.Add(this.lbHkSnapshot);
            this.tabPage3.Controls.Add(this.lbHkClear);
            this.tabPage3.Controls.Add(this.lbHkPan);
            this.tabPage3.Controls.Add(this.lbHkPointer);
            this.tabPage3.Controls.Add(this.lbHkRedo);
            this.tabPage3.Controls.Add(this.lbHkUndo);
            this.tabPage3.Controls.Add(this.lbHkEraser);
            this.tabPage3.Controls.Add(this.lbGlobalHotkey);
            this.tabPage3.Controls.Add(this.hiInkVisible);
            this.tabPage3.Controls.Add(this.hiSnapshot);
            this.tabPage3.Controls.Add(this.hiClear);
            this.tabPage3.Controls.Add(this.hiPan);
            this.tabPage3.Controls.Add(this.hiPointer);
            this.tabPage3.Controls.Add(this.hiRedo);
            this.tabPage3.Controls.Add(this.hiUndo);
            this.tabPage3.Controls.Add(this.hiEraser);
            this.tabPage3.Controls.Add(this.hiGlobal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1103, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hotkeys";
            // 
            // cbAllowHotkeyInPointer
            // 
            this.cbAllowHotkeyInPointer.AutoSize = true;
            this.cbAllowHotkeyInPointer.Location = new System.Drawing.Point(22, 80);
            this.cbAllowHotkeyInPointer.Name = "cbAllowHotkeyInPointer";
            this.cbAllowHotkeyInPointer.Size = new System.Drawing.Size(438, 16);
            this.cbAllowHotkeyInPointer.TabIndex = 18;
            this.cbAllowHotkeyInPointer.Text = "Allow all following hotkeys in mouse pointer mode (may cause a mess):";
            this.cbAllowHotkeyInPointer.UseVisualStyleBackColor = true;
            this.cbAllowHotkeyInPointer.CheckedChanged += new System.EventHandler(this.cbAllowHotkeyInPointer_CheckedChanged);
            // 
            // lbHkInkVisible
            // 
            this.lbHkInkVisible.AutoSize = true;
            this.lbHkInkVisible.Location = new System.Drawing.Point(275, 187);
            this.lbHkInkVisible.Name = "lbHkInkVisible";
            this.lbHkInkVisible.Size = new System.Drawing.Size(64, 12);
            this.lbHkInkVisible.TabIndex = 16;
            this.lbHkInkVisible.Text = "View/Hide";
            // 
            // lbHkSnapshot
            // 
            this.lbHkSnapshot.AutoSize = true;
            this.lbHkSnapshot.Location = new System.Drawing.Point(275, 211);
            this.lbHkSnapshot.Name = "lbHkSnapshot";
            this.lbHkSnapshot.Size = new System.Drawing.Size(58, 12);
            this.lbHkSnapshot.TabIndex = 12;
            this.lbHkSnapshot.Text = "Snapshot";
            // 
            // lbHkClear
            // 
            this.lbHkClear.AutoSize = true;
            this.lbHkClear.Location = new System.Drawing.Point(275, 286);
            this.lbHkClear.Name = "lbHkClear";
            this.lbHkClear.Size = new System.Drawing.Size(35, 12);
            this.lbHkClear.TabIndex = 13;
            this.lbHkClear.Text = "Clear";
            // 
            // lbHkPan
            // 
            this.lbHkPan.AutoSize = true;
            this.lbHkPan.Location = new System.Drawing.Point(275, 136);
            this.lbHkPan.Name = "lbHkPan";
            this.lbHkPan.Size = new System.Drawing.Size(27, 12);
            this.lbHkPan.TabIndex = 10;
            this.lbHkPan.Text = "Pan";
            // 
            // lbHkPointer
            // 
            this.lbHkPointer.AutoSize = true;
            this.lbHkPointer.Location = new System.Drawing.Point(275, 161);
            this.lbHkPointer.Name = "lbHkPointer";
            this.lbHkPointer.Size = new System.Drawing.Size(86, 12);
            this.lbHkPointer.TabIndex = 6;
            this.lbHkPointer.Text = "Mouse pointer";
            this.lbHkPointer.Visible = false;
            // 
            // lbHkRedo
            // 
            this.lbHkRedo.AutoSize = true;
            this.lbHkRedo.Location = new System.Drawing.Point(275, 261);
            this.lbHkRedo.Name = "lbHkRedo";
            this.lbHkRedo.Size = new System.Drawing.Size(34, 12);
            this.lbHkRedo.TabIndex = 7;
            this.lbHkRedo.Text = "Redo";
            // 
            // lbHkUndo
            // 
            this.lbHkUndo.AutoSize = true;
            this.lbHkUndo.Location = new System.Drawing.Point(275, 236);
            this.lbHkUndo.Name = "lbHkUndo";
            this.lbHkUndo.Size = new System.Drawing.Size(34, 12);
            this.lbHkUndo.TabIndex = 4;
            this.lbHkUndo.Text = "Undo";
            // 
            // lbHkEraser
            // 
            this.lbHkEraser.AutoSize = true;
            this.lbHkEraser.Location = new System.Drawing.Point(275, 111);
            this.lbHkEraser.Name = "lbHkEraser";
            this.lbHkEraser.Size = new System.Drawing.Size(42, 12);
            this.lbHkEraser.TabIndex = 4;
            this.lbHkEraser.Text = "Eraser";
            // 
            // lbGlobalHotkey
            // 
            this.lbGlobalHotkey.AutoSize = true;
            this.lbGlobalHotkey.Location = new System.Drawing.Point(20, 17);
            this.lbGlobalHotkey.Name = "lbGlobalHotkey";
            this.lbGlobalHotkey.Size = new System.Drawing.Size(425, 12);
            this.lbGlobalHotkey.TabIndex = 4;
            this.lbGlobalHotkey.Text = "Global hotkey (start drawing, switch between mouse pointer and drawing)";
            // 
            // hiInkVisible
            // 
            this.hiInkVisible.BackColor = System.Drawing.Color.White;
            this.hiInkVisible.ExternalConflictFlag = false;
            this.hiInkVisible.Hotkey = hotkey1;
            this.hiInkVisible.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiInkVisible.Location = new System.Drawing.Point(397, 187);
            this.hiInkVisible.Name = "hiInkVisible";
            this.hiInkVisible.RequireModifier = false;
            this.hiInkVisible.Size = new System.Drawing.Size(139, 21);
            this.hiInkVisible.TabIndex = 17;
            this.hiInkVisible.Text = "None";
            this.hiInkVisible.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiSnapshot
            // 
            this.hiSnapshot.BackColor = System.Drawing.Color.White;
            this.hiSnapshot.ExternalConflictFlag = false;
            this.hiSnapshot.Hotkey = hotkey2;
            this.hiSnapshot.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiSnapshot.Location = new System.Drawing.Point(397, 211);
            this.hiSnapshot.Name = "hiSnapshot";
            this.hiSnapshot.RequireModifier = false;
            this.hiSnapshot.Size = new System.Drawing.Size(139, 21);
            this.hiSnapshot.TabIndex = 14;
            this.hiSnapshot.Text = "None";
            this.hiSnapshot.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiClear
            // 
            this.hiClear.BackColor = System.Drawing.Color.White;
            this.hiClear.ExternalConflictFlag = false;
            this.hiClear.Hotkey = hotkey3;
            this.hiClear.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiClear.Location = new System.Drawing.Point(397, 286);
            this.hiClear.Name = "hiClear";
            this.hiClear.RequireModifier = false;
            this.hiClear.Size = new System.Drawing.Size(139, 21);
            this.hiClear.TabIndex = 15;
            this.hiClear.Text = "None";
            this.hiClear.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiPan
            // 
            this.hiPan.BackColor = System.Drawing.Color.White;
            this.hiPan.ExternalConflictFlag = false;
            this.hiPan.Hotkey = hotkey4;
            this.hiPan.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiPan.Location = new System.Drawing.Point(397, 136);
            this.hiPan.Name = "hiPan";
            this.hiPan.RequireModifier = false;
            this.hiPan.Size = new System.Drawing.Size(139, 21);
            this.hiPan.TabIndex = 11;
            this.hiPan.Text = "None";
            this.hiPan.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiPointer
            // 
            this.hiPointer.BackColor = System.Drawing.Color.White;
            this.hiPointer.ExternalConflictFlag = false;
            this.hiPointer.Hotkey = hotkey5;
            this.hiPointer.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiPointer.Location = new System.Drawing.Point(397, 161);
            this.hiPointer.Name = "hiPointer";
            this.hiPointer.RequireModifier = false;
            this.hiPointer.Size = new System.Drawing.Size(139, 21);
            this.hiPointer.TabIndex = 8;
            this.hiPointer.Text = "None";
            this.hiPointer.Visible = false;
            this.hiPointer.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiRedo
            // 
            this.hiRedo.BackColor = System.Drawing.Color.White;
            this.hiRedo.ExternalConflictFlag = false;
            this.hiRedo.Hotkey = hotkey6;
            this.hiRedo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiRedo.Location = new System.Drawing.Point(397, 261);
            this.hiRedo.Name = "hiRedo";
            this.hiRedo.RequireModifier = false;
            this.hiRedo.Size = new System.Drawing.Size(139, 21);
            this.hiRedo.TabIndex = 9;
            this.hiRedo.Text = "None";
            this.hiRedo.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiUndo
            // 
            this.hiUndo.BackColor = System.Drawing.Color.White;
            this.hiUndo.ExternalConflictFlag = false;
            this.hiUndo.Hotkey = hotkey7;
            this.hiUndo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiUndo.Location = new System.Drawing.Point(397, 236);
            this.hiUndo.Name = "hiUndo";
            this.hiUndo.RequireModifier = false;
            this.hiUndo.Size = new System.Drawing.Size(139, 21);
            this.hiUndo.TabIndex = 5;
            this.hiUndo.Text = "None";
            this.hiUndo.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiEraser
            // 
            this.hiEraser.BackColor = System.Drawing.Color.White;
            this.hiEraser.ExternalConflictFlag = false;
            this.hiEraser.Hotkey = hotkey8;
            this.hiEraser.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiEraser.Location = new System.Drawing.Point(397, 111);
            this.hiEraser.Name = "hiEraser";
            this.hiEraser.RequireModifier = false;
            this.hiEraser.Size = new System.Drawing.Size(139, 21);
            this.hiEraser.TabIndex = 5;
            this.hiEraser.Text = "None";
            this.hiEraser.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // hiGlobal
            // 
            this.hiGlobal.BackColor = System.Drawing.Color.White;
            this.hiGlobal.ExternalConflictFlag = false;
            this.hiGlobal.Hotkey = hotkey9;
            this.hiGlobal.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hiGlobal.Location = new System.Drawing.Point(22, 36);
            this.hiGlobal.Name = "hiGlobal";
            this.hiGlobal.RequireModifier = true;
            this.hiGlobal.Size = new System.Drawing.Size(139, 21);
            this.hiGlobal.TabIndex = 5;
            this.hiGlobal.Text = "None";
            this.hiGlobal.OnHotkeyChanged += new System.EventHandler(this.hi_OnHotkeyChanged);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(568, 418);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options - gInk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox cbEraserEnabled;
		private System.Windows.Forms.CheckBox cbPointerEnabled;
		private System.Windows.Forms.CheckBox cbSnapEnabled;
		private System.Windows.Forms.CheckBox cbUndoEnabled;
		private System.Windows.Forms.CheckBox cbClearEnabled;
		private System.Windows.Forms.CheckBox cbWidthEnabled;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox tbSnapPath;
		private System.Windows.Forms.Label lbSnapshotsavepath;
		private System.Windows.Forms.Button btSnapPath;
		private System.Windows.Forms.Label lbNote;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbCanvascursor;
		private System.Windows.Forms.ComboBox comboCanvasCursor;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lbGlobalHotkey;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox cbInkVisibleEnabled;
		private System.Windows.Forms.CheckBox cbPanEnabled;
		private System.Windows.Forms.CheckBox cbAllowDragging;
		private HotkeyInputBox hiGlobal;
		private HotkeyInputBox hiEraser;
		private System.Windows.Forms.Label lbHkEraser;
		private HotkeyInputBox hiUndo;
		private System.Windows.Forms.Label lbHkUndo;
		private HotkeyInputBox hiPointer;
		private HotkeyInputBox hiRedo;
		private System.Windows.Forms.Label lbHkPointer;
		private System.Windows.Forms.Label lbHkRedo;
		private HotkeyInputBox hiSnapshot;
		private HotkeyInputBox hiClear;
		private System.Windows.Forms.Label lbHkSnapshot;
		private System.Windows.Forms.Label lbHkClear;
		private HotkeyInputBox hiPan;
		private System.Windows.Forms.Label lbHkPan;
		private HotkeyInputBox hiInkVisible;
		private System.Windows.Forms.Label lbHkInkVisible;
		private System.Windows.Forms.CheckBox cbAllowHotkeyInPointer;
	}
}