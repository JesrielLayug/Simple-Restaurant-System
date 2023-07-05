namespace RestaurantSystem.Models
{
    partial class CustomerOrdersModel
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
            this.labelRestaurantLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelBaseForOrder = new System.Windows.Forms.Panel();
            this.panelBaseTop = new System.Windows.Forms.Panel();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonTakeOut = new System.Windows.Forms.Button();
            this.buttonDineIn = new System.Windows.Forms.Button();
            this.panelBaseRigth = new System.Windows.Forms.Panel();
            this.panelBaseOfBase = new System.Windows.Forms.Panel();
            this.panelNoOrder = new System.Windows.Forms.Panel();
            this.labelNoOrder = new System.Windows.Forms.Label();
            this.pictureBoxNoOrder = new System.Windows.Forms.PictureBox();
            this.panelRightTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelBaseTop.SuspendLayout();
            this.panelBaseRigth.SuspendLayout();
            this.panelBaseOfBase.SuspendLayout();
            this.panelNoOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoOrder)).BeginInit();
            this.panelRightTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRestaurantLogo
            // 
            this.labelRestaurantLogo.AutoSize = true;
            this.labelRestaurantLogo.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurantLogo.ForeColor = System.Drawing.Color.Black;
            this.labelRestaurantLogo.Location = new System.Drawing.Point(30, 37);
            this.labelRestaurantLogo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRestaurantLogo.Name = "labelRestaurantLogo";
            this.labelRestaurantLogo.Size = new System.Drawing.Size(295, 31);
            this.labelRestaurantLogo.TabIndex = 1;
            this.labelRestaurantLogo.Text = "Customer\'s Pending Order";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.labelRestaurantLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1215, 104);
            this.panelHeader.TabIndex = 1;
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelBase.Controls.Add(this.panelBaseForOrder);
            this.panelBase.Controls.Add(this.panelBaseTop);
            this.panelBase.Controls.Add(this.panelBaseRigth);
            this.panelBase.Location = new System.Drawing.Point(14, 117);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(1185, 764);
            this.panelBase.TabIndex = 2;
            // 
            // panelBaseForOrder
            // 
            this.panelBaseForOrder.BackColor = System.Drawing.SystemColors.Control;
            this.panelBaseForOrder.Location = new System.Drawing.Point(0, 66);
            this.panelBaseForOrder.Name = "panelBaseForOrder";
            this.panelBaseForOrder.Size = new System.Drawing.Size(887, 698);
            this.panelBaseForOrder.TabIndex = 2;
            // 
            // panelBaseTop
            // 
            this.panelBaseTop.BackColor = System.Drawing.Color.White;
            this.panelBaseTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBaseTop.Controls.Add(this.buttonDelivery);
            this.panelBaseTop.Controls.Add(this.buttonTakeOut);
            this.panelBaseTop.Controls.Add(this.buttonDineIn);
            this.panelBaseTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaseTop.Location = new System.Drawing.Point(0, 0);
            this.panelBaseTop.Name = "panelBaseTop";
            this.panelBaseTop.Size = new System.Drawing.Size(887, 66);
            this.panelBaseTop.TabIndex = 1;
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelivery.FlatAppearance.BorderSize = 0;
            this.buttonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelivery.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelivery.Location = new System.Drawing.Point(595, 0);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Size = new System.Drawing.Size(298, 64);
            this.buttonDelivery.TabIndex = 2;
            this.buttonDelivery.Text = "DELIVERY";
            this.buttonDelivery.UseVisualStyleBackColor = true;
            this.buttonDelivery.Click += new System.EventHandler(this.buttonDelivery_Click);
            // 
            // buttonTakeOut
            // 
            this.buttonTakeOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTakeOut.FlatAppearance.BorderSize = 0;
            this.buttonTakeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeOut.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeOut.Location = new System.Drawing.Point(293, 0);
            this.buttonTakeOut.Name = "buttonTakeOut";
            this.buttonTakeOut.Size = new System.Drawing.Size(302, 64);
            this.buttonTakeOut.TabIndex = 1;
            this.buttonTakeOut.Text = "TAKE OUT";
            this.buttonTakeOut.UseVisualStyleBackColor = true;
            this.buttonTakeOut.Click += new System.EventHandler(this.buttonTakeOut_Click);
            // 
            // buttonDineIn
            // 
            this.buttonDineIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDineIn.FlatAppearance.BorderSize = 0;
            this.buttonDineIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDineIn.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDineIn.Location = new System.Drawing.Point(0, 0);
            this.buttonDineIn.Name = "buttonDineIn";
            this.buttonDineIn.Size = new System.Drawing.Size(293, 64);
            this.buttonDineIn.TabIndex = 0;
            this.buttonDineIn.Text = "DINE IN";
            this.buttonDineIn.UseVisualStyleBackColor = true;
            this.buttonDineIn.Click += new System.EventHandler(this.buttonDineIn_Click);
            // 
            // panelBaseRigth
            // 
            this.panelBaseRigth.BackColor = System.Drawing.Color.Black;
            this.panelBaseRigth.Controls.Add(this.panelBaseOfBase);
            this.panelBaseRigth.Controls.Add(this.panelRightTop);
            this.panelBaseRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBaseRigth.Location = new System.Drawing.Point(887, 0);
            this.panelBaseRigth.Name = "panelBaseRigth";
            this.panelBaseRigth.Size = new System.Drawing.Size(298, 764);
            this.panelBaseRigth.TabIndex = 0;
            // 
            // panelBaseOfBase
            // 
            this.panelBaseOfBase.Controls.Add(this.panelNoOrder);
            this.panelBaseOfBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseOfBase.Location = new System.Drawing.Point(0, 66);
            this.panelBaseOfBase.Name = "panelBaseOfBase";
            this.panelBaseOfBase.Size = new System.Drawing.Size(298, 698);
            this.panelBaseOfBase.TabIndex = 1;
            // 
            // panelNoOrder
            // 
            this.panelNoOrder.Controls.Add(this.labelNoOrder);
            this.panelNoOrder.Controls.Add(this.pictureBoxNoOrder);
            this.panelNoOrder.Location = new System.Drawing.Point(6, 129);
            this.panelNoOrder.Name = "panelNoOrder";
            this.panelNoOrder.Size = new System.Drawing.Size(286, 346);
            this.panelNoOrder.TabIndex = 1;
            // 
            // labelNoOrder
            // 
            this.labelNoOrder.AutoSize = true;
            this.labelNoOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOrder.ForeColor = System.Drawing.Color.Transparent;
            this.labelNoOrder.Location = new System.Drawing.Point(38, 299);
            this.labelNoOrder.Name = "labelNoOrder";
            this.labelNoOrder.Size = new System.Drawing.Size(210, 21);
            this.labelNoOrder.TabIndex = 1;
            this.labelNoOrder.Text = "No selected order to display";
            // 
            // pictureBoxNoOrder
            // 
            this.pictureBoxNoOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxNoOrder.Image = global::RestaurantSystem.Properties.Resources.BG;
            this.pictureBoxNoOrder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNoOrder.Name = "pictureBoxNoOrder";
            this.pictureBoxNoOrder.Size = new System.Drawing.Size(286, 278);
            this.pictureBoxNoOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNoOrder.TabIndex = 0;
            this.pictureBoxNoOrder.TabStop = false;
            // 
            // panelRightTop
            // 
            this.panelRightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelRightTop.Controls.Add(this.label1);
            this.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRightTop.Location = new System.Drawing.Point(0, 0);
            this.panelRightTop.Name = "panelRightTop";
            this.panelRightTop.Size = new System.Drawing.Size(298, 66);
            this.panelRightTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Order\'s Specification";
            // 
            // CustomerOrdersModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerOrdersModel";
            this.Size = new System.Drawing.Size(1215, 894);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelBaseTop.ResumeLayout(false);
            this.panelBaseRigth.ResumeLayout(false);
            this.panelBaseOfBase.ResumeLayout(false);
            this.panelNoOrder.ResumeLayout(false);
            this.panelNoOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoOrder)).EndInit();
            this.panelRightTop.ResumeLayout(false);
            this.panelRightTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRestaurantLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelBaseRigth;
        private System.Windows.Forms.Panel panelRightTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBaseTop;
        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonTakeOut;
        private System.Windows.Forms.Button buttonDineIn;
        private System.Windows.Forms.Panel panelBaseForOrder;
        private System.Windows.Forms.Panel panelNoOrder;
        private System.Windows.Forms.Label labelNoOrder;
        private System.Windows.Forms.PictureBox pictureBoxNoOrder;
        private System.Windows.Forms.Panel panelBaseOfBase;
    }
}
