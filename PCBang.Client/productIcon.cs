using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PC_Project.Data;


namespace loginform
{
    public partial class ProductIcon : UserControl
    {
        public ProductIcon()
        {
            InitializeComponent();
        }
         
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;

            if (DataRepository.Product.GetByName(lblName.Text) != null)
                OnOrderBtnClicked(DataRepository.Product.GetByName(lblName.Text).Value, (int)btnCount.Value);
            Enabled = true;
        }

        public void SetProductData(Product product)
        {
            lblName.Text = product.Name;
            lblPrice.Text = product.Price.ToString("C");

        }
            
        #region OrderBtnClicked event things for C# 3.0
        public event EventHandler<OrderBtnClickedEventArgs> OrderBtnClicked;

        protected virtual void OnOrderBtnClicked(OrderBtnClickedEventArgs e)
        {
            if (OrderBtnClicked != null)
                OrderBtnClicked(this, e);
        }

        private OrderBtnClickedEventArgs OnOrderBtnClicked(int productId, int count)
        {
            OrderBtnClickedEventArgs args = new OrderBtnClickedEventArgs(productId, count);
            OnOrderBtnClicked(args);

            return args;
        }

        private OrderBtnClickedEventArgs OnOrderBtnClickedForOut()
        {
            OrderBtnClickedEventArgs args = new OrderBtnClickedEventArgs();
            OnOrderBtnClicked(args);

            return args;
        }

        public class OrderBtnClickedEventArgs : EventArgs
        {
            public int ProductId { get; set; }
            public int Count { get; set; }

            public OrderBtnClickedEventArgs()
            {
            }

            public OrderBtnClickedEventArgs(int productId, int count)
            {
                ProductId = productId;
                Count = count;
            }
        }
        #endregion

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
