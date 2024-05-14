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

    public event EventHandler OnEmployeeCreatedOrUpdated = null!;

    private void OnEmployeeCreatedOrUpdatedHandler(object sender, EventArgs e)
    {
        if (OnEmployeeCreatedOrUpdated != null)
            OnEmployeeCreatedOrUpdated(this, e);
    }

    private void btnUserCancel_Click(object sender, EventArgs e)
    {
        this.Close();
        this.OnEmployeeCreatedOrUpdatedHandler(sender, e);
    }

    private void btnUserAccept_Click(object sender, EventArgs e)
    {
        var id = this.txtEmployeeId.Text;
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

        if (id is null || id == string.Empty)
        {
            employee = employee with { Id = 0 };
        }
        else
        {
            Int32.TryParse(this.txtEmployeeId.Text, out var existentId);
            employee = employee with { Id = existentId };
        }

        this.CreateEmployee(employee);
    }

    private void UserDetails_Load(object sender, EventArgs e)
    {
        this.comboEmployeeIsMarried.DataSource = new List<string>() { "SI", "NO" };
    }

    private async void CreateEmployee(EmployeeDto employee)
    {
        if (employee.Id == 0)
        {
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
        else
        {
            try
            {
                await this.employeeService.UpdateEmployeeAsync(employee);
                MessageBox.Show("Empleado actualizado con exito");
            }
            catch (Exception ex)
            {
                // Catch any exception that has bubbled up.
                MessageBox.Show($"{ex.Message}", "Ha ocurrido un error", MessageBoxButtons.OK);
            }
        }

        this.ClearEmployeeInputs();
    }

    private void ClearEmployeeInputs()
    {
        this.txtEmployeeFullName.Clear();
        this.txtEmployeeDNI.Clear();
        this.comboEmployeeIsMarried.ResetText();
        this.txtEmployeeSalary.Clear();
        this.txtEmployeeAge.Clear();
    }
}
