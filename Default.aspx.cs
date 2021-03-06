﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BtnHistory.Visible = false;
        BtnEdit.Visible = false;


        if (Session["UserInfo"] != null)
        {
            DataSet ds = new DataSet();
            ds = Session["UserInfo"] as DataSet;
            if (ds.Tables[0].Rows.Count > 0)
            {
                Session["Userid"] = ds.Tables[0].Rows[0]["CustomerID"];
                Control c = this.Master.FindControl("login");// "masterDiv"= the Id of the div.
                c.Visible = false;
                c = this.Master.FindControl("Register");// "masterDiv"= the Id of the div.
                c.Visible = false;
                c = this.Master.FindControl("LogOut");// "masterDiv"= the Id of the div.
                c.Visible = true;
                Label mpLabel = (Label)Master.FindControl("welcome");
                mpLabel.Text = "Welcome " + ds.Tables[0].Rows[0]["firstname"];
                mpLabel.Visible = true;
                ViewState["Flags"] = 1;
                if (Convert.ToInt32(ds.Tables[0].Rows[0]["RollID"]) == 1)
                {
                    BtnHistory.Visible = true;
                    BtnEdit.Visible = true;
                }

            }

        }

    }

    protected void BtnTransfer_Click(object sender, EventArgs e)
    {
        if (ViewState["Flags"] != null)
            Response.Redirect("Transfer.aspx");
        else
            msg.Text = "Please login to use this feature";
    }

    protected void BtnDeposit_Click(object sender, EventArgs e)
    { /*
        if (ViewState["Flags"].ToString() == "1")
            Response.Redirect("DepositForm.aspx");
        else
            msg.Text = "Please login to use this feature";
            */


        if (ViewState["Flags"] != null)
            Response.Redirect("DepositForm.aspx");
        else
            msg.Text = "Please login to use this feature";
    }

    protected void BtnWithdraw_Click(object sender, EventArgs e)
    { /*
        if (ViewState["Flags"].ToString() == "1")
            Response.Redirect("BankDetails.aspx");
        else
            msg.Text = "Please login to use this feature";
            */


        if (ViewState["Flags"] != null)
            Response.Redirect("BankDetails.aspx");
        else
            msg.Text = "Please login to use this feature";
    }
    protected void BtnHistory_Click(object sender, EventArgs e)
    {
        /*
        if (ViewState["Flags"].ToString() == "1")
            Response.Redirect("TransactionHistory.aspx");
        else
            msg.Text = "Please login to use this feature";
            
    */

        if (ViewState["Flags"] != null)
            Response.Redirect("TransactionHistory.aspx");
        else
            msg.Text = "Please login to use this feature";
    }
    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        /*
        if (ViewState["Flags"].ToString() == "1")
            Response.Redirect("TransactionHistory.aspx");
        else
            msg.Text = "Please login to use this feature";
            BtnEdit_Click
    */

        if (ViewState["Flags"] != null)
            Response.Redirect("EditUser.aspx");
        else
            msg.Text = "Please login to use this feature";
    }
}