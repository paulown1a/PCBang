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
    public partial class billForm : DevExpress.XtraEditors.XtraForm
    {
        private Customer customer;

        public billForm()
        {
            
            InitializeComponent();
        }

        public billForm(Customer customer) : this()
        {
            this.customer = customer;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            bdsCode.DataSource = DataRepository.Code.GetAll().FindAll(x => x.CodeID < 100);
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
                order.CodeID = (int)cbbCode.SelectedValue;
                DataRepository.Order.Update(order);
            }

            //MessageBox.Show(customer.Payment.ToString());
            DataRepository.Customer.Update(customer);

            MessageBox.Show("주문이 완료되었습니다.");
            Close();
            Enabled = true;

            if (MessageBox.Show("추가주문을 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();

            }
            else
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnBillCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
