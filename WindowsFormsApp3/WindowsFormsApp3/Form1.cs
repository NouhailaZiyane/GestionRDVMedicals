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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" && prenom.Text == "" && specialite.Text == "" && adresse.Text == "" && Ville.Text == "" && tel1.Text == "" && mdp.Text == "" && mdpc.Text == "")
            {
                MessageBox.Show("les champs sont vides", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (mdp.Text == mdpc.Text)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Medecin VALUES ('" + nom.Text + "','" + prenom.Text + "','" + specialite.Text + "','" + adresse.Text + "','" + Ville.Text + "','" + tel1.Text + "','" + nom.Text + " " + prenom.Text + "','" + mdp.Text + "')";

                cmd.ExecuteNonQuery();
                connection.Close();

                nom.Text = "";
                prenom.Text = "";
                specialite.Text = "";
                adresse.Text = "";
                Ville.Text = "";
                mdp.Text = "";
                mdpc.Text = "";


                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdp.Text = "";
                mdpc.Text = "";
                mdp.Focus();
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text = "";
            s.Text = "";
            adresse.Text = "";
            Ville.Text = "";
            tel1.Text = "";
            t.Text = "";

        }
        private void afficher_CheckedChanged(object sender, EventArgs e)
        {
            if (afficher.Checked)
            {
                mdp.UseSystemPasswordChar = false;
                mdpc.UseSystemPasswordChar = false;
                afficher.Text = "Cacher le mot de passe";
            }
            else
            {
                mdp.UseSystemPasswordChar = true;
                mdpc.UseSystemPasswordChar = true;

                var checkbox = (CheckBox)sender;
                afficher.Text = "Afficher le mot de passe";
            }
            /*    Ajouter un icone **/


        }

        private void Tel_Click(object sender, EventArgs e)
        {

        }

        private void t_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t.Text == "Algérie") { tel1.Text = "+213"; }
            if (t.Text == "Allemagne") { tel1.Text = "+49"; }
            if (t.Text == "Bahreïn") { tel1.Text = "+973"; }
            if (t.Text == "Belgique") { tel1.Text = "+32"; }
            if (t.Text == "Brésil") { tel1.Text = "+55"; }
            if (t.Text == "Corée du Sud") { tel1.Text = "+82"; }
            if (t.Text == "Danemark") { tel1.Text = "+45"; }
            if (t.Text == "Djibouti") { tel1.Text = "+253"; }
            if (t.Text == "Finlande") { tel1.Text = "+358"; }
            if (t.Text == "France") { tel1.Text = "+33"; }
            if (t.Text == "Hong Kong") { tel1.Text = "+852"; }
            if (t.Text == "Hongrie") { tel1.Text = "+36"; }
            if (t.Text == "Inde") { tel1.Text = "+91"; }
            if (t.Text == "Irland") { tel1.Text = "+353"; }
            if (t.Text == "Kenya") { tel1.Text = "+254"; }
            if (t.Text == "Koweit") { tel1.Text = "+965"; }
            if (t.Text == "Liban") { tel1.Text = "+961"; }
            if (t.Text == "Luxembourg") { tel1.Text = "+352"; }
            if (t.Text == "Maroc") { tel1.Text = "+212"; }
            if (t.Text == "Mexique") { tel1.Text = "+52"; }
            if (t.Text == "Oman") { tel1.Text = "+968"; };
        }
    }
}
