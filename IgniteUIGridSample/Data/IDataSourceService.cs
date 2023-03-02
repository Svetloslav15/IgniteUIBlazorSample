using IgniteUIGridSample.Models;

namespace IgniteUIGridSample.Northwind
{
    public interface IDataSourceService
    {
        Task<List<Employee>?> GetEmployees();

        Task<List<Country>?> GetCountries();
    }
}