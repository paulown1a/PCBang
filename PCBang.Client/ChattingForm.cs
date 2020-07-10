using loginform;
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

namespace PC_Project.Client
{
    public partial class ChattingForm : Form
    {
        private int SeatId { get; set; }
        public ChattingForm()
        {
            InitializeComponent();
        }

        public ChattingForm(int seatId) : this()
        {
            this.SeatId = seatId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChattingForm_Load(object sender, EventArgs e)
        {
            ChattingTimer.Start();
            bdsChatting.DataSource = DataRepository.Chatting.GetNotRead(false, SeatId);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Chatting chatting = new Chatting();
            chatting.Checked = false;
            chatting.Sent = true;
            chatting.Text = txbText.Text;
            chatting.SendTIme = DateTime.Now;
            chatting.SeatID = SeatId;
            DataRepository.Chatting.Insert(chatting);
            txbText.Text = "";
            txbText.Select(0, 0);

            MessageBox.Show("발송되었습니다.");
        }

        private void ChattingTimer_Tick(object sender, EventArgs e)
        {
            bdsChatting.DataSource = DataRepository.Chatting.GetNotRead(false, SeatId);
        }

        private void txbText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSend_Click(this, e);
            }
        }
    }
}
