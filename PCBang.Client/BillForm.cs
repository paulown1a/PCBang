using PC_Project.Data;
using PC_Room;
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

namespace PC_Project.Client
{
    public partial class BillForm : DevExpress.XtraEditors.XtraForm
    {
        private Customer customer;

        public BillForm()
        {
            
            InitializeComponent();
        }

        public BillForm(Customer customer) : this()
        {
            this.customer = customer;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            bdsOrderinBill.DataSource = DataRepository.Order.GetWithProduct(false);
            lbTotal.Text += DataRepository.Order.GetTotalPrice(false, customer.CustomerID).ToString("C0");
        }

        private void btnBillOrder_Click(object sender, EventArgs e)
        {
            Enabled = false;
            List<Order> orders = DataRepository.Order.GetWithProduct(false,customer.CustomerID);
            customer.Payment += DataRepository.Order.GetTotalPrice(false, customer.CustomerID);

            
            foreach (Order order in orders)
            {
                //MessageBox.Show(Regex.Replace(order.ProductName, @"\D",""));
                if (DataRepository.Order.CheckItem(order) == 101)
                    customer.RemainingTime += int.Parse(Regex.Replace(order.ProductName, @"\D", ""))*60;
                order.buyed = true;
                DataRepository.Order.Update(order);
            }

            //MessageBox.Show(customer.Payment.ToString());
            DataRepository.Customer.Update(customer);

            MessageBox.Show("주문이 완료되었습니다.");
            Close();
            Enabled = true;
            
        }

        private void btnBillCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
