namespace IVTRON
{
    partial class Onkolab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Onkolab));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.doctorModule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.receteButton = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mainDiagnosisButton = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.subDiagnosis = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.protokols = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.activeIngredient = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ilaclar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MainMenu = new DevExpress.XtraTab.XtraTabControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement5,
            this.accordionControlElement6,
            this.accordionControlElement8});
            this.accordionControl1.Location = new System.Drawing.Point(0, 52);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(303, 881);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.doctorModule});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.Image")));
            this.accordionControlElement1.Text = "Doktor Modul";
            // 
            // doctorModule
            // 
            this.doctorModule.Image = ((System.Drawing.Image)(resources.GetObject("doctorModule.Image")));
            this.doctorModule.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.doctorModule.Text = "Doktor Modul";
            this.doctorModule.Click += new System.EventHandler(this.doctorModule_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.receteButton});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.Image")));
            this.accordionControlElement5.Text = "Eczacı Modulu";
            // 
            // receteButton
            // 
            this.receteButton.Image = ((System.Drawing.Image)(resources.GetObject("receteButton.Image")));
            this.receteButton.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.receteButton.Text = "Reçeteler";
            this.receteButton.Click += new System.EventHandler(this.receteButton_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainDiagnosisButton,
            this.subDiagnosis,
            this.protokols,
            this.activeIngredient,
            this.ilaclar,
            this.accordionControlElement2,
            this.accordionControlElement10});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Text = "Tanımlamalar";
            // 
            // mainDiagnosisButton
            // 
            this.mainDiagnosisButton.Image = ((System.Drawing.Image)(resources.GetObject("mainDiagnosisButton.Image")));
            this.mainDiagnosisButton.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mainDiagnosisButton.Text = "Ana Tanılar";
            this.mainDiagnosisButton.Click += new System.EventHandler(this.mainDiagnosisButton_Click);
            // 
            // subDiagnosis
            // 
            this.subDiagnosis.Image = ((System.Drawing.Image)(resources.GetObject("subDiagnosis.Image")));
            this.subDiagnosis.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.subDiagnosis.Text = "Alt Tanılar";
            this.subDiagnosis.Click += new System.EventHandler(this.subDiagnosis_Click);
            // 
            // protokols
            // 
            this.protokols.Image = ((System.Drawing.Image)(resources.GetObject("protokols.Image")));
            this.protokols.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.protokols.Text = "Protokoller";
            this.protokols.Click += new System.EventHandler(this.protokols_Click);
            // 
            // activeIngredient
            // 
            this.activeIngredient.Image = ((System.Drawing.Image)(resources.GetObject("activeIngredient.Image")));
            this.activeIngredient.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.activeIngredient.Text = "Etken Madde";
            this.activeIngredient.Click += new System.EventHandler(this.activeIngredient_Click);
            // 
            // ilaclar
            // 
            this.ilaclar.Image = ((System.Drawing.Image)(resources.GetObject("ilaclar.Image")));
            this.ilaclar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ilaclar.Text = "İlaçlar";
            this.ilaclar.Click += new System.EventHandler(this.ilaclar_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.Image")));
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Hasta Kayıt";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement9});
            this.accordionControlElement8.Expanded = true;
            this.accordionControlElement8.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement8.Image")));
            this.accordionControlElement8.Text = "Operasyonlar";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement9.Image")));
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Operasyonlar";
            this.accordionControlElement9.Click += new System.EventHandler(this.accordionControlElement9_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMenu.BackgroundImage")));
            this.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(303, 52);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1376, 881);
            this.MainMenu.TabIndex = 2;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.Aqua;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(1679, 52);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Element7";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement10.Image")));
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Enjektör";
            this.accordionControlElement10.Click += new System.EventHandler(this.accordionControlElement10_Click);
            // 
            // Onkolab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 933);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Onkolab";
            this.Ribbon = this.ribbonControl1;
            this.Text = "IVTRON";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        public DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraTab.XtraTabControl MainMenu;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainDiagnosisButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement subDiagnosis;
        private DevExpress.XtraBars.Navigation.AccordionControlElement protokols;
        private DevExpress.XtraBars.Navigation.AccordionControlElement doctorModule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement activeIngredient;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ilaclar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement receteButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
    }
}

