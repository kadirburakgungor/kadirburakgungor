
partial class EMGListForm
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
          
            this.emgGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupFilter = new DevExpress.XtraEditors.GroupControl();
     
            ((System.ComponentModel.ISupportInitialize)(this.emgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).BeginInit();
            this.SuspendLayout();
      
            // 
            // emgGridView
            // 
          
            // 
            // groupFilter
            // 
            this.groupFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilter.Location = new System.Drawing.Point(0, 43);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(737, 59);
            this.groupFilter.TabIndex = 5;
            this.groupFilter.Text = "Filtre";
            this.groupFilter.Visible = false;
            // 
            // EMGListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 483);
         
            this.Controls.Add(this.groupFilter);
            this.Name = "EMGListForm";
            this.Text = "EMGListForm";
            this.Load += new System.EventHandler(this.EMGListForm_Load);
            this.Controls.SetChildIndex(this.groupFilter, 0);
  
            ((System.ComponentModel.ISupportInitialize)(this.emgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFilter)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    public DevExpress.XtraEditors.GroupControl groupFilter;
   
    public DevExpress.XtraGrid.Views.Grid.GridView emgGridView;
}
