namespace ProjectRoom
{
    partial class Admin
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
            dataGridView1 = new DataGridView();
            grid_name = new DataGridViewTextBoxColumn();
            grid_lastname = new DataGridViewTextBoxColumn();
            grid_id = new DataGridViewTextBoxColumn();
            grid_major = new DataGridViewTextBoxColumn();
            grid_level = new DataGridViewTextBoxColumn();
            grid_datein = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            backToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { grid_name, grid_lastname, grid_id, grid_major, grid_level, grid_datein });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(843, 411);
            dataGridView1.TabIndex = 0;
            // 
            // grid_name
            // 
            grid_name.HeaderText = "ชื่อ";
            grid_name.Name = "grid_name";
            grid_name.ReadOnly = true;
            grid_name.Width = 120;
            // 
            // grid_lastname
            // 
            grid_lastname.HeaderText = "นามสกุล";
            grid_lastname.Name = "grid_lastname";
            grid_lastname.ReadOnly = true;
            grid_lastname.Width = 120;
            // 
            // grid_id
            // 
            grid_id.HeaderText = "รหัสนักศึกษา";
            grid_id.Name = "grid_id";
            grid_id.ReadOnly = true;
            grid_id.Width = 120;
            // 
            // grid_major
            // 
            grid_major.HeaderText = "สาขา";
            grid_major.Name = "grid_major";
            grid_major.ReadOnly = true;
            grid_major.Width = 120;
            // 
            // grid_level
            // 
            grid_level.HeaderText = "ชั้นปี";
            grid_level.Name = "grid_level";
            grid_level.ReadOnly = true;
            grid_level.Width = 120;
            // 
            // grid_datein
            // 
            grid_datein.HeaderText = "เวลาเข้าใช้งาน";
            grid_datein.Name = "grid_datein";
            grid_datein.ReadOnly = true;
            grid_datein.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, backToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(868, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(44, 20);
            backToolStripMenuItem.Text = "Back";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private DataGridViewTextBoxColumn grid_name;
        private DataGridViewTextBoxColumn grid_lastname;
        private DataGridViewTextBoxColumn grid_id;
        private DataGridViewTextBoxColumn grid_major;
        private DataGridViewTextBoxColumn grid_level;
        private DataGridViewTextBoxColumn grid_datein;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}