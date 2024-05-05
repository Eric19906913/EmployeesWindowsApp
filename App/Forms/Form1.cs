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
        var employee = this.dataGridView1.SelectedRows[0].DataBoundItem as EmployeeDto;

        if (employee is null)
        {
            return;
        }

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
        this.userDetailsForm.Show(this);
    }

    private void ConfigureDataGrid()
    {
        this.dataGridView1.ShowEditingIcon = false;
    }

    private async void LoadDataGridDataSource()
    {
        this.dataGridView1.DataSource = await this.employeeService.GetAllEmployeesAsync();
    }
}
