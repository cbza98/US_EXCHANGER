using Dapper;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Models.Login;
using US_EXCHANGER.Models.Persona.Entidad;
using US_EXCHANGER.Presentation.UsersControls.MessageBox;
using US_EXCHANGER.Validators.Login;

namespace US_EXCHANGER.Presentation
{
    public partial class FrmLogin : Form
    {


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                OPE_USUARIOBean loginBean = new OPE_USUARIOBean()
                {
                    CODIGO = txtUsuario.Text,
                    CONTRASENA = txtUsuario.Text
                };
                LoginValidator validator = new LoginValidator();
                ValidationResult validationResult = validator.Validate(loginBean);
                IList<ValidationFailure> failures = validationResult.Errors;
                if (!validationResult.IsValid)
                {

                    foreach (var item in failures)
                    {
                        var result = USMessageBox.Show(item.ErrorMessage,
    "Error-Stop Icon",
    MessageBoxButtons.RetryCancel,

    MessageBoxIcon.Error);
                        return;
                    }
                }
                FrmBase _frmbase = new FrmBase();
                _frmbase.Show();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void usButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OPE_USUARIOBean loginBean = new OPE_USUARIOBean()
                {
                    CODIGO = txtUsuario.Text,
                 CONTRASENA = HRA.UTIL.dbUtility.EncryptText(txtpass.Text)
                };
                LoginValidator validator = new LoginValidator();
                ValidationResult validationResult = validator.Validate(loginBean);
                IList<ValidationFailure> failures = validationResult.Errors;
                if (!validationResult.IsValid)
                {

                    foreach (var item in failures)
                    {
                        var result = USMessageBox.Show(item.ErrorMessage,
"Error-Stop Icon",
MessageBoxButtons.RetryCancel,

MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {


                    string cnn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        string Query = $"SELECT CODIGO, CONTRASENA FROM OPE_USUARIO WHERE CODIGO='{loginBean.CODIGO}' AND CONTRASENA='{loginBean.CONTRASENA}'";
                        using (SqlCommand cmd = new SqlCommand(Query, conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {

                                USMessageBox.Show("Ingreso Exitoso......",
                                                "Notificación    ",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);


                                FrmBase _frmbase = new FrmBase();
                                _frmbase.Show();
                                cmd.Dispose();
                                this.Hide();
                            }
                            else
                            {

                                USMessageBox.Show("Datos incorrectos.......",
                                                "Notificación    ",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                    }




                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void usButton3_Click(object sender, EventArgs e)
        {

         //   var cifrado = EUTIL.HRA.UTIL.dbUtility.DecryptText(txtpass.Text);
         //   txtUsuario.Text = cifrado.ToString();
            //    using (IDbConnection db = new SqlConnection(ConfigurationManager.AppSettings["Conn"]))
            //    {
            //        if (db.State == ConnectionState.Closed) db.Open();
            //        {

            //            DynamicParameters cmd = new DynamicParameters();
            //            cmd.Add("@CODIGO", cod_tabla);
            //            var procedure = "GetDataMaestro";

            //          //  listado = db.Query<T_Maestro>(procedure, cmd, commandType: System.Data.CommandType.StoredProcedure);

            //        }
            //    }
            //}
        }

        private void usButton3_Click_1(object sender, EventArgs e)
        {
           // string cifrado = EUTIL.HRA.UTIL.dbUtility.EncryptText(txtpass.Text);
          //  txtUsuario.Text = cifrado.ToString();
        }
    }
}

