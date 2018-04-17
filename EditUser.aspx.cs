using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bobs_class
{
    public partial class EditUser : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ""C:\USERS\ROBERT\SOURCE\REPOS\BOBS CLASS\BOBS CLASS\APP_DATA\DATABASE\EWALLET.MDF""; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Idbtn_Click(object sender, EventArgs e)
        {
            string userid = Convert.ToString(UserID_bx.Text);
            string Thisuser;
            Session["user"] = "";
            SqlCommand getuser = new SqlCommand("SELECT CustomerID FROM CustomerInfo WHERE CustomerId = @cust", conn);
            if (userid == "")
            {
                srch_lbl.Text = "Please enter a ID";
            }
            else
            {
                try
                {
                    conn.Open();

                    getuser.Parameters.AddWithValue("@cust", userid);
                    Thisuser = Convert.ToString(getuser.ExecuteScalar());

                    if (Thisuser != "" && Thisuser != null)
                    {
                        mydiv.Visible = true;
                        srch_lbl.Text = "";
                        Session["user"] = Thisuser;
                    }
                    else
                    {
                        srch_lbl.Text = "User not found";
                    }
                }

                finally
                {
                    conn.Close();

                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlCommand updateuser = new SqlCommand("UPDATE CustomerInfo SET FirstName= @Fname, LastName = @Lname, Email = @Email, Phone = @Phone WHERE CustomerId = @cust", conn);
            string updFname = "";
            string updLname = "";
            string updEmail = "";
            string updPhone = "";
            string user = Session["user"].ToString();
            //First Name
            if (fnametxt != null)
            { updFname = fnametxt.Text; }
            else
            { fnamelbl.Text = "please enter a value"; }
            //Last Name
            if (lnametxt != null)
            { updLname = lnametxt.Text; }
            else
            { lnamelbl.Text = "please enter a value"; }
            //Email
            if (emailtxt != null)
            { updEmail = emailtxt.Text; }
            else
            { emaillbl.Text = "please enter a value"; }
            //Phone
            if (phonetxt != null)
            { updPhone = phonetxt.Text; }
            else
            { phonelbl.Text = "please enter a value"; }
            try
            {
                conn.Open();
                if (updEmail != "" && updFname != "" && updLname != "" && updPhone != "")
                {
                    updateuser.Parameters.AddWithValue("@cust", user);
                    updateuser.Parameters.AddWithValue("@Fname", updFname);
                    updateuser.Parameters.AddWithValue("@Lname", updLname);
                    updateuser.Parameters.AddWithValue("@Email", updEmail);
                    updateuser.Parameters.AddWithValue("@Phone", updPhone);
                    updateuser.ExecuteNonQuery();
                }
            }
            finally
            {
                conn.Close();
                Response.Redirect("EditUser.aspx");
            }

        }

        protected void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
