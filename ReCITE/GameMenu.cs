using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using WMPLib;

namespace ReCITE
{
    public partial class GameMenu : Form
    {
        WindowsMediaPlayer intro = new WindowsMediaPlayer();

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/db_recite.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);
        DataTable dt = new DataTable();
        public GameMenu()
        {
            InitializeComponent();
        }
        public void play_player()
        {
            intro.URL = "ending.mp3";
            intro.settings.setMode("loop", true);
            intro.controls.play();
        }
        public void stop_player()
        {
            intro.controls.stop();
        }
        private void btn_end_Click(object sender, EventArgs e)
        {
            play_player();
            uC_LottoName1.Hide();
            uC_OddEven1.Hide();
            uC_Defuse1.Hide();
            panel1.Show();
            panel1.BringToFront();
            btn_refresh_lv.BringToFront();

            uC_LottoName1.lb_stud.SelectedIndices.Clear();
            uC_LottoName1.lbl_stud.Text = "Student Name";
            uC_LottoName1.lb_stud.Hide();
            uC_LottoName1.btn_play.Hide();
            uC_LottoName1.btn_add_point.Hide();
            uC_LottoName1.btn_lifeline1.Hide();
            uC_LottoName1.btn_lifeline2.Hide();
            uC_LottoName1.btn_lifeline3.Hide();
            uC_LottoName1.lbl_stud.Hide();
            uC_LottoName1.label8.Hide();
            uC_LottoName1.end_lottogame();
            uC_LottoName1.stop_player();

            uC_OddEven1.lb_stud.SelectedIndices.Clear();
            uC_OddEven1.lbl_stud.Text = "Student Name";
            uC_OddEven1.lb_stud.Hide();
            uC_OddEven1.panel1.Hide();
            uC_OddEven1.lbl_stud.Hide();
            uC_OddEven1.end_oddeven();
            uC_OddEven1.stop_player();
            uC_OddEven1.lbl_number.Text = "00";
            uC_OddEven1.lbl_number.Hide();

            uC_Defuse1.panel1.Hide();
            uC_Defuse1.panel1.SendToBack();
            uC_Defuse1.stop_player();
            uC_Defuse1.end_defuse();

            get_section();

        }

