using MainPage;
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

namespace loginform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "")
            {
                MessageBox.Show("ID를 입력해주세요.");
                return;
            }
            if (txbPassword.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }

            Customer customer = DataRepository.Customer.Login(txbID.Text, txbPassword.Text);
            if (customer == null)
                MessageBox.Show("사용자 정보가 올바르지 않습니다.");
            else if(DataRepository.Seat.LoginCheck(customer.CustomerID))
                    MessageBox.Show("이미 사용중인 사용자 입니다.");
            else if(customer.RemainingTime <=0 )
                MessageBox.Show("잔여시간이 부족합니다.");


            else
            {
                MessageBox.Show("로그인 되었습니다.");
                String seatNumber = cbbSeat.Text;
                MainPageForm MainPage = new MainPageForm(customer, seatNumber);
                MainPage.ShowDialog();
            }

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            NewAccountForm NewAccount = new NewAccountForm();
            NewAccount.ShowDialog();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            List<Seat> seats = DataRepository.Seat.GetAll();
            seatBindingSource.DataSource = seats.FindAll(x => x.CustomerID == null);
        }

        private void cbbSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                bntLogin_Click(this, e);

        }
    }
}
