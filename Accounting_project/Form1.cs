using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using accounting.DataLayar;
using accounting.DataLayar.Contex;

namespace Accounting_project
{
    public partial class Form1 : Form
    {
        //UnitOFWork db;
        public Form1()
        {
            InitializeComponent();
           
            DGViewDisplay();
        }

       

        void DGViewDisplay()
        {
            DGView.AutoGenerateColumns = false;
            using(UnitOFWork db = new UnitOFWork())
            {
                DGView.DataSource = db.CustomerConnection.SelectAllCustomers();
            }

        }

        private void deleteBTN_Click_1(object sender, EventArgs e)
        {
            if (DGView.CurrentRow == null)
            {
                MessageBox.Show("selcet a row please");
            }
            else
            {
                string deletion = DGView.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"are you sure to delete {deletion}  ?", "notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOFWork db = new UnitOFWork())
                    {
                        db.CustomerConnection.DeleteCustomer(Convert.ToInt32(DGView.CurrentRow.Cells[0].Value.ToString()));
                        db.Save();
                    }
               
                    DGViewDisplay();
                }

            }
        }

        private void refreshBTN_Click_1(object sender, EventArgs e)
        {
            DGViewDisplay();
            searchBOX.Text = null;
        }

        private void editBTN_Click_1(object sender, EventArgs e)
        {
            if (DGView.CurrentRow != null)
            {
                int currentID = int.Parse(DGView.CurrentRow.Cells[0].Value.ToString());
                Form2 frm = new Form2();
                frm.check = currentID;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //DGViewDisplay();
                    //frm.Invalidate();
                    UnitOFWork conn = new UnitOFWork();
                    DGView.DataSource=conn.CustomerConnection.SelectAllCustomers();


                }

            }
            
            else
            {
                MessageBox.Show("please selcet a row ", "notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void addBTN_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DGViewDisplay();

            }
            // db.CustomerConnection.AddCustomer();
        }

        private void searchBOX_TextChanged_1(object sender, EventArgs e)
        {
            using (UnitOFWork db = new UnitOFWork())
            {
                DGView.DataSource = db.CustomerConnection.search(searchBOX.Text).ToList();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
