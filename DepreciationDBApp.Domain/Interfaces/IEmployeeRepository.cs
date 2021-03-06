using DepreciationDBApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Domain.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee FindByDni(string dni);
        Employee FindByEmail(string email);
        IEnumerable<Employee> FindByLastnames(string lastnames);
        IDbContextTransaction GetTransaction(); //devolver todas las instrucciones en un solo paquete xd
    }
}
