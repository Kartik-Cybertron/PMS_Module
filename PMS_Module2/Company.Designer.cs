namespace PMS_Module2
{
    partial class Company
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
            this.btn_delEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updtEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addEmp = new Guna.UI2.WinForms.Guna2Button();
            this.CompanyDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.txt_cmpny_addr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_cmpny_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_cmpny_phn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_cmpny_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Medicine Manufacturer";
            // 
            // btn_delEmp
            // 
            this.btn_delEmp.CheckedState.Parent = this.btn_delEmp;
            this.btn_delEmp.CustomImages.Parent = this.btn_delEmp;
            this.btn_delEmp.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delEmp.ForeColor = System.Drawing.Color.White;
            this.btn_delEmp.HoverState.Parent = this.btn_delEmp;
            this.btn_delEmp.Location = new System.Drawing.Point(241, 333);
            this.btn_delEmp.Name = "btn_delEmp";
            this.btn_delEmp.ShadowDecoration.Parent = this.btn_delEmp;
            this.btn_delEmp.Size = new System.Drawing.Size(109, 45);
            this.btn_delEmp.TabIndex = 43;
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
            this.btn_updtEmp.Location = new System.Drawing.Point(126, 333);
            this.btn_updtEmp.Name = "btn_updtEmp";
            this.btn_updtEmp.ShadowDecoration.Parent = this.btn_updtEmp;
            this.btn_updtEmp.Size = new System.Drawing.Size(109, 45);
            this.btn_updtEmp.TabIndex = 44;
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
            this.btn_addEmp.Location = new System.Drawing.Point(11, 333);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.ShadowDecoration.Parent = this.btn_addEmp;
            this.btn_addEmp.Size = new System.Drawing.Size(109, 45);
            this.btn_addEmp.TabIndex = 45;
            this.btn_addEmp.Text = "ADD";
            this.btn_addEmp.Click += new System.EventHandler(this.btn_addEmp_Click);
            // 
            // CompanyDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CompanyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CompanyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CompanyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CompanyDataGridView.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CompanyDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CompanyDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CompanyDataGridView.EnableHeadersVisualStyles = false;
            this.CompanyDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CompanyDataGridView.Location = new System.Drawing.Point(412, 0);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.RowHeadersVisible = false;
            this.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompanyDataGridView.Size = new System.Drawing.Size(493, 541);
            this.CompanyDataGridView.TabIndex = 42;
            this.CompanyDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CompanyDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.Height = 44;
            this.CompanyDataGridView.ThemeStyle.ReadOnly = false;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CompanyDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CompanyDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CompanyDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CompanyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDataGridView_CellContentClick);
            // 
            // btn_back
            // 
            this.btn_back.CheckedState.Parent = this.btn_back;
            this.btn_back.CustomImages.Parent = this.btn_back;
            this.btn_back.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.HoverState.Parent = this.btn_back;
            this.btn_back.Location = new System.Drawing.Point(126, 403);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Parent = this.btn_back;
            this.btn_back.Size = new System.Drawing.Size(109, 45);
            this.btn_back.TabIndex = 41;
            this.btn_back.Text = "BACK";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_cmpny_addr
            // 
            this.txt_cmpny_addr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cmpny_addr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmpny_addr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_addr.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cmpny_addr.HintText = "";
            this.txt_cmpny_addr.isPassword = false;
            this.txt_cmpny_addr.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_addr.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cmpny_addr.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_addr.LineThickness = 3;
            this.txt_cmpny_addr.Location = new System.Drawing.Point(209, 145);
            this.txt_cmpny_addr.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cmpny_addr.Name = "txt_cmpny_addr";
            this.txt_cmpny_addr.Size = new System.Drawing.Size(179, 54);
            this.txt_cmpny_addr.TabIndex = 35;
            this.txt_cmpny_addr.Text = "Company Address";
            this.txt_cmpny_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cmpny_name
            // 
            this.txt_cmpny_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cmpny_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmpny_name.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_name.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cmpny_name.HintText = "";
            this.txt_cmpny_name.isPassword = false;
            this.txt_cmpny_name.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_name.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cmpny_name.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_name.LineThickness = 3;
            this.txt_cmpny_name.Location = new System.Drawing.Point(2, 145);
            this.txt_cmpny_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cmpny_name.Name = "txt_cmpny_name";
            this.txt_cmpny_name.Size = new System.Drawing.Size(179, 54);
            this.txt_cmpny_name.TabIndex = 36;
            this.txt_cmpny_name.Text = "Company Name";
            this.txt_cmpny_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cmpny_phn
            // 
            this.txt_cmpny_phn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cmpny_phn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmpny_phn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_phn.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cmpny_phn.HintText = "";
            this.txt_cmpny_phn.isPassword = false;
            this.txt_cmpny_phn.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_phn.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cmpny_phn.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_phn.LineThickness = 3;
            this.txt_cmpny_phn.Location = new System.Drawing.Point(209, 81);
            this.txt_cmpny_phn.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cmpny_phn.Name = "txt_cmpny_phn";
            this.txt_cmpny_phn.Size = new System.Drawing.Size(179, 54);
            this.txt_cmpny_phn.TabIndex = 38;
            this.txt_cmpny_phn.Text = "Phone No";
            this.txt_cmpny_phn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_cmpny_id
            // 
            this.txt_cmpny_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cmpny_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmpny_id.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_id.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cmpny_id.HintText = "";
            this.txt_cmpny_id.isPassword = false;
            this.txt_cmpny_id.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_id.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cmpny_id.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cmpny_id.LineThickness = 3;
            this.txt_cmpny_id.Location = new System.Drawing.Point(2, 81);
            this.txt_cmpny_id.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cmpny_id.Name = "txt_cmpny_id";
            this.txt_cmpny_id.Size = new System.Drawing.Size(173, 54);
            this.txt_cmpny_id.TabIndex = 39;
            this.txt_cmpny_id.Text = "Company Id";
            this.txt_cmpny_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 541);
            this.Controls.Add(this.btn_delEmp);
            this.Controls.Add(this.btn_updtEmp);
            this.Controls.Add(this.btn_addEmp);
            this.Controls.Add(this.CompanyDataGridView);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_cmpny_addr);
            this.Controls.Add(this.txt_cmpny_name);
            this.Controls.Add(this.txt_cmpny_phn);
            this.Controls.Add(this.txt_cmpny_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_delEmp;
        private Guna.UI2.WinForms.Guna2Button btn_updtEmp;
        private Guna.UI2.WinForms.Guna2Button btn_addEmp;
        private Guna.UI2.WinForms.Guna2DataGridView CompanyDataGridView;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cmpny_addr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cmpny_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cmpny_phn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cmpny_id;
    }
}