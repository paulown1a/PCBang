using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class GameUsingListData : EntitiyData<GameUsingList>
    {
        public GameUsingList Get(int gameId, int customerId)
        {
            PCBangEntities context = CreateContext();
            return context.GameUsingLists.FirstOrDefault(a => a.GameID == gameId && a.CustomerID == customerId);
        }

        public void Delete(int gameId, int customerId)
        {
            GameUsingList gameUsingList = Get(gameId, customerId);
            if (gameUsingList == null)
                return;
            Delete(gameUsingList);
        }

        public Dictionary<Game> TopFiveGame()
        {
            PCBangEntities context = CreateContext();
            var query = from x in context.GameUsingLists
                        select x.Game;
            Dictionary<Game, int> count = new Dictionary<Game, int>();
            var games = query.ToList();
            foreach (var game in games)
                if (count.ContainsKey(game))
                    count[game]++;
                else
                    count.Add(game, 1);
            count.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                return count;
            
        }
    }
}
