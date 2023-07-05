namespace RestaurantSystem.Views.AdditionalForms
{
    partial class OrderForm
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
            this.panelDish = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.labelOrderNote = new System.Windows.Forms.Label();
            this.TBOrderRequest = new System.Windows.Forms.TextBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDish
            // 
            this.panelDish.Location = new System.Drawing.Point(38, 91);
            this.panelDish.Name = "panelDish";
            this.panelDish.Size = new System.Drawing.Size(266, 150);
            this.panelDish.TabIndex = 2;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(61, 20);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(214, 24);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Order Verification Notice\r\n";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(342, 61);
            this.panelHeader.TabIndex = 1;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(35, 272);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 19);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity";
            // 
            // TBQuantity
            // 
            this.TBQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TBQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.TBQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBQuantity.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBQuantity.ForeColor = System.Drawing.Color.Black;
            this.TBQuantity.Location = new System.Drawing.Point(116, 268);
            this.TBQuantity.MaxLength = 2;
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(36, 27);
            this.TBQuantity.TabIndex = 3;
            this.TBQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBQuantity_KeyPress);
            // 
            // labelOrderNote
            // 
            this.labelOrderNote.AutoSize = true;
            this.labelOrderNote.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNote.ForeColor = System.Drawing.Color.Black;
            this.labelOrderNote.Location = new System.Drawing.Point(31, 316);
            this.labelOrderNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderNote.Name = "labelOrderNote";
            this.labelOrderNote.Size = new System.Drawing.Size(158, 19);
            this.labelOrderNote.TabIndex = 4;
            this.labelOrderNote.Text = "Order Special Request";
            // 
            // TBOrderRequest
            // 
            this.TBOrderRequest.BackColor = System.Drawing.SystemColors.Control;
            this.TBOrderRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBOrderRequest.Location = new System.Drawing.Point(34, 343);
            this.TBOrderRequest.Multiline = true;
            this.TBOrderRequest.Name = "TBOrderRequest";
            this.TBOrderRequest.Size = new System.Drawing.Size(265, 80);
            this.TBOrderRequest.TabIndex = 5;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonAddOrder.ForeColor = System.Drawing.Color.White;
            this.buttonAddOrder.Location = new System.Drawing.Point(31, 438);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(268, 51);
            this.buttonAddOrder.TabIndex = 7;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 509);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.TBOrderRequest);
            this.Controls.Add(this.labelOrderNote);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.panelDish);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Label labelOrderNote;
        private System.Windows.Forms.TextBox TBOrderRequest;
        private System.Windows.Forms.Button buttonAddOrder;
        public System.Windows.Forms.Panel panelDish;
    }
}