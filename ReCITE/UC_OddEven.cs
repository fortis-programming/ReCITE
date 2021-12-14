using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Data.OleDb;

namespace ReCITE
{
    public partial class UC_OddEven : UserControl
    {
        WindowsMediaPlayer player1 = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        WindowsMediaPlayer gunshot = new WindowsMediaPlayer();
        WindowsMediaPlayer doll = new WindowsMediaPlayer();

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/db_recite.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);
        DataTable dt = new DataTable();
        public UC_OddEven()
        {
            InitializeComponent();
        }

        private void UC_OddEven_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void randomcode()
        {
            Random name = new Random();
            int a = lb_stud.Items.Count;
            int selected = name.Next(a);

            lb_stud.SelectedIndex = selected;

            lbl_stud.Text = lb_stud.SelectedItem.ToString();

            var chars = "0123456789";
            var stringChars = new char[2];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            lbl_number.Text = finalString.ToString();

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player2.URL = "green-light.mp3";
            player1.controls.stop();
            player2.controls.play();
            panel1.Show();
            panel1.BringToFront();
            lbl_stud.Show();
            randomcode();
            get_score();
        }
        public void play_player()
        {
            player1.URL = "opening-sound.mp3";
            player1.settings.setMode("loop", true);
            player1.controls.play();
        }
        public void stop_player()
        {
            player1.controls.stop();
        }
        private void btn_even_Click(object sender, EventArgs e)
        {
            lbl_number.Show();

            int num, rem;
            num = Convert.ToInt32(lbl_number.Text);
            rem = num % 2;

            if (rem == 0)
            {
                update_select();
            }
            else
            {
                update_select();
                gunshot.URL = "squid-game-gunshot.mp3";
                gunshot.controls.play();
            }
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
        public void end_oddeven()
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
                        end_oddeven();
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
                        end_oddeven();
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
                        end_oddeven();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_C();
                        randomcode();
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
                        end_oddeven();
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
        private void btn_odd_Click(object sender, EventArgs e)
        {
            lbl_number.Show();

            int num, rem;
            num = Convert.ToInt32(lbl_number.Text);
            rem = num % 2;

            if (rem != 0)
            {
                update_select();
            }
            else
            {
                update_select();
                gunshot.URL = "squid-game-gunshot.mp3";
                gunshot.controls.play();
            }
        }
        private void btn_add_point_Click(object sender, EventArgs e)
        {
            add_score();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            update_LB_Stud();
            doll.URL = "squid-game-doll.mp3";
            doll.controls.play();
            randomcode();
            get_score();
            lbl_number.Hide();
            lifelines();

            if (lbl_line3.Text == "N")
            {
                btn_lifeline3.Visible = true;
            }
            else
            {
                btn_lifeline3.Visible = false;
            }

            btn_add_point.Visible = true;
        }

        private void btn_lifeline1_Click(object sender, EventArgs e)
        {
            lbl_number.Hide(); 

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
