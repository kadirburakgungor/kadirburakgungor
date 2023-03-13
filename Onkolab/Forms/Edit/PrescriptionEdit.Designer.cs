namespace IVTRON.Forms.Edit
{
    partial class PrescriptionEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionEdit));
            this.GControlMedicines = new DevExpress.XtraGrid.GridControl();
            this.GViewMedicines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GControl = new DevExpress.XtraGrid.GridControl();
            this.GView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtIlacAdı = new DevExpress.XtraEditors.TextEdit();
            this.txtEnjektor = new DevExpress.XtraEditors.TextEdit();
            this.txtSiseSayisi = new DevExpress.XtraEditors.TextEdit();
            this.txtSeferSayısı = new DevExpress.XtraEditors.TextEdit();
            this.txtArtan = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiseSayisis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUyari = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFlakom1 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFlakom2 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFlakom3 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtFlakom4 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GControlMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlacAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnjektor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiseSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeferSayısı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArtan.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlMedicines
            // 
            this.GControlMedicines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GControlMedicines.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GControlMedicines.Location = new System.Drawing.Point(0, 676);
            this.GControlMedicines.MainView = this.GViewMedicines;
            this.GControlMedicines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GControlMedicines.Name = "GControlMedicines";
            this.GControlMedicines.Size = new System.Drawing.Size(1647, 233);
            this.GControlMedicines.TabIndex = 4;
            this.GControlMedicines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewMedicines});
            this.GControlMedicines.DoubleClick += new System.EventHandler(this.GControlMedicines_DoubleClick);
            // 
            // GViewMedicines
            // 
            this.GViewMedicines.GridControl = this.GControlMedicines;
            this.GViewMedicines.Name = "GViewMedicines";
            this.GViewMedicines.OptionsView.ShowGroupPanel = false;
            // 
            // GControl
            // 
            this.GControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GControl.Location = new System.Drawing.Point(0, 50);
            this.GControl.MainView = this.GView;
            this.GControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GControl.Name = "GControl";
            this.GControl.Size = new System.Drawing.Size(1647, 207);
            this.GControl.TabIndex = 5;
            this.GControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GView});
            this.GControl.DoubleClick += new System.EventHandler(this.GControl_DoubleClick);
            // 
            // GView
            // 
            this.GView.GridControl = this.GControl;
            this.GView.Name = "GView";
            this.GView.OptionsView.ShowGroupPanel = false;
            // 
            // txtIlacAdı
            // 
            this.txtIlacAdı.Location = new System.Drawing.Point(105, 7);
            this.txtIlacAdı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIlacAdı.Name = "txtIlacAdı";
            this.txtIlacAdı.Size = new System.Drawing.Size(112, 22);
            this.txtIlacAdı.TabIndex = 6;
            this.txtIlacAdı.EditValueChanged += new System.EventHandler(this.txtIlacAdı_EditValueChanged);
            // 
            // txtEnjektor
            // 
            this.txtEnjektor.Location = new System.Drawing.Point(372, 6);
            this.txtEnjektor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnjektor.Name = "txtEnjektor";
            this.txtEnjektor.Size = new System.Drawing.Size(112, 22);
            this.txtEnjektor.TabIndex = 7;
            // 
            // txtSiseSayisi
            // 
            this.txtSiseSayisi.Location = new System.Drawing.Point(105, 58);
            this.txtSiseSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiseSayisi.Name = "txtSiseSayisi";
            this.txtSiseSayisi.Size = new System.Drawing.Size(112, 22);
            this.txtSiseSayisi.TabIndex = 8;
            // 
            // txtSeferSayısı
            // 
            this.txtSeferSayısı.Location = new System.Drawing.Point(372, 57);
            this.txtSeferSayısı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeferSayısı.Name = "txtSeferSayısı";
            this.txtSeferSayısı.Size = new System.Drawing.Size(112, 22);
            this.txtSeferSayısı.TabIndex = 9;
            // 
            // txtArtan
            // 
            this.txtArtan.Location = new System.Drawing.Point(686, 7);
            this.txtArtan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtan.Name = "txtArtan";
            this.txtArtan.Size = new System.Drawing.Size(112, 22);
            this.txtArtan.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "İlac Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enjektor Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(264, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sefer Sayısı";
            // 
            // txtSiseSayisis
            // 
            this.txtSiseSayisis.AutoSize = true;
            this.txtSiseSayisis.ForeColor = System.Drawing.Color.Black;
            this.txtSiseSayisis.Location = new System.Drawing.Point(17, 62);
            this.txtSiseSayisis.Name = "txtSiseSayisis";
            this.txtSiseSayisis.Size = new System.Drawing.Size(68, 17);
            this.txtSiseSayisis.TabIndex = 14;
            this.txtSiseSayisis.Text = "Şise Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(525, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Artması Beklenen İlaç";
            // 
            // txtUyari
            // 
            this.txtUyari.AutoSize = true;
            this.txtUyari.Location = new System.Drawing.Point(276, 295);
            this.txtUyari.Name = "txtUyari";
            this.txtUyari.Size = new System.Drawing.Size(0, 17);
            this.txtUyari.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1340, 351);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(303, 53);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Operasyon Oluştur";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 419);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIlacAdı);
            this.panel2.Controls.Add(this.txtSiseSayisis);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSiseSayisi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtArtan);
            this.panel2.Controls.Add(this.txtEnjektor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSeferSayısı);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1623, 121);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.txtFlakom1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Location = new System.Drawing.Point(1235, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 148);
            this.panel3.TabIndex = 21;
            // 
            // txtFlakom1
            // 
            this.txtFlakom1.Location = new System.Drawing.Point(106, 117);
            this.txtFlakom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlakom1.Name = "txtFlakom1";
            this.txtFlakom1.Size = new System.Drawing.Size(303, 22);
            this.txtFlakom1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Çekim Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "1.Flakom";
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.ErrorImage")));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(329, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 75);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Controls.Add(this.txtFlakom2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(829, 14);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 148);
            this.panel4.TabIndex = 20;
            // 
            // txtFlakom2
            // 
            this.txtFlakom2.Location = new System.Drawing.Point(114, 119);
            this.txtFlakom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlakom2.Name = "txtFlakom2";
            this.txtFlakom2.Size = new System.Drawing.Size(286, 22);
            this.txtFlakom2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Çekim Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "2.Flakom";
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.ErrorImage")));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(329, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 75);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.txtFlakom3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(423, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 148);
            this.panel5.TabIndex = 19;
            // 
            // txtFlakom3
            // 
            this.txtFlakom3.Location = new System.Drawing.Point(101, 119);
            this.txtFlakom3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlakom3.Name = "txtFlakom3";
            this.txtFlakom3.Size = new System.Drawing.Size(299, 22);
            this.txtFlakom3.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Çekim Sayısı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "3.Flakom";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(332, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 75);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Honeydew;
            this.panel6.Controls.Add(this.txtFlakom4);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Location = new System.Drawing.Point(12, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 148);
            this.panel6.TabIndex = 18;
            // 
            // txtFlakom4
            // 
            this.txtFlakom4.Location = new System.Drawing.Point(100, 119);
            this.txtFlakom4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlakom4.Name = "txtFlakom4";
            this.txtFlakom4.Size = new System.Drawing.Size(300, 22);
            this.txtFlakom4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Çekim Sayısı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "4.Flakom";
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(329, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 75);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // PrescriptionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 939);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUyari);
            this.Controls.Add(this.GControl);
            this.Controls.Add(this.GControlMedicines);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PrescriptionEdit";
            this.Text = "PrescriptionEdit";
            this.Controls.SetChildIndex(this.GControlMedicines, 0);
            this.Controls.SetChildIndex(this.GControl, 0);
            this.Controls.SetChildIndex(this.txtUyari, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GControlMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlacAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnjektor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiseSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeferSayısı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArtan.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFlakom4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlMedicines;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewMedicines;
        private DevExpress.XtraGrid.GridControl GControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GView;
        private DevExpress.XtraEditors.TextEdit txtIlacAdı;
        private DevExpress.XtraEditors.TextEdit txtEnjektor;
        private DevExpress.XtraEditors.TextEdit txtSiseSayisi;
        private DevExpress.XtraEditors.TextEdit txtSeferSayısı;
        private DevExpress.XtraEditors.TextEdit txtArtan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSiseSayisis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtUyari;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtFlakom1;
        private DevExpress.XtraEditors.TextEdit txtFlakom2;
        private DevExpress.XtraEditors.TextEdit txtFlakom3;
        private DevExpress.XtraEditors.TextEdit txtFlakom4;
    }
}