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
    public partial class Form10 : Form
    {
        SqlConnection cn= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

        public Form10()
        {
            InitializeComponent();
        }

        private bool rechercher_patient() //fonction qui permet de vérifier l'existence d'un patient dont le code est saisi dans la zone textcode
        {
            bool p = false;
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Patient where patient_id ='" + textcode.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                p = true;

            dr.Close();
            cn.Close();
            return p;
        }



        private void button_ok_Click_1(object sender, EventArgs e)
        {
            if (textcode.Text == "") //controle de saisie sur le champ code
                MessageBox.Show("Champ Code vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (rechercher_patient() == false)
            {

                textnom.Text = ""; // vider les champs

                MessageBox.Show("Patient introuvable", "introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textcode.Focus();
                textcode.SelectAll();
                Liste.DataSource = null;

            }
            else
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from Patient where patient_id ='" + textcode.Text + "'";
                //SqlDataReader dr = cmd.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, cn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //string nom, prenom;
                foreach (DataRow row in dt.Rows)
                {
                    textnom.Text = row["nom"].ToString();
                    textprenom.Text = row["prenom"].ToString();
                }
                //dr.Close();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = cn;
                cmd1.CommandText = "select id,date,heure from RDV where patient_id=" + textcode.Text + " and medecin_id="+ LoginInfo.medID + " order by CAST(date AS NVARCHAR(10))";
                cmd1.ExecuteNonQuery();

                DataTable dta = new DataTable();
                SqlDataAdapter c = new SqlDataAdapter(cmd1.CommandText, cn); ;
                c.Fill(dta);
                Liste.DataSource = dta;

               // dr.Close();
                cn.Close();
            }
           

        }






        private bool verifierRDV()
        {
            cn.Open();
            SqlCommand cmd1 = cn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT date, heure FROM RDV where medecin_id=" + LoginInfo.medID;

            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            string[] d = dpdaterdv.Text.Split('/');
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

                if (jour1 == jour & mois1 == mois && annee3 == annee2 && msheurerdv.Text == row["heure"].ToString()) { return false; }



            }
            cn.Close();
            return true;
        }




        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet2.RDV'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            cn.Open();
            SqlCommand cmd1 = cn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM RDV where medecin_id=" + LoginInfo.medID;
            //text.Text =da;

            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd1.CommandText, cn);

            adapter.Fill(dt);
            Liste.DataSource = dt;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // mode de sélection qui permet de sélectionner toute la ligne de la liste 
            cn.Close();
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            if (verifierRDV()) {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = String.Format("update RDV set date='{0}',heure='{1}' where id={2}", dpdaterdv.Text, msheurerdv.Text, textnumrdv.Text);
                cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                                       // if (r != 0)
                                       //{
                MessageBox.Show("RDV bien modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                Liste.CurrentRow.Cells[0].Value = textnumrdv.Text; // modifier les infos du RDV sélectionné de la liste
                Liste.CurrentRow.Cells[1].Value = dpdaterdv.Text; // modifier les infos du RDV sélectionné de la liste
                Liste.CurrentRow.Cells[2].Value = msheurerdv.Text;
                //Liste.CurrentRow.Cells[3].Value = combocodem.SelectedItem.ToString();


                // }
                cn.Close();
            }
            else
            {
                MessageBox.Show("Le rendez_vous n\'a pas été crée / VEUILLEZ CHOISIR UNE AUTRE DATE POUR LE RENDEZ-VOUS!", "Insert failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (textnumrdv.Text == "")
            {
                MessageBox.Show("Champ Numéro RDV vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = String.Format("delete from RDV where Id='{0}'", textnumrdv.Text);
                int r = cmd.ExecuteNonQuery(); // ou ecrire cmd.ExecuteNonQuery() sans retour
                if (r != 0)
                {
                    MessageBox.Show("RDV bien supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    textnumrdv.Text = "";
                    dpdaterdv.Text = "";
                    msheurerdv.Text = "";
                    //combocodem.SelectedIndex = -1;
                    Liste.Rows.Remove(Liste.CurrentRow); //supprimer le RDV sélctionné de la liste
                }

            }
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            textcode.Text = ""; // zone code patient
            textnom.Text = ""; // zone nom patient
            textprenom.Text = "";
            Liste.DataSource = null; // zone liste d'affichage
            textnumrdv.Text = ""; // zone numéro RDV
            dpdaterdv.Text = ""; // zone date RDV
            msheurerdv.Text = ""; // zone heure RDV
            //combocodem.SelectedIndex = -1; // zone liste de codes médecin
        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // même que le formualire "Rechercher_RDV_Date"
            if (cn.State != ConnectionState.Open && Liste.Rows.Count != 0)
            {
                string coderdv = Liste.CurrentRow.Cells[0].Value.ToString();
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from RDV where Id='" + coderdv + "'";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textnumrdv.Text = dr[0].ToString();
                    //dpdaterdv.Value = DateTime.Parse(dr[].ToString());
                    dpdaterdv.Text = dr[1].ToString();

                    msheurerdv.Text = dr[2].ToString();
                    //combocodem.SelectedItem = dr[3].ToString();
                }
                dr.Close();
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            this.Hide();
            f.Show();
        }
    }
}
