using ProjectRoom.Class;

namespace ProjectRoom
{
    public partial class Home : Form
    {
        public static Admin? _Admin;
        public Home()
        {
            InitializeComponent();
            _Admin = new Admin();
            _Admin.Load += onload;
        }

        private void onload(object? sender, EventArgs e)
        {
            if(_Admin.students.Count > 0)
            {
                _Admin.getDatagrid().Rows.Clear();
                foreach(Students student in _Admin.students)
                {
                    _Admin.getDatagrid().Rows.Add(student.getPerson().getName(), student.getPerson().getLastName(), student.getPerson().getID(), student.getPerson().getMajor(), student.getPerson().getLevel(), student.getDatein());
                }
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string Name = tb_name.Text;
            string Lastname = tb_lastname.Text;
            string Id = tb_id.Text;
            string Major = tb_major.Text;
            string Level = tb_level.Text;
            _Admin.students.Add(new Students(new Person(Name, Lastname, Id, Major, Level),DateTime.Now.ToString()));
            tb_name.Clear();
            tb_lastname.Clear();
            tb_id.Clear();
            tb_major.Clear();
            tb_level.Clear();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                _Admin.ShowDialog();
            }
        }
    }
}