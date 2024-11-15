namespace Stock_Management_System
{
    partial class addNewCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddNewCus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCusContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetCus = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateCus = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteCus = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCus = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtCusTin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddNewCus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddNewCus
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddNewCus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddNewCus.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddNewCus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddNewCus.ColumnHeadersHeight = 30;
            this.dgvAddNewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAddNewCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusId,
            this.cusName,
            this.cusAddress,
            this.cusContact,
            this.cusEmail,
            this.cusTin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddNewCus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddNewCus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCus.Location = new System.Drawing.Point(468, 37);
            this.dgvAddNewCus.Name = "dgvAddNewCus";
            this.dgvAddNewCus.ReadOnly = true;
            this.dgvAddNewCus.RowHeadersVisible = false;
            this.dgvAddNewCus.RowHeadersWidth = 51;
            this.dgvAddNewCus.RowTemplate.Height = 24;
            this.dgvAddNewCus.Size = new System.Drawing.Size(771, 404);
            this.dgvAddNewCus.TabIndex = 41;
            this.dgvAddNewCus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddNewCus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAddNewCus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAddNewCus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAddNewCus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAddNewCus.ThemeStyle.BackColor = System.Drawing.Color.Beige;
            this.dgvAddNewCus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAddNewCus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAddNewCus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddNewCus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAddNewCus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAddNewCus.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAddNewCus.ThemeStyle.ReadOnly = true;
            this.dgvAddNewCus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAddNewCus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAddNewCus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAddNewCus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAddNewCus.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAddNewCus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAddNewCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick_click);
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
            // txtCusContact
            // 
            this.txtCusContact.AutoRoundedCorners = true;
            this.txtCusContact.BorderRadius = 14;
            this.txtCusContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusContact.DefaultText = "";
            this.txtCusContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusContact.Location = new System.Drawing.Point(117, 232);
            this.txtCusContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusContact.Name = "txtCusContact";
            this.txtCusContact.PasswordChar = '\0';
            this.txtCusContact.PlaceholderText = "07********";
            this.txtCusContact.SelectedText = "";
            this.txtCusContact.Size = new System.Drawing.Size(338, 31);
            this.txtCusContact.TabIndex = 37;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusAddress.DefaultText = "";
            this.txtCusAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusAddress.Location = new System.Drawing.Point(117, 118);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.PasswordChar = '\0';
            this.txtCusAddress.PlaceholderText = "No370,BRoad,Colombo7";
            this.txtCusAddress.SelectedText = "";
            this.txtCusAddress.Size = new System.Drawing.Size(338, 93);
            this.txtCusAddress.TabIndex = 38;
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.AutoRoundedCorners = true;
            this.txtCusEmail.BorderRadius = 14;
            this.txtCusEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusEmail.DefaultText = "";
            this.txtCusEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusEmail.Location = new System.Drawing.Point(117, 271);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.PasswordChar = '\0';
            this.txtCusEmail.PlaceholderText = "abc@gmail.com";
            this.txtCusEmail.SelectedText = "";
            this.txtCusEmail.Size = new System.Drawing.Size(338, 31);
            this.txtCusEmail.TabIndex = 39;
            // 
            // txtCusName
            // 
            this.txtCusName.AutoRoundedCorners = true;
            this.txtCusName.BorderRadius = 14;
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Location = new System.Drawing.Point(117, 79);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderText = "Abc";
            this.txtCusName.SelectedText = "";
            this.txtCusName.Size = new System.Drawing.Size(338, 31);
            this.txtCusName.TabIndex = 40;
            // 
            // btnResetCus
            // 
            this.btnResetCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetCus.ForeColor = System.Drawing.Color.White;
            this.btnResetCus.Location = new System.Drawing.Point(11, 401);
            this.btnResetCus.Name = "btnResetCus";
            this.btnResetCus.Size = new System.Drawing.Size(100, 40);
            this.btnResetCus.TabIndex = 33;
            this.btnResetCus.Text = "Reset";
            this.btnResetCus.Click += new System.EventHandler(this.btnResetCus_click);
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateCus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCus.Location = new System.Drawing.Point(117, 402);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateCus.TabIndex = 34;
            this.btnUpdateCus.Text = "Update";
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteCus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCus.Location = new System.Drawing.Point(225, 401);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(102, 40);
            this.btnDeleteCus.TabIndex = 35;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_click);
            // 
            // btnAddCus
            // 
            this.btnAddCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCus.ForeColor = System.Drawing.Color.White;
            this.btnAddCus.Location = new System.Drawing.Point(333, 401);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(108, 40);
            this.btnAddCus.TabIndex = 36;
            this.btnAddCus.Text = "Add";
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(14, 232);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(184, 18);
            this.guna2HtmlLabel5.TabIndex = 28;
            this.guna2HtmlLabel5.Text = "Contact No";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(14, 139);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(169, 18);
            this.guna2HtmlLabel4.TabIndex = 29;
            this.guna2HtmlLabel4.Text = "Address";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 271);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(176, 18);
            this.guna2HtmlLabel3.TabIndex = 30;
            this.guna2HtmlLabel3.Text = "Email ";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(155, 18);
            this.guna2HtmlLabel2.TabIndex = 31;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Futura-Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(104, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(386, 36);
            this.guna2HtmlLabel1.TabIndex = 32;
            this.guna2HtmlLabel1.Text = "Add New Customer";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(11, 1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 35);
            this.guna2ControlBox1.TabIndex = 27;
            // 
            // txtCusTin
            // 
            this.txtCusTin.AutoRoundedCorners = true;
            this.txtCusTin.BorderRadius = 14;
            this.txtCusTin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusTin.DefaultText = "";
            this.txtCusTin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusTin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusTin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusTin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusTin.Location = new System.Drawing.Point(117, 310);
            this.txtCusTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusTin.Name = "txtCusTin";
            this.txtCusTin.PasswordChar = '\0';
            this.txtCusTin.PlaceholderText = "A1212354";
            this.txtCusTin.SelectedText = "";
            this.txtCusTin.Size = new System.Drawing.Size(338, 31);
            this.txtCusTin.TabIndex = 39;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Futura Bk BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(14, 310);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(176, 18);
            this.guna2HtmlLabel6.TabIndex = 30;
            this.guna2HtmlLabel6.Text = "Tin No";
            // 
            // addNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 453);
            this.Controls.Add(this.dgvAddNewCus);
            this.Controls.Add(this.txtCusContact);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusTin);
            this.Controls.Add(this.txtCusEmail);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.btnResetCus);
            this.Controls.Add(this.btnUpdateCus);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(268, 950);
            this.Name = "addNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addNewCustomer";
            this.Load += new System.EventHandler(this.addNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddNewCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAddNewCus;
        private Guna.UI2.WinForms.Guna2TextBox txtCusContact;
        private Guna.UI2.WinForms.Guna2TextBox txtCusAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtCusEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private Guna.UI2.WinForms.Guna2Button btnResetCus;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCus;
        private Guna.UI2.WinForms.Guna2Button btnDeleteCus;
        private Guna.UI2.WinForms.Guna2Button btnAddCus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtCusTin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusTin;
    }
}