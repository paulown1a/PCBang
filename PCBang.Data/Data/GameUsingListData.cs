using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        
    }
}
