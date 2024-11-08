namespace Stock_Management_System
{
    partial class customerDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerDashbord));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnaddnewItem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCustomerDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.btnimgSerach = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderRadius = 27;
            this.guna2Panel1.Controls.Add(this.btnAddCustomer);
            this.guna2Panel1.Controls.Add(this.btnaddnewItem);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(75, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(508, 57);
            this.guna2Panel1.TabIndex = 20;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddCustomer.HoverState.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnAddCustomer.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnAddCustomer.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnAddCustomer.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddCustomer.ImageRotate = 0F;
            this.btnAddCustomer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddCustomer.Location = new System.Drawing.Point(95, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.PressedState.Image = global::Stock_Management_System.Properties.Resources.AddSupplier;
            this.btnAddCustomer.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnAddCustomer.Size = new System.Drawing.Size(64, 51);
            this.btnAddCustomer.TabIndex = 15;
            this.btnAddCustomer.UseTransparentBackground = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
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
            this.guna2ControlBox1.TabIndex = 19;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Futura-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(624, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(267, 67);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Customer Details ";
            // 
            // dgvCustomerDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerDetails.ColumnHeadersHeight = 35;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusId,
            this.cusName,
            this.cusAddress,
            this.cusContact,
            this.cusEmail,
            this.cusTin});
            this.dgvCustomerDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerDetails.Location = new System.Drawing.Point(12, 96);
            this.dgvCustomerDetails.MultiSelect = false;
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.ReadOnly = true;
            this.dgvCustomerDetails.RowHeadersVisible = false;
            this.dgvCustomerDetails.RowHeadersWidth = 51;
            this.dgvCustomerDetails.RowTemplate.Height = 33;
            this.dgvCustomerDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(1549, 909);
            this.dgvCustomerDetails.TabIndex = 21;
            this.dgvCustomerDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomerDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomerDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCustomerDetails.ThemeStyle.ReadOnly = true;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.Height = 33;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
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
            this.btnimgSerach.Location = new System.Drawing.Point(1434, 22);
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
            this.txtSearch.Location = new System.Drawing.Point(1115, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "   Search Customer";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(404, 47);
            this.txtSearch.TabIndex = 28;
            // 
            // cusId
            // 
            this.cusId.DataPropertyName = "cusId";
            this.cusId.HeaderText = "Id";
            this.cusId.MinimumWidth = 6;
            this.cusId.Name = "cusId";
            this.cusId.ReadOnly = true;
            this.cusId.Visible = false;
            // 
            // cusName
            // 
            this.cusName.DataPropertyName = "cusName";
            this.cusName.HeaderText = "Name";
            this.cusName.MinimumWidth = 6;
            this.cusName.Name = "cusName";
            this.cusName.ReadOnly = true;
            // 
            // cusAddress
            // 
            this.cusAddress.DataPropertyName = "cusAddress";
            this.cusAddress.HeaderText = "Address";
            this.cusAddress.MinimumWidth = 6;
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.ReadOnly = true;
            // 
            // cusContact
            // 
            this.cusContact.DataPropertyName = "cusContact";
            this.cusContact.HeaderText = "Contact No";
            this.cusContact.MinimumWidth = 6;
            this.cusContact.Name = "cusContact";
            this.cusContact.ReadOnly = true;
            // 
            // cusEmail
            // 
            this.cusEmail.DataPropertyName = "cusEmail";
            this.cusEmail.HeaderText = "Email";
            this.cusEmail.MinimumWidth = 6;
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.ReadOnly = true;
            // 
            // cusTin
            // 
            this.cusTin.DataPropertyName = "cusTin";
            this.cusTin.HeaderText = "Tin No";
            this.cusTin.MinimumWidth = 6;
            this.cusTin.Name = "cusTin";
            this.cusTin.ReadOnly = true;
            // 
            // customerDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1722, 992);
            this.Controls.Add(this.btnimgSerach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvCustomerDetails);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 130);
            this.Name = "customerDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "customerDashbord";
            this.Load += new System.EventHandler(this.customerDashbordload_click);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddCustomer;
        private Guna.UI2.WinForms.Guna2ImageButton btnaddnewItem;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerDetails;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Inventry_Management_SystemDataSet inventry_Management_SystemDataSet;
        private Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btnimgSerach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusTin;
    }
}