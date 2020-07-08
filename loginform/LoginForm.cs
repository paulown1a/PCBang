using Dbdata;
using MainPage;
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

        private void simpleButton1_Click(object sender, EventArgs e)
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

            //CustomerData Customer = new CustomerData();
            Customer customer = DataRepository.Customer.Login(txbID.Text, txbPassword.Text);
            if (customer == null)
                MessageBox.Show("사용자 정보가 올바르지 않습니다.");
            else
            {
                MessageBox.Show("로그인 되었습니다.");
                String seatNumber = cbbSeat.Text;
                MainPageForm MainPage = new MainPageForm(customer, seatNumber);
                MainPage.Show();
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
            //NewAccount.CenterToScreen();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            List<Seat> seats = DataRepository.Seat.GetAll();
            seatBindingSource.DataSource = seats.FindAll(x => x.CustomerID == null);
        }

        private void cbbSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
