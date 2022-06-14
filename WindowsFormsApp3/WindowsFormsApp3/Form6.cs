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

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
        public Form6()
        {
        
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "afficher le mot de passe";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;


                var checkbox = (CheckBox)sender;
                checkBox1.Text = "Cacher le mot de passe";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Au niveau de votre requete le "%" permet de lister toute les lignes commençant par la lettre que vous allez taper dans 
            // metroTextBoxSearch.Text
            cmd.CommandText = "SELECT * FROM Patient WHERE login= '" + textBox1.Text + "' and mdp= '" + textBox2.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", "Something went wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            else
            {

                LoginInfo.UserID = dr["patient_id"].ToString();
                LoginInfo.nom = dr["nom"].ToString();
                LoginInfo.prenom = dr["prenom"].ToString();

                search f = new search();
                f.Show();

            }
            connection.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
