using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transfer : System.Web.UI.Page
{
    DataBaseHandler cls = new DataBaseHandler();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet UserData = new DataSet();
    SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ""C:\USERS\ROBERT\SOURCE\REPOS\BOBS CLASS\BOBS CLASS\APP_DATA\DATABASE\EWALLET.MDF""; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");






    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand getbalance = new SqlCommand("SELECT Balance FROM AccountInfo WHERE customerid= @Userid", conn);
        SqlCommand getcustomerid = new SqlCommand("SELECT customerid FROM AccountInfo WHERE customerid= @Userid", conn);
        SqlCommand getidfromemail = new SqlCommand("SELECT CustomerID FROM CustomerInfo WHERE Email= @email", conn);
        SqlCommand getidfromphone = new SqlCommand("SELECT CustomerID FROM CustomerInfo WHERE Phone= @Phone", conn);
        SqlCommand updatebalance = new SqlCommand("UPDATE AccountInfo SET Balance= @new WHERE customerid = @id", conn);


        // if (!IsPostBack)
        if (Session["UserInfo"] != null)
        {

            UserData = Session["UserInfo"] as DataSet;
            if (UserData.Tables[0].Rows.Count > 0)
            {
                Session["Userid"] = UserData.Tables[0].Rows[0]["CustomerID"];
                Control c = this.Master.FindControl("login");// "masterDiv"= the Id of the div.
                c.Visible = false;
                c = this.Master.FindControl("Register");// "masterDiv"= the Id of the div.
                c.Visible = false;
                c = this.Master.FindControl("LogOut");// "masterDiv"= the Id of the div.
                c.Visible = true;
                Label mpLabel = (Label)Master.FindControl("welcome");
                mpLabel.Text = "Welcome " + UserData.Tables[0].Rows[0]["firstname"];
                mpLabel.Visible = true;
                //Flag = 1;




                try
                {


                    conn.Open();
                    getbalance.Parameters.AddWithValue("@Userid", Session["Userid"]);
                    getcustomerid.Parameters.AddWithValue("@Userid", Session["Userid"]);

                    fnamelbl.Text = "";


                }

                finally
                {

                    conn.Close();
                }
            }
            else
                Response.Redirect("login.aspx");

        }
        else
            Response.Redirect("login.aspx");
    }
    Regex reg;// = new Regex (@"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\D*");
    protected void BtbSend_Click(object sender, EventArgs e)
    {
        SqlCommand getbalance = new SqlCommand("SELECT Balance FROM AccountInfo WHERE customerid= @Userid3", conn);
        SqlCommand getpayeebalance = new SqlCommand("SELECT Balance FROM AccountInfo WHERE customerid= @payee", conn);
        SqlCommand getpayerbalance = new SqlCommand("SELECT Balance FROM AccountInfo WHERE customerid= @Userid3", conn);
        SqlCommand getcustomerid = new SqlCommand("SELECT customerid FROM AccountInfo WHERE customerid= @Userid2", conn);
        SqlCommand getemailcustomerid = new SqlCommand("SELECT customerid FROM AccountInfo WHERE customerid= @cusid", conn);
        SqlCommand getidfromemail = new SqlCommand("SELECT CustomerID FROM CustomerInfo WHERE Email= @email", conn);
        SqlCommand getidfromphone = new SqlCommand("SELECT CustomerID FROM CustomerInfo WHERE Phone= @Phone", conn);
        SqlCommand getphonecustomerid = new SqlCommand("SELECT customerid FROM AccountInfo WHERE customerid= @cusid", conn);
        SqlCommand inserttransaction = new SqlCommand("INSERT INTO transactions ( CustomerId, Amount,BeneficiaryID) Values (@cust,@amt,@Pay)", conn);
        SqlCommand inserttransaction2 = new SqlCommand("INSERT INTO transactions ( CustomerId, Amount,BeneficiaryID) Values (@cust2,@amt2,@Pay2)", conn);


        SqlCommand updatebalance = new SqlCommand("UPDATE AccountInfo SET Balance= @new WHERE customerid = @id", conn);
        SqlCommand updatebalance2 = new SqlCommand("UPDATE AccountInfo SET Balance= @new2 WHERE customerid = @id2", conn);

        bool send = false;

        if (RbtnType1.SelectedValue == "2")
        {
            try
            {


                conn.Open();
                string payer;
                int bal;
                int sending;
                int username = Convert.ToInt32(Session["Userid"]);
                string id;
                string email = txtphonemail.Text;
                int newpayee;
                int newpayer;


                //get payer balance
                getbalance.Parameters.AddWithValue("@Userid3", username);
                bal = Convert.ToInt32(getbalance.ExecuteScalar());
                fnamelbl.Text = Convert.ToString(bal);
                getcustomerid.Parameters.AddWithValue("@Userid2", username);
                payer = Convert.ToString(getcustomerid.ExecuteScalar());
                sending = Convert.ToInt32(txtbal.Text);




                if (bal < sending)
                {
                    fnamelbl.Text = "Error, Insufficient funds";
                }
                else
                {

                    send = true;
                    //get payee email

                    getidfromemail.Parameters.AddWithValue("@Email", email);
                    //get payee id from email


                    id = Convert.ToString(getidfromemail.ExecuteScalar());

                    getemailcustomerid.Parameters.AddWithValue("@cusid", id);
                    getpayeebalance.Parameters.AddWithValue("@payee", value: id);

                    int payeebal = Convert.ToInt32(getpayeebalance.ExecuteScalar());
                    string payee = Convert.ToString(getemailcustomerid.ExecuteScalar());



                    newpayee = payeebal + sending;
                    newpayer = bal - sending;



                    updatebalance.Parameters.AddWithValue("@new", newpayee);
                    updatebalance.Parameters.AddWithValue("@id", id);

                    updatebalance.ExecuteScalar();


                    updatebalance2.Parameters.AddWithValue("@new2", newpayer);
                    updatebalance2.Parameters.AddWithValue("@id2", username);
                    updatebalance2.ExecuteScalar();

                    inserttransaction.Parameters.AddWithValue("@cust", id);
                    inserttransaction.Parameters.AddWithValue("@amt", sending);
                    inserttransaction.Parameters.AddWithValue("@Pay", payee);
                    inserttransaction.ExecuteScalar();


                }



            }

            finally
            {

                conn.Close();

            }
            if (send == true)
            {
                Response.Redirect("Default.ASPX");
            }
        }


        else if (RbtnType1.SelectedValue == "1")
        {
            try
            {


                conn.Open();
                string payer;
                int bal;
                int sending;
                int username = Convert.ToInt32(Session["Userid"]);
                string id;
                int phone = Convert.ToInt32(txtphonemail.Text);
                int newpayee;
                int newpayer;

                //get payer balance
                getbalance.Parameters.AddWithValue("@Userid3", username);
                bal = Convert.ToInt32(getbalance.ExecuteScalar());

                getcustomerid.Parameters.AddWithValue("@Userid2", username);
                payer = Convert.ToString(getcustomerid.ExecuteScalar());
                sending = Convert.ToInt32(txtbal.Text);
                if (bal < sending)
                {
                    fnamelbl.Text = "Error, Insufficient funds";
                }
                else
                {
                    //get payee email

                    send = true;


                    getidfromphone.Parameters.AddWithValue("@Phone", phone);
                    //get payee id from email


                    id = Convert.ToString(getidfromphone.ExecuteScalar());

                    getphonecustomerid.Parameters.AddWithValue("@cusid", id);
                    getpayeebalance.Parameters.AddWithValue("@payee", value: id);

                    int payeebal = Convert.ToInt32(getpayeebalance.ExecuteScalar());
                    string payee = Convert.ToString(getphonecustomerid.ExecuteScalar());



                    newpayee = payeebal + sending;
                    newpayer = bal - sending;
                    //int test = 6 + sending;


                    updatebalance.Parameters.AddWithValue("@new", newpayee);
                    updatebalance.Parameters.AddWithValue("@id", id);

                    updatebalance.ExecuteScalar();


                    updatebalance2.Parameters.AddWithValue("@new2", newpayer);
                    updatebalance2.Parameters.AddWithValue("@id2", username);
                    updatebalance2.ExecuteScalar();

                    inserttransaction2.Parameters.AddWithValue("@cust2", id);
                    inserttransaction2.Parameters.AddWithValue("@amt2", sending);
                    inserttransaction2.Parameters.AddWithValue("@Pay2", payee);
                    inserttransaction2.ExecuteScalar();


                }



            }

            finally
            {

                conn.Close();

            }
            if (send == true)
            {
                Response.Redirect("Default.ASPX");
            }
        }


    }

    protected void RBtnChange1(object sender, EventArgs e)
    {
        if (RbtnType1.SelectedValue == "2")
        {
            reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            lbltype.Text = "Email ID";
        }
        else if (RbtnType1.SelectedValue == "1")
        {
            reg = new Regex(@"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\D*");
            lbltype.Text = "Phone Number";
        }
    }

}


