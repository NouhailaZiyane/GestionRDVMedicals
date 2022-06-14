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
    public partial class Form12 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\WindowsFormsApp3\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet5.RDV'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rDVTableAdapter.Fill(this.database1DataSet5.RDV);
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet4.secretaire'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.secretaireTableAdapter.Fill(this.database1DataSet4.secretaire);

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
        private void button3_Click(object sender, EventArgs e)
        {
            if (verifierRDV())
            {
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                string id;
                if (dr.Read())
                {
                    textnumrdv.Text = dr[0].ToString();
                    //dpdaterdv.Value = DateTime.Parse(dr[].ToString());
                    dpdaterdv.Text = dr[1].ToString();

                    msheurerdv.Text = dr[2].ToString();
                    msheurerdv.Text = dr[2].ToString();
                    LoginInfo.medID = dr[3].ToString();
                    //combocodem.SelectedItem = dr[3].ToString();
                }
                dr.Close();
                cn.Close();
            }
        }

        private void choix_TextChanged(object sender, EventArgs e)
        {
            if (choix1.Text == "Patient")
            {
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from RDV where patient_id like '%" + choix.Text + "%'";

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, cn); ;
                dataadp.Fill(dta);
                Liste.DataSource = dta;


                cn.Close();
            }else if (choix1.Text == "Medecin")
            {
                cn.Open();

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from RDV where medecin_id like '%" + choix.Text + "%'";

                cmd.ExecuteNonQuery();
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, cn); ;
                dataadp.Fill(dta);
                Liste.DataSource = dta;


                cn.Close();
            }
        }

        private void choix1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choix1.Text == "Date")
            {
                choix.Hide();
                hide.Visible = true;
            }
            else
            {
                hide.Hide();
                choix.Visible = true;
            }
        }

        private void hide_ValueChanged(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RDV where date like '%" + hide.Text + "%'";

            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, cn); ;
            dataadp.Fill(dta);
            Liste.DataSource = dta;


            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f = new Form13();
            f.Show();
        }
    }
}
