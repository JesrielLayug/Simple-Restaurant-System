using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RestaurantSystem.Model.ClassProperties;
using System.Security.Cryptography;
using System.Windows.Forms;
using RestaurantSystem.Models;
using System.IO;
using System.Drawing;
using System.Runtime.Remoting.Contexts;

namespace RestaurantSystem.Model
{
    public class DishDbContext
    {
        private string connectionString;
        public DishDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<SqlConnection> CreateConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            await conn.OpenAsync();
            return conn;
        }

        public async Task InsertDishData(DishesModels dish)
        {
            SqlConnection conn = await CreateConnection();
            SqlCommand cmd;
            string query = $"INSERT INTO Dishes(Category,Name,Image,Price,Description) VALUES (@category,@name,@image,@price,@description)";

            using (cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@category", dish.DishCategory);
                cmd.Parameters.AddWithValue("@name", dish.DishName);
                cmd.Parameters.AddWithValue("@image", dish.DishImage);
                cmd.Parameters.AddWithValue("@price", dish.DishPrice);
                cmd.Parameters.AddWithValue("@description", dish.DishDescription);


                await cmd.ExecuteNonQueryAsync();
            }

            conn.Close();
        }

        public async Task UpdateDishDataAsync(DishesModels dish)
        {
            var conn = await CreateConnection();
            string query = $"UPDATE Dishes SET Category = @category, Name = @name, Image = @image, Price = @price, Description = @description WHERE DishId = @id";
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", dish.DishId);
                cmd.Parameters.AddWithValue("@category", dish.DishCategory);
                cmd.Parameters.AddWithValue("@name", dish.DishName);
                cmd.Parameters.AddWithValue("@image", dish.DishImage);
                cmd.Parameters.AddWithValue("@price", dish.DishPrice);
                cmd.Parameters.AddWithValue("@description", dish.DishDescription);
                await cmd.ExecuteNonQueryAsync();
            }
            conn.Close();
        }

        public async Task RemoveDishDataAsync(DishesModels dish)
        {
            var conn = await CreateConnection();
            string query = $"DELETE FROM Dishes WHERE DishId = @id";
            using(var cmd = new SqlCommand(query,conn))
            {
                cmd.Parameters.AddWithValue("@id", dish.DishId);
                await cmd.ExecuteNonQueryAsync();
            }
            conn.Close();
        }



        public async Task<List<DishesModels>> RetrieveListDataAsync(DishesModels dish)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (SqlConnection conn = await CreateConnection())
            {
                string query = "SELECT * FROM Dishes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            dish = new DishesModels(); // Create a new instance for each iteration

                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }

            return listDish;
        }




        public async Task<List<DishesModels>> RetrieveListDataAsync(int ID)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (SqlConnection conn = await CreateConnection())
            {
                string query = "SELECT * FROM Dishes WHERE DishId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            DishesModels dish = new DishesModels(); // Create a new instance for each iteration

                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }

            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListDishAsOrderAsync(int ID)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (SqlConnection conn = await CreateConnection())
            {
                string query = $"SELECT * FROM Dishes WHERE DishId = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", ID);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            DishesModels dish = new DishesModels(); // Create a new instance for each iteration

                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }

            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListSoupDish(DishesModels dish)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (var  conn = await CreateConnection())
            {
                string soupQuery = $"SELECT * FROM Dishes WHERE Category = 'Soups'";
                using (var cmd = new SqlCommand(soupQuery, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while(await reader.ReadAsync())
                        {
                            dish = new DishesModels();
                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }
            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListSaladDish(DishesModels dish)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (var conn = await CreateConnection())
            {
                string soupQuery = $"SELECT * FROM Dishes WHERE Category = 'Salads'";
                using (var cmd = new SqlCommand(soupQuery, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            dish = new DishesModels();
                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }
            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListPastaDish(DishesModels dish)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (var conn = await CreateConnection())
            {
                string soupQuery = $"SELECT * FROM Dishes WHERE Category = 'Pasta'";
                using (var cmd = new SqlCommand(soupQuery, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            dish = new DishesModels();
                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }
            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListBakeryDish(DishesModels dish)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (var conn = await CreateConnection())
            {
                string soupQuery = $"SELECT * FROM Dishes WHERE Category = 'BakeryProducts'";
                using (var cmd = new SqlCommand(soupQuery, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            dish = new DishesModels();
                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }
            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListDrinksDish(DishesModels dish)
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (var conn = await CreateConnection())
            {
                string soupQuery = $"SELECT * FROM Dishes WHERE Category = 'Drinks'";
                using (var cmd = new SqlCommand(soupQuery, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            dish = new DishesModels();
                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }
            return listDish;
        }

        public async Task<List<DishesModels>> RetrieveListDishByNameAsync(string name)
        {
            List<DishesModels> ListDish = new List<DishesModels>();
            using(var conn = await CreateConnection())
            {
                string query = $"SELECT * FROM Dishes WHERE Name = @name";
                using(var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    using(var reader = await cmd.ExecuteReaderAsync())
                    {
                        while(await reader.ReadAsync())
                        {
                            DishesModels dish = new DishesModels()
                            {
                                DishId = reader.GetInt32(0),
                                DishCategory = reader.GetString(1),
                                DishName = reader.GetString(2),
                                DishPrice = reader.GetDecimal(4),
                                DishDescription = reader.GetString(5),
                            };
                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            ListDish.Add(dish);
                        }
                    }
                }
            }
            return ListDish;
        }

        public async Task<List<DishesModels>> RetrieveAllDataAsync()
        {
            List<DishesModels> listDish = new List<DishesModels>();

            using (SqlConnection conn = await CreateConnection())
            {
                string query = "SELECT * FROM Dishes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            DishesModels dish = new DishesModels(); // Create a new instance for each iteration

                            dish.DishId = reader.GetInt32(0);
                            dish.DishCategory = reader.GetString(1);
                            dish.DishName = reader.GetString(2);

                            if (!reader.IsDBNull(3))
                            {
                                dish.DishImage = (byte[])reader["Image"];
                            }

                            dish.DishPrice = reader.GetDecimal(4);
                            dish.DishDescription = reader.GetString(5);

                            listDish.Add(dish);
                        }
                    }
                }
            }

            return listDish;
        }

    }
}
