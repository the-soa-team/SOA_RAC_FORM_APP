namespace SOA_RAC_Form_App
{
    partial class Cars
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LicenceAgeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.CompaniesGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ListBtn = new System.Windows.Forms.Button();
            this.DriverAgeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DailyMaxKmBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DailyMaxKmBox);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.DriverAgeBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.SaveBtn);
            this.splitContainer1.Panel1.Controls.Add(this.LicenceAgeBox);
            this.splitContainer1.Panel1.Controls.Add(this.ModelBox);
            this.splitContainer1.Panel1.Controls.Add(this.BrandBox);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 653);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(24, 280);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(288, 40);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Save Form";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LicenceAgeBox
            // 
            this.LicenceAgeBox.Location = new System.Drawing.Point(112, 152);
            this.LicenceAgeBox.Name = "LicenceAgeBox";
            this.LicenceAgeBox.Size = new System.Drawing.Size(200, 22);
            this.LicenceAgeBox.TabIndex = 8;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(112, 112);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(200, 22);
            this.ModelBox.TabIndex = 6;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(112, 72);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(200, 22);
            this.BrandBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Licence Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD CAR";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.CompaniesGridView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(758, 653);
            this.splitContainer2.SplitterDistance = 325;
            this.splitContainer2.TabIndex = 1;
            // 
            // CompaniesGridView
            // 
            this.CompaniesGridView.AllowUserToAddRows = false;
            this.CompaniesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompaniesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompaniesGridView.Location = new System.Drawing.Point(0, 0);
            this.CompaniesGridView.MultiSelect = false;
            this.CompaniesGridView.Name = "CompaniesGridView";
            this.CompaniesGridView.ReadOnly = true;
            this.CompaniesGridView.RowTemplate.Height = 24;
            this.CompaniesGridView.Size = new System.Drawing.Size(758, 325);
            this.CompaniesGridView.TabIndex = 0;
            this.CompaniesGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompaniesGridView_RowEnter);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ListBtn);
            this.splitContainer3.Size = new System.Drawing.Size(758, 324);
            this.splitContainer3.SplitterDistance = 162;
            this.splitContainer3.TabIndex = 0;
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(0, 0);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(760, 48);
            this.ListBtn.TabIndex = 0;
            this.ListBtn.Text = "List Companies";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // DriverAgeBox
            // 
            this.DriverAgeBox.Location = new System.Drawing.Point(112, 192);
            this.DriverAgeBox.Name = "DriverAgeBox";
            this.DriverAgeBox.Size = new System.Drawing.Size(200, 22);
            this.DriverAgeBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Driver Age";
            // 
            // DailyMaxKmBox
            // 
            this.DailyMaxKmBox.Location = new System.Drawing.Point(112, 232);
            this.DailyMaxKmBox.Name = "DailyMaxKmBox";
            this.DailyMaxKmBox.Size = new System.Drawing.Size(200, 22);
            this.DailyMaxKmBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Daily Max Km";
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cars";
            this.Text = "CARS";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesGridView)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox LicenceAgeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView CompaniesGridView;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.TextBox DriverAgeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DailyMaxKmBox;
        private System.Windows.Forms.Label label6;
    }
}