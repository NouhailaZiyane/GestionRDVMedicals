using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }

        private void combocodem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {

        }

        private void button_nouveau_Click(object sender, EventArgs e)
        {

        }

        private void combocodep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Test.Text = LoginInfo.medID+ " "+ LoginInfo.nomMed+ " "+ LoginInfo.prenomMed;
            codeM.Text = LoginInfo.medID;
            nomM.Text = LoginInfo.nomMed;
            prenom.Text = LoginInfo.prenomMed;
            codeP.Text = LoginInfo.UserID;
            nomP.Text = LoginInfo.nom;
            prenomP.Text = LoginInfo.prenom;


        }
        //codeP
        //nomP
        //male-female
        //dateRdv
        //heureRdv
        //codeM
        //nomM
        //Specialite
        private DateTime LongDateToDateTime(long longdate, string type)
        {
            DateTime date = DateTime.ParseExact(longdate.ToString(), type, System.Globalization.CultureInfo.InvariantCulture);
            return date;
        }

        private bool verifierRDV(string idM)
        {
            connection.Open();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT date, heure FROM RDV where medecin_id="+idM;

            cmd1.ExecuteNonQuery();
            SqlDataReader dr = cmd1.ExecuteReader();
            foreach (DataRow row in dr)
            {
                if (dateRdv.Text == dr["date"].ToString() && heureRdv.Text == dr["heure"].ToString())

                    return false;

                }
            connection.Close();
            return true;
        }
        private void ajouterRDV_Click(object sender, EventArgs e)
        {
           // LoginInfo.medID
            if (codeP.Text == "" && nomP.Text == "" && dateRdv.Text == "" && heureRdv.Text == "" && codeM.Text == "" && nomM.Text == "" )
            {
                MessageBox.Show("les champs sont vides", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                if (verifierRDV(LoginInfo.medID)) {
                    var formats = new[]
{
    "dd/MM/yyyy",
    "dd/MM/yyyy HH:mm",
    "dd/MM/yyyy HH:mm tt",
    "dd/MM/yyyy HH:mm:ss",
    "dd/MM/yyyy HH:mm:ss tt",
    "HH:mm:ss",
};
                    char s = ':';
                    var timeParts = heureRdv.Text.Split(s);
                    int hours = Convert.ToInt32(timeParts[0]);
                    int minutes = Convert.ToInt32(timeParts[1]);
                    int seconds = Convert.ToInt32(timeParts[2]);

                    var timeSpan = new TimeSpan(hours, minutes, seconds);
                    DateTime oDate = Convert.ToDateTime(heureRdv.Text);
                    connection.Open();
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    //Time dt = heureRdv.Value.Time;
                    //cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateRdv.ToShortDateString()));
                    //cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(da.ToString("HH:mm:ss")));
                    cmd2.CommandText = "INSERT INTO RDV VALUES ("+ LongDateToDateTime(long.Parse(dateRdv.Text), "dd/MM/yyyy")+" ,"+ oDate+", "+ LoginInfo.medID + "," + LoginInfo.UserID + ")";

                    cmd2.ExecuteNonQuery();
                    connection.Close();

                    codeP.Text = "";
                    nomP.Text = "";
                    dateRdv.Text = "";
                    heureRdv.Text = "";
                    codeM.Text = "";
                    nomM.Text = "";
                    //Specialite.Text = "";
                    //male.Checked = false;
                    MessageBox.Show("Le rendez_vous a été bien crée", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else { 
                        MessageBox.Show("Le rendez_vous n\'a pas été crée / VEUILLEZ CHOISIR UNE AUTRE DATE POUR LE RENDEZ-VOUS!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
    
           
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sexeP_Click(object sender, EventArgs e)
        {

        }
    }
}
