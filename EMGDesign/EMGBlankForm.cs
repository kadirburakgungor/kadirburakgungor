using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EMGDesign
{
    public partial class EMGBlankForm : DevExpress.XtraEditors.XtraForm
    {
        public EMGBlankForm()
        {
            InitializeComponent();

            Modifield = false;
        }

        public object Param1 { get; set; }
        public object Param2 { get; set; }
        public object Param3 { get; set; }
        public object Param4 { get; set; }
        public object Param5 { get; set; }

        public bool Modifield { get; set; }

        private void XtraUIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Modifield)
            {
                EMGMessage.MesajBox("Değişiklikler Kayıt Edilmedi.. \nFormdan Çıkmak İstiyor musnuz ?", this.Text, MsgButton.YesNo, MsgImg.Question);
                if (EMGMessage.Result == DialogResult.No)
                {
                    e.Cancel = true;

                }
            }
        }
    }
}