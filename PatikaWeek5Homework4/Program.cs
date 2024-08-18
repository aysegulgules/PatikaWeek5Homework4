using PatikaWeek5Homework4;
//Film tipinde liste tanımlanıyor..
List<Film> films = new List<Film>();


 while (true)
{
        Film film = new Film();
        Console.WriteLine("\nLütfen film adı giriniz..: ");
        film.Name = Console.ReadLine();
        Console.WriteLine("Lütfen filmin IMDB puanını giriniz..:");
ImdbGo: if (Double.TryParse(Console.ReadLine(), out double ImdbRating))
        {
            film.ImdbRating = ImdbRating;
        }
        else 
        {
            Console.WriteLine("Geçersiz giriş.Lütfen IMDB puanını giriniz..: ");
            goto ImdbGo;
        }
        films.Add(film);//listeye yeni film bilgisi ekleniyor.

filmGo: Console.WriteLine("\nYeni bir film eklemek ister misiniz?(e/h)");
    var continueFilm = Console.ReadLine().ToLower();
    if (continueFilm == "h")
    {
        break;
    }
    if (continueFilm != "e")
    { 
        Console.WriteLine("Geçersiz giriş.");
        goto filmGo;
    }
}


 //Listedeki tüm filimler ekleniyor.
Console.WriteLine("\nEklediğiniz filmlerin listelesi.....:");
 foreach(Film film1 in films)
{
   film1.FilmInfo();

}



Console.WriteLine("\n Imdb puanı 4 ile 9 arasında olan filmlerin listelesi..:");
var imdbFilms=films.Where(f=> f.ImdbRating >= 4 && f.ImdbRating <= 9);// 4 ile 9 puan arası almış filmleri numaralandırıyor
foreach (Film film1 in imdbFilms)
{
    
        film1.FilmInfo();

}

//
Console.WriteLine("\n İsmi 'A' ile başlayan filmler ve imdb puanları listelesi.....:");
var aLetterFilms = films.Where(f => f.Name.StartsWith("A",StringComparison.CurrentCultureIgnoreCase));// A ile başlayan filmleri numaralandırıyor
foreach (Film film1 in aLetterFilms)
{        
        film1.FilmInfo();
}