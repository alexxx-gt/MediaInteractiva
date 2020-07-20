using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using SharedModels.DTOs;

namespace BLL.Infrastructure.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> Get(int id);
        Task<List<EmployeeDto>> GetList();
        Task<EmployeeDto> Create(EmployeeDto dto);
        Task<EmployeeDto> Update(EmployeeDto dto, int id);
        Task<EmployeeDto> Delete(int id);
    }
}
