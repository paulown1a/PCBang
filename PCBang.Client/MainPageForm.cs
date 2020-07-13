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
using DevExpress.Internal;
using System.Linq.Expressions;

namespace MainPage
{
    public partial class MainPageForm : Form
    {
        private Customer customer;
        private string seatNumber;
        private int genreId = 0;
        private int pausedTime = 0;
        
        
        public MainPageForm(Customer customer, string seatNumber)
        {
            InitializeComponent();
            this.customer = customer;
            this.seatNumber = seatNumber;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            timer1.Start();
            LabelUpdate();

            List<Game> topGames = DataRepository.Game.TopFiveGame();
            lblGameNo1.Text = topGames[0] != null ? $"{1 }. {topGames[0].Name}" : $"{1 }. ";
            lblGameNo2.Text = topGames[1] != null ? $"{2 }. {topGames[1].Name}" : $"{2 }. ";
            lblGameNo3.Text = topGames[2] != null ? $"{3 }. {topGames[2].Name}" : $"{3 }. ";
            lblGameNo4.Text = topGames[3] != null ? $"{4 }. {topGames[3].Name}" : $"{4 }. ";
            lblGameNo5.Text = topGames[4] != null ? $"{5 }. {topGames[4].Name}" : $"{5 }. ";

            btnFPSGame.StyleController = null;
            btnFPSGame.LookAndFeel.UseDefaultLookAndFeel = false;
            btnFPSGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;


            btnRPGGame.StyleController = null;
            btnRPGGame.LookAndFeel.UseDefaultLookAndFeel = false;
            btnRPGGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            btnCDGame.StyleController = null;
            btnCDGame.LookAndFeel.UseDefaultLookAndFeel = false;
            btnCDGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;

            DataRepository.Seat.Update(seatNumber, customer.CustomerID);

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Enabled = false;
            pausedTime = 0;
            timer1.Stop();
            timer2.Start();
            
            
            if (MessageBox.Show("사용을 종료하시겠습니까?", "사용종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Exit();
            }
            else
            {
                timer2.Stop();
                customer.RemainingTime -= pausedTime;
                lblRemainingTime.Text = "남은시간 : " + customer.RemainingTime.ToString() + " 분";
                timer1.Start();
                Enabled = true;
                return;
            }

        }
        private void Exit()
        {
            timer1.Stop();
            DataRepository.Seat.Update(seatNumber);
            DataRepository.Customer.Update(customer);
            DataRepository.Chatting.DeleteAll(false, int.Parse(seatNumber));
            Application.Exit();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
         
            PC_Project.Client.ChattingForm chatting = new PC_Project.Client.ChattingForm(int.Parse(seatNumber));
            chatting.ShowDialog();
        }

        private void btnFoodOrder_Click(object sender, EventArgs e)
        {
            FoodOrderForm Foodorder = new FoodOrderForm(seatNumber, customer);
            Foodorder.ShowDialog();
            LabelUpdate();
        }
        public void LabelUpdate()
        {
            RankCheck(customer.Payment);
            lblName.Text = "이름 : " + customer.Name.ToString();
            lblID.Text = "아이디 : " + customer.LoginID.ToString();
            lblSeat.Text = "좌석번호 : " + seatNumber;
            lblRank.Text = "등급 : " + customer.Rank.ToString();
            lblPayamount.Text = "금액 : " + customer.Payment.ToString();
            lblRemainingTime.Text = "남은시간 : " + customer.RemainingTime.ToString() + " 분";
        }

        private void RankCheck(int TotalPayment)
        {
            if (TotalPayment >= 30000 && TotalPayment < 60000)
                customer.Rank = 1;
            else if (TotalPayment >= 60000 && TotalPayment < 90000)
                customer.Rank = 2;
            else if (TotalPayment >= 90000 && TotalPayment < 120000)
                customer.Rank = 3;
            else if (TotalPayment >= 120000 && TotalPayment < 150000)
                customer.Rank = 4;
            else if (TotalPayment >= 150000)
                customer.Rank = 5;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            customer.RemainingTime = DataRepository.Customer.Get(customer.CustomerID).RemainingTime;
            customer.RemainingTime--;
            DataRepository.Customer.Update(customer);
            lblRemainingTime.Text = "남은시간 : " + customer.RemainingTime.ToString() + " 분";
            if (customer.RemainingTime <= 0)
            {
                timer1.Stop();
                customer.RemainingTime = 0;
                MessageBox.Show("사용시간이 종료되었습니다.");
                timer1.Start();
                Exit();          
            }

        }

        private void btnCDGame_Click(object sender, EventArgs e)
        {
            CallGames(201);
        }

        private void btnRPGGame_Click(object sender, EventArgs e)
        {
            CallGames(203);
        }

        private void btnFPSGame_Click(object sender, EventArgs e)
        {
            CallGames(202);
        }

        private void CallGames(int genreId)
        {
            if (this.genreId == 0)
            {
                gameBindingSource.DataSource = DataRepository.GameGenre.GetbyGenre(genreId);
                this.genreId = genreId;
                grdGames.Visible = true;
            }
            else if(genreId == this.genreId)
            {
                grdGames.Visible = false;
                this.genreId = 0;
            }
            else
            {
                gameBindingSource.DataSource = DataRepository.GameGenre.GetbyGenre(genreId);
                this.genreId = genreId;
            }
        }

        private void grdGames_DoubleClick(object sender, EventArgs e)
        {
            Game game = gameBindingSource.Current as Game;
            if (game == null)
                return;
            DataRepository.Game.ClickGame(game);

            List<Game> topGames = DataRepository.Game.TopFiveGame();
            lblGameNo1.Text = topGames[0] != null ? $"{1 }. {topGames[0].Name}" : $"{1 }. ";
            lblGameNo2.Text = topGames[1] != null ? $"{2 }. {topGames[1].Name}" : $"{2 }. ";
            lblGameNo3.Text = topGames[2] != null ? $"{3 }. {topGames[2].Name}" : $"{3 }. ";
            lblGameNo4.Text = topGames[3] != null ? $"{4 }. {topGames[3].Name}" : $"{4 }. ";
            lblGameNo5.Text = topGames[4] != null ? $"{5 }. {topGames[4].Name}" : $"{5 }. ";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pausedTime++;
        }
    }
}
