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
        private int? customerId;

        public AddTimeform()
        {
            InitializeComponent();
        }

        public AddTimeform(int? customerId) : this()
        {
            this.customerId = customerId;
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddTimeform_Load(object sender, EventArgs e)
        {
            bdsCustomer.DataSource = DataRepository.Customer.GetAll();
            bdsProduct.DataSource = DataRepository.Product.GetAll().FindAll(x => x.CodeID == 101);
            bdsCode.DataSource = DataRepository.Code.GetAll().FindAll(x => x.CodeID < 100 );
            if (customerId != null)
                cbbCustomer.SelectedValue = customerId;
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
            customer.RemainingTime += int.Parse(Regex.Replace(DataRepository.Product.Get(order.ProductID).Name, @"\D", "")) * 60;
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
