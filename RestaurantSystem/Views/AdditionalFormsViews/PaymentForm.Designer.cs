namespace RestaurantSystem.Views.AdditionalForms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.TBCash = new System.Windows.Forms.TextBox();
            this.labelCash = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPesoSign = new System.Windows.Forms.Label();
            this.labelTotalVal = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBCash
            // 
            this.TBCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.TBCash, "TBCash");
            this.TBCash.Name = "TBCash";
            // 
            // labelCash
            // 
            resources.ApplyResources(this.labelCash, "labelCash");
            this.labelCash.ForeColor = System.Drawing.Color.Black;
            this.labelCash.Name = "labelCash";
            // 
            // labelPaymentMethod
            // 
            resources.ApplyResources(this.labelPaymentMethod, "labelPaymentMethod");
            this.labelPaymentMethod.ForeColor = System.Drawing.Color.Transparent;
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.labelPesoSign);
            this.panelHeader.Controls.Add(this.labelTotalVal);
            this.panelHeader.Controls.Add(this.labelPaymentMethod);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // labelPesoSign
            // 
            resources.ApplyResources(this.labelPesoSign, "labelPesoSign");
            this.labelPesoSign.ForeColor = System.Drawing.Color.Transparent;
            this.labelPesoSign.Name = "labelPesoSign";
            // 
            // labelTotalVal
            // 
            resources.ApplyResources(this.labelTotalVal, "labelTotalVal");
            this.labelTotalVal.ForeColor = System.Drawing.Color.Transparent;
            this.labelTotalVal.Name = "labelTotalVal";
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // PaymentForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelCash);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.TBCash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TopMost = true;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPesoSign;
        public System.Windows.Forms.Label labelTotalVal;
        public System.Windows.Forms.TextBox TBCash;
        public System.Windows.Forms.Button buttonConfirm;
    }
}