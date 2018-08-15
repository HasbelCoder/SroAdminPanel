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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void button_Click(object sender, EventArgs e)
        {
            try {
                try
                {
                    string kullanici = kad.Text;
                    string sifre = password.Text;
                    SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog='" + dbad.Text + "';Integrated Security=True");
                    SqlCommand sorgula = new SqlCommand("SELECT * FROM sromon WHERE ad=@ad AND sifre=@sifre", baglan);
                    sorgula.Parameters.AddWithValue("@ad", kullanici);
                    sorgula.Parameters.AddWithValue("@sifre", sifre);
                    baglan.Open();
                    SqlDataReader oku = sorgula.ExecuteReader();
                    if (oku.Read())
                    {
                        Session["Kullanici"] = oku["ad"].ToString();
                        Session["database"] = dbad.Text.ToString();
                        Response.Redirect("yonetim.aspx");
                    }
                    else
                        Label1.Text = "Kullanıcı adı yada şifre hatalı!";
                    oku.Close();
                    baglan.Close();
                    baglan.Dispose();
                }
                catch
                {
                    string kullanici = kad.Text;
                    string sifre = password.Text;
                    SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog='" + dbad.Text + "';Integrated Security=True");
                    baglan.Open();
                    SqlCommand tabloyap = new SqlCommand("CREATE TABLE sromon(ad char(50),sifre char(50),globalmng char(50),machine char(50),download char(50),gateway char(50),farm char(50),agent char(50),shard char(50),gamesw char(50));", baglan);
                    tabloyap.ExecuteNonQuery();
                    SqlCommand kayitekle = new SqlCommand("INSERT INTO sromon(ad,sifre) values ('" + kullanici + "','" + sifre + "')", baglan);
                    kayitekle.ExecuteNonQuery();
                    baglan.Close();
                    Label1.Text = "İlk Kayıt Yapıldı Tekrardan Giriş Yapınız! // First registration completed. Please sign in.!";
                }
               
            }
            catch
            {
                Label1.Text = "Genel Bir Sorun Oluştu!!!..";
            }

        }
    }
}