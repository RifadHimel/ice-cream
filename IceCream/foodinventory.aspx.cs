using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCream
{
    public partial class foodinventory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_filepath;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //blue
        protected void Button4_Click(object sender, EventArgs e)
        {
            getFoodByID();
        }
        //green
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkIffoodExists())
            {
                Response.Write("<script>alert('Food Already Exists, try some other Food ID');</script>");
            }
            else
            {
                addNewFood();
            }
        }
        //yellow
        protected void Button3_Click(object sender, EventArgs e)
        {
            updateFoodByID();
        }
        //red
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteFoodByID();
        }

        // user defined functions
        bool checkIffoodExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from food_master_tbl where food_id='" + TextBox1.Text.Trim() + "' OR food_name='" + TextBox2.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        bool checkIfFoodExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from food_master_tbl where food_id='" + TextBox1.Text.Trim() + "' OR food_name='" + TextBox2.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }

        void addNewFood()
        {
            try
            {
               

                string filepath = "~/foodinventory/mrbaker.png";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("foodinventory/" + filename));
                filepath = "~/foodinventory/" + filename;


                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO food_master_tbl(food_id,food_name,release_date,type,price,food_description,food_img_link) values(@food_id,@food_name,@release_date,@type,@price,@food_description,@food_img_link)", con);

                cmd.Parameters.AddWithValue("@food_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@release_date", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@type", DropDownList1.SelectedItem.Value);
              
                cmd.Parameters.AddWithValue("@price", TextBox8.Text.Trim());
             
                cmd.Parameters.AddWithValue("@food_description", TextBox6.Text.Trim());
               
                cmd.Parameters.AddWithValue("@food_img_link", filepath);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Food added successfully.');</script>");
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void getFoodByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from food_master_tbl WHERE food_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0]["food_name"].ToString();
                    TextBox4.Text = dt.Rows[0]["release_date"].ToString();
                   
                    TextBox8.Text = dt.Rows[0]["price"].ToString().Trim();
                
                    TextBox6.Text = dt.Rows[0]["food_description"].ToString();
                

                    DropDownList1.SelectedValue = dt.Rows[0]["type"].ToString().Trim();
                 
                    global_filepath = dt.Rows[0]["food_img_link"].ToString();

                }
                else
                {
                    Response.Write("<script>alert('Invalid Food ID');</script>");
                }

            }
            catch (Exception ex)
            {

            }
        }

        void updateFoodByID()
        {

            if (checkIfFoodExists())
            {
                try
                {

                    string filepath = "~/foodinventory/mrbaker.png";
                    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    if (filename == "" || filename == null)
                    {
                        filepath = global_filepath;

                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("foodinventory/" + filename));
                        filepath = "~/foodinventory/" + filename;
                    }

                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("UPDATE food_master_tbl set food_name=@food_name,  release_date=@release_date, type=@type,  price=@price, food_description=@food_description,   food_img_link=@food_img_link where food_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.Parameters.AddWithValue("@food_id", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@food_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@release_date", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", DropDownList1.SelectedItem.Value);

                    cmd.Parameters.AddWithValue("@price", TextBox8.Text.Trim());

                    cmd.Parameters.AddWithValue("@food_description", TextBox6.Text.Trim());

                    cmd.Parameters.AddWithValue("@food_img_link", filepath);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('Food Updated Successfully');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Book ID');</script>");
            }
        }
        void deleteFoodByID()
        {
            if (checkIfFoodExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from food_master_tbl WHERE food_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Food Deleted Successfully');</script>");

                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Food ID');</script>");
            }
        }

    }
}