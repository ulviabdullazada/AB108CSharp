using WinFormJson.Models;
using WinFormJson.Services;

namespace WinFormJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Name", "Ad");
            dataGridView1.Columns.Add("Surname", "Soyad");
            getDatas();
        }
        private void getDatas()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in StudentService.GetAll())
            {
                dataGridView1.Rows.Add(item.Name, item.Surname);
            }
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            Student std = new Student
            {
                Name = Name.Text,
                Surname = Surname.Text,
            };
            StudentService.Add(std);
            getDatas();
            Name.Text = string.Empty;
            Surname.Text = string.Empty;
        }
    }
}
