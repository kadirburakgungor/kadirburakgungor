using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.DXErrorProvider;

using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Navigation;

using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;

public partial class EMGForm : DevExpress.XtraEditors.XtraForm
{
    public EMGForm()
    {
        InitializeComponent();

        DevExpress.Skins.SkinManager.EnableFormSkins();
        DevExpress.Skins.SkinManager.EnableMdiFormSkins();



    }

    // Layout Name  = LC
    // btnYeni      = Yeni
    // btnSil       = Sil
    // btnKaydet    = Kaydet
    // btnYazdir    = Yazdir
    // btnCikis     = Cikis
    // Form_Load    = Yukle
    // btnDuzenle   = Duzenle
    // btnYenile    = Yenile



    public int UniqueID { get; set; }
    public string UniqueName { get; set; }
    public bool Modifield = false;
    private EMGFormButtonSetType _buttonSet;
    public EMGFormButtonSetType ButtonSet
    {
        get
        {
            return _buttonSet;
        }
        set
        {
            _buttonSet = value;
            switch (value)
            {
                case EMGFormButtonSetType.EntryFormButtonSet:
                    btnYeni.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnKaydet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnSil.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnCikis.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    btnDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnYenile.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnDiger1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnExcelExport.Visibility = BarItemVisibility.Never;
                    btnExportAktar.Visibility = BarItemVisibility.Never;


                    break;
                case EMGFormButtonSetType.ListButtonSet:
                    btnYeni.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnSil.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnCikis.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnYenile.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                    btnKaydet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnExcelExport.Visibility = BarItemVisibility.Never;
                    btnExportAktar.Visibility = BarItemVisibility.Always;
                    break;
                case EMGFormButtonSetType.CloseOnly:
                    btnYeni.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnKaydet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnSil.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnCikis.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnDuzenle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnYenile.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnDiger1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnDiger4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                    btnExcelExport.Visibility = BarItemVisibility.Never;
                    btnExportAktar.Visibility = BarItemVisibility.Never;
                    btnCikis.Visibility = BarItemVisibility.Always;

                    break;
                default:
                    break;
            }
        }
    }
    public bool FormButonlarEnable
    {

        set
        {
            btnYeni.Enabled = value;
            btnKaydet.Enabled = value;
            btnSil.Enabled = value;
            btnDuzenle.Enabled = value;
            btnYenile.Enabled = value;
            btnDiger1.Enabled = value;
            btnDiger2.Enabled = value;

            if (this.Controls["LC"] != null)
            {
                foreach (Control item in this.Controls["LC"].Controls)
                {
                    item.Enabled = value;
                }

            }

        }
    }
    public bool ListeButonlarEnble
    {
        set
        {

            btnSil.Enabled = value;
            btnYeni.Enabled = value;
            btnYenile.Enabled = value;
            btnDiger1.Enabled = value;
            btnDiger2.Enabled = value;



        }

    }



    public object Param1 { get; set; }
    public object Param2 { get; set; }
    public object Param3 { get; set; }
    public object Param4 { get; set; }
    public object Param5 { get; set; }
    public object EMP1 { get; set; }

    private List<EMGValidate> validateControls = new List<EMGValidate>();


    /// <summary>
    /// Form Closing Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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

    /// <summary>
    /// Load Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void XtraUIForm_Load(object sender, EventArgs e)
    {

        btnFiltreKaydet.Visibility = BarItemVisibility.Never;

        if (this.Controls["LC"] != null)
        {
            foreach (Control item in this.Controls["LC"].Controls)
            {
                item.TextChanged += new EventHandler(item_TextChanged);
            }

            if (this.Controls["LC"] is LayoutControl)
            {
                LayoutControl lc = (LayoutControl)this.Controls["LC"];
                lc.OptionsView.HighlightFocusedItem = true;
            }
          
        }

        try
        {
            this.GetType().GetMethod("Yukle").Invoke(this, null);
        }
        catch { }




    }

    /// <summary>
    /// Text Changed Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void item_TextChanged(object sender, EventArgs e)
    {
        Modifield = true;
    }

    #region Buttons Event

