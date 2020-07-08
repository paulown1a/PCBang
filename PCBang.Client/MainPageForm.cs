using MainPage;
using PC_Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using Microsoft.Win32;
using System.Drawing.Text;
using PC_Project.Data;

namespace MainPage
{
    public partial class MainPageForm : Form
    {
        private Customer customer;
        private string seatNumber;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        public MainPageForm(Customer customer, string seatNumber)
        {
            InitializeComponent();
            this.customer = customer;
            this.seatNumber = seatNumber;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);

            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            lblName.Text += customer.Name.ToString();
            lblID.Text += customer.LoginID.ToString();
            lblRank.Text += customer.Rank.ToString();
            lblPayamount.Text += customer.Payment.ToString();
            lblRemainingTime.Text += customer.RemainingTime.ToString();
            lblSeat.Text += seatNumber;

           
            btnRPGGame.StyleController = null;
            btnRPGGame.LookAndFeel.UseDefaultLookAndFeel = false;
            btnRPGGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            btnCDGame.StyleController = null;
            btnCDGame.LookAndFeel.UseDefaultLookAndFeel = false;
            btnCDGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;


            DataRepository.Seat.Update(seatNumber, customer.CustomerID);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            customer.RemainingTime--;
         timer1.Start(); //타이머를 발동시킨다.
        }



        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("사용을 종료하시겠습니까?", "사용종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("종료합니다");
                DataRepository.Seat.Update(seatNumber);
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("직원호출");
        }

        private void btnFoodOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("음식주문");
            FoodOrderForm Foodorder = new FoodOrderForm(seatNumber, customer.CustomerID);
            Foodorder.Show();
        }
    }
}
