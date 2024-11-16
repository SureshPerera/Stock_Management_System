namespace Stock_Management_System
{
    partial class purchace_list
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
            this.dgvPurchaseList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.supplierDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet1 = new Stock_Management_System.Inventry_Management_SystemDataSet1();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.btnaddnewItem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalPriceWithTax = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTax = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboxTax = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.supplierDetailsTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSet1TableAdapters.supplierDetailsTableAdapter();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxVender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnImgAddSuppliers = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.newto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Item_Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvPurchaseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseList.ColumnHeadersHeight = 30;
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPurchaseList.GridColor = System.Drawing.Color.Silver;
            this.dgvPurchaseList.Location = new System.Drawing.Point(21, 211);
            this.dgvPurchaseList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseList.RowHeadersVisible = false;
            this.dgvPurchaseList.RowHeadersWidth = 51;
            this.dgvPurchaseList.RowTemplate.Height = 24;
            this.dgvPurchaseList.Size = new System.Drawing.Size(1499, 392);
            this.dgvPurchaseList.TabIndex = 0;
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
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvPurchaseList.ThemeStyle.ReadOnly = false;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPurchaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseList_cellContentClick);
            this.dgvPurchaseList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellEndEdit_click);
            this.dgvPurchaseList.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseList_cellleave);
            this.dgvPurchaseList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellValueChange_Click);
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
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1340, 809);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Create";
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1154, 809);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(968, 809);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "Delete";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1160, 100);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(126, 22);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Expiry_date";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1160, 59);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(151, 22);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Purchase_date";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(1161, 149);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(150, 22);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Purchase_type";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderRadius = 17;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.guna2DateTimePicker1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(1320, 50);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 3;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 9, 9, 1, 8, 53, 804);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.AutoRoundedCorners = true;
            this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.BorderRadius = 17;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.CustomFormat = "dd/mm/yyyy";
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(1320, 92);
            this.guna2DateTimePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker2.TabIndex = 3;
            this.guna2DateTimePicker2.UseTransparentBackground = true;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 9, 9, 0, 58, 34, 431);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(1320, 141);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2ComboBox1.TabIndex = 4;
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
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(731, 9);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(301, 31);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Purchase Order";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
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
            this.btnaddnewItem.Location = new System.Drawing.Point(9, 52);
            this.btnaddnewItem.Name = "btnaddnewItem";
            this.btnaddnewItem.PressedState.Image = global::Stock_Management_System.Properties.Resources.Add_Databases;
            this.btnaddnewItem.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnaddnewItem.Size = new System.Drawing.Size(62, 49);
            this.btnaddnewItem.TabIndex = 14;
            this.btnaddnewItem.UseTransparentBackground = true;
            this.btnaddnewItem.Click += new System.EventHandler(this.btnaddnewItem_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(15, 99);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(50, 37);
            this.guna2HtmlLabel5.TabIndex = 2;
            this.guna2HtmlLabel5.Text = "New \r\nItem";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(1160, 652);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(129, 18);
            this.guna2HtmlLabel6.TabIndex = 15;
            this.guna2HtmlLabel6.Text = "Total Price";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(1160, 685);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(111, 18);
            this.guna2HtmlLabel7.TabIndex = 15;
            this.guna2HtmlLabel7.Text = "Tax/Vat";
            this.guna2HtmlLabel7.Click += new System.EventHandler(this.guna2HtmlLabel7_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(1160, 730);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(174, 18);
            this.guna2HtmlLabel8.TabIndex = 15;
            this.guna2HtmlLabel8.Text = "Total Price with tax";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = false;
            this.txtTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(1407, 652);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(113, 18);
            this.txtTotalPrice.TabIndex = 15;
            this.txtTotalPrice.Text = "****";
            // 
            // txtTotalPriceWithTax
            // 
            this.txtTotalPriceWithTax.AutoSize = false;
            this.txtTotalPriceWithTax.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPriceWithTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceWithTax.Location = new System.Drawing.Point(1407, 730);
            this.txtTotalPriceWithTax.Name = "txtTotalPriceWithTax";
            this.txtTotalPriceWithTax.Size = new System.Drawing.Size(113, 18);
            this.txtTotalPriceWithTax.TabIndex = 15;
            this.txtTotalPriceWithTax.Text = "****";
            // 
            // txtTax
            // 
            this.txtTax.AutoSize = false;
            this.txtTax.BackColor = System.Drawing.Color.Transparent;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(1407, 685);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(113, 18);
            this.txtTax.TabIndex = 15;
            this.txtTax.Text = "****";
            this.txtTax.Click += new System.EventHandler(this.guna2HtmlLabel7_Click);
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.AutoSize = false;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(919, 657);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(43, 18);
            this.guna2HtmlLabel12.TabIndex = 15;
            this.guna2HtmlLabel12.Text = "Tax";
            this.guna2HtmlLabel12.Click += new System.EventHandler(this.guna2HtmlLabel12_Click);
            // 
            // comboxTax
            // 
            this.comboxTax.AutoRoundedCorners = true;
            this.comboxTax.BackColor = System.Drawing.Color.Transparent;
            this.comboxTax.BorderRadius = 17;
            this.comboxTax.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxTax.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboxTax.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxTax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxTax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboxTax.ItemHeight = 30;
            this.comboxTax.Items.AddRange(new object[] {
            "8",
            "10",
            "18"});
            this.comboxTax.Location = new System.Drawing.Point(980, 652);
            this.comboxTax.Name = "comboxTax";
            this.comboxTax.Size = new System.Drawing.Size(90, 36);
            this.comboxTax.TabIndex = 16;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.AutoSize = false;
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(1076, 657);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(31, 31);
            this.guna2HtmlLabel13.TabIndex = 15;
            this.guna2HtmlLabel13.Text = "%";
            this.guna2HtmlLabel13.Click += new System.EventHandler(this.guna2HtmlLabel12_Click);
            // 
            // supplierDetailsTableAdapter
            // 
            this.supplierDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.AutoSize = false;
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(778, 149);
            this.guna2HtmlLabel14.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(92, 22);
            this.guna2HtmlLabel14.TabIndex = 2;
            this.guna2HtmlLabel14.Text = "Vender";
            this.guna2HtmlLabel14.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
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
            this.comboBoxVender.Location = new System.Drawing.Point(870, 141);
            this.comboBoxVender.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxVender.Name = "comboBoxVender";
            this.comboBoxVender.Size = new System.Drawing.Size(200, 36);
            this.comboBoxVender.TabIndex = 4;
            this.comboBoxVender.SelectedIndexChanged += new System.EventHandler(this.comboBoxVender_SelectedIndexChanged);
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
            this.btnImgAddSuppliers.Location = new System.Drawing.Point(74, 52);
            this.btnImgAddSuppliers.Name = "btnImgAddSuppliers";
            this.btnImgAddSuppliers.PressedState.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnImgAddSuppliers.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnImgAddSuppliers.Size = new System.Drawing.Size(64, 51);
            this.btnImgAddSuppliers.TabIndex = 17;
            this.btnImgAddSuppliers.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.AutoSize = false;
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(74, 100);
            this.guna2HtmlLabel15.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(62, 37);
            this.guna2HtmlLabel15.TabIndex = 2;
            this.guna2HtmlLabel15.Text = "New Supplier";
            this.guna2HtmlLabel15.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newto
            // 
            this.newto.AutoSize = false;
            this.newto.BackColor = System.Drawing.Color.Transparent;
            this.newto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newto.Location = new System.Drawing.Point(870, 79);
            this.newto.Margin = new System.Windows.Forms.Padding(0);
            this.newto.Name = "newto";
            this.newto.Size = new System.Drawing.Size(150, 22);
            this.newto.TabIndex = 2;
            this.newto.Text = "...";
            this.newto.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
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
            // purchace_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 992);
            this.Controls.Add(this.btnImgAddSuppliers);
            this.Controls.Add(this.comboxTax);
            this.Controls.Add(this.txtTotalPriceWithTax);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.guna2HtmlLabel12);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.btnaddnewItem);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.comboBoxVender);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel14);
            this.Controls.Add(this.newto);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel15);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPurchaseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 130);
            this.Name = "purchace_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "purchace_list";
            this.Load += new System.EventHandler(this.purchace_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseList;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Inventry_Management_SystemDataSet inventry_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btnaddnewItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTotalPriceWithTax;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtTax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2ComboBox comboxTax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Inventry_Management_SystemDataSet1 inventry_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource supplierDetailsBindingSource;
        private Inventry_Management_SystemDataSet1TableAdapters.supplierDetailsTableAdapter supplierDetailsTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxVender;
        private Guna.UI2.WinForms.Guna2ImageButton btnImgAddSuppliers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel newto;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
    }
}