﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthenticationandAuthorization
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(User.Identity.Name + "<br>");
            Response.Write(User.Identity.AuthenticationType + "<br>");
            Response.Write(User.Identity.IsAuthenticated + "<br>");
            Response.Write(User.IsInRole("Administrators") + "<br>");
        }
    }
}