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

namespace PartyElection
{
    public partial class FormGraphs : Form
    {
        public FormGraphs()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbElection;Integrated Security=True");

        private void FormGraphs_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand provinceName = new SqlCommand("select provinceName from TblProvince", connection);
            SqlDataReader read = provinceName.ExecuteReader();
            while (read.Read())
            {
                cmBoxProvince.Items.Add(read[0]);
            }
            connection.Close();

            connection.Open();
            SqlCommand graphs = new SqlCommand("select SUM(AParty), SUM(BParty), SUM(CParty), SUm(DParty), SUM(EParty) from TblProvince", connection);
            SqlDataReader read2 = graphs.ExecuteReader();
            while(read2.Read())
            {
                chart1.Series["Parties"].Points.AddXY("A Party", read2[0]);
                chart1.Series["Parties"].Points.AddXY("B Party", read2[1]);
                chart1.Series["Parties"].Points.AddXY("C Party", read2[2]);
                chart1.Series["Parties"].Points.AddXY("D Party", read2[3]);
                chart1.Series["Parties"].Points.AddXY("E Party", read2[4]);
            }

            connection.Close();

        }

        private void cmBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand chooseProvince = new SqlCommand("select * from TblProvince where provinceName=@p1", connection);
            chooseProvince.Parameters.AddWithValue("@p1", cmBoxProvince.Text);
            SqlDataReader read3 = chooseProvince.ExecuteReader();
            while(read3.Read())
            {
                progBarAParty.Value = int.Parse(read3[2].ToString());
                progBarBParty.Value = int.Parse(read3[3].ToString());
                progBarCParty.Value = int.Parse(read3[4].ToString());
                progBarDParty.Value = int.Parse(read3[5].ToString());
                progBarEParty.Value = int.Parse(read3[6].ToString());

                lblAScore.Text = read3[2].ToString();
                lblBScore.Text = read3[2].ToString();
                lblCScore.Text = read3[4].ToString();
                lblDScore.Text = read3[5].ToString();
                lblEScore.Text = read3[6].ToString();
            }

           


            connection.Close();
        }

        private void btnVotePage_Click(object sender, EventArgs e)
        {
            FormElection form = new FormElection();
            this.Hide();
            form.Show();
        }
    }
}
