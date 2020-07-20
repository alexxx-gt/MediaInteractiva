using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Infrastructure.Extensions;
using BLL.Infrastructure.Interfaces;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using SharedModels.DTOs;

namespace BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationContext _context;
        public EmployeeService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<EmployeeDto>  Get(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(a => a.Id == id);

            return employee.MapToDto();
        }

        public async Task<List<EmployeeDto>> GetList()
        {
            var employees = await _context.Employees.ToListAsync();

            return employees.Select(a => a.MapToDto()).ToList();
        }

        public async Task<EmployeeDto> Create(EmployeeDto dto)
        {

            var employee = new Employee
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IsMIEmployee = dto.IsMIEmployee
            };

            var addedEmployee = _context.Employees.Add(employee).Entity;
            await _context.SaveChangesAsync();

            return addedEmployee.MapToDto();
        }

        public async Task<EmployeeDto> Update(EmployeeDto dto, int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(a => a.Id == id);

            if (employee != null)
            {
                employee.FirstName = dto.FirstName;
                employee.LastName = dto.LastName;
                employee.IsMIEmployee = dto.IsMIEmployee;

                var updatedEmployee = _context.Employees.Update(employee).Entity;
                await _context.SaveChangesAsync();

                return updatedEmployee.MapToDto();
            }
            else
            {
                throw new Exception($"Animal with id {id} was not found");
            }
        }

        public async Task<EmployeeDto> Delete(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(a => a.Id == id);

            if (employee != null)
            {
                var deletedEmployee = _context.Employees.Remove(employee).Entity;
                await _context.SaveChangesAsync();

                return deletedEmployee.MapToDto();
            }
            else
            {
                throw new Exception($"Animal with id {id} was not found");
            }
        }
    }
}
