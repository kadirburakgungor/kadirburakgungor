using DevExpress.XtraGrid.Columns;
using IVTRON;
using Onkolab.Forms.Edit;
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

namespace Onkolab.Forms.List
{
    public partial class OperationsList : EMGForm
    {
        public OperationsList()
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


        public void AktarXLS()
        {
            EMGFormEvents.ExportExcel(GView, "Rapor " + DateTime.Now.ToShortDateString());
        }

        public void AktarPDF()
        {
            EMGFormEvents.ExportPDF(GView, "Rapor " + DateTime.Now.ToShortDateString());
        }

 

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


            var table = dbNew.Database.SqlQuery<Operation_Sp_Result>("Operation_Sp").ToList();
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




        private void GView_DoubleClick(object sender, EventArgs e)
        {
            Duzenle();
        }



        public void Duzenle()
        {
            //...

            int index = GView.FocusedRowHandle;
            if (index < 0) return;
            int Value = GView.GetDataRow(index)[UniqueName].ToInt();


            OperationEdit form = new OperationEdit();
            form.obj.Id = Value;

            form.ShowDialog();

            Yukle();



        }



        public void Yenile()
        {
            Yukle();
        }



        public void Yeni()
        {
            new OperationEdit().ShowDialog();

            Yukle();
        }

    }

}


  