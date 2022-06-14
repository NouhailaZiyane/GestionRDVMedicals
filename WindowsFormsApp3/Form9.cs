using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form9 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void button_annuler_Click_1(object sender, EventArgs e)
        {
            msDaterdv.Text = ""; //la zone date RDV
            Liste.DataSource = null; // la liste d'affichage (DataGridView)
            adresse.Text = ""; // la zone nom patient
            specialite.Text = ""; // la zone nom patient
            prenom.Text = ""; // la zone spécialité médecin
            nom.Text = "";

        }

  

        private void button_ok_Click_1(object sender, EventArgs e)
        {
            cn.Open();

            // string date1 = msDaterdv.Text + " 00:00:00";
            string da = msDaterdv.Text;
           // string d = " nouha"+ da;
            // DateTime new1= msDaterdv.Value;
            //DateTime new1 = DateTime.ParseExact(msDaterdv.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            //string new2 = new1.ToString();
            
            SqlCommand cmd1 = cn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM RDV where CONVERT(VARCHAR,date)='" + da+"' and patient_id="+LoginInfo.UserID;
            //text.Text =da;
         
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd1.CommandText, cn);
            
            adapter.Fill(dt);
            Liste.DataSource = dt;
            //text.Text = msDaterdv.Text;
            //text.Text = msDaterdv.Text;
            /*string[] da;
            //DateTime dt1 = Convert.ToDateTime(LongDateToDateTime(dateRdv.ToLong(), "MM/dd/yyyy"));
            string date2, mois1, annee1, da1, annee2, jour1;
            foreach (DataRow row in dt.Rows)
            {
              
                da = row["date"].ToString().Split('/');
                //MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", row["date"].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                jour1 = da[0];

                 mois1 = da[1];
                 annee1 = da[2];
                 da1 = annee1.Replace("00:00:00", "");
                 annee2 = da1.Trim();
                date2 = jour1 + "/" + mois1 + "/" + annee2;
                text.Text = msDaterdv.Text;
                label5.Text = row["date"].ToString();
                if (date2==msDaterdv.Text) {
                    int i =(int) row["id"];
                    //cmd.Parameters.AddWithValue("@val", i);
                    LoginInfo.UserID = "1";
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from RDV where id="+i+" and patient_id=" + LoginInfo.UserID;

                    cmd.ExecuteNonQuery();

                    DataTable dta = new DataTable();
                   SqlDataAdapter c = new SqlDataAdapter(cmd.CommandText, cn); ;
                    c.Fill(dta);
                    Liste.DataSource = dta;

                    
                }
                else
                {
                    Liste.DataSource =null;
                }


                  
            }*/
            cn.Close();
   


        }




        private void Liste_SelectionChanged(object sender, EventArgs e)
        {
            
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form9_Load_1(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd1 = cn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM RDV where patient_id=" + LoginInfo.UserID;
            //text.Text =da;

            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd1.CommandText, cn);

            adapter.Fill(dt);
            Liste.DataSource = dt;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // mode de sélection qui permet de sélectionner toute la ligne de la liste 
            cn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void msDaterdv_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            if (cn.State != ConnectionState.Open) // pour ne pas interférer avec la procédure button_ok_Click
            {
                string codem, codep;
                DataGridViewRow r = Liste.Rows[a];
         
                codem = r.Cells[3].Value.ToString(); // récupérer le code médecin du RDV sélectionné
                //codep = r.Cells[4].Value.ToString(); // récupérer le code patient du RDV sélectionné
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = "select nom,prenom, specialite, adresse from Medecin where medecin_id='" + codem + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                nom.Text= dr[0].ToString();
                prenom.Text = dr[1].ToString();
                specialite.Text = dr[2].ToString();
                adresse.Text = dr[3].ToString();
                dr.Close();


                cn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search f = new search();
            this.Hide();
            f.Show();
        }
    }
}
