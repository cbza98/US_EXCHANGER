using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_EXCHANGER.Presentation.UsersControls.USTextBox
{
    public partial class USTextBox : TextBox
    {
        public USTextBox()
        {
            InitializeComponent();
        }


        //Sobreescribir el metodo OnKeyPress de la clase USTextBox
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //solo permitir numeros y teclas de control
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false; //permitir el caracter
            }
            else
            {
                e.Handled = true; //rechazar el caracter
            }
        }


    }
}
