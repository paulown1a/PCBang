using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public class ChattingData : EntitiyData<Chatting>
    {
        public Chatting Get(int chattingId)
        {
            PCUIEntities context = CreateContext();
            return context.Chattings.FirstOrDefault(a => a.ChattingID == chattingId);
        }

        public void Delete(int chattingId)
        {
            Chatting chatting = Get(chattingId);
            if (chatting == null)
                return;
            Delete(chatting);
        }
    }
}
