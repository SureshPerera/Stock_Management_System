namespace Stock_Management_System
{
    partial class suppliersDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliersDashbord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.btnImgAddSuppliers = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnaddnewItem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnimgSerach = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvAddNewCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.supId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Firm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddNewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Futura-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(600, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(267, 67);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Supplier Details ";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(10, 34);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 35);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderRadius = 27;
            this.guna2Panel1.Controls.Add(this.btnImgAddSuppliers);
            this.guna2Panel1.Controls.Add(this.btnaddnewItem);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(56, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(508, 57);
            this.guna2Panel1.TabIndex = 17;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
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
            this.btnImgAddSuppliers.Location = new System.Drawing.Point(95, 3);
            this.btnImgAddSuppliers.Name = "btnImgAddSuppliers";
            this.btnImgAddSuppliers.PressedState.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnImgAddSuppliers.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnImgAddSuppliers.Size = new System.Drawing.Size(64, 51);
            this.btnImgAddSuppliers.TabIndex = 15;
            this.btnImgAddSuppliers.UseTransparentBackground = true;
            this.btnImgAddSuppliers.Click += new System.EventHandler(this.btnImgAddSuppliers_click);
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
            this.btnaddnewItem.Location = new System.Drawing.Point(3, 2);
            this.btnaddnewItem.Name = "btnaddnewItem";
            this.btnaddnewItem.PressedState.Image = global::Stock_Management_System.Properties.Resources.Add_Databases;
            this.btnaddnewItem.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnaddnewItem.Size = new System.Drawing.Size(77, 53);
            this.btnaddnewItem.TabIndex = 14;
            this.btnaddnewItem.UseTransparentBackground = true;
            this.btnaddnewItem.Click += new System.EventHandler(this.btnaddnewItem_Click);
            // 
            // btnimgSerach
            // 
            this.btnimgSerach.BackColor = System.Drawing.Color.Transparent;
            this.btnimgSerach.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnimgSerach.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnimgSerach.HoverState.ImageSize = new System.Drawing.Size(37, 37);
            this.btnimgSerach.Image = ((System.Drawing.Image)(resources.GetObject("btnimgSerach.Image")));
            this.btnimgSerach.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnimgSerach.ImageRotate = 0F;
            this.btnimgSerach.ImageSize = new System.Drawing.Size(30, 30);
            this.btnimgSerach.Location = new System.Drawing.Point(1364, 13);
            this.btnimgSerach.Name = "btnimgSerach";
            this.btnimgSerach.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnimgSerach.PressedState.ImageSize = new System.Drawing.Size(37, 37);
            this.btnimgSerach.Size = new System.Drawing.Size(40, 39);
            this.btnimgSerach.TabIndex = 29;
            this.btnimgSerach.UseTransparentBackground = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 22;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(1020, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "   Search Supplier";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(404, 47);
            this.txtSearch.TabIndex = 28;
            // 
            // dgvAddNewCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAddNewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddNewCustomer.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddNewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddNewCustomer.ColumnHeadersHeight = 18;
            this.dgvAddNewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAddNewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supId,
            this.supplier_Name,
            this.supplier_Firm,
            this.supplier_Address,
            this.supplier_Contact,
            this.email,
            this.tinNo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddNewCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddNewCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCustomer.Location = new System.Drawing.Point(12, 69);
            this.dgvAddNewCustomer.Name = "dgvAddNewCustomer";
            this.dgvAddNewCustomer.ReadOnly = true;
            this.dgvAddNewCustomer.RowHeadersVisible = false;
            this.dgvAddNewCustomer.RowHeadersWidth = 51;
            this.dgvAddNewCustomer.RowTemplate.Height = 24;
            this.dgvAddNewCustomer.Size = new System.Drawing.Size(1534, 909);
            this.dgvAddNewCustomer.TabIndex = 30;
            this.dgvAddNewCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddNewCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAddNewCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAddNewCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAddNewCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAddNewCustomer.ThemeStyle.BackColor = System.Drawing.Color.Beige;
            this.dgvAddNewCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAddNewCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAddNewCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddNewCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAddNewCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAddNewCustomer.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvAddNewCustomer.ThemeStyle.ReadOnly = true;
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // supId
            // 
            this.supId.DataPropertyName = "supId";
            this.supId.HeaderText = "Id";
            this.supId.MinimumWidth = 6;
            this.supId.Name = "supId";
            this.supId.ReadOnly = true;
            this.supId.Visible = false;
            // 
            // supplier_Name
            // 
            this.supplier_Name.DataPropertyName = "supplier_Name";
            this.supplier_Name.HeaderText = "Name";
            this.supplier_Name.MinimumWidth = 6;
            this.supplier_Name.Name = "supplier_Name";
            this.supplier_Name.ReadOnly = true;
            // 
            // supplier_Firm
            // 
            this.supplier_Firm.DataPropertyName = "supplier_Firm";
            this.supplier_Firm.HeaderText = "Company ";
            this.supplier_Firm.MinimumWidth = 6;
            this.supplier_Firm.Name = "supplier_Firm";
            this.supplier_Firm.ReadOnly = true;
            // 
            // supplier_Address
            // 
            this.supplier_Address.DataPropertyName = "supplier_Address";
            this.supplier_Address.HeaderText = "Address";
            this.supplier_Address.MinimumWidth = 6;
            this.supplier_Address.Name = "supplier_Address";
            this.supplier_Address.ReadOnly = true;
            // 
            // supplier_Contact
            // 
            this.supplier_Contact.DataPropertyName = "supplier_Contact";
            this.supplier_Contact.HeaderText = "Contact No";
            this.supplier_Contact.MinimumWidth = 6;
            this.supplier_Contact.Name = "supplier_Contact";
            this.supplier_Contact.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // tinNo
            // 
            this.tinNo.HeaderText = "Tin No";
            this.tinNo.MinimumWidth = 6;
            this.tinNo.Name = "tinNo";
            this.tinNo.ReadOnly = true;
            // 
            // suppliersDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 992);
            this.Controls.Add(this.dgvAddNewCustomer);
            this.Controls.Add(this.btnimgSerach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 130);
            this.Name = "suppliersDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "suppliersDashbord";
            this.Load += new System.EventHandler(this.suppliersDashbord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddNewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnaddnewItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnImgAddSuppliers;
        private Inventry_Management_SystemDataSet inventry_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btnimgSerach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAddNewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn supId;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Firm;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinNo;
    }
}