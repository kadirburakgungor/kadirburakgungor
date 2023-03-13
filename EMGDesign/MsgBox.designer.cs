
    partial class MsgBox
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
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.frm = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.msglabel = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.img = new System.Windows.Forms.PictureBox();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.frm)).BeginInit();
            this.frm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNo.Appearance.Options.UseFont = true;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Image = global::EMGDesign.Properties.Resources.no2;
            this.btnNo.Location = new System.Drawing.Point(130, 10);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(70, 25);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "No";
            this.btnNo.Visible = false;
            // 
            // frm
            // 
            this.frm.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.frm.AppearanceCaption.Options.UseFont = true;
            this.frm.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.frm.CaptionImage = global::EMGDesign.Properties.Resources.Blue_Ball;
            this.frm.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.frm.Controls.Add(this.panelControl3);
            this.frm.Controls.Add(this.panelControl2);
            this.frm.Controls.Add(this.panelControl1);
            this.frm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm.Location = new System.Drawing.Point(0, 0);
            this.frm.Name = "frm";
            this.frm.Size = new System.Drawing.Size(384, 162);
            this.frm.TabIndex = 1;
            this.frm.Text = "Message";
            this.frm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.msglabel);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(90, 40);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(292, 76);
            this.panelControl3.TabIndex = 3;
            // 
            // msglabel
            // 
            this.msglabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msglabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msglabel.Location = new System.Drawing.Point(0, 0);
            this.msglabel.Margin = new System.Windows.Forms.Padding(3);
            this.msglabel.Name = "msglabel";
            this.msglabel.Padding = new System.Windows.Forms.Padding(1, 5, 25, 5);
            this.msglabel.Size = new System.Drawing.Size(292, 76);
            this.msglabel.TabIndex = 0;
            this.msglabel.Text = "...";
            this.msglabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.img);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(88, 76);
            this.panelControl2.TabIndex = 2;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(23, 0);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(49, 76);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 0;
            this.img.TabStop = false;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(23, 76);
            this.panelControl4.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnNo);
            this.panelControl1.Controls.Add(this.btnYes);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 116);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(380, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = global::EMGDesign.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(206, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYes.Appearance.Options.UseFont = true;
            this.btnYes.Image = global::EMGDesign.Properties.Resources.accept;
            this.btnYes.Location = new System.Drawing.Point(54, 10);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(70, 25);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.Visible = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.frm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.frm)).EndInit();
            this.frm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.PanelControl panelControl2;
        public DevExpress.XtraEditors.PanelControl panelControl3;
        public System.Windows.Forms.PictureBox img;
        public DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.SimpleButton btnNo;
        public DevExpress.XtraEditors.SimpleButton btnYes;
        public System.Windows.Forms.Label msglabel;
        public DevExpress.XtraEditors.PanelControl panelControl4;
        public DevExpress.XtraEditors.GroupControl frm;
    }
