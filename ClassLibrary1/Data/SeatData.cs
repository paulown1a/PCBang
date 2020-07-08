using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    class SeatData : EntitiyData<Seat>
    {
        public Seat Get(int seatId)
        {
            PCUIEntities context = CreateContext();
            return context.Seats.FirstOrDefault(a => a.SeatID == seatId);
        }

        public void Delete(int seatId)
        {
            Seat seat = Get(seatId);
            if (seat == null)
                return;
            Delete(seat);
        }
    }
}
