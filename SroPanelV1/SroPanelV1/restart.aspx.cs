using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace SroPanelV1
{
    public partial class restart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reset_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.WindowStyle = ProcessWindowStyle.Hidden;
                proc.FileName = "cmd";
                proc.Arguments = "/C shutdown -f -r";
                Process.Start(proc);
                Label1.Text = "Makinaya Birkaç Dakika İçerisinde RES Atılacaktır. // it will restart in a few minutes";
            }
            catch
            {
                Label1.Text = "Bir Problem Var // Threre is a problem!..";
            }
        }
    }
}