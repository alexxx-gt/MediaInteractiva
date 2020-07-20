using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using SharedModels.DTOs;

namespace BLL.Infrastructure.Extensions
{
    public static class AnimalExtensions
    {
        public static AnimalDto MapToDto(this Animal model)
        {
            var result = new AnimalDto();

            result.Id = model.Id;
            result.Name = model.Name;
            result.Type = model.Type;
            result.OwnerId = model.OwnerId;

            return result;
        }
    }
}
