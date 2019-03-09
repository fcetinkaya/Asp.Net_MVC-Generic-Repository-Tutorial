using GenericRepository.DAL.Repositories.Abstract;
using GenericRepository.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL.Repositories.Conrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(UOWContext context) : base(context)
        {

        }

        public IEnumerable<Personel> GetPersonelsWithDepartments()
        {
            return UOWContext.Personels.Include("Department").ToList();
        }

        public UOWContext UOWContext { get { return _context as UOWContext; } }
    }
}
