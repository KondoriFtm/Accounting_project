namespace Accounting_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addBTN = new System.Windows.Forms.ToolStripButton();
            this.refreshBTN = new System.Windows.Forms.ToolStripButton();
            this.deleteBTN = new System.Windows.Forms.ToolStripButton();
            this.editBTN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchLBL = new System.Windows.Forms.ToolStripLabel();
            this.searchBOX = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBTN,
            this.refreshBTN,
            this.deleteBTN,
            this.editBTN,
            this.toolStripSeparator1,
            this.searchLBL,
            this.searchBOX});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 47);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addBTN
            // 
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(98, 44);
            this.addBTN.Text = "Add new";
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click_1);
            // 
            // refreshBTN
            // 
            this.refreshBTN.Image = ((System.Drawing.Image)(resources.GetObject("refreshBTN.Image")));
            this.refreshBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBTN.Name = "refreshBTN";
            this.refreshBTN.Size = new System.Drawing.Size(90, 44);
            this.refreshBTN.Text = "Refresh";
            this.refreshBTN.Click += new System.EventHandler(this.refreshBTN_Click_1);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(84, 44);
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click_1);
            // 
            // editBTN
            // 
            this.editBTN.Image = ((System.Drawing.Image)(resources.GetObject("editBTN.Image")));
            this.editBTN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(71, 44);
            this.editBTN.Text = "Edit";
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // searchLBL
            // 
            this.searchLBL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchLBL.Name = "searchLBL";
            this.searchLBL.Size = new System.Drawing.Size(44, 44);
            this.searchLBL.Text = "search ";
            // 
            // searchBOX
            // 
            this.searchBOX.AutoSize = false;
            this.searchBOX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBOX.Name = "searchBOX";
            this.searchBOX.Size = new System.Drawing.Size(120, 47);
            this.searchBOX.TextChanged += new System.EventHandler(this.searchBOX_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGView);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "list of people";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DGView
            // 
            this.DGView.AllowUserToAddRows = false;
            this.DGView.AllowUserToDeleteRows = false;
            this.DGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.fullname,
            this.PhoneNumber,
            this.Address});
            this.DGView.Location = new System.Drawing.Point(6, 19);
            this.DGView.Name = "DGView";
            this.DGView.ReadOnly = true;
            this.DGView.Size = new System.Drawing.Size(548, 237);
            this.DGView.TabIndex = 0;
            this.DGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "FullName";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addBTN;
        private System.Windows.Forms.ToolStripButton refreshBTN;
        private System.Windows.Forms.ToolStripButton deleteBTN;
        private System.Windows.Forms.ToolStripButton editBTN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel searchLBL;
        private System.Windows.Forms.ToolStripTextBox searchBOX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}

