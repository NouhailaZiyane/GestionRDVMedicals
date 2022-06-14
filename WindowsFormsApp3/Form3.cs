using MetroFramework.Forms;
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
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (afficher.Checked)
                if (afficher.Checked)
                {
                    textBox2.UseSystemPasswordChar = false;
                    //textBox3.UseSystemPasswordChar = false;
                    afficher.Text = "Cacher le mot de passe";
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                    //textBox3.UseSystemPasswordChar = true;

                    var checkbox = (CheckBox)sender;
                    afficher.Text = "Afficher le mot de passe";
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Au niveau de votre requete le "%" permet de lister toute les lignes commençant par la lettre que vous allez taper dans 
            // metroTextBoxSearch.Text
            cmd.CommandText = "SELECT * FROM secretaire WHERE login= '" + textBox1.Text + "' and mdp= '" + textBox2.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)     
            {
                LoginInfo.secID = dr["id"].ToString();
                LoginInfo.nomSec = dr["login"].ToString();
                // LoginInfo.prenomSec = dr["prenom"].ToString();
                MetroFramework.MetroMessageBox.Show(this, "You have SUCCESSFULLY connected \n\n Welcome " + LoginInfo.nomSec, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form12 f = new Form12();
                f.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Authentification FAILED" , "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
             

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
