using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace formulaire
{
    public partial class Nom : Form

    {

        static string chaine = @"Data Source=DESKTOP-7MJDDPC\MSSQLSERVER03;Initial Catalog=Etudiant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public Nom()
        {
            InitializeComponent();
        }
        public int idvalide()
        {
            int cpt;
            cmd.CommandText = "select id from Personne where ='" + identifiant.Text + "'";
            cpt=(int)cmd.ExecuteScalar();
            return cpt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enregister.Enabled = true;
            Modifer.Enabled = false;
            Supprimer.Enabled = false;
            Anuller.Enabled = true;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(chaine);
            cnx.Open();
            if (idvalide() == 0 && (identifiant.Text == "" || textBox2.Text == "" || textBox3.Text == ""))
            {


                cmd.CommandText = "insert into  values('" + identifiant.Text + "','" + textBox3.Text + "','" + textBox2.Text + "') ";
                cmd.ExecuteNonQuery();
                identifiant.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            else 
            {
                MessageBox.Show("cette personne existe deja");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void Anuller_Click(object sender, EventArgs e)
        {
            Anuller.Enabled = true;
        }

        private void Modifer_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
