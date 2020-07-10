using PC_Project.Data;
using PC_Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Project.Client
{
    public partial class BillForm : DevExpress.XtraEditors.XtraForm
    {
        private int customerID;

        public BillForm()
        {
            
            InitializeComponent();
        }

        public BillForm(int customerID) : this()
        {
            this.customerID = customerID;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            bdsOrderinBill.DataSource = DataRepository.Order.GetWithProduct(false);
            lbTotal.Text += DataRepository.Order.GetTotalPrice(false, customerID).ToString("C0");
        }

        private void btnBillOrder_Click(object sender, EventArgs e)
        {
            Enabled = false;
            List<Order> orders = DataRepository.Order.GetWithProduct(false,customerID);
            foreach (Order order in orders)
            {
                order.buyed = true;
                DataRepository.Order.Update(order);
            }
            
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
