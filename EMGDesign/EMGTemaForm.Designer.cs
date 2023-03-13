namespace EMGDesign
{
    partial class EMGTemaForm
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
            this.imageList = new DevExpress.XtraEditors.ImageListBoxControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnUygula = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColumnWidth = 175;
            this.imageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.imageList.ItemHeight = 25;
            this.imageList.Location = new System.Drawing.Point(0, 0);
            this.imageList.MultiColumn = true;
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(530, 339);
            this.imageList.TabIndex = 0;
            this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageList_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnUygula);
            this.panelControl1.Controls.Add(this.btnIptal);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 339);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(530, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // btnUygula
            // 
            this.btnUygula.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUygula.Image = global::EMGDesign.Properties.Resources.accept;
            this.btnUygula.Location = new System.Drawing.Point(362, 7);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(75, 23);
            this.btnUygula.TabIndex = 1;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIptal.Image = global::EMGDesign.Properties.Resources.no2;
            this.btnIptal.Location = new System.Drawing.Point(443, 7);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 379);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTema";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTema_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTema_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ImageListBoxControl imageList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnUygula;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
    }
}