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
        public GameGenre Get(int gameId, int genreId)
        {
            PCBangEntities context = CreateContext();
            return context.GameGenres.FirstOrDefault(a => a.GameID == gameId && a.GenreID == genreId);
        }

        public void Delete(int gameId, int genreId)
        {
            GameGenre gameGenre = Get(gameId, genreId);
            if (gameGenre == null)
                return;
            Delete(gameGenre);
        }
    }
}
