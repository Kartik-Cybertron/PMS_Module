namespace PMS_Module2
{
    partial class MedicineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.btn_del = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updt = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.company_cmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpkr_exp_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_qty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_s_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_b_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_med_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MedicineDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medicine Stock";
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(123, 351);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(109, 45);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "BACK";
            // 
            // btn_del
            // 
            this.btn_del.CheckedState.Parent = this.btn_del;
            this.btn_del.CustomImages.Parent = this.btn_del;
            this.btn_del.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.HoverState.Parent = this.btn_del;
            this.btn_del.Location = new System.Drawing.Point(238, 275);
            this.btn_del.Name = "btn_del";
            this.btn_del.ShadowDecoration.Parent = this.btn_del;
            this.btn_del.Size = new System.Drawing.Size(109, 45);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "DELETE";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_updt
            // 
            this.btn_updt.CheckedState.Parent = this.btn_updt;
            this.btn_updt.CustomImages.Parent = this.btn_updt;
            this.btn_updt.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_updt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_updt.ForeColor = System.Drawing.Color.White;
            this.btn_updt.HoverState.Parent = this.btn_updt;
            this.btn_updt.Location = new System.Drawing.Point(123, 275);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.ShadowDecoration.Parent = this.btn_updt;
            this.btn_updt.Size = new System.Drawing.Size(109, 45);
            this.btn_updt.TabIndex = 16;
            this.btn_updt.Text = "UPDATE";
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // btn_add
            // 
            this.btn_add.CheckedState.Parent = this.btn_add;
            this.btn_add.CustomImages.Parent = this.btn_add;
            this.btn_add.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.HoverState.Parent = this.btn_add;
            this.btn_add.Location = new System.Drawing.Point(8, 275);
            this.btn_add.Name = "btn_add";
            this.btn_add.ShadowDecoration.Parent = this.btn_add;
            this.btn_add.Size = new System.Drawing.Size(109, 45);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // company_cmbx
            // 
            this.company_cmbx.BackColor = System.Drawing.Color.Transparent;
            this.company_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.company_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_cmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.company_cmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.company_cmbx.FocusedState.Parent = this.company_cmbx;
            this.company_cmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.company_cmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.company_cmbx.HoverState.Parent = this.company_cmbx;
            this.company_cmbx.ItemHeight = 30;
            this.company_cmbx.Items.AddRange(new object[] {
            "IndiaMed",
            "Ranbaxy",
            "Cipla"});
            this.company_cmbx.ItemsAppearance.Parent = this.company_cmbx;
            this.company_cmbx.Location = new System.Drawing.Point(6, 175);
            this.company_cmbx.Name = "company_cmbx";
            this.company_cmbx.ShadowDecoration.Parent = this.company_cmbx;
            this.company_cmbx.Size = new System.Drawing.Size(164, 36);
            this.company_cmbx.TabIndex = 13;
            // 
            // dtpkr_exp_date
            // 
            this.dtpkr_exp_date.CheckedState.Parent = this.dtpkr_exp_date;
            this.dtpkr_exp_date.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpkr_exp_date.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_exp_date.ForeColor = System.Drawing.SystemColors.Control;
            this.dtpkr_exp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkr_exp_date.HoverState.Parent = this.dtpkr_exp_date;
            this.dtpkr_exp_date.Location = new System.Drawing.Point(8, 125);
            this.dtpkr_exp_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkr_exp_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkr_exp_date.Name = "dtpkr_exp_date";
            this.dtpkr_exp_date.ShadowDecoration.Parent = this.dtpkr_exp_date;
            this.dtpkr_exp_date.Size = new System.Drawing.Size(162, 36);
            this.dtpkr_exp_date.TabIndex = 12;
            this.dtpkr_exp_date.Value = new System.DateTime(2021, 2, 19, 13, 2, 35, 497);
            // 
            // txt_qty
            // 
            this.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_qty.HintForeColor = System.Drawing.Color.Empty;
            this.txt_qty.HintText = "";
            this.txt_qty.isPassword = false;
            this.txt_qty.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_qty.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_qty.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_qty.LineThickness = 3;
            this.txt_qty.Location = new System.Drawing.Point(194, 191);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(5);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(179, 54);
            this.txt_qty.TabIndex = 8;
            this.txt_qty.Text = "Quantity";
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_qty.OnValueChanged += new System.EventHandler(this.txt_qty_OnValueChanged);
            // 
            // txt_s_price
            // 
            this.txt_s_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_s_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_price.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_s_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_s_price.HintText = "";
            this.txt_s_price.isPassword = false;
            this.txt_s_price.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_s_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_s_price.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_s_price.LineThickness = 3;
            this.txt_s_price.Location = new System.Drawing.Point(194, 127);
            this.txt_s_price.Margin = new System.Windows.Forms.Padding(5);
            this.txt_s_price.Name = "txt_s_price";
            this.txt_s_price.Size = new System.Drawing.Size(179, 54);
            this.txt_s_price.TabIndex = 9;
            this.txt_s_price.Text = "S_Price";
            this.txt_s_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_s_price.OnValueChanged += new System.EventHandler(this.txt_s_price_OnValueChanged);
            // 
            // txt_b_price
            // 
            this.txt_b_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_b_price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b_price.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_b_price.HintForeColor = System.Drawing.Color.Empty;
            this.txt_b_price.HintText = "";
            this.txt_b_price.isPassword = false;
            this.txt_b_price.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_b_price.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_b_price.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_b_price.LineThickness = 3;
            this.txt_b_price.Location = new System.Drawing.Point(194, 63);
            this.txt_b_price.Margin = new System.Windows.Forms.Padding(5);
            this.txt_b_price.Name = "txt_b_price";
            this.txt_b_price.Size = new System.Drawing.Size(179, 54);
            this.txt_b_price.TabIndex = 10;
            this.txt_b_price.Text = "B_Price";
            this.txt_b_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_b_price.OnValueChanged += new System.EventHandler(this.txt_b_price_OnValueChanged);
            // 
            // txt_med_name
            // 
            this.txt_med_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_med_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_med_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_med_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_med_name.HintText = "";
            this.txt_med_name.isPassword = false;
            this.txt_med_name.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_med_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_med_name.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_med_name.LineThickness = 3;
            this.txt_med_name.Location = new System.Drawing.Point(8, 63);
            this.txt_med_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_med_name.Name = "txt_med_name";
            this.txt_med_name.Size = new System.Drawing.Size(179, 54);
            this.txt_med_name.TabIndex = 11;
            this.txt_med_name.Text = "MedicineName";
            this.txt_med_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MedicineDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MedicineDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MedicineDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MedicineDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicineDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MedicineDataGridView.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicineDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MedicineDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.MedicineDataGridView.EnableHeadersVisualStyles = false;
            this.MedicineDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineDataGridView.Location = new System.Drawing.Point(381, 0);
            this.MedicineDataGridView.Name = "MedicineDataGridView";
            this.MedicineDataGridView.RowHeadersVisible = false;
            this.MedicineDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineDataGridView.Size = new System.Drawing.Size(493, 465);
            this.MedicineDataGridView.TabIndex = 18;
            this.MedicineDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MedicineDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MedicineDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MedicineDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MedicineDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MedicineDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MedicineDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MedicineDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MedicineDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MedicineDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MedicineDataGridView.ThemeStyle.HeaderStyle.Height = 44;
            this.MedicineDataGridView.ThemeStyle.ReadOnly = false;
            this.MedicineDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MedicineDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MedicineDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.MedicineDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MedicineDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineDataGridView_CellContentClick);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 465);
            this.Controls.Add(this.MedicineDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.company_cmbx);
            this.Controls.Add(this.dtpkr_exp_date);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_s_price);
            this.Controls.Add(this.txt_b_price);
            this.Controls.Add(this.txt_med_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2Button btn_del;
        private Guna.UI2.WinForms.Guna2Button btn_updt;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2ComboBox company_cmbx;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkr_exp_date;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_qty;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_s_price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_b_price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_med_name;
        private Guna.UI2.WinForms.Guna2DataGridView MedicineDataGridView;
    }
}