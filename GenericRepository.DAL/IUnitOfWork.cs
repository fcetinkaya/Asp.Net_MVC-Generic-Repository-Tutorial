using GenericRepository.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL
{
    public interface IUnitOfWork:IDisposable
    {
         IDepartmentRepository DepartmentRepository { get;  }
         IPersonelRepository PersonelRepository { get; }

        int Complete();


    }
}