        public void refresh_LB_LeaderBoard()
        {
            if (lbl_secID.Text == "1")
            {
                lv_leaderboard.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionA", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_leaderboard.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
            else if (lbl_secID.Text == "2")
            {
                lv_leaderboard.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionB", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_leaderboard.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
            else if (lbl_secID.Text == "3")
            {
                lv_leaderboard.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionC", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_leaderboard.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
            else
            {
                lv_leaderboard.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionD", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_leaderboard.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
        }
        public void refresh_LV_Student()
        {
            if (lbl_secID.Text == "1")
            {
                lv_student.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionA", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_student.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
            else if (lbl_secID.Text == "2")
            {
                lv_student.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionB", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_student.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
            else if (lbl_secID.Text == "3")
            {
                lv_student.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionC", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_student.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
            else
            {
                lv_student.Items.Clear();
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                sql = new OleDbCommand("Select * From tbl_sectionD", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        ListViewItem lv = new ListViewItem(rd[0].ToString());
                        lv.SubItems.Add(rd[1].ToString());
                        lv.SubItems.Add(rd[8].ToString());
                        lv_student.Items.Add(lv);
                    }
                }
                else
                {
                    // walang laman
                    MessageBox.Show("No Record Found.");
                }
                cn.Close();
            }
        }
        private void get_section()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_secID.Text + "'", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows)
            {

                if (rd.Read())
                {
                    lbl_section.Text = rd.GetValue(1).ToString();
                    refresh_LV_Student();
                }
            }
        }
        public void reset_points()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID.Text == "1")
            {
                sql = new OleDbCommand("Update tbl_sectionA set added_points='" + '0' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID.Text == "2")
            {
                sql = new OleDbCommand("Update tbl_sectionB set added_points='" + '0' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID.Text == "3")
            {
                sql = new OleDbCommand("Update tbl_sectionC set added_points='" + '0' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set added_points='" + '0' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
        }
        private void GameMenu_Load(object sender, EventArgs e)
        {
            stop_player();
            refresh_LB_LeaderBoard();
            uC_LottoName1.play_player();
            uC_OddEven1.Hide();
            uC_Defuse1.Hide();

            if (lbl_secID.Text == "1")
            {
                uC_LottoName1.refresh_LB_Stud_A();
                uC_OddEven1.refresh_LB_Stud_A();
                uC_Defuse1.refresh_LB_Stud_A();
                uC_LottoName1.lbl_secID1.Text = lbl_secID.Text;
                uC_OddEven1.lbl_secID1.Text = lbl_secID.Text;
                uC_Defuse1.lbl_secID1.Text = lbl_secID.Text;
            }
            else if (lbl_secID.Text == "2")
            {
                uC_LottoName1.refresh_LB_Stud_B();
                uC_OddEven1.refresh_LB_Stud_B();
                uC_Defuse1.refresh_LB_Stud_B();
                uC_LottoName1.lbl_secID1.Text = lbl_secID.Text;
                uC_OddEven1.lbl_secID1.Text = lbl_secID.Text;
                uC_Defuse1.lbl_secID1.Text = lbl_secID.Text;
            }
            else if (lbl_secID.Text == "3")
            {
                uC_LottoName1.refresh_LB_Stud_C();
                uC_OddEven1.refresh_LB_Stud_C();
                uC_Defuse1.refresh_LB_Stud_C();
                uC_LottoName1.lbl_secID1.Text = lbl_secID.Text;
                uC_OddEven1.lbl_secID1.Text = lbl_secID.Text;
                uC_Defuse1.lbl_secID1.Text = lbl_secID.Text;
            }
            else
            {
                uC_LottoName1.refresh_LB_Stud_D();
                uC_OddEven1.refresh_LB_Stud_D();
                uC_Defuse1.refresh_LB_Stud_D();
                uC_LottoName1.lbl_secID1.Text = lbl_secID.Text;
                uC_OddEven1.lbl_secID1.Text = lbl_secID.Text;
                uC_Defuse1.lbl_secID1.Text = lbl_secID.Text;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            stop_player();
            uC_LottoName1.stop_player();
            uC_OddEven1.stop_player();
            uC_Defuse1.stop_player();
            ClassList cl = new ClassList();
            cl.Show();
            this.Hide();
        }

        private void btn_refresh_lv_Click(object sender, EventArgs e)
        {
            refresh_LB_LeaderBoard();
        }

        private void btn_odd_even_Click(object sender, EventArgs e)
        {
            stop_player();
            uC_OddEven1.Show();
            uC_LottoName1.Hide();
            uC_OddEven1.BringToFront();
            uC_OddEven1.play_player();
            uC_LottoName1.stop_player();
            uC_Defuse1.stop_player();

            uC_OddEven1.lb_stud.SelectedIndices.Clear();
            uC_OddEven1.lbl_stud.Text = "Student Name";
            uC_OddEven1.lb_stud.Hide();
            uC_OddEven1.panel1.Hide();
            uC_OddEven1.lbl_stud.Hide();
            uC_OddEven1.end_oddeven();
        }

        private void btn_pick_name_Click(object sender, EventArgs e)
        {
            stop_player();
            uC_OddEven1.stop_player();
            uC_Defuse1.stop_player();
            uC_LottoName1.play_player();
            uC_OddEven1.Hide();
            uC_LottoName1.Show();
            uC_LottoName1.BringToFront();
            uC_LottoName1.lb_stud.SelectedIndices.Clear();
            uC_LottoName1.lbl_stud.Text = "Student Name";
            uC_LottoName1.lb_stud.Hide();
            uC_LottoName1.btn_play.Hide();
            uC_LottoName1.btn_add_point.Hide();
            uC_LottoName1.btn_lifeline1.Hide();
            uC_LottoName1.btn_lifeline2.Hide();
            uC_LottoName1.btn_lifeline3.Hide();
            uC_LottoName1.lbl_stud.Hide();
            uC_LottoName1.end_lottogame();
        }

        private void btn_defuse_Click(object sender, EventArgs e)
        {
            stop_player();
            uC_OddEven1.stop_player();
            uC_LottoName1.stop_player();
            uC_OddEven1.Hide();
            uC_LottoName1.Hide();

            uC_LottoName1.lb_stud.SelectedIndices.Clear();
            uC_LottoName1.lbl_stud.Text = "Student Name";
            uC_LottoName1.lb_stud.Hide();
            uC_LottoName1.btn_play.Hide();
            uC_LottoName1.btn_add_point.Hide();
            uC_LottoName1.btn_lifeline1.Hide();
            uC_LottoName1.btn_lifeline2.Hide();
            uC_LottoName1.btn_lifeline3.Hide();
            uC_LottoName1.lbl_stud.Hide();
            uC_LottoName1.end_lottogame();
            uC_LottoName1.stop_player();

            uC_OddEven1.lb_stud.SelectedIndices.Clear();
            uC_OddEven1.panel1.Hide();
            uC_OddEven1.end_oddeven();
            uC_OddEven1.stop_player();

            uC_Defuse1.Show();
            uC_Defuse1.panel1.Hide();
            uC_Defuse1.BringToFront();
            uC_Defuse1.play_player();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            reset_points();
            stop_player();
            ClassList cl = new ClassList();
            cl.Show();
            this.Hide();
        }
    }
}
