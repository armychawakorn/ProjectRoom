namespace ProjectRoom
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            tb_name = new TextBox();
            tb_lastname = new TextBox();
            label3 = new Label();
            tb_id = new TextBox();
            label4 = new Label();
            tb_major = new TextBox();
            label5 = new Label();
            tb_level = new TextBox();
            label6 = new Label();
            button_submit = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 23);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 0;
            label1.Text = "ลงทะเบียนเข้าใช้งาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 73);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(101, 67);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(145, 23);
            tb_name.TabIndex = 2;
            // 
            // tb_lastname
            // 
            tb_lastname.Location = new Point(101, 96);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(145, 23);
            tb_lastname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 102);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 3;
            label3.Text = "นามสกุล";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(101, 125);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(145, 23);
            tb_id.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 131);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 5;
            label4.Text = "รหัสนักศึกษา";
            // 
            // tb_major
            // 
            tb_major.Location = new Point(101, 154);
            tb_major.Name = "tb_major";
            tb_major.Size = new Size(145, 23);
            tb_major.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 160);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 7;
            label5.Text = "สาขา";
            // 
            // tb_level
            // 
            tb_level.Location = new Point(101, 183);
            tb_level.Name = "tb_level";
            tb_level.Size = new Size(145, 23);
            tb_level.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 189);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(31, 17);
            label6.TabIndex = 9;
            label6.Text = "ชั้นปี";
            // 
            // button_submit
            // 
            button_submit.Location = new Point(123, 228);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(75, 23);
            button_submit.TabIndex = 11;
            button_submit.Text = "ตกลง";
            button_submit.UseVisualStyleBackColor = true;
            button_submit.Click += button_submit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(312, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adminToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(180, 22);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 303);
            Controls.Add(button_submit);
            Controls.Add(tb_level);
            Controls.Add(label6);
            Controls.Add(tb_major);
            Controls.Add(label5);
            Controls.Add(tb_id);
            Controls.Add(label4);
            Controls.Add(tb_lastname);
            Controls.Add(label3);
            Controls.Add(tb_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = resources.GetString("$this.Text");
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_name;
        private TextBox tb_lastname;
        private Label label3;
        private TextBox tb_id;
        private Label label4;
        private TextBox tb_major;
        private Label label5;
        private TextBox tb_level;
        private Label label6;
        private Button button_submit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
    }
}