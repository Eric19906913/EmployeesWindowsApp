using TPFinalHaasEric.Services;

namespace TPFinalHaasEric.Forms;

public partial class UserDetails : Form
{
    private readonly IEmployeeService employeeService;

    public UserDetails(
        IEmployeeService employeeService)
    {
        this.employeeService = employeeService;
        InitializeComponent();
    }

    private void btnUserCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async void btnUserAccept_Click(object sender, EventArgs e)
    {
        var fullName = this.txtEmployeeFullName.Text.Trim();
        var dni = this.txtEmployeeDNI.Text.Trim();
        var casado = this.comboEmployeeIsMarried.Text.Trim();
        Decimal.TryParse(this.txtEmployeeSalary.Text, out var salary);
        Int32.TryParse(this.txtEmployeeAge.Text, out var age);

        var employee = new EmployeeDto()
        {
            FullName = fullName,
            Age = age,
            DNI = dni,
            IsMarried = casado == "SI",
            Salary = salary
        };

        try
        {
            await this.employeeService.CreateEmployeeAsync(employee);
            MessageBox.Show("Empleado creado con exito");

        }
        catch (Exception ex)
        {
            // Catch any exception that has bubbled up.
            MessageBox.Show($"{ex.Message}", "Ha ocurrido un error", MessageBoxButtons.OK);
        }
    }

    private void UserDetails_Load(object sender, EventArgs e)
    {
        this.comboEmployeeIsMarried.DataSource = new List<string>() { "SI", "NO" };
    }
}
