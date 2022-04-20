namespace US_EXCHANGER.Presentation
{
    partial class FrmAsistencia
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
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnCompraVenta = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usButton1
            // 
            this.usButton1.FlatAppearance.BorderSize = 0;
            // 
            // usButton2
            // 
            this.usButton2.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.Text = "Unosoft";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.Text = "Empresa: Unosoft Boleteria";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.Location = new System.Drawing.Point(57, 172);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(171, 107);
            this.iconButton4.TabIndex = 8;
            this.iconButton4.Text = "Apertura | Cierre Caja";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnCompraVenta
            // 
            this.btnCompraVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.btnCompraVenta.FlatAppearance.BorderSize = 0;
            this.btnCompraVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraVenta.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompraVenta.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCompraVenta.IconColor = System.Drawing.Color.White;
            this.btnCompraVenta.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCompraVenta.Location = new System.Drawing.Point(299, 172);
            this.btnCompraVenta.Name = "btnCompraVenta";
            this.btnCompraVenta.Size = new System.Drawing.Size(171, 107);
            this.btnCompraVenta.TabIndex = 7;
            this.btnCompraVenta.Text = "Venta Boletos";
            this.btnCompraVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompraVenta.UseVisualStyleBackColor = false;
            this.btnCompraVenta.Click += new System.EventHandler(this.btnCompraVenta_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.Location = new System.Drawing.Point(534, 172);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(171, 107);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Reportes";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.btnCompraVenta);
            this.Name = "FrmAsistencia";
            this.Text = "FrmAsistencia";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.usButton1, 0);
            this.Controls.SetChildIndex(this.usButton2, 0);
            this.Controls.SetChildIndex(this.btnCompraVenta, 0);
            this.Controls.SetChildIndex(this.iconButton4, 0);
            this.Controls.SetChildIndex(this.iconButton1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnCompraVenta;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}