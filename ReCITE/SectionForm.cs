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

namespace ReCITE
{
    public partial class SectionForm : Form
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/db_recite.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbCommand sql2 = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);
        DataTable dt = new DataTable();
        public SectionForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_insert.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            tb_name.Visible = true;
            tb_name.Clear();
            tb_name.Focus();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_name.TextLength == 0)
            {
                MessageBox.Show("Incomplete Data");
            }
            else if (tb_name.TextLength > 1)
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                if (lbl_section_ID.Text == "1")
                {
                    sql = new OleDbCommand("Select * From tbl_sectionA where [stud_name]='" + tb_name.Text + "'", cn);
                    rd = sql.ExecuteReader();

                    int counted = 0;
                    while (rd.Read())
                    {
                        counted = counted + 1;
                    }

                    if (counted == 1)
                    {
                        MessageBox.Show("Duplicate Entry! Please try another entry.", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = new OleDbCommand("Insert into tbl_sectionA ([stud_name],[stud_section],[stud_score],[lifeline_1],[lifeline_2],[lifeline_3],[selected],[added_points]) values ('" + tb_name.Text + "','" + tb_section.Text + "','" + '0' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + '0' + "')", cn);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added!", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        refresh_LV_Stud_A();
                        clear_student();
                    }
                }
                else if (lbl_section_ID.Text == "2")
                {
                    sql = new OleDbCommand("Select * From tbl_sectionB where [stud_name]='" + tb_name.Text + "'", cn);
                    rd = sql.ExecuteReader();

                    int counted = 0;
                    while (rd.Read())
                    {
                        counted = counted + 1;
                    }

                    if (counted == 1)
                    {
                        MessageBox.Show("Duplicate Entry! Please try another entry.", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = new OleDbCommand("Insert into tbl_sectionB ([stud_name],[stud_section],[stud_score],[lifeline_1],[lifeline_2],[lifeline_3],[selected],[added_points]) values ('" + tb_name.Text + "','" + tb_section.Text + "','" + '0' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + '0' + "')", cn);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added!", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        refresh_LV_Stud_B();
                        clear_student();
                    }
                }
                else if (lbl_section_ID.Text == "3")
                {
                    sql = new OleDbCommand("Select * From tbl_sectionC where [stud_name]='" + tb_name.Text + "'", cn);
                    rd = sql.ExecuteReader();

                    int counted = 0;
                    while (rd.Read())
                    {
                        counted = counted + 1;
                    }

                    if (counted == 1)
                    {
                        MessageBox.Show("Duplicate Entry! Please try another entry.", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = new OleDbCommand("Insert into tbl_sectionC ([stud_name],[stud_section],[stud_score],[lifeline_1],[lifeline_2],[lifeline_3],[selected],[added_points]) values ('" + tb_name.Text + "','" + tb_section.Text + "','" + '0' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + '0' + "')", cn);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added!", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        refresh_LV_Stud_C();
                        clear_student();
                    }
                }
                else 
                {
                    sql = new OleDbCommand("Select * From tbl_sectionD where [stud_name]='" + tb_name.Text + "'", cn);
                    rd = sql.ExecuteReader();

                    int counted = 0;
                    while (rd.Read())
                    {
                        counted = counted + 1;
                    }

                    if (counted == 1)
                    {
                        MessageBox.Show("Duplicate Entry! Please try another entry.", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = new OleDbCommand("Insert into tbl_sectionD ([stud_name],[stud_section],[stud_score],[lifeline_1],[lifeline_2],[lifeline_3],[selected],[added_points]) values ('" + tb_name.Text + "','" + tb_section.Text + "','" + '0' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + 'N' + "','" + '0' + "')", cn);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added!", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        refresh_LV_Stud_D();
                        clear_student();
                    }
                }

                
            }
        }
        public void clear_student()
        {
            tb_name.Clear();

            btn_update.Visible = false;
            btn_insert.Visible = false;
            btn_delete.Visible = false;
            tb_name.Visible = false;

        }

        public void refresh_LV_Stud_A()
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
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd[0].ToString());
                    lv.SubItems.Add(rd[1].ToString());
                    lv.SubItems.Add(rd[3].ToString());
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

        public void refresh_LV_Stud_B()
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
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd[0].ToString());
                    lv.SubItems.Add(rd[1].ToString());
                    lv.SubItems.Add(rd[3].ToString());
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
        public void refresh_LV_Stud_C()
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
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd[0].ToString());
                    lv.SubItems.Add(rd[1].ToString());
                    lv.SubItems.Add(rd[3].ToString());
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
        public void refresh_LV_Stud_D()
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
                // ILABAS ANG LAMAN SA LISTVIEW
                while (rd.Read())
                {
                    ListViewItem lv = new ListViewItem(rd[0].ToString());
                    lv.SubItems.Add(rd[1].ToString());
                    lv.SubItems.Add(rd[3].ToString());
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

        private void get_section()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_section_ID.Text + "'", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows)
            {

                if (rd.Read())
                {
                    tb_section.Text = rd.GetValue(1).ToString();
                }
            }
        }

        private void btn_edit_section_Click(object sender, EventArgs e)
        {
            tb_section.Enabled = true;
            tb_section.Focus();
        }

        private void SectionA_Load(object sender, EventArgs e)
        {
            get_section();
            if (lbl_section_ID.Text == "1")
            {
                refresh_LV_Stud_A();
            }
            else if (lbl_section_ID.Text == "2")
            {
                refresh_LV_Stud_B();
            }
            else if (lbl_section_ID.Text == "3")
            {
                refresh_LV_Stud_C();
            }
            else 
            {
                refresh_LV_Stud_D();
            }
        }

        private void tb_section_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_section_ID.Text + "' ", cn);
                rd = sql.ExecuteReader();

                int counted = 0;
                while (rd.Read())
                {
                    counted = counted + 1;
                }

                if (counted == 1)
                {
                    sql = new OleDbCommand("Update tbl_all_section set [Section]='" + tb_section.Text + "' where ID like'" + lbl_section_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();

                    if (lbl_section_ID.Text == "1")
                    {
                        sql = new OleDbCommand("Update tbl_sectionA set [stud_section]='" + tb_section.Text + "' ", cn);
                        sql.ExecuteNonQuery();
                    }
                    else if (lbl_section_ID.Text == "2")
                    {
                        sql = new OleDbCommand("Update tbl_sectionB set [stud_section]='" + tb_section.Text + "' ", cn);
                        sql.ExecuteNonQuery();
                    }
                    else if (lbl_section_ID.Text == "3")
                    {
                        sql = new OleDbCommand("Update tbl_sectionC set [stud_section]='" + tb_section.Text + "' ", cn);
                        sql.ExecuteNonQuery();
                    }
                    else
                    {
                        sql = new OleDbCommand("Update tbl_sectionD set [stud_section]='" + tb_section.Text + "' ", cn);
                        sql.ExecuteNonQuery();
                    }
                    MessageBox.Show("Successfully Updated!", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    get_section();
                    tb_section.Enabled = false;
                }
            }
        }

        private void lv_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ID.Text = lv_student.Items[lv_student.FocusedItem.Index].Text;
            tb_name.Text = lv_student.Items[lv_student.FocusedItem.Index].SubItems[1].Text;

            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_insert.Visible = false;
            tb_name.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_name.TextLength == 0 )
            {
                MessageBox.Show("Incomplete Data", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                if (lbl_section_ID.Text == "1")
                {
                    sql = new OleDbCommand("Update tbl_sectionA set stud_name='" + tb_name.Text + "' where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_A();
                    clear_student();
                }
                else if (lbl_section_ID.Text == "2")
                {
                    sql = new OleDbCommand("Update tbl_sectionB set stud_name='" + tb_name.Text + "' where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_B();
                    clear_student();
                }
                else if (lbl_section_ID.Text == "3")
                {
                    sql = new OleDbCommand("Update tbl_sectionC set stud_name='" + tb_name.Text + "' where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_C();
                    clear_student();
                }
                else
                {
                    sql = new OleDbCommand("Update tbl_sectionD set stud_name='" + tb_name.Text + "' where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Updated", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_D();
                    clear_student();
                }

                
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ClassList m = new ClassList();
            m.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this student?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                if (lbl_section_ID.Text == "1")
                {
                    sql = new OleDbCommand("Delete from tbl_sectionA where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_A();
                    clear_student();
                }
                else if (lbl_section_ID.Text == "1")
                {
                    sql = new OleDbCommand("Delete from tbl_sectionB where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_B();
                    clear_student();
                }
                else if (lbl_section_ID.Text == "1")
                {
                    sql = new OleDbCommand("Delete from tbl_sectionC where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_C();
                    clear_student();
                }
                else
                {
                    sql = new OleDbCommand("Delete from tbl_sectionD where ID like '" + lbl_ID.Text + "'", cn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted", "ReCITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    refresh_LV_Stud_D();
                    clear_student();
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GameMenu m = new GameMenu();
            m.lbl_secID.Text = lbl_section_ID.Text;
            m.Show();
            this.Hide();
        }

        private void tb_section_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
