using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;

namespace US_EXCHANGER.Presentation
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            usexDropdownMenu1.IsMainMenu = true;
            usexDropdownMenu1.BackColor = ColorTranslator.FromHtml("#0b4a72");
            usexDropdownMenu1.ForeColor = Color.White;
            usexDropdownMenu2.IsMainMenu = true;
            usexDropdownMenu2.BackColor = ColorTranslator.FromHtml("#0b4a72");
            usexDropdownMenu2.ForeColor = Color.White;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            usexDropdownMenu1.Show(iconButton2, iconButton2.Width, 0);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            usexDropdownMenu2.Show(iconButton3, iconButton3.Width, 0);
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            FrmLogin _frmlogin = new FrmLogin();
            _frmlogin.Show();
            this.Close();
        }

        private void clientesProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Maestros.FrmClienteProveedor().Show();
        }

        private void tablasBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Configuracion.FrmTablasBasicas().Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Configuracion.FrmMaestroEmpresa().Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Maestros.FrmListadoClientesProveedores("0002").Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Maestros.FrmListadoClientesProveedores("0001").Show();
        }

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall: break;
                case CloseReason.FormOwnerClosing: break;
                case CloseReason.MdiFormClosing: break;
                case CloseReason.None: break;
                case CloseReason.TaskManagerClosing: break;
                case CloseReason.UserClosing:
                    {
                        var Result = USMessageBox.Show("Desea salir del sistema?......",
                                            "Advertencia Unosoft    ",
                                            MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Exclamation);

                        if (Result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            e.Cancel = true;
                        }

                    }
                    break;
                case CloseReason.WindowsShutDown: break;
                default: break;
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maestros.FrmListadoItems _ListItem = new Maestros.FrmListadoItems();
            _ListItem.Show();
        }
    }
}
