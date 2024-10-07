using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNET_SimónArias.Models;

namespace PruebaNET_SimónArias.Repositories;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAll();
    Task<Employee> GetById(int id);
    Task<Employee> GetByEmail(string? email);
    Task Add(Employee employee);
    Task Update(Employee employee);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
