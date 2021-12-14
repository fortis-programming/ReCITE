using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using WMPLib;

namespace ReCITE
{
    public partial class UC_LottoName : UserControl
    {
        WindowsMediaPlayer intro = new WindowsMediaPlayer();
        WindowsMediaPlayer play = new WindowsMediaPlayer();

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/db_recite.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);
        DataTable dt = new DataTable();
        public UC_LottoName()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_stud.BringToFront();
            lb_stud.Show();
            btn_play.Visible = true;
            lbl_stud.Visible = true;
            stop_player();
            play.URL = "smb_pipe.mp3";
            play.controls.play();
        }

        private void UC_LottoName_Load(object sender, EventArgs e)
        {
            lifelines();
        }


        public void play_player()
        {
            intro.URL = "super_mario_game.mp3";
            intro.settings.setMode("loop", true);
            intro.controls.play();
        }
        public void stop_player()
        {
            intro.controls.stop();
        }
        public void refresh_LB_Stud_A()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            sql = new OleDbCommand("Select * From tbl_sectionA", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows == true)
            {
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    lb_stud.Items.Add(rd[1].ToString());
                }
            }
            else
            {
                // walang laman
                MessageBox.Show("No Record Found.");
            }
            cn.Close();
        }
        public void refresh_LB_Stud_B()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            sql = new OleDbCommand("Select * From tbl_sectionB", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows == true)
            {
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    lb_stud.Items.Add(rd[1].ToString());
                }
            }
            else
            {
                // walang laman
                MessageBox.Show("No Record Found.");
            }
            cn.Close();
        }
        public void refresh_LB_Stud_C()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            sql = new OleDbCommand("Select * From tbl_sectionC", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows == true)
            {
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    lb_stud.Items.Add(rd[1].ToString());
                }
            }
            else
            {
                // walang laman
                MessageBox.Show("No Record Found.");
            }
            cn.Close();
        }
        public void refresh_LB_Stud_D()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            sql = new OleDbCommand("Select * From tbl_sectionD", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows == true)
            {
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    lb_stud.Items.Add(rd[1].ToString());
                }
            }
            else
            {
                // walang laman
                MessageBox.Show("No Record Found.");
            }
            cn.Close();
        }
        public void get_score()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            if (lbl_secID1.Text == "1")
            {
                sql = new OleDbCommand("Select * From tbl_sectionA where stud_name like'" + lbl_stud.Text + "' ", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        lbl_score.Text = rd.GetValue(3).ToString();
                        lbl_line1.Text = rd.GetValue(4).ToString();
                        lbl_line2.Text = rd.GetValue(5).ToString();
                        lbl_line3.Text = rd.GetValue(6).ToString();
                        lbl_ap.Text = rd.GetValue(8).ToString();
                    }
                }
                cn.Close();
            }
            else if (lbl_secID1.Text == "2")
            {
                sql = new OleDbCommand("Select * From tbl_sectionB where stud_name like'" + lbl_stud.Text + "' ", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        lbl_score.Text = rd.GetValue(3).ToString();
                        lbl_line1.Text = rd.GetValue(4).ToString();
                        lbl_line2.Text = rd.GetValue(5).ToString();
                        lbl_line3.Text = rd.GetValue(6).ToString();
                        lbl_ap.Text = rd.GetValue(8).ToString();
                    }
                }
                cn.Close();
            }
            else if (lbl_secID1.Text == "3")
            {
                sql = new OleDbCommand("Select * From tbl_sectionC where stud_name like'" + lbl_stud.Text + "' ", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        lbl_score.Text = rd.GetValue(3).ToString();
                        lbl_line1.Text = rd.GetValue(4).ToString();
                        lbl_line2.Text = rd.GetValue(5).ToString();
                        lbl_line3.Text = rd.GetValue(6).ToString();
                        lbl_ap.Text = rd.GetValue(8).ToString();
                    }
                }
                cn.Close();
            }
            else
            {
                sql = new OleDbCommand("Select * From tbl_sectionD where stud_name like'" + lbl_stud.Text + "' ", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        lbl_score.Text = rd.GetValue(3).ToString();
                        lbl_line1.Text = rd.GetValue(4).ToString();
                        lbl_line2.Text = rd.GetValue(5).ToString();
                        lbl_line3.Text = rd.GetValue(6).ToString();
                        lbl_ap.Text = rd.GetValue(8).ToString();
                    }
                }
                cn.Close();
            }

        }
        public void update_select()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID1.Text == "1")
            {
                sql = new OleDbCommand("Update tbl_sectionA set selected='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID1.Text == "2")
            {
                sql = new OleDbCommand("Update tbl_sectionB set selected='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID1.Text == "3")
            {
                sql = new OleDbCommand("Update tbl_sectionC set selected='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set selected='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void lifelines()
        {
            if (lbl_line1.Text == "N")
            {
                btn_lifeline1.Visible = true;
            }
            else
            {
                btn_lifeline1.Visible = false;
            }

            if (lbl_line2.Text == "N")
            {
                btn_lifeline2.Visible = true;
            }
            else
            {
                btn_lifeline2.Visible = false;
            }

            if (lbl_line3.Text == "N")
            {
                btn_lifeline3.Visible = true;
            }
            else
            {
                btn_lifeline3.Visible = false;
            }
        }
        public void update_LB_Stud()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            if (lbl_secID1.Text == "1")
            {
                lb_stud.Items.Clear();

                sql = new OleDbCommand("Select * From tbl_sectionA where selected like'" + 'N' + "'", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    // ILABAS ANG LAMAN SA LISTVIEW
                    while (rd.Read())
                    {
                        lb_stud.Items.Add(rd[1].ToString());
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("All players have played this game. Do you want to replay game?", "ReCITE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dialogResult == DialogResult.Yes)
                    {
                        end_lottogame();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_A();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        refresh_LB_Stud_A();

                    }
                }
            }
            else if (lbl_secID1.Text == "2")
            {
                lb_stud.Items.Clear();

                sql = new OleDbCommand("Select * From tbl_sectionB where selected like'" + 'N' + "'", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    // ILABAS ANG LAMAN SA LISTVIEW
                    while (rd.Read())
                    {
                        lb_stud.Items.Add(rd[1].ToString());
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("All players have played this game. Do you want to replay game?", "ReCITE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dialogResult == DialogResult.Yes)
                    {
                        end_lottogame();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_B();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        refresh_LB_Stud_B();
                    }
                }
            }
            else if (lbl_secID1.Text == "3")
            {
                lb_stud.Items.Clear();

                sql = new OleDbCommand("Select * From tbl_sectionC where selected like'" + 'N' + "'", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    // ILABAS ANG LAMAN SA LISTVIEW
                    while (rd.Read())
                    {
                        lb_stud.Items.Add(rd[1].ToString());
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("All players have played this game. Do you want to replay game?", "ReCITE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dialogResult == DialogResult.Yes)
                    {
                        end_lottogame();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_C();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        refresh_LB_Stud_C();
                    }
                }
            }
            else
            {
                lb_stud.Items.Clear();

                sql = new OleDbCommand("Select * From tbl_sectionD where selected like'" + 'N' + "'", cn);
                rd = sql.ExecuteReader();
                if (rd.HasRows == true)
                {
                    // ILABAS ANG LAMAN SA LISTVIEW
                    while (rd.Read())
                    {
                        lb_stud.Items.Add(rd[1].ToString());
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("All players have played this game. Play again?", "ReCITE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dialogResult == DialogResult.Yes)
                    {
                        end_lottogame();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_D();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        refresh_LB_Stud_D();
                    }
                }
            }
            cn.Close();
        }
        private void randomcode()
        {
            Random name = new Random();
            int a = lb_stud.Items.Count;
            int selected = name.Next(a);

            lb_stud.SelectedIndex = selected;

            lbl_stud.Text = lb_stud.SelectedItem.ToString();

        }
        public void add_score()
        {
            lbl_ttl_score.Text = Convert.ToString(Convert.ToInt32(lbl_score.Text) + 1);
            lbl_ttl_ap.Text = Convert.ToString(Convert.ToInt32(lbl_ap.Text) + 1);

            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID1.Text == "1")
            {
                sql = new OleDbCommand("Update tbl_sectionA set stud_score='" + lbl_ttl_score.Text + "',added_points='" + lbl_ttl_ap.Text + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID1.Text == "2")
            {
                sql = new OleDbCommand("Update tbl_sectionB set stud_score='" + lbl_ttl_score.Text + "',added_points='" + lbl_ttl_ap.Text + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID1.Text == "3")
            {
                sql = new OleDbCommand("Update tbl_sectionC set stud_score='" + lbl_ttl_score.Text + "',added_points='" + lbl_ttl_ap.Text + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set stud_score='" + lbl_ttl_score.Text + "',added_points='" + lbl_ttl_ap.Text + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
        }
        public void end_lottogame()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID1.Text == "1")
            {
                sql = new OleDbCommand("Update tbl_sectionA set lifeline_1='" + 'N' + "',lifeline_2='" + 'N' + "',lifeline_3='" + 'N' + "',selected='" + 'N' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID1.Text == "2")
            {
                sql = new OleDbCommand("Update tbl_sectionB set lifeline_1='" + 'N' + "',lifeline_2='" + 'N' + "',lifeline_3='" + 'N' + "',selected='" + 'N' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else if (lbl_secID1.Text == "3")
            {
                sql = new OleDbCommand("Update tbl_sectionC set lifeline_1='" + 'N' + "',lifeline_2='" + 'N' + "',lifeline_3='" + 'N' + "',selected='" + 'N' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set lifeline_1='" + 'N' + "',lifeline_2='" + 'N' + "',lifeline_3='" + 'N' + "',selected='" + 'N' + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            update_select();
            update_LB_Stud();
            randomcode();
            get_score();
            lifelines();

            btn_add_point.Visible = true;
            label8.Visible = true;
        }

        private void btn_add_point_Click(object sender, EventArgs e)
        {
            add_score();
        }
        private void btn_lifeline1_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID1.Text == "1" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionA set lifeline_1='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else if (lbl_secID1.Text == "2" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionB set lifeline_1='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else if (lbl_secID1.Text == "3" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionC set lifeline_1='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set lifeline_1='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            update_select();
            update_LB_Stud();
            randomcode();
            get_score();
            lifelines();
        }
        private void btn_lifeline2_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID1.Text == "1" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionA set lifeline_2='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else if (lbl_secID1.Text == "2" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionB set lifeline_2='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else if (lbl_secID1.Text == "3" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionC set lifeline_2='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set lifeline_2='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            get_score();
            lifelines();

        }
        private void btn_lifeline3_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            if (lbl_secID1.Text == "1" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionA set lifeline_3='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else if (lbl_secID1.Text == "2" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionB set lifeline_3='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else if (lbl_secID1.Text == "3" && lbl_line1.Text == "N")
            {
                sql = new OleDbCommand("Update tbl_sectionC set lifeline_3='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }
            else
            {
                sql = new OleDbCommand("Update tbl_sectionD set lifeline_3='" + 'Y' + "' where stud_name like '" + lb_stud.Text + "'", cn);
                sql.ExecuteNonQuery();
                cn.Close();
            }

            get_score();
            lifelines();
        }
    }
}
