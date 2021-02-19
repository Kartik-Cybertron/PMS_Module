namespace PMS_Module2
{
    partial class Login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txtbx_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbx_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(77, 246);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(160, 45);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbx_password.HintForeColor = System.Drawing.Color.Empty;
            this.txtbx_password.HintText = "";
            this.txtbx_password.isPassword = true;
            this.txtbx_password.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbx_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbx_password.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbx_password.LineThickness = 3;
            this.txtbx_password.Location = new System.Drawing.Point(31, 186);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(267, 44);
            this.txtbx_password.TabIndex = 4;
            this.txtbx_password.Text = "Password";
            this.txtbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbx_username
            // 
            this.txtbx_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_username.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_username.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbx_username.HintForeColor = System.Drawing.Color.Empty;
            this.txtbx_username.HintText = "";
            this.txtbx_username.isPassword = false;
            this.txtbx_username.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbx_username.LineIdleColor = System.Drawing.Color.Gray;
            this.txtbx_username.LineMouseHoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbx_username.LineThickness = 3;
            this.txtbx_username.Location = new System.Drawing.Point(31, 102);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(267, 44);
            this.txtbx_username.TabIndex = 5;
            this.txtbx_username.Text = "User Id";
            this.txtbx_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 364);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbx_password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbx_username;
        private System.Windows.Forms.Label label1;
    }
}