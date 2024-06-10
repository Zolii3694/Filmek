using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    class AkcioFilm: Film, IKorhataros
    {
        int korhatar;

        public AkcioFilm(int korhatar,string cim, int ar)
            :base(cim,ar)
        {
            this.korhatar = korhatar;
        }

        public override void Ertekel(int ertek)
        {
            if(ertek != 5)
            {
            base.Ertekel(ertek);
            }
        }

        public int Korhatar
        {
            get
            {
                return korhatar;
            }
        }

        public int Buntetes(int eletkor)
        {
            return (korhatar - eletkor) * ar;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Korhatar: {korhatar}";
        }
    }
}
