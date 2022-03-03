
namespace US_EXCHANGER.Presentation
{
    partial class FrmLogin
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
            this.txtUsuario = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtpass = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetComboBox1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usButton2 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.usButton1 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.usButton3 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteCustomSource = null;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsuario.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsuario.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsuario.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.txtUsuario.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsuario.Image = null;
            this.txtUsuario.IsDerivedStyle = true;
            this.txtUsuario.Lines = null;
            this.txtUsuario.Location = new System.Drawing.Point(364, 92);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(170, 25);
            this.txtUsuario.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUsuario.StyleManager = null;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.ThemeAuthor = "Narwin";
            this.txtUsuario.ThemeName = "MetroLite";
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.WatermarkText = "Ingrese el usuario";
            // 
            // txtpass
            // 
            this.txtpass.AutoCompleteCustomSource = null;
            this.txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtpass.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtpass.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtpass.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtpass.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.txtpass.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtpass.Image = null;
            this.txtpass.IsDerivedStyle = true;
            this.txtpass.Lines = null;
            this.txtpass.Location = new System.Drawing.Point(364, 149);
            this.txtpass.MaxLength = 32767;
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.ReadOnly = false;
            this.txtpass.Size = new System.Drawing.Size(170, 25);
            this.txtpass.Style = MetroSet_UI.Enums.Style.Light;
            this.txtpass.StyleManager = null;
            this.txtpass.TabIndex = 1;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.ThemeAuthor = "Narwin";
            this.txtpass.ThemeName = "MetroLite";
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.WatermarkText = "Ingrese la contraseña";
            // 
            // metroSetComboBox1
            // 
            this.metroSetComboBox1.AllowDrop = true;
            this.metroSetComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroSetComboBox1.CausesValidation = false;
            this.metroSetComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox1.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.metroSetComboBox1.FormattingEnabled = true;
            this.metroSetComboBox1.IsDerivedStyle = true;
            this.metroSetComboBox1.ItemHeight = 20;
            this.metroSetComboBox1.Items.AddRange(new object[] {
            "Empresa 000001",
            "Empresa 000002",
            "Empresa 000003"});
            this.metroSetComboBox1.Location = new System.Drawing.Point(364, 39);
            this.metroSetComboBox1.Name = "metroSetComboBox1";
            this.metroSetComboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox1.Size = new System.Drawing.Size(170, 26);
            this.metroSetComboBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetComboBox1.StyleManager = null;
            this.metroSetComboBox1.TabIndex = 4;
            this.metroSetComboBox1.ThemeAuthor = "Narwin";
            this.metroSetComboBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(264, 42);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(94, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 6;
            this.metroSetLabel1.Text = "Sociedad";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(264, 92);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(49, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 7;
            this.metroSetLabel2.Text = "Usuario";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(264, 149);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(94, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 8;
            this.metroSetLabel3.Text = "Contraseña";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 283);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "ExchangeUS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Unosoft 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::US_EXCHANGER.Properties.Resources.onuwhite;
            this.pictureBox1.Location = new System.Drawing.Point(81, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // usButton2
            // 
            this.usButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton2.BorderRadius = 0;
            this.usButton2.BorderSize = 0;
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.usButton2.ForeColor = System.Drawing.Color.White;
            this.usButton2.Location = new System.Drawing.Point(454, 224);
            this.usButton2.Name = "usButton2";
            this.usButton2.Size = new System.Drawing.Size(80, 30);
            this.usButton2.TabIndex = 10;
            this.usButton2.Text = "Cancelar";
            this.usButton2.TextColor = System.Drawing.Color.White;
            this.usButton2.UseVisualStyleBackColor = false;
            // 
            // usButton1
            // 
            this.usButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton1.BorderRadius = 0;
            this.usButton1.BorderSize = 0;
            this.usButton1.FlatAppearance.BorderSize = 0;
            this.usButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.usButton1.ForeColor = System.Drawing.Color.White;
            this.usButton1.Location = new System.Drawing.Point(264, 224);
            this.usButton1.Name = "usButton1";
            this.usButton1.Size = new System.Drawing.Size(80, 30);
            this.usButton1.TabIndex = 9;
            this.usButton1.Text = "Ingresar";
            this.usButton1.TextColor = System.Drawing.Color.White;
            this.usButton1.UseVisualStyleBackColor = false;
            this.usButton1.Click += new System.EventHandler(this.usButton1_Click);
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
            this.usButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.usButton3.ForeColor = System.Drawing.Color.White;
            this.usButton3.Location = new System.Drawing.Point(364, 220);
            this.usButton3.Name = "usButton3";
            this.usButton3.Size = new System.Drawing.Size(80, 38);
            this.usButton3.TabIndex = 12;
            this.usButton3.Text = "Cancelar";
            this.usButton3.TextColor = System.Drawing.Color.White;
            this.usButton3.UseVisualStyleBackColor = false;
            this.usButton3.Visible = false;
            this.usButton3.Click += new System.EventHandler(this.usButton3_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 282);
            this.Controls.Add(this.usButton3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usButton2);
            this.Controls.Add(this.usButton1);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetComboBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTextBox txtUsuario;
        private MetroSet_UI.Controls.MetroSetTextBox txtpass;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MenuControls.USButton usButton1;
        private MenuControls.USButton usButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MenuControls.USButton usButton3;
    }
}