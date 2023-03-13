
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

namespace IVTRON.Forms.Operation
{
    public partial class DoctorModule : EMGForm
    {
        public DoctorModule()
        {
            InitializeComponent();
          
        }


        OnkolabDb db = new OnkolabDb();

        double bsa = 0;

      

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(txtKilo.Value>0 && txtBoy.Value > 0)
            {
                var deger = (txtBoy.Value * txtKilo.Value) / 3600;
                 bsa = Math.Sqrt(deger.ToDbl());
            }
            txtBsa.Text = Math.Round(bsa, 2).ToStr();
        }

        private void txtBoy_ValueChanged(object sender, EventArgs e)
        {
            if (txtKilo.Value > 0 && txtBoy.Value > 0)
            {
                var deger = (txtBoy.Value * txtKilo.Value) / 3600;
                bsa = Math.Sqrt(deger.ToDbl());
            }
            txtBsa.Text = Math.Round(bsa,2).ToStr();
        }

        private void GControl_Click(object sender, EventArgs e)
        {

        }

        private void DoctorModule_Load(object sender, EventArgs e)
        {

            OnkolabExtension extension = new OnkolabExtension();
            EMGFormEvents.LookUp(extension.ToDataTable(db.Patients.ToList()), txtPatientId, "Id", "Name", "Ana Tanı");

            EMGFormEvents.LookUp(extension.ToDataTable(db.MainDiagnosis.ToList()), txtMainDiagnosis, "Id", "Name", "Ana Tanı");



        }

        private void txtMainDiagnosis_EditValueChanged(object sender, EventArgs e)
        {
            OnkolabExtension extension = new OnkolabExtension();

            int deger = txtMainDiagnosis.EditValue.ToInt();
            
            EMGFormEvents.LookUp(extension.ToDataTable(db.SubDiagnosis.Where(a=>a.MainDiagnosisId== deger).ToList()), txtAltTani, "Id", "Name", "Alt Tanı");

        }

        private void txtAltTani_EditValueChanged(object sender, EventArgs e)
        {
            OnkolabExtension extension = new OnkolabExtension();
            int deger = txtAltTani.EditValue.ToInt();

            EMGFormEvents.LookUp(extension.ToDataTable(db.Protokols.Where(a => a.SubDiagnosisId == deger).ToList()), txtProtokol, "Id", "Name", "Protokol");

        }

        private void txtProtokol_EditValueChanged(object sender, EventArgs e)
        {
            int deger = txtProtokol.EditValue.ToInt();

           var list= db.EtkenMadde.Where(b => b.ProtokolId == deger).ToList();

            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Etken Madde", typeof(string)));
            dt.Columns.Add(new DataColumn("Hesaplanan Doz", typeof(double)));
            dt.Columns.Add(new DataColumn("Uygulanacak Doz", typeof(double)));    
            DataColumn a = new DataColumn("Seyreltme Miktarı", typeof(double));
            a.ReadOnly = true;
            dt.Columns.Add(a);
            dt.Columns.Add(new DataColumn("SF", typeof(bool)));
            dt.Columns.Add(new DataColumn("DEX", typeof(bool)));
            dt.Columns.Add(new DataColumn("1/3 IZODEX", typeof(bool)));
            dt.Columns.Add(new DataColumn("PVC", typeof(bool)));
            dt.Columns.Add(new DataColumn("PE", typeof(bool)));
            dt.Columns.Add(new DataColumn("EVA", typeof(bool)));
            dt.Columns.Add(new DataColumn("Uygulama Tarihi", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Note", typeof(string)));
            dt.Columns.Add(new DataColumn("ExtraNotes", typeof(string)));
            foreach (var item in list)
            {
                double hesaplananDoz = 0;
                double UygulanacakDoz = 0;
                if (item.UnitId == 1)
                {
                    //mg/m2
                    hesaplananDoz=item.Dose*bsa;

                }
                if (item.UnitId == 2)
                {
                    //mg/kg
                    hesaplananDoz = item.Dose * txtKilo.Value.ToDbl();

                }
                if (item.UnitId == 3)
                {
                    // mg
                    hesaplananDoz = item.Dose;

                }
                if (item.UnitId == 4)
                {
                    //UI/mg 
                    // Burası nasıl olacak 
                    hesaplananDoz = item.Dose* bsa;

                }


                dt.Rows.Add(item.Id,item.Name, hesaplananDoz, hesaplananDoz, item.DilitionAmount, item.Sf, item.Dex, item.Izodex, item.Pvc, item.Pe, item.Pvc, item.Date, item.Notes, "Extra Notes");

                GControl.DataSource = dt;
                gridView1.Columns["Hesaplanan Doz"].OptionsColumn.AllowEdit = false;

                if (!item.Sf)
                {
                    gridView1.Columns["SF"].OptionsColumn.AllowEdit = false;

                }
                if (!item.Dex)
                {
                    gridView1.Columns["DEX"].OptionsColumn.AllowEdit = false;

                }
                if (!item.Izodex)
                {
                    gridView1.Columns["1/3 IZODEX"].OptionsColumn.AllowEdit = false;

                }
              


            }
            
            

          
           // ((gridView1.Columns[0].Width = 20;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Prescription recete = new Prescription();
                recete.PatientId = txtPatientId.EditValue.ToInt();
                recete.Boy = txtBoy.Value.ToInt();
                recete.Kg = txtKilo.Value.ToInt();
                recete.Bsa = bsa;
                recete.ProtokolId = txtProtokol.EditValue.ToInt();
                recete.SubDiagnosisId = txtAltTani.EditValue.ToInt();
                recete.MainDiagnosisId = txtMainDiagnosis.EditValue.ToInt();

                recete.TeslimEdilecekBirimId = 1;
                var newValue = db.Prescription.Add(recete);
                db.SaveChanges();




                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    PrescriptionItems receteItems = new PrescriptionItems();
             


                    receteItems.PrescriptionId = newValue.Id;
                    receteItems.EtkenMaddeId = gridView1.GetRowCellValue(i, "Id").ToInt();
                    receteItems.HesaplananDoz = gridView1.GetRowCellValue(i, "Hesaplanan Doz").ToDbl();
                    receteItems.UygulanacakDoz = gridView1.GetRowCellValue(i, "Uygulanacak Doz").ToDbl();
                    receteItems.SeyreltmeMiktari = gridView1.GetRowCellValue(i, "Seyreltme Miktarı").ToDbl();
                    receteItems.Sf = gridView1.GetRowCellValue(i, "SF").ToBool();
                    receteItems.Dex = gridView1.GetRowCellValue(i, "DEX").ToBool();
                    receteItems.Izodex = gridView1.GetRowCellValue(i, "1/3 IZODEX").ToBool();
                    receteItems.Pvc = gridView1.GetRowCellValue(i, "PVC").ToBool();
                    receteItems.Eva = gridView1.GetRowCellValue(i, "EVA").ToBool();
                    receteItems.Pe = gridView1.GetRowCellValue(i, "PE").ToBool();
                    receteItems.UygualamTarihi = gridView1.GetRowCellValue(i, "Uygulama Tarihi").ToDate();
                    receteItems.Notes = gridView1.GetRowCellValue(i, "Note").ToStr();
                    receteItems.ExtraNotes = gridView1.GetRowCellValue(i, "ExtraNotes").ToStr();


                    db.PrescriptionItems.Add(receteItems);

                 
                }

                db.SaveChanges();
                Message.InfoMessage("Reçete Kayıt Edildi .", this.Text);

                GControl.DataSource = new DataTable();
            }
            catch (Exception ex)
            {

                
            }


        }
    }
}
