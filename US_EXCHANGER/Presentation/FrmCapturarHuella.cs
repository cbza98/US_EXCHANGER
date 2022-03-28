
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libzkfpcsharp;

namespace US_EXCHANGER.Presentation
{
    public partial class FrmCapturarHuella : Demo.Form1
    {

        #region Atributos
        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        bool bIdentify = true;
        byte[] FPBuffer;
        int RegisterCount = 0;
        const int REGISTER_FINGER_COUNT = 3;

        byte[][] RegTmps = new byte[3][];
        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        int cbRegTmp = 0;
        int iFid = 1;

        private int mfpWidth = 0;
        private int mfpHeight = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;
        #endregion
        public FrmCapturarHuella()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        private void usButton1_Click(object sender, EventArgs e)
        {

        }

        private void usButton2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCapturarHuella_Load(object sender, EventArgs e)
        {

        }

        private void cmbIdx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
