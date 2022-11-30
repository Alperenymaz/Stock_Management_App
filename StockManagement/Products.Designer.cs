namespace StockManagement
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductDataGT = new Guna.UI.WinForms.GunaDataGridView();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.stok_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kalan_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sırano_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.adet_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kod_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fiber_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.core_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.marka_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.unicom_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.makara_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGT)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 142);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(1001, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1102, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1203, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 25);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Choose Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::StockManagement.Properties.Resources.white_hamburger_menu_icon_24;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 770);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 10);
            this.panel2.TabIndex = 1;
            // 
            // ProductDataGT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductDataGT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductDataGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataGT.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductDataGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductDataGT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDataGT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDataGT.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDataGT.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGT.EnableHeadersVisualStyles = false;
            this.ProductDataGT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGT.Location = new System.Drawing.Point(0, 144);
            this.ProductDataGT.Name = "ProductDataGT";
            this.ProductDataGT.RowHeadersVisible = false;
            this.ProductDataGT.RowTemplate.Height = 30;
            this.ProductDataGT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGT.Size = new System.Drawing.Size(1346, 620);
            this.ProductDataGT.TabIndex = 2;
            this.ProductDataGT.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProductDataGT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDataGT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDataGT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDataGT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDataGT.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductDataGT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ProductDataGT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ProductDataGT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductDataGT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDataGT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDataGT.ThemeStyle.HeaderStyle.Height = 20;
            this.ProductDataGT.ThemeStyle.ReadOnly = false;
            this.ProductDataGT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDataGT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDataGT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProductDataGT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDataGT.ThemeStyle.RowsStyle.Height = 30;
            this.ProductDataGT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDataGT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDataGT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataGT_CellContentClick);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menu_panel.Controls.Add(this.stok_textbox);
            this.menu_panel.Controls.Add(this.kalan_textbox);
            this.menu_panel.Controls.Add(this.sırano_textbox);
            this.menu_panel.Controls.Add(this.bunifuThinButton24);
            this.menu_panel.Controls.Add(this.adet_textbox);
            this.menu_panel.Controls.Add(this.kod_textbox);
            this.menu_panel.Controls.Add(this.fiber_textbox);
            this.menu_panel.Controls.Add(this.core_textbox);
            this.menu_panel.Controls.Add(this.marka_textbox);
            this.menu_panel.Controls.Add(this.bunifuThinButton21);
            this.menu_panel.Controls.Add(this.bunifuThinButton23);
            this.menu_panel.Controls.Add(this.bunifuCustomLabel1);
            this.menu_panel.Controls.Add(this.unicom_textbox);
            this.menu_panel.Controls.Add(this.makara_textbox);
            this.menu_panel.Location = new System.Drawing.Point(0, 138);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(481, 639);
            this.menu_panel.TabIndex = 4;
            this.menu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // stok_textbox
            // 
            this.stok_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stok_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stok_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stok_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.stok_textbox.HintText = "";
            this.stok_textbox.isPassword = false;
            this.stok_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.stok_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.stok_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.stok_textbox.LineThickness = 4;
            this.stok_textbox.Location = new System.Drawing.Point(13, 283);
            this.stok_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stok_textbox.Name = "stok_textbox";
            this.stok_textbox.Size = new System.Drawing.Size(224, 41);
            this.stok_textbox.TabIndex = 22;
            this.stok_textbox.Text = "Stok Çıkışı";
            this.stok_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kalan_textbox
            // 
            this.kalan_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kalan_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kalan_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalan_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kalan_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.kalan_textbox.HintText = "";
            this.kalan_textbox.isPassword = false;
            this.kalan_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.kalan_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.kalan_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.kalan_textbox.LineThickness = 4;
            this.kalan_textbox.Location = new System.Drawing.Point(245, 283);
            this.kalan_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kalan_textbox.Name = "kalan_textbox";
            this.kalan_textbox.Size = new System.Drawing.Size(224, 41);
            this.kalan_textbox.TabIndex = 21;
            this.kalan_textbox.Text = "Kalan";
            this.kalan_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sırano_textbox
            // 
            this.sırano_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sırano_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sırano_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sırano_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sırano_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.sırano_textbox.HintText = "";
            this.sırano_textbox.isPassword = false;
            this.sırano_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.sırano_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.sırano_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sırano_textbox.LineThickness = 4;
            this.sırano_textbox.Location = new System.Drawing.Point(13, 79);
            this.sırano_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sırano_textbox.Name = "sırano_textbox";
            this.sırano_textbox.Size = new System.Drawing.Size(224, 41);
            this.sırano_textbox.TabIndex = 20;
            this.sırano_textbox.Text = "Sıra No";
            this.sırano_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 2;
            this.bunifuThinButton24.ActiveCornerRadius = 15;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Home";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.Location = new System.Drawing.Point(4, 593);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(67, 41);
            this.bunifuThinButton24.TabIndex = 19;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // adet_textbox
            // 
            this.adet_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.adet_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adet_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adet_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adet_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.adet_textbox.HintText = "";
            this.adet_textbox.isPassword = false;
            this.adet_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.adet_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.adet_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adet_textbox.LineThickness = 4;
            this.adet_textbox.Location = new System.Drawing.Point(245, 232);
            this.adet_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adet_textbox.Name = "adet_textbox";
            this.adet_textbox.Size = new System.Drawing.Size(224, 41);
            this.adet_textbox.TabIndex = 18;
            this.adet_textbox.Text = "Adet";
            this.adet_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kod_textbox
            // 
            this.kod_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kod_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kod_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kod_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kod_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.kod_textbox.HintText = "";
            this.kod_textbox.isPassword = false;
            this.kod_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.kod_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.kod_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.kod_textbox.LineThickness = 4;
            this.kod_textbox.Location = new System.Drawing.Point(13, 232);
            this.kod_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kod_textbox.Name = "kod_textbox";
            this.kod_textbox.Size = new System.Drawing.Size(224, 41);
            this.kod_textbox.TabIndex = 17;
            this.kod_textbox.Text = "Kod";
            this.kod_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fiber_textbox
            // 
            this.fiber_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fiber_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fiber_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiber_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fiber_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.fiber_textbox.HintText = "";
            this.fiber_textbox.isPassword = false;
            this.fiber_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.fiber_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.fiber_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fiber_textbox.LineThickness = 4;
            this.fiber_textbox.Location = new System.Drawing.Point(245, 181);
            this.fiber_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fiber_textbox.Name = "fiber_textbox";
            this.fiber_textbox.Size = new System.Drawing.Size(224, 41);
            this.fiber_textbox.TabIndex = 16;
            this.fiber_textbox.Text = "Fiber Tipi";
            this.fiber_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // core_textbox
            // 
            this.core_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.core_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.core_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.core_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.core_textbox.HintText = "";
            this.core_textbox.isPassword = false;
            this.core_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.core_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.core_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.core_textbox.LineThickness = 4;
            this.core_textbox.Location = new System.Drawing.Point(13, 181);
            this.core_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.core_textbox.Name = "core_textbox";
            this.core_textbox.Size = new System.Drawing.Size(224, 41);
            this.core_textbox.TabIndex = 15;
            this.core_textbox.Text = "Core";
            this.core_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // marka_textbox
            // 
            this.marka_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.marka_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.marka_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marka_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.marka_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.marka_textbox.HintText = "";
            this.marka_textbox.isPassword = false;
            this.marka_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.marka_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.marka_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.marka_textbox.LineThickness = 4;
            this.marka_textbox.Location = new System.Drawing.Point(245, 130);
            this.marka_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.marka_textbox.Name = "marka_textbox";
            this.marka_textbox.Size = new System.Drawing.Size(224, 41);
            this.marka_textbox.TabIndex = 14;
            this.marka_textbox.Text = "Marka";
            this.marka_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 15;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Remove Product";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(9, 334);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(163, 41);
            this.bunifuThinButton21.TabIndex = 12;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 2;
            this.bunifuThinButton23.ActiveCornerRadius = 15;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Add Product";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.Location = new System.Drawing.Point(306, 334);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(163, 41);
            this.bunifuThinButton23.TabIndex = 11;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 30);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Add Product";
            // 
            // unicom_textbox
            // 
            this.unicom_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.unicom_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unicom_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unicom_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unicom_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.unicom_textbox.HintText = "";
            this.unicom_textbox.isPassword = false;
            this.unicom_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.unicom_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.unicom_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.unicom_textbox.LineThickness = 4;
            this.unicom_textbox.Location = new System.Drawing.Point(13, 130);
            this.unicom_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unicom_textbox.Name = "unicom_textbox";
            this.unicom_textbox.Size = new System.Drawing.Size(224, 41);
            this.unicom_textbox.TabIndex = 5;
            this.unicom_textbox.Text = "UniCom Kodları";
            this.unicom_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // makara_textbox
            // 
            this.makara_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.makara_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.makara_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makara_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.makara_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.makara_textbox.HintText = "";
            this.makara_textbox.isPassword = false;
            this.makara_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.makara_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.makara_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.makara_textbox.LineThickness = 4;
            this.makara_textbox.Location = new System.Drawing.Point(245, 79);
            this.makara_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makara_textbox.Name = "makara_textbox";
            this.makara_textbox.Size = new System.Drawing.Size(224, 41);
            this.makara_textbox.TabIndex = 4;
            this.makara_textbox.Text = "Makara No";
            this.makara_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.ProductDataGT);
            this.Controls.Add(this.panel2);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGT)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView ProductDataGT;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox unicom_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox makara_textbox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adet_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox kod_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fiber_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox core_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox marka_textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sırano_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stok_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox kalan_textbox;
    }
}