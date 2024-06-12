namespace Accounting_project
{
    partial class EntrancePage
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnTransaction = new System.Windows.Forms.ToolStripButton();
            this.PayReportBtn = new System.Windows.Forms.ToolStripButton();
            this.ReciveReportBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.btnTransaction,
            this.PayReportBtn,
            this.ReciveReportBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoSize = false;
            this.btnCustomer.Image = global::Accounting_project.Properties.Resources.Users;
            this.btnCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(68, 50);
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Image = global::Accounting_project.Properties.Resources.servicesCosts;
            this.btnTransaction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(70, 59);
            this.btnTransaction.Text = "transaction";
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // PayReportBtn
            // 
            this.PayReportBtn.Image = global::Accounting_project.Properties.Resources._1370791030_credit_card;
            this.PayReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PayReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PayReportBtn.Name = "PayReportBtn";
            this.PayReportBtn.Size = new System.Drawing.Size(96, 59);
            this.PayReportBtn.Text = "Paymant Report";
            this.PayReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PayReportBtn.Click += new System.EventHandler(this.PayReportBtn_Click);
            // 
            // ReciveReportBtn
            // 
            this.ReciveReportBtn.Image = global::Accounting_project.Properties.Resources._1371476468_preferences_contact_list;
            this.ReciveReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReciveReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReciveReportBtn.Name = "ReciveReportBtn";
            this.ReciveReportBtn.Size = new System.Drawing.Size(117, 59);
            this.ReciveReportBtn.Text = "Receivement Report";
            this.ReciveReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReciveReportBtn.Click += new System.EventHandler(this.ReciveReportBtn_Click);
            // 
            // EntrancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EntrancePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "entrance page";
            this.Load += new System.EventHandler(this.EntrancePage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnTransaction;
        private System.Windows.Forms.ToolStripButton PayReportBtn;
        private System.Windows.Forms.ToolStripButton ReciveReportBtn;
    }
}