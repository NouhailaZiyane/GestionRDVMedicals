using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
            if (afficher.Checked)
            {
                pass.UseSystemPasswordChar = false;
                // mdpc.UseSystemPasswordChar = false;
                afficher.Text = "Cacher le mot de passe";
            }
            else
            {
                pass.UseSystemPasswordChar = true;
                //mdpc.UseSystemPasswordChar = true;

                var checkbox = (CheckBox)sender;
                afficher.Text = "Afficher le mot de passe";
            }
        }
        bool IsEmailValid()
        {
            try
            {
                MailAddress m = new MailAddress(mail.Text);


                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Format Email incorrect, vous devez respecter cette forme: abcde@gmail.com ", "Erreur", MessageBoxButtons.OK);
                mail.Clear();
                mail.Focus();
                return false;
            }
        }
        private bool verifierPass()
        {
            Regex pattern = new Regex("[0-9]{1,8}");

            if (!pattern.IsMatch(pass.Text))
            {
                MessageBox.Show(this, "Le password  doit etre composé au manimum de 8 chiffres");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
          if (nom.Text == "" || prenom.Text == "" || age.Text == "" || tel.Text == "" || mail.Text == "" || login.Text == "" || pass.Text == "" )
            {
               // MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", "Something went wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MetroFramework.MetroMessageBox.Show(this,"les champs sont vides", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (!IsEmailValid())
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
               // connecter();
                Form6 f = new Form6();
                this.Hide();
                f.Show();
                
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Hide();

            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t.Text == "Algérie") { tel.Text = "+213"; }
            if (t.Text == "Allemagne") { tel.Text = "+49"; }
            if (t.Text == "Bahreïn") { tel.Text = "+973"; }
            if (t.Text == "Belgique") { tel.Text = "+32"; }
            if (t.Text == "Brésil") { tel.Text = "+55"; }
            if (t.Text == "Corée du Sud") { tel.Text = "+82"; }
            if (t.Text == "Danemark") { tel.Text = "+45"; }
            if (t.Text == "Djibouti") { tel.Text = "+253"; }
            if (t.Text == "Finlande") { tel.Text = "+358"; }
            if (t.Text == "France") { tel.Text = "+33"; }
            if (t.Text == "Hong Kong") { tel.Text = "+852"; }
            if (t.Text == "Hongrie") { tel.Text = "+36"; }
            if (t.Text == "Inde") { tel.Text = "+91"; }
            if (t.Text == "Irland") { tel.Text = "+353"; }
            if (t.Text == "Kenya") { tel.Text = "+254"; }
            if (t.Text == "Koweit") { tel.Text = "+965"; }
            if (t.Text == "Liban") { tel.Text = "+961"; }
            if (t.Text == "Luxembourg") { tel.Text = "+352"; }
            if (t.Text == "Maroc") { tel.Text = "+212"; }
            if (t.Text == "Mexique") { tel.Text = "+52"; }
            if (t.Text == "Oman") { tel.Text = "+968"; };
        }
    }
}
