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
    public partial class Form7 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
                checkBox1.Text = "afficher le mot de passe";
            }
            else
            {
                pass.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkBox1.Text = "Cacher le mot de passe";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || age.Text == "" || tel.Text == "" || mail.Text == "" || login.Text == "" || pass.Text == "")
            {
                MessageBox.Show("les champs sont vides", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Patient VALUES ('" + nom.Text + "','" + prenom.Text + "','" + age.Text + "','" + tel.Text + "','" + mail.Text + "','" + login.Text + "','" + pass.Text + "')";

                cmd.ExecuteNonQuery();
                connection.Close();

                nom.Text = "";
                prenom.Text = "";
                age.Text = "";
                tel.Text = "";
                mail.Text = "";
                login.Text = "";
                pass.Text = "";
                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connecter();
            }
        }
        private void connecter()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Au niveau de votre requete le "%" permet de lister toute les lignes commençant par la lettre que vous allez taper dans 
            // metroTextBoxSearch.Text
            cmd.CommandText = "SELECT * FROM Patient WHERE login= '" + login.Text + "' and mdp= '" + pass.Text + "'"; 
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
               
                Form2 f = new Form2();
                f.Show();

            }
            connection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text = "";
            age.Text = "";
            tel.Text = "";
            mail.Text = "";
            login.Text = "";
            pass.Text = "";
            nom.Focus();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
