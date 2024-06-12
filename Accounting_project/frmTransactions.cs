using accounting.DataLayar;
using accounting.DataLayar.Contex;
using accounting.DataLayar.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting_project
{
    public partial class frmTransactions : Form
    {
        public int id = 0;
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
          
                using (UnitOFWork db = new UnitOFWork())
                {
                    DGviewCustmer.AutoGenerateColumns = false;
                    DGviewCustmer.DataSource = db.CustomerConnection.GetCustomerFullname();

                }
            
            if(id != 0 )
            {
                txtFullName.ReadOnly = false;
                using (UnitOFWork db = new UnitOFWork())
                {
                    var account = db.AccountingRepository.GetByKey(id);
                    txtFullName.Text = db.CustomerConnection.SelectCustomer(account.CustomerID).FullName;
                    if (account.TypeID == 2)
                    {
                        rbPay.Checked = true;
                    }
                    else
                    {
                        rbRecive.Checked = true;
                    }
                    numericAmount.Value = account.amount;
                    txtDescription.Text = account.Description;
                }
                this.Text = "edit";
                btnSave.Text = "edit";

            }

        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOFWork db = new UnitOFWork())
            {
                DGviewCustmer.AutoGenerateColumns = false;
                DGviewCustmer.DataSource = db.CustomerConnection.GetCustomerFullname(btnSearch.Text);

            }
        }

        private void rbRecive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DGviewCustmer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFullName.Text = DGviewCustmer.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {

                if (rbPay.Checked || rbRecive.Checked)
                {

                    using (UnitOFWork Context = new UnitOFWork())
                    {

                        accounting.DataLayar.Accounting account = new accounting.DataLayar.Accounting()
                        {
                            CustomerID = int.Parse(DGviewCustmer.CurrentRow.Cells[1].Value.ToString()),
                            TypeID = rbPay.Checked ? 2 : 1,
                            amount = int.Parse(numericAmount.Value.ToString()),
                            datetime = DateTime.Now,
                            Description = txtDescription.Text
                        };

                        if (id == 0)
                        {
                            Context.AccountingRepository.insert(account);
                        }
                        else
                        {
                            account.ID = id;    
                            Context.AccountingRepository.Update(account);
                        }

                        Context.Save();
                        DialogResult = DialogResult.OK;
                    }


                }
                else
                {
                    MessageBox.Show("check the transaction type ");
                }


            }
        }
    }
}
