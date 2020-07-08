using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public static class DataRepository
    {
        public static SeatData Seat { get; } = new SeatData();
        public static CustomerData Customer { get; } = new CustomerData();
        public static ProductData Product { get; } = new ProductData();
        public static CodeData Code { get; } = new CodeData();
        public static OrderData Order { get; } = new OrderData();
        public static ChattingData Chatting { get; } = new ChattingData();
        public static ProductData Products { get; set; } = new ProductData();
    }
}
