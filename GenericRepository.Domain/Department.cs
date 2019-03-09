using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Domain
{
    public class Department : BaseEntity
    {
        public Department()
        {
            Personels = new List<Personel>(); // Personels tanımlanmadığı için alt kısımda null hatası verecektir. Hata vermemesi için constractr class tanımlıyoruz.
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Personel> Personels { get; set; }
    }
}
