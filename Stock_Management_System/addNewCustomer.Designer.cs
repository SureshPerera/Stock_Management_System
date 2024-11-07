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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddNewCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.supId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Firm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSupCon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupAddess = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupCom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddNewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddNewCustomer
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvAddNewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAddNewCustomer.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddNewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAddNewCustomer.ColumnHeadersHeight = 18;
            this.dgvAddNewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAddNewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supId,
            this.supplier_Name,
            this.supplier_Firm,
            this.supplier_Address,
            this.supplier_Contact});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddNewCustomer.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAddNewCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAddNewCustomer.Location = new System.Drawing.Point(468, 37);
            this.dgvAddNewCustomer.Name = "dgvAddNewCustomer";
            this.dgvAddNewCustomer.ReadOnly = true;
            this.dgvAddNewCustomer.RowHeadersVisible = false;
            this.dgvAddNewCustomer.RowHeadersWidth = 51;
            this.dgvAddNewCustomer.RowTemplate.Height = 24;
            this.dgvAddNewCustomer.Size = new System.Drawing.Size(771, 404);
            this.dgvAddNewCustomer.TabIndex = 41;
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
            // txtSupCon
            // 
            this.txtSupCon.AutoRoundedCorners = true;
            this.txtSupCon.BorderRadius = 14;
            this.txtSupCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupCon.DefaultText = "";
            this.txtSupCon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupCon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupCon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupCon.Location = new System.Drawing.Point(117, 232);
            this.txtSupCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupCon.Name = "txtSupCon";
            this.txtSupCon.PasswordChar = '\0';
            this.txtSupCon.PlaceholderText = "07********";
            this.txtSupCon.SelectedText = "";
            this.txtSupCon.Size = new System.Drawing.Size(338, 31);
            this.txtSupCon.TabIndex = 37;
            // 
            // txtSupAddess
            // 
            this.txtSupAddess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupAddess.DefaultText = "";
            this.txtSupAddess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupAddess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupAddess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupAddess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupAddess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupAddess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupAddess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupAddess.Location = new System.Drawing.Point(117, 118);
            this.txtSupAddess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupAddess.Name = "txtSupAddess";
            this.txtSupAddess.PasswordChar = '\0';
            this.txtSupAddess.PlaceholderText = "No370,BRoad,Colombo7";
            this.txtSupAddess.SelectedText = "";
            this.txtSupAddess.Size = new System.Drawing.Size(338, 93);
            this.txtSupAddess.TabIndex = 38;
            // 
            // txtSupCom
            // 
            this.txtSupCom.AutoRoundedCorners = true;
            this.txtSupCom.BorderRadius = 14;
            this.txtSupCom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupCom.DefaultText = "";
            this.txtSupCom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupCom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupCom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupCom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupCom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupCom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupCom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupCom.Location = new System.Drawing.Point(117, 271);
            this.txtSupCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupCom.Name = "txtSupCom";
            this.txtSupCom.PasswordChar = '\0';
            this.txtSupCom.PlaceholderText = "abc@gmail.com";
            this.txtSupCom.SelectedText = "";
            this.txtSupCom.Size = new System.Drawing.Size(338, 31);
            this.txtSupCom.TabIndex = 39;
            // 
            // txtSupName
            // 
            this.txtSupName.AutoRoundedCorners = true;
            this.txtSupName.BorderRadius = 14;
            this.txtSupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupName.DefaultText = "";
            this.txtSupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupName.Location = new System.Drawing.Point(117, 79);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.PasswordChar = '\0';
            this.txtSupName.PlaceholderText = "Abc";
            this.txtSupName.SelectedText = "";
            this.txtSupName.Size = new System.Drawing.Size(338, 31);
            this.txtSupName.TabIndex = 40;
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(11, 401);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 40);
            this.btnReset.TabIndex = 33;
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
            this.guna2Button3.Location = new System.Drawing.Point(117, 402);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(100, 40);
            this.guna2Button3.TabIndex = 34;
            this.guna2Button3.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(225, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 40);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(333, 401);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(108, 40);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Text = "Add";
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 14;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(117, 310);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "A1212354";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(338, 31);
            this.guna2TextBox1.TabIndex = 39;
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
            this.Controls.Add(this.dgvAddNewCustomer);
            this.Controls.Add(this.txtSupCon);
            this.Controls.Add(this.txtSupAddess);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.txtSupCom);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.guna2Button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddNewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAddNewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn supId;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Firm;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_Contact;
        private Guna.UI2.WinForms.Guna2TextBox txtSupCon;
        private Guna.UI2.WinForms.Guna2TextBox txtSupAddess;
        private Guna.UI2.WinForms.Guna2TextBox txtSupCom;
        private Guna.UI2.WinForms.Guna2TextBox txtSupName;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}