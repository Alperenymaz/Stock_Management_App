namespace StockManagement
{
    partial class InventoryManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementSystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPass_checkBox = new System.Windows.Forms.CheckBox();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userName_textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.showPass_checkBox);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.userName_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(316, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 367);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showPass_checkBox
            // 
            this.showPass_checkBox.AutoSize = true;
            this.showPass_checkBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass_checkBox.Location = new System.Drawing.Point(134, 231);
            this.showPass_checkBox.Name = "showPass_checkBox";
            this.showPass_checkBox.Size = new System.Drawing.Size(107, 17);
            this.showPass_checkBox.TabIndex = 5;
            this.showPass_checkBox.Text = "Show Password";
            this.showPass_checkBox.UseVisualStyleBackColor = true;
            this.showPass_checkBox.CheckedChanged += new System.EventHandler(this.showPass_checkBox_CheckedChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SlateBlue;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_button.Location = new System.Drawing.Point(95, 311);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(83, 35);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password_textbox.ForeColor = System.Drawing.Color.Black;
            this.password_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.password_textbox.HintText = "";
            this.password_textbox.isPassword = true;
            this.password_textbox.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.password_textbox.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.password_textbox.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.password_textbox.LineThickness = 3;
            this.password_textbox.Location = new System.Drawing.Point(19, 191);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(217, 33);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.Text = "Password";
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_textbox.OnValueChanged += new System.EventHandler(this.password_textbox_OnValueChanged);
            // 
            // userName_textbox
            // 
            this.userName_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userName_textbox.ForeColor = System.Drawing.Color.Black;
            this.userName_textbox.HintForeColor = System.Drawing.Color.Empty;
            this.userName_textbox.HintText = "User Name";
            this.userName_textbox.isPassword = false;
            this.userName_textbox.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.userName_textbox.LineIdleColor = System.Drawing.Color.SlateBlue;
            this.userName_textbox.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.userName_textbox.LineThickness = 3;
            this.userName_textbox.Location = new System.Drawing.Point(19, 122);
            this.userName_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.userName_textbox.Name = "userName_textbox";
            this.userName_textbox.Size = new System.Drawing.Size(217, 33);
            this.userName_textbox.TabIndex = 2;
            this.userName_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userName_textbox.OnValueChanged += new System.EventHandler(this.userName_textbox_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "UniCom Universal Bilgisayar Hizmetleri";
            // 
            // InventoryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryManagementSystem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagementSystem";
            this.Load += new System.EventHandler(this.InventoryManagementSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showPass_checkBox;
        private System.Windows.Forms.Button login_button;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userName_textbox;
    }
}

