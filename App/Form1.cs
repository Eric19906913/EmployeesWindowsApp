using TPFinalHaasEric.Services;

namespace TPFinalHaasEric;

public partial class EmployeeView : Form
{
    private readonly IEmployeeService employeeService;

    public EmployeeView(IEmployeeService employeeService)
    {
        this.employeeService = employeeService;

        InitializeComponent();
        this.ConfigureDataGrid();
    }

    /// <summary>
    /// REMARKS: This is VERY BAD practice but I wanted to all my code works with async/await.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The events.</param>
    private async void EmployeeView_Load(object sender, EventArgs e)
    {
        var employees = await this.employeeService.GetAllEmployeesAsync();

        this.dataGridView1.DataSource = employees;
    }

    private void btnDeleteEmployee_Click(object sender, EventArgs e)
    {
        var employee = this.dataGridView1.SelectedRows[0].DataBoundItem as EmployeeDto;

        if (employee is null)
        {
            return;
        }

        var result = MessageBox.Show(
            $"Esta seguro que desea eliminar el empleado {employee?.FullName}?.",
            "Eliminar empleado",
            MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            this.employeeService.DeleteEmployee(employee!.Id);
            this.dataGridView1.Refresh();

            MessageBox.Show("Empleado borrado exitosamente.");
        }
        else
        {
            MessageBox.Show("no borras al loquito.");
        }
    }

    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        this.btnDeleteEmployee.Enabled = true;
    }

    private void ConfigureDataGrid()
    {
        this.dataGridView1.ShowEditingIcon = false;
    }

    
}
