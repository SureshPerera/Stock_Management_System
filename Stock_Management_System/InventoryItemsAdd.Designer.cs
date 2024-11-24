namespace Stock_Management_System
{
    partial class InventoryItemsAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInvoNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnImgAddSuppliers = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtTotalPriceWithTax = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSetTax = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnaddnewItem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.supplierDetailsTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSet1TableAdapters.supplierDetailsTableAdapter();
            this.dgvPurchaseList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.Item_Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.supplierDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet1 = new Stock_Management_System.Inventry_Management_SystemDataSet1();
            this.txtExpireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPurchaceDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboBoxVender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGetTax = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoNumber
            // 
            this.txtInvoNumber.AutoRoundedCorners = true;
            this.txtInvoNumber.BorderRadius = 16;
            this.txtInvoNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvoNumber.DefaultText = "";
            this.txtInvoNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInvoNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInvoNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInvoNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInvoNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInvoNumber.Location = new System.Drawing.Point(1333, 157);
            this.txtInvoNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvoNumber.Name = "txtInvoNumber";
            this.txtInvoNumber.PasswordChar = '\0';
            this.txtInvoNumber.PlaceholderText = "123";
            this.txtInvoNumber.SelectedText = "";
            this.txtInvoNumber.Size = new System.Drawing.Size(200, 35);
            this.txtInvoNumber.TabIndex = 50;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefresh.HoverState.Image = global::Stock_Management_System.Properties.Resources.Sync;
            this.btnRefresh.HoverState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnRefresh.Image = global::Stock_Management_System.Properties.Resources.Sync;
            this.btnRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefresh.ImageRotate = 0F;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(1471, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.Image = global::Stock_Management_System.Properties.Resources.Sync;
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnRefresh.Size = new System.Drawing.Size(44, 39);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnImgAddSuppliers
            // 
            this.btnImgAddSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnImgAddSuppliers.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImgAddSuppliers.HoverState.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnImgAddSuppliers.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnImgAddSuppliers.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnImgAddSuppliers.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnImgAddSuppliers.ImageRotate = 0F;
            this.btnImgAddSuppliers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnImgAddSuppliers.Location = new System.Drawing.Point(91, 68);
            this.btnImgAddSuppliers.Name = "btnImgAddSuppliers";
            this.btnImgAddSuppliers.PressedState.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnImgAddSuppliers.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnImgAddSuppliers.Size = new System.Drawing.Size(64, 51);
            this.btnImgAddSuppliers.TabIndex = 49;
            this.btnImgAddSuppliers.UseTransparentBackground = true;
            this.btnImgAddSuppliers.Click += new System.EventHandler(this.btnImgAddSuppliers_Click);
            // 
            // txtTotalPriceWithTax
            // 
            this.txtTotalPriceWithTax.AutoSize = false;
            this.txtTotalPriceWithTax.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPriceWithTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceWithTax.Location = new System.Drawing.Point(1445, 770);
            this.txtTotalPriceWithTax.Name = "txtTotalPriceWithTax";
            this.txtTotalPriceWithTax.Size = new System.Drawing.Size(170, 38);
            this.txtTotalPriceWithTax.TabIndex = 46;
            this.txtTotalPriceWithTax.Text = "****";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(1198, 770);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(174, 38);
            this.guna2HtmlLabel8.TabIndex = 36;
            this.guna2HtmlLabel8.Text = "Total Price with tax";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = false;
            this.txtTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(1445, 697);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(162, 38);
            this.txtTotalPrice.TabIndex = 45;
            this.txtTotalPrice.Text = "****";
            // 
            // txtSetTax
            // 
            this.txtSetTax.AutoSize = false;
            this.txtSetTax.BackColor = System.Drawing.Color.Transparent;
            this.txtSetTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetTax.Location = new System.Drawing.Point(1445, 732);
            this.txtSetTax.Name = "txtSetTax";
            this.txtSetTax.Size = new System.Drawing.Size(162, 38);
            this.txtSetTax.TabIndex = 44;
            this.txtSetTax.Text = "****";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(1199, 732);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(111, 38);
            this.guna2HtmlLabel7.TabIndex = 43;
            this.guna2HtmlLabel7.Text = "Tax/Vat";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.AutoSize = false;
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(1158, 698);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(31, 31);
            this.guna2HtmlLabel13.TabIndex = 42;
            this.guna2HtmlLabel13.Text = "%";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.AutoSize = false;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(1004, 698);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(43, 18);
            this.guna2HtmlLabel12.TabIndex = 41;
            this.guna2HtmlLabel12.Text = "Tax";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.AutoSize = false;
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(1378, 770);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(37, 38);
            this.guna2HtmlLabel11.TabIndex = 40;
            this.guna2HtmlLabel11.Text = "Rs :";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(1378, 732);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(37, 38);
            this.guna2HtmlLabel10.TabIndex = 39;
            this.guna2HtmlLabel10.Text = "Rs :";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(1378, 692);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(37, 38);
            this.guna2HtmlLabel9.TabIndex = 38;
            this.guna2HtmlLabel9.Text = "Rs :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(1198, 692);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(129, 38);
            this.guna2HtmlLabel6.TabIndex = 37;
            this.guna2HtmlLabel6.Text = "Sub Total";
            // 
            // btnaddnewItem
            // 
            this.btnaddnewItem.BackColor = System.Drawing.Color.Transparent;
            this.btnaddnewItem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnaddnewItem.HoverState.Image = global::Stock_Management_System.Properties.Resources.Add_Databases;
            this.btnaddnewItem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnaddnewItem.Image = global::Stock_Management_System.Properties.Resources.Add_Databases;
            this.btnaddnewItem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnaddnewItem.ImageRotate = 0F;
            this.btnaddnewItem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnaddnewItem.Location = new System.Drawing.Point(26, 68);
            this.btnaddnewItem.Name = "btnaddnewItem";
            this.btnaddnewItem.PressedState.Image = global::Stock_Management_System.Properties.Resources.Add_Databases;
            this.btnaddnewItem.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnaddnewItem.Size = new System.Drawing.Size(62, 49);
            this.btnaddnewItem.TabIndex = 35;
            this.btnaddnewItem.UseTransparentBackground = true;
            this.btnaddnewItem.Click += new System.EventHandler(this.btnaddnewItem_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 15;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.MediumBlue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(9, 9);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 35);
            this.guna2ControlBox1.TabIndex = 34;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // supplierDetailsTableAdapter
            // 
            this.supplierDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPurchaseList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseList.ColumnHeadersHeight = 45;
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_Id,
            this.Product_name,
            this.Item_Discription,
            this.product_Qty,
            this.Item_Cost,
            this.total_price});
            this.dgvPurchaseList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPurchaseList.GridColor = System.Drawing.Color.Silver;
            this.dgvPurchaseList.Location = new System.Drawing.Point(34, 252);
            this.dgvPurchaseList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseList.RowHeadersVisible = false;
            this.dgvPurchaseList.RowHeadersWidth = 45;
            this.dgvPurchaseList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.RowTemplate.Height = 35;
            this.dgvPurchaseList.Size = new System.Drawing.Size(1499, 392);
            this.dgvPurchaseList.TabIndex = 19;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPurchaseList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvPurchaseList.ThemeStyle.ReadOnly = false;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Height = 35;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPurchaseList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseList_CellEndEdit);
            this.dgvPurchaseList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseList_CellValueChanged);
            // 
            // product_Id
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.product_Id.HeaderText = "product_Id";
            this.product_Id.MinimumWidth = 6;
            this.product_Id.Name = "product_Id";
            this.product_Id.Visible = false;
            // 
            // Product_name
            // 
            this.Product_name.DataPropertyName = "product_name";
            this.Product_name.DataSource = this.itemBindingSource;
            this.Product_name.DisplayMember = "Item_Name";
            this.Product_name.HeaderText = "Product_name";
            this.Product_name.MinimumWidth = 6;
            this.Product_name.Name = "Product_name";
            this.Product_name.ValueMember = "Item_Name";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.inventry_Management_SystemDataSet;
            // 
            // inventry_Management_SystemDataSet
            // 
            this.inventry_Management_SystemDataSet.DataSetName = "Inventry_Management_SystemDataSet";
            this.inventry_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Item_Discription
            // 
            this.Item_Discription.DataPropertyName = "Item_Discription";
            this.Item_Discription.HeaderText = "Product_Discriptions";
            this.Item_Discription.MinimumWidth = 6;
            this.Item_Discription.Name = "Item_Discription";
            // 
            // product_Qty
            // 
            this.product_Qty.HeaderText = "Product_Qty";
            this.product_Qty.MinimumWidth = 6;
            this.product_Qty.Name = "product_Qty";
            // 
            // Item_Cost
            // 
            this.Item_Cost.DataPropertyName = "Item_Cost";
            this.Item_Cost.HeaderText = "Unit_Price";
            this.Item_Cost.MinimumWidth = 6;
            this.Item_Cost.Name = "Item_Cost";
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total_price";
            this.total_price.MinimumWidth = 6;
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.AutoSize = false;
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(91, 116);
            this.guna2HtmlLabel15.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(62, 37);
            this.guna2HtmlLabel15.TabIndex = 29;
            this.guna2HtmlLabel15.Text = "New Supplier";
            this.guna2HtmlLabel15.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // supplierDetailsBindingSource
            // 
            this.supplierDetailsBindingSource.DataMember = "supplierDetails";
            this.supplierDetailsBindingSource.DataSource = this.inventry_Management_SystemDataSet1;
            // 
            // inventry_Management_SystemDataSet1
            // 
            this.inventry_Management_SystemDataSet1.DataSetName = "Inventry_Management_SystemDataSet1";
            this.inventry_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtExpireDate
            // 
            this.txtExpireDate.AutoRoundedCorners = true;
            this.txtExpireDate.BackColor = System.Drawing.Color.Transparent;
            this.txtExpireDate.BorderRadius = 17;
            this.txtExpireDate.Checked = true;
            this.txtExpireDate.CustomFormat = "dd/mm/yyyy";
            this.txtExpireDate.FocusedColor = System.Drawing.Color.Transparent;
            this.txtExpireDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpireDate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtExpireDate.Location = new System.Drawing.Point(1333, 108);
            this.txtExpireDate.Margin = new System.Windows.Forms.Padding(0);
            this.txtExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.Size = new System.Drawing.Size(200, 36);
            this.txtExpireDate.TabIndex = 30;
            this.txtExpireDate.UseTransparentBackground = true;
            this.txtExpireDate.Value = new System.DateTime(2024, 9, 9, 1, 8, 53, 804);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(528, 12);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(541, 55);
            this.guna2HtmlLabel4.TabIndex = 26;
            this.guna2HtmlLabel4.Text = "CREATE NEW INVENTORY";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(32, 115);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(50, 37);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.Text = "New \r\nItem";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1173, 117);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(151, 22);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Expire_date";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1173, 158);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(126, 22);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Invoice No";
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1167, 850);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1353, 850);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Create";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.AutoSize = false;
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(1173, 68);
            this.guna2HtmlLabel17.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(151, 22);
            this.guna2HtmlLabel17.TabIndex = 23;
            this.guna2HtmlLabel17.Text = "Purchase_date";
            // 
            // txtPurchaceDate
            // 
            this.txtPurchaceDate.AutoRoundedCorners = true;
            this.txtPurchaceDate.BackColor = System.Drawing.Color.Transparent;
            this.txtPurchaceDate.BorderRadius = 17;
            this.txtPurchaceDate.Checked = true;
            this.txtPurchaceDate.CustomFormat = "dd/mm/yyyy";
            this.txtPurchaceDate.FocusedColor = System.Drawing.Color.Transparent;
            this.txtPurchaceDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPurchaceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPurchaceDate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPurchaceDate.Location = new System.Drawing.Point(1333, 59);
            this.txtPurchaceDate.Margin = new System.Windows.Forms.Padding(0);
            this.txtPurchaceDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtPurchaceDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtPurchaceDate.Name = "txtPurchaceDate";
            this.txtPurchaceDate.Size = new System.Drawing.Size(200, 36);
            this.txtPurchaceDate.TabIndex = 30;
            this.txtPurchaceDate.UseTransparentBackground = true;
            this.txtPurchaceDate.Value = new System.DateTime(2024, 9, 9, 1, 8, 53, 804);
            // 
            // comboBoxVender
            // 
            this.comboBoxVender.AutoRoundedCorners = true;
            this.comboBoxVender.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxVender.BorderRadius = 17;
            this.comboBoxVender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxVender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxVender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxVender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxVender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxVender.ItemHeight = 30;
            this.comboBoxVender.Location = new System.Drawing.Point(930, 70);
            this.comboBoxVender.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxVender.Name = "comboBoxVender";
            this.comboBoxVender.Size = new System.Drawing.Size(200, 36);
            this.comboBoxVender.TabIndex = 32;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.AutoSize = false;
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(838, 78);
            this.guna2HtmlLabel14.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(92, 22);
            this.guna2HtmlLabel14.TabIndex = 28;
            this.guna2HtmlLabel14.Text = "Vender";
            // 
            // txtGetTax
            // 
            this.txtGetTax.AutoRoundedCorners = true;
            this.txtGetTax.BorderRadius = 16;
            this.txtGetTax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGetTax.DefaultText = "";
            this.txtGetTax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGetTax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGetTax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGetTax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGetTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGetTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGetTax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGetTax.Location = new System.Drawing.Point(1067, 694);
            this.txtGetTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGetTax.Name = "txtGetTax";
            this.txtGetTax.PasswordChar = '\0';
            this.txtGetTax.PlaceholderText = "123";
            this.txtGetTax.SelectedText = "";
            this.txtGetTax.Size = new System.Drawing.Size(85, 35);
            this.txtGetTax.TabIndex = 50;
            // 
            // InventoryItemsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 945);
            this.Controls.Add(this.txtGetTax);
            this.Controls.Add(this.txtInvoNumber);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnImgAddSuppliers);
            this.Controls.Add(this.txtTotalPriceWithTax);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtSetTax);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.btnaddnewItem);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.dgvPurchaseList);
            this.Controls.Add(this.guna2HtmlLabel15);
            this.Controls.Add(this.comboBoxVender);
            this.Controls.Add(this.guna2HtmlLabel14);
            this.Controls.Add(this.txtPurchaceDate);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel17);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 130);
            this.Name = "InventoryItemsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "InventoryItemsAdd";
            this.Load += new System.EventHandler(this.InventoryItemsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtInvoNumber;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefresh;
        private Guna.UI2.WinForms.Guna2ImageButton btnImgAddSuppliers;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTotalPriceWithTax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtSetTax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ImageButton btnaddnewItem;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Inventry_Management_SystemDataSet1TableAdapters.supplierDetailsTableAdapter supplierDetailsTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product_name;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Inventry_Management_SystemDataSet inventry_Management_SystemDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private System.Windows.Forms.BindingSource supplierDetailsBindingSource;
        private Inventry_Management_SystemDataSet1 inventry_Management_SystemDataSet1;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtExpireDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtPurchaceDate;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxVender;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2TextBox txtGetTax;
    }
}