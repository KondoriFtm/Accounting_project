namespace Accounting_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phoneTXT = new System.Windows.Forms.TextBox();
            this.AddressTXT = new System.Windows.Forms.TextBox();
            this.fullnameTXT = new System.Windows.Forms.TextBox();
            this.addressLBL = new System.Windows.Forms.Label();
            this.phoneLBL = new System.Windows.Forms.Label();
            this.fullnameLBL = new System.Windows.Forms.Label();
            this.PicSelectBTN = new System.Windows.Forms.Button();
            this.submitBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personPicture);
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "picture";
            // 
            // personPicture
            // 
            this.personPicture.Image = ((System.Drawing.Image)(resources.GetObject("personPicture.Image")));
            this.personPicture.Location = new System.Drawing.Point(6, 19);
            this.personPicture.Name = "personPicture";
            this.personPicture.Size = new System.Drawing.Size(147, 215);
            this.personPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personPicture.TabIndex = 0;
            this.personPicture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phoneTXT);
            this.groupBox2.Controls.Add(this.AddressTXT);
            this.groupBox2.Controls.Add(this.fullnameTXT);
            this.groupBox2.Controls.Add(this.addressLBL);
            this.groupBox2.Controls.Add(this.phoneLBL);
            this.groupBox2.Controls.Add(this.fullnameLBL);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(171, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "person informations";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // phoneTXT
            // 
            this.phoneTXT.Location = new System.Drawing.Point(132, 88);
            this.phoneTXT.Name = "phoneTXT";
            this.phoneTXT.Size = new System.Drawing.Size(167, 20);
            this.phoneTXT.TabIndex = 6;
            // 
            // AddressTXT
            // 
            this.AddressTXT.Location = new System.Drawing.Point(132, 134);
            this.AddressTXT.Multiline = true;
            this.AddressTXT.Name = "AddressTXT";
            this.AddressTXT.Size = new System.Drawing.Size(167, 39);
            this.AddressTXT.TabIndex = 5;
            // 
            // fullnameTXT
            // 
            this.fullnameTXT.Location = new System.Drawing.Point(132, 44);
            this.fullnameTXT.Name = "fullnameTXT";
            this.fullnameTXT.Size = new System.Drawing.Size(167, 20);
            this.fullnameTXT.TabIndex = 4;
            // 
            // addressLBL
            // 
            this.addressLBL.AutoSize = true;
            this.addressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addressLBL.Location = new System.Drawing.Point(7, 134);
            this.addressLBL.Name = "addressLBL";
            this.addressLBL.Size = new System.Drawing.Size(69, 18);
            this.addressLBL.TabIndex = 3;
            this.addressLBL.Text = "Address";
            // 
            // phoneLBL
            // 
            this.phoneLBL.AutoSize = true;
            this.phoneLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.phoneLBL.Location = new System.Drawing.Point(6, 87);
            this.phoneLBL.Name = "phoneLBL";
            this.phoneLBL.Size = new System.Drawing.Size(120, 18);
            this.phoneLBL.TabIndex = 2;
            this.phoneLBL.Text = "Phone Number";
            // 
            // fullnameLBL
            // 
            this.fullnameLBL.AutoSize = true;
            this.fullnameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fullnameLBL.Location = new System.Drawing.Point(7, 41);
            this.fullnameLBL.Name = "fullnameLBL";
            this.fullnameLBL.Size = new System.Drawing.Size(76, 18);
            this.fullnameLBL.TabIndex = 1;
            this.fullnameLBL.Text = "full name";
            // 
            // PicSelectBTN
            // 
            this.PicSelectBTN.Location = new System.Drawing.Point(12, 281);
            this.PicSelectBTN.Name = "PicSelectBTN";
            this.PicSelectBTN.Size = new System.Drawing.Size(115, 23);
            this.PicSelectBTN.TabIndex = 7;
            this.PicSelectBTN.Text = "select";
            this.PicSelectBTN.UseVisualStyleBackColor = true;
            this.PicSelectBTN.Click += new System.EventHandler(this.PicSelectBTN_Click_1);
            // 
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.Color.DarkGreen;
            this.submitBTN.Location = new System.Drawing.Point(181, 281);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(116, 26);
            this.submitBTN.TabIndex = 8;
            this.submitBTN.Text = "subimt";
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 316);
            this.Controls.Add(this.PicSelectBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label phoneLBL;
        private System.Windows.Forms.Label fullnameLBL;
        private System.Windows.Forms.TextBox phoneTXT;
        private System.Windows.Forms.TextBox AddressTXT;
        private System.Windows.Forms.TextBox fullnameTXT;
        private System.Windows.Forms.Label addressLBL;
        private System.Windows.Forms.Button PicSelectBTN;
        private System.Windows.Forms.PictureBox personPicture;
        private System.Windows.Forms.Button submitBTN;
    }
}