using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PI
{
    class Spajanje
    {
        private static Spajanje instance; //Singleton objekt
        private string connectionString; //Putanja i ostali podaci za spajanje na bazu
        private SqlConnection connection; //Konekcija prema bazi
        public static Spajanje Instance //Singleton instanca klase za rad za bazom.
        {
            get
            {
                if (instance == null)
                {
                    instance = new Spajanje();
                }
                return instance;
            }
        }
        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }
        public SqlConnection Connection //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }
            private Spajanje() //Konstruktor klase
{
ConnectionString = @"Data Source=161.53.120.217\VARAZDIN,1433;Initial Catalog=pi2013tetivadb;User ID=pi2013tetiva;Password=pi2013tetiva";
Connection = new SqlConnection(ConnectionString);
Connection.Open();
}
~Spajanje() //Destruktor klase
{
Connection.Close();
Connection = null;
}
        /// <summary>
/// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.
/// </summary>
/// <param name="sqlUpit">SQL upit.</param>
/// <returns>Rezultati upita.</returns>
public SqlDataReader DohvatiDataReader(string sqlUpit)
{
SqlCommand command = new SqlCommand(sqlUpit, Connection);
return command.ExecuteReader();
}
/// <summary>
/// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
/// </summary>
/// <param name="sqlUpit">SQL upit.</param>
/// <returns>Skalarna vrijednost kao rezultat upita.</returns>
public object DohvatiVrijednost(string sqlUpit)
{
SqlCommand command = new SqlCommand(sqlUpit, Connection);
return command.ExecuteScalar();
}
/// <summary>
/// Izvršava INSERT, UPDATE, DELETE SQL izraz.
/// </summary>
/// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
/// <returns>Broj redaka u tablici koji su promijenjeni.</returns>
public int IzvrsiUpit(string sqlUpit)
{
SqlCommand command = new SqlCommand(sqlUpit, Connection);
return command.ExecuteNonQuery();
}




       

    }

}
