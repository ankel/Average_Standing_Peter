﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Average_Standing_Peter {
    public partial class HelloWorld : System.Web.UI.Page {
        protected void Page_Load ( object sender, EventArgs e ) {
            lblHello.Text = "Hello, World!";
        }
    }
}