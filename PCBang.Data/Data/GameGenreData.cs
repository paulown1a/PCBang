using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class GameGenreData : EntitiyData<GameGenre>
    {
        public GameGenre Get(int gameId, int codeId)
        {
            PCBangEntities context = CreateContext();
            return context.GameGenres.FirstOrDefault(a => a.GameID == gameId && a.CodeID == codeId);
        }

        public void Delete(int gameId, int codeId)
        {
            GameGenre gameGenre = Get(gameId, codeId);
            if (gameGenre == null)
                return;
            Delete(gameGenre);
        }

        public List<Game> GetbyGenre(int codeId)
        {
                PCBangEntities context = CreateContext();
            var query = from x in context.GameGenres
                        where x.CodeID == codeId
                        select x.Game;
            return query.ToList();
        }
    }
}
