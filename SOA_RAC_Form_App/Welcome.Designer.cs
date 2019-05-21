namespace SOA_RAC_Form_App
{
    partial class Welcome
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersBtn = new System.Windows.Forms.Button();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.CompaniesBtn = new System.Windows.Forms.Button();
            this.CarsBtn = new System.Windows.Forms.Button();
            this.TracsantionsBtn = new System.Windows.Forms.Button();
            this.IncomeReportBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.IncomeReportBtn);
            this.splitContainer1.Panel2.Controls.Add(this.CustomersBtn);
            this.splitContainer1.Panel2.Controls.Add(this.RequestBtn);
            this.splitContainer1.Panel2.Controls.Add(this.UsersBtn);
            this.splitContainer1.Panel2.Controls.Add(this.CompaniesBtn);
            this.splitContainer1.Panel2.Controls.Add(this.CarsBtn);
            this.splitContainer1.Panel2.Controls.Add(this.TracsantionsBtn);
            this.splitContainer1.Size = new System.Drawing.Size(782, 403);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SOA RENT A CAR";
            // 
            // CustomersBtn
            // 
            this.CustomersBtn.Location = new System.Drawing.Point(88, 120);
            this.CustomersBtn.Name = "CustomersBtn";
            this.CustomersBtn.Size = new System.Drawing.Size(200, 50);
            this.CustomersBtn.TabIndex = 3;
            this.CustomersBtn.Text = "CUSTOMERS";
            this.CustomersBtn.UseVisualStyleBackColor = true;
            this.CustomersBtn.Click += new System.EventHandler(this.CustomersBtn_Click);
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(296, 120);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(200, 50);
            this.RequestBtn.TabIndex = 4;
            this.RequestBtn.Text = "RENTING REQUESTS";
            this.RequestBtn.UseVisualStyleBackColor = true;
            // 
            // UsersBtn
            // 
            this.UsersBtn.Location = new System.Drawing.Point(504, 120);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(200, 50);
            this.UsersBtn.TabIndex = 5;
            this.UsersBtn.Text = "USERS";
            this.UsersBtn.UseVisualStyleBackColor = true;
            // 
            // CompaniesBtn
            // 
            this.CompaniesBtn.Location = new System.Drawing.Point(88, 64);
            this.CompaniesBtn.Name = "CompaniesBtn";
            this.CompaniesBtn.Size = new System.Drawing.Size(200, 50);
            this.CompaniesBtn.TabIndex = 0;
            this.CompaniesBtn.Text = "COMPANIES";
            this.CompaniesBtn.UseVisualStyleBackColor = true;
            this.CompaniesBtn.Click += new System.EventHandler(this.CompaniesBtn_Click);
            // 
            // CarsBtn
            // 
            this.CarsBtn.Location = new System.Drawing.Point(296, 64);
            this.CarsBtn.Name = "CarsBtn";
            this.CarsBtn.Size = new System.Drawing.Size(200, 50);
            this.CarsBtn.TabIndex = 1;
            this.CarsBtn.Text = "CARS";
            this.CarsBtn.UseVisualStyleBackColor = true;
            this.CarsBtn.Click += new System.EventHandler(this.CarsBtn_Click);
            // 
            // TracsantionsBtn
            // 
            this.TracsantionsBtn.Location = new System.Drawing.Point(504, 64);
            this.TracsantionsBtn.Name = "TracsantionsBtn";
            this.TracsantionsBtn.Size = new System.Drawing.Size(200, 50);
            this.TracsantionsBtn.TabIndex = 2;
            this.TracsantionsBtn.Text = "TRANSACTIONS";
            this.TracsantionsBtn.UseVisualStyleBackColor = true;
            this.TracsantionsBtn.Click += new System.EventHandler(this.TracsantionsBtn_Click);
            // 
            // IncomeReportBtn
            // 
            this.IncomeReportBtn.Location = new System.Drawing.Point(88, 176);
            this.IncomeReportBtn.Name = "IncomeReportBtn";
            this.IncomeReportBtn.Size = new System.Drawing.Size(200, 50);
            this.IncomeReportBtn.TabIndex = 6;
            this.IncomeReportBtn.Text = "INCOME REPORT";
            this.IncomeReportBtn.UseVisualStyleBackColor = true;
            this.IncomeReportBtn.Click += new System.EventHandler(this.IncomeReportBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "VHICLE STATS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "VHICLE STATS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SOA RAC";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TracsantionsBtn;
        private System.Windows.Forms.Button CarsBtn;
        private System.Windows.Forms.Button CompaniesBtn;
        private System.Windows.Forms.Button CustomersBtn;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button IncomeReportBtn;
    }
}

