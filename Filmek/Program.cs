using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<Film> filmek = new List<Film>()
        {
            new Film ("Film1", 1000),
            new Film("Film2", 2000),
            new AkcioFilm(16 ,"AkcioFilm1", 3000),
            new AkcioFilm(18 ,"AkcioFilm2", 500),
        };
            Film legolcsobb = filmek.OrderBy(item => item.ar).First();
            Console.WriteLine(legolcsobb);

            Console.ReadKey();
        }
    }
}
