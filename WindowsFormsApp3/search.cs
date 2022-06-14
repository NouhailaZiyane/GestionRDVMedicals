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
    public partial class search : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Medecin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinTableAdapter.Fill(this.database1DataSet.Medecin);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void choix_Click(object sender, EventArgs e)
        {

        }

        private void choix_TextChanged(object sender, EventArgs e)
        {
            if (choix1.Text == "Ville")
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Medecin where ville like '%" + choix.Text + "%'";

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;


                connection.Close();

            }
            else if (choix1.Text == "Nom")
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Medecin where nom like '%" + choix.Text + "%'";

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;


                connection.Close();
            }
            else if (choix1.Text == "Specialite")
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Medecin where specialite like '%" + choix.Text + "%'";

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;


                connection.Close();
            }
            else if (choix1.Text == "Prénom")
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Medecin where prenom like '%" + choix.Text + "%'";

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;


                connection.Close();
            }


        }
        int a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[a];
            string nom = r.Cells[0].Value.ToString();
            string prenom = r.Cells[1].Value.ToString();
            string specialite = r.Cells[2].Value.ToString();
            string adresse = r.Cells[3].Value.ToString();
            string ville = r.Cells[4].Value.ToString();
            string tel = r.Cells[5].Value.ToString();

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            // Au niveau de votre requete le "%" permet de lister toute les lignes commençant par la lettre que vous allez taper dans 
            // metroTextBoxSearch.Text
            cmd.CommandText = "SELECT * FROM Medecin WHERE nom= '" + nom + "' and prenom= '" + prenom + "' and specialite= '"+specialite + "' and adresse= '" + adresse+ "' and ville= '" +ville+ "' and tel= '" +tel+ "'" ;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == false)
            {
               /// MetroFramework.MetroMessageBox.Show(this, "\n\n The username or password are wrong, Please check ", "Something went wrong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                LoginInfo.medID = dr["medecin_id"].ToString();
                LoginInfo.nomMed = dr["nom"].ToString();
                LoginInfo.prenomMed = dr["prenom"].ToString();
                //MetroFramework.MetroMessageBox.Show(this, "\n\n You have successfully connected ", "Hello" + LoginInfo.prenom + " " + LoginInfo.nom, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                


            }
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            this.Hide();
            f.Show();
        }
    }
    }

