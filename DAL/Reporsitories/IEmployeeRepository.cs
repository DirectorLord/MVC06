using DAL.Entities;

namespace DAL.Reporsitories;

public interface IEmployeeRepository : IRepository<Employee>
{
    IEnumerable<Employee> GetAll(string name);
}