    private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Cikis").Invoke(this, null);
        }
        catch { }
        Close();
    }

    private void btnYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Yeni").Invoke(this, null);
        }
        catch { }
    }

    private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Kaydet").Invoke(this, null);
        }
        catch { }
    }

    private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Sil").Invoke(this, null);
        }
        catch { }
    }

    private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Yazdir").Invoke(this, null);
        }
        catch { }
    }

    private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Duzenle").Invoke(this, null);
        }
        catch { }
    }

    private void btnYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("Yenile").Invoke(this, null);
        }
        catch { }
    }

    private void btnExcelExport_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("ExcelExport").Invoke(this, null);
        }
        catch { }
    }
    #endregion

    // Escape Key Button Close
    private void XtraUIForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            this.Close();
        }
    }

    #region Button Settings


    public void EMGBarButtonSetting(BarLargeButtonItem button, string Caption)
    {
        button.Caption = Caption;
        ((DevExpress.Utils.ToolTipTitleItem)button.SuperTip.Items[0]).Text = Caption;
    }
    public void EMGBarButtonSetting(BarLargeButtonItem button, bool Visible)
    {
        button.Visibility = Visible ? BarItemVisibility.Always : BarItemVisibility.Never;
    }

    public void EMGBarButtonSetting(BarLargeButtonItem button, string Caption, bool Visible)
    {
        EMGBarButtonSetting(button, Caption);
        EMGBarButtonSetting(button, Visible);
    }
    public void EMGBarButtonSetting(BarLargeButtonItem button, string Caption, bool Visible, Image image)
    {
        EMGBarButtonSetting(button, Caption);
        EMGBarButtonSetting(button, Visible);
        button.LargeGlyph = image;
    }
    public void EMGBarButtonSettingSmallImage(BarLargeButtonItem button, string Caption, bool Visible, Image image)
    {
        EMGBarButtonSetting(button, Caption);
        EMGBarButtonSetting(button, Visible);
        button.Glyph = image;
    }

    public void EMGSmallIcon()
    {
        for (int i = 0; i < bar1.ItemLinks.Count; i++)
        {
            bar1.ItemLinks[i].Item.LargeGlyph = null;
        }
    }

    #endregion

    #region Validate

    public void ValidateAdd(bool condition, Control control, string message, ErrorType errorType)
    {
        validateControls.Add(new EMGValidate(condition, control, message, errorType));
    }
    public void ValidateClear()
    {
        dxError.ClearErrors();
        validateControls.Clear();
    }

    public bool isValidate
    {
        get
        {
            dxError.ClearErrors();
            foreach (EMGValidate item in validateControls)
            {
                if (item.Condition)
                {
                    dxError.SetError(item.SelectControl, item.Message, item.ErrorType);
                }
            }

            return !dxError.HasErrors;
        }
    }

    #endregion

    private void btnFiltreKaydet_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("FKaydet").Invoke(this, null);
        }
        catch { }
    }

    private void btnAktarExcel_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("AktarXLS").Invoke(this, null);
        }
        catch { }
    }

    private void btnAktarPDF_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            this.GetType().GetMethod("AktarPDF").Invoke(this, null);
        }
        catch { }
    }

    public void SetInfoText(string message, MImageType mImageType)
    {
        infoText.Caption = message;
        if (mImageType == MImageType.None)
            infoText.Glyph = null;
        else if (mImageType == MImageType.Cancel || mImageType == MImageType.Error)
            infoText.Glyph = ımageCollection1.Images[0];
        else if (mImageType == MImageType.Apply)
            infoText.Glyph = ımageCollection1.Images[1];
        else if (mImageType == MImageType.Question)
            infoText.Glyph = ımageCollection1.Images[2];
        else if (mImageType == MImageType.Save)
            infoText.Glyph = ımageCollection1.Images[3];
        else if (mImageType == MImageType.Info)
            infoText.Glyph = ımageCollection1.Images[4];

    }


}


public enum EMGFormButtonSetType
{
    ListButtonSet,
    EntryFormButtonSet,
    CloseOnly
}


public class EMGValidate
{
    public bool Condition { get; set; }
    public Control SelectControl { get; set; }
    public string Message { get; set; }
    public DevExpress.XtraEditors.DXErrorProvider.ErrorType ErrorType { get; set; }

    public EMGValidate(bool _Condition, Control _SelectControl, string _Message, DevExpress.XtraEditors.DXErrorProvider.ErrorType _ErrorType)
    {
        Condition = _Condition;
        SelectControl = _SelectControl;
        Message = _Message;
        ErrorType = _ErrorType;
    }

}

public enum MImageType
{
    Cancel,
    Apply,
    Question,
    Save,
    Info,
    Error,
    None
}