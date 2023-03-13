using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System.Runtime.InteropServices;

public partial class MsgBox : XtraForm
{
    #region Variable and api
    Image warning = global::EMGDesign.Properties.Resources.msgWarning;
    Image error = global::EMGDesign.Properties.Resources.msgError;
    Image info = global::EMGDesign.Properties.Resources.msgInfo;
    Image question = global::EMGDesign.Properties.Resources.msgQuestion;
    private MsgButton _button { get; set; }
    public MsgPosition MsgPosition { get; set; }
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;
    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    #endregion


    #region Ct MsgBox Override (3)
    public MsgBox()
    {

        InitializeComponent();
        Button(MsgButton.Ok);
        Image(MsgImg.Information);
        this.Text = "";
        _button = MsgButton.Ok;
        MsgPosition = MsgPosition.Center;



    }



    #endregion
    #region MesajBox Override (5)
    public void MesajBox(Form oOwnerForm, string Message)
    {
        this.Owner = oOwnerForm;
        this.Size = new Size(328, 127);
        Message = Message.Replace("\\n", "\n"); ;
        msglabel.Text = Message;
        Graphics g = this.CreateGraphics();
        int _height = Convert.ToInt32(g.MeasureString(Message, msglabel.Font).Height);
        int _width = Convert.ToInt32(g.MeasureString(Message, msglabel.Font).Width);
        Size size = new Size(328, 127);

        if (_height > msglabel.Height)
            this.Height = size.Height + ((_height + msglabel.Height) - size.Height) + panelControl1.Height + 20;
        else
            this.Height = size.Height + 20;

        if (_width > size.Width)
            this.Width = size.Width + (_width - size.Width) + panelControl2.Width;
        else
            this.Width = size.Width;

        Button(_button);

        switch (MsgPosition)
        {
            case MsgPosition.Left:
                msglabel.TextAlign = ContentAlignment.MiddleLeft;
                break;
            case MsgPosition.Right:
                msglabel.TextAlign = ContentAlignment.MiddleRight;
                break;
            case MsgPosition.Center:
                msglabel.TextAlign = ContentAlignment.MiddleCenter;
                break;
            default:
                break;
        }

        this.ShowDialog();
        Image(MsgImg.Information);
        this.Text = "";
        _button = MsgButton.Ok;
        MsgPosition = MsgPosition.Center;

    }
    /// <summary>
    /// Default Image=Information;
    /// Default Button=OK
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Caption"></param>
    public void MesajBox(Form oOwnerForm, string Message, string Caption)
    {
        this.Owner = oOwnerForm;
        this.Text = "     " + Caption;
        frm.Text = this.Text;
        MesajBox(oOwnerForm, Message);

    }
    /// <summary>
    /// Default Image=Information
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Caption"></param>
    /// <param name="b"></param>
    public void MesajBox(Form oOwnerForm, string Message, string Caption, MsgButton b)
    {
        _button = b;
        MesajBox(oOwnerForm, Message, Caption);

    }
    /// <summary>
    /// Default Button=OK
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Caption"></param>
    /// <param name="msgimg"></param>
    public void MesajBox(Form oOwnerForm, string Message, string Caption, MsgImg msgimg)
    {
        Image(msgimg);
        MesajBox(oOwnerForm, Message, Caption);

    }
    public void MesajBox(Form oOwnerForm, string Message, string Caption, MsgButton b, MsgImg msgimg)
    {
        Image(msgimg);
        MesajBox(oOwnerForm, Message, Caption, b);

    }
    #endregion
    #region Set Controls and others
    private void Image(MsgImg im)
    {
        if (im == MsgImg.Error)
            img.Image = error;
        else if (im == MsgImg.Warning)
            img.Image = warning;
        else if (im == MsgImg.Information)
            img.Image = info;
        else if (im == MsgImg.Question)
            img.Image = question;

    }
    private void Button(MsgButton b)
    {
        btnYes.Visible = false;
        btnNo.Visible = false;
        btnCancel.Visible = false;

        if (b == MsgButton.Ok)
        {
            string _ok = GetControlCaption("msgBtnOk");
            btnYes.Text = (_ok == "") ? "Tamam" : _ok;
            btnYes.DialogResult = DialogResult.OK;
            btnYes.Visible = true;
            btnYes.Left = (this.Width / 2) - (btnYes.Width / 2);
            this.DialogResult = DialogResult.Cancel;



        }
        else if (b == MsgButton.YesNo)
        {
            string _yes = GetControlCaption("msgbtnYes");
            string _no = GetControlCaption("msgBtnNo");
            btnYes.Text = (_yes == "") ? "Evet" : _yes;
            btnNo.Text = (_no == "") ? "Hayýr" : _no;
            btnYes.DialogResult = DialogResult.Yes;
            btnNo.DialogResult = DialogResult.No;
            btnYes.Visible = true;
            btnNo.Visible = true;
            btnYes.Left = (this.Width / 3) - (btnYes.Width / 2);
            btnNo.Left = (this.Width / 3) * 2 - (btnNo.Width / 2);




            this.DialogResult = DialogResult.No;
        }
        else if (b == MsgButton.YesNoCancel)
        {
            string _yes = GetControlCaption("msgbtnYes");
            string _no = GetControlCaption("msgBtnNo");
            string _cancel = GetControlCaption("msgBtnCancel");

            btnYes.Text = (_yes == "") ? "Evet" : _yes;
            btnNo.Text = (_no == "") ? "Hayýr" : _no;
            btnCancel.Text = (_cancel == "") ? "Ýptal" : _cancel;
            btnYes.DialogResult = DialogResult.Yes;
            btnNo.DialogResult = DialogResult.No;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnYes.Visible = true;
            btnNo.Visible = true;
            btnCancel.Visible = true;

            btnYes.Left = (this.Width / 4) - (btnYes.Width / 2);
            btnNo.Left = (this.Width / 4) * 2 - (btnNo.Width / 2);
            btnCancel.Left = (this.Width / 4) * 3 - (btnCancel.Width / 2);

            this.DialogResult = DialogResult.Cancel;


        }
    }
    private string GetControlCaption(string controlName)
    {
        string retValue = "";

        switch (controlName)
        {
            case "msgbtnYes":
                retValue = "Evet";
                break;
            case "msgBtnOk":
                retValue = "Tamam";
                break;
            case "msgBtnNo":
                retValue = "Hayýr";
                break;
            default:
                retValue = "";
                break;
        }


        return retValue;

    }

