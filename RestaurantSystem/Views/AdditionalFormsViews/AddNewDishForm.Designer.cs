namespace RestaurantSystem.Models.AdditionalForms
{
    partial class AddNewDishForm
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
            this.components = new System.ComponentModel.Container();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelAddNewDish = new System.Windows.Forms.Label();
            this.Soups = new System.Windows.Forms.RadioButton();
            this.Salads = new System.Windows.Forms.RadioButton();
            this.Pasta = new System.Windows.Forms.RadioButton();
            this.BakeryProducts = new System.Windows.Forms.RadioButton();
            this.Drinks = new System.Windows.Forms.RadioButton();
            this.buttonSelectPhoto = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddDish = new System.Windows.Forms.Button();
            this.GBRadioButtons = new System.Windows.Forms.GroupBox();
            this.pictureBoxDishPhoto = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.GBRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDishPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.labelAddNewDish);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(663, 78);
            this.panelTitle.TabIndex = 0;
            // 
            // labelAddNewDish
            // 
            this.labelAddNewDish.AutoSize = true;
            this.labelAddNewDish.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewDish.ForeColor = System.Drawing.Color.White;
            this.labelAddNewDish.Location = new System.Drawing.Point(26, 24);
            this.labelAddNewDish.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAddNewDish.Name = "labelAddNewDish";
            this.labelAddNewDish.Size = new System.Drawing.Size(159, 29);
            this.labelAddNewDish.TabIndex = 1;
            this.labelAddNewDish.Text = "ADD NEW DISH";
            // 
            // Soups
            // 
            this.Soups.AutoSize = true;
            this.Soups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soups.FlatAppearance.BorderSize = 2;
            this.Soups.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Soups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soups.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soups.Location = new System.Drawing.Point(21, 42);
            this.Soups.Name = "Soups";
            this.Soups.Size = new System.Drawing.Size(78, 28);
            this.Soups.TabIndex = 3;
            this.Soups.TabStop = true;
            this.Soups.Text = "Soups";
            this.Soups.UseVisualStyleBackColor = false;
            this.Soups.CheckedChanged += new System.EventHandler(this.radioButtonSoup_CheckedChanged);
            // 
            // Salads
            // 
            this.Salads.AutoSize = true;
            this.Salads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Salads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salads.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salads.Location = new System.Drawing.Point(111, 42);
            this.Salads.Name = "Salads";
            this.Salads.Size = new System.Drawing.Size(84, 28);
            this.Salads.TabIndex = 4;
            this.Salads.TabStop = true;
            this.Salads.Text = "Salads";
            this.Salads.UseVisualStyleBackColor = false;
            this.Salads.CheckedChanged += new System.EventHandler(this.radioButtonSalads_CheckedChanged);
            // 
            // Pasta
            // 
            this.Pasta.AutoSize = true;
            this.Pasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pasta.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pasta.Location = new System.Drawing.Point(214, 42);
            this.Pasta.Name = "Pasta";
            this.Pasta.Size = new System.Drawing.Size(74, 28);
            this.Pasta.TabIndex = 5;
            this.Pasta.TabStop = true;
            this.Pasta.Text = "Pasta";
            this.Pasta.UseVisualStyleBackColor = false;
            this.Pasta.CheckedChanged += new System.EventHandler(this.radioButtonPasta_CheckedChanged);
            // 
            // BakeryProducts
            // 
            this.BakeryProducts.AutoSize = true;
            this.BakeryProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BakeryProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BakeryProducts.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakeryProducts.Location = new System.Drawing.Point(311, 42);
            this.BakeryProducts.Name = "BakeryProducts";
            this.BakeryProducts.Size = new System.Drawing.Size(162, 28);
            this.BakeryProducts.TabIndex = 6;
            this.BakeryProducts.TabStop = true;
            this.BakeryProducts.Text = "Bakery Products";
            this.BakeryProducts.UseVisualStyleBackColor = false;
            this.BakeryProducts.CheckedChanged += new System.EventHandler(this.radioButtonBakery_CheckedChanged);
            // 
            // Drinks
            // 
            this.Drinks.AutoSize = true;
            this.Drinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drinks.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drinks.Location = new System.Drawing.Point(493, 42);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(80, 28);
            this.Drinks.TabIndex = 7;
            this.Drinks.TabStop = true;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = false;
            this.Drinks.CheckedChanged += new System.EventHandler(this.radioButtonDrinks_CheckedChanged);
            // 
            // buttonSelectPhoto
            // 
            this.buttonSelectPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.buttonSelectPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectPhoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectPhoto.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectPhoto.Location = new System.Drawing.Point(41, 482);
            this.buttonSelectPhoto.Name = "buttonSelectPhoto";
            this.buttonSelectPhoto.Size = new System.Drawing.Size(239, 51);
            this.buttonSelectPhoto.TabIndex = 9;
            this.buttonSelectPhoto.Text = "Add new image";
            this.buttonSelectPhoto.UseVisualStyleBackColor = false;
            this.buttonSelectPhoto.Click += new System.EventHandler(this.buttonSelectPhoto_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(317, 239);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 24);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Location = new System.Drawing.Point(320, 270);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(298, 31);
            this.textBoxName.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(317, 317);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 24);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrice.Location = new System.Drawing.Point(321, 350);
            this.textBoxPrice.MaxLength = 4;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(69, 31);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Black;
            this.labelDescription.Location = new System.Drawing.Point(317, 398);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 24);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Location = new System.Drawing.Point(321, 436);
            this.textBoxDescription.MaxLength = 150;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(298, 97);
            this.textBoxDescription.TabIndex = 16;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(136, 607);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 51);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddDish
            // 
            this.buttonAddDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.buttonAddDish.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDish.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDish.Location = new System.Drawing.Point(342, 607);
            this.buttonAddDish.Name = "buttonAddDish";
            this.buttonAddDish.Size = new System.Drawing.Size(200, 51);
            this.buttonAddDish.TabIndex = 18;
            this.buttonAddDish.Text = "Add Dish";
            this.buttonAddDish.UseVisualStyleBackColor = false;
            this.buttonAddDish.Click += new System.EventHandler(this.buttonAddDish_Click);
            // 
            // GBRadioButtons
            // 
            this.GBRadioButtons.BackColor = System.Drawing.SystemColors.Control;
            this.GBRadioButtons.Controls.Add(this.Soups);
            this.GBRadioButtons.Controls.Add(this.Salads);
            this.GBRadioButtons.Controls.Add(this.Pasta);
            this.GBRadioButtons.Controls.Add(this.BakeryProducts);
            this.GBRadioButtons.Controls.Add(this.Drinks);
            this.GBRadioButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBRadioButtons.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBRadioButtons.Location = new System.Drawing.Point(31, 107);
            this.GBRadioButtons.Name = "GBRadioButtons";
            this.GBRadioButtons.Size = new System.Drawing.Size(608, 100);
            this.GBRadioButtons.TabIndex = 19;
            this.GBRadioButtons.TabStop = false;
            this.GBRadioButtons.Text = " What kind of dish would you like to add? ";
            // 
            // pictureBoxDishPhoto
            // 
            this.pictureBoxDishPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxDishPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDishPhoto.ImageLocation = "";
            this.pictureBoxDishPhoto.Location = new System.Drawing.Point(41, 239);
            this.pictureBoxDishPhoto.Name = "pictureBoxDishPhoto";
            this.pictureBoxDishPhoto.Size = new System.Drawing.Size(239, 237);
            this.pictureBoxDishPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDishPhoto.TabIndex = 8;
            this.pictureBoxDishPhoto.TabStop = false;
            // 
            // AddNewDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(663, 688);
            this.Controls.Add(this.GBRadioButtons);
            this.Controls.Add(this.buttonAddDish);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSelectPhoto);
            this.Controls.Add(this.pictureBoxDishPhoto);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewDishForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.GBRadioButtons.ResumeLayout(false);
            this.GBRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDishPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelAddNewDish;
        private System.Windows.Forms.Button buttonSelectPhoto;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.PictureBox pictureBoxDishPhoto;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxDescription;
        public System.Windows.Forms.Button buttonAddDish;
        public System.Windows.Forms.RadioButton Soups;
        public System.Windows.Forms.RadioButton Salads;
        public System.Windows.Forms.RadioButton Pasta;
        public System.Windows.Forms.RadioButton BakeryProducts;
        public System.Windows.Forms.RadioButton Drinks;
        public System.Windows.Forms.GroupBox GBRadioButtons;
    }
}