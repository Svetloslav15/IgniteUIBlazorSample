using IgniteUIGridSample.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace IgniteUIGridSample.Northwind
{
    public class DataSourceService: IDataSourceService
    {
        private readonly HttpClient _http;

        public DataSourceService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<Employee>?> GetEmployees()
        {
            return await this._http.GetFromJsonAsync<List<Employee>>("/static-data/northwind-employees.json");
        }

        public async Task<List<Country>?> GetCountries()
        {
            return await this._http.GetFromJsonAsync<List<Country>>("/static-data/countries.json");
        }

        public async Task<List<State>?> GetStates()
        {
            return await this._http.GetFromJsonAsync<List<State>>("/static-data/states-with-cities.json");
        }
    }
}