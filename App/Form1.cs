using App.Domain;
using App.Persistence;

namespace TPFinalHaasEric
{
    public partial class Form1 : Form
    {
        public readonly IEnumerable<Employee> employees;
        public readonly AppDbContext dbContext;

        public Form1(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            employees = this.dbContext.Employees.ToList();

            InitializeComponent();

            dataGridView1.DataSource = employees;
        }
    }
}
