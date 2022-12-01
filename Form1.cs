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

        SqlConnection chaine =new SqlConnection (@"Data Source=DESKTOP-7MJDDPC\MSSQLSERVER03;Initial Catalog=Etudiant;Integrated Security=True");
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
       
        
        public Nom()
        {
            InitializeComponent();
        }
        int value;
        

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
            value = 1;
            identifiant.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Enregister.Enabled = true;
            Modifer.Enabled = false;
            Supprimer.Enabled = false;
            Anuller.Enabled = true;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(value == 1)
            {
                
            
                try
                {
                    if (identifiant.Text != "" || textBox2.Text != "" || textBox3.Text != "")
                    {
                        
                        chaine.Open();
                        SqlCommand cmd = new SqlCommand("insert into Personne(id,Nom,Prenom) values" +"('"+identifiant.Text+"','"+textBox3.Text+ "','"+textBox2.Text+"')",chaine) ;
                         
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("bien Ajouter ");
                        chaine.Close();
                        identifiant.Clear();
                        textBox2.Clear();
                        textBox3.Clear();

                    }
                    else
                    {
                        MessageBox.Show("remplire tout les champs");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            try
            {
                
                    chaine.Open();
                    SqlCommand cmd = new SqlCommand;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("bien Ajouter ");
                    chaine.Close();
                    identifiant.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                
                else
                {
                    MessageBox.Show("remplire tout les champs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}

private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
