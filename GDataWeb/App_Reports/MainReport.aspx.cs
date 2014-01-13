using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GDataWeb.App_Reports
{
    public partial class MainReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewer1.ReportSource = new Report();
            //this.ReportViewer1.ReportSource.
        }
    }
}