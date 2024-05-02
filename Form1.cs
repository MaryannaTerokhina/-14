using System.Text.RegularExpressions;

namespace Практична_список_студентів
{
    public partial class Form1 : Form
    {
        record Student
        {
            public string name { get; set; }
            public string group { get; set; }
            public string prestnt { get; set; } = "Присутній";

            public Student(string name, string group, string prestnt = "Присутній")
            {
                this.name = name;
                this.group = group; 
                this.prestnt = prestnt; 
            }
         }
        List<Student> students = new List<Student>() ;



public Form1()
        {
            InitializeComponent();
            students.Add(new Student("Дмитро Онофрійчук", "31КН"));
            students.Add(new Student("Марина Погрибняк", "32КН"));
            students.Add(new Student("Анастасія Дуб", "31КН"));
            students.Add(new Student("Володимир Великий", "32КН"));
            students.Add(new Student("Віталіна Тигролова", "31КН"));
            students.Add(new Student("Назар Волошко", "32КН"));
            render();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                students[listView1.SelectedIndices[0]].prestnt = 
                   students[listView1.SelectedIndices[0]].prestnt.Equals("Присутній") ? "Відсутній" : "Присутній";

                render();
            }
            else {
                MessageBox.Show("Choose a student!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            render();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void render()
        {
            listView1.Items.Clear();
            students.Where(s => s.name.ToLower().Contains(textBox1.Text.ToLower())).ToList().ForEach(student =>
            {
                listView1.Items.Add(new ListViewItem(new string[] { student.name, student.group,  student.prestnt}));
            });

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}