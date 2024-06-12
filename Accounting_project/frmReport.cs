using accounting.DataLayar.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using accounting;
using Accounting.ViewModel;
using accounting.DataLayar;
using ValidationComponents;

namespace Accounting_project
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOFWork db = new UnitOFWork())
            {
                List<CusomerViewModel> lst = new List<CusomerViewModel> ();
                lst.Add(new CusomerViewModel() { FullName = "select a Customer", CustomerID = 0 });
                lst.AddRange(db.CustomerConnection.GetCustomerFullname());
                cbCustomer.DataSource =lst;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
             
            if (TypeID == 1)
            {
                this.Text = "Recievement";
            }
            else
            {
                this.Text = "Payment";
            }



        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(dgviewAccounting.CurrentRow == null)
            {
                MessageBox.Show("no transaction is selected");
            }
            else
            {
                if(MessageBox.Show($"are sure to delete {dgviewAccounting.CurrentRow.Cells[2].Value.ToString()} ?","warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOFWork db = new UnitOFWork())
                    {
                        int customerID = int.Parse(dgviewAccounting.CurrentRow.Cells[0].Value.ToString());
                        db.AccountingRepository.Delete(customerID);
                        db.Save();
                        bindGrid();    
                   
                    }
                }
            }
        }

        void bindGrid()
        {

            using (UnitOFWork db = new UnitOFWork())
            {
               
                dgviewAccounting.AutoGenerateColumns = false;
                
                List<accounting.DataLayar.Accounting> result  = new List<accounting.DataLayar.Accounting> ();
                if ((int)cbCustomer.SelectedValue == 0) //it means no Customer is selected 
                {                                       //so no filter is needed ,fetch all customers with that typeID

                     result = db.AccountingRepository.GetByFilter(F => F.TypeID == TypeID).ToList();

                }
                else
                {
                     result = db.AccountingRepository.GetByFilter(F => F.TypeID == TypeID && F.CustomerID == (int)cbCustomer.SelectedValue).ToList();

                }
                if(txtFromDate.Text != "  /  /")
                {
                    DateTime startDate = Convert.ToDateTime(txtFromDate.Text);
                    result =result.Where(F=> F.datetime >= startDate).ToList();
                }
                if(txtTodate.Text != "  /  /")
                {
                    DateTime EndDate = Convert.ToDateTime(txtTodate.Text);
                    result = result.Where(F => F.datetime <= EndDate).ToList();
                }
                dgviewAccounting.Rows.Clear();
                foreach (var item in result)
                {
                    string name = (db.CustomerConnection.SelectCustomer(item.CustomerID)).FullName;
                    dgviewAccounting.Rows.Add(item.ID, item.CustomerID, name, item.amount, item.datetime,item.Description);
                    dgviewAccounting.Refresh();

                }


            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //if (BaseValidator.IsFormValid(this.components))
            {
                frmTransactions frm = new frmTransactions();
                frm.id = int.Parse(dgviewAccounting.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    bindGrid();

                }
            }
      
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            //the informations of DataGridView be sent to stireport

            DataTable dt = new DataTable();
            dt.Columns.Add("Customer Name");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date Time");
            dt.Columns.Add("Description");

            foreach(DataGridViewRow item in dgviewAccounting.Rows) 
            {
                dt.Rows.Add(item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(), 
                    item.Cells[5].Value.ToString());
            }
            stiReport.Load(Application.StartupPath + "/report.mrt");
            stiReport.RegData("DataSource", dt);
            stiReport.Show();
        }
    }
}
