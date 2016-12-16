using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static string cns = @"server=(localdb)\MSSQLLocalDB;Database=NORTHWND;Trusted_Connection=Yes";
        static void Main(string[] args)
        {
            //FreightByShipper();
        }

        public static void OrdersByCustomerCompanyName(string CompanyName)
        {

        }

        public static void FreightByShipper()
        {
            string queryString =
            @"SELECT ShipVia, Avg(Freight) AS AverageFreight, CompanyName
              FROM Orders INNER JOIN
              Shippers ON Orders.ShipVia = Shippers.ShipperID
              GROUP BY ShipVia, CompanyName;";

            using (SqlConnection connection = new SqlConnection(cns))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.Write("Sum: " + reader.GetValue(1));
                    Console.WriteLine(" Company Name: " + reader.GetString(2));
                    Console.WriteLine("=====================================");
                }
                reader.Close();

            }
        }

        public static void CustomersPerSupplier()
        {

        }
    }
}
