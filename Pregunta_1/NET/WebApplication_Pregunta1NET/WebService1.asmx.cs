using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication_Pregunta1NET
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string nombreSinDB()
        {
            return "Richard Pomacosi Quispe";
        }
        [WebMethod]
        public DataSet Alumno()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=(local);user=richard;pwd=123456;database=academico";
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand= new SqlCommand();
            ada.SelectCommand.Connection = conn;
            ada.SelectCommand.CommandText = "select * from alumno";
            ada.SelectCommand.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            ada.Fill(ds);

            return ds;
        }

        [WebMethod]
        public DataSet AlumnoNombre(string ci)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=(local);user=richard;pwd=123456;database=academico";
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand = new SqlCommand();
            ada.SelectCommand.Connection = conn;
            ada.SelectCommand.CommandText = "select * from alumno where ci=@ci";
            ada.SelectCommand.CommandType = CommandType.Text;
            ada.SelectCommand.Parameters.Add("@ci", SqlDbType.VarChar, 20).Value = ci;
            DataSet ds = new DataSet();
            ada.Fill(ds);

            return ds;
        }

    }
}
