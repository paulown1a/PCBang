using Dbdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public static class DataRepository
    {
        public static ChattingData Chatting { get; } = new ChattingData();
        public static CodeData Code { get; } = new CodeData();
        public static CustomerData Customer { get; } = new CustomerData();
        public static GameData Game { get; } = new GameData();
        public static GameGenreData GameGenre { get; } = new GameGenreData();
        public static GameUsingListData GameUsingList { get; } = new GameUsingListData();
        public static OrderData Order { get; } = new OrderData();
        public static ProductData Product { get; } = new ProductData();
        public static SeatData Seat { get; } = new SeatData();
    }
}
