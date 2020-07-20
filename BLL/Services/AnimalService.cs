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
    public class AnimalService : IAnimalService
    {
        private readonly ApplicationContext _context;

        public AnimalService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<AnimalDto> Get(int id)
        {
            var animal = await _context.Animals.FirstOrDefaultAsync(a => a.Id == id);

            return animal.MapToDto();
        }

        public async Task<List<AnimalDto>> GetList()
        {
            var animals = await _context.Animals.ToListAsync();

            return animals.Select(a => a.MapToDto()).ToList();
        }

        public async Task<AnimalDto> Create(AnimalDto dto)
        {
            var animal = new Animal
            {
                Name = dto.Name,
                Type = dto.Type,
                OwnerId = dto.OwnerId
            };

            var addedAnimal = _context.Animals.Add(animal).Entity;
            await _context.SaveChangesAsync();

            return addedAnimal.MapToDto();
        }

        public async Task<AnimalDto> Update(AnimalDto dto, int id)
        {
            var animal = await _context.Animals.FirstOrDefaultAsync(a => a.Id == id);

            if (animal != null)
            {
                animal.Name = dto.Name;
                animal.Type = dto.Type;
                animal.OwnerId = dto.OwnerId;

                var updatedAnimal = _context.Animals.Update(animal).Entity;
                await _context.SaveChangesAsync();

                return updatedAnimal.MapToDto();
            }
            else
            {
                throw new Exception($"Animal with id {id} was not found");
            }
        }

        public async Task<AnimalDto> Delete(int id)
        {
            var animal = await _context.Animals.FirstOrDefaultAsync(a => a.Id == id);

            if (animal != null)
            {
                var deletedAnimal = _context.Animals.Remove(animal).Entity;
                await _context.SaveChangesAsync();

                return deletedAnimal.MapToDto();
            }
            else
            {
                throw new Exception($"Animal with id {id} was not found");
            }
        }
    }
}
