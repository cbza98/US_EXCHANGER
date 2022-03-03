
namespace US_EXCHANGER.Presentation
{
    partial class FrmBase
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.frmHome1 = new US_EXCHANGER.Presentation.UsersControls.Configuracion.FrmHome();
            this.usexDropdownMenu1 = new US_EXCHANGER.Presentation.MenuControls.USEXDropdownMenu(this.components);
            this.tablasBásicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usexDropdownMenu2 = new US_EXCHANGER.Presentation.MenuControls.USEXDropdownMenu(this.components);
            this.ventasComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaCréditoDébitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNotaCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaNotaDébitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónElectrónicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaciónBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anulaciónDocElectrónicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.usexDropdownMenu1.SuspendLayout();
            this.usexDropdownMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(839, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 520);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-39, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 38);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empresa: Unosoft Echanger Demo";
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UnoExchanger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::US_EXCHANGER.Properties.Resources.onuwhite;
            this.pictureBox1.Location = new System.Drawing.Point(51, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.iconButton1);
            this.flowLayoutPanel2.Controls.Add(this.iconButton2);
            this.flowLayoutPanel2.Controls.Add(this.iconButton3);
            this.flowLayoutPanel2.Controls.Add(this.iconButton4);
            this.flowLayoutPanel2.Controls.Add(this.iconButton6);
            this.flowLayoutPanel2.Controls.Add(this.iconButton5);
            this.flowLayoutPanel2.Controls.Add(this.iconButton7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(181, 443);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 57);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Inicio";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 66);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(165, 57);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Mantenimiento";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 129);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(165, 57);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Ventas";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 192);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(165, 57);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Movimientos";
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(3, 255);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(165, 57);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.Text = "Compras";
            this.iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(3, 318);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(165, 57);
            this.iconButton5.TabIndex = 6;
            this.iconButton5.Text = "Reportes";
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(74)))), ((int)(((byte)(114)))));
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.White;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButton7.IconColor = System.Drawing.Color.White;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(3, 381);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(165, 57);
            this.iconButton7.TabIndex = 7;
            this.iconButton7.Text = "Configuración";
            this.iconButton7.UseVisualStyleBackColor = false;
            // 
            // frmHome1
            // 
            this.frmHome1.Location = new System.Drawing.Point(318, 104);
            this.frmHome1.Name = "frmHome1";
            this.frmHome1.Size = new System.Drawing.Size(571, 319);
            this.frmHome1.TabIndex = 5;
            // 
            // usexDropdownMenu1
            // 
            this.usexDropdownMenu1.IsMainMenu = false;
            this.usexDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasBásicasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.empresaToolStripMenuItem,
            this.clientesProveedoresToolStripMenuItem});
            this.usexDropdownMenu1.MenuItemHeight = 25;
            this.usexDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.usexDropdownMenu1.Name = "usexDropdownMenu1";
            this.usexDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.usexDropdownMenu1.Size = new System.Drawing.Size(191, 92);
            // 
            // tablasBásicasToolStripMenuItem
            // 
            this.tablasBásicasToolStripMenuItem.Name = "tablasBásicasToolStripMenuItem";
            this.tablasBásicasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tablasBásicasToolStripMenuItem.Text = "Tablas Básicas";
            this.tablasBásicasToolStripMenuItem.Click += new System.EventHandler(this.tablasBásicasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // clientesProveedoresToolStripMenuItem
            // 
            this.clientesProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.clientesProveedoresToolStripMenuItem.Name = "clientesProveedoresToolStripMenuItem";
            this.clientesProveedoresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clientesProveedoresToolStripMenuItem.Text = "Clientes | Proveedores";
            this.clientesProveedoresToolStripMenuItem.Click += new System.EventHandler(this.clientesProveedoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // usexDropdownMenu2
            // 
            this.usexDropdownMenu2.IsMainMenu = false;
            this.usexDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasComprasToolStripMenuItem,
            this.notaCréditoDébitoToolStripMenuItem,
            this.facturaciónElectrónicaToolStripMenuItem});
            this.usexDropdownMenu2.MenuItemHeight = 25;
            this.usexDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.usexDropdownMenu2.Name = "usexDropdownMenu2";
            this.usexDropdownMenu2.PrimaryColor = System.Drawing.Color.Empty;
            this.usexDropdownMenu2.Size = new System.Drawing.Size(198, 70);
            // 
            // ventasComprasToolStripMenuItem
            // 
            this.ventasComprasToolStripMenuItem.Name = "ventasComprasToolStripMenuItem";
            this.ventasComprasToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ventasComprasToolStripMenuItem.Text = "Ventas - Compras";
            // 
            // notaCréditoDébitoToolStripMenuItem
            // 
            this.notaCréditoDébitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaNotaCréditoToolStripMenuItem,
            this.nuevaNotaDébitoToolStripMenuItem});
            this.notaCréditoDébitoToolStripMenuItem.Name = "notaCréditoDébitoToolStripMenuItem";
            this.notaCréditoDébitoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.notaCréditoDébitoToolStripMenuItem.Text = "Nota Crédito / Débito";
            // 
            // nuevaNotaCréditoToolStripMenuItem
            // 
            this.nuevaNotaCréditoToolStripMenuItem.Name = "nuevaNotaCréditoToolStripMenuItem";
            this.nuevaNotaCréditoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nuevaNotaCréditoToolStripMenuItem.Text = "Nueva Nota Crédito";
            // 
            // nuevaNotaDébitoToolStripMenuItem
            // 
            this.nuevaNotaDébitoToolStripMenuItem.Name = "nuevaNotaDébitoToolStripMenuItem";
            this.nuevaNotaDébitoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nuevaNotaDébitoToolStripMenuItem.Text = "Nueva Nota Débito";
            // 
            // facturaciónElectrónicaToolStripMenuItem
            // 
            this.facturaciónElectrónicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarDocumentosToolStripMenuItem,
            this.comunicaciónBajaToolStripMenuItem,
            this.anulaciónDocElectrónicosToolStripMenuItem});
            this.facturaciónElectrónicaToolStripMenuItem.Name = "facturaciónElectrónicaToolStripMenuItem";
            this.facturaciónElectrónicaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.facturaciónElectrónicaToolStripMenuItem.Text = "Facturación Electrónica";
            // 
            // enviarDocumentosToolStripMenuItem
            // 
            this.enviarDocumentosToolStripMenuItem.Name = "enviarDocumentosToolStripMenuItem";
            this.enviarDocumentosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.enviarDocumentosToolStripMenuItem.Text = "Enviar Documentos";
            // 
            // comunicaciónBajaToolStripMenuItem
            // 
            this.comunicaciónBajaToolStripMenuItem.Name = "comunicaciónBajaToolStripMenuItem";
            this.comunicaciónBajaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.comunicaciónBajaToolStripMenuItem.Text = "Comunicación Baja";
            // 
            // anulaciónDocElectrónicosToolStripMenuItem
            // 
            this.anulaciónDocElectrónicosToolStripMenuItem.Name = "anulaciónDocElectrónicosToolStripMenuItem";
            this.anulaciónDocElectrónicosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.anulaciónDocElectrónicosToolStripMenuItem.Text = "Anulación Doc Electrónicos";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 515);
            this.Controls.Add(this.frmHome1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.usexDropdownMenu1.ResumeLayout(false);
            this.usexDropdownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton7;
        private UsersControls.Configuracion.FrmHome frmHome1;
        private MenuControls.USEXDropdownMenu usexDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem tablasBásicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private MenuControls.USEXDropdownMenu usexDropdownMenu2;
        private System.Windows.Forms.ToolStripMenuItem ventasComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaCréditoDébitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotaCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaNotaDébitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónElectrónicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaciónBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anulaciónDocElectrónicosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clientesProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
    }
}