using DevExpress.XtraTab;
using IVTRON.Forms;
using IVTRON.Forms.List;
using IVTRON.Forms.Operation;
using Onkolab.Forms.List;
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

namespace IVTRON
{
    public partial class Onkolab : DevExpress.XtraBars.Ribbon.RibbonForm
    {
      
        public Onkolab()
        {
            InitializeComponent();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
         

            isOpen(typeof(HastaKayit), "Hasta Kayıt"); 
        }

        void isOpen(Type type, string baslik)
        {

            foreach (XtraTabPage item in MainMenu.TabPages)
            {
                foreach (Control cnt in item.Controls)
                {
                    if (cnt.GetType() == type)
                    {
                        MainMenu.SelectedTabPage = item;

                        return;
                    }
                }
            }

            CreateTab((Form)Activator.CreateInstance(type), baslik);


        }
        public void CreateTab(Form ui, string baslik)
        {
            XtraTabPage page = new XtraTabPage();
            MainMenu.TabPages.Add(page);
            MainMenu.SelectedTabPage = page;
            page.Text = baslik;
            ui.Dock = DockStyle.Fill;

            ui.TopLevel = false;
            ui.Parent = page;
            ui.AutoScroll = true;
            ui.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ui.Visible = true;


            ui.Tag = page;
            ui.FormClosed += new FormClosedEventHandler(ui_FormClosed);
            ui.TextChanged += new EventHandler(ui_TextChanged);
        }
        void ui_TextChanged(object sender, EventArgs e)
        {
            XtraTabPage page = (XtraTabPage)((Form)sender).Tag;
            page.Text = ((Form)sender).Text;
        }

        void ui_FormClosed(object sender, FormClosedEventArgs e)
        {
            XtraTabPage page = (XtraTabPage)((Form)sender).Tag;
            page.TabControl.TabPages.Remove(page);
        }

        private void mainDiagnosisButton_Click(object sender, EventArgs e)
        {
            isOpen(typeof(MainDiagnosisList), "Ana Tanılar");
        }

        private void subDiagnosis_Click(object sender, EventArgs e)
        {
            isOpen(typeof(SubDiagnosisList), "Alt Tanılar");
        }

        private void protokols_Click(object sender, EventArgs e)
        {
            isOpen(typeof(ProtokolList), "Protokoller");

        }

        private void doctorModule_Click(object sender, EventArgs e)
        {
            isOpen(typeof(DoctorModule), "Protokoller");

        }

        private void activeIngredient_Click(object sender, EventArgs e)
        {
            isOpen(typeof(ActiveIngredientList), "Etken Maddeler");

        }

        private void ilaclar_Click(object sender, EventArgs e)
        {
            isOpen(typeof(MedicineList), "İlaçlar");

        }

        private void receteButton_Click(object sender, EventArgs e)
        {
            isOpen(typeof(PrescriptionList), "Reçeteler");

        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            isOpen(typeof(OperationsList), "Operasyonlar");

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            isOpen(typeof(InjectorList), "Enjektörler");

        }
    }
   

}
