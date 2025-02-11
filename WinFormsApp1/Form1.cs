using System.Data;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


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
                dataGridView1.Rows.Add(txtnom, txtemail);
                MessageBox.Show(txtnom + txtemail);

            }


        }



        private bool verifmail(string txtemail)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(txtemail, pattern);
        }

        private void txt_email_TextChanged_1(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["supprimer"].Index && e.RowIndex >= 0) {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("ligne supprimée !");
            }
        }
    }

}
