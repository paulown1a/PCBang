using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PC_Project.Data;

namespace Managerform
{

    public partial class ManageCustomerform : DevExpress.XtraEditors.XtraForm
{
    public ManageCustomerform()
    {
        InitializeComponent();
    }

        private void DeleteCustomerform_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = DataRepository.Customer.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = customerBindingSource.Current as Customer;

            if (customer == null)
                return;

            if (MessageBox.Show("삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRepository.Customer.Delete(customer);
                MessageBox.Show("삭제 완료");
                customerBindingSource.DataSource = DataRepository.Customer.GetAll();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Customer customer = customerBindingSource.Current as Customer;
            
            if (customer == null)
                return;

            if (txbName.Text == "" && txbID.Text == "" && txbPW.Text == "")
                return;

            if (txbName.Text != "")
                customer.Name = txbName.Text;
            if (txbID.Text != "")
                customer.LoginID = txbID.Text;
            if (txbPW.Text != "")
                customer.LoginPassword = txbPW.Text;

            DataRepository.Customer.Update(customer);
            MessageBox.Show("변경되었습니다.");

            customerBindingSource.DataSource = DataRepository.Customer.GetAll();

        }
        private void ManagerCustomerform_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                Close();
        }
    }
}