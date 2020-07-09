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
using PC_Project.Data;

namespace ManagerForm
{

    public partial class ManagerChattingform : DevExpress.XtraEditors.XtraForm
    {
        public ManagerChattingform()
        {
            InitializeComponent();
        }

        private void ManagerChattingform_Load(object sender, EventArgs e)
        {
            dbsSeat.DataSource = DataRepository.Seat.GetUsing();
            dbsChatting.DataSource = DataRepository.Chatting.GetNotRead(true);
        }

        private void cbbSeat_DropDown(object sender, EventArgs e)
        {
            dbsSeat.DataSource = DataRepository.Seat.GetUsing();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DataRepository.Chatting.UpdateAll(true);
            Close();
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Chatting chatting = new Chatting();
            chatting.Checked = false;
            chatting.Sent = false;
            chatting.Text = txbText.Text;
            chatting.SendTIme = DateTime.Now;
            chatting.SeatID = (int)cbbSeat.SelectedValue;
            DataRepository.Chatting.Insert(chatting);
            MessageBox.Show("발송되었습니다.");
        }

        private void txbText_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txbText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(this, e);
                txbText.Select(0, 0);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Chatting chatting = dbsChatting.Current as Chatting;
            chatting.Checked = true;
            DataRepository.Chatting.Update(chatting);

            dbsChatting.DataSource = DataRepository.Chatting.GetNotRead(true);

        }
    }
}