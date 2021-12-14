namespace ReCITE
{
    partial class GameMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.btn_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_defuse = new System.Windows.Forms.Button();
            this.btn_odd_even = new System.Windows.Forms.Button();
            this.btn_pick_name = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_leaderboard = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_end = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_secID = new System.Windows.Forms.Label();
            this.btn_refresh_lv = new System.Windows.Forms.Button();
            this.lbl_section = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_student = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_stop = new System.Windows.Forms.Button();
            this.uC_OddEven1 = new ReCITE.UC_OddEven();
            this.uC_Defuse1 = new ReCITE.UC_Defuse();
            this.uC_LottoName1 = new ReCITE.UC_LottoName();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(189, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(71, 33);
            this.btn_back.TabIndex = 1;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btn_defuse
            // 
            this.btn_defuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.btn_defuse.FlatAppearance.BorderSize = 0;
            this.btn_defuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_defuse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defuse.ForeColor = System.Drawing.Color.White;
            this.btn_defuse.Location = new System.Drawing.Point(0, 566);
            this.btn_defuse.Name = "btn_defuse";
            this.btn_defuse.Size = new System.Drawing.Size(272, 25);
            this.btn_defuse.TabIndex = 81;
            this.btn_defuse.Text = "DEFUSE THE BOMB";
            this.btn_defuse.UseVisualStyleBackColor = false;
            this.btn_defuse.Click += new System.EventHandler(this.btn_defuse_Click);
            // 
            // btn_odd_even
            // 
            this.btn_odd_even.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(135)))), ((int)(((byte)(67)))));
            this.btn_odd_even.FlatAppearance.BorderSize = 0;
            this.btn_odd_even.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_odd_even.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odd_even.ForeColor = System.Drawing.Color.White;
            this.btn_odd_even.Location = new System.Drawing.Point(0, 542);
            this.btn_odd_even.Name = "btn_odd_even";
            this.btn_odd_even.Size = new System.Drawing.Size(272, 25);
            this.btn_odd_even.TabIndex = 80;
            this.btn_odd_even.Text = "ODD OR EVEN";
            this.btn_odd_even.UseVisualStyleBackColor = false;
            this.btn_odd_even.Click += new System.EventHandler(this.btn_odd_even_Click);
            // 
            // btn_pick_name
            // 
            this.btn_pick_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152)))));
            this.btn_pick_name.FlatAppearance.BorderSize = 0;
            this.btn_pick_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pick_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pick_name.ForeColor = System.Drawing.Color.White;
            this.btn_pick_name.Location = new System.Drawing.Point(0, 518);
            this.btn_pick_name.Name = "btn_pick_name";
            this.btn_pick_name.Size = new System.Drawing.Size(272, 25);
            this.btn_pick_name.TabIndex = 79;
            this.btn_pick_name.Text = "LOTTO NAME";
            this.btn_pick_name.UseVisualStyleBackColor = false;
            this.btn_pick_name.Click += new System.EventHandler(this.btn_pick_name_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lv_leaderboard);
            this.panel1.Controls.Add(this.btn_end);
            this.panel1.Controls.Add(this.btn_pick_name);
            this.panel1.Controls.Add(this.btn_defuse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_odd_even);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_secID);
            this.panel1.Location = new System.Drawing.Point(977, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 650);
            this.panel1.TabIndex = 82;
            // 
            // lv_leaderboard
            // 
            this.lv_leaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(228)))));
            this.lv_leaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_leaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_leaderboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_leaderboard.ForeColor = System.Drawing.Color.Black;
            this.lv_leaderboard.FullRowSelect = true;
            this.lv_leaderboard.GridLines = true;
            this.lv_leaderboard.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_leaderboard.Location = new System.Drawing.Point(15, 108);
            this.lv_leaderboard.Name = "lv_leaderboard";
            this.lv_leaderboard.Size = new System.Drawing.Size(245, 299);
            this.lv_leaderboard.TabIndex = 90;
            this.lv_leaderboard.UseCompatibleStateImageBehavior = false;
            this.lv_leaderboard.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Score";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_end.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_end.BackgroundImage")));
            this.btn_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_end.FlatAppearance.BorderSize = 0;
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.ForeColor = System.Drawing.Color.White;
            this.btn_end.Location = new System.Drawing.Point(105, 592);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(60, 58);
            this.btn_end.TabIndex = 89;
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 83;
            this.label1.Text = "Today\'s\r\nLeaderboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_secID
            // 
            this.lbl_secID.AutoSize = true;
            this.lbl_secID.Location = new System.Drawing.Point(53, 136);
            this.lbl_secID.Name = "lbl_secID";
            this.lbl_secID.Size = new System.Drawing.Size(35, 13);
            this.lbl_secID.TabIndex = 90;
            this.lbl_secID.Text = "label2";
            // 
            // btn_refresh_lv
            // 
            this.btn_refresh_lv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_refresh_lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refresh_lv.BackgroundImage")));
            this.btn_refresh_lv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refresh_lv.FlatAppearance.BorderSize = 0;
            this.btn_refresh_lv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh_lv.Location = new System.Drawing.Point(993, 60);
            this.btn_refresh_lv.Name = "btn_refresh_lv";
            this.btn_refresh_lv.Size = new System.Drawing.Size(32, 33);
            this.btn_refresh_lv.TabIndex = 91;
            this.btn_refresh_lv.UseVisualStyleBackColor = false;
            this.btn_refresh_lv.Click += new System.EventHandler(this.btn_refresh_lv_Click);
            // 
            // lbl_section
            // 
            this.lbl_section.AutoSize = true;
            this.lbl_section.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_section.Location = new System.Drawing.Point(21, 26);
            this.lbl_section.Name = "lbl_section";
            this.lbl_section.Size = new System.Drawing.Size(197, 56);
            this.lbl_section.TabIndex = 92;
            this.lbl_section.Text = "Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 32);
            this.label3.TabIndex = 93;
            this.label3.Text = "Today\'s Leaderboard";
            // 
            // lv_student
            // 
            this.lv_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(228)))));
            this.lv_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_student.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_student.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_student.ForeColor = System.Drawing.Color.Black;
            this.lv_student.FullRowSelect = true;
            this.lv_student.GridLines = true;
            this.lv_student.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_student.Location = new System.Drawing.Point(31, 157);
            this.lv_student.Name = "lv_student";
            this.lv_student.Size = new System.Drawing.Size(917, 455);
            this.lv_student.TabIndex = 94;
            this.lv_student.UseCompatibleStateImageBehavior = false;
            this.lv_student.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 458;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Added Score";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 458;
            // 
            // btn_stop
            // 
            this.btn_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_stop.BackgroundImage")));
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Location = new System.Drawing.Point(802, 46);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(146, 44);
            this.btn_stop.TabIndex = 95;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // uC_OddEven1
            // 
            this.uC_OddEven1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(136)))), ((int)(((byte)(87)))));
            this.uC_OddEven1.Location = new System.Drawing.Point(0, 0);
            this.uC_OddEven1.Name = "uC_OddEven1";
            this.uC_OddEven1.Size = new System.Drawing.Size(977, 650);
            this.uC_OddEven1.TabIndex = 92;
            // 
            // uC_Defuse1
            // 
            this.uC_Defuse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(61)))));
            this.uC_Defuse1.Location = new System.Drawing.Point(0, 0);
            this.uC_Defuse1.Name = "uC_Defuse1";
            this.uC_Defuse1.Size = new System.Drawing.Size(977, 650);
            this.uC_Defuse1.TabIndex = 93;
            // 
            // uC_LottoName1
            // 
            this.uC_LottoName1.BackColor = System.Drawing.Color.White;
            this.uC_LottoName1.Location = new System.Drawing.Point(0, 0);
            this.uC_LottoName1.Name = "uC_LottoName1";
            this.uC_LottoName1.Size = new System.Drawing.Size(977, 650);
            this.uC_LottoName1.TabIndex = 83;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.uC_LottoName1);
            this.Controls.Add(this.uC_Defuse1);
            this.Controls.Add(this.uC_OddEven1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.lv_student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_section);
            this.Controls.Add(this.btn_refresh_lv);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.GameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_defuse;
        private System.Windows.Forms.Button btn_odd_even;
        private System.Windows.Forms.Button btn_pick_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_end;
        public System.Windows.Forms.Label lbl_secID;
        private UC_LottoName uC_LottoName1;
        public System.Windows.Forms.ListView lv_leaderboard;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_refresh_lv;
        private UC_OddEven uC_OddEven1;
        private UC_Defuse uC_Defuse1;
        private System.Windows.Forms.Label lbl_section;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView lv_student;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_stop;
    }
}