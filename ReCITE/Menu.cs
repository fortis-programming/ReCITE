using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ReCITE
{
    public partial class Menu : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            player.URL = "super_mario_intro.mp3";
            player2.URL = "smb_pipe.mp3";
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            player2.controls.stop();
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            player2.controls.play();

            ClassList cl = new ClassList();
            cl.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to close application?", "ReCITE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                player.controls.stop();
                Application.Exit();
            }
            // tinanggal ko yung else na walang laman
        }
    }
}
