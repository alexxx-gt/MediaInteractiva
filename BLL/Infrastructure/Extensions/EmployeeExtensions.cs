using DAL.Models;
using SharedModels.DTOs;

namespace BLL.Infrastructure.Extensions
{
    public static class EmployeeExtensions
    {
        public static EmployeeDto MapToDto(this Employee model)
        {
            var result = new EmployeeDto();

            result.FirstName = model.FirstName;
            result.LastName = model.LastName;
            result.Id = model.Id;
            result.IsMIEmployee = model.IsMIEmployee;

            return result;
        }
    }
}
