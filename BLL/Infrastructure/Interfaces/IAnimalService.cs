using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using SharedModels.DTOs;

namespace BLL.Infrastructure.Interfaces
{
    public interface IAnimalService
    {
        Task<AnimalDto> Get(int id);
        Task<List<AnimalDto>> GetList();
        Task<AnimalDto> Create(AnimalDto dto);
        Task<AnimalDto> Update(AnimalDto dto, int id);
        Task<AnimalDto> Delete(int id);
    }
}
