using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbdata
{
    class GameGenreData : EntitiyData<GameGenre>
    {
        public GameGenre Get(int gameId, int codeId)
        {
            PCUIEntities context = CreateContext();
            return context.GameGenres.FirstOrDefault(a => a.GameID == gameId && a.CodeID == codeId);
        }

        public void Delete(int gameId, int codeId)
        {
            GameGenre gameGenre = Get(gameId, codeId);
            if (gameGenre == null)
                return;
            Delete(gameGenre);
        }
    }
}
