namespace US_EXCHANGER.Presentation
{
    partial class FrmMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.usButton3 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.usButton4 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.ref1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            this.usButton1.Location = new System.Drawing.Point(522, 444);
            this.usButton1.Text = "Consultar";
            this.usButton1.Click += new System.EventHandler(this.usButton1_Click);
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.Location = new System.Drawing.Point(793, 445);
            this.usButton2.Click += new System.EventHandler(this.usButton2_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.Text = "Unosoft";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.Text = "Empresa: Unosoft Boleteria";
            // 
            // dtListado
            // 
            this.dtListado.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ref1,
            this.ref2,
            this.ref3,
            this.ref4});
            this.dtListado.EnableHeadersVisualStyles = false;
            this.dtListado.Location = new System.Drawing.Point(24, 156);
            this.dtListado.MultiSelect = false;
            this.dtListado.Name = "dtListado";
            this.dtListado.RowHeadersVisible = false;
            this.dtListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListado.Size = new System.Drawing.Size(838, 262);
            this.dtListado.TabIndex = 63;
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
            this.usButton3.Location = new System.Drawing.Point(609, 445);
            this.usButton3.Name = "usButton3";
            this.usButton3.Size = new System.Drawing.Size(91, 22);
            this.usButton3.TabIndex = 64;
            this.usButton3.Text = "Generar Excel";
            this.usButton3.TextColor = System.Drawing.Color.White;
            this.usButton3.UseVisualStyleBackColor = false;
            // 
            // usButton4
            // 
            this.usButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton4.BorderRadius = 0;
            this.usButton4.BorderSize = 0;
            this.usButton4.FlatAppearance.BorderSize = 0;
            this.usButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usButton4.ForeColor = System.Drawing.Color.White;
            this.usButton4.Location = new System.Drawing.Point(706, 445);
            this.usButton4.Name = "usButton4";
            this.usButton4.Size = new System.Drawing.Size(80, 22);
            this.usButton4.TabIndex = 65;
            this.usButton4.Text = "Generar PDF";
            this.usButton4.TextColor = System.Drawing.Color.White;
            this.usButton4.UseVisualStyleBackColor = false;
            // 
            // ref1
            // 
            this.ref1.FillWeight = 250F;
            this.ref1.HeaderText = "Referencia 1";
            this.ref1.Name = "ref1";
            // 
            // ref2
            // 
            this.ref2.HeaderText = "Referencia 2";
            this.ref2.Name = "ref2";
            // 
            // ref3
            // 
            this.ref3.HeaderText = "Referencia 3";
            this.ref3.Name = "ref3";
            // 
            // ref4
            // 
            this.ref4.HeaderText = "Referencia 4";
            this.ref4.Name = "ref4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 74);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 14);
            this.label10.TabIndex = 67;
            this.label10.Text = "Fecha desde";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 67);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 21);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 69;
            this.label3.Text = "Fecha hasta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(324, 67);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(93, 21);
            this.dateTimePicker2.TabIndex = 68;
            this.dateTimePicker2.Value = new System.DateTime(2022, 4, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(100, 14);
            this.label4.TabIndex = 70;
            this.label4.Text = "Criterio busqueda";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Reporte Consolidado",
            "Reporte Detallado"});
            this.comboBox2.Location = new System.Drawing.Point(141, 113);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(276, 22);
            this.comboBox2.TabIndex = 71;
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 498);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.usButton4);
            this.Controls.Add(this.usButton3);
            this.Controls.Add(this.dtListado);
            this.Name = "FrmMonitor";
            this.Text = "FrmMonitor";
            this.Controls.SetChildIndex(this.dtListado, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.usButton3, 0);
            this.Controls.SetChildIndex(this.usButton4, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref4;
        private MenuControls.USButton usButton3;
        private MenuControls.USButton usButton4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}