
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
    public partial class PrescriptionEdit : EMGForm
    {
        public PrescriptionEdit()
        {
            InitializeComponent();
        }
        OnkolabDb db = new OnkolabDb();
        public Prescription obj = new Prescription();
        
        String mesaj = "Reçete";

        OnkolabExtension extension = new OnkolabExtension();
        List<OperationItems> operationList = new List<OperationItems>();
        List<OperationItems> operationListView = new List<OperationItems>();
        Operations operation = new Operations();
        double mlDegeri = 0;
        int siseSayisi = 0, ilacId = 0, toplamSeferSayisi = 0, siseSeferSayısı = 0, toplamSeferSayisiView = 0;
        Injectors selectInjector = new Injectors();

        public void Yukle()
        {
            GView.OptionsBehavior.Editable = false;
            GViewMedicines.OptionsBehavior.Editable = false;


            if (obj.Id == 0)
            {
                //obj.SetObject(obj.DepoID);
                //EMGFormEvents.ClassToForm(this.LC, obj);
            }
            else
            {
                obj = db.Prescription.FirstOrDefault(item=> item.Id == obj.Id);


                var table = db.PrescriptionItems.Where(ıtems=>ıtems.PrescriptionId==obj.Id).ToList();
                OnkolabExtension a = new OnkolabExtension();
                // Listele
                GControl.DataSource = a.ToDataTable(table);
           


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
            // Save - Update
            if (obj.Id == 0)
            {

                //db.Protokols.Add(obj);
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

   

        private void getMedicenes_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
       
        }

        private void txtIlacAdı_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void GControl_DoubleClick(object sender, EventArgs e)
        {
            int index = GView.FocusedRowHandle;
            if (index < 0) return;
            int Value = GView.GetDataRow(index)["EtkenMaddeId"].ToInt();

            GControlMedicines.DataSource = extension.ToDataTable(db.Medicines.Where(a => a.EtkenMaddeId == Value).ToList());
        }

        private void GControlMedicines_DoubleClick(object sender, EventArgs e)
        {

            int indexEtkenMadde = GView.FocusedRowHandle;
            if (indexEtkenMadde < 0) return;
            double uygulanacakDoz = GView.GetDataRow(indexEtkenMadde)["UygulanacakDoz"].ToDbl();



            int index = GViewMedicines.FocusedRowHandle;
            if (index < 0) return;

            // ilacın mg degeri 
             ilacId = GViewMedicines.GetDataRow(index)["Id"].ToInt();

            double mg = GViewMedicines.GetDataRow(index)["Mg"].ToDbl();
            string ilacAdı = GViewMedicines.GetDataRow(index)["Name"].ToString();
            // İlacın ml degeri
            double ml = GViewMedicines.GetDataRow(index)["Ml"].ToDbl();
            double oran = mg / ml;

             mlDegeri = uygulanacakDoz / oran;

            var enjektorListesi=db.Injectors.ToList();

             selectInjector = enjektorListesi.OrderBy(x => Math.Abs(x.Capacity.ToDbl() - mlDegeri)).First();

             toplamSeferSayisi =(int) Math.Ceiling(mlDegeri / selectInjector.Capacity.ToDbl()).ToInt();

            toplamSeferSayisiView= (int)Math.Ceiling(mlDegeri / selectInjector.Capacity.ToDbl()).ToInt();

            siseSeferSayısı = (int)Math.Ceiling(ml / selectInjector.Capacity.ToDbl()).ToInt();

             siseSayisi = (int)Math.Ceiling(mlDegeri / ml.ToDbl()).ToInt();

            double artanMl= siseSayisi * ml - mlDegeri;
            if (siseSayisi > 4)
            {
                txtUyari.Text = "4 Şişeden Fazla Şeçim Yapamazsınız Lütfen Uygun Hacimli İlaç Seçiniz";
                          
            }
            else
            {

                for (int i = 0; i < siseSayisi; i++)
                {
                    var item = new OperationItems();
                    item.OperationId =0;
                    item.InjektorId = selectInjector.Id;
                    item.MedicineId = ilacId;


                    if (toplamSeferSayisiView > siseSeferSayısı)
                    {
                        item.TripCounter = siseSeferSayısı;
                        toplamSeferSayisiView = toplamSeferSayisiView - siseSeferSayısı;
                    }
                    else
                    {
                        item.TripCounter = toplamSeferSayisiView;
                    }

                    if (i == 0)
                    {
                        txtFlakom1.Text = item.TripCounter.ToStr();
                    }
                    if (i == 1)
                    {
                        txtFlakom2.Text = item.TripCounter.ToStr();
                    }

                    if (i == 2)
                    {
                        txtFlakom3.Text = item.TripCounter.ToStr();
                    }
                    if (i == 3)
                    {
                        txtFlakom4.Text = item.TripCounter.ToStr();
                    }





                    operationListView.Add(item);
                }



                txtIlacAdı.Text = ilacAdı;
                txtArtan.Text = artanMl.ToString();
                txtEnjektor.Text = selectInjector.Capacity.ToString();
                txtSeferSayısı.Text = toplamSeferSayisi.ToString();
                txtSiseSayisi.Text = siseSayisi.ToString();

              
            }

          
          

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            operation.PersonId = obj.PatientId;
            operation.PrescriptionId = obj.Id;

            int etkenMaddeIndex = GView.FocusedRowHandle;
            if (etkenMaddeIndex < 0) return;
            int etkenMaddeId = GView.GetDataRow(etkenMaddeIndex)["EtkenMaddeId"].ToInt();
            operation.EtkenMaddeId = etkenMaddeId;
            operation.Date = DateTime.Now;
            var Operations = db.Operations.Add(operation);
            db.SaveChanges();

            double hesaplanacakMlDegeri = mlDegeri;

            for (int i = 0; i < siseSayisi; i++)
            {
                var item = new OperationItems();
                item.OperationId = Operations.Id;
                item.InjektorId = selectInjector.Id;
                item.MedicineId = ilacId;


                if (toplamSeferSayisi > siseSeferSayısı)
                {
                    item.TripCounter = siseSeferSayısı;
                    toplamSeferSayisi = toplamSeferSayisi - siseSeferSayısı;
                }
                else
                {
                    item.TripCounter = toplamSeferSayisi;
                }


         


                operationList.Add(item);
            }

            db.OperationItems.AddRange(operationList);
            db.SaveChanges();

            Message.InfoMessage("Operasyon Kayıt Edildi","Operasyon");

        }
    }
}


