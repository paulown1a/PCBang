using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using PC_Project.Data;
using loginform;
using PC_Project.Client;
using DevExpress.Printing.ExportHelpers;
using DevExpress.XtraGrid.Views.Card;

namespace PC_Room
{
    public partial class FoodOrderForm :Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Panel leftBorderBtnSecond;
        private int seatNumber;
        private Customer customer;

        public FoodOrderForm()
        {
            InitializeComponent();
            CenterToScreen();
            
            leftBorderBtn = new Panel();
            leftBorderBtnSecond = new Panel();
            leftBorderBtn.Size = new Size(7, 48);
            leftBorderBtnSecond.Size = new Size(7, 48);
            MenuPn.Controls.Add(leftBorderBtn);
            CalulatorPn.Controls.Add(leftBorderBtnSecond);
            
        }

        public FoodOrderForm(string seatNumber, Customer customer) : this()
        {
            this.seatNumber = int.Parse(seatNumber);
            this.customer = customer;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(192, 27, 55);
            public static Color color2 = Color.FromArgb(245, 135, 171);
            public static Color color3 = Color.FromArgb(104, 94, 197);
            public static Color color4 = Color.FromArgb(42, 152, 235);
            public static Color color5 = Color.FromArgb(199, 93, 204);
            public static Color color6 = Color.FromArgb(255, 113, 85);
            public static Color color7 = Color.FromArgb(165, 229, 158);
            public static Color color8 = Color.FromArgb(252, 202, 65);
        }

        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                if(senderBtn==ExitBtn || senderBtn== BuyBtn || senderBtn==btnClear)
                {
                    leftBorderBtnSecond.BackColor = color;
                    leftBorderBtnSecond.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                    leftBorderBtnSecond.Visible = true;
                    leftBorderBtnSecond.BringToFront();
                }
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
            
        }
        private void DisableButton()
        {
            if(currentBtn!=null)
            { 
                currentBtn.BackColor = Color.FromArgb(37, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            activateButton(sender,RGBColors.color4);
            GridFood.BringToFront();
            bdsProduct.DataSource = DataRepository.Product.Getbycode(102);
        }

        private void BeverageBtn_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
            GridFood.BringToFront();
            bdsProduct.DataSource = DataRepository.Product.Getbycode(104);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DataRepository.Order.DeleteOrder(customer.CustomerID);
            Close();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtnSecond.Visible = false;
            leftBorderBtn.Visible = false;
        }

        private void HomeIcon_Click(object sender, EventArgs e)
        {
            pnHome.BringToFront();
            Reset();
        }

        private void ExitBtn_MouseHover(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color1);
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            Reset();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            //activateButton(sender, RGBColors.color6);

            if (DataRepository.Order.GetWithProduct(false, customer.CustomerID).Count==0)
            { 
                MessageBox.Show("상품을 골라 주세요");
                return;
            }
            else
            {
                billForm billform = new billForm(customer);
                var res=billform.ShowDialog();
                bdsOrder.DataSource = DataRepository.Order.GetWithProduct(false, customer.CustomerID);
                if (res==DialogResult.OK)
                {
                    var orderagain = new FoodOrderForm();
                    this.Visible = false;
                    
                    this.Close();
                }
            }
                
        }

        private void BuyBtn_MouseHover(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color6);
        }

        private void BuyBtn_MouseLeave(object sender, EventArgs e)
        {
            Reset();
        }

        private void SnackBtn_Click_1(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            GridFood.BringToFront();
            bdsProduct.DataSource = DataRepository.Product.Getbycode(103);
        }

        private void TicketBtn_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color7);
            GridFood.BringToFront();
            bdsProduct.DataSource = DataRepository.Product.Getbycode(101);
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            
            List<Product> products =
                DataRepository.Product.Getbycode(102);
            bdsProduct.DataSource = products;
        }

        private void productIcon1_OrderBtnClicked(object sender, loginform.ProductIcon.OrderBtnClickedEventArgs e)
        {

            Order order = new Order();

            order.ProductID = e.ProductId;

            order.SeatID = seatNumber;
            order.CustomerID = customer.CustomerID;
            order.OrderTime = DateTime.Now;
            order.buyed = false;
            DataRepository.Order.Insert(order);

        }

        private void FoodOrderForm_Load(object sender, EventArgs e)
        {
            //uscProduct1.SetProductData(DataRepository.Product.Get(4));
            pnHome.BringToFront();
            ControlBox = false;
        }


        private void GridFood_DoubleClick(object sender, EventArgs e)
        {
           
            Product product = bdsProduct.Current as Product;
            if (product == null)
                return;
            Order order = new Order();
            order.CodeID = null;
            order.CustomerID = customer.CustomerID;
            order.ProductID = product.ProductID;
            order.SeatID = seatNumber;
            order.buyed = false;
            order.OrderTime = DateTime.Now;
            order.Count = 1;
            DataRepository.Order.Insert(order);
            bdsOrder.DataSource = DataRepository.Order.GetWithProduct(false, customer.CustomerID);

        }

        private void gridBIll_DoubleClick(object sender, EventArgs e)
        {
            
            Order order = bdsOrder.Current as Order;
            if (order == null)
                return;
            DataRepository.Order.Delete(order);
            bdsOrder.DataSource = DataRepository.Order.GetWithProduct(false, customer.CustomerID);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Order order = bdsOrder.Current as Order;
            if (order == null)
                return;
            DataRepository.Order.DeleteOrder(customer.CustomerID);
            bdsOrder.DataSource = DataRepository.Order.GetWithProduct(false, customer.CustomerID);
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color8);
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            Reset();
        }

    }
}