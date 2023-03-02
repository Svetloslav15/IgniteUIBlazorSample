namespace IgniteUIGridSample.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>?> GetEmployees();
    }
}