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
            bdsChatting.DataSource = DataRepository.Chatting.GetNotRead(false, SeatId);
        }
    }
}
