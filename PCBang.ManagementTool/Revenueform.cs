using DevExpress.XtraEditors.Filtering;
using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerForm
{
    public partial class Revenueform : Form
    {
        public Revenueform()
        {
            InitializeComponent();
        }

        private void Revenueform_Load(object sender, EventArgs e)
        {
            List<Order> orders = DataRepository.Order.GetWithProduct(true);
            int total = 0;
            foreach(Order order in orders)
               total += order.buyed == true ?order.Count * order.ProductPrice:0;
            lblTotal.Text = total.ToString("C0");
            bdsOrder.DataSource = orders;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Revenueform_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                Close();
        }
    }
}
