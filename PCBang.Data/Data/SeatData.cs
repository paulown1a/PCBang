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

        public List<Seat> GetUsing()
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Seats
                        where x.CustomerID != null
                        select x;

            return query.ToList();
        }

        public List<Seat> GetWithCustomer()
        {
            PCBangEntities context = CreateContext();
            var query = from x in context.Seats
                        select new { Seat = x, CustomerName = x.Customer.Name, RemainingTime = x.Customer == null ? 0:x.Customer.RemainingTime };
            var list = query.ToList();
            
            foreach (var x in list)
            {
                x.Seat.RemainingTime = x.RemainingTime;
                x.Seat.CustomerName = x.CustomerName;
            }

            return list.ConvertAll(x => x.Seat);
        }

        public void Update(string seatId, int? customerId = null)
        {
            Seat seat = Get(int.Parse(seatId));
            if (seat == null)
                return;
            seat.CustomerID = customerId;
            Update(seat);
        }

        public bool LoginCheck(int customerId)
        {
            PCBangEntities context = CreateContext();

            return context.Seats.FirstOrDefault(a => a.CustomerID == customerId) == null ? false : true;
        }

        public List<Seat> GetCanUse()
        {
            PCBangEntities context = CreateContext();

            var query = from x in context.Seats
                        where x.CustomerID == null && x.Breakdown == false
                        select x;

            return query.ToList();
        }
    }
}
