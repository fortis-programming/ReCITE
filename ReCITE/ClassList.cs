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
    public partial class ClassList : Form
    {
        // TANGINA MO KRIS
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/db_recite.accdb");
        OleDbCommand sql = default(OleDbCommand);
        OleDbDataReader rd = default(OleDbDataReader);
        DataTable dt = new DataTable();
        public static string section;
        public ClassList()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            get_secA();
            get_secB();
            get_secC();
            get_secD();
        }

        public void get_secA()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_ID1.Text + "'", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows)
            {

                if (rd.Read())
                {
                    btn_secA.Text = rd.GetValue(1).ToString();
                }
            }
        }
        public void get_secB()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_ID2.Text + "'", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows)
            {

                if (rd.Read())
                {
                    btn_secB.Text = rd.GetValue(1).ToString();
                }
            }
        }
        public void get_secC()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_ID3.Text + "'", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows)
            {

                if (rd.Read())
                {
                    btn_secC.Text = rd.GetValue(1).ToString();
                }
            }
        }
        public void get_secD()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            sql = new OleDbCommand("Select * From tbl_all_section where ID like'" + lbl_ID4.Text + "'", cn);
            rd = sql.ExecuteReader();
            if (rd.HasRows)
            {

                if (rd.Read())
                {
                    btn_secD.Text = rd.GetValue(1).ToString();
                }
            }
        }

        private void btn_secA_Click(object sender, EventArgs e)
        {
            SectionForm m = new SectionForm();
            m.lbl_section_ID.Text = lbl_ID1.Text;
            m.Show();
            this.Hide();
            
        }

        private void btn_secB_Click(object sender, EventArgs e)
        {
            SectionForm m = new SectionForm();
            m.lbl_section_ID.Text = lbl_ID2.Text;
            m.Show();
            this.Hide();
        }

        private void btn_secC_Click(object sender, EventArgs e)
        {
            SectionForm m = new SectionForm();
            m.lbl_section_ID.Text = lbl_ID3.Text;
            m.Show();
            this.Hide();
        }

        private void btn_secD_Click(object sender, EventArgs e)
        {
            SectionForm m = new SectionForm();
            m.lbl_section_ID.Text = lbl_ID4.Text;
            m.Show();
            this.Hide();
        }

        
    }
}
