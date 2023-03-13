namespace IVTRON.Forms.Operation
{
    partial class DoctorModule
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
            this.LC = new DevExpress.XtraLayout.LayoutControl();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMainDiagnosis = new DevExpress.XtraEditors.LookUpEdit();
            this.GControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtProtokol = new DevExpress.XtraEditors.LookUpEdit();
            this.txtBsa = new DevExpress.XtraEditors.TextEdit();
            this.txtKilo = new System.Windows.Forms.NumericUpDown();
            this.txtBoy = new System.Windows.Forms.NumericUpDown();
            this.txtTeslimEdilecek = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPatientId = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAltTani = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LC)).BeginInit();
            this.LC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainDiagnosis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProtokol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBsa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEdilecek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltTani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // LC
            // 
            this.LC.Controls.Add(this.button1);
            this.LC.Controls.Add(this.txtMainDiagnosis);
            this.LC.Controls.Add(this.GControl);
            this.LC.Controls.Add(this.txtProtokol);
            this.LC.Controls.Add(this.txtBsa);
            this.LC.Controls.Add(this.txtKilo);
            this.LC.Controls.Add(this.txtBoy);
            this.LC.Controls.Add(this.txtTeslimEdilecek);
            this.LC.Controls.Add(this.txtPatientId);
            this.LC.Controls.Add(this.txtAltTani);
            this.LC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LC.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9});
            this.LC.Location = new System.Drawing.Point(0, 50);
            this.LC.Name = "LC";
            this.LC.Root = this.layoutControlGroup1;
            this.LC.Size = new System.Drawing.Size(1902, 953);
            this.LC.TabIndex = 9;
            this.LC.Text = "layoutControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 921);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1878, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMainDiagnosis
            // 
            this.txtMainDiagnosis.Location = new System.Drawing.Point(147, 166);
            this.txtMainDiagnosis.Name = "txtMainDiagnosis";
            this.txtMainDiagnosis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMainDiagnosis.Properties.NullText = "";
            this.txtMainDiagnosis.Size = new System.Drawing.Size(492, 22);
            this.txtMainDiagnosis.StyleController = this.LC;
            this.txtMainDiagnosis.TabIndex = 11;
            this.txtMainDiagnosis.EditValueChanged += new System.EventHandler(this.txtMainDiagnosis_EditValueChanged);
            // 
            // GControl
            // 
            this.GControl.Location = new System.Drawing.Point(12, 204);
            this.GControl.MainView = this.gridView1;
            this.GControl.Name = "GControl";
            this.GControl.Size = new System.Drawing.Size(1878, 713);
            this.GControl.TabIndex = 10;
            this.GControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GControl.Click += new System.EventHandler(this.GControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtProtokol
            // 
            this.txtProtokol.Location = new System.Drawing.Point(1386, 166);
            this.txtProtokol.Name = "txtProtokol";
            this.txtProtokol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProtokol.Properties.NullText = "";
            this.txtProtokol.Size = new System.Drawing.Size(492, 22);
            this.txtProtokol.StyleController = this.LC;
            this.txtProtokol.TabIndex = 9;
            this.txtProtokol.EditValueChanged += new System.EventHandler(this.txtProtokol_EditValueChanged);
            // 
            // txtBsa
            // 
            this.txtBsa.Location = new System.Drawing.Point(867, 95);
            this.txtBsa.Name = "txtBsa";
            this.txtBsa.Size = new System.Drawing.Size(1011, 22);
            this.txtBsa.StyleController = this.LC;
            this.txtBsa.TabIndex = 8;
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(867, 71);
            this.txtKilo.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(1011, 23);
            this.txtKilo.TabIndex = 7;
            this.txtKilo.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(867, 45);
            this.txtBoy.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(1011, 23);
            this.txtBoy.TabIndex = 6;
            this.txtBoy.ValueChanged += new System.EventHandler(this.txtBoy_ValueChanged);
            // 
            // txtTeslimEdilecek
            // 
            this.txtTeslimEdilecek.Location = new System.Drawing.Point(147, 71);
            this.txtTeslimEdilecek.Name = "txtTeslimEdilecek";
            this.txtTeslimEdilecek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTeslimEdilecek.Properties.NullText = "";
            this.txtTeslimEdilecek.Size = new System.Drawing.Size(593, 22);
            this.txtTeslimEdilecek.StyleController = this.LC;
            this.txtTeslimEdilecek.TabIndex = 5;
            // 
            // txtPatientId
            // 
            this.txtPatientId.Location = new System.Drawing.Point(147, 45);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPatientId.Properties.NullText = "";
            this.txtPatientId.Size = new System.Drawing.Size(593, 22);
            this.txtPatientId.StyleController = this.LC;
            this.txtPatientId.TabIndex = 4;
            // 
            // txtAltTani
            // 
            this.txtAltTani.Location = new System.Drawing.Point(766, 166);
            this.txtAltTani.Name = "txtAltTani";
            this.txtAltTani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAltTani.Properties.NullText = "";
            this.txtAltTani.Size = new System.Drawing.Size(493, 22);
            this.txtAltTani.StyleController = this.LC;
            this.txtAltTani.TabIndex = 9;
            this.txtAltTani.EditValueChanged += new System.EventHandler(this.txtAltTani_EditValueChanged);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1882, 741);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1902, 953);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.layoutControlGroup2.AppearanceGroup.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.layoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.Red;
            this.layoutControlGroup2.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1882, 121);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPatientId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(720, 26);
            this.layoutControlItem1.Text = "Hasta Adı :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTeslimEdilecek;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(720, 50);
            this.layoutControlItem2.Text = "Teslim Edilecek Yer :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtBoy;
            this.layoutControlItem3.Location = new System.Drawing.Point(720, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1138, 26);
            this.layoutControlItem3.Text = "Boy (cm) :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtKilo;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem4.Location = new System.Drawing.Point(720, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1138, 24);
            this.layoutControlItem4.Text = "Kilo (kg)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtBsa;
            this.layoutControlItem5.Location = new System.Drawing.Point(720, 50);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1138, 26);
            this.layoutControlItem5.Text = "Vucut Yüzey Alanı :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 121);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1882, 71);
            this.layoutControlGroup3.Text = "Ana Tanı";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtAltTani;
            this.layoutControlItem8.CustomizationFormText = "Ana Tanı ";
            this.layoutControlItem8.Location = new System.Drawing.Point(619, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(620, 26);
            this.layoutControlItem8.Text = "Alt Tanı";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtProtokol;
            this.layoutControlItem7.CustomizationFormText = "Ana Tanı ";
            this.layoutControlItem7.Location = new System.Drawing.Point(1239, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(619, 26);
            this.layoutControlItem7.Text = "Protokol";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtMainDiagnosis;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(619, 26);
            this.layoutControlItem6.Text = "Ana Tanı";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.GControl;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(1882, 717);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.button1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 909);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(1882, 24);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // DoctorModule
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.LC);
            this.Name = "DoctorModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "DoctorModule";
            this.Load += new System.EventHandler(this.DoctorModule_Load);
            this.Controls.SetChildIndex(this.LC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LC)).EndInit();
            this.LC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMainDiagnosis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProtokol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBsa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEdilecek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltTani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl LC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.NumericUpDown txtKilo;
        private System.Windows.Forms.NumericUpDown txtBoy;
        private DevExpress.XtraEditors.LookUpEdit txtTeslimEdilecek;
        private DevExpress.XtraEditors.LookUpEdit txtPatientId;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtBsa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraGrid.GridControl GControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit txtProtokol;
        private DevExpress.XtraEditors.LookUpEdit txtAltTani;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.LookUpEdit txtMainDiagnosis;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}