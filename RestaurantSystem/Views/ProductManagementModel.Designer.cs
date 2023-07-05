namespace RestaurantSystem.Models
{
    partial class ProductManagementModel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelProductsManagement = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.labelProductsManagement);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 9);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1219, 104);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelProductsManagement
            // 
            this.labelProductsManagement.AutoSize = true;
            this.labelProductsManagement.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductsManagement.ForeColor = System.Drawing.Color.Black;
            this.labelProductsManagement.Location = new System.Drawing.Point(31, 38);
            this.labelProductsManagement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductsManagement.Name = "labelProductsManagement";
            this.labelProductsManagement.Size = new System.Drawing.Size(260, 31);
            this.labelProductsManagement.TabIndex = 0;
            this.labelProductsManagement.Text = "Products Management";
            // 
            // ProductManagementModel
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductManagementModel";
            this.Size = new System.Drawing.Size(1219, 886);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelProductsManagement;
    }
}
