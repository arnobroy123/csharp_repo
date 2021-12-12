namespace BankAdmin.PresentationLayer
{
    partial class AdminWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_com = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sal = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_com);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_sal);
            this.panel1.Controls.Add(this.emp_btn);
            this.panel1.Location = new System.Drawing.Point(48, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 311);
            this.panel1.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(52, 30);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(389, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Notice Board";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_com
            // 
            this.btn_com.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_com.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_com.Location = new System.Drawing.Point(209, 207);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(146, 46);
            this.btn_com.TabIndex = 2;
            this.btn_com.Text = "Commition";
            this.btn_com.UseVisualStyleBackColor = false;
            this.btn_com.Click += new System.EventHandler(this.btn_com_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Customer Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sal
            // 
            this.btn_sal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_sal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sal.Location = new System.Drawing.Point(209, 124);
            this.btn_sal.Name = "btn_sal";
            this.btn_sal.Size = new System.Drawing.Size(146, 46);
            this.btn_sal.TabIndex = 1;
            this.btn_sal.Text = "Salary";
            this.btn_sal.UseVisualStyleBackColor = false;
            this.btn_sal.Click += new System.EventHandler(this.btn_sal_Click_1);
            // 
            // emp_btn
            // 
            this.emp_btn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emp_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_btn.Location = new System.Drawing.Point(209, 39);
            this.emp_btn.Name = "emp_btn";
            this.emp_btn.Size = new System.Drawing.Size(146, 46);
            this.emp_btn.TabIndex = 0;
            this.emp_btn.Text = "Employee";
            this.emp_btn.UseVisualStyleBackColor = false;
            this.emp_btn.Click += new System.EventHandler(this.emp_btn_Click_1);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 370);
            this.Controls.Add(this.panel1);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminWindow_FormClosing_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_com;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sal;
        private System.Windows.Forms.Button emp_btn;
    }
}