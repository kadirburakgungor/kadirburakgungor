
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

    public partial class MainDiagnosisEdit : EMGForm
    {
        public MainDiagnosisEdit()
        {
            InitializeComponent();
        }
        OnkolabDb db = new OnkolabDb();
        public MainDiagnosis obj = new MainDiagnosis();
        String mesaj = "Ana Tanı";
        public void Yukle()
        {
            if (obj.Id == 0)
            {
                //obj.SetObject(obj.DepoID);
                //EMGFormEvents.ClassToForm(this.LC, obj);
            }
            else
            {
               obj=db.MainDiagnosis.FirstOrDefault(a => a.Id == obj.Id);
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

                db.MainDiagnosis.Add(obj);
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
    }

}