    private void frm_MouseDown(object sender, MouseEventArgs e)
    {


        if (e.Button == MouseButtons.Left && e.Y < 32)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

        }

    }

    private void MsgBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (this._button == MsgButton.Ok)
        {
            if (e.KeyCode == Keys.T)
            {
                this.DialogResult = btnYes.DialogResult = DialogResult.OK;
                Hide();
            }
        }
        else if (this._button == MsgButton.YesNo)
        {
            if (e.KeyCode == Keys.E)
            {
                this.DialogResult = btnYes.DialogResult = DialogResult.Yes;
                Hide();
            }
            else if (e.KeyCode == Keys.H)
            {
                this.DialogResult = btnNo.DialogResult = DialogResult.No;
                Hide();
            }
        }
        else if (this._button == MsgButton.YesNoCancel)
        {
            if (e.KeyCode == Keys.E)
            {
                this.DialogResult = btnYes.DialogResult = DialogResult.Yes;
                Hide();
            }
            else if (e.KeyCode == Keys.H)
            {
                this.DialogResult = btnNo.DialogResult = DialogResult.No;
                Hide();
            }
            else if (e.KeyCode == Keys.I)
            {
                this.DialogResult = btnCancel.DialogResult = DialogResult.Cancel;
                Hide();
            }
        }
    }
    #endregion
}

#region Enum


public enum MsgImg
{
    Error, Information, Warning, Question
}
public enum MsgButton
{
    Ok, YesNo, YesNoCancel
}
public enum MsgPosition
{

    Left,
    Right,
    Center
}
#endregion

public static class EMGMessage
{
    private static MsgBox messageBox = new MsgBox();
    public static DialogResult Result
    {
        get
        {
            return messageBox.DialogResult;
        }
    }

    public static void MesajBox(Form oOwnerForm, string Message)
    {
        messageBox.MesajBox(oOwnerForm, Message);
    }
    public static void MesajBox(Form oOwnerForm, string Message, string Caption)
    {
        messageBox.MesajBox(oOwnerForm, Message, Caption);
    }
    public static void MesajBox(Form oOwnerForm, string Message, string Caption, MsgButton b)
    {
        messageBox.MesajBox(oOwnerForm, Message, Caption, b);
    }
    public static void MesajBox(Form oOwnerForm, string Message, string Caption, MsgImg msgimg)
    {

        messageBox.MesajBox(oOwnerForm, Message, Caption, msgimg);
    }
    public static void MesajBox(Form oOwnerForm, string Message, string Caption, MsgButton b, MsgImg msgimg)
    {
        messageBox.MesajBox(oOwnerForm, Message, Caption, b, msgimg);

    }

    public static void MesajBox(string Message)
    {
        messageBox.MesajBox(null, Message);
    }
    public static void MesajBox(string Message, string Caption)
    {
        messageBox.MesajBox(null, Message, Caption);
    }
    public static void MesajBox(string Message, string Caption, MsgButton b)
    {
        messageBox.MesajBox(null, Message, Caption, b);
    }
    public static void MesajBox(string Message, string Caption, MsgImg msgimg)
    {

        messageBox.MesajBox(null, Message, Caption, msgimg);
    }
    public static void MesajBox(string Message, string Caption, MsgButton b, MsgImg msgimg)
    {
        messageBox.MesajBox(null, Message, Caption, b, msgimg);

    }
}
