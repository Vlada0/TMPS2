using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns1
{
    public interface ITarget //интерфейс, с которым может работать клиент
    {
        List<string> GetFilmList();
    }
    // Адаптер делает интерфейс Адаптируемого класса совместимым с целевым
    // интерфейсом.
    class Adapter : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public List<string> GetFilmList()
        {
            List<string> filmList = new List<string>();
            string[] films = adaptee.GetFilms();
            foreach (string film in films)
            {
                filmList.Add(film);
            }

            return filmList;
        }
    }

    class Adaptee //адаптируемый класс, его интерфейс несовместим с существующим клиентским кодом
    {

        public string[] GetFilms()
        {
            string[] films = new string[4];

            films[0] = "1:20 " + "Armagedon";
            films[1] = "2:10 " + "One day";
            films[2] = "1:50 " + "Titanic";
            films[3] = "1:40 " + "Perl Harbor";

            return films;
        }
    }

}
