using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TransactionHistory : System.Web.UI.Page
{




    protected void Page_Load(object sender, EventArgs e)
    {
        Console.WriteLine(Session["payee"]);
        Console.WriteLine(Session["payer"]);
        Console.WriteLine(Session["amount"]);

    }

    protected void BtnHistoryBack_Click(object sender, EventArgs e)
    {

        Response.Redirect("Default.aspx");
    }

    protected void BtnHistoryNext_Click(object sender, EventArgs e)
    {

    }


    protected void GridView1_RowCommand(object sender,
   GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Undo")
        {
            // Retrieve the row index stored in the 
            // CommandArgument property.
            int index = Convert.ToInt32(e.CommandArgument);

            // Retrieve the row that contains the button 
            // from the Rows collection.
            GridViewRow row = GridView1.Rows[index];

            // Add code here to add the item to the shopping cart.

            string payer = "1018";
            string payee = "1019";
            string amount = "20";

            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ""C:\USERS\ROBERT\SOURCE\REPOS\BOBS CLASS\BOBS CLASS\APP_DATA\DATABASE\EWALLET.MDF""; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                conn.Open();
                SqlCommand inserttransaction = new SqlCommand("INSERT INTO transactions ( payer, amount, payee) Values (@cust,@amt,@Pay)", conn);
                SqlCommand update1 = new SqlCommand("UPDATE AccountInfo SET Balance= Balance + @amt  WHERE customerid = @id", conn);
                SqlCommand update2 = new SqlCommand("UPDATE AccountInfo SET Balance= Balance - @amt  WHERE customerid = @id", conn);

                inserttransaction.Parameters.AddWithValue("@cust", payer);
                inserttransaction.Parameters.AddWithValue("@amt", amount);
                inserttransaction.Parameters.AddWithValue("@pay", payee);
                inserttransaction.ExecuteNonQuery();
                update1.Parameters.AddWithValue("@cust", payer);
                update1.Parameters.AddWithValue("@amt", amount);
                update1.ExecuteNonQuery();
                update2.Parameters.AddWithValue("@cust", payee);
                update2.Parameters.AddWithValue("@amt", amount);
                update2.ExecuteNonQuery();

            }
            finally
            {
                conn.Close();
            }
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string info;
        if (DropDownList1.SelectedIndex == 0)
        {
            info = searchtxt.Text;
            SqlDataSource1.SelectCommand = ("SELECT * FROM Transactions");
            SqlDataSource1.SelectParameters.Clear();
            SqlDataSource1.DataBind();
        }
        else if (DropDownList1.SelectedIndex == 1)
        {
            info = searchtxt.Text;
            SqlDataSource1.SelectCommand = ("SELECT * FROM Transactions WHERE CustomerID = @cust ");
            SqlDataSource1.SelectParameters.Clear();
            SqlDataSource1.SelectParameters.Add("cust", info);
            SqlDataSource1.DataBind();
        }
        else if (DropDownList1.SelectedIndex == 2)
        {
            info = searchtxt.Text;
            SqlDataSource1.SelectCommand = ("SELECT * FROM Transactions WHERE TransactionID = @cust");
            SqlDataSource1.SelectParameters.Clear();
            SqlDataSource1.SelectParameters.Add("cust", info);
            SqlDataSource1.DataBind();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}





