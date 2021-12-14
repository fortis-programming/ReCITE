namespace ReCITE
{
    partial class SectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectionForm));
            this.lv_student = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_edit_section = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_section = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_section_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_student
            // 
            this.lv_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.lv_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_student.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_student.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_student.ForeColor = System.Drawing.Color.White;
            this.lv_student.FullRowSelect = true;
            this.lv_student.GridLines = true;
            this.lv_student.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_student.Location = new System.Drawing.Point(118, 159);
            this.lv_student.Name = "lv_student";
            this.lv_student.Size = new System.Drawing.Size(1011, 420);
            this.lv_student.TabIndex = 67;
            this.lv_student.UseCompatibleStateImageBehavior = false;
            this.lv_student.View = System.Windows.Forms.View.Details;
            this.lv_student.SelectedIndexChanged += new System.EventHandler(this.lv_student_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Student Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 505;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Student Score";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 505;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 43);
            this.btn_back.TabIndex = 68;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_edit_section
            // 
            this.btn_edit_section.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit_section.BackgroundImage")));
            this.btn_edit_section.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit_section.FlatAppearance.BorderSize = 0;
            this.btn_edit_section.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_section.Location = new System.Drawing.Point(366, 70);
            this.btn_edit_section.Name = "btn_edit_section";
            this.btn_edit_section.Size = new System.Drawing.Size(23, 23);
            this.btn_edit_section.TabIndex = 70;
            this.btn_edit_section.UseVisualStyleBackColor = true;
            this.btn_edit_section.Click += new System.EventHandler(this.btn_edit_section_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(1066, 104);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 49);
            this.btn_add.TabIndex = 71;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(118, 594);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(301, 31);
            this.tb_name.TabIndex = 72;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_name.Visible = false;
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Location = new System.Drawing.Point(462, 594);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(31, 31);
            this.btn_update.TabIndex = 74;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(499, 594);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(31, 31);
            this.btn_delete.TabIndex = 75;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_section
            // 
            this.tb_section.BackColor = System.Drawing.Color.White;
            this.tb_section.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_section.Enabled = false;
            this.tb_section.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_section.ForeColor = System.Drawing.Color.Black;
            this.tb_section.Location = new System.Drawing.Point(118, 74);
            this.tb_section.Name = "tb_section";
            this.tb_section.Size = new System.Drawing.Size(261, 59);
            this.tb_section.TabIndex = 76;
            this.tb_section.Text = "SectionA";
            this.tb_section.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_section.TextChanged += new System.EventHandler(this.tb_section_TextChanged);
            this.tb_section.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_section_KeyDown);
            // 
            // btn_insert
            // 
            this.btn_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insert.BackgroundImage")));
            this.btn_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Location = new System.Drawing.Point(425, 594);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(31, 31);
            this.btn_insert.TabIndex = 73;
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Visible = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(999, 585);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(130, 48);
            this.btn_start.TabIndex = 77;
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(415, 425);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(35, 13);
            this.lbl_ID.TabIndex = 78;
            this.lbl_ID.Text = "label1";
            // 
            // lbl_section_ID
            // 
            this.lbl_section_ID.AutoSize = true;
            this.lbl_section_ID.Location = new System.Drawing.Point(401, 438);
            this.lbl_section_ID.Name = "lbl_section_ID";
            this.lbl_section_ID.Size = new System.Drawing.Size(29, 13);
            this.lbl_section_ID.TabIndex = 79;
            this.lbl_section_ID.Text = "label";
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 650);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_edit_section);
            this.Controls.Add(this.tb_section);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lv_student);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_section_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionForm";
            this.Load += new System.EventHandler(this.SectionA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lv_student;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_edit_section;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.TextBox tb_section;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.Label lbl_section_ID;
    }
}