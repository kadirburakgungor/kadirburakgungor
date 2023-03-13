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

namespace IVTRON.Forms.Edit
{
    public partial class MedicineEdit : EMGForm
    {
        public MedicineEdit()
        {
            InitializeComponent();
        }
        OnkolabDb db = new OnkolabDb();
        public Medicines obj = new Medicines();
        String mesaj = "İlaç";
        OnkolabExtension extension = new OnkolabExtension();



        public void Yukle()
        {



            if (obj.Id == 0)
            {
                //obj.SetObject(obj.DepoID);
                //EMGFormEvents.ClassToForm(this.LC, obj);
            }
            else
            {
                obj = db.Medicines.FirstOrDefault(a => a.Id == obj.Id);



                EMGFormEvents.ClassToForm(this.LC, obj);



            }
            this.Modifield = false;
        }



        public void Yeni()
        {
            if (Modifield)
            {
                string msg = "Bilgiler Kayıt Edilmedi.\nFormu Temizlemek İstiyor musunuz ?";
                if (Message.QuestionMessage(msg, this.Text) == DialogResult.No)
                    return;
            }
            //obj = new MainDiagnosis();
            EMGFormEvents.FormClear(LC, obj);
            this.Modifield = false;
        }



        public void Kaydet()
        {

            //Class'ı doldur


            ValidateClear();
            // Note : ValidateAdd(Condition, Control, Message, ErrorType.Warning);
            //ValidateAdd(txtDepoTanimi.Text.Trim() == "", txtDepoTanimi, "Depo Tanımı Alanı Boş Geçilemez.", ErrorType.Warning);
            //ValidateAdd(txtAdres.Text.Trim() == "", txtAdres, "Depo Adresi Alanı Boş Geçilemez.", ErrorType.Warning);
            if (!isValidate)
            {
                Message.InfoMessage("Lütfen Girişleri Kontrol Ediniz.", this.Text);
                return;
            }
            if (obj.Id != 0)
            {
            }
            EMGFormEvents.FormToClass(LC, obj);
            // Save - Update
            if (obj.Id == 0)
            {
                obj.CozucuTuruId = 1;
          

                    db.Medicines.Add(obj);
                db.SaveChanges();

                if (obj.Id > 0)
                {
                    Message.InfoMessage("" + mesaj + " Kayıt Edildi .", this.Text);
                    this.Modifield = false;
                    this.Close();
                }
                else
                {
                    Message.ErrorMessage("" + mesaj + " Kayıt Edilemedi .", this.Text);
                }
            }
            else
            {

                db.SaveChanges();
                Message.InfoMessage("" + mesaj + " Kayıt Edildi .", this.Text);
                this.Modifield = false;
                this.Close();
            }
        }

        private void MedicineEdit_Load(object sender, EventArgs e)
        {
            EMGFormEvents.LookUp(extension.ToDataTable(db.Brands.ToList()), txtBrandId, "Id", "Name", "Marka");

            EMGFormEvents.LookUp(extension.ToDataTable(db.Speeds.ToList()), txtCozmeHızıId, "Id", "Name", "Çözücü");

            EMGFormEvents.LookUp(extension.ToDataTable(db.Speeds.ToList()), txtKaristirmaHiziId, "Id", "Name", "Karıştırma Hızı");

            EMGFormEvents.LookUp(extension.ToDataTable(db.Unit.ToList()), txtUnitId, "Id", "Name", "Birim");

            EMGFormEvents.LookUp(extension.ToDataTable(db.MainDiagnosis.ToList()), leMainDiagnosis, "Id", "Name", "Ana Tanı");

        }

        private void leMainDiagnosis_EditValueChanged(object sender, EventArgs e)
        {

            int deger = leMainDiagnosis.EditValue.ToInt();

            EMGFormEvents.LookUp(extension.ToDataTable(db.SubDiagnosis.Where(a => a.MainDiagnosisId == deger).ToList()), leSubDiagnosis, "Id", "Name", "Ana Tanı");
        }

        private void leSubDiagnosis_EditValueChanged(object sender, EventArgs e)
        {
            int deger = leSubDiagnosis.EditValue.ToInt();

            EMGFormEvents.LookUp(extension.ToDataTable(db.Protokols.Where(a => a.SubDiagnosisId == deger).ToList()), leProtokol, "Id", "Name", "Protokol");

        }

        private void leProtokol_EditValueChanged(object sender, EventArgs e)
        {
            int deger = leProtokol.EditValue.ToInt();

            EMGFormEvents.LookUp(extension.ToDataTable(db.EtkenMadde.Where(a => a.ProtokolId == deger).ToList()), txtEtkenMaddeId, "Id", "Name", "Etken Madde");

        }
    }
}


