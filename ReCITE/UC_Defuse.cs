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
    public partial class UC_Defuse : UserControl
    {
        WindowsMediaPlayer intro = new WindowsMediaPlayer();
        WindowsMediaPlayer bomb = new WindowsMediaPlayer();
        WindowsMediaPlayer explode = new WindowsMediaPlayer();
        WindowsMediaPlayer defused = new WindowsMediaPlayer();

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/db_recite.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);
        DataTable dt = new DataTable();
        public UC_Defuse()
        {
            InitializeComponent();
        }

        private void UC_Defuse_Load(object sender, EventArgs e)
        {
            
        }
        private void call_name()
        {
            Random name = new Random();
            int a = lb_stud.Items.Count;
            int selected = name.Next(a);

            lb_stud.SelectedIndex = selected;

            lbl_stud.Text = lb_stud.SelectedItem.ToString();

        }
        private void check_wire()
        {
            var chars = "NY";
            var stringChars = new char[1];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            lbl_wire.Text = finalString.ToString();
        }
        public void play_player()
        {
            intro.URL = "The Pink Panther Theme Song.mp3";
            intro.settings.setMode("loop", true);
            intro.controls.play();
        }
        public void stop_player()
        {
            intro.controls.stop();
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
                        reset_wire();
                        end_defuse();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_A();
                        call_name();
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
                        reset_wire();
                        end_defuse();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_B();
                        call_name();
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
                        reset_wire();
                        end_defuse();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_C();
                        call_name();
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
                    DialogResult dialogResult = MessageBox.Show("All players have played this game. Do you want to replay game?", "ReCITE", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                    if (dialogResult == DialogResult.Yes)
                    {
                        reset_wire();
                        end_defuse();
                        lb_stud.Items.Clear();
                        refresh_LB_Stud_D();
                        call_name();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        refresh_LB_Stud_D();
                    }
                }
            }
            cn.Close();
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
        public void end_defuse()
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
        public void call_wire()
        {
            btn_red.Visible = true;
            btn_blue.Visible = true;
            btn_green.Visible = true;
        }
        public void reset_wire()
        {
            btn_red.Visible = true;
            btn_green.Visible = true;
            btn_blue.Visible = true;
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

        private void btn_start_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();

            bomb.URL = "bomb-has-been-planted-sound-effect-cs-go.mp3";
            intro.controls.stop();
            bomb.controls.play();

            btn_red.Enabled = true;
            btn_green.Enabled = true;
            btn_blue.Enabled = true;

            lbl_wire.Text = " ";
            call_name();
            get_score();
            
            if (btn_red.Visible == false || btn_green.Visible == false || btn_blue.Visible == false)
            {
                reset_wire();
            }
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
            call_name();
            get_score();
            lifelines();
            reset_wire();
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

            update_select();
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

            update_select();
            get_score();
            lifelines();
        }
        private void btn_red_Click(object sender, EventArgs e)
        {
            lbl_wire.Text = " ";
            get_score();
            check_wire();
            lifelines();

            if (lbl_wire.Text == "N")
            {
                defused.URL = "bomb-has-been-defused-csgo-sound-effect.mp3";
                defused.controls.play();
                update_select();
                update_LB_Stud(); 
                call_name();
            }
            else if (lbl_wire.Text == "Y")
            {
                btn_add_point.Enabled = true;
                explode.URL = "bomb.mp3";
                explode.controls.play();
                update_select();
            }

            btn_red.Visible = false;

            if (btn_green.Visible == false && btn_blue.Visible == false)
            {
                check_wire();
            }
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            lbl_wire.Text = " ";
            get_score();
            check_wire();

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

            if (lbl_wire.Text == "N")
            {
                defused.URL = "bomb-has-been-defused-csgo-sound-effect.mp3";
                defused.controls.play();
                update_select();
                update_LB_Stud();
                call_name();
            }
            else if (lbl_wire.Text == "Y")
            {
                btn_add_point.Enabled = true;
                explode.URL = "bomb.mp3";
                explode.controls.play();
                update_select();
            }

            btn_green.Visible = false;

            if (btn_red.Visible == false && btn_blue.Visible == false)
            {
                check_wire();
            }
            
            
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            lbl_wire.Text = " ";
            get_score();
            check_wire();

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

            if (lbl_wire.Text == "N")
            {
                defused.URL = "bomb-has-been-defused-csgo-sound-effect.mp3";
                defused.controls.play();
                update_select();
                update_LB_Stud();
                call_name();
            }
            else if (lbl_wire.Text == "Y")
            {
                btn_add_point.Enabled = true;
                explode.URL = "bomb.mp3";
                explode.controls.play();
                update_select();
            }

            btn_blue.Visible = false;

            if (btn_red.Visible == false && btn_green.Visible == false)
            {
                check_wire();
            }

            
        }

        private void btn_add_point_Click(object sender, EventArgs e)
        {
            add_score();
            update_LB_Stud();
            call_name();
            reset_wire();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (lbl_line1.Text == "N")
            {
                btn_lifeline1.Visible = true;
            }
            else
            {
                btn_lifeline1.Visible = false;
            }

            if (btn_red.Visible == false && btn_green.Visible == false && btn_blue.Visible == false)
            {
                reset_wire();
            }
        }
    }
}
