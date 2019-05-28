namespace PhymarcyApp_K30
{
    partial class AddMedicine
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
            this.dtproductDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtValidDate = new System.Windows.Forms.DateTimePicker();
            this.dtgAddMedicine = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.grpTags = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ckReseipt = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmQrCode = new System.Windows.Forms.NumericUpDown();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddMedicine)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQrCode)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtproductDate
            // 
            this.dtproductDate.Location = new System.Drawing.Point(323, 151);
            this.dtproductDate.Name = "dtproductDate";
            this.dtproductDate.Size = new System.Drawing.Size(200, 20);
            this.dtproductDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(319, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Production Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(582, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valid Untill";
            // 
            // dtValidDate
            // 
            this.dtValidDate.Location = new System.Drawing.Point(586, 151);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(200, 20);
            this.dtValidDate.TabIndex = 14;
            // 
            // dtgAddMedicine
            // 
            this.dtgAddMedicine.AllowUserToAddRows = false;
            this.dtgAddMedicine.AllowUserToDeleteRows = false;
            this.dtgAddMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAddMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgAddMedicine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgAddMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAddMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgAddMedicine.Location = new System.Drawing.Point(0, 643);
            this.dtgAddMedicine.Name = "dtgAddMedicine";
            this.dtgAddMedicine.ReadOnly = true;
            this.dtgAddMedicine.Size = new System.Drawing.Size(1194, 299);
            this.dtgAddMedicine.TabIndex = 17;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblError.Location = new System.Drawing.Point(319, 218);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(82, 22);
            this.lblError.TabIndex = 20;
            this.lblError.Text = "Medicine";
            this.lblError.Visible = false;
            // 
            // grpTags
            // 
            this.grpTags.Location = new System.Drawing.Point(830, 113);
            this.grpTags.Name = "grpTags";
            this.grpTags.Size = new System.Drawing.Size(364, 172);
            this.grpTags.TabIndex = 23;
            this.grpTags.TabStop = false;
            this.grpTags.Text = "Selected Tag";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ckReseipt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nmQrCode);
            this.panel1.Controls.Add(this.txtMedicine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 638);
            this.panel1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(27, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 56);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ckReseipt
            // 
            this.ckReseipt.AutoSize = true;
            this.ckReseipt.Location = new System.Drawing.Point(157, 373);
            this.ckReseipt.Name = "ckReseipt";
            this.ckReseipt.Size = new System.Drawing.Size(15, 14);
            this.ckReseipt.TabIndex = 24;
            this.ckReseipt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(32, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "With Reseipt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(23, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Description";
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(27, 238);
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(253, 102);
            this.richDescription.TabIndex = 21;
            this.richDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Qr Code";
            // 
            // nmQrCode
            // 
            this.nmQrCode.Location = new System.Drawing.Point(27, 152);
            this.nmQrCode.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmQrCode.Name = "nmQrCode";
            this.nmQrCode.Size = new System.Drawing.Size(145, 20);
            this.nmQrCode.TabIndex = 19;
            // 
            // txtMedicine
            // 
            this.txtMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicine.Location = new System.Drawing.Point(27, 65);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(188, 26);
            this.txtMedicine.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Medicine";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(104)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.cmbTags);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmbFirms);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nmPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nmCount);
            this.panel2.Location = new System.Drawing.Point(293, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 105);
            this.panel2.TabIndex = 25;
            // 
            // cmbTags
            // 
            this.cmbTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(651, 58);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(152, 28);
            this.cmbTags.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(647, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Tags";
            // 
            // cmbFirms
            // 
            this.cmbFirms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(451, 56);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(152, 28);
            this.cmbFirms.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(447, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Firms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(69, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Price";
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(73, 58);
            this.nmPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(145, 20);
            this.nmPrice.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(245, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Count";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(249, 58);
            this.nmCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(145, 20);
            this.nmCount.TabIndex = 23;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1194, 942);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpTags);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtgAddMedicine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtValidDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtproductDate);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddMedicine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQrCode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtproductDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtValidDate;
        private System.Windows.Forms.DataGridView dtgAddMedicine;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox grpTags;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckReseipt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmQrCode;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmCount;
    }
}