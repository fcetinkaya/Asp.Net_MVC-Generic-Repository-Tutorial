using GenericRepository.DAL;
using GenericRepository.Domain;
using System;

namespace ConsoleApp1GenericRepository.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new UOWContext());
            unitOfWork.DepartmentRepository.Add(
                new Department()
                {
                    Name = "Information Technology",
                    IsActive = true,
                    CreateDate = DateTime.Now
                });
            unitOfWork.Complete();
        }
    }
}