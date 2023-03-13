using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Data.SqlClient;
using System.IO;

public partial class EMGListForm : EMGForm
{
    public EMGListForm()
    {
        InitializeComponent();

        ButtonSet = EMGFormButtonSetType.ListButtonSet;

        GView.OptionsBehavior.Editable = false;
        GView.OptionsSelection.EnableAppearanceFocusedCell = false;
        GView.RowHeight = 22;
        GridViewFilte = true;

        GView.GroupPanelText = "Sütuna Göre Gruplamak İçin Sütun Başlığını Buraya Sürükleyiniz...";

        


    }
    //void LoadSettings()
    //{
    //    string path = Application.StartupPath;
    //    path += @"\ViewSetting\";

    //    if (!Directory.Exists(path))
    //    {
    //        Directory.CreateDirectory(path);
    //    }

    //    path += "\\" + GControl.Parent.ToString().Split(',')[0] + ".xml";

    //    if (File.Exists(path))
    //        GView.RestoreLayoutFromXml(path);
    //}
    //void btnFiltreKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    //{
    //    string path = Application.StartupPath;
    //    path += @"\ViewSetting\";

    //    if (!Directory.Exists(path))
    //    {
    //        Directory.CreateDirectory(path);
    //    }

    //    GView.SaveLayoutToXml(path + "\\" + GControl.Parent.ToString().Split(',')[0] + ".xml");
    //}

    public bool Filtre
    {
        get
        {
            return groupFilter.Visible;
        }
        set
        {
            groupFilter.Visible = value;
        }
    }
    public string FiltreBaslik
    {
        get
        {
            return groupFilter.Text;

        }
        set
        {
            groupFilter.Text = value;
        }
    }
    public bool GridViewFilte
    {
        get { return GView.OptionsView.ShowAutoFilterRow; }
        set { GView.OptionsView.ShowAutoFilterRow = value; }
    }

    public GridView GView
    {
        get
        {
            return emgGridView;
        }
        set
        {
            emgGridView = value;
        }
    }

    private void EMGListForm_Load(object sender, EventArgs e)
    {
       
    }

    public void ExcelExport()
    {
        try
        {
            string filename = this.Text;
            EMGFormEvents.ExportExcel(GView, filename);
        }
        catch
        {
            EMGMessage.MesajBox("Excel yazma işlemi sırasında bir hata oluştu !", " Hata !", MsgButton.Ok, MsgImg.Error);
            return;
        }

    }

    public void AktarXLS()
    {
        try
        {
            string filename = this.Text;
            EMGFormEvents.ExportExcel(GView, filename);
        }
        catch
        {
            EMGMessage.MesajBox("Excel yazma işlemi sırasında bir hata oluştu !", " Hata !", MsgButton.Ok, MsgImg.Error);
            return;
        }
    }

    public void AktarPDF()
    {
        try
        {
            string filename = this.Text;
            EMGFormEvents.ExportPDF(GView, filename);
        }
        catch
        {
            EMGMessage.MesajBox("PDF yazma işlemi sırasında bir hata oluştu !", " Hata !", MsgButton.Ok, MsgImg.Error);
            return;
        }
    }
}

