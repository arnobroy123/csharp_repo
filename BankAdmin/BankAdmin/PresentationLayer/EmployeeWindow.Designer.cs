namespace BankAdmin
{
    partial class EmployeeWindow
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
            this.emplist_btn = new System.Windows.Forms.Button();
            this.empdept_btn = new System.Windows.Forms.Button();
            this.AddEmp_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // emplist_btn
            // 
            this.emplist_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.emplist_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplist_btn.Location = new System.Drawing.Point(244, 17);
            this.emplist_btn.Name = "emplist_btn";
            this.emplist_btn.Size = new System.Drawing.Size(138, 39);
            this.emplist_btn.TabIndex = 0;
            this.emplist_btn.Text = "Employee List";
            this.emplist_btn.UseVisualStyleBackColor = false;
            this.emplist_btn.Click += new System.EventHandler(this.emplist_btn_Click);
            // 
            // empdept_btn
            // 
            this.empdept_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.empdept_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdept_btn.Location = new System.Drawing.Point(229, 17);
            this.empdept_btn.Name = "empdept_btn";
            this.empdept_btn.Size = new System.Drawing.Size(169, 39);
            this.empdept_btn.TabIndex = 1;
            this.empdept_btn.Text = "Employee Department";
            this.empdept_btn.UseVisualStyleBackColor = false;
            this.empdept_btn.Click += new System.EventHandler(this.empdept_btn_Click);
            // 
            // AddEmp_btn
            // 
            this.AddEmp_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddEmp_btn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmp_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddEmp_btn.Location = new System.Drawing.Point(244, 16);
            this.AddEmp_btn.Name = "AddEmp_btn";
            this.AddEmp_btn.Size = new System.Drawing.Size(138, 39);
            this.AddEmp_btn.TabIndex = 2;
            this.AddEmp_btn.Text = "Add New Employee";
            this.AddEmp_btn.UseVisualStyleBackColor = false;
            this.AddEmp_btn.Click += new System.EventHandler(this.AddEmp_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.empdept_btn);
            this.panel1.Location = new System.Drawing.Point(-4, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 71);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.emplist_btn);
            this.panel2.Location = new System.Drawing.Point(-4, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 71);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.AddEmp_btn);
            this.panel3.Location = new System.Drawing.Point(-4, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 71);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "EmployeeWindow";
            this.Text = "EmployeeWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeWindow_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emplist_btn;
        private System.Windows.Forms.Button empdept_btn;
        private System.Windows.Forms.Button AddEmp_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}