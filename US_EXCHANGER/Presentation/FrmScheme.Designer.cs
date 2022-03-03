namespace US_EXCHANGER.Presentation
{
    public partial class FrmScheme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usButton2 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.usButton1 = new US_EXCHANGER.Presentation.MenuControls.USButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-26, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1414, 41);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empresa: Unosoft Echanger Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UnoExchanger";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::US_EXCHANGER.Properties.Resources.onuwhite;
            this.pictureBox1.Location = new System.Drawing.Point(50, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 41);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 560);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // usButton2
            // 
            this.usButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.usButton2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.usButton2.BorderRadius = 0;
            this.usButton2.BorderSize = 0;
            this.usButton2.FlatAppearance.BorderSize = 0;
            this.usButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usButton2.ForeColor = System.Drawing.Color.White;
            this.usButton2.Location = new System.Drawing.Point(1293, 753);
            this.usButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usButton2.Name = "usButton2";
            this.usButton2.Size = new System.Drawing.Size(80, 23);
            this.usButton2.TabIndex = 6;
            this.usButton2.Text = "Cancelar";
            this.usButton2.TextColor = System.Drawing.Color.White;
            this.usButton2.UseVisualStyleBackColor = false;
            this.usButton2.Click += new System.EventHandler(this.usButton2_Click);
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
            this.usButton1.ForeColor = System.Drawing.Color.White;
            this.usButton1.Location = new System.Drawing.Point(1196, 753);
            this.usButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usButton1.Name = "usButton1";
            this.usButton1.Size = new System.Drawing.Size(80, 23);
            this.usButton1.TabIndex = 5;
            this.usButton1.Text = "Guardar";
            this.usButton1.TextColor = System.Drawing.Color.White;
            this.usButton1.UseVisualStyleBackColor = false;
            // 
            // FrmScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.usButton2);
            this.Controls.Add(this.usButton1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmScheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmScheme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public MenuControls.USButton usButton1;
        public MenuControls.USButton usButton2;
    }
}