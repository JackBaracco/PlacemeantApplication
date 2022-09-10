namespace GoToGrocery
{
    partial class FormAddData
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
            this.rMembersHeading = new System.Windows.Forms.RadioButton();
            this.rShopStockHeading = new System.Windows.Forms.RadioButton();
            this.rTransactionsHeading = new System.Windows.Forms.RadioButton();
            this.rPurchasedItemsHeading = new System.Windows.Forms.RadioButton();
            this.cShopItemName = new System.Windows.Forms.CheckBox();
            this.cShopBrand = new System.Windows.Forms.CheckBox();
            this.cShopCategory = new System.Windows.Forms.CheckBox();
            this.cShopQuantity = new System.Windows.Forms.CheckBox();
            this.cMemMemberFullName = new System.Windows.Forms.CheckBox();
            this.cMemStreetNumber = new System.Windows.Forms.CheckBox();
            this.cMemUnitNumber = new System.Windows.Forms.CheckBox();
            this.cMemStreetName = new System.Windows.Forms.CheckBox();
            this.cMemSuburb = new System.Windows.Forms.CheckBox();
            this.cMemPostcode = new System.Windows.Forms.CheckBox();
            this.cMemCity = new System.Windows.Forms.CheckBox();
            this.cMemPhoneNumber = new System.Windows.Forms.CheckBox();
            this.cTranMemberID = new System.Windows.Forms.CheckBox();
            this.cPurTransactionID = new System.Windows.Forms.CheckBox();
            this.cPurPrice = new System.Windows.Forms.CheckBox();
            this.cPurQuantity = new System.Windows.Forms.CheckBox();
            this.tShopItemName = new System.Windows.Forms.TextBox();
            this.tShopBrand = new System.Windows.Forms.TextBox();
            this.tShopCategory = new System.Windows.Forms.TextBox();
            this.tShopQuantity = new System.Windows.Forms.TextBox();
            this.tMemMemberFullName = new System.Windows.Forms.TextBox();
            this.tMemStreetNumber = new System.Windows.Forms.TextBox();
            this.tMemUnitNumber = new System.Windows.Forms.TextBox();
            this.tMemStreetName = new System.Windows.Forms.TextBox();
            this.tMemSuburb = new System.Windows.Forms.TextBox();
            this.tMemPostcode = new System.Windows.Forms.TextBox();
            this.tMemCity = new System.Windows.Forms.TextBox();
            this.tMemPhoneNumber = new System.Windows.Forms.TextBox();
            this.tTranMemberID = new System.Windows.Forms.TextBox();
            this.tPurTransactionID = new System.Windows.Forms.TextBox();
            this.tPurPrice = new System.Windows.Forms.TextBox();
            this.tPurQuantity = new System.Windows.Forms.TextBox();
            this.bSubmitSelect = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectOutputs = new System.Windows.Forms.DataGridView();
            this.bResetSelect = new System.Windows.Forms.Button();
            this.pHeadings = new System.Windows.Forms.Panel();
            this.cTranPurchaseDate = new System.Windows.Forms.CheckBox();
            this.tTranPurchaseDate = new System.Windows.Forms.TextBox();
            this.selectErrorMessage = new System.Windows.Forms.Label();
            this.cPurItemID = new System.Windows.Forms.CheckBox();
            this.tPurItemID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOutputs)).BeginInit();
            this.pHeadings.SuspendLayout();
            this.SuspendLayout();
            // 
            // rMembersHeading
            // 
            this.rMembersHeading.AutoSize = true;
            this.rMembersHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rMembersHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rMembersHeading.Location = new System.Drawing.Point(96, 0);
            this.rMembersHeading.Name = "rMembersHeading";
            this.rMembersHeading.Size = new System.Drawing.Size(181, 32);
            this.rMembersHeading.TabIndex = 0;
            this.rMembersHeading.Text = "Member Details";
            this.rMembersHeading.UseVisualStyleBackColor = false;
            this.rMembersHeading.CheckedChanged += new System.EventHandler(this.rMembersHeading_CheckedChanged);
            // 
            // rShopStockHeading
            // 
            this.rShopStockHeading.AutoSize = true;
            this.rShopStockHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rShopStockHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rShopStockHeading.Location = new System.Drawing.Point(443, 0);
            this.rShopStockHeading.Name = "rShopStockHeading";
            this.rShopStockHeading.Size = new System.Drawing.Size(135, 32);
            this.rShopStockHeading.TabIndex = 0;
            this.rShopStockHeading.Text = "Shop Stock";
            this.rShopStockHeading.UseVisualStyleBackColor = false;
            this.rShopStockHeading.CheckedChanged += new System.EventHandler(this.rShopStockHeading_CheckedChanged);
            // 
            // rTransactionsHeading
            // 
            this.rTransactionsHeading.AutoSize = true;
            this.rTransactionsHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rTransactionsHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rTransactionsHeading.Location = new System.Drawing.Point(789, 0);
            this.rTransactionsHeading.Name = "rTransactionsHeading";
            this.rTransactionsHeading.Size = new System.Drawing.Size(148, 32);
            this.rTransactionsHeading.TabIndex = 0;
            this.rTransactionsHeading.Text = "Transactions";
            this.rTransactionsHeading.UseVisualStyleBackColor = false;
            this.rTransactionsHeading.CheckedChanged += new System.EventHandler(this.rTransactionsHeading_CheckedChanged);
            // 
            // rPurchasedItemsHeading
            // 
            this.rPurchasedItemsHeading.AutoSize = true;
            this.rPurchasedItemsHeading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rPurchasedItemsHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rPurchasedItemsHeading.Location = new System.Drawing.Point(1137, 0);
            this.rPurchasedItemsHeading.Name = "rPurchasedItemsHeading";
            this.rPurchasedItemsHeading.Size = new System.Drawing.Size(185, 32);
            this.rPurchasedItemsHeading.TabIndex = 0;
            this.rPurchasedItemsHeading.Text = "Purchased Items";
            this.rPurchasedItemsHeading.UseVisualStyleBackColor = false;
            this.rPurchasedItemsHeading.CheckedChanged += new System.EventHandler(this.rPurchasedItemsHeading_CheckedChanged);
            // 
            // cShopItemName
            // 
            this.cShopItemName.AutoSize = true;
            this.cShopItemName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cShopItemName.Location = new System.Drawing.Point(564, 148);
            this.cShopItemName.Name = "cShopItemName";
            this.cShopItemName.Size = new System.Drawing.Size(85, 19);
            this.cShopItemName.TabIndex = 1;
            this.cShopItemName.Text = "Item Name";
            this.cShopItemName.UseVisualStyleBackColor = false;
            this.cShopItemName.CheckedChanged += new System.EventHandler(this.cShopItemName_CheckedChanged);
            // 
            // cShopBrand
            // 
            this.cShopBrand.AutoSize = true;
            this.cShopBrand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cShopBrand.Location = new System.Drawing.Point(564, 173);
            this.cShopBrand.Name = "cShopBrand";
            this.cShopBrand.Size = new System.Drawing.Size(57, 19);
            this.cShopBrand.TabIndex = 1;
            this.cShopBrand.Text = "Brand";
            this.cShopBrand.UseVisualStyleBackColor = false;
            this.cShopBrand.CheckedChanged += new System.EventHandler(this.cShopBrand_CheckedChanged);
            // 
            // cShopCategory
            // 
            this.cShopCategory.AutoSize = true;
            this.cShopCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cShopCategory.Location = new System.Drawing.Point(564, 198);
            this.cShopCategory.Name = "cShopCategory";
            this.cShopCategory.Size = new System.Drawing.Size(74, 19);
            this.cShopCategory.TabIndex = 1;
            this.cShopCategory.Text = "Category";
            this.cShopCategory.UseVisualStyleBackColor = false;
            this.cShopCategory.CheckedChanged += new System.EventHandler(this.cShopCategory_CheckedChanged);
            // 
            // cShopQuantity
            // 
            this.cShopQuantity.AutoSize = true;
            this.cShopQuantity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cShopQuantity.Location = new System.Drawing.Point(564, 223);
            this.cShopQuantity.Name = "cShopQuantity";
            this.cShopQuantity.Size = new System.Drawing.Size(72, 19);
            this.cShopQuantity.TabIndex = 1;
            this.cShopQuantity.Text = "Quantity";
            this.cShopQuantity.UseVisualStyleBackColor = false;
            this.cShopQuantity.CheckedChanged += new System.EventHandler(this.cShopQuantity_CheckedChanged);
            // 
            // cMemMemberFullName
            // 
            this.cMemMemberFullName.AutoSize = true;
            this.cMemMemberFullName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemMemberFullName.Location = new System.Drawing.Point(217, 146);
            this.cMemMemberFullName.Name = "cMemMemberFullName";
            this.cMemMemberFullName.Size = new System.Drawing.Size(106, 19);
            this.cMemMemberFullName.TabIndex = 1;
            this.cMemMemberFullName.Text = "Member Name";
            this.cMemMemberFullName.UseVisualStyleBackColor = false;
            this.cMemMemberFullName.CheckedChanged += new System.EventHandler(this.cMemMemberFullName_CheckedChanged);
            // 
            // cMemStreetNumber
            // 
            this.cMemStreetNumber.AutoSize = true;
            this.cMemStreetNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemStreetNumber.Location = new System.Drawing.Point(217, 171);
            this.cMemStreetNumber.Name = "cMemStreetNumber";
            this.cMemStreetNumber.Size = new System.Drawing.Size(103, 19);
            this.cMemStreetNumber.TabIndex = 1;
            this.cMemStreetNumber.Text = "Street Number";
            this.cMemStreetNumber.UseVisualStyleBackColor = false;
            this.cMemStreetNumber.CheckedChanged += new System.EventHandler(this.cMemStreetNumber_CheckedChanged);
            // 
            // cMemUnitNumber
            // 
            this.cMemUnitNumber.AutoSize = true;
            this.cMemUnitNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemUnitNumber.Location = new System.Drawing.Point(217, 196);
            this.cMemUnitNumber.Name = "cMemUnitNumber";
            this.cMemUnitNumber.Size = new System.Drawing.Size(95, 19);
            this.cMemUnitNumber.TabIndex = 1;
            this.cMemUnitNumber.Text = "Unit Number";
            this.cMemUnitNumber.UseVisualStyleBackColor = false;
            this.cMemUnitNumber.CheckedChanged += new System.EventHandler(this.cMemUnitNumber_CheckedChanged);
            // 
            // cMemStreetName
            // 
            this.cMemStreetName.AutoSize = true;
            this.cMemStreetName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemStreetName.Location = new System.Drawing.Point(217, 221);
            this.cMemStreetName.Name = "cMemStreetName";
            this.cMemStreetName.Size = new System.Drawing.Size(91, 19);
            this.cMemStreetName.TabIndex = 1;
            this.cMemStreetName.Text = "Street Name";
            this.cMemStreetName.UseVisualStyleBackColor = false;
            this.cMemStreetName.CheckedChanged += new System.EventHandler(this.cMemStreetName_CheckedChanged);
            // 
            // cMemSuburb
            // 
            this.cMemSuburb.AutoSize = true;
            this.cMemSuburb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemSuburb.Location = new System.Drawing.Point(217, 246);
            this.cMemSuburb.Name = "cMemSuburb";
            this.cMemSuburb.Size = new System.Drawing.Size(64, 19);
            this.cMemSuburb.TabIndex = 1;
            this.cMemSuburb.Text = "Suburb";
            this.cMemSuburb.UseVisualStyleBackColor = false;
            this.cMemSuburb.CheckedChanged += new System.EventHandler(this.cMemSuburb_CheckedChanged);
            // 
            // cMemPostcode
            // 
            this.cMemPostcode.AutoSize = true;
            this.cMemPostcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemPostcode.Location = new System.Drawing.Point(217, 271);
            this.cMemPostcode.Name = "cMemPostcode";
            this.cMemPostcode.Size = new System.Drawing.Size(75, 19);
            this.cMemPostcode.TabIndex = 1;
            this.cMemPostcode.Text = "Postcode";
            this.cMemPostcode.UseVisualStyleBackColor = false;
            this.cMemPostcode.CheckedChanged += new System.EventHandler(this.cMemPostcode_CheckedChanged);
            // 
            // cMemCity
            // 
            this.cMemCity.AutoSize = true;
            this.cMemCity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemCity.Location = new System.Drawing.Point(217, 296);
            this.cMemCity.Name = "cMemCity";
            this.cMemCity.Size = new System.Drawing.Size(47, 19);
            this.cMemCity.TabIndex = 1;
            this.cMemCity.Text = "City";
            this.cMemCity.UseVisualStyleBackColor = false;
            this.cMemCity.CheckedChanged += new System.EventHandler(this.cMemCity_CheckedChanged);
            // 
            // cMemPhoneNumber
            // 
            this.cMemPhoneNumber.AutoSize = true;
            this.cMemPhoneNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cMemPhoneNumber.Location = new System.Drawing.Point(217, 321);
            this.cMemPhoneNumber.Name = "cMemPhoneNumber";
            this.cMemPhoneNumber.Size = new System.Drawing.Size(105, 19);
            this.cMemPhoneNumber.TabIndex = 1;
            this.cMemPhoneNumber.Text = "Phone number";
            this.cMemPhoneNumber.UseVisualStyleBackColor = false;
            this.cMemPhoneNumber.CheckedChanged += new System.EventHandler(this.cMemPhoneNumber_CheckedChanged);
            // 
            // cTranMemberID
            // 
            this.cTranMemberID.AutoSize = true;
            this.cTranMemberID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cTranMemberID.Location = new System.Drawing.Point(910, 146);
            this.cTranMemberID.Name = "cTranMemberID";
            this.cTranMemberID.Size = new System.Drawing.Size(85, 19);
            this.cTranMemberID.TabIndex = 1;
            this.cTranMemberID.Text = "Member ID";
            this.cTranMemberID.UseVisualStyleBackColor = false;
            this.cTranMemberID.CheckedChanged += new System.EventHandler(this.cTranMemberID_CheckedChanged);
            // 
            // cPurTransactionID
            // 
            this.cPurTransactionID.AutoSize = true;
            this.cPurTransactionID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cPurTransactionID.Location = new System.Drawing.Point(1258, 148);
            this.cPurTransactionID.Name = "cPurTransactionID";
            this.cPurTransactionID.Size = new System.Drawing.Size(100, 19);
            this.cPurTransactionID.TabIndex = 1;
            this.cPurTransactionID.Text = "Transaction ID";
            this.cPurTransactionID.UseVisualStyleBackColor = false;
            this.cPurTransactionID.CheckedChanged += new System.EventHandler(this.cPurTransactionID_CheckedChanged);
            // 
            // cPurPrice
            // 
            this.cPurPrice.AutoSize = true;
            this.cPurPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cPurPrice.Location = new System.Drawing.Point(1258, 198);
            this.cPurPrice.Name = "cPurPrice";
            this.cPurPrice.Size = new System.Drawing.Size(52, 19);
            this.cPurPrice.TabIndex = 1;
            this.cPurPrice.Text = "Price";
            this.cPurPrice.UseVisualStyleBackColor = false;
            this.cPurPrice.CheckedChanged += new System.EventHandler(this.cPurPrice_CheckedChanged);
            // 
            // cPurQuantity
            // 
            this.cPurQuantity.AutoSize = true;
            this.cPurQuantity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cPurQuantity.Location = new System.Drawing.Point(1258, 223);
            this.cPurQuantity.Name = "cPurQuantity";
            this.cPurQuantity.Size = new System.Drawing.Size(72, 19);
            this.cPurQuantity.TabIndex = 1;
            this.cPurQuantity.Text = "Quantity";
            this.cPurQuantity.UseVisualStyleBackColor = false;
            this.cPurQuantity.CheckedChanged += new System.EventHandler(this.cPurQuantity_CheckedChanged);
            // 
            // tShopItemName
            // 
            this.tShopItemName.Location = new System.Drawing.Point(662, 146);
            this.tShopItemName.Name = "tShopItemName";
            this.tShopItemName.Size = new System.Drawing.Size(100, 23);
            this.tShopItemName.TabIndex = 2;
            // 
            // tShopBrand
            // 
            this.tShopBrand.Location = new System.Drawing.Point(662, 171);
            this.tShopBrand.Name = "tShopBrand";
            this.tShopBrand.Size = new System.Drawing.Size(100, 23);
            this.tShopBrand.TabIndex = 2;
            // 
            // tShopCategory
            // 
            this.tShopCategory.Location = new System.Drawing.Point(662, 196);
            this.tShopCategory.Name = "tShopCategory";
            this.tShopCategory.Size = new System.Drawing.Size(100, 23);
            this.tShopCategory.TabIndex = 2;
            // 
            // tShopQuantity
            // 
            this.tShopQuantity.Location = new System.Drawing.Point(662, 221);
            this.tShopQuantity.Name = "tShopQuantity";
            this.tShopQuantity.Size = new System.Drawing.Size(100, 23);
            this.tShopQuantity.TabIndex = 2;
            // 
            // tMemMemberFullName
            // 
            this.tMemMemberFullName.Location = new System.Drawing.Point(322, 142);
            this.tMemMemberFullName.Name = "tMemMemberFullName";
            this.tMemMemberFullName.Size = new System.Drawing.Size(100, 23);
            this.tMemMemberFullName.TabIndex = 2;
            // 
            // tMemStreetNumber
            // 
            this.tMemStreetNumber.Location = new System.Drawing.Point(322, 167);
            this.tMemStreetNumber.Name = "tMemStreetNumber";
            this.tMemStreetNumber.Size = new System.Drawing.Size(100, 23);
            this.tMemStreetNumber.TabIndex = 2;
            // 
            // tMemUnitNumber
            // 
            this.tMemUnitNumber.Location = new System.Drawing.Point(322, 192);
            this.tMemUnitNumber.Name = "tMemUnitNumber";
            this.tMemUnitNumber.Size = new System.Drawing.Size(100, 23);
            this.tMemUnitNumber.TabIndex = 2;
            // 
            // tMemStreetName
            // 
            this.tMemStreetName.Location = new System.Drawing.Point(322, 217);
            this.tMemStreetName.Name = "tMemStreetName";
            this.tMemStreetName.Size = new System.Drawing.Size(100, 23);
            this.tMemStreetName.TabIndex = 2;
            // 
            // tMemSuburb
            // 
            this.tMemSuburb.Location = new System.Drawing.Point(322, 242);
            this.tMemSuburb.Name = "tMemSuburb";
            this.tMemSuburb.Size = new System.Drawing.Size(100, 23);
            this.tMemSuburb.TabIndex = 2;
            // 
            // tMemPostcode
            // 
            this.tMemPostcode.Location = new System.Drawing.Point(322, 267);
            this.tMemPostcode.Name = "tMemPostcode";
            this.tMemPostcode.Size = new System.Drawing.Size(100, 23);
            this.tMemPostcode.TabIndex = 2;
            // 
            // tMemCity
            // 
            this.tMemCity.Location = new System.Drawing.Point(322, 292);
            this.tMemCity.Name = "tMemCity";
            this.tMemCity.Size = new System.Drawing.Size(100, 23);
            this.tMemCity.TabIndex = 2;
            // 
            // tMemPhoneNumber
            // 
            this.tMemPhoneNumber.Location = new System.Drawing.Point(322, 317);
            this.tMemPhoneNumber.Name = "tMemPhoneNumber";
            this.tMemPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.tMemPhoneNumber.TabIndex = 2;
            // 
            // tTranMemberID
            // 
            this.tTranMemberID.Location = new System.Drawing.Point(1015, 144);
            this.tTranMemberID.Name = "tTranMemberID";
            this.tTranMemberID.Size = new System.Drawing.Size(100, 23);
            this.tTranMemberID.TabIndex = 2;
            // 
            // tPurTransactionID
            // 
            this.tPurTransactionID.Location = new System.Drawing.Point(1363, 146);
            this.tPurTransactionID.Name = "tPurTransactionID";
            this.tPurTransactionID.Size = new System.Drawing.Size(92, 23);
            this.tPurTransactionID.TabIndex = 2;
            // 
            // tPurPrice
            // 
            this.tPurPrice.Location = new System.Drawing.Point(1363, 196);
            this.tPurPrice.Name = "tPurPrice";
            this.tPurPrice.Size = new System.Drawing.Size(92, 23);
            this.tPurPrice.TabIndex = 2;
            // 
            // tPurQuantity
            // 
            this.tPurQuantity.Location = new System.Drawing.Point(1363, 221);
            this.tPurQuantity.Name = "tPurQuantity";
            this.tPurQuantity.Size = new System.Drawing.Size(92, 23);
            this.tPurQuantity.TabIndex = 2;
            // 
            // bSubmitSelect
            // 
            this.bSubmitSelect.Location = new System.Drawing.Point(753, 323);
            this.bSubmitSelect.Name = "bSubmitSelect";
            this.bSubmitSelect.Size = new System.Drawing.Size(171, 50);
            this.bSubmitSelect.TabIndex = 3;
            this.bSubmitSelect.Text = "SUBMIT";
            this.bSubmitSelect.UseVisualStyleBackColor = true;
            this.bSubmitSelect.Click += new System.EventHandler(this.bSubmitSelect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(98, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1484, 345);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bGoBack
            // 
            this.bGoBack.Location = new System.Drawing.Point(21, 12);
            this.bGoBack.Name = "bGoBack";
            this.bGoBack.Size = new System.Drawing.Size(75, 23);
            this.bGoBack.TabIndex = 6;
            this.bGoBack.Text = "Go back";
            this.bGoBack.UseVisualStyleBackColor = true;
            this.bGoBack.Click += new System.EventHandler(this.bGoBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(753, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Data";
            // 
            // selectOutputs
            // 
            this.selectOutputs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.selectOutputs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectOutputs.Location = new System.Drawing.Point(98, 452);
            this.selectOutputs.Name = "selectOutputs";
            this.selectOutputs.RowTemplate.Height = 25;
            this.selectOutputs.Size = new System.Drawing.Size(1484, 531);
            this.selectOutputs.TabIndex = 8;
            // 
            // bResetSelect
            // 
            this.bResetSelect.Location = new System.Drawing.Point(1483, 370);
            this.bResetSelect.Name = "bResetSelect";
            this.bResetSelect.Size = new System.Drawing.Size(75, 23);
            this.bResetSelect.TabIndex = 6;
            this.bResetSelect.Text = "RESET";
            this.bResetSelect.UseVisualStyleBackColor = true;
            this.bResetSelect.Click += new System.EventHandler(this.bResetSelect_Click);
            // 
            // pHeadings
            // 
            this.pHeadings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pHeadings.Controls.Add(this.rShopStockHeading);
            this.pHeadings.Controls.Add(this.rMembersHeading);
            this.pHeadings.Controls.Add(this.rTransactionsHeading);
            this.pHeadings.Controls.Add(this.rPurchasedItemsHeading);
            this.pHeadings.Location = new System.Drawing.Point(121, 87);
            this.pHeadings.Name = "pHeadings";
            this.pHeadings.Size = new System.Drawing.Size(1426, 32);
            this.pHeadings.TabIndex = 10;
            // 
            // cTranPurchaseDate
            // 
            this.cTranPurchaseDate.AutoSize = true;
            this.cTranPurchaseDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cTranPurchaseDate.Location = new System.Drawing.Point(910, 171);
            this.cTranPurchaseDate.Name = "cTranPurchaseDate";
            this.cTranPurchaseDate.Size = new System.Drawing.Size(101, 19);
            this.cTranPurchaseDate.TabIndex = 1;
            this.cTranPurchaseDate.Text = "Purchase Date";
            this.cTranPurchaseDate.UseVisualStyleBackColor = false;
            this.cTranPurchaseDate.CheckedChanged += new System.EventHandler(this.cTranPurchaseDate_CheckedChanged);
            // 
            // tTranPurchaseDate
            // 
            this.tTranPurchaseDate.Location = new System.Drawing.Point(1015, 169);
            this.tTranPurchaseDate.Name = "tTranPurchaseDate";
            this.tTranPurchaseDate.Size = new System.Drawing.Size(100, 23);
            this.tTranPurchaseDate.TabIndex = 2;
            // 
            // selectErrorMessage
            // 
            this.selectErrorMessage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectErrorMessage.Location = new System.Drawing.Point(98, 409);
            this.selectErrorMessage.Name = "selectErrorMessage";
            this.selectErrorMessage.Size = new System.Drawing.Size(1484, 40);
            this.selectErrorMessage.TabIndex = 13;
            this.selectErrorMessage.Text = " ";
            this.selectErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cPurItemID
            // 
            this.cPurItemID.AutoSize = true;
            this.cPurItemID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cPurItemID.Location = new System.Drawing.Point(1258, 173);
            this.cPurItemID.Name = "cPurItemID";
            this.cPurItemID.Size = new System.Drawing.Size(64, 19);
            this.cPurItemID.TabIndex = 1;
            this.cPurItemID.Text = "Item ID";
            this.cPurItemID.UseVisualStyleBackColor = false;
            this.cPurItemID.CheckedChanged += new System.EventHandler(this.cPurMemberID_CheckedChanged);
            // 
            // tPurItemID
            // 
            this.tPurItemID.Location = new System.Drawing.Point(1363, 171);
            this.tPurItemID.Name = "tPurItemID";
            this.tPurItemID.Size = new System.Drawing.Size(92, 23);
            this.tPurItemID.TabIndex = 2;
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1041);
            this.Controls.Add(this.selectErrorMessage);
            this.Controls.Add(this.pHeadings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bResetSelect);
            this.Controls.Add(this.bGoBack);
            this.Controls.Add(this.bSubmitSelect);
            this.Controls.Add(this.tMemStreetName);
            this.Controls.Add(this.tShopQuantity);
            this.Controls.Add(this.tPurItemID);
            this.Controls.Add(this.tPurQuantity);
            this.Controls.Add(this.tPurPrice);
            this.Controls.Add(this.tTranPurchaseDate);
            this.Controls.Add(this.tMemPhoneNumber);
            this.Controls.Add(this.tMemUnitNumber);
            this.Controls.Add(this.tShopCategory);
            this.Controls.Add(this.tTranMemberID);
            this.Controls.Add(this.tMemCity);
            this.Controls.Add(this.tMemStreetNumber);
            this.Controls.Add(this.tShopBrand);
            this.Controls.Add(this.tPurTransactionID);
            this.Controls.Add(this.tMemPostcode);
            this.Controls.Add(this.tMemMemberFullName);
            this.Controls.Add(this.tShopItemName);
            this.Controls.Add(this.tMemSuburb);
            this.Controls.Add(this.cTranMemberID);
            this.Controls.Add(this.cMemMemberFullName);
            this.Controls.Add(this.cPurItemID);
            this.Controls.Add(this.cPurQuantity);
            this.Controls.Add(this.cMemPhoneNumber);
            this.Controls.Add(this.cMemPostcode);
            this.Controls.Add(this.cShopQuantity);
            this.Controls.Add(this.cPurPrice);
            this.Controls.Add(this.cMemCity);
            this.Controls.Add(this.cPurTransactionID);
            this.Controls.Add(this.cMemSuburb);
            this.Controls.Add(this.cShopCategory);
            this.Controls.Add(this.cMemStreetName);
            this.Controls.Add(this.cShopBrand);
            this.Controls.Add(this.cMemUnitNumber);
            this.Controls.Add(this.cTranPurchaseDate);
            this.Controls.Add(this.cShopItemName);
            this.Controls.Add(this.cMemStreetNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectOutputs);
            this.MaximizeBox = false;
            this.Name = "FormAddData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOutputs)).EndInit();
            this.pHeadings.ResumeLayout(false);
            this.pHeadings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rMembersHeading;
        private RadioButton rShopStockHeading;
        private RadioButton rTransactionsHeading;
        private RadioButton rPurchasedItemsHeading;
        private CheckBox cShopItemName;
        private CheckBox cShopBrand;
        private CheckBox cShopCategory;
        private CheckBox cShopQuantity;
        private CheckBox cMemMemberFullName;
        private CheckBox cMemStreetNumber;
        private CheckBox cMemUnitNumber;
        private CheckBox cMemStreetName;
        private CheckBox cMemSuburb;
        private CheckBox cMemPostcode;
        private CheckBox cMemCity;
        private CheckBox cMemPhoneNumber;
        private CheckBox cTranMemberID;
        private CheckBox cPurTransactionID;
        private CheckBox cPurPrice;
        private CheckBox cPurQuantity;
        private TextBox tShopItemName;
        private TextBox tShopBrand;
        private TextBox tShopCategory;
        private TextBox tShopQuantity;
        private TextBox tMemMemberFullName;
        private TextBox tMemStreetNumber;
        private TextBox tMemUnitNumber;
        private TextBox tMemStreetName;
        private TextBox tMemSuburb;
        private TextBox tMemPostcode;
        private TextBox tMemCity;
        private TextBox tMemPhoneNumber;
        private TextBox tTranMemberID;
        private TextBox tPurTransactionID;
        private TextBox tPurPrice;
        private TextBox tPurQuantity;
        private Button bSubmitSelect;
        private ColorDialog colorDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ColorDialog colorDialog2;
        private PictureBox pictureBox1;
        private Button bGoBack;
        private Label label1;
        private DataGridView selectOutputs;
        private Button bResetSelect;
        private Panel pHeadings;
        private CheckBox cTranPurchaseDate;
        private TextBox tTranPurchaseDate;
        private Label selectErrorMessage;
        private CheckBox cPurItemID;
        private TextBox tPurItemID;
    }
}