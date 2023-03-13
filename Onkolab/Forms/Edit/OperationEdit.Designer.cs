namespace Onkolab.Forms.Edit
{
    partial class OperationEdit
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tmrHome = new System.Windows.Forms.Timer(this.components);
            this.tmrDuzen = new System.Windows.Forms.Timer(this.components);
            this.tmrCekim = new System.Windows.Forms.Timer(this.components);
            this.tmrBasma = new System.Windows.Forms.Timer(this.components);
            this.tmrEgilKalk = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.GControlItems = new DevExpress.XtraGrid.GridControl();
            this.GViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GControlFlakomTarti = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.GControlSerumTarti = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrFlakomTarti = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlFlakomTarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlSerumTarti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(732, 347);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 351);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tmrHome
            // 
            this.tmrHome.Tick += new System.EventHandler(this.tmrHome_Tick);
            // 
            // tmrDuzen
            // 
            this.tmrDuzen.Tick += new System.EventHandler(this.tmrDuzen_Tick);
            // 
            // tmrCekim
            // 
            this.tmrCekim.Tick += new System.EventHandler(this.tmrCekim_Tick);
            // 
            // tmrBasma
            // 
            this.tmrBasma.Tick += new System.EventHandler(this.tmrBasma_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Operasyonu Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GControlItems
            // 
            this.GControlItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GControlItems.Location = new System.Drawing.Point(3, 52);
            this.GControlItems.MainView = this.GViewItems;
            this.GControlItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GControlItems.Name = "GControlItems";
            this.GControlItems.Size = new System.Drawing.Size(723, 200);
            this.GControlItems.TabIndex = 6;
            this.GControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewItems});
            // 
            // GViewItems
            // 
            this.GViewItems.GridControl = this.GControlItems;
            this.GViewItems.Name = "GViewItems";
            this.GViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şişeler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GControlItems);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(729, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 254);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 47);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(732, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 47);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Operasyon Adımları";
            // 
            // GControlFlakomTarti
            // 
            this.GControlFlakomTarti.Location = new System.Drawing.Point(0, 347);
            this.GControlFlakomTarti.MainView = this.gridView2;
            this.GControlFlakomTarti.Name = "GControlFlakomTarti";
            this.GControlFlakomTarti.Size = new System.Drawing.Size(358, 350);
            this.GControlFlakomTarti.TabIndex = 12;
            this.GControlFlakomTarti.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GControlFlakomTarti;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 47);
            this.panel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Flakom Tartı Okuma Değerleri";
            // 
            // GControlSerumTarti
            // 
            this.GControlSerumTarti.Location = new System.Drawing.Point(368, 348);
            this.GControlSerumTarti.MainView = this.gridView3;
            this.GControlSerumTarti.Name = "GControlSerumTarti";
            this.GControlSerumTarti.Size = new System.Drawing.Size(358, 350);
            this.GControlSerumTarti.TabIndex = 14;
            this.GControlSerumTarti.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.GControlSerumTarti;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(368, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 47);
            this.panel5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serum Tartı Okuma Değerleri";
            // 
            // tmrFlakomTarti
            // 
            this.tmrFlakomTarti.Tick += new System.EventHandler(this.tmrFlakomTarti_Tick);
            // 
            // OperationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 727);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.GControlSerumTarti);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.GControlFlakomTarti);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OperationEdit";
            this.Text = "OperationEdit";
            this.Load += new System.EventHandler(this.OperationEdit_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.GControlFlakomTarti, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.GControlSerumTarti, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlFlakomTarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlSerumTarti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Timer tmrHome;
        private System.Windows.Forms.Timer tmrDuzen;
        private System.Windows.Forms.Timer tmrCekim;
        private System.Windows.Forms.Timer tmrBasma;
        private System.Windows.Forms.Timer tmrEgilKalk;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl GControlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl GControlFlakomTarti;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl GControlSerumTarti;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer tmrFlakomTarti;
    }
}