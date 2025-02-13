using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hykonenclub\\source\\repos\\WinFormsApp1\\WinFormsApp1\\DB_contact.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Class1.Reload();

            DataGridViewButtonColumn btn_modif = new DataGridViewButtonColumn();
            btn_modif.HeaderText = "modifier";
            btn_modif.Text = "modifier";
            btn_modif.Name = "modifier";
            btn_modif.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_modif);
            
            DataGridViewButtonColumn btn_suppr = new DataGridViewButtonColumn();
            btn_suppr.HeaderText = "supprimer";
            btn_suppr.Text = "supprimer";
            btn_suppr.Name = "supprimer";
            btn_suppr.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn_suppr);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_add_contact_Click(object sender, EventArgs e)
        {
            string txtnom = txt_nom_prenom.Text.Trim();
            string txtemail = txt_email.Text.Trim();
           

            if (txtemail == string.Empty || txtnom == string.Empty)
            {
                MessageBox.Show("veuillez remplir tout les champs!!");
            }
            else if (!verifmail(txtemail))
            {

                MessageBox.Show("mail invalide!!!!");
            }

            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(stringconnection))
                    {
                        conn.Open();
                        string req = "INSERT INTO Contacts (Nom, Email) VALUES (@Nom, @Email)";
                        SqlCommand cmd = new SqlCommand(req, conn);
                        cmd.Parameters.AddWithValue("@Nom", txtnom);
                        cmd.Parameters.AddWithValue("@Email", txtemail);

                        cmd.ExecuteNonQuery();
                    }
                    ((TextBox)txt_nom_prenom).Clear();
                    ((TextBox)txt_email).Clear();
                    MessageBox.Show(" T'ES NOIR EZ EZ EZ EZ EZ EZ EZ EZ EZ EZ            "+ txtnom + txtemail);
                    dataGridView1.DataSource = Class1.Reload();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }






        





        private bool verifmail(string txtemail)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(txtemail, pattern);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["supprimer"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Voulez vous supprimer cette colonne ?",
                    "confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question


                    );
                if (result == DialogResult.Yes)
                {
                    try {

                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        string id = row.Cells["ID"].Value.ToString();
                        using (SqlConnection conn = new SqlConnection(stringconnection))
                        {
                            conn.Open();
                            string req = "DELETE FROM Contacts WHERE ID = @ID";
                            SqlCommand cmd = new SqlCommand(req, conn);
                            cmd.Parameters.AddWithValue("@ID", id);
                            


                            cmd.ExecuteNonQuery();
                        }
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("ligne supprimée !");

                        Class1.Reload();


                    } catch (Exception ex) 
                        {

                        MessageBox.Show(ex.Message);


                    }





                }

            }
            else if (e.ColumnIndex == dataGridView1.Columns["modifier"].Index && e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();
                Form2 newform = new Form2(id, dataGridView1); 
                newform.Show(); 
                

                           
            }


        }

        
        


        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            string txtemail = txt_email.Text;
            if (verifmail(txtemail))
            {
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "veuillez rentrez un mail valide!!";
                lbl_error.ForeColor = Color.Red;

            }
        }

        
    }

}
