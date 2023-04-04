using ProjectRoom.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRoom
{
    public partial class Admin : Form
    {
        public static Admin Instance;
        public List<Students> students = new List<Students>();
        public string Username = "Admin";
        public string Password = "1234";
        public Admin()
        {
            InitializeComponent();
            Instance = this;
        }
        public DataGridView getDatagrid()
        {
            return this.dataGridView1;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "Students";
            openfile.Filter = "CSV|*.csv";
            openfile.ShowDialog();
            if (openfile.FileName != "")
            {
                students.Clear();
                dataGridView1.Rows.Clear();
                using (StreamReader file = new StreamReader(openfile.FileName))
                {
                    string line;
                    int count = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        students.Add(new Students(new Person(data[0], data[1], data[2], data[3], data[4]), data[5]));
                    }
                }
                foreach (Students student in students)
                {
                    dataGridView1.Rows.Add(student.getPerson().getName(), student.getPerson().getLastName(), student.getPerson().getID(), student.getPerson().getMajor(), student.getPerson().getLevel(), student.getDatein());
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Students";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {
                using (StreamWriter file = new StreamWriter(saveFile.FileName))
                {
                    foreach (Students i in students)
                    {
                        file.WriteLine($"" +
                            $"{i.getPerson().getName()}," +
                            $"{i.getPerson().getLastName()}," +
                            $"{i.getPerson().getID()}," +
                            $"{i.getPerson().getMajor()}," +
                            $"{i.getPerson().getLevel()}," +
                            $"{i.getDatein()},");
                    }
                }
            }
        }
    }
}
