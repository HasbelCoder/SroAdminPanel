using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SroPanelV1
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try { 
           
                SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog='" + Session["database"].ToString() + "';Integrated Security=True");
                baglan.Open();
                SqlCommand user = new SqlCommand("Update sromon Set ad ='" + username.Text + "'", baglan);
                SqlCommand pass = new SqlCommand("Update sromon Set sifre ='" + password.Text + "'", baglan);

                user.ExecuteNonQuery();
                pass.ExecuteNonQuery();
                baglan.Close();
                Label3.Text = "Başarılı / Successful";
            }
            catch
            {
                Label3.Text = "Problem!..";
            }
            
        }
    }
}