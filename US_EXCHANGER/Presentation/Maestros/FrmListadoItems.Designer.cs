namespace US_EXCHANGER.Presentation.Maestros
{
    partial class FrmListadoItems
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(352, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(75, 125);
            this.txtDesc.PromptText = "Busqueda por Nombre";
            this.txtDesc.Size = new System.Drawing.Size(374, 23);
            this.txtDesc.WaterMark = "Busqueda por Nombre";
            // 
            // lblIndicadorbusqueda
            // 
            this.lblIndicadorbusqueda.Location = new System.Drawing.Point(19, 125);
            this.lblIndicadorbusqueda.Size = new System.Drawing.Size(50, 13);
            this.lblIndicadorbusqueda.Text = "Nombre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tipo de Item";
            // 
            // cmbTipoItem
            // 
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Location = new System.Drawing.Point(22, 79);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(193, 21);
            this.cmbTipoItem.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Categoria de Item";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(256, 79);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(193, 21);
            this.cmbCategoria.TabIndex = 44;
            // 
            // FrmListadoItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 571);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoItem);
            this.Name = "FrmListadoItems";
            this.Text = "FrmListadoItems";
            this.Load += new System.EventHandler(this.FrmListadoItems_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblIndicadorbusqueda, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.cmbTipoItem, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cmbCategoria, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}