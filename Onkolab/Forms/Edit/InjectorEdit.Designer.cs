namespace Onkolab.Forms.Edit
{
    partial class InjectorEdit
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
            this.txtCapacity = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtTopValue = new DevExpress.XtraEditors.TextEdit();
            this.txtTopIndex = new DevExpress.XtraEditors.TextEdit();
            this.txtBotValue = new DevExpress.XtraEditors.TextEdit();
            this.txtBotIndex = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.LC)).BeginInit();
            this.LC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // LC
            // 
            this.LC.Controls.Add(this.txtCapacity);
            this.LC.Controls.Add(this.txtName);
            this.LC.Controls.Add(this.txtTopValue);
            this.LC.Controls.Add(this.txtTopIndex);
            this.LC.Controls.Add(this.txtBotValue);
            this.LC.Controls.Add(this.txtBotIndex);
            this.LC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LC.Location = new System.Drawing.Point(0, 43);
            this.LC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LC.Name = "LC";
            this.LC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-2760, 290, 250, 350);
            this.LC.Root = this.layoutControlGroup1;
            this.LC.Size = new System.Drawing.Size(713, 198);
            this.LC.TabIndex = 4;
            this.LC.Text = "layoutControl1";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(73, 36);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(628, 20);
            this.txtCapacity.StyleController = this.LC;
            this.txtCapacity.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(628, 20);
            this.txtName.StyleController = this.LC;
            this.txtName.TabIndex = 4;
            // 
            // txtTopValue
            // 
            this.txtTopValue.Location = new System.Drawing.Point(73, 60);
            this.txtTopValue.Name = "txtTopValue";
            this.txtTopValue.Size = new System.Drawing.Size(628, 20);
            this.txtTopValue.StyleController = this.LC;
            this.txtTopValue.TabIndex = 5;
            // 
            // txtTopIndex
            // 
            this.txtTopIndex.Location = new System.Drawing.Point(73, 84);
            this.txtTopIndex.Name = "txtTopIndex";
            this.txtTopIndex.Size = new System.Drawing.Size(628, 20);
            this.txtTopIndex.StyleController = this.LC;
            this.txtTopIndex.TabIndex = 5;
            // 
            // txtBotValue
            // 
            this.txtBotValue.Location = new System.Drawing.Point(73, 108);
            this.txtBotValue.Name = "txtBotValue";
            this.txtBotValue.Size = new System.Drawing.Size(628, 20);
            this.txtBotValue.StyleController = this.LC;
            this.txtBotValue.TabIndex = 5;
            // 
            // txtBotIndex
            // 
            this.txtBotIndex.Location = new System.Drawing.Point(73, 132);
            this.txtBotIndex.Name = "txtBotIndex";
            this.txtBotIndex.Size = new System.Drawing.Size(628, 20);
            this.txtBotIndex.StyleController = this.LC;
            this.txtBotIndex.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(713, 198);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(693, 24);
            this.layoutControlItem1.Text = "Enjektor Adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCapacity;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(693, 24);
            this.layoutControlItem2.Text = "Kapasite :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtTopValue;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(693, 24);
            this.layoutControlItem3.Text = "Top Değer :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTopIndex;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(693, 24);
            this.layoutControlItem4.Text = "Top Index :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtBotValue;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(693, 24);
            this.layoutControlItem5.Text = "Bot Değer :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtBotIndex;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(693, 58);
            this.layoutControlItem6.Text = "Bot Index :";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(58, 13);
            // 
            // InjectorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 266);
            this.Controls.Add(this.LC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InjectorEdit";
            this.Text = "InjectorEdit";
            this.Controls.SetChildIndex(this.LC, 0);
            ((System.ComponentModel.ISupportInitialize)(this.LC)).EndInit();
            this.LC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTopIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBotIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl LC;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtCapacity;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtTopValue;
        private DevExpress.XtraEditors.TextEdit txtTopIndex;
        private DevExpress.XtraEditors.TextEdit txtBotValue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtBotIndex;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}