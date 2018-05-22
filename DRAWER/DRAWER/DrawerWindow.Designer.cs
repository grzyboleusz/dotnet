namespace Drawer
{
    partial class DawerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DawerWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAERO = new System.Windows.Forms.RadioButton();
            this.radioButtonFLOOD_FILL = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFREEHAND = new System.Windows.Forms.RadioButton();
            this.radioButtonELLIPSE = new System.Windows.Forms.RadioButton();
            this.radioButtonLINE = new System.Windows.Forms.RadioButton();
            this.radioButtonRECT = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelCOLOR_MAIN = new System.Windows.Forms.Label();
            this.labelCOLOR_SECONDARY = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemNEW_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOPEN_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSAVE_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonIMAGE = new System.Windows.Forms.ToolStripDropDownButton();
            this.zmieńRozmiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonEDIT = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripUNDO = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTEXT_STRIKEOUT = new System.Windows.Forms.CheckBox();
            this.checkBoxTEXT_UNDERLINE = new System.Windows.Forms.CheckBox();
            this.comboBoxFONT_LIST = new System.Windows.Forms.ComboBox();
            this.checkBoxTEXT_ITALIC = new System.Windows.Forms.CheckBox();
            this.checkBoxTEXT_BOLD = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelOPENED_FILE = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonAERO);
            this.groupBox1.Controls.Add(this.radioButtonFLOOD_FILL);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.radioButtonFREEHAND);
            this.groupBox1.Controls.Add(this.radioButtonELLIPSE);
            this.groupBox1.Controls.Add(this.radioButtonLINE);
            this.groupBox1.Controls.Add(this.radioButtonRECT);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(656, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narzędzia";
            // 
            // radioButtonAERO
            // 
            this.radioButtonAERO.AutoSize = true;
            this.radioButtonAERO.Location = new System.Drawing.Point(375, 19);
            this.radioButtonAERO.Name = "radioButtonAERO";
            this.radioButtonAERO.Size = new System.Drawing.Size(65, 17);
            this.radioButtonAERO.TabIndex = 10;
            this.radioButtonAERO.Text = "Aerograf";
            this.radioButtonAERO.UseVisualStyleBackColor = true;
            this.radioButtonAERO.CheckedChanged += new System.EventHandler(this.radioButtonAERO_CheckedChanged);
            // 
            // radioButtonFLOOD_FILL
            // 
            this.radioButtonFLOOD_FILL.AutoSize = true;
            this.radioButtonFLOOD_FILL.Location = new System.Drawing.Point(273, 18);
            this.radioButtonFLOOD_FILL.Name = "radioButtonFLOOD_FILL";
            this.radioButtonFLOOD_FILL.Size = new System.Drawing.Size(96, 17);
            this.radioButtonFLOOD_FILL.TabIndex = 9;
            this.radioButtonFLOOD_FILL.Text = "Pomaluj obszar";
            this.radioButtonFLOOD_FILL.UseVisualStyleBackColor = true;
            this.radioButtonFLOOD_FILL.CheckedChanged += new System.EventHandler(this.radioButtonFLOOD_FILL_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kontur",
            "Jednolity",
            "Kontur i wypełnienie"});
            this.comboBox1.Location = new System.Drawing.Point(480, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(607, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButtonFREEHAND
            // 
            this.radioButtonFREEHAND.AutoSize = true;
            this.radioButtonFREEHAND.Location = new System.Drawing.Point(194, 19);
            this.radioButtonFREEHAND.Name = "radioButtonFREEHAND";
            this.radioButtonFREEHAND.Size = new System.Drawing.Size(73, 17);
            this.radioButtonFREEHAND.TabIndex = 3;
            this.radioButtonFREEHAND.Text = "Odręcznie";
            this.radioButtonFREEHAND.UseVisualStyleBackColor = true;
            this.radioButtonFREEHAND.CheckedChanged += new System.EventHandler(this.radioButtonPOINT_CheckedChanged);
            // 
            // radioButtonELLIPSE
            // 
            this.radioButtonELLIPSE.AutoSize = true;
            this.radioButtonELLIPSE.Location = new System.Drawing.Point(135, 19);
            this.radioButtonELLIPSE.Name = "radioButtonELLIPSE";
            this.radioButtonELLIPSE.Size = new System.Drawing.Size(53, 17);
            this.radioButtonELLIPSE.TabIndex = 2;
            this.radioButtonELLIPSE.Text = "Elipsa";
            this.radioButtonELLIPSE.UseVisualStyleBackColor = true;
            this.radioButtonELLIPSE.CheckedChanged += new System.EventHandler(this.radioButtonELIPSE_CheckedChanged);
            // 
            // radioButtonLINE
            // 
            this.radioButtonLINE.AutoSize = true;
            this.radioButtonLINE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButtonLINE.Checked = true;
            this.radioButtonLINE.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLINE.Name = "radioButtonLINE";
            this.radioButtonLINE.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLINE.TabIndex = 1;
            this.radioButtonLINE.TabStop = true;
            this.radioButtonLINE.Text = "Linia";
            this.radioButtonLINE.UseVisualStyleBackColor = true;
            this.radioButtonLINE.CheckedChanged += new System.EventHandler(this.radioButtonLINE_CheckedChanged);
            // 
            // radioButtonRECT
            // 
            this.radioButtonRECT.AutoSize = true;
            this.radioButtonRECT.Location = new System.Drawing.Point(59, 19);
            this.radioButtonRECT.Name = "radioButtonRECT";
            this.radioButtonRECT.Size = new System.Drawing.Size(70, 17);
            this.radioButtonRECT.TabIndex = 0;
            this.radioButtonRECT.Text = "Prostokąt";
            this.radioButtonRECT.UseVisualStyleBackColor = true;
            this.radioButtonRECT.CheckedChanged += new System.EventHandler(this.radioButtonRECT_CheckedChanged);
            // 
            // labelCOLOR_MAIN
            // 
            this.labelCOLOR_MAIN.BackColor = System.Drawing.Color.Black;
            this.labelCOLOR_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCOLOR_MAIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCOLOR_MAIN.Location = new System.Drawing.Point(9, 111);
            this.labelCOLOR_MAIN.Name = "labelCOLOR_MAIN";
            this.labelCOLOR_MAIN.Size = new System.Drawing.Size(30, 15);
            this.labelCOLOR_MAIN.TabIndex = 3;
            this.labelCOLOR_MAIN.Click += new System.EventHandler(this.labelCOLOR_Click);
            // 
            // labelCOLOR_SECONDARY
            // 
            this.labelCOLOR_SECONDARY.BackColor = System.Drawing.Color.White;
            this.labelCOLOR_SECONDARY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCOLOR_SECONDARY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCOLOR_SECONDARY.Location = new System.Drawing.Point(45, 111);
            this.labelCOLOR_SECONDARY.Name = "labelCOLOR_SECONDARY";
            this.labelCOLOR_SECONDARY.Size = new System.Drawing.Size(30, 15);
            this.labelCOLOR_SECONDARY.TabIndex = 4;
            this.labelCOLOR_SECONDARY.Click += new System.EventHandler(this.labelCOLOR_SECONDARY_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButtonIMAGE,
            this.toolStripDropDownButtonEDIT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNEW_FILE,
            this.toolStripMenuItemOPEN_FILE,
            this.toolStripMenuItemSAVE_FILE});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripDropDownButton1.Text = "Plik";
            // 
            // toolStripMenuItemNEW_FILE
            // 
            this.toolStripMenuItemNEW_FILE.Name = "toolStripMenuItemNEW_FILE";
            this.toolStripMenuItemNEW_FILE.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemNEW_FILE.Text = "Nowy";
            this.toolStripMenuItemNEW_FILE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItemNEW_FILE.Click += new System.EventHandler(this.toolStripMenuItemNEW_FILE_Click);
            // 
            // toolStripMenuItemOPEN_FILE
            // 
            this.toolStripMenuItemOPEN_FILE.Name = "toolStripMenuItemOPEN_FILE";
            this.toolStripMenuItemOPEN_FILE.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemOPEN_FILE.Text = "Otwórz...";
            this.toolStripMenuItemOPEN_FILE.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItemSAVE_FILE
            // 
            this.toolStripMenuItemSAVE_FILE.Name = "toolStripMenuItemSAVE_FILE";
            this.toolStripMenuItemSAVE_FILE.Size = new System.Drawing.Size(121, 22);
            this.toolStripMenuItemSAVE_FILE.Text = "Zapisz";
            this.toolStripMenuItemSAVE_FILE.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripDropDownButtonIMAGE
            // 
            this.toolStripDropDownButtonIMAGE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonIMAGE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńRozmiarToolStripMenuItem,
            this.wyczyśćToolStripMenuItem});
            this.toolStripDropDownButtonIMAGE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonIMAGE.Image")));
            this.toolStripDropDownButtonIMAGE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonIMAGE.Name = "toolStripDropDownButtonIMAGE";
            this.toolStripDropDownButtonIMAGE.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButtonIMAGE.Text = "Obraz";
            // 
            // zmieńRozmiarToolStripMenuItem
            // 
            this.zmieńRozmiarToolStripMenuItem.Name = "zmieńRozmiarToolStripMenuItem";
            this.zmieńRozmiarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.zmieńRozmiarToolStripMenuItem.Text = "Zmień rozmiar";
            this.zmieńRozmiarToolStripMenuItem.Click += new System.EventHandler(this.zmieńRozmiarToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonEDIT
            // 
            this.toolStripDropDownButtonEDIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonEDIT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUNDO});
            this.toolStripDropDownButtonEDIT.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonEDIT.Image")));
            this.toolStripDropDownButtonEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonEDIT.Name = "toolStripDropDownButtonEDIT";
            this.toolStripDropDownButtonEDIT.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButtonEDIT.Text = "Edycja";
            // 
            // toolStripUNDO
            // 
            this.toolStripUNDO.Enabled = false;
            this.toolStripUNDO.Name = "toolStripUNDO";
            this.toolStripUNDO.Size = new System.Drawing.Size(152, 22);
            this.toolStripUNDO.Text = "Cofnij";
            this.toolStripUNDO.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "Bez tytułu";
            this.saveFileDialog1.Filter = "Obrazy PNG|*.png";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "Obrazy PNG|*.png";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 484);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CausesValidation = false;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(379, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(221, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "przykładowy tekst";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 83);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 54);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rysowanie";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 54);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tekst";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.checkBoxTEXT_STRIKEOUT);
            this.groupBox2.Controls.Add(this.checkBoxTEXT_UNDERLINE);
            this.groupBox2.Controls.Add(this.comboBoxFONT_LIST);
            this.groupBox2.Controls.Add(this.checkBoxTEXT_ITALIC);
            this.groupBox2.Controls.Add(this.checkBoxTEXT_BOLD);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 47);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Czcionka i styl";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(158, 16);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // checkBoxTEXT_STRIKEOUT
            // 
            this.checkBoxTEXT_STRIKEOUT.AutoSize = true;
            this.checkBoxTEXT_STRIKEOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxTEXT_STRIKEOUT.Location = new System.Drawing.Point(333, 19);
            this.checkBoxTEXT_STRIKEOUT.Name = "checkBoxTEXT_STRIKEOUT";
            this.checkBoxTEXT_STRIKEOUT.Size = new System.Drawing.Size(33, 17);
            this.checkBoxTEXT_STRIKEOUT.TabIndex = 3;
            this.checkBoxTEXT_STRIKEOUT.Text = "S";
            this.checkBoxTEXT_STRIKEOUT.UseVisualStyleBackColor = true;
            this.checkBoxTEXT_STRIKEOUT.CheckedChanged += new System.EventHandler(this.checkBoxTEXT_STRIKEOUT_CheckedChanged);
            // 
            // checkBoxTEXT_UNDERLINE
            // 
            this.checkBoxTEXT_UNDERLINE.AutoSize = true;
            this.checkBoxTEXT_UNDERLINE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxTEXT_UNDERLINE.Location = new System.Drawing.Point(293, 19);
            this.checkBoxTEXT_UNDERLINE.Name = "checkBoxTEXT_UNDERLINE";
            this.checkBoxTEXT_UNDERLINE.Size = new System.Drawing.Size(34, 17);
            this.checkBoxTEXT_UNDERLINE.TabIndex = 2;
            this.checkBoxTEXT_UNDERLINE.Text = "U";
            this.checkBoxTEXT_UNDERLINE.UseVisualStyleBackColor = true;
            this.checkBoxTEXT_UNDERLINE.CheckedChanged += new System.EventHandler(this.checkBoxTEXT_UNDERLINE_CheckedChanged);
            // 
            // comboBoxFONT_LIST
            // 
            this.comboBoxFONT_LIST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFONT_LIST.FormattingEnabled = true;
            this.comboBoxFONT_LIST.Location = new System.Drawing.Point(2, 16);
            this.comboBoxFONT_LIST.Name = "comboBoxFONT_LIST";
            this.comboBoxFONT_LIST.Size = new System.Drawing.Size(150, 21);
            this.comboBoxFONT_LIST.TabIndex = 9;
            this.comboBoxFONT_LIST.SelectedIndexChanged += new System.EventHandler(this.comboBoxFONT_LIST_SelectedIndexChanged);
            // 
            // checkBoxTEXT_ITALIC
            // 
            this.checkBoxTEXT_ITALIC.AutoSize = true;
            this.checkBoxTEXT_ITALIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxTEXT_ITALIC.Location = new System.Drawing.Point(258, 19);
            this.checkBoxTEXT_ITALIC.Name = "checkBoxTEXT_ITALIC";
            this.checkBoxTEXT_ITALIC.Size = new System.Drawing.Size(29, 17);
            this.checkBoxTEXT_ITALIC.TabIndex = 1;
            this.checkBoxTEXT_ITALIC.Text = "I";
            this.checkBoxTEXT_ITALIC.UseVisualStyleBackColor = true;
            this.checkBoxTEXT_ITALIC.CheckedChanged += new System.EventHandler(this.checkBoxTEXT_ITALIC_CheckedChanged);
            // 
            // checkBoxTEXT_BOLD
            // 
            this.checkBoxTEXT_BOLD.AutoSize = true;
            this.checkBoxTEXT_BOLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxTEXT_BOLD.Location = new System.Drawing.Point(218, 19);
            this.checkBoxTEXT_BOLD.Name = "checkBoxTEXT_BOLD";
            this.checkBoxTEXT_BOLD.Size = new System.Drawing.Size(34, 17);
            this.checkBoxTEXT_BOLD.TabIndex = 0;
            this.checkBoxTEXT_BOLD.Text = "B";
            this.checkBoxTEXT_BOLD.UseVisualStyleBackColor = true;
            this.checkBoxTEXT_BOLD.CheckedChanged += new System.EventHandler(this.checkBoxTEXT_BOLD_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Czyść";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelOPENED_FILE});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelOPENED_FILE
            // 
            this.labelOPENED_FILE.Name = "labelOPENED_FILE";
            this.labelOPENED_FILE.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 638);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelCOLOR_SECONDARY);
            this.Controls.Add(this.labelCOLOR_MAIN);
            this.MinimumSize = new System.Drawing.Size(680, 200);
            this.Name = "Form1";
            this.Text = "Drawer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRECT;
        private System.Windows.Forms.RadioButton radioButtonELLIPSE;
        private System.Windows.Forms.RadioButton radioButtonLINE;
        private System.Windows.Forms.RadioButton radioButtonFREEHAND;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelCOLOR_MAIN;
        private System.Windows.Forms.Label labelCOLOR_SECONDARY;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNEW_FILE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOPEN_FILE;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSAVE_FILE;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButtonAERO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonFLOOD_FILL;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxFONT_LIST;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxTEXT_STRIKEOUT;
        private System.Windows.Forms.CheckBox checkBoxTEXT_UNDERLINE;
        private System.Windows.Forms.CheckBox checkBoxTEXT_ITALIC;
        private System.Windows.Forms.CheckBox checkBoxTEXT_BOLD;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelOPENED_FILE;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonIMAGE;
        private System.Windows.Forms.ToolStripMenuItem zmieńRozmiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonEDIT;
        private System.Windows.Forms.ToolStripMenuItem toolStripUNDO;
    }
}

