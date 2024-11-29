using Assignmet_EF_D2.Models;

namespace Assignmet_EF_D2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewsContext db = new NewsContext();
            dataGridView1.DataSource= db.News.ToList();
        

    }
    }
}
