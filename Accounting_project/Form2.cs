using accounting.DataLayar;
using accounting.DataLayar.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ValidationComponents;

namespace Accounting_project
{
    public partial class Form2 : Form
    {
        public int check = 0;
        string Image_name = "no photo";
        UnitOFWork db = new UnitOFWork();
        public Form2()
        {
            InitializeComponent();

        }
  

        bool isvalid()
        {
            if (fullnameTXT.Text == "")
            {
                MessageBox.Show("enter the fullname", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullnameTXT.Focus();
               
                return false;
            }
            if (phoneTXT.Text == "")
            {
                MessageBox.Show("enter the phone number", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTXT.Focus();
                return false;
            }

            if (AddressTXT.Text == "")
            {
                MessageBox.Show("enter the address", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddressTXT.Focus();
                return false;
            }
            return true;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //check == 0 means no user has been selected ,so it is in insert mode
            //else it is in edit mode
            if (check != 0)
            {
                Text = "edit";
                submitBTN.Text = "edit";
                Customer cus = db.CustomerConnection.SelectCustomer(check);
                fullnameTXT.Text = cus.FullName;
                AddressTXT.Text = cus.Address;
                phoneTXT.Text = cus.PhoneNumber;
             
                string  path = Application.StartupPath + "/Images/" + cus.CustomerImage;
                personPicture.ImageLocation = path;
                Image_name =cus.CustomerImage;

                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PicSelectBTN_Click_1(object sender, EventArgs e)
        {
           
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    personPicture.ImageLocation = ofd.FileName;
                    //if user has Selected a picture genarate a unique name and set the Image_name as it  and save this picture in resource file ,
                    //but else let the Image_name be it's default name (no Photo)
                    Image_name = Guid.NewGuid().ToString()+ Path.GetExtension(personPicture.ImageLocation);
                    File.WriteAllBytes(Application.StartupPath + "/Images/" + Image_name , (File.ReadAllBytes(personPicture.ImageLocation)));

                }       
        }

        private void submitBTN_Click_1(object sender, EventArgs e)
        {
            //using (UnitOFWork db = new UnitOFWork())
          
                if (isvalid())
                {
                    Customer cus = new Customer() { Address = AddressTXT.Text, FullName = fullnameTXT.Text, PhoneNumber = phoneTXT.Text, CustomerImage = Image_name };
                    if (check == 0)//insert
                    {
                        db.CustomerConnection.AddCustomer(cus);
                    }
                    else//update
                    {
                        cus.CustomerID = check;
                        db.CustomerConnection.UpdateCustomer(cus);
                    }
                }
                db.Save();
                DialogResult = DialogResult.OK;
                //if (check == 0)//insert
                //{
                //    //if (BaseValidator.IsFormValid(this.components))
                //    if (isvalid())
                //    {
                //        Customer cus = new Customer() { Address = AddressTXT.Text, FullName = fullnameTXT.Text, PhoneNumber = phoneTXT.Text, CustomerImage = Image_name };
                //        db.CustomerConnection.AddCustomer(cus);
                //        db.Save();
                //        DialogResult = DialogResult.OK;
                //    }
                //}

                //else//update
                //{
                //    Customer cus = new Customer() { FullName = fullnameTXT.Text, Address = AddressTXT.Text, PhoneNumber = phoneTXT.Text, CustomerImage = Image_name, CustomerID = check };
                //    if (db.CustomerConnection.UpdateCustomer(cus))
                //    {

                //        DialogResult = DialogResult.OK;
                //        db.Save();
                //    }
                //    else
                //    {
                //        MessageBox.Show("the updation was not successfull");
                //        DialogResult = DialogResult.No;
                //    }
                //}

            
          

        
       
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
