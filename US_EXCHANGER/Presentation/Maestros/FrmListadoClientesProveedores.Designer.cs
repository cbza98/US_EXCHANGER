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
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            this.usButton1.Location = new System.Drawing.Point(565, 508);
            this.usButton1.Text = "Anterior";
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.Location = new System.Drawing.Point(829, 508);
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
            this.btnSiguiente.Location = new System.Drawing.Point(691, 508);
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
            this.dtListado.Location = new System.Drawing.Point(12, 81);
            this.dtListado.MultiSelect = false;
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowHeadersVisible = false;
            this.dtListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListado.Size = new System.Drawing.Size(913, 409);
            this.dtListado.TabIndex = 13;
            this.dtListado.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtListado_CellMouseDoubleClick);
            this.dtListado.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtListado_RowHeaderMouseDoubleClick);
            this.dtListado.DoubleClick += new System.EventHandler(this.dtListado_DoubleClick);
            // 
            // FrmListadoClientesProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 545);
            this.Controls.Add(this.dtListado);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "FrmListadoClientesProveedores";
            this.Text = "FrmListadoClientesProveedores";
            this.Load += new System.EventHandler(this.FrmListadoClientesProveedores_Load);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.Controls.SetChildIndex(this.dtListado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControls.USButton btnSiguiente;
        public System.Windows.Forms.DataGridView dtListado;
    }
}