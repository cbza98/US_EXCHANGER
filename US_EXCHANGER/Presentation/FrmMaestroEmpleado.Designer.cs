namespace US_EXCHANGER.Presentation
{
    partial class FrmMaestroEmpleado
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
            this.cmbDocIdent = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreComercial = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocIdent = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usButton5 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.usButton3 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.Text = "Maestro de empleado";
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.Location = new System.Drawing.Point(551, 390);
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            this.usButton1.Location = new System.Drawing.Point(437, 390);
            // 
            // cmbDocIdent
            // 
            this.cmbDocIdent.FormattingEnabled = true;
            this.cmbDocIdent.Location = new System.Drawing.Point(473, 64);
            this.cmbDocIdent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDocIdent.Name = "cmbDocIdent";
            this.cmbDocIdent.Size = new System.Drawing.Size(171, 23);
            this.cmbDocIdent.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(392, 67);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "Documento";
            // 
            // txtNombreComercial
            // 
            // 
            // 
            // 
            this.txtNombreComercial.CustomButton.Image = null;
            this.txtNombreComercial.CustomButton.Location = new System.Drawing.Point(473, 1);
            this.txtNombreComercial.CustomButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombreComercial.CustomButton.Name = "";
            this.txtNombreComercial.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNombreComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreComercial.CustomButton.TabIndex = 1;
            this.txtNombreComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreComercial.CustomButton.UseSelectable = true;
            this.txtNombreComercial.CustomButton.Visible = false;
            this.txtNombreComercial.Lines = new string[0];
            this.txtNombreComercial.Location = new System.Drawing.Point(145, 130);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreComercial.MaxLength = 32767;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.PasswordChar = '\0';
            this.txtNombreComercial.PromptText = "Ingrese la huella";
            this.txtNombreComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreComercial.SelectedText = "";
            this.txtNombreComercial.SelectionLength = 0;
            this.txtNombreComercial.SelectionStart = 0;
            this.txtNombreComercial.ShortcutsEnabled = true;
            this.txtNombreComercial.Size = new System.Drawing.Size(499, 27);
            this.txtNombreComercial.TabIndex = 29;
            this.txtNombreComercial.UseSelectable = true;
            this.txtNombreComercial.WaterMark = "Ingrese la huella";
            this.txtNombreComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7F);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Valor Huella";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(473, 1);
            this.txtNombre.CustomButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(145, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PromptText = "Ingrese nombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(499, 27);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMark = "Ingrese nombre";
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7F);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre";
            // 
            // txtDocIdent
            // 
            // 
            // 
            // 
            this.txtDocIdent.CustomButton.Image = null;
            this.txtDocIdent.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtDocIdent.CustomButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtDocIdent.CustomButton.Name = "";
            this.txtDocIdent.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDocIdent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocIdent.CustomButton.TabIndex = 1;
            this.txtDocIdent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocIdent.CustomButton.UseSelectable = true;
            this.txtDocIdent.CustomButton.Visible = false;
            this.txtDocIdent.Lines = new string[0];
            this.txtDocIdent.Location = new System.Drawing.Point(145, 64);
            this.txtDocIdent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDocIdent.MaxLength = 32767;
            this.txtDocIdent.Name = "txtDocIdent";
            this.txtDocIdent.PasswordChar = '\0';
            this.txtDocIdent.PromptText = "Ingrese número de documento";
            this.txtDocIdent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocIdent.SelectedText = "";
            this.txtDocIdent.SelectionLength = 0;
            this.txtDocIdent.SelectionStart = 0;
            this.txtDocIdent.ShortcutsEnabled = true;
            this.txtDocIdent.Size = new System.Drawing.Size(194, 27);
            this.txtDocIdent.TabIndex = 25;
            this.txtDocIdent.UseSelectable = true;
            this.txtDocIdent.WaterMark = "Ingrese número de documento";
            this.txtDocIdent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocIdent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7F);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ruc/DNI/Documento";
            // 
            // usButton5
            // 
            this.usButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton5.BorderRadius = 0;
            this.usButton5.BorderSize = 0;
            this.usButton5.FlatAppearance.BorderSize = 0;
            this.usButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usButton5.ForeColor = System.Drawing.Color.White;
            this.usButton5.Location = new System.Drawing.Point(389, 163);
            this.usButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usButton5.Name = "usButton5";
            this.usButton5.Size = new System.Drawing.Size(120, 25);
            this.usButton5.TabIndex = 32;
            this.usButton5.Text = "Enrolar huella";
            this.usButton5.TextColor = System.Drawing.Color.White;
            this.usButton5.UseVisualStyleBackColor = false;
            this.usButton5.Click += new System.EventHandler(this.usButton5_Click);
            // 
            // usButton3
            // 
            this.usButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton3.BorderRadius = 0;
            this.usButton3.BorderSize = 0;
            this.usButton3.FlatAppearance.BorderSize = 0;
            this.usButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usButton3.ForeColor = System.Drawing.Color.White;
            this.usButton3.Location = new System.Drawing.Point(517, 163);
            this.usButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usButton3.Name = "usButton3";
            this.usButton3.Size = new System.Drawing.Size(127, 25);
            this.usButton3.TabIndex = 33;
            this.usButton3.Text = "Verificar huella";
            this.usButton3.TextColor = System.Drawing.Color.White;
            this.usButton3.UseVisualStyleBackColor = false;
            this.usButton3.Click += new System.EventHandler(this.usButton3_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnListar.IconColor = System.Drawing.Color.White;
            this.btnListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListar.IconSize = 15;
            this.btnListar.Location = new System.Drawing.Point(346, 67);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(28, 20);
            this.btnListar.TabIndex = 54;
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmMaestroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 437);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.usButton3);
            this.Controls.Add(this.usButton5);
            this.Controls.Add(this.cmbDocIdent);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocIdent);
            this.Controls.Add(this.label2);
            this.Name = "FrmMaestroEmpleado";
            this.Text = "FrmMaestroEmpleado";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDocIdent, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNombreComercial, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.cmbDocIdent, 0);
            this.Controls.SetChildIndex(this.usButton5, 0);
            this.Controls.SetChildIndex(this.usButton3, 0);
            this.Controls.SetChildIndex(this.btnListar, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocIdent;
        private System.Windows.Forms.Label label16;
        private MetroFramework.Controls.MetroTextBox txtNombreComercial;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtDocIdent;
        private System.Windows.Forms.Label label2;
        public MenuControls.USButton usButton5;
        public MenuControls.USButton usButton3;
        private FontAwesome.Sharp.IconButton btnListar;
    }
}