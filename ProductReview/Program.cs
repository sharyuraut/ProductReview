using System;
using System.Data;
using System.Linq;

namespace ProductReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ-Product Review Program!");

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "A");
            table.Rows.Add("2", "B");
            table.Rows.Add("3", "C");

            Program inst = new Program();
            inst.DisplayProducts(table);

        }

        private void DisplayProducts(DataTable table)
        {
            var productNames = from products in table.AsEnumerable() select products.Field<string>("ProductName");
            Console.WriteLine("Product Names: ");
            foreach(string productName in productNames)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
