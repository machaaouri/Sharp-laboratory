﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Program
    {

        static void Init()
        {
            /*
             * For test purpose Tells Entity Framework that it is okay 
             * to drop and recreate the databse evry time this App runs 
            */
            Database.SetInitializer(new DropCreateDatabaseAlways<EmployeeDbContex>());
        }

        static void SeedDb()
        {
            Init();

            using(IRepository<Employee>  employeeRepository =
                new SqlRepository<Employee>(new EmployeeDbContex()))
            {
                AddEmployees(employeeRepository);
                AddManagers(employeeRepository); // Contravariance
                CountEmployees(employeeRepository);
                QueryById(employeeRepository);
                DumpPeople(employeeRepository); // Covariance 
            }
        }

        private static void AddManagers(IWriteOnlyRepository<Manager> employeeRepository)
        {
            employeeRepository.Add(new Manager { Name = "MCH" });
            employeeRepository.Commit();
        }

        private static void DumpPeople(IReadOnlyRepository<Person> employeeRepository)
        {
            var employees = employeeRepository.FindAll();

            foreach(var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static void QueryById(IRepository<Employee> employeeRepository)
        {
            Employee emp = employeeRepository.FindById(1);
            Console.WriteLine(emp.Name);
        }

        private static void CountEmployees(IRepository<Employee> employeeRepository)
        {
            Console.WriteLine(employeeRepository.FindAll().Count());
        }

        private static void AddEmployees(IRepository<Employee> employeeRepository)
        {
            employeeRepository.Add(new Employee { Name = "Houssame" });
            employeeRepository.Add(new Employee { Name = "Machaaouri" });
            employeeRepository.Add(new Employee { Name = "Ben" });
            employeeRepository.Commit();
        }

        static void Main(string[] args)
        {
            SeedDb();
            Console.ReadKey();
        }
    }
}
