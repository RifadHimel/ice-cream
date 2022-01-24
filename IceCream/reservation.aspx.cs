using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IceCream
{
    public partial class reservation : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static Int32 bookingid;
        static String startdate;
        static String enddate;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            startdate = Calendar1.SelectedDate.Year + "-" + Calendar1.SelectedDate.Month + "-" + Calendar1.SelectedDate.Day + " " + DropDownList2.SelectedItem.Value;
            enddate = Calendar1.SelectedDate.Year + "-" + Calendar1.SelectedDate.Month + "-" + Calendar1.SelectedDate.Day + " " + DropDownList3.SelectedItem.Value;
            // Response.Write(startdate);
            findAvailableTable();
            RadioButtonList1.Visible = true;
        }
        private void findAvailableTable()
        {

            //String mycon = "Data Source=DESKTOP-TK4TKON\SQLEXPRESS; Initial Catalog=pastryshopDB; Integrated Security=True";
            String myquery = "select DISTINCT table_no from table_master_tbl where ((dtstart between '" + startdate + "' and '" + enddate + "' ) or (dtend between '" + startdate + "' and '" + enddate + "' ))";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //RadioButtonList1.Items.Clear();
                Label1.Text = "Available Tables are Given Below";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {


                    RadioButtonList1.Items.Remove(RadioButtonList1.Items.FindByValue(dr["table_no"].ToString()));

                }
                if (RadioButtonList1.Items.Count == 0)
                {
                    Label1.Text = "No Table Available to Book";
                }

            }
            else
            {
                Label1.Text = "Available Tables are Given Below";

            }
            con.Close();
        }
        public void GenerateBookingID()
        {
            // String mycon = "Data Source=DESKTOP-TK4TKON\SQLEXPRESS;Initial Catalog=OnlineRestaurant;Integrated Security=True";
            SqlConnection scon = new SqlConnection(strcon);
            String myquery = "select bookingid from table_master_tbl";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            scon.Close();
            if (ds.Tables[0].Rows.Count < 1)
            {
                bookingid = 50001;

            }
            else
            {



                //  String mycon1 = "Data Source=DESKTOP-TK4TKON\SQLEXPRESS;Initial Catalog=OnlineRestaurant;Integrated Security=True";
                SqlConnection scon1 = new SqlConnection(strcon);
                String myquery1 = "select max(bookingid) from table_master_tbl";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = myquery1;
                cmd1.Connection = scon1;
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);


                bookingid = Convert.ToInt32(ds1.Tables[0].Rows[0][0].ToString());

                bookingid = bookingid + 1;
                scon1.Close();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GenerateBookingID();
            String updatepass = "insert into table_master_tbl(bookingid,table_no,member_name,noc,dtstart,dtend) values(" + bookingid + ",'" + RadioButtonList1.SelectedItem.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ",'" + startdate + "','" + enddate + "')";
            // String mycon1 = "Data Source=DESKTOP-TK4TKON\SQLEXPRESS;Initial Catalog=OnlineRestaurant;Integrated Security=True";
            SqlConnection s = new SqlConnection(strcon);
            s.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = updatepass;
            cmd1.Connection = s;
            cmd1.ExecuteNonQuery();
            s.Close();
            Label2.Text = "Booking ID " + bookingid + RadioButtonList1.SelectedItem.Text + " Has Been Booked From " + startdate + " to " + enddate;
        }
    }
}