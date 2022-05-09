using Assignment_1.Database;
using Assignment_1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class ProductMaster : System.Web.UI.Page
    { 
        List<MasterProduct> masterP;
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
            cmd.CommandText = "SELECT p.product_id, p.product_name,c.category_name, b.brand_name, p.list_price, p.model_year FROM products p INNER JOIN brands b ON b.brand_id = p.brand_id INNER JOIN categories c ON c.category_id = p.category_id";
            cmd.Connection = ClsConnection.Conn();
            cmd.CommandType = System.Data.CommandType.Text;
            masterP = new List<MasterProduct>();
            using (var dt = new DataTable())
            {
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                GridProducts.DataSource = dt;
                GridProducts.DataBind();
            }
        }

        protected void GridProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Update")
            {
                Response.Redirect($"/AddProduct.aspx?id={e.CommandArgument}");
            }

            else if(e.CommandName == "Delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                DeleteBrand(id);
            }
            e.Handled = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBrand(int id)
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM products WHERE product_id=@p_id";
                cmd.Parameters.AddWithValue("@p_id", id.ToString());
                cmd.Connection = ClsConnection.Conn();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
                LoadProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("/AddProduct.aspx");
        }

        //protected void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var cmd = new SqlCommand();
        //        cmd.CommandText = "INSERT INTO products(product_name, brand_id, category_id, model_year, list_price) VALUES(@p_name, @brand, @cate, @year, @price)";
        //        cmd.Parameters.AddWithValue("@p_name", txtProduct.Text);
        //        cmd.Parameters.AddWithValue("@brand", ddBrand.SelectedIndex);
        //        cmd.Parameters.AddWithValue("@cate", ddCategory.SelectedIndex);
        //        cmd.Parameters.AddWithValue("@year", txtModel.Text);
        //        cmd.Parameters.AddWithValue("@price", txtList.Text);
        //        cmd.Connection = ClsConnection.Conn();
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //        LoadProducts();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}