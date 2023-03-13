namespace IVTRON
{
    partial class MainDiagnosisList
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
            this.GControl = new DevExpress.XtraGrid.GridControl();
            this.GView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GView)).BeginInit();
            this.SuspendLayout();
            // 
            // GControl
            // 
            this.GControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GControl.Location = new System.Drawing.Point(0, 50);
            this.GControl.MainView = this.GView;
            this.GControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GControl.Name = "GControl";
            this.GControl.Size = new System.Drawing.Size(1034, 640);
            this.GControl.TabIndex = 4;
            this.GControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GView});
            // 
            // GView
            // 
            this.GView.GridControl = this.GControl;
            this.GView.Name = "GView";
            this.GView.OptionsView.ShowGroupPanel = false;
            // 
            // MainDiagnosisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 720);
            this.Controls.Add(this.GControl);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainDiagnosisList";
            this.Text = "MainDiagnosisList";
            this.Controls.SetChildIndex(this.GControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControl;
        private DevExpress.XtraGrid.Views.Grid.GridView GView;
    }
}