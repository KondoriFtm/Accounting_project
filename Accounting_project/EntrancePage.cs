using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_project
{
    public partial class EntrancePage : Form
    {
        public EntrancePage()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.ShowDialog();
        }

        private void EntrancePage_Load(object sender, EventArgs e)
        {

        }

        private void PayReportBtn_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID= 2;
            frm.ShowDialog();
        }

        private void ReciveReportBtn_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeID = 1;
            frm.ShowDialog();
        }
    }
}
