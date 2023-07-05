using RestaurantSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Controller.PurchaseController
{
    public class PO_NumberGenerator
    {
        private static string connectionString = @"Data Source=.;Initial Catalog=JRestaurantSystem;Integrated Security=True";
        private static PurchaseOrderDbContext dbContext;

        private static int nextPurchaseOrder = 1;
        public static async Task<string> GeneratePurchaseNumber()
        {
            dbContext = new PurchaseOrderDbContext(connectionString);
            int dateToday = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            //int dateToday = 20230628;

            string existingNumber;
            string newPurchaseNumber;
            int purchaseOrderNumber;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CUSTOMER_ORDERS WHERE PurchaseNumber LIKE @date ORDER BY PurchaseNumber DESC";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", $"{dateToday}%");
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            existingNumber = reader.GetString(reader.GetOrdinal("PurchaseNumber"));
                            string lastFourNumbers = existingNumber.Substring(existingNumber.Length - 4);
                            int existingPurchaseNumber = int.Parse(lastFourNumbers);
                            purchaseOrderNumber = existingPurchaseNumber + 1;
                            newPurchaseNumber = $"{dateToday}-{purchaseOrderNumber:D4}";
                        }
                        else
                        {
                            purchaseOrderNumber = nextPurchaseOrder++;
                            newPurchaseNumber = $"{dateToday}-{purchaseOrderNumber:D4}";
                        }
                    }
                }
            }
            return newPurchaseNumber;
        }
    }
}
