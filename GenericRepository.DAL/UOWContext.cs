using GenericRepository.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.DAL
{
    public class UOWContext:DbContext
    {
        public UOWContext():base("UOWContext") // Connection bağlantısını tanımlıyoruz..
        {

        }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
