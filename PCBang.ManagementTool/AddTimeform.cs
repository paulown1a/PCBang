using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerForm
{
    public partial class AddTimeform : Form
    {
        private int? customerID;

        public AddTimeform()
        {
            InitializeComponent();
        }

        public AddTimeform(int? customerID) : this()
        {
            this.customerID = customerID;
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddTimeform_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = DataRepository.Customer.GetAll();
            List<Product> products = DataRepository.Product.GetAll().FindAll(x => x.CodeID == 101);
            productBindingSource.DataSource = products;
            List<Code> codes = DataRepository.Code.GetAll().FindAll(x => x.CodeID < 100 );
            codeBindingSource.DataSource = codes;
            if (customerID != null)
                cbbCustomer.SelectedValue = customerID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecution_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CustomerID = (int)cbbCustomer.SelectedValue;
            order.ProductID = (int)cbbTime.SelectedValue;
            order.Count= 1;
            order.OrderTime = DateTime.Now;
            order.CodeID = (int)cbbCode.SelectedValue;
            order.buyed = true;

            DataRepository.Order.Insert(order);

            Customer customer = DataRepository.Customer.Get(order.CustomerID);
            customer.RemainingTime = int.Parse(Regex.Replace(DataRepository.Product.Get(order.ProductID).Name, @"\D", "")) * 60;
            DataRepository.Customer.Update(customer);

            MessageBox.Show("결제되었습니다.");
            Close();
        }
        private void AddTimeform_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                Close();
        }
    }
}
