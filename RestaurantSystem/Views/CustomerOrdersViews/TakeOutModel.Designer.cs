namespace RestaurantSystem.Views.CustomerOrdersViews
{
    partial class TakeOutModel
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
            this.panelNoOrderBase = new System.Windows.Forms.Panel();
            this.labelNoOrder = new System.Windows.Forms.Label();
            this.pictureBoxNoOrder = new System.Windows.Forms.PictureBox();
            this.panelNoOrderBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNoOrderBase
            // 
            this.panelNoOrderBase.Controls.Add(this.labelNoOrder);
            this.panelNoOrderBase.Controls.Add(this.pictureBoxNoOrder);
            this.panelNoOrderBase.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNoOrderBase.Location = new System.Drawing.Point(141, 70);
            this.panelNoOrderBase.Name = "panelNoOrderBase";
            this.panelNoOrderBase.Size = new System.Drawing.Size(605, 558);
            this.panelNoOrderBase.TabIndex = 1;
            // 
            // labelNoOrder
            // 
            this.labelNoOrder.AutoSize = true;
            this.labelNoOrder.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOrder.Location = new System.Drawing.Point(48, 494);
            this.labelNoOrder.Name = "labelNoOrder";
            this.labelNoOrder.Size = new System.Drawing.Size(509, 29);
            this.labelNoOrder.TabIndex = 1;
            this.labelNoOrder.Text = "Currently, there are no orders on record for today.";
            // 
            // pictureBoxNoOrder
            // 
            this.pictureBoxNoOrder.Image = global::RestaurantSystem.Properties.Resources.BG;
            this.pictureBoxNoOrder.Location = new System.Drawing.Point(37, 15);
            this.pictureBoxNoOrder.Name = "pictureBoxNoOrder";
            this.pictureBoxNoOrder.Size = new System.Drawing.Size(531, 459);
            this.pictureBoxNoOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNoOrder.TabIndex = 0;
            this.pictureBoxNoOrder.TabStop = false;
            // 
            // TakeOutModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelNoOrderBase);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TakeOutModel";
            this.Size = new System.Drawing.Size(887, 698);
            this.panelNoOrderBase.ResumeLayout(false);
            this.panelNoOrderBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNoOrderBase;
        private System.Windows.Forms.Label labelNoOrder;
        private System.Windows.Forms.PictureBox pictureBoxNoOrder;
    }
}
