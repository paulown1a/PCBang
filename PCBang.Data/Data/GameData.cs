using PC_Project.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class GameData : EntitiyData<Game>
    {
        public Game Get(int gameId)
        {
            PCBangEntities context = CreateContext();
            return context.Games.FirstOrDefault(a => a.GameID == gameId);
        }

        public void Delete(int gameId)
        {
            Game Game = Get(gameId);
            if (Game == null)
                return;
            Delete(Game);
        }

        public void ClickGame(Game game)
        {
            Game target = Get(game.GameID);
            target.PlayCount++;
            Update(target);
        }

        public List<Game> TopFiveGame()
        {
            PCBangEntities context = CreateContext();
            List<Game> games = GetAll();
            return games.OrderByDescending(x => x.PlayCount).ToList();
        }

        public void AddPhoto(int gameId, string filePath)
        {
            var game = Get(gameId);

            if (game == null)
                return;

            game.Photo = File.ReadAllBytes(filePath);

            Update(game);
        }
    }
}
