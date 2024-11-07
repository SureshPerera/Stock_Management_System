namespace Stock_Management_System
{
    partial class categoryDashbord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryDashbord));
            this.dgvSupplierDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.catId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewCatergory = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnimgSerach = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierDetails)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplierDetails
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvSupplierDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSupplierDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSupplierDetails.ColumnHeadersHeight = 35;
            this.dgvSupplierDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSupplierDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catId,
            this.cat_Name,
            this.cat_Address});
            this.dgvSupplierDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierDetails.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSupplierDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplierDetails.Location = new System.Drawing.Point(12, 96);
            this.dgvSupplierDetails.MultiSelect = false;
            this.dgvSupplierDetails.Name = "dgvSupplierDetails";
            this.dgvSupplierDetails.ReadOnly = true;
            this.dgvSupplierDetails.RowHeadersVisible = false;
            this.dgvSupplierDetails.RowHeadersWidth = 51;
            this.dgvSupplierDetails.RowTemplate.Height = 33;
            this.dgvSupplierDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvSupplierDetails.Size = new System.Drawing.Size(1549, 909);
            this.dgvSupplierDetails.TabIndex = 25;
            this.dgvSupplierDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplierDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSupplierDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSupplierDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSupplierDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSupplierDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplierDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplierDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSupplierDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvSupplierDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSupplierDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSupplierDetails.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvSupplierDetails.ThemeStyle.ReadOnly = true;
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.Height = 33;
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSupplierDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderRadius = 27;
            this.guna2Panel1.Controls.Add(this.btnAddNewCatergory);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(108, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(508, 57);
            this.guna2Panel1.TabIndex = 24;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(10, 3);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 35);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Futura-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(695, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(333, 41);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Category Details ";
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
            // catId
            // 
            this.catId.DataPropertyName = "catId";
            this.catId.HeaderText = "Id";
            this.catId.MinimumWidth = 6;
            this.catId.Name = "catId";
            this.catId.ReadOnly = true;
            // 
            // cat_Name
            // 
            this.cat_Name.DataPropertyName = "cat_Name";
            this.cat_Name.HeaderText = "Category Name";
            this.cat_Name.MinimumWidth = 6;
            this.cat_Name.Name = "cat_Name";
            this.cat_Name.ReadOnly = true;
            // 
            // cat_Address
            // 
            this.cat_Address.DataPropertyName = "cat_Address";
            this.cat_Address.HeaderText = "Discriptions";
            this.cat_Address.MinimumWidth = 6;
            this.cat_Address.Name = "cat_Address";
            this.cat_Address.ReadOnly = true;
            // 
            // btnAddNewCatergory
            // 
            this.btnAddNewCatergory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCatergory.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAddNewCatergory.HoverState.Image = global::Stock_Management_System.Properties.Resources.Categorycolour;
            this.btnAddNewCatergory.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnAddNewCatergory.Image = global::Stock_Management_System.Properties.Resources.Categorycolour;
            this.btnAddNewCatergory.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddNewCatergory.ImageRotate = 0F;
            this.btnAddNewCatergory.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewCatergory.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewCatergory.Name = "btnAddNewCatergory";
            this.btnAddNewCatergory.PressedState.Image = global::Stock_Management_System.Properties.Resources.Categorycolour;
            this.btnAddNewCatergory.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnAddNewCatergory.Size = new System.Drawing.Size(64, 51);
            this.btnAddNewCatergory.TabIndex = 15;
            this.btnAddNewCatergory.UseTransparentBackground = true;
            this.btnAddNewCatergory.Click += new System.EventHandler(this.btnAddNewCatergory_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(1071, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "   Search anythings.";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(404, 47);
            this.txtSearch.TabIndex = 26;
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
            this.btnimgSerach.Location = new System.Drawing.Point(1415, 19);
            this.btnimgSerach.Name = "btnimgSerach";
            this.btnimgSerach.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnimgSerach.PressedState.ImageSize = new System.Drawing.Size(37, 37);
            this.btnimgSerach.Size = new System.Drawing.Size(40, 39);
            this.btnimgSerach.TabIndex = 27;
            this.btnimgSerach.UseTransparentBackground = true;
            // 
            // categoryDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 945);
            this.Controls.Add(this.btnimgSerach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSupplierDetails);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 130);
            this.Name = "categoryDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "categoryDashbord";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierDetails)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvSupplierDetails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Inventry_Management_SystemDataSet inventry_Management_SystemDataSet;
        private Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddNewCatergory;
        private System.Windows.Forms.DataGridViewTextBoxColumn catId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_Address;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ImageButton btnimgSerach;
    }
}