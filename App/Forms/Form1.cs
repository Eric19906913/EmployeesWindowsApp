using TPFinalHaasEric.Forms;
using TPFinalHaasEric.Services;

namespace TPFinalHaasEric;

public partial class EmployeeView : Form
{
    private readonly IEmployeeService employeeService;
    private readonly UserDetails userDetailsForm;

    public EmployeeView(IEmployeeService employeeService, UserDetails userDetailsForm)
    {
        this.employeeService = employeeService;
        this.userDetailsForm = userDetailsForm;

        InitializeComponent();
        this.ConfigureDataGrid();
    }

    /// <summary>
    /// REMARKS: Using async/void is VERY BAD practice but I wanted to all my code works with async/await.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The events.</param>
    private void EmployeeView_Load(object sender, EventArgs e)
    {
        this.LoadDataGridDataSource();
    }

    private void btnDeleteEmployee_Click(object sender, EventArgs e)
    {
        if (this.dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show(
                "Debe seleccionar un empleado a eliminar.",
                "Seleccion invalida",
                MessageBoxButtons.OK);

            return;
        }

        if (this.dataGridView1.SelectedRows.Count > 1)
        {
            MessageBox.Show(
                "Solo se permite eliminar un empleado a la vez.",
                "Seleccion invalida",
                MessageBoxButtons.OK);

            return;
        }

        var employee = this.dataGridView1.SelectedRows[0].DataBoundItem as EmployeeDto;

        var result = MessageBox.Show(
            $"Esta seguro que desea eliminar el empleado {employee?.FullName}?.",
            "Eliminar empleado",
            MessageBoxButtons.OKCancel);

        if (result == DialogResult.OK)
        {
            this.employeeService.DeleteEmployee(employee!.Id);

            MessageBox.Show("Empleado borrado exitosamente.");
            this.LoadDataGridDataSource();
        }
    }

    private void btnAddEmployee_Click(object sender, EventArgs e)
    {
        this.userDetailsForm.OnEmployeeCreatedOrUpdated += new EventHandler(Child_OnEmployeeCreatedOrUpdated);
        this.userDetailsForm.Show(this);
    }

    private void btnEditEmployee_Click(object sender, EventArgs e)
    {
        if (this.dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show(
                "Debe seleccionar un empleado a modificar.",
                "Seleccion invalida",
                MessageBoxButtons.OK);

            return;
        }

        if (this.dataGridView1.SelectedRows.Count > 1)
        {
            MessageBox.Show(
                "Solo se permite modificar un empleado a la vez.",
                "Seleccion invalida",
                MessageBoxButtons.OK);

            return;
        }

        var employee = this.dataGridView1.SelectedRows[0].DataBoundItem as EmployeeDto;

        if (employee is null)
        {
            MessageBox.Show(
                "Debe seleccionar un empleado.",
                "Seleccion invalida",
                MessageBoxButtons.OK);

            return;
        }

        this.LoadUserInformation(employee);
        this.userDetailsForm.OnEmployeeCreatedOrUpdated += new EventHandler(Child_OnEmployeeCreatedOrUpdated);
        this.userDetailsForm.Show(this);
    }

    private void LoadUserInformation(EmployeeDto employee)
    {
        this.userDetailsForm.txtEmployeeId.Text = employee.Id.ToString();
        this.userDetailsForm.txtEmployeeFullName.Text = employee.FullName;
        this.userDetailsForm.txtEmployeeDNI.Text = employee.DNI;
        this.userDetailsForm.comboEmployeeIsMarried.Text = employee.IsMarried ? "SI" : "NO";
        this.userDetailsForm.txtEmployeeSalary.Text = employee.Salary.ToString();
        this.userDetailsForm.txtEmployeeAge.Text = employee.Age.ToString();
    }

    private async void LoadDataGridDataSource()
    {
        this.dataGridView1.DataSource = await this.employeeService.GetAllEmployeesAsync();
    }

    private void ConfigureDataGrid()
    {
        this.dataGridView1.ShowEditingIcon = false;
    }

    public void Child_OnEmployeeCreatedOrUpdated(object sender, EventArgs e)
    {
        this.LoadDataGridDataSource();
    }
}
