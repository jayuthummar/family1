﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class family_expence_main_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"]!=string.Empty)
        {
            if (!Page.IsPostBack)
            {
                lbluser.Text = Session["UserName"].ToString();
            }
        }
    }
}
