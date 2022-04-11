using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W8_Latihan_Jumat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter mySqlAdapter;
        public string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtTeam = new DataTable();
            DataTable dtTeam2 = new DataTable();
            sqlQuery = "SELECT t.team_name as 'Nama Tim', t.team_id as 'ID Team', t.home_stadium as 'Home Stadium', t.capacity as 'Capacity', m.manager_name as  `Manager`, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            mySqlAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlAdapter.Fill(dtTeam);
            mySqlAdapter.Fill(dtTeam2);
            cb_timHome.DataSource = dtTeam;
            cb_timAway.DataSource = dtTeam2;
            cb_timAway.DisplayMember = "Nama Tim";
            cb_timHome.DisplayMember = "Nama Tim";
            //lbl_isiStadium.Text.= dtTeam.Rows;
            //lbl_isiKapasitas.Text = "Capacity";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_isimanagerHome_Click(object sender, EventArgs e)
        {

        }

        private void lbl_stadium_Click(object sender, EventArgs e)
        {

        }

        private void cb_timHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtStadium = new DataTable();
            DataTable dtCapacity = new DataTable(); 
            DataTable dtCaptain = new DataTable();
            DataTable dtManager = new DataTable();
            
            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            mySqlAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlAdapter.Fill(dtStadium);
            mySqlAdapter.Fill(dtCapacity);
            mySqlAdapter.Fill(dtManager);
            mySqlAdapter.Fill(dtCaptain);
            lbl_isiStadium.Text = dtStadium.Rows[cb_timHome.SelectedIndex][2].ToString();
            lbl_isiKapasitas.Text  = dtCapacity.Rows[cb_timHome.SelectedIndex][3].ToString();
            lbl_isicaptainHome.Text = dtCaptain.Rows[cb_timHome.SelectedIndex][5].ToString();
            lbl_isimanagerHome.Text = dtManager.Rows[cb_timHome.SelectedIndex][4].ToString();
            

        }

        private void cb_timAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCaptain = new DataTable();
            DataTable dtManager = new DataTable();

            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            mySqlAdapter = new MySqlDataAdapter(sqlCommand);
   
            mySqlAdapter.Fill(dtManager);
            mySqlAdapter.Fill(dtCaptain);
            lbl_isicaptainAway.Text = dtCaptain.Rows[cb_timAway.SelectedIndex][5].ToString();
            lbl_isimanagerAway.Text = dtManager.Rows[cb_timAway.SelectedIndex][4].ToString();
        }
    }
}
