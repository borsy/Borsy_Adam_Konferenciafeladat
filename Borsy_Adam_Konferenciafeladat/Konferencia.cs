using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borsy_Adam_Konferenciafeladat
{
    public class Konferencia
    {
        public List<Eloadas> konferencia_adatok_beolvasas()
        {
            List<Eloadas> eloadas = new List<Eloadas>();
            //sql.CommandText = "SELECT * FROM ertekelesek NATURAL JOIN eloadasok";
            sql_parancsok = "SELECT * FROM `ertekelesek` INNER JOIN eloadasok ON eloadasok.eloadasid=ertekelesek.eloadasid;";
        }
}
