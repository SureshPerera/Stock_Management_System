namespace Stock_Management_System
{
    partial class logingAccountDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logingAccountDashbord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnimgSerach = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemTableAdapter = new Stock_Management_System.Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter();
            this.inventry_Management_SystemDataSet = new Stock_Management_System.Inventry_Management_SystemDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvCustomerDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnImgAddUsers = new Guna.UI2.WinForms.Guna2ImageButton();
            this.UseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.SuspendLayout();
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
            this.btnimgSerach.TabIndex = 35;
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
            this.txtSearch.Location = new System.Drawing.Point(1079, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "   Search Customer";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(404, 47);
            this.txtSearch.TabIndex = 34;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // inventry_Management_SystemDataSet
            // 
            this.inventry_Management_SystemDataSet.DataSetName = "Inventry_Management_SystemDataSet";
            this.inventry_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.inventry_Management_SystemDataSet;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderRadius = 27;
            this.guna2Panel1.Controls.Add(this.btnImgAddUsers);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(75, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(508, 57);
            this.guna2Panel1.TabIndex = 32;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(10, 10);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 35);
            this.guna2ControlBox1.TabIndex = 31;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Futura-Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(624, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(459, 67);
            this.guna2HtmlLabel1.TabIndex = 30;
            this.guna2HtmlLabel1.Text = "Loging Account Details";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // dgvCustomerDetails
            // 
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvCustomerDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvCustomerDetails.ColumnHeadersHeight = 45;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UseID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.UserName,
            this.Passwords});
            this.dgvCustomerDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerDetails.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgvCustomerDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerDetails.Location = new System.Drawing.Point(12, 96);
            this.dgvCustomerDetails.MultiSelect = false;
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvCustomerDetails.RowHeadersVisible = false;
            this.dgvCustomerDetails.RowHeadersWidth = 51;
            this.dgvCustomerDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerDetails.RowTemplate.Height = 33;
            this.dgvCustomerDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerDetails.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(1549, 909);
            this.dgvCustomerDetails.TabIndex = 33;
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
            this.dgvCustomerDetails.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvCustomerDetails.ThemeStyle.ReadOnly = true;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.Height = 33;
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnImgAddUsers
            // 
            this.btnImgAddUsers.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImgAddUsers.HoverState.Image = global::Stock_Management_System.Properties.Resources.Add_User_Male_green;
            this.btnImgAddUsers.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnImgAddUsers.Image = global::Stock_Management_System.Properties.Resources.Add_User_Male;
            this.btnImgAddUsers.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnImgAddUsers.ImageRotate = 0F;
            this.btnImgAddUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnImgAddUsers.Location = new System.Drawing.Point(3, 5);
            this.btnImgAddUsers.Name = "btnImgAddUsers";
            this.btnImgAddUsers.PressedState.Image = global::Stock_Management_System.Properties.Resources.Add_User_Male_green;
            this.btnImgAddUsers.PressedState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnImgAddUsers.Size = new System.Drawing.Size(64, 49);
            this.btnImgAddUsers.TabIndex = 36;
            this.btnImgAddUsers.Click += new System.EventHandler(this.btnImgAddUsers_Click);
            // 
            // UseID
            // 
            this.UseID.DataPropertyName = "UseID";
            this.UseID.HeaderText = "Id";
            this.UseID.MinimumWidth = 6;
            this.UseID.Name = "UseID";
            this.UseID.ReadOnly = true;
            this.UseID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Passwords
            // 
            this.Passwords.DataPropertyName = "Passwords";
            this.Passwords.HeaderText = "Password";
            this.Passwords.MinimumWidth = 6;
            this.Passwords.Name = "Passwords";
            this.Passwords.ReadOnly = true;
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
            this.btnRefresh.Location = new System.Drawing.Point(1498, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.Image = global::Stock_Management_System.Properties.Resources.Sync;
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(47, 47);
            this.btnRefresh.Size = new System.Drawing.Size(44, 39);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.UseTransparentBackground = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // logingAccountDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 945);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnimgSerach);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvCustomerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 130);
            this.Name = "logingAccountDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "logingAccountDashbord";
            this.Load += new System.EventHandler(this.logingAccountDashbord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventry_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnimgSerach;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Inventry_Management_SystemDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private Inventry_Management_SystemDataSet inventry_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomerDetails;
        public Guna.UI2.WinForms.Guna2ImageButton btnImgAddUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwords;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefresh;
    }
}