using BLL.DataTransferObject.Department;
using DAL.Entities;
using DAL.Reporsitories;

namespace BLL.Services;

public class DepartmentService(IRepository<Department> repository) : IDepartmentService
{
    public int Create(DepartmentRequest request)
    {
        return repository.Add(request.ToEntity());
    }

    public DepartmentDetailResponse? GetById(int id)
    {
        
        
    }

    public IEnumerable<DepartmentDetailResponse> GetAll()
    {
        return departmentService.GetAll();
    }

    public int Update(DepartmentUpdateRequest request)
    {
        return departmentService.Update(request);
    }

    public bool Delete(int id)
    {
        var department = repository.GetById(id);
        if (department == null) return false;
        var result = repository.Delete(department);
    }

    public int Add(DepartmentRequest request)
    {
        return departmentService.Add(request);
    }
}
