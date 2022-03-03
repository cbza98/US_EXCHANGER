using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_EXCHANGER.Presentation.UsersControls.USTextBox
{
    public partial class USCurrencyTextBox : MaskedTextBox
    {
        public USCurrencyTextBox()
        {
            InitializeComponent();
        }

        private short decimales = 2; //por default permitira 2 decimales
        private string separadordecimales = "."; //por default permitira . decimales
        private string separadorgrupo = ","; //por default permitira . decimales
        private string signoMoneda = "S/.";
        //Implementar la propiedad que permita al usuario establecer el numero de decimales a mostrar
        [Description("Define el número de decimales para el cuadro de texto.")]
        public short NumeroDecimales
        {
            get { return this.decimales; }
            set { this.decimales = value; }
        }


        public string Separadordecimales
        {
            get { return this.separadordecimales; }
            set { this.separadordecimales = value; }
        }

        public string SignoMoneda
        {
            get { return this.signoMoneda; }
            set { this.signoMoneda = value; }
        }

        public string Separadorgrupo
        {
            get { return this.separadorgrupo; }
            set { this.separadorgrupo = value; }
        }

        private bool punto = false; //auxiliar para limitar el numero de decimales
        //Sobrescribir el metodo OnKeyPress
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //contar el numero de puntos y actualizar nuestra variable a true si ya se tiene un punto
            if (this.Text.Contains(".") == true)
                punto = true;
            else
                punto = false;

            //solo numeros y 2 decimales       // e.KeyChar == (char)Keys.Home  
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                //liminar el numero de decimales
                if (e.KeyChar == '.')
                {
                    if (punto == false)
                    {
                        e.Handled = false;
                        punto = true;
                    }
                    else
                        e.Handled = true;

                    return;
                }

                if (Regex.IsMatch(this.Text, "^\\d*\\.\\d{" + decimales + "}$")) e.Handled = true;
            }
            else
            {
                //si es tecla de control especial, permitirla y regresar
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    //return;
                }
                else
                    e.Handled = true;
            }
            //e.Handled = e.KeyChar != (char)Keys.Back;
        }





    }
}
