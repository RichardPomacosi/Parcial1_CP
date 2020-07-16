using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_ConsumidorPregunta1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            GridView1.DataSource = ws.Alumno();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();

            string ci;
            ci = TextBox1.Text;
            GridView1.DataSource = ws.AlumnoNombre(ci);
            GridView1.DataBind();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            TextBox2.Text = ws.nombreSinDB().ToString();

        }
    }
}