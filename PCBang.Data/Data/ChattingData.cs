using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class ChattingData : EntitiyData<Chatting>
    {
        public Chatting Get(int chattingId)
        {
            PCBangEntities context = CreateContext();
            return context.Chattings.FirstOrDefault(a => a.ChattingID == chattingId);
        }

        public void Delete(int chattingId)
        {
            Chatting chatting = Get(chattingId);
            if (chatting == null)
                return;
            Delete(chatting);
        }

        public List<Chatting> GetNotRead(bool sent)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Chattings
                        where x.Sent == sent && x.Checked == false
                        select x;

            return query.ToList();
        }

        public List<Chatting> GetNotRead(bool sent, int seatId)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Chattings
                        where x.Sent == sent && x.Checked == false && x.SeatID == seatId
                        select x;
            return query.ToList();
        }

        public List<Chatting> GetNotRead(bool sent, int seatid)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Chattings
                        where x.Sent == sent && x.Checked == false && x.SeatID == seatid
                        select x;
            return query.ToList();
        }

        public void UpdateAll(bool sent)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Chattings
                        where x.Sent == sent && x.Checked == false
                        select x;
            var chattings = query.ToList();
            foreach (var chatting in chattings)
            {
                chatting.Checked = true;
                Update(chatting);
            }
        }

        public void UpdateAll(bool sent, int seatid)
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Chattings
                        where x.Sent == sent && x.Checked == false && x.SeatID == seatid
                        select x;
            var chattings = query.ToList();
            foreach (var chatting in chattings)
            {
                chatting.Checked = true;
                Update(chatting);
            }
        }
    }
}
