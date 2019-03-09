using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository.DAL.Repositories.Abstract;
using GenericRepository.DAL.Repositories.Conrete;

namespace GenericRepository.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private UOWContext _UOWContext;
        public UnitOfWork(UOWContext context)
        {
            _UOWContext = context;
            DepartmentRepository = new DepartmentRepository(_UOWContext);
            PersonelRepository = new PersonelRepository(_UOWContext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }
        public IPersonelRepository PersonelRepository { get; private set; }
        public int Complete()
        {
            var sayi = _UOWContext.SaveChanges();
            return sayi;
        }
        public void Dispose()
        {
            _UOWContext.Dispose();
        }
    }
}
