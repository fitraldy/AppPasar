using System.Data.SqlClient;
using System.Data.Common;
class Program
{
    static void Main()
    {
        SqlConnection conn = null;
        try
        {
            conn = new SqlConnection(@"server=HAPIPILO\SQLEXPRESS;Database=CompanyDB;Trusted_Connection=True;"); //connection database
            //Native Query
            SqlCommand cmd = new SqlCommand(@"create table Distributor (PenjualName varchar(100), Barang varchar(50), Harga int not null)", conn);
            SqlCommand cmd2 = new SqlCommand(@"create table Pembeli (PembeliName varchar(100), Barang varchar(50), Harga int not null)", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            Console.WriteLine("Connect and create succesfull");
        }
        finally
        {
            conn.Close();
            Console.WriteLine("close connection!!");
        }

    }
}