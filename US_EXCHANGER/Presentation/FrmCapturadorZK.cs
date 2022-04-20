
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Asistencia;

namespace US_EXCHANGER.Presentation
{
    public partial class FrmCapturadorZK : Form
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
        public FrmCapturadorZK()
        {
            InitializeComponent();
        }



        //private void DoCapture()
        //{
        //    while (!bIsTimeToDie)
        //    {
        //        cbCapTmp = 2048;
        //        int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
        //        if (ret == zkfp.ZKFP_ERR_OK)
        //        {
        //            SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
        //        }
        //        Thread.Sleep(200);
        //    }
        //}

        //protected override void DefWndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case MESSAGE_CAPTURED_OK:
        //            {
        //                MemoryStream ms = new MemoryStream();
        //                BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
        //                Bitmap bmp = new Bitmap(ms);
        //                this.picFPImg.Image = bmp;
        //                if (IsRegister)
        //                {
        //                    int ret = zkfp.ZKFP_ERR_OK;
        //                    int fid = 0, score = 0;
        //                    ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
        //                    if (zkfp.ZKFP_ERR_OK == ret)
        //                    {
        //                        textRes.Text = "This finger was already register by " + fid + "!";
        //                        return;
        //                    }
        //                    if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
        //                    {
        //                        Text = "Please press the same finger 3 times for the enrollment";
        //                        return;
        //                    }
        //                    Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);
        //                    String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
        //                    byte[] blob = zkfp2.Base64ToBlob(strBase64);
        //                    RegisterCount++;
        //                    if (RegisterCount >= REGISTER_FINGER_COUNT)
        //                    {
        //                        RegisterCount = 0;
        //                        if (zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBMerge(mDBHandle, RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref cbRegTmp)) &&
        //                               zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBAdd(mDBHandle, iFid, RegTmp)))
        //                        {
        //                            iFid++;
        //                            Text= "enroll succ";
        //                            Text = strBase64;
        //                        }
        //                        else
        //                        {
        //                            Text = "enroll fail, error code=" + ret;
        //                        }
        //                        IsRegister = false;
        //                        return;
        //                    }
        //                    else
        //                    {
        //                        Text = "You need to press the " + (REGISTER_FINGER_COUNT - RegisterCount) + " times fingerprint";
        //                    }
        //                }
        //                else
        //                {
        //                    if (cbRegTmp <= 0)
        //                    {
        //                        Text = "Please register your finger first!";
        //                        return;
        //                    }
        //                    if (bIdentify)
        //                    {
        //                        int ret = zkfp.ZKFP_ERR_OK;
        //                        int fid = 0, score = 0;
        //                        ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
        //                        if (zkfp.ZKFP_ERR_OK == ret)
        //                        {
        //                            Text= "Identify succ, fid= " + fid + ",score=" + score + "!";
        //                            String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
        //                            Text= strBase64;
        //                            return;
        //                        }
        //                        else
        //                        {
        //                            textRes.Text = "Identify fail, ret= " + ret;
        //                            return;
        //                        }
        //                    }
        //                    /* else
        //                     {
        //                         int ret = zkfp2.DBMatch(mDBHandle, CapTmp, RegTmp);
        //                         if (0 < ret)
        //                         {
        //                             textRes.Text = "Match finger succ, score=" + ret + "!";
        //                             return;
        //                         }
        //                         else
        //                         {
        //                             textRes.Text = "Match finger fail, ret= " + ret;
        //                             return;
        //                         }
        //                     }*/
        //                }
        //            }
        //            break;

        //        default:
        //            base.DefWndProc(ref m);
        //            break;
        //    }
        //}
    }
}
