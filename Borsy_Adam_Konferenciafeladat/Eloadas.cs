using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borsy_Adam_Konferenciafeladat
{
    internal class Eloadas
    {
        readonly int Eloadas_id;
        string cim;
        int sorok;
        int szekek;
        int[,] ertekeles;

        public int Eloadasid => Eloadas_id;
        public string Cim { get => cim; set => cim = value;}
        public int Sorok { get => sorok; set => sorok = value;}
        public int Szekek { get => szekek; set => szekek = value;}
        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value;}

        public Eloadas(int eloadas_id, string cim, int sorok, int szekek)
        {
            Eloadas_id = eloadas_id;
            Cim = cim;
            Sorok = sorok;
            Szekek = szekek;
            Ertekeles = ertekeles;
        }
    }
}
