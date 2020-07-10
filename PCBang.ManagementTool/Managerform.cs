using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Managerform;
using PC_Project.Data;

namespace ManagerForm
{
    //hi
    public partial class Managerform : DevExpress.XtraEditors.XtraForm
    {
        public Managerform()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            List<Seat> seats = DataRepository.Seat.GetAll();
            bdsSeat.DataSource = seats;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Seat seat = bdsSeat.Current as Seat;

            if (seat.CustomerID == null) 
                return;

            AddTimeform addTimeform = new AddTimeform(seat.CustomerID);
            addTimeform.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            Seat seat = bdsSeat.Current as Seat;

            if (seat == null)
                return;

            lblSeat.Text = seat.SeatID.ToString();
            if (seat.CustomerID != null)
            {
                Customer customer = DataRepository.Customer.Get(seat.CustomerID.Value);
                lblName.Text = customer.Name;
                lblId.Text = customer.LoginID.ToString();
                lblRemainingTime.Text = customer.RemainingTime.ToString();
                lblRank.Text = customer.Rank.ToString();
            }
            else
            {
                lblName.Text = "--";
                lblId.Text = "--";
                lblRemainingTime.Text = "--";
                lblRank.Text = "--";
            }
            }

        private void btnAddtime_Click(object sender, EventArgs e)
        {
            AddTimeform addtimeform = new AddTimeform();
            addtimeform.Show();
            
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ManageCustomerform deletecustomerform = new ManageCustomerform();
            deletecustomerform.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            Revenueform revenueform = new Revenueform();
            revenueform.Show();
        }

        private void btnChatting_Click(object sender, EventArgs e)
        {
            ManagerChattingform managerChattingform = new ManagerChattingform();
            managerChattingform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Seat> seats = DataRepository.Seat.GetAll();
            bdsSeat.DataSource = seats;
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProductform manageProductform = new ManageProductform();
            manageProductform.Show();
        }
    }
}