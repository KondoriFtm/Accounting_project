namespace Accounting_project
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.editBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.printBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.ToDateBtn = new System.Windows.Forms.Label();
            this.fromDateBtn = new System.Windows.Forms.Label();
            this.txtTodate = new System.Windows.Forms.MaskedTextBox();
            this.customerBtn = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dgviewAccounting = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewAccounting)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBtn,
            this.refreshBtn,
            this.deleteBtn,
            this.printBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // editBtn
            // 
            this.editBtn.Image = global::Accounting_project.Properties.Resources._1371475973_document_edit;
            this.editBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(44, 59);
            this.editBtn.Text = "edit";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::Accounting_project.Properties.Resources._1371476342_Refresh;
            this.refreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 59);
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.ToolTipText = "Refresh";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Image = global::Accounting_project.Properties.Resources._1371476007_Close_Box_Red;
            this.deleteBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(44, 59);
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Image = global::Accounting_project.Properties.Resources._1371476276_Print;
            this.printBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(44, 59);
            this.printBtn.Text = "Print";
            this.printBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterBtn);
            this.groupBox1.Controls.Add(this.ToDateBtn);
            this.groupBox1.Controls.Add(this.fromDateBtn);
            this.groupBox1.Controls.Add(this.txtTodate);
            this.groupBox1.Controls.Add(this.customerBtn);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Location = new System.Drawing.Point(9, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiter Box";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Location = new System.Drawing.Point(545, 36);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(48, 23);
            this.FilterBtn.TabIndex = 6;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // ToDateBtn
            // 
            this.ToDateBtn.AutoSize = true;
            this.ToDateBtn.Location = new System.Drawing.Point(382, 41);
            this.ToDateBtn.Name = "ToDateBtn";
            this.ToDateBtn.Size = new System.Drawing.Size(49, 13);
            this.ToDateBtn.TabIndex = 5;
            this.ToDateBtn.Text = "To Date:";
            // 
            // fromDateBtn
            // 
            this.fromDateBtn.AutoSize = true;
            this.fromDateBtn.Location = new System.Drawing.Point(213, 41);
            this.fromDateBtn.Name = "fromDateBtn";
            this.fromDateBtn.Size = new System.Drawing.Size(57, 13);
            this.fromDateBtn.TabIndex = 4;
            this.fromDateBtn.Text = "From date:";
            // 
            // txtTodate
            // 
            this.txtTodate.Location = new System.Drawing.Point(437, 38);
            this.txtTodate.Mask = "00/00/0000";
            this.txtTodate.Name = "txtTodate";
            this.txtTodate.Size = new System.Drawing.Size(100, 20);
            this.txtTodate.TabIndex = 3;
            this.txtTodate.ValidatingType = typeof(System.DateTime);
            // 
            // customerBtn
            // 
            this.customerBtn.AutoSize = true;
            this.customerBtn.Location = new System.Drawing.Point(6, 41);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(74, 13);
            this.customerBtn.TabIndex = 2;
            this.customerBtn.Text = "Account Party";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(276, 38);
            this.txtFromDate.Mask = "00/00/0000";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(100, 20);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(86, 37);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 0;
            // 
            // dgviewAccounting
            // 
            this.dgviewAccounting.AllowUserToAddRows = false;
            this.dgviewAccounting.AllowUserToDeleteRows = false;
            this.dgviewAccounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewAccounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewAccounting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CustomerID,
            this.FullName,
            this.amount,
            this.DateTime,
            this.Description});
            this.dgviewAccounting.Location = new System.Drawing.Point(9, 147);
            this.dgviewAccounting.Name = "dgviewAccounting";
            this.dgviewAccounting.ReadOnly = true;
            this.dgviewAccounting.Size = new System.Drawing.Size(617, 231);
            this.dgviewAccounting.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "datetime";
            this.DateTime.HeaderText = "Date Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // stiReport
            // 
            this.stiReport.CookieContainer = null;
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "8a7d94e08de545809f24874c229d5ad6";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = null;
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = null;
            this.requiredFieldValidator1.ErrorMessage = "select a transaction please";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 390);
            this.Controls.Add(this.dgviewAccounting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewAccounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editBtn;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStripButton printBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ToDateBtn;
        private System.Windows.Forms.Label fromDateBtn;
        private System.Windows.Forms.MaskedTextBox txtTodate;
        private System.Windows.Forms.Label customerBtn;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.DataGridView dgviewAccounting;
        private Stimulsoft.Report.StiReport stiReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}