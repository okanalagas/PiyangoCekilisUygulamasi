using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Çekiliş
{
    internal static class Database
    {
        static SqlConnection conn = new SqlConnection("Server=103S-2\\MSSQLSERVER01;Database=Draw;Trusted_Connection=true");

        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;

        static DataTable dt;
        static Form1 form = (Form1)Application.OpenForms["Form1"];

        static string cmdText;

        public static void GridFill()
        {
            conn.Open();
            cmdText = "select * from Info";
            da = new SqlDataAdapter(cmdText,conn);
            dt = new DataTable();
            da.Fill(dt);
            form.dataGridView1.DataSource = dt;
            conn.Close();                   
        }
        public static void Add(string name,string surname,string ticketno)
        {
            conn.Open();
            cmdText = $"insert Info values('{name}','{surname}','{ticketno}')";
            cmd = new SqlCommand(cmdText,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            GridFill();
        }
        public static bool Check(string ticketno)
        {
            int count = 0;
            conn.Open();
            cmdText = $"select count(*) from Info where TicketNo = '{ticketno}'";
            cmd = new SqlCommand (cmdText,conn);    
            dr=cmd.ExecuteReader();  //cmd.ExecuteScalar() ile de yapılabilir.
            while(dr.Read())
            {
                count = dr.GetInt32(0);  // (int)dr[0].ToString()
            }
            conn.Close();
            if (count > 0)
            {
                return false;
            }
            else
                return true;
        }
        public static List<string> user;
        public static void Get(string ticketno)
        {
            user = new List<string>();
            conn.Open();
            cmdText = $"select Name,Surname from Info where TicketNo = '{ticketno}'";
            cmd = new SqlCommand(cmdText, conn);
            dr = cmd.ExecuteReader();  //cmd.ExecuteScalar() ile de yapılabilir.
            while (dr.Read())
            {
                user.Add(dr.GetString(0));
                user.Add(dr.GetString(1));
            }
            conn.Close();           
        }
    }
}
