namespace US_EXCHANGER.Presentation.Maestros
{
    partial class FrmListadoClientesProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSiguiente = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.lblIndicadorbusqueda = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            this.usButton1.Location = new System.Drawing.Point(757, 508);
            this.usButton1.Text = "Nuevo";
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.Location = new System.Drawing.Point(845, 508);
            this.usButton2.Click += new System.EventHandler(this.usButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(976, 41);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.btnSiguiente.BorderRadius = 0;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(670, 507);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(80, 24);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Seleccionar";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dtListado
            // 
            this.dtListado.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtListado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.EnableHeadersVisualStyles = false;
            this.dtListado.Location = new System.Drawing.Point(12, 103);
            this.dtListado.MultiSelect = false;
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowHeadersVisible = false;
            this.dtListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListado.Size = new System.Drawing.Size(913, 387);
            this.dtListado.TabIndex = 13;
            this.dtListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentDoubleClick);
            this.dtListado.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtListado_CellMouseDoubleClick);
            this.dtListado.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtListado_RowHeaderMouseDoubleClick);
            this.dtListado.DoubleClick += new System.EventHandler(this.dtListado_DoubleClick);
            // 
            // lblIndicadorbusqueda
            // 
            this.lblIndicadorbusqueda.AutoSize = true;
            this.lblIndicadorbusqueda.Location = new System.Drawing.Point(32, 65);
            this.lblIndicadorbusqueda.Name = "lblIndicadorbusqueda";
            this.lblIndicadorbusqueda.Size = new System.Drawing.Size(82, 14);
            this.lblIndicadorbusqueda.TabIndex = 14;
            this.lblIndicadorbusqueda.Text = "Nombre | Ruc :";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(120, 62);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Busqueda por Nombre o RUC";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(315, 23);
            this.metroTextBox1.TabIndex = 15;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Busqueda por Nombre o RUC";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // FrmListadoClientesProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 545);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lblIndicadorbusqueda);
            this.Controls.Add(this.dtListado);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "FrmListadoClientesProveedores";
            this.Text = "FrmListadoClientesProveedores";
            this.Load += new System.EventHandler(this.FrmListadoClientesProveedores_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.Controls.SetChildIndex(this.dtListado, 0);
            this.Controls.SetChildIndex(this.lblIndicadorbusqueda, 0);
            this.Controls.SetChildIndex(this.metroTextBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuControls.USButton btnSiguiente;
        public System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.Label lblIndicadorbusqueda;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}