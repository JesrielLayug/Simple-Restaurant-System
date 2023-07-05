namespace RestaurantSystem.Models
{
    partial class FoodAndDrinksModel
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
            this.labelRestaurantLogo = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.panelBaseCategoryBody = new System.Windows.Forms.Panel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelAdditionalFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalVal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelHr = new System.Windows.Forms.Panel();
            this.labelDiscountVal = new System.Windows.Forms.Label();
            this.labelPercentSign = new System.Windows.Forms.Label();
            this.TBDiscountValue = new System.Windows.Forms.TextBox();
            this.BTNPaynow = new System.Windows.Forms.Button();
            this.labelDiscountReduction = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.Panel_Cashier = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonTakeOut = new System.Windows.Forms.Button();
            this.buttonDineIn = new System.Windows.Forms.Button();
            this.panelBaseOrder = new System.Windows.Forms.Panel();
            this.panelNoOrder = new System.Windows.Forms.Panel();
            this.labelNoOrder = new System.Windows.Forms.Label();
            this.pictureBoxNoOrder = new System.Windows.Forms.PictureBox();
            this.panelTopCashier = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBaseCategory = new System.Windows.Forms.Panel();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.buttonBakeryProducts = new System.Windows.Forms.Button();
            this.buttonPasta = new System.Windows.Forms.Button();
            this.buttonSalad = new System.Windows.Forms.Button();
            this.buttonSoup = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.Panel_Cashier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBaseOrder.SuspendLayout();
            this.panelNoOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoOrder)).BeginInit();
            this.panelTopCashier.SuspendLayout();
            this.panelBaseCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.labelRestaurantLogo);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 9);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(905, 104);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelRestaurantLogo
            // 
            this.labelRestaurantLogo.AutoSize = true;
            this.labelRestaurantLogo.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurantLogo.ForeColor = System.Drawing.Color.Black;
            this.labelRestaurantLogo.Location = new System.Drawing.Point(28, 40);
            this.labelRestaurantLogo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRestaurantLogo.Name = "labelRestaurantLogo";
            this.labelRestaurantLogo.Size = new System.Drawing.Size(171, 31);
            this.labelRestaurantLogo.TabIndex = 0;
            this.labelRestaurantLogo.Text = "Foods && Drinks";
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAll.FlatAppearance.BorderSize = 0;
            this.buttonAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAll.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(18, 16);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(91, 49);
            this.buttonAll.TabIndex = 0;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // panelBaseCategoryBody
            // 
            this.panelBaseCategoryBody.Location = new System.Drawing.Point(3, 228);
            this.panelBaseCategoryBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBaseCategoryBody.Name = "panelBaseCategoryBody";
            this.panelBaseCategoryBody.Size = new System.Drawing.Size(915, 661);
            this.panelBaseCategoryBody.TabIndex = 8;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelPayment.Controls.Add(this.labelFee);
            this.panelPayment.Controls.Add(this.labelAdditionalFee);
            this.panelPayment.Controls.Add(this.label3);
            this.panelPayment.Controls.Add(this.labelTotalVal);
            this.panelPayment.Controls.Add(this.labelTotal);
            this.panelPayment.Controls.Add(this.panelHr);
            this.panelPayment.Controls.Add(this.labelDiscountVal);
            this.panelPayment.Controls.Add(this.labelPercentSign);
            this.panelPayment.Controls.Add(this.TBDiscountValue);
            this.panelPayment.Controls.Add(this.BTNPaynow);
            this.panelPayment.Controls.Add(this.labelDiscountReduction);
            this.panelPayment.Controls.Add(this.labelDiscount);
            this.panelPayment.Location = new System.Drawing.Point(12, 650);
            this.panelPayment.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(298, 236);
            this.panelPayment.TabIndex = 11;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFee.ForeColor = System.Drawing.Color.White;
            this.labelFee.Location = new System.Drawing.Point(223, 80);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(47, 18);
            this.labelFee.TabIndex = 23;
            this.labelFee.Text = " 00.00";
            // 
            // labelAdditionalFee
            // 
            this.labelAdditionalFee.AutoSize = true;
            this.labelAdditionalFee.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.labelAdditionalFee.Location = new System.Drawing.Point(21, 80);
            this.labelAdditionalFee.Name = "labelAdditionalFee";
            this.labelAdditionalFee.Size = new System.Drawing.Size(102, 18);
            this.labelAdditionalFee.TabIndex = 22;
            this.labelAdditionalFee.Text = "Additional Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(215, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "₱";
            // 
            // labelTotalVal
            // 
            this.labelTotalVal.AutoSize = true;
            this.labelTotalVal.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVal.ForeColor = System.Drawing.Color.White;
            this.labelTotalVal.Location = new System.Drawing.Point(233, 127);
            this.labelTotalVal.Name = "labelTotalVal";
            this.labelTotalVal.Size = new System.Drawing.Size(44, 19);
            this.labelTotalVal.TabIndex = 20;
            this.labelTotalVal.Text = "00.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.labelTotal.Location = new System.Drawing.Point(22, 127);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(43, 19);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "Total";
            // 
            // panelHr
            // 
            this.panelHr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelHr.Location = new System.Drawing.Point(24, 110);
            this.panelHr.Name = "panelHr";
            this.panelHr.Size = new System.Drawing.Size(253, 2);
            this.panelHr.TabIndex = 18;
            // 
            // labelDiscountVal
            // 
            this.labelDiscountVal.AutoSize = true;
            this.labelDiscountVal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountVal.ForeColor = System.Drawing.Color.White;
            this.labelDiscountVal.Location = new System.Drawing.Point(227, 51);
            this.labelDiscountVal.Name = "labelDiscountVal";
            this.labelDiscountVal.Size = new System.Drawing.Size(43, 18);
            this.labelDiscountVal.TabIndex = 14;
            this.labelDiscountVal.Text = "00.00";
            // 
            // labelPercentSign
            // 
            this.labelPercentSign.AutoSize = true;
            this.labelPercentSign.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.labelPercentSign.Location = new System.Drawing.Point(260, 19);
            this.labelPercentSign.Name = "labelPercentSign";
            this.labelPercentSign.Size = new System.Drawing.Size(21, 22);
            this.labelPercentSign.TabIndex = 13;
            this.labelPercentSign.Text = "%";
            // 
            // TBDiscountValue
            // 
            this.TBDiscountValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TBDiscountValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TBDiscountValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TBDiscountValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDiscountValue.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDiscountValue.ForeColor = System.Drawing.Color.White;
            this.TBDiscountValue.Location = new System.Drawing.Point(223, 18);
            this.TBDiscountValue.MaxLength = 2;
            this.TBDiscountValue.Name = "TBDiscountValue";
            this.TBDiscountValue.Size = new System.Drawing.Size(36, 25);
            this.TBDiscountValue.TabIndex = 0;
            this.TBDiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBDiscountValue.TextChanged += new System.EventHandler(this.TBDiscountValue_TextChanged);
            this.TBDiscountValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDiscountValue_KeyPress);
            // 
            // BTNPaynow
            // 
            this.BTNPaynow.BackColor = System.Drawing.Color.White;
            this.BTNPaynow.FlatAppearance.BorderSize = 0;
            this.BTNPaynow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPaynow.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPaynow.ForeColor = System.Drawing.Color.Black;
            this.BTNPaynow.Location = new System.Drawing.Point(26, 180);
            this.BTNPaynow.Name = "BTNPaynow";
            this.BTNPaynow.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BTNPaynow.Size = new System.Drawing.Size(251, 42);
            this.BTNPaynow.TabIndex = 7;
            this.BTNPaynow.Text = "Pay now";
            this.BTNPaynow.UseVisualStyleBackColor = false;
            this.BTNPaynow.Click += new System.EventHandler(this.BTNPaynow_Click);
            // 
            // labelDiscountReduction
            // 
            this.labelDiscountReduction.AutoSize = true;
            this.labelDiscountReduction.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountReduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.labelDiscountReduction.Location = new System.Drawing.Point(21, 51);
            this.labelDiscountReduction.Name = "labelDiscountReduction";
            this.labelDiscountReduction.Size = new System.Drawing.Size(129, 18);
            this.labelDiscountReduction.TabIndex = 9;
            this.labelDiscountReduction.Text = "Discount Reduction";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.labelDiscount.Location = new System.Drawing.Point(21, 23);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(63, 18);
            this.labelDiscount.TabIndex = 8;
            this.labelDiscount.Text = "Discount";
            // 
            // Panel_Cashier
            // 
            this.Panel_Cashier.BackColor = System.Drawing.Color.Black;
            this.Panel_Cashier.Controls.Add(this.groupBox1);
            this.Panel_Cashier.Controls.Add(this.panelBaseOrder);
            this.Panel_Cashier.Controls.Add(this.panelPayment);
            this.Panel_Cashier.Controls.Add(this.panelTopCashier);
            this.Panel_Cashier.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Cashier.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Cashier.Location = new System.Drawing.Point(902, 0);
            this.Panel_Cashier.Name = "Panel_Cashier";
            this.Panel_Cashier.Size = new System.Drawing.Size(322, 899);
            this.Panel_Cashier.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDelivery);
            this.groupBox1.Controls.Add(this.buttonTakeOut);
            this.groupBox1.Controls.Add(this.buttonDineIn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Service Option ";
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelivery.FlatAppearance.BorderSize = 0;
            this.buttonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelivery.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonDelivery.Location = new System.Drawing.Point(207, 24);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Size = new System.Drawing.Size(80, 35);
            this.buttonDelivery.TabIndex = 14;
            this.buttonDelivery.Text = "Delivery";
            this.buttonDelivery.UseVisualStyleBackColor = false;
            this.buttonDelivery.Click += new System.EventHandler(this.buttonDelivery_Click);
            // 
            // buttonTakeOut
            // 
            this.buttonTakeOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonTakeOut.FlatAppearance.BorderSize = 0;
            this.buttonTakeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeOut.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonTakeOut.Location = new System.Drawing.Point(112, 24);
            this.buttonTakeOut.Name = "buttonTakeOut";
            this.buttonTakeOut.Size = new System.Drawing.Size(80, 35);
            this.buttonTakeOut.TabIndex = 13;
            this.buttonTakeOut.Text = "Take Out";
            this.buttonTakeOut.UseVisualStyleBackColor = false;
            this.buttonTakeOut.Click += new System.EventHandler(this.buttonTakeOut_Click);
            // 
            // buttonDineIn
            // 
            this.buttonDineIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonDineIn.FlatAppearance.BorderSize = 0;
            this.buttonDineIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDineIn.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDineIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.buttonDineIn.Location = new System.Drawing.Point(16, 24);
            this.buttonDineIn.Name = "buttonDineIn";
            this.buttonDineIn.Size = new System.Drawing.Size(80, 35);
            this.buttonDineIn.TabIndex = 1;
            this.buttonDineIn.Text = "Dine In";
            this.buttonDineIn.UseVisualStyleBackColor = false;
            this.buttonDineIn.Click += new System.EventHandler(this.buttonDineIn_Click);
            // 
            // panelBaseOrder
            // 
            this.panelBaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelBaseOrder.Controls.Add(this.panelNoOrder);
            this.panelBaseOrder.Location = new System.Drawing.Point(12, 186);
            this.panelBaseOrder.Name = "panelBaseOrder";
            this.panelBaseOrder.Size = new System.Drawing.Size(298, 458);
            this.panelBaseOrder.TabIndex = 12;
            // 
            // panelNoOrder
            // 
            this.panelNoOrder.Controls.Add(this.labelNoOrder);
            this.panelNoOrder.Controls.Add(this.pictureBoxNoOrder);
            this.panelNoOrder.Location = new System.Drawing.Point(7, 63);
            this.panelNoOrder.Name = "panelNoOrder";
            this.panelNoOrder.Size = new System.Drawing.Size(284, 338);
            this.panelNoOrder.TabIndex = 0;
            // 
            // labelNoOrder
            // 
            this.labelNoOrder.AutoSize = true;
            this.labelNoOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOrder.ForeColor = System.Drawing.Color.Transparent;
            this.labelNoOrder.Location = new System.Drawing.Point(29, 297);
            this.labelNoOrder.Name = "labelNoOrder";
            this.labelNoOrder.Size = new System.Drawing.Size(221, 21);
            this.labelNoOrder.TabIndex = 1;
            this.labelNoOrder.Text = "You don\'t have any orders yet";
            // 
            // pictureBoxNoOrder
            // 
            this.pictureBoxNoOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxNoOrder.Image = global::RestaurantSystem.Properties.Resources.BG;
            this.pictureBoxNoOrder.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNoOrder.Name = "pictureBoxNoOrder";
            this.pictureBoxNoOrder.Size = new System.Drawing.Size(284, 278);
            this.pictureBoxNoOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNoOrder.TabIndex = 0;
            this.pictureBoxNoOrder.TabStop = false;
            // 
            // panelTopCashier
            // 
            this.panelTopCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTopCashier.Controls.Add(this.label1);
            this.panelTopCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopCashier.Location = new System.Drawing.Point(0, 0);
            this.panelTopCashier.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.panelTopCashier.Name = "panelTopCashier";
            this.panelTopCashier.Size = new System.Drawing.Size(322, 104);
            this.panelTopCashier.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cashier Section";
            // 
            // panelBaseCategory
            // 
            this.panelBaseCategory.BackColor = System.Drawing.Color.White;
            this.panelBaseCategory.Controls.Add(this.buttonDrinks);
            this.panelBaseCategory.Controls.Add(this.buttonBakeryProducts);
            this.panelBaseCategory.Controls.Add(this.buttonPasta);
            this.panelBaseCategory.Controls.Add(this.buttonSalad);
            this.panelBaseCategory.Controls.Add(this.buttonSoup);
            this.panelBaseCategory.Controls.Add(this.buttonAll);
            this.panelBaseCategory.Location = new System.Drawing.Point(16, 134);
            this.panelBaseCategory.Name = "panelBaseCategory";
            this.panelBaseCategory.Size = new System.Drawing.Size(865, 77);
            this.panelBaseCategory.TabIndex = 7;
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonDrinks.FlatAppearance.BorderSize = 0;
            this.buttonDrinks.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrinks.Image = global::RestaurantSystem.Properties.Resources.drink1;
            this.buttonDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDrinks.Location = new System.Drawing.Point(731, 16);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(109, 49);
            this.buttonDrinks.TabIndex = 5;
            this.buttonDrinks.Text = " Drinks";
            this.buttonDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDrinks.UseVisualStyleBackColor = false;
            this.buttonDrinks.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBakeryProducts
            // 
            this.buttonBakeryProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonBakeryProducts.FlatAppearance.BorderSize = 0;
            this.buttonBakeryProducts.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBakeryProducts.Image = global::RestaurantSystem.Properties.Resources.bread;
            this.buttonBakeryProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBakeryProducts.Location = new System.Drawing.Point(525, 16);
            this.buttonBakeryProducts.Name = "buttonBakeryProducts";
            this.buttonBakeryProducts.Size = new System.Drawing.Size(186, 49);
            this.buttonBakeryProducts.TabIndex = 4;
            this.buttonBakeryProducts.Text = " Bakery Products";
            this.buttonBakeryProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBakeryProducts.UseVisualStyleBackColor = false;
            this.buttonBakeryProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPasta
            // 
            this.buttonPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPasta.FlatAppearance.BorderSize = 0;
            this.buttonPasta.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPasta.Image = global::RestaurantSystem.Properties.Resources.Pasta;
            this.buttonPasta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPasta.Location = new System.Drawing.Point(394, 16);
            this.buttonPasta.Name = "buttonPasta";
            this.buttonPasta.Size = new System.Drawing.Size(109, 49);
            this.buttonPasta.TabIndex = 3;
            this.buttonPasta.Text = "Pasta";
            this.buttonPasta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPasta.UseVisualStyleBackColor = false;
            this.buttonPasta.Click += new System.EventHandler(this.buttonPasta_Click);
            // 
            // buttonSalad
            // 
            this.buttonSalad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSalad.FlatAppearance.BorderSize = 0;
            this.buttonSalad.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalad.Image = global::RestaurantSystem.Properties.Resources.salads;
            this.buttonSalad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalad.Location = new System.Drawing.Point(264, 16);
            this.buttonSalad.Name = "buttonSalad";
            this.buttonSalad.Size = new System.Drawing.Size(109, 49);
            this.buttonSalad.TabIndex = 2;
            this.buttonSalad.Text = " Salads";
            this.buttonSalad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalad.UseVisualStyleBackColor = false;
            this.buttonSalad.Click += new System.EventHandler(this.buttonSalad_Click);
            // 
            // buttonSoup
            // 
            this.buttonSoup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSoup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSoup.FlatAppearance.BorderSize = 0;
            this.buttonSoup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSoup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSoup.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoup.Image = global::RestaurantSystem.Properties.Resources.Soup;
            this.buttonSoup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSoup.Location = new System.Drawing.Point(133, 16);
            this.buttonSoup.Name = "buttonSoup";
            this.buttonSoup.Size = new System.Drawing.Size(109, 49);
            this.buttonSoup.TabIndex = 1;
            this.buttonSoup.Text = " Soups";
            this.buttonSoup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSoup.UseVisualStyleBackColor = false;
            this.buttonSoup.Click += new System.EventHandler(this.buttonSoup_Click);
            // 
            // FoodAndDrinksModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.Panel_Cashier);
            this.Controls.Add(this.panelBaseCategoryBody);
            this.Controls.Add(this.panelBaseCategory);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FoodAndDrinksModel";
            this.Size = new System.Drawing.Size(1224, 899);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.Panel_Cashier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelBaseOrder.ResumeLayout(false);
            this.panelNoOrder.ResumeLayout(false);
            this.panelNoOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoOrder)).EndInit();
            this.panelTopCashier.ResumeLayout(false);
            this.panelTopCashier.PerformLayout();
            this.panelBaseCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelRestaurantLogo;
        public System.Windows.Forms.Panel panelBaseCategoryBody;
        public System.Windows.Forms.Button buttonAll;
        public System.Windows.Forms.Button buttonSoup;
        public System.Windows.Forms.Button buttonBakeryProducts;
        public System.Windows.Forms.Button buttonPasta;
        public System.Windows.Forms.Button buttonSalad;
        public System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label labelDiscountVal;
        private System.Windows.Forms.Label labelPercentSign;
        private System.Windows.Forms.TextBox TBDiscountValue;
        private System.Windows.Forms.Button BTNPaynow;
        private System.Windows.Forms.Label labelDiscountReduction;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Panel Panel_Cashier;
        private System.Windows.Forms.Panel panelBaseOrder;
        private System.Windows.Forms.Panel panelNoOrder;
        private System.Windows.Forms.Label labelNoOrder;
        private System.Windows.Forms.PictureBox pictureBoxNoOrder;
        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonTakeOut;
        private System.Windows.Forms.Button buttonDineIn;
        private System.Windows.Forms.Panel panelHr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalVal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelBaseCategory;
        private System.Windows.Forms.Panel panelTopCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelAdditionalFee;
    }
}
