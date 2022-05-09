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
    public partial class AddProduct : System.Web.UI.Page
    {
        List<Products> products;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                if (id > 0)
                {
                    LoadProducts(id);
                }
            }
        }

        private void LoadProducts(int id)
        {
            var cmd = new SqlCommand();
            cmd.Connection = ClsConnection.Conn();
            cmd.CommandText = "LOAD_PRODUCTS";
            cmd.Parameters.AddWithValue("@PRODUCT_ID", id.ToString());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var dt = new DataTable())
            {
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if(dt!=null && dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    hiddenPID.Value = id.ToString();
                    txtPN.Text = (string)row["product_name"];
                    txtModel.Text = Convert.ToString(row["model_year"]);
                    txtList.Text = Convert.ToString(row["list_price"]);
                    ddBrand.SelectedValue = Convert.ToString(row["brand_id"]);
                    ddCategory.SelectedValue = Convert.ToString(row["category_id"]);
                }

            }
        }

        //protected void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var cmd = new SqlCommand();
        //        cmd.CommandText = "INSERT INTO products(product_name, brand_id, category_id, model_year, list_price) VALUES(@p_name, @brand, @cate, @year, @price)";
        //        cmd.Parameters.AddWithValue("@p_name", txtPN.Text);
        //        cmd.Parameters.AddWithValue("@brand", ddBrand.SelectedIndex);
        //        cmd.Parameters.AddWithValue("@cate", ddCategory.SelectedIndex);
        //        cmd.Parameters.AddWithValue("@year", txtModel.Text);
        //        cmd.Parameters.AddWithValue("@price", txtList.Text);
        //        cmd.Connection = ClsConnection.Conn();
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //        Response.Redirect("/ProductMaster.aspx");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "PRODUCT_UPSERT";
                if (!string.IsNullOrEmpty(hiddenPID.Value))
                    cmd.Parameters.AddWithValue("@ID", hiddenPID.Value);
                cmd.Parameters.AddWithValue("@Name", txtPN.Text);
                cmd.Parameters.AddWithValue("@BRAND_ID", ddBrand.SelectedValue);
                cmd.Parameters.AddWithValue("@CATEGORY_ID", ddCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@MODEL_YEAR", txtModel.Text);
                cmd.Parameters.AddWithValue("@LIST_PRICE", txtList.Text);
                cmd.Connection = ClsConnection.Conn();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                Response.Redirect("/ProductMaster.aspx");
            }
            catch(Exception ex)
            {

            }
        }

        protected void UpdateData(int Id)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = "SELECT p.product_name, b.brand_name, c.category_name, p.model_year, p.list_price FROM products p INNER JOIN brands b ON b.brand_id=p.brand_id INNER JOIN categories c ON c.catagory_id=p.category_id WHERE p.product_id=@Id ";
            cmd.Parameters.AddWithValue("@Id", Id);
            
        }

        
    }
}