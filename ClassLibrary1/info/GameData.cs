using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    public class GameData : EntitiyData<Game>
    {
        public Game Get(int gameId)
        {
            PCUIEntities context = CreateContext();
            return context.Games.FirstOrDefault(a => a.GameID == gameId);
        }

        public void Delete(int gameId)
        {
            Game Game = Get(gameId);
            if (Game == null)
                return;
            Delete(Game);
        }
    }
}
