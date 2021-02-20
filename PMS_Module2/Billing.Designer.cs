namespace PMS_Module2
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.med_combx = new System.Windows.Forms.ComboBox();
            this.lab_avail_stock = new System.Windows.Forms.Label();
            this.txt_bill_qty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.BillingDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd_amount = new System.Windows.Forms.Label();
            this.btn_print = new Guna.UI2.WinForms.Guna2Button();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Billing System";
            // 
            // med_combx
            // 
            this.med_combx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_combx.FormattingEnabled = true;
            this.med_combx.Location = new System.Drawing.Point(19, 81);
            this.med_combx.Name = "med_combx";
            this.med_combx.Size = new System.Drawing.Size(159, 25);
            this.med_combx.TabIndex = 8;
            this.med_combx.Text = "Select Medicine";
            this.med_combx.SelectionChangeCommitted += new System.EventHandler(this.med_combx_SelectionChangeCommitted);
            // 
            // lab_avail_stock
            // 
            this.lab_avail_stock.AutoSize = true;
            this.lab_avail_stock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_avail_stock.Location = new System.Drawing.Point(16, 142);
            this.lab_avail_stock.Name = "lab_avail_stock";
            this.lab_avail_stock.Size = new System.Drawing.Size(102, 17);
            this.lab_avail_stock.TabIndex = 9;
            this.lab_avail_stock.Text = "Available Stock";
            this.lab_avail_stock.Visible = false;
            // 
            // txt_bill_qty
            // 
            this.txt_bill_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bill_qty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_qty.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_bill_qty.HintForeColor = System.Drawing.Color.Empty;
            this.txt_bill_qty.HintText = "";
            this.txt_bill_qty.isPassword = false;
            this.txt_bill_qty.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_bill_qty.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_bill_qty.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_bill_qty.LineThickness = 3;
            this.txt_bill_qty.Location = new System.Drawing.Point(19, 199);
            this.txt_bill_qty.Margin = new System.Windows.Forms.Padding(5);
            this.txt_bill_qty.Name = "txt_bill_qty";
            this.txt_bill_qty.Size = new System.Drawing.Size(179, 54);
            this.txt_bill_qty.TabIndex = 12;
            this.txt_bill_qty.Text = "Quantity";
            this.txt_bill_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_add
            // 
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(19, 302);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(109, 45);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "ADD To BILL";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // BillingDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BillingDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BillingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillingDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillingDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillingDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillingDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BillingDataGridView.ColumnHeadersHeight = 44;
            this.BillingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedId,
            this.MedName,
            this.med_qty,
            this.U_price,
            this.T_price});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillingDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BillingDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.BillingDataGridView.EnableHeadersVisualStyles = false;
            this.BillingDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillingDataGridView.Location = new System.Drawing.Point(318, 0);
            this.BillingDataGridView.Name = "BillingDataGridView";
            this.BillingDataGridView.RowHeadersVisible = false;
            this.BillingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillingDataGridView.Size = new System.Drawing.Size(493, 535);
            this.BillingDataGridView.TabIndex = 19;
            this.BillingDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BillingDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillingDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillingDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillingDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillingDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillingDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillingDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BillingDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillingDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillingDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillingDataGridView.ThemeStyle.HeaderStyle.Height = 44;
            this.BillingDataGridView.ThemeStyle.ReadOnly = false;
            this.BillingDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillingDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillingDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillingDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillingDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.BillingDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillingDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MedId
            // 
            this.MedId.HeaderText = "Med Id";
            this.MedId.Name = "MedId";
            // 
            // MedName
            // 
            this.MedName.HeaderText = "Medicine Name";
            this.MedName.Name = "MedName";
            // 
            // med_qty
            // 
            this.med_qty.HeaderText = "Quantity";
            this.med_qty.Name = "med_qty";
            // 
            // U_price
            // 
            this.U_price.HeaderText = "Unit Price";
            this.U_price.Name = "U_price";
            // 
            // T_price
            // 
            this.T_price.HeaderText = "Total Price";
            this.T_price.Name = "T_price";
            // 
            // grd_amount
            // 
            this.grd_amount.AutoSize = true;
            this.grd_amount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd_amount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grd_amount.Location = new System.Drawing.Point(27, 429);
            this.grd_amount.Name = "grd_amount";
            this.grd_amount.Size = new System.Drawing.Size(222, 37);
            this.grd_amount.TabIndex = 20;
            this.grd_amount.Text = "Total Amount";
            // 
            // btn_print
            // 
            this.btn_print.CheckedState.Parent = this.btn_print;
            this.btn_print.CustomImages.Parent = this.btn_print;
            this.btn_print.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.HoverState.Parent = this.btn_print;
            this.btn_print.Location = new System.Drawing.Point(34, 478);
            this.btn_print.Name = "btn_print";
            this.btn_print.ShadowDecoration.Parent = this.btn_print;
            this.btn_print.Size = new System.Drawing.Size(109, 45);
            this.btn_print.TabIndex = 18;
            this.btn_print.Text = "PRINT";
            // 
            // btn_home
            // 
            this.btn_home.CheckedState.Parent = this.btn_home;
            this.btn_home.CustomImages.Parent = this.btn_home;
            this.btn_home.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.HoverState.Parent = this.btn_home;
            this.btn_home.Location = new System.Drawing.Point(178, 478);
            this.btn_home.Name = "btn_home";
            this.btn_home.ShadowDecoration.Parent = this.btn_home;
            this.btn_home.Size = new System.Drawing.Size(109, 45);
            this.btn_home.TabIndex = 18;
            this.btn_home.Text = "Back to Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 535);
            this.Controls.Add(this.grd_amount);
            this.Controls.Add(this.BillingDataGridView);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_bill_qty);
            this.Controls.Add(this.lab_avail_stock);
            this.Controls.Add(this.med_combx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox med_combx;
        private System.Windows.Forms.Label lab_avail_stock;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_bill_qty;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2DataGridView BillingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_price;
        private System.Windows.Forms.Label grd_amount;
        private Guna.UI2.WinForms.Guna2Button btn_print;
        private Guna.UI2.WinForms.Guna2Button btn_home;
    }
}