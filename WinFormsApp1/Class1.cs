using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Class1
    {
        public static DataTable Reload()
        {
            string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hykonenclub\\source\\repos\\WinFormsApp1\\WinFormsApp1\\DB_contact.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(stringconnection))
            {
                // ouverture de la connexion
                conn.Open();
                // requet sql
                string dmd = "SELECT * FROM Contacts";
                //package nuget qui permet d'intéragire avc la bdd
                SqlDataAdapter da = new SqlDataAdapter(dmd, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
