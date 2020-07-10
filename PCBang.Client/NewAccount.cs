using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using System.Runtime.Remoting;
using DevExpress.Utils.VisualEffects;
using PC_Project.Data;

// good morning 09:46
//bye mornig 10:01
// ending 1003

namespace loginform
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txbName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }
            
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

            if (txbPasswordConfirm.Text == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                return;
            }
            if (txbPasswordConfirm.Text != txbPassword.Text)
            {
                MessageBox.Show("비밀번호가 일치하지않습니다.");
                return;
            }
            


            String Name = txbName.Text;
            String ID = txbID.Text;
            String Password = txbPassword.Text;

            if (DataRepository.Customer.CanUseId(ID))
            {
                DataRepository.Customer.Insert(Name, ID, Password);
                MessageBox.Show("가입 되었습니다.");
            }
            else
                MessageBox.Show("이미 사용중인 ID 입니다.");

            
            this.Close();
            
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
        }

        private void txbPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            txbPasswordConfirm.PasswordChar = '*';
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
