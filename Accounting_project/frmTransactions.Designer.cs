namespace Accounting_project
{
    partial class frmTransactions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DGviewCustmer = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.rbRecive = new System.Windows.Forms.RadioButton();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGviewCustmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DGviewCustmer);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(386, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(231, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "customer selection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "search";
            // 
            // DGviewCustmer
            // 
            this.DGviewCustmer.AllowUserToAddRows = false;
            this.DGviewCustmer.AllowUserToDeleteRows = false;
            this.DGviewCustmer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGviewCustmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGviewCustmer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.CustomerID});
            this.DGviewCustmer.Location = new System.Drawing.Point(15, 60);
            this.DGviewCustmer.Margin = new System.Windows.Forms.Padding(4);
            this.DGviewCustmer.Name = "DGviewCustmer";
            this.DGviewCustmer.ReadOnly = true;
            this.DGviewCustmer.Size = new System.Drawing.Size(208, 298);
            this.DGviewCustmer.TabIndex = 1;
            this.DGviewCustmer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGviewCustmer_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(60, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.TextChanged += new System.EventHandler(this.btnSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(126, 36);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(221, 21);
            this.txtFullName.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(126, 162);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 178);
            this.txtDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transaction Type";
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(126, 76);
            this.rbPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(73, 19);
            this.rbPay.TabIndex = 8;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "Payment";
            this.rbPay.UseVisualStyleBackColor = true;
            this.rbPay.CheckedChanged += new System.EventHandler(this.rbPay_CheckedChanged);
            // 
            // rbRecive
            // 
            this.rbRecive.AutoSize = true;
            this.rbRecive.Location = new System.Drawing.Point(207, 76);
            this.rbRecive.Margin = new System.Windows.Forms.Padding(4);
            this.rbRecive.Name = "rbRecive";
            this.rbRecive.Size = new System.Drawing.Size(62, 19);
            this.rbRecive.TabIndex = 9;
            this.rbRecive.TabStop = true;
            this.rbRecive.Text = "Recive";
            this.rbRecive.UseVisualStyleBackColor = true;
            this.rbRecive.CheckedChanged += new System.EventHandler(this.rbRecive_CheckedChanged);
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(126, 118);
            this.numericAmount.Margin = new System.Windows.Forms.Padding(4);
            this.numericAmount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(221, 21);
            this.numericAmount.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRecive);
            this.groupBox2.Controls.Add(this.numericAmount);
            this.groupBox2.Controls.Add(this.rbPay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(4, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(363, 366);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "filling out";
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtFullName;
            this.requiredFieldValidator1.ErrorMessage = "select the full name from customer selection box";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.numericAmount;
            this.rangeValidator1.ErrorMessage = "the amount out of range";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "9999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.Location = new System.Drawing.Point(16, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 26);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "FullName";
            this.name.HeaderText = "Full Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 399);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "new Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGviewCustmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGviewCustmer;
        private System.Windows.Forms.TextBox btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.RadioButton rbRecive;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RangeValidator rangeValidator1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
    }
}