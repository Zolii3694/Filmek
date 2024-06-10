using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek
{
    class Film
    {
        public string cim { get; }
        public int ar { get; }
        List<int> ertekelesek;

        public Film(string cim, int ar)
        {
            this.ar = ar;
            this.cim = cim;
            ertekelesek = new List<int>();
        }

        public virtual void Ertekel(int ertek)
        {
            if(ertek < 6 && ertek > 0)
            {
                if(ertek >= 10)
                {
                    throw new Exception($"{cim} cimu filmre nem mentheto a(z) {ertek} ertekeles.");
                }
                ertekelesek.Add(ertek);
            }
        }

        public double Atlag
        {
            get
            {
                if(ertekelesek.Count == 0) {
                    throw new Exception($"{this} objektumra meg nem erkezett ertekeles");
                }
                return ertekelesek.Average();
            }
        }

        public override string ToString()
        {
            return $"Cim: {cim}; Ar: {ar}";
        }
    }
}
