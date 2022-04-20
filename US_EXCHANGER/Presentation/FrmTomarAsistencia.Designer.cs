namespace US_EXCHANGER.Presentation
{
    partial class FrmTomarAsistencia
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
            this.usButton3 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.Location = new System.Drawing.Point(868, 626);
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            this.usButton1.Location = new System.Drawing.Point(357, 626);
            this.usButton1.Size = new System.Drawing.Size(138, 25);
            this.usButton1.Text = "Reconectar Dispositivo";
            this.usButton1.Visible = false;
            this.usButton1.Click += new System.EventHandler(this.usButton1_Click_1);
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(107, 65);
            this.txtDesc.PromptText = "Valide su asistencia";
            this.txtDesc.Visible = false;
            this.txtDesc.WaterMark = "Valide su asistencia";
            // 
            // lblIndicadorbusqueda
            // 
            this.lblIndicadorbusqueda.Location = new System.Drawing.Point(37, 75);
            this.lblIndicadorbusqueda.Size = new System.Drawing.Size(37, 13);
            this.lblIndicadorbusqueda.Text = "Huella";
            this.lblIndicadorbusqueda.Visible = false;
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(244, 16);
            this.label2.Text = "Empresa: Unosoft Biometric Demo";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.Text = "UnoBio";
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
            this.usButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.usButton3.ForeColor = System.Drawing.Color.White;
            this.usButton3.Location = new System.Drawing.Point(641, 627);
            this.usButton3.Name = "usButton3";
            this.usButton3.Size = new System.Drawing.Size(166, 25);
            this.usButton3.TabIndex = 21;
            this.usButton3.Text = "Reconectar Dispositivo";
            this.usButton3.TextColor = System.Drawing.Color.White;
            this.usButton3.UseVisualStyleBackColor = false;
            this.usButton3.Visible = false;
            this.usButton3.Click += new System.EventHandler(this.usButton3_Click);
            // 
            // FrmTomarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 664);
            this.Controls.Add(this.usButton3);
            this.Name = "FrmTomarAsistencia";
            this.Text = "FrmTomarAsistencia";
            this.Load += new System.EventHandler(this.FrmTomarAsistencia_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblIndicadorbusqueda, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.usButton3, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuControls.USButton usButton3;
    }
}