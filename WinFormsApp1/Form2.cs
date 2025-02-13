using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string ID;
        DataGridView dg;
        public Form2(string id, DataGridView dg)
        {
            InitializeComponent();
                
                this.ID = id;   
            this.dg = dg;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            
            string txtnom = txt_modifnom.Text.Trim();
            string txtemail = txt_modifmail.Text.Trim();
            
            
            if(txtnom != string.Empty || txtemail != string.Empty || verifmail(txtemail)) {
            
            try
            {
                    string connectionbdd = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hykonenclub\\source\\repos\\WinFormsApp1\\WinFormsApp1\\DB_contact.mdf;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(connectionbdd))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Contacts SET Nom = @Nom, Email = @Email WHERE ID= @ID", conn);
                        cmd.Parameters.AddWithValue("@Nom", txtnom);
                        cmd.Parameters.AddWithValue("@Email", txtemail);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.ExecuteNonQuery();
                        
                    }
                    dg.DataSource = Class1.Reload();
                    MessageBox.Show("modification éffectué");
                    
                    this.Close();                
                }
                catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
            
            
            
            } 
        }


        private bool verifmail(string txtemail)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(txtemail, pattern);
        }
    }
}
