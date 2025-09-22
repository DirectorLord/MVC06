using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Reporsitories;

public class EmployeeRepository(CompanyDBContext dbConext)
    :BaseRepository<Employee>(dbConext) , IEmployeeRepository
{
    public IEnumerable<Employee> GetAll(string name)
    {
       return _dbSet.Where(e => e.Name == name).ToList();
    }
}
