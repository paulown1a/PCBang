using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class SeatData : EntitiyData<Seat>
    {
        public Seat Get(int seatId)
        {
            PCBangEntities context = CreateContext();
            return context.Seats.FirstOrDefault(a => a.SeatID == seatId);
        }

        public void Delete(int seatId)
        {
            Seat seat = Get(seatId);
            if (seat == null)
                return;
            Delete(seat);
        }

        public object GetUsing()
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Seats
                        where x.CustomerID != null
                        select x;

            return query.ToList();
        }

        public void Update(string seatId, int? customerID = null)
        {
            Seat seat = Get(int.Parse(seatId));
            if (seat == null)
                return;
            seat.CustomerID = customerID;
            Update(seat);
        }

    }
}
