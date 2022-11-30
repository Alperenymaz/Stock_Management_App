namespace StockManagement
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.users_label = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.uname_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.upassword_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userDataGT = new Guna.UI.WinForms.GunaDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGT)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.users_label);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 139);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(957, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "User List";
            // 
            // users_label
            // 
            this.users_label.AutoSize = true;
            this.users_label.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.users_label.Location = new System.Drawing.Point(3, 53);
            this.users_label.Name = "users_label";
            this.users_label.Size = new System.Drawing.Size(436, 86);
            this.users_label.TabIndex = 0;
            this.users_label.Text = "Users Settings";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 2;
            this.bunifuThinButton22.ActiveCornerRadius = 15;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Home";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(67, 41);
            this.bunifuThinButton22.TabIndex = 9;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // uname_textbox
            // 
            this.uname_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uname_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uname_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.uname_textbox.HintText = "";
            this.uname_textbox.isPassword = false;
            this.uname_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.uname_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.uname_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.uname_textbox.LineThickness = 4;
            this.uname_textbox.Location = new System.Drawing.Point(119, 273);
            this.uname_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uname_textbox.Name = "uname_textbox";
            this.uname_textbox.Size = new System.Drawing.Size(426, 41);
            this.uname_textbox.TabIndex = 3;
            this.uname_textbox.Text = "User Name";
            this.uname_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // upassword_textbox
            // 
            this.upassword_textbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.upassword_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upassword_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upassword_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upassword_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.upassword_textbox.HintText = "";
            this.upassword_textbox.isPassword = false;
            this.upassword_textbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.upassword_textbox.LineIdleColor = System.Drawing.Color.Teal;
            this.upassword_textbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.upassword_textbox.LineThickness = 4;
            this.upassword_textbox.Location = new System.Drawing.Point(119, 324);
            this.upassword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upassword_textbox.Name = "upassword_textbox";
            this.upassword_textbox.Size = new System.Drawing.Size(426, 41);
            this.upassword_textbox.TabIndex = 4;
            this.upassword_textbox.Text = "Password";
            this.upassword_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // userDataGT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.userDataGT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.userDataGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGT.BackgroundColor = System.Drawing.Color.Teal;
            this.userDataGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userDataGT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userDataGT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataGT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataGT.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userDataGT.DefaultCellStyle = dataGridViewCellStyle3;
            this.userDataGT.EnableHeadersVisualStyles = false;
            this.userDataGT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userDataGT.Location = new System.Drawing.Point(3, 0);
            this.userDataGT.Name = "userDataGT";
            this.userDataGT.ReadOnly = true;
            this.userDataGT.RowHeadersVisible = false;
            this.userDataGT.RowTemplate.Height = 30;
            this.userDataGT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGT.Size = new System.Drawing.Size(611, 646);
            this.userDataGT.TabIndex = 1;
            this.userDataGT.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.userDataGT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userDataGT.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userDataGT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userDataGT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userDataGT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userDataGT.ThemeStyle.BackColor = System.Drawing.Color.Teal;
            this.userDataGT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userDataGT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.userDataGT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.userDataGT.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userDataGT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userDataGT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userDataGT.ThemeStyle.HeaderStyle.Height = 20;
            this.userDataGT.ThemeStyle.ReadOnly = true;
            this.userDataGT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userDataGT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userDataGT.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userDataGT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userDataGT.ThemeStyle.RowsStyle.Height = 30;
            this.userDataGT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userDataGT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userDataGT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGT_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 778);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1355, 10);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.userDataGT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(738, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 639);
            this.panel3.TabIndex = 13;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 2;
            this.bunifuThinButton23.ActiveCornerRadius = 15;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Add User";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton23.Location = new System.Drawing.Point(382, 388);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(163, 41);
            this.bunifuThinButton23.TabIndex = 10;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 15;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Remove User";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton21.Location = new System.Drawing.Point(119, 388);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(163, 41);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 2;
            this.bunifuThinButton24.ActiveCornerRadius = 15;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.Teal;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Edit";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.Teal;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton24.Location = new System.Drawing.Point(568, 729);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(163, 41);
            this.bunifuThinButton24.TabIndex = 14;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 788);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.upassword_textbox);
            this.Controls.Add(this.uname_textbox);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGT)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label users_label;
        private Bunifu.Framework.UI.BunifuMaterialTextbox uname_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox upassword_textbox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Guna.UI.WinForms.GunaDataGridView userDataGT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
    }
}