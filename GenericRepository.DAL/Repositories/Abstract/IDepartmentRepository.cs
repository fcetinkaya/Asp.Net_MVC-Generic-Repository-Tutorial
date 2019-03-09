using GenericRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepository.DAL.Repositories.Abstract
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetDepartments(int count);
        IEnumerable<Department> GetDepartmentsWithPersonels();
    }
}
