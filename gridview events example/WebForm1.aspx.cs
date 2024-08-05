using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace gridview_events_example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string dant = ConfigurationManager.ConnectionStrings["dan"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void DataBind()
        {
            SqlConnection con = new SqlConnection(dant);
            SqlDataAdapter da = new SqlDataAdapter("select * from vishnu2", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}