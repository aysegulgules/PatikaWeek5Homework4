using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5Homework4
{
    internal class Film
    {
        public string Name{ get; set; }
        public double ImdbRating { get; set; }

        public void FilmInfo()
        {
            Console.WriteLine($"Film Adı..:{Name} Imdb Puanı..:{ImdbRating}");
        }
    }
}
