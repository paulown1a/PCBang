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
    public partial class ManagerLoginform : Form
    {
        public ManagerLoginform()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtPassword.Text == "1234")
            {
                Managerform manager = new Managerform();
                ShowInTaskbar = false;
                Opacity = 0;
                manager.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(this, e);
        }
        
    }
}
//