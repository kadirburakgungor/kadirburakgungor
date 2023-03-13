namespace IVTRON.Forms.Edit
{
    partial class ProtokolEdit
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
            this.txtSubDiagnosisId = new DevExpress.XtraEditors.LookUpEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LC)).BeginInit();
            this.LC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubDiagnosisId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // LC
            // 
            this.LC.Controls.Add(this.txtSubDiagnosisId);
            this.LC.Controls.Add(this.txtName);
            this.LC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LC.Location = new System.Drawing.Point(0, 50);
            this.LC.Name = "LC";
            this.LC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(0, 290, 250, 350);
            this.LC.Root = this.layoutControlGroup1;
            this.LC.Size = new System.Drawing.Size(974, 489);
            this.LC.TabIndex = 4;
            this.LC.Text = "layoutControl1";
            // 
            // txtSubDiagnosisId
            // 
            this.txtSubDiagnosisId.Location = new System.Drawing.Point(96, 38);
            this.txtSubDiagnosisId.Name = "txtSubDiagnosisId";
            this.txtSubDiagnosisId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSubDiagnosisId.Properties.NullText = "";
            this.txtSubDiagnosisId.Size = new System.Drawing.Size(866, 22);
            this.txtSubDiagnosisId.StyleController = this.LC;
            this.txtSubDiagnosisId.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(866, 22);
            this.txtName.StyleController = this.LC;
            this.txtName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(974, 489);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(954, 26);
            this.layoutControlItem1.Text = "Protokol Adı : ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSubDiagnosisId;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(954, 443);
            this.layoutControlItem2.Text = "Alt Gruplar :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 16);
            // 
            // ProtokolEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 569);
            this.Controls.Add(this.LC);
            this.Name = "ProtokolEdit";
            this.Text = "ProtokolEdit";
            this.Load += new System.EventHandler(this.ProtokolEdit_Load_1);
            this.Controls.SetChildIndex(this.LC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LC)).EndInit();
            this.LC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSubDiagnosisId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl LC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit txtSubDiagnosisId;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}