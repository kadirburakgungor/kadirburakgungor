namespace IVTRON.Forms.Edit
{
    partial class SubDiagnosisEdit
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
            this.txtMainDiagnosisId = new DevExpress.XtraEditors.LookUpEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.A = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LC)).BeginInit();
            this.LC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainDiagnosisId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            this.SuspendLayout();
            // 
            // LC
            // 
            this.LC.Controls.Add(this.txtMainDiagnosisId);
            this.LC.Controls.Add(this.txtName);
            this.LC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LC.Location = new System.Drawing.Point(0, 50);
            this.LC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LC.Name = "LC";
            this.LC.Root = this.layoutControlGroup1;
            this.LC.Size = new System.Drawing.Size(974, 489);
            this.LC.TabIndex = 4;
            this.LC.Text = "layoutControl1";
            // 
            // txtMainDiagnosisId
            // 
            this.txtMainDiagnosisId.Location = new System.Drawing.Point(90, 38);
            this.txtMainDiagnosisId.Name = "txtMainDiagnosisId";
            this.txtMainDiagnosisId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMainDiagnosisId.Properties.NullText = "";
            this.txtMainDiagnosisId.Size = new System.Drawing.Size(872, 22);
            this.txtMainDiagnosisId.StyleController = this.LC;
            this.txtMainDiagnosisId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(872, 22);
            this.txtName.StyleController = this.LC;
            this.txtName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.A});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(974, 489);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(954, 26);
            this.layoutControlItem1.Text = "Alt Tanı Adı :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 16);
            // 
            // A
            // 
            this.A.Control = this.txtMainDiagnosisId;
            this.A.Location = new System.Drawing.Point(0, 26);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(954, 443);
            this.A.Text = "Ana Tanısı :";
            this.A.TextSize = new System.Drawing.Size(75, 16);
            // 
            // SubDiagnosisEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 569);
            this.Controls.Add(this.LC);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SubDiagnosisEdit";
            this.Text = "SubDiagnosisEdit";
            this.Load += new System.EventHandler(this.SubDiagnosisEdit_Load);
            this.Controls.SetChildIndex(this.LC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LC)).EndInit();
            this.LC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMainDiagnosisId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl LC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit txtMainDiagnosisId;
        private DevExpress.XtraLayout.LayoutControlItem A;
    }
}