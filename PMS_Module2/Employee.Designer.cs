namespace PMS_Module2
{
    partial class Employee
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
            this.EmployeeDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.gender_cmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_emp_salary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_emp_age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_emp_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_emp_phn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_emp_addr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_delEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updtEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addEmp = new Guna.UI2.WinForms.Guna2Button();
            this.txt_emp_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.EmployeeDataGridView.ColumnHeadersHeight = 44;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmployeeDataGridView.EnableHeadersVisualStyles = false;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.Location = new System.Drawing.Point(390, 0);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(493, 460);
            this.EmployeeDataGridView.TabIndex = 30;
            this.EmployeeDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Height = 44;
            this.EmployeeDataGridView.ThemeStyle.ReadOnly = false;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Employees";
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(129, 403);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(109, 45);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "BACK";
            // 
            // gender_cmbx
            // 
            this.gender_cmbx.BackColor = System.Drawing.Color.Transparent;
            this.gender_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_cmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender_cmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender_cmbx.FocusedState.Parent = this.gender_cmbx;
            this.gender_cmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gender_cmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gender_cmbx.HoverState.Parent = this.gender_cmbx;
            this.gender_cmbx.ItemHeight = 30;
            this.gender_cmbx.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_cmbx.ItemsAppearance.Parent = this.gender_cmbx;
            this.gender_cmbx.Location = new System.Drawing.Point(194, 99);
            this.gender_cmbx.Name = "gender_cmbx";
            this.gender_cmbx.ShadowDecoration.Parent = this.gender_cmbx;
            this.gender_cmbx.Size = new System.Drawing.Size(179, 36);
            this.gender_cmbx.TabIndex = 25;
            // 
            // txt_emp_salary
            // 
            this.txt_emp_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emp_salary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_salary.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_salary.HintForeColor = System.Drawing.Color.Empty;
            this.txt_emp_salary.HintText = "";
            this.txt_emp_salary.isPassword = false;
            this.txt_emp_salary.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_salary.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_emp_salary.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_salary.LineThickness = 3;
            this.txt_emp_salary.Location = new System.Drawing.Point(5, 209);
            this.txt_emp_salary.Margin = new System.Windows.Forms.Padding(5);
            this.txt_emp_salary.Name = "txt_emp_salary";
            this.txt_emp_salary.Size = new System.Drawing.Size(179, 54);
            this.txt_emp_salary.TabIndex = 20;
            this.txt_emp_salary.Text = "Employee Salary";
            this.txt_emp_salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_emp_age
            // 
            this.txt_emp_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emp_age.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_age.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_age.HintForeColor = System.Drawing.Color.Empty;
            this.txt_emp_age.HintText = "";
            this.txt_emp_age.isPassword = false;
            this.txt_emp_age.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_age.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_emp_age.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_age.LineThickness = 3;
            this.txt_emp_age.Location = new System.Drawing.Point(5, 145);
            this.txt_emp_age.Margin = new System.Windows.Forms.Padding(5);
            this.txt_emp_age.Name = "txt_emp_age";
            this.txt_emp_age.Size = new System.Drawing.Size(179, 54);
            this.txt_emp_age.TabIndex = 21;
            this.txt_emp_age.Text = "Employee Age";
            this.txt_emp_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emp_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_emp_name.HintText = "";
            this.txt_emp_name.isPassword = false;
            this.txt_emp_name.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_emp_name.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_name.LineThickness = 3;
            this.txt_emp_name.Location = new System.Drawing.Point(5, 81);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(173, 54);
            this.txt_emp_name.TabIndex = 22;
            this.txt_emp_name.Text = "Employee Name";
            this.txt_emp_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_emp_phn
            // 
            this.txt_emp_phn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emp_phn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_phn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_phn.HintForeColor = System.Drawing.Color.Empty;
            this.txt_emp_phn.HintText = "";
            this.txt_emp_phn.isPassword = false;
            this.txt_emp_phn.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_phn.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_emp_phn.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_phn.LineThickness = 3;
            this.txt_emp_phn.Location = new System.Drawing.Point(194, 145);
            this.txt_emp_phn.Margin = new System.Windows.Forms.Padding(5);
            this.txt_emp_phn.Name = "txt_emp_phn";
            this.txt_emp_phn.Size = new System.Drawing.Size(179, 54);
            this.txt_emp_phn.TabIndex = 22;
            this.txt_emp_phn.Text = "Phone No";
            this.txt_emp_phn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_emp_addr
            // 
            this.txt_emp_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emp_addr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_addr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_addr.HintForeColor = System.Drawing.Color.Empty;
            this.txt_emp_addr.HintText = "";
            this.txt_emp_addr.isPassword = false;
            this.txt_emp_addr.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_addr.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_emp_addr.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_addr.LineThickness = 3;
            this.txt_emp_addr.Location = new System.Drawing.Point(194, 209);
            this.txt_emp_addr.Margin = new System.Windows.Forms.Padding(5);
            this.txt_emp_addr.Name = "txt_emp_addr";
            this.txt_emp_addr.Size = new System.Drawing.Size(179, 54);
            this.txt_emp_addr.TabIndex = 22;
            this.txt_emp_addr.Text = "Employee Address";
            this.txt_emp_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_delEmp
            // 
            this.btn_delEmp.CheckedState.Parent = this.btn_delEmp;
            this.btn_delEmp.CustomImages.Parent = this.btn_delEmp;
            this.btn_delEmp.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delEmp.ForeColor = System.Drawing.Color.White;
            this.btn_delEmp.HoverState.Parent = this.btn_delEmp;
            this.btn_delEmp.Location = new System.Drawing.Point(244, 333);
            this.btn_delEmp.Name = "btn_delEmp";
            this.btn_delEmp.ShadowDecoration.Parent = this.btn_delEmp;
            this.btn_delEmp.Size = new System.Drawing.Size(109, 45);
            this.btn_delEmp.TabIndex = 31;
            this.btn_delEmp.Text = "DELETE";
            this.btn_delEmp.Click += new System.EventHandler(this.btn_delEmp_Click);
            // 
            // btn_updtEmp
            // 
            this.btn_updtEmp.CheckedState.Parent = this.btn_updtEmp;
            this.btn_updtEmp.CustomImages.Parent = this.btn_updtEmp;
            this.btn_updtEmp.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_updtEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_updtEmp.ForeColor = System.Drawing.Color.White;
            this.btn_updtEmp.HoverState.Parent = this.btn_updtEmp;
            this.btn_updtEmp.Location = new System.Drawing.Point(129, 333);
            this.btn_updtEmp.Name = "btn_updtEmp";
            this.btn_updtEmp.ShadowDecoration.Parent = this.btn_updtEmp;
            this.btn_updtEmp.Size = new System.Drawing.Size(109, 45);
            this.btn_updtEmp.TabIndex = 32;
            this.btn_updtEmp.Text = "UPDATE";
            this.btn_updtEmp.Click += new System.EventHandler(this.btn_updtEmp_Click);
            // 
            // btn_addEmp
            // 
            this.btn_addEmp.CheckedState.Parent = this.btn_addEmp;
            this.btn_addEmp.CustomImages.Parent = this.btn_addEmp;
            this.btn_addEmp.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addEmp.ForeColor = System.Drawing.Color.White;
            this.btn_addEmp.HoverState.Parent = this.btn_addEmp;
            this.btn_addEmp.Location = new System.Drawing.Point(14, 333);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.ShadowDecoration.Parent = this.btn_addEmp;
            this.btn_addEmp.Size = new System.Drawing.Size(109, 45);
            this.btn_addEmp.TabIndex = 33;
            this.btn_addEmp.Text = "ADD";
            this.btn_addEmp.Click += new System.EventHandler(this.btn_addEmp_Click);
            // 
            // txt_emp_pass
            // 
            this.txt_emp_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_emp_pass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_pass.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_pass.HintForeColor = System.Drawing.Color.Empty;
            this.txt_emp_pass.HintText = "";
            this.txt_emp_pass.isPassword = true;
            this.txt_emp_pass.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_emp_pass.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_emp_pass.LineThickness = 3;
            this.txt_emp_pass.Location = new System.Drawing.Point(5, 271);
            this.txt_emp_pass.Margin = new System.Windows.Forms.Padding(5);
            this.txt_emp_pass.Name = "txt_emp_pass";
            this.txt_emp_pass.Size = new System.Drawing.Size(179, 54);
            this.txt_emp_pass.TabIndex = 20;
            this.txt_emp_pass.Text = "Employee Password";
            this.txt_emp_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 460);
            this.Controls.Add(this.btn_delEmp);
            this.Controls.Add(this.btn_updtEmp);
            this.Controls.Add(this.btn_addEmp);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gender_cmbx);
            this.Controls.Add(this.txt_emp_pass);
            this.Controls.Add(this.txt_emp_salary);
            this.Controls.Add(this.txt_emp_age);
            this.Controls.Add(this.txt_emp_addr);
            this.Controls.Add(this.txt_emp_phn);
            this.Controls.Add(this.txt_emp_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Guna.UI2.WinForms.Guna2ComboBox gender_cmbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_emp_salary;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_emp_age;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_emp_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_emp_phn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_emp_addr;
        private Guna.UI2.WinForms.Guna2Button btn_delEmp;
        private Guna.UI2.WinForms.Guna2Button btn_updtEmp;
        private Guna.UI2.WinForms.Guna2Button btn_addEmp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_emp_pass;
    }
}