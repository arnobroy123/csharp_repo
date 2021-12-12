namespace BankAdmin
{
    partial class DeptWindow
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
            this.deptlist_Grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.buttonAccountent = new System.Windows.Forms.Button();
            this.buttonMngr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deptlist_Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deptlist_Grid
            // 
            this.deptlist_Grid.AllowUserToAddRows = false;
            this.deptlist_Grid.AllowUserToDeleteRows = false;
            this.deptlist_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptlist_Grid.Location = new System.Drawing.Point(318, 22);
            this.deptlist_Grid.Name = "deptlist_Grid";
            this.deptlist_Grid.ReadOnly = true;
            this.deptlist_Grid.Size = new System.Drawing.Size(444, 253);
            this.deptlist_Grid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(22, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStaff);
            this.groupBox1.Controls.Add(this.buttonCashier);
            this.groupBox1.Controls.Add(this.buttonAccountent);
            this.groupBox1.Controls.Add(this.buttonMngr);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info By Position";
            // 
            // buttonStaff
            // 
            this.buttonStaff.Location = new System.Drawing.Point(71, 193);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(113, 27);
            this.buttonStaff.TabIndex = 5;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonCashier
            // 
            this.buttonCashier.Location = new System.Drawing.Point(71, 144);
            this.buttonCashier.Name = "buttonCashier";
            this.buttonCashier.Size = new System.Drawing.Size(113, 27);
            this.buttonCashier.TabIndex = 4;
            this.buttonCashier.Text = "Cashier";
            this.buttonCashier.UseVisualStyleBackColor = true;
            this.buttonCashier.Click += new System.EventHandler(this.buttonCashier_Click);
            // 
            // buttonAccountent
            // 
            this.buttonAccountent.Location = new System.Drawing.Point(71, 99);
            this.buttonAccountent.Name = "buttonAccountent";
            this.buttonAccountent.Size = new System.Drawing.Size(113, 27);
            this.buttonAccountent.TabIndex = 1;
            this.buttonAccountent.Text = "Accountent";
            this.buttonAccountent.UseVisualStyleBackColor = true;
            this.buttonAccountent.Click += new System.EventHandler(this.buttonAccountent_Click);
            // 
            // buttonMngr
            // 
            this.buttonMngr.Location = new System.Drawing.Point(71, 49);
            this.buttonMngr.Name = "buttonMngr";
            this.buttonMngr.Size = new System.Drawing.Size(113, 27);
            this.buttonMngr.TabIndex = 0;
            this.buttonMngr.Text = "Manager";
            this.buttonMngr.UseVisualStyleBackColor = true;
            this.buttonMngr.Click += new System.EventHandler(this.buttonMngr_Click);
            // 
            // DeptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deptlist_Grid);
            this.Name = "DeptWindow";
            this.Text = "DeptWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeptWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.deptlist_Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deptlist_Grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMngr;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Button buttonAccountent;
    }
}