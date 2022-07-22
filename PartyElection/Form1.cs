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
    public partial class FormElection : Form
    {
        public FormElection()
        {
            InitializeComponent();
        }

        void cleanTxBox()
        {
            txBoxProvinceName.Text = "";
            txBoxAParty.Text = "";
            txBoxBParty.Text = "";
            txBoxCParty.Text = "";
            txBoxDParty.Text = "";
            txBoxEParty.Text = "";
        }

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbElection;Integrated Security=True");

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (txBoxProvinceName.Text=="" || txBoxAParty.Text==""|| txBoxBParty.Text=="" || txBoxCParty.Text=="" || txBoxDParty.Text=="" || txBoxEParty.Text=="")

                MessageBox.Show("Areas can not be empty");

            else
            {
                connection.Open();

                SqlCommand vote = new SqlCommand("insert into TblProvince (provinceName, AParty, BParty, Cparty, DParty, EParty) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
                vote.Parameters.AddWithValue("@p1", txBoxProvinceName.Text);
                vote.Parameters.AddWithValue("@p2", txBoxAParty.Text);
                vote.Parameters.AddWithValue("@p3", txBoxBParty.Text);
                vote.Parameters.AddWithValue("@p4", txBoxCParty.Text);
                vote.Parameters.AddWithValue("@p5", txBoxDParty.Text);
                vote.Parameters.AddWithValue("@p6", txBoxEParty.Text);
                vote.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Vote entrance is succesfull..");
                cleanTxBox();

            }

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormGraphs form = new FormGraphs();
            this.Hide();
            form.Show();
        }
    }
}
