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
            DataTable dt = new DataTable();
            string [] d=dateRdv.Text.Split('/');
            string jour = d[0];
            string mois = d[1];
            string annee = d[2];
            string da11 = annee.Replace("00:00:00", "");
            string annee3 = da11.Trim();
            ///MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", dateRdv.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

            adapter.Fill(dt);

            //DateTime dt1 = Convert.ToDateTime(LongDateToDateTime(dateRdv.ToLong(), "MM/dd/yyyy"));

            foreach (DataRow row in dt.Rows)
            {
                string[] da = row["date"].ToString().Split('/');
                //MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", row["date"].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string jour1 = da[0];
                
                string mois1 = da[1];
                string annee1 = da[2];
                string da1 = annee1.Replace("00:00:00", "");
                string annee2 = da1.Trim();

                if (jour1 == jour & mois1 == mois && annee3 == annee2 && heureRdv.Text == row["heure"].ToString()) { return false; }

                   

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

                    connection.Open();
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandType = CommandType.Text;


                    //Time dt = heureRdv.Value.Time;
                    //cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dateRdv.ToShortDateString()));
                    //cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(da.ToString("HH:mm:ss")));
                    
                    cmd2.Parameters.AddWithValue("@val", heureRdv.Text);
                    cmd2.Parameters.AddWithValue("@val1", dateRdv.Text);

                    cmd2.CommandText = "INSERT INTO RDV VALUES (@val1 ,@val, "+ LoginInfo.medID + "," + LoginInfo.UserID + ")";

                    cmd2.ExecuteNonQuery();
                    connection.Close();

                    //Specialite.Text = "";
                    //male.Checked = false;
                    MessageBox.Show("Le rendez_vous a été bien crée", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else { 
                        MessageBox.Show("Le rendez_vous n\'a pas été crée / VEUILLEZ CHOISIR UNE AUTRE DATE POUR LE RENDEZ-VOUS!", "Insert failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
    
           
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sexeP_Click(object sender, EventArgs e)
        {

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
