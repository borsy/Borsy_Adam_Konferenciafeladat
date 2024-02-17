using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Borsy_Adam_Konferenciafeladat
{
    internal class Adatbazis_kapcsolat
    {
        MySqlCommand sql_parancsok = null;
        MySqlConnection adatbazis_kapcsolat = null;

        public Adatbazis_kapcsolat()
        {
            MySqlConnectionStringBuilder mscsb = new MySqlConnectionStringBuilder();
            mscsb.Server = "localhost";
            mscsb.UserID = "root";
            mscsb.Password = "";
            mscsb.Database = "konferencia";
            mscsb.CharacterSet = "utf8";

            adatbazis_kapcsolat = new MySqlConnection(mscsb.ConnectionString);
            sql_parancsok = adatbazis_kapcsolat.CreateCommand();
        }
    }
}
