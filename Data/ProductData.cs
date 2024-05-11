using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductData
    {
        public List<Product> Get()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(BaseDatos.connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_listarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.product_id = Convert.ToInt32(reader["product_id"]);
                            product.name = reader["name"].ToString();
                            product.price = Convert.ToDouble(reader["price"]);
                            product.stock = Convert.ToInt32(reader["stock"]);
                            product.active = Convert.ToInt32(reader["active"]);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }


        public List<Product> GetByName(string name)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(BaseDatos.connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_listarProductoNombre", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product();
                            product.product_id = Convert.ToInt32(reader["product_id"]);
                            product.name = reader["name"].ToString();
                            product.price = Convert.ToDouble(reader["price"]);
                            product.stock = Convert.ToInt32(reader["stock"]);
                            product.active = Convert.ToInt32(reader["active"]);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }
        public void InsertProduct(string name, double price, int stock)
        {
            using (SqlConnection connection = new SqlConnection(BaseDatos.connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_InsertarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@stock", stock);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduct(int productId)
        {
            using (SqlConnection connection = new SqlConnection(BaseDatos.connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_EliminarProducto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@product_id", productId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


    }

}
