﻿using DevExpress.XtraGrid.Columns;
using IVTRON.Forms.Edit;
using Onkolab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVTRON.Forms.List
{
    public partial class ActiveIngredientList : EMGForm
    {
        public ActiveIngredientList()
        {
            InitializeComponent();
            UniqueName = "Id";

            ButtonSet = EMGFormButtonSetType.ListButtonSet;
            btnYenile.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSil.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnYeni.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnExportAktar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            GView.OptionsBehavior.Editable = false;
        }

        OnkolabDb db = new OnkolabDb();

        #region Properties

        private String mesaj = "Arıza";

        #endregion Properties

        public void AktarXLS()
        {
            EMGFormEvents.ExportExcel(GView, "Rapor " + DateTime.Now.ToShortDateString());
        }

        public void AktarPDF()
        {
            EMGFormEvents.ExportPDF(GView, "Rapor " + DateTime.Now.ToShortDateString());
        }

        private void ActiveIngredientList_Load(object sender, EventArgs e)
        {

        }

        #region Yukle

        public void Yukle()
        {
            OnkolabDb dbNew = new OnkolabDb();

            // Seçili Kayıt No
            int SelectedRow = 0;
            try
            {
                SelectedRow = GView.FocusedRowHandle;
            }
            catch { }
            var table = dbNew.Database.SqlQuery<List_EtkenMaddes_SP_Result>("List_EtkenMaddes_SP").ToList();
            OnkolabExtension a = new OnkolabExtension();

            GControl.DataSource = a.ToDataTable(table);



            foreach (GridColumn item in GView.Columns)
            {
                item.OptionsFilter.FilterPopupMode = FilterPopupMode.CheckedList;
            }

            //UniqueName Kolon Gizle
            try
            {
                GView.Columns[UniqueName].Visible = true;
            }
            catch { }

            //deleted Kolon Gizle


            //Kayıt Sayısı
            txtSubText.Caption = "Kayıt Sayısı : " + ((DataTable)GControl.DataSource).Rows.Count;

            //Tekrar Seç
            GView.FocusedRowHandle = SelectedRow;
            if (GView.FocusedRowHandle != SelectedRow)
                GView.FocusedRowHandle = SelectedRow - 1;

            this.Modifield = false;
        }


        #endregion Yukle

        #region GView_DoubleClick

        private void GView_DoubleClick(object sender, EventArgs e)
        {
            Duzenle();
        }

        #endregion GView_DoubleClick

        #region Duzenle

        public void Duzenle()
        {
            //...

            int index = GView.FocusedRowHandle;
            if (index < 0) return;
            int Value = GView.GetDataRow(index)[UniqueName].ToInt();


            ProtokolEdit form = new ProtokolEdit();
            form.obj.Id = Value;

            form.ShowDialog();

            Yukle();



        }

        #endregion Duzenle

        #region Yenile

        public void Yenile()
        {
            Yukle();
        }

        #endregion Yenile

        #region Yeni

        public void Yeni()
        {
            new ActiveIngredientEdit().ShowDialog();

            Yukle();
        }

        #endregion Yeni

       
    }
}