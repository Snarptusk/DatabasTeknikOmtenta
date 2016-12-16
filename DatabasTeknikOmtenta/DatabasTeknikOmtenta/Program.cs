using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabasTeknikOmtenta;

namespace ConsoleApplication1
{
    class Program
    {
        static string cns = @"server=(localdb)\MSSQLLocalDB;Database=NORTHWND;Trusted_Connection=Yes";
        static void Main(string[] args)
        {
            //OrdersByCustomerCompanyName("randomname");

            //FreightByShipper();

            //CustomersPerSupplier();

            //SupplierForProduct(5);

            //OrderDetailsInPriceRange(10, 20);

            //AddToy();

            Console.ReadLine();
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

        public static void SupplierForProduct(int productID)
        {

            using (var db = new NORTHWNDContext())
            {
                foreach (var item in db.Products)
                {
                    if (item.ProductID == productID)
                    {
                        Console.WriteLine(item.ProductName);
                        Console.WriteLine("=====================");
                    }
                }
            }
        }

        public static void OrderDetailsInPriceRange(int LowestPriceInclusive, int HighestPriceInclusive)
        {
            using (var db = new NORTHWNDContext())
            {
                foreach (var item in db.Products)
                {
                    if (item.UnitPrice > LowestPriceInclusive && item.UnitPrice < HighestPriceInclusive)
                    {
                        Console.WriteLine("Item name: " + item.ProductName + ".");
                        Console.WriteLine("Product price: " + item.UnitPrice + ".");
                        Console.WriteLine("============================================");
                    }
                }
            }
        }

        public static void AddToy()
        {
            Console.Write("Input a toy ID: ");
            string toyId = Console.ReadLine();

            Console.Write("Input a toy description: ");
            string description = Console.ReadLine();

            Console.Write("Was the toy made by santa? (1 = Yes, 0 = No): ");
            string MadeBySanta = Console.ReadLine();

            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "AddToy(Description, MadeBySanta)";
            cmd.Parameters.AddWithValue("@ToyID", toyId);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@MadeBySanta", MadeBySanta);

            cmd.ExecuteNonQuery();
            cn.Close();

            Console.WriteLine("=======================================");
            Console.WriteLine("Toy added!");
            Console.WriteLine("=======================================");
        }
    }
}
