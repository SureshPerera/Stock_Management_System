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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliersDashbord));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImgAddSuppliers = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnaddnewItem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSpplierDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnimgSerach = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.supId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Firm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpplierDetails)).BeginInit();
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
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
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
            // dgvSpplierDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvSpplierDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpplierDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSpplierDetails.ColumnHeadersHeight = 45;
            this.dgvSpplierDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSpplierDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supId,
            this.supplier_Address,
            this.supplier_Contact,
            this.supplier_Firm,
            this.supplier_Name,
            this.supEmail,
            this.Tin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSpplierDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSpplierDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSpplierDetails.Location = new System.Drawing.Point(12, 69);
            this.dgvSpplierDetails.Name = "dgvSpplierDetails";
            this.dgvSpplierDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSpplierDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSpplierDetails.RowHeadersVisible = false;
            this.dgvSpplierDetails.RowHeadersWidth = 51;
            this.dgvSpplierDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSpplierDetails.RowTemplate.Height = 34;
            this.dgvSpplierDetails.Size = new System.Drawing.Size(1534, 909);
            this.dgvSpplierDetails.TabIndex = 30;
            this.dgvSpplierDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgvSpplierDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvSpplierDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSpplierDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSpplierDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSpplierDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSpplierDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSpplierDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSpplierDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvSpplierDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSpplierDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSpplierDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSpplierDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSpplierDetails.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvSpplierDetails.ThemeStyle.ReadOnly = true;
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.Height = 34;
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvSpplierDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.btnRefresh.Location = new System.Drawing.Point(1482, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.Image = global::Stock_Management_System.Properties.Resources.Sync;
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnRefresh.Size = new System.Drawing.Size(44, 39);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // supplier_Address
            // 
            this.supplier_Address.DataPropertyName = "supplier_Address";
            this.supplier_Address.HeaderText = "Name";
            this.supplier_Address.MinimumWidth = 6;
            this.supplier_Address.Name = "supplier_Address";
            this.supplier_Address.ReadOnly = true;
            // 
            // supplier_Contact
            // 
            this.supplier_Contact.DataPropertyName = "supplier_Contact";
            this.supplier_Contact.HeaderText = "Company ";
            this.supplier_Contact.MinimumWidth = 6;
            this.supplier_Contact.Name = "supplier_Contact";
            this.supplier_Contact.ReadOnly = true;
            // 
            // supplier_Firm
            // 
            this.supplier_Firm.DataPropertyName = "supplier_Firm";
            this.supplier_Firm.HeaderText = "Address";
            this.supplier_Firm.MinimumWidth = 6;
            this.supplier_Firm.Name = "supplier_Firm";
            this.supplier_Firm.ReadOnly = true;
            // 
            // supplier_Name
            // 
            this.supplier_Name.DataPropertyName = "supplier_Name";
            this.supplier_Name.HeaderText = "Contact No";
            this.supplier_Name.MinimumWidth = 6;
            this.supplier_Name.Name = "supplier_Name";
            this.supplier_Name.ReadOnly = true;
            // 
            // supEmail
            // 
            this.supEmail.DataPropertyName = "supEmail";
            this.supEmail.HeaderText = "Email";
            this.supEmail.MinimumWidth = 6;
            this.supEmail.Name = "supEmail";
            this.supEmail.ReadOnly = true;
            // 
            // Tin
            // 
            this.Tin.DataPropertyName = "Tin";
            this.Tin.HeaderText = "Tin No";
            this.Tin.MinimumWidth = 6;
            this.Tin.Name = "Tin";
            this.Tin.ReadOnly = true;
            // 
            // suppliersDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 992);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvSpplierDetails);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpplierDetails)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvSpplierDetails;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn supId;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Firm;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tin;
    }
}