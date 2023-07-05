using RestaurantSystem.Model.ClassProperties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace RestaurantSystem.Model
{

    /*
     
     */

    public class PurchaseOrderDbContext
    {
        private string connString;
        public PurchaseOrderDbContext(string connString)
        {

            this.connString = connString;

        }

        private async Task<SqlConnection> CreateConnection()
        {
            SqlConnection conn = new SqlConnection(connString);
            await conn.OpenAsync();
            return conn;
        }

        public async Task InsertPurchaseOrderAsync(PurchaseOrderModel purchaseOrder)
        {
            SqlConnection conn =  await CreateConnection();
            SqlCommand cmd;
            string query = "INSERT INTO CUSTOMER_ORDERS(PurchaseNumber, DishId, Quantity, OrderNote, ServiceOption, TotalPayment, Cash, Change, Discount, Status) " +
                            $"VALUES (@purchaseNumber,@dishID,@quantity,@orderNote,@serviceOption,@totalPayment,@cash,@change,@discount,@status)";
            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@purchaseNumber", purchaseOrder.OrderNumber);
                cmd.Parameters.AddWithValue("@dishID", purchaseOrder.DishId);
                cmd.Parameters.AddWithValue("@quantity", purchaseOrder.Quantity);
                cmd.Parameters.AddWithValue("@orderNote", purchaseOrder.OrderRequest);
                cmd.Parameters.AddWithValue("@serviceOption", purchaseOrder.ServiceOption);
                cmd.Parameters.AddWithValue("@totalPayment", purchaseOrder.TotalPayment);
                cmd.Parameters.AddWithValue("@cash", purchaseOrder.Cash);
                cmd.Parameters.AddWithValue("@change", purchaseOrder.Change);
                cmd.Parameters.AddWithValue("@discount", purchaseOrder.Discount);
                cmd.Parameters.AddWithValue("@status", purchaseOrder.Status);

                await cmd.ExecuteNonQueryAsync();
            }
            conn.Close();
        }

        public async Task<List<PurchaseOrderModel>> RetrieveOrderNumberAsync(string service, string date, string status)
        {
            List<PurchaseOrderModel> ListOrderNumbers = new List<PurchaseOrderModel> ();
            using(SqlConnection conn = await CreateConnection())
            {
                string query = $"SELECT DISTINCT PurchaseNumber FROM CUSTOMER_ORDERS WHERE ServiceOption = @service AND Status = @status AND PurchaseNumber LIKE @dateToday ORDER BY PurchaseNumber DESC";
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("service", service);
                    cmd.Parameters.AddWithValue("dateToday", $"{date}%");
                    cmd.Parameters.AddWithValue("status", status);
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                    { 
                        while (await reader.ReadAsync())
                        {
                            PurchaseOrderModel model = new PurchaseOrderModel()
                            {
                                OrderNumber = reader.GetString(reader.GetOrdinal("PurchaseNumber")),
                            };
                            ListOrderNumbers.Add(model);
                        }
                    }
                }
            }
            return ListOrderNumbers;
        }

        public async Task<List<PurchaseOrderModel>> RetrieveOrderDataAsync(string orderNumber)
        {
            List<PurchaseOrderModel> ListPurchaseOrders = new List<PurchaseOrderModel> ();
            using(SqlConnection con = await CreateConnection())
            {
                string query = "SELECT * FROM CUSTOMER_ORDERS WHERE PurchaseNumber = @orderNumber";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@orderNumber", orderNumber);
                    using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while(await reader.ReadAsync())
                        {
                            PurchaseOrderModel purchaseOrder = new PurchaseOrderModel()
                            {
                                OrderNumber = reader.GetString(1),
                                DishId = reader.GetInt32(2),
                                Quantity = reader.GetInt32(3),
                                OrderRequest = reader.GetString(4),
                                ServiceOption = reader.GetString(5),
                                TotalPayment = reader.GetDecimal(6),
                                Cash = reader.GetDecimal(7),
                                Change = reader.GetDecimal(8),
                                Discount = reader.GetDecimal(9)
                            };
                            ListPurchaseOrders.Add(purchaseOrder);
                        }
                    }
                }
            }
            return ListPurchaseOrders;
        }

        public async Task<List<OrderObjectModel>> RetrieveOrderModelAsync(string orderNumber)
        {
            List<OrderObjectModel> listCurrrentOrder = new List<OrderObjectModel>();
            using(SqlConnection conn = await CreateConnection())
            {
                string query = "SELECT [PurchaseNumber], t2.DishId, t2.Name, [Quantity], [OrderNote] " +
                                "FROM [JRestaurantSystem].[dbo].[CUSTOMER_ORDERS] t1 INNER JOIN [JRestaurantSystem].[dbo].[DISHES] " +
                                "t2 ON t1.DishID = t2.DishId WHERE PurchaseNumber = @purchaseNumber";
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("purchaseNumber", orderNumber);
                    using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            OrderObjectModel order = new OrderObjectModel()
                            {
                                DishId = reader.GetInt32(reader.GetOrdinal("DishId")),
                                DishName = reader.GetString(reader.GetOrdinal("Name")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                OrderNote = reader.GetString(reader.GetOrdinal("OrderNote"))
                            };
                            listCurrrentOrder.Add(order);
                        }
                    }
                }
            }
            return listCurrrentOrder;
        }

        public async Task UpdateOrderStatus(string status, string purchaseNumber)
        {
            using(SqlConnection conn = await CreateConnection())
            {
                string query = $"UPDATE CUSTOMER_ORDERS SET Status = @status WHERE PurchaseNumber = @purchaseNumber";
                using(SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("status", status);
                    cmd.Parameters.AddWithValue("purchaseNumber", purchaseNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
                conn.Close();
            }
        }

    }
}
