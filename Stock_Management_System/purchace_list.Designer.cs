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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPurchaseList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Product_discriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dealer_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.product_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseList.ColumnHeadersHeight = 20;
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_Id,
            this.Product_name,
            this.Product_discriptions,
            this.Dealer_name,
            this.product_Qty,
            this.unit_price,
            this.total_price});
            this.dgvPurchaseList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPurchaseList.GridColor = System.Drawing.Color.Silver;
            this.dgvPurchaseList.Location = new System.Drawing.Point(21, 211);
            this.dgvPurchaseList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.RowHeadersVisible = false;
            this.dgvPurchaseList.RowHeadersWidth = 51;
            this.dgvPurchaseList.RowTemplate.Height = 24;
            this.dgvPurchaseList.Size = new System.Drawing.Size(1168, 252);
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
            this.dgvPurchaseList.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvPurchaseList.ThemeStyle.ReadOnly = false;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPurchaseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1009, 473);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            // 
            // btnReset
            // 
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(812, 473);
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
            this.guna2Button3.Location = new System.Drawing.Point(611, 473);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "guna2Button1";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(812, 91);
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
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(812, 50);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(151, 22);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Purchase_date";
            // 
            // product_Id
            // 
            this.product_Id.HeaderText = "product_Id";
            this.product_Id.MinimumWidth = 6;
            this.product_Id.Name = "product_Id";
            this.product_Id.Visible = false;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Product_name";
            this.Product_name.MinimumWidth = 6;
            this.Product_name.Name = "Product_name";
            // 
            // Product_discriptions
            // 
            this.Product_discriptions.HeaderText = "Product_discriptions";
            this.Product_discriptions.MinimumWidth = 6;
            this.Product_discriptions.Name = "Product_discriptions";
            // 
            // Dealer_name
            // 
            this.Dealer_name.HeaderText = "Dealer_name";
            this.Dealer_name.MinimumWidth = 6;
            this.Dealer_name.Name = "Dealer_name";
            this.Dealer_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dealer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // product_Qty
            // 
            this.product_Qty.HeaderText = "Product_Qty";
            this.product_Qty.MinimumWidth = 6;
            this.product_Qty.Name = "product_Qty";
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Unit_Price";
            this.unit_price.MinimumWidth = 6;
            this.unit_price.Name = "unit_price";
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total_price";
            this.total_price.MinimumWidth = 6;
            this.total_price.Name = "total_price";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(812, 134);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(150, 22);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Purchase_type";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.guna2DateTimePicker1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(972, 41);
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
            this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.CustomFormat = "dd/mm/yyyy";
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.guna2DateTimePicker2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(972, 83);
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
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(972, 134);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(-1, -2);
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
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(65, 16);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(301, 31);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "Purchase Order";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // purchace_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 530);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPurchaseList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "purchace_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "purchace_list";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvPurchaseList;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_discriptions;
        private System.Windows.Forms.DataGridViewComboBoxColumn Dealer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}