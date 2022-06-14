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
    
    public partial class Form4 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Au niveau de votre requete le "%" permet de lister toute les lignes commençant par la lettre que vous allez taper dans 
            // metroTextBoxSearch.Text
            cmd.CommandText = "SELECT * FROM Medecin WHERE login= '" + textBox1.Text + "' and mdp= '" + textBox2.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == false)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", "Something went wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            else
            {

                LoginInfo.medID = dr["medecin_id"].ToString();
                LoginInfo.nomMed = dr["nom"].ToString();
                LoginInfo.prenomMed = dr["prenom"].ToString();
                MetroFramework.MetroMessageBox.Show(this, "\n\n You have successfully connected ", "Hello"+ LoginInfo.prenom+ " "+ LoginInfo.nom, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Form2 f = new Form2();
                f.Show();
                
            }
            connection.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }
    }
}
