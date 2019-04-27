namespace SOA_RAC_Form_App
{
    partial class CarsForm
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
            this.FormGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelUpdateBtn = new System.Windows.Forms.Button();
            this.HasAirBagCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RentPriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumSeatsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.LuggageVolumeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LicenceAgeBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentKmBox = new System.Windows.Forms.TextBox();
            this.DriverAgeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DailyMaxKmBox = new System.Windows.Forms.TextBox();
            this.EntityGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ListBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.FormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntityGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormGroupBox
            // 
            this.FormGroupBox.Controls.Add(this.CancelUpdateBtn);
            this.FormGroupBox.Controls.Add(this.HasAirBagCombo);
            this.FormGroupBox.Controls.Add(this.label1);
            this.FormGroupBox.Controls.Add(this.RentPriceBox);
            this.FormGroupBox.Controls.Add(this.label2);
            this.FormGroupBox.Controls.Add(this.label11);
            this.FormGroupBox.Controls.Add(this.label3);
            this.FormGroupBox.Controls.Add(this.NumSeatsBox);
            this.FormGroupBox.Controls.Add(this.label5);
            this.FormGroupBox.Controls.Add(this.label10);
            this.FormGroupBox.Controls.Add(this.BrandBox);
            this.FormGroupBox.Controls.Add(this.LuggageVolumeBox);
            this.FormGroupBox.Controls.Add(this.ModelBox);
            this.FormGroupBox.Controls.Add(this.label9);
            this.FormGroupBox.Controls.Add(this.LicenceAgeBox);
            this.FormGroupBox.Controls.Add(this.SaveBtn);
            this.FormGroupBox.Controls.Add(this.label8);
            this.FormGroupBox.Controls.Add(this.label4);
            this.FormGroupBox.Controls.Add(this.CurrentKmBox);
            this.FormGroupBox.Controls.Add(this.DriverAgeBox);
            this.FormGroupBox.Controls.Add(this.label7);
            this.FormGroupBox.Controls.Add(this.label6);
            this.FormGroupBox.Controls.Add(this.DailyMaxKmBox);
            this.FormGroupBox.Location = new System.Drawing.Point(8, 24);
            this.FormGroupBox.Name = "FormGroupBox";
            this.FormGroupBox.Size = new System.Drawing.Size(336, 608);
            this.FormGroupBox.TabIndex = 24;
            this.FormGroupBox.TabStop = false;
            this.FormGroupBox.Text = "ADD CAR";
            // 
            // CancelUpdateBtn
            // 
            this.CancelUpdateBtn.Enabled = false;
            this.CancelUpdateBtn.Location = new System.Drawing.Point(8, 488);
            this.CancelUpdateBtn.Name = "CancelUpdateBtn";
            this.CancelUpdateBtn.Size = new System.Drawing.Size(312, 40);
            this.CancelUpdateBtn.TabIndex = 25;
            this.CancelUpdateBtn.Text = "Cancel Update";
            this.CancelUpdateBtn.UseVisualStyleBackColor = true;
            this.CancelUpdateBtn.Click += new System.EventHandler(this.CancelUpdateBtn_Click);
            // 
            // HasAirBagCombo
            // 
            this.HasAirBagCombo.FormattingEnabled = true;
            this.HasAirBagCombo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.HasAirBagCombo.Location = new System.Drawing.Point(120, 272);
            this.HasAirBagCombo.Name = "HasAirBagCombo";
            this.HasAirBagCombo.Size = new System.Drawing.Size(200, 24);
            this.HasAirBagCombo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // RentPriceBox
            // 
            this.RentPriceBox.Location = new System.Drawing.Point(120, 400);
            this.RentPriceBox.Name = "RentPriceBox";
            this.RentPriceBox.Size = new System.Drawing.Size(200, 22);
            this.RentPriceBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rent Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // NumSeatsBox
            // 
            this.NumSeatsBox.Location = new System.Drawing.Point(120, 352);
            this.NumSeatsBox.Name = "NumSeatsBox";
            this.NumSeatsBox.Size = new System.Drawing.Size(200, 22);
            this.NumSeatsBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Licence Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "Number of \r\nSeats";
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(120, 32);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(200, 22);
            this.BrandBox.TabIndex = 5;
            // 
            // LuggageVolumeBox
            // 
            this.LuggageVolumeBox.Location = new System.Drawing.Point(120, 312);
            this.LuggageVolumeBox.Name = "LuggageVolumeBox";
            this.LuggageVolumeBox.Size = new System.Drawing.Size(200, 22);
            this.LuggageVolumeBox.TabIndex = 19;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(120, 72);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(200, 22);
            this.ModelBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Luggage\r\nVolume";
            // 
            // LicenceAgeBox
            // 
            this.LicenceAgeBox.Location = new System.Drawing.Point(120, 112);
            this.LicenceAgeBox.Name = "LicenceAgeBox";
            this.LicenceAgeBox.Size = new System.Drawing.Size(200, 22);
            this.LicenceAgeBox.TabIndex = 8;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(8, 440);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(312, 40);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Create EntityTitle";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Has Airbag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Driver Age";
            // 
            // CurrentKmBox
            // 
            this.CurrentKmBox.Location = new System.Drawing.Point(120, 232);
            this.CurrentKmBox.Name = "CurrentKmBox";
            this.CurrentKmBox.Size = new System.Drawing.Size(200, 22);
            this.CurrentKmBox.TabIndex = 15;
            // 
            // DriverAgeBox
            // 
            this.DriverAgeBox.Location = new System.Drawing.Point(120, 152);
            this.DriverAgeBox.Name = "DriverAgeBox";
            this.DriverAgeBox.Size = new System.Drawing.Size(200, 22);
            this.DriverAgeBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Current Km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Daily Max Km";
            // 
            // DailyMaxKmBox
            // 
            this.DailyMaxKmBox.Location = new System.Drawing.Point(120, 192);
            this.DailyMaxKmBox.Name = "DailyMaxKmBox";
            this.DailyMaxKmBox.Size = new System.Drawing.Size(200, 22);
            this.DailyMaxKmBox.TabIndex = 13;
            // 
            // EntityGridView
            // 
            this.EntityGridView.AllowUserToAddRows = false;
            this.EntityGridView.AllowUserToOrderColumns = true;
            this.EntityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntityGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntityGridView.Location = new System.Drawing.Point(0, 0);
            this.EntityGridView.MultiSelect = false;
            this.EntityGridView.Name = "EntityGridView";
            this.EntityGridView.ReadOnly = true;
            this.EntityGridView.RowTemplate.Height = 24;
            this.EntityGridView.Size = new System.Drawing.Size(750, 440);
            this.EntityGridView.TabIndex = 0;
            this.EntityGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EntityGridView_CellClick);
            this.EntityGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EntityGridView_RowEnter);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(0, 56);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(744, 40);
            this.DeleteBtn.TabIndex = 25;
            this.DeleteBtn.Text = "Delete Selected Car";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ListBtn
            // 
            this.ListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBtn.AutoSize = true;
            this.ListBtn.Location = new System.Drawing.Point(0, 0);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(744, 48);
            this.ListBtn.TabIndex = 0;
            this.ListBtn.Text = "List Cars";
            this.ListBtn.UseVisualStyleBackColor = true;
            this.ListBtn.Click += new System.EventHandler(this.ListBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FormGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 647);
            this.panel1.TabIndex = 25;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 653);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 647);
            this.panel2.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 647);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.EntityGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 440);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.UpdateBtn);
            this.panel4.Controls.Add(this.DeleteBtn);
            this.panel4.Controls.Add(this.ListBtn);
            this.panel4.Location = new System.Drawing.Point(3, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 195);
            this.panel4.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(0, 104);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(744, 40);
            this.UpdateBtn.TabIndex = 26;
            this.UpdateBtn.Text = "Update Selected Car";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "CarsForm";
            this.Text = "CARS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CarsForm_FormClosed);
            this.Load += new System.EventHandler(this.Cars_Load);
            this.FormGroupBox.ResumeLayout(false);
            this.FormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntityGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox LicenceAgeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EntityGridView;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.TextBox DriverAgeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DailyMaxKmBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CurrentKmBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NumSeatsBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LuggageVolumeBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RentPriceBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox FormGroupBox;
        private System.Windows.Forms.ComboBox HasAirBagCombo;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button CancelUpdateBtn;
    }
}