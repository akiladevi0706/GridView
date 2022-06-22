using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Task22
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }

    public class ProductDataAccessLayer
    {
        public static List<Product> GetAllProducts()
        {
            List<Product> listProducts = new List<Product>();

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from Products", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Product product = new Product();
                    product.Id = Convert.ToInt32(rdr["Id"]);
                    product.Name = rdr["Name"].ToString();
                    product.Price = rdr["Price"].ToString();

                    listProducts.Add(product);
                }
            }

            return listProducts;
        }
    }
}