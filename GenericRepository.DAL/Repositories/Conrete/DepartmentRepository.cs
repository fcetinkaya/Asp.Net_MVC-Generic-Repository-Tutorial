using GenericRepository.DAL.Repositories.Abstract;
using GenericRepository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Repositories.Conrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(UOWContext context):base(context)
        {
           
        }
        public IEnumerable<Department> GetDepartments(int count)
        {
            return uwoContext.Departments.Take(count).ToList();
        }

        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
           
 return uwoContext.Departments.Include("Personels").ToList();
        }
        public UOWContext uwoContext { get { return _context as UOWContext; } }
    }
}
