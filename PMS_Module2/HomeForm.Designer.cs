namespace PMS_Module2
{
    partial class HomeForm
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
            this.lab_main = new System.Windows.Forms.Label();
            this.lab_medForm = new System.Windows.Forms.Label();
            this.lab_cmpnyForm = new System.Windows.Forms.Label();
            this.lab_billForm = new System.Windows.Forms.Label();
            this.lab_EmpForm = new System.Windows.Forms.Label();
            this.lab_exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_main
            // 
            this.lab_main.AutoSize = true;
            this.lab_main.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_main.Location = new System.Drawing.Point(309, 64);
            this.lab_main.Name = "lab_main";
            this.lab_main.Size = new System.Drawing.Size(162, 37);
            this.lab_main.TabIndex = 0;
            this.lab_main.Text = "Main Menu";
            // 
            // lab_medForm
            // 
            this.lab_medForm.AutoSize = true;
            this.lab_medForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_medForm.Location = new System.Drawing.Point(99, 169);
            this.lab_medForm.Name = "lab_medForm";
            this.lab_medForm.Size = new System.Drawing.Size(135, 37);
            this.lab_medForm.TabIndex = 0;
            this.lab_medForm.Text = "Medicine";
            this.lab_medForm.Click += new System.EventHandler(this.lab_medForm_Click);
            // 
            // lab_cmpnyForm
            // 
            this.lab_cmpnyForm.AutoSize = true;
            this.lab_cmpnyForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_cmpnyForm.Location = new System.Drawing.Point(99, 324);
            this.lab_cmpnyForm.Name = "lab_cmpnyForm";
            this.lab_cmpnyForm.Size = new System.Drawing.Size(159, 37);
            this.lab_cmpnyForm.TabIndex = 0;
            this.lab_cmpnyForm.Text = "Companies";
            this.lab_cmpnyForm.Click += new System.EventHandler(this.lab_cmpnyForm_Click);
            // 
            // lab_billForm
            // 
            this.lab_billForm.AutoSize = true;
            this.lab_billForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_billForm.Location = new System.Drawing.Point(568, 324);
            this.lab_billForm.Name = "lab_billForm";
            this.lab_billForm.Size = new System.Drawing.Size(99, 37);
            this.lab_billForm.TabIndex = 0;
            this.lab_billForm.Text = "Billing";
            this.lab_billForm.Click += new System.EventHandler(this.lab_billForm_Click);
            // 
            // lab_EmpForm
            // 
            this.lab_EmpForm.AutoSize = true;
            this.lab_EmpForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_EmpForm.Location = new System.Drawing.Point(568, 169);
            this.lab_EmpForm.Name = "lab_EmpForm";
            this.lab_EmpForm.Size = new System.Drawing.Size(143, 37);
            this.lab_EmpForm.TabIndex = 0;
            this.lab_EmpForm.Text = "Employee";
            this.lab_EmpForm.Click += new System.EventHandler(this.lab_EmpForm_Click);
            // 
            // lab_exit
            // 
            this.lab_exit.AutoSize = true;
            this.lab_exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_exit.Location = new System.Drawing.Point(341, 392);
            this.lab_exit.Name = "lab_exit";
            this.lab_exit.Size = new System.Drawing.Size(65, 37);
            this.lab_exit.TabIndex = 0;
            this.lab_exit.Text = "Exit";
            this.lab_exit.Click += new System.EventHandler(this.lab_exit_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 476);
            this.Controls.Add(this.lab_EmpForm);
            this.Controls.Add(this.lab_exit);
            this.Controls.Add(this.lab_billForm);
            this.Controls.Add(this.lab_cmpnyForm);
            this.Controls.Add(this.lab_medForm);
            this.Controls.Add(this.lab_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_main;
        private System.Windows.Forms.Label lab_medForm;
        private System.Windows.Forms.Label lab_cmpnyForm;
        private System.Windows.Forms.Label lab_billForm;
        private System.Windows.Forms.Label lab_EmpForm;
        private System.Windows.Forms.Label lab_exit;
    }
}