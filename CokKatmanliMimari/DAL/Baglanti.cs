using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;  // gerekli kütüphane eklendi
using System.Data;       // gerekli kütüphane eklendi

namespace DAL
{
    class Baglanti
    {
        //Veri tabanı ile bağlantı işlemi gerçekleştirildi
        public static OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Database1.mdb");
        public static void Connection(OleDbCommand command)
        {

            if(command.Connection.State!=ConnectionState.Open)
            {
                command.Connection.Open();
            }
        }
    }


}
