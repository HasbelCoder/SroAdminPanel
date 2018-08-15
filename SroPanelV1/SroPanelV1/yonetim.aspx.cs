using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SroPanelV1
{
    public partial class yonetim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
                Response.Redirect("Default.aspx");
            else
            {
                Response.Write("Hoşgeldiniz " + Session["Kullanici"].ToString());
                //Label1.Text = Session["database"].ToString();
            }

            



        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog='" + Session["database"].ToString() + "';Integrated Security=True");
                SqlCommand komut = new SqlCommand(TextBox1.Text, baglan);
                baglan.Open();
                komut.ExecuteNonQuery();

                baglan.Close();
                Label1.Text = "Başarılı/ Successful";
            }
            catch
            {
                Label1.Text = "Bir Problem Var. Ekleme Yapılamadı. / There is a problem. it could not be added";
            }
        }
    }
}