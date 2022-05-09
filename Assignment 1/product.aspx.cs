using Assignment_1.Database;
using Assignment_1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class product : System.Web.UI.Page
    {

        List<Products> products;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ClsConnection.Conn();

            if (!Page.IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT product_name, brand_id, category_id, model_year, list_price FROM products";
            cmd.Connection = ClsConnection.Conn();
            cmd.CommandType = System.Data.CommandType.Text;
            products = new List<Products>();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows == true)
                {
                    while (reader.Read() == true)
                    {
                        var product = new Products();
                        product.ProductsName = reader.GetString(reader.GetOrdinal("product_name"));
                        product.Brand = (int)reader["brand_id"];
                        product.Category = (int)reader["category_id"];
                        product.ModelYear = (short)reader["model_year"];
                        double price = Convert.ToDouble(reader["list_price"]);
                        product.Price = Math.Round(price, 2);
                        products.Add(product);
                    }
                }
                GridProduct.DataSource = products;
                GridProduct.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO products(product_name, brand_id, category_id, model_year, list_price) VALUES(@p_name, @brand, @cate, @year, @price)";
                cmd.Parameters.AddWithValue("@p_name", txtProduct.Text);
                cmd.Parameters.AddWithValue("@brand", ddBrand.SelectedIndex);
                cmd.Parameters.AddWithValue("@cate", ddCategory.SelectedIndex);
                cmd.Parameters.AddWithValue("@year", txtModel.Text);
                cmd.Parameters.AddWithValue("@price", txtList.Text);
                cmd.Connection = ClsConnection.Conn();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadProducts();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}