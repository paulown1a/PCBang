using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Project.Data
{
    public class GenreData : EntitiyData<Genre>
    {
        public Genre Get(int genreId)
        {
            PCBangEntities context = CreateContext();
            return context.Genres.FirstOrDefault(a => a.GenreID == genreId);
        }

        public void Delete(int GenreId)
        {
            Genre Genre = Get(GenreId);
            if (Genre == null)
                return;
            Delete(Genre);
        }
        public void AddPhoth(int genreId, string filePath)
        {
            var genre = Get(genreId);

            if (genre == null)
                return;

            genre.Photo = File.ReadAllBytes(filePath);

            Update(genre);
        }
    }
}
