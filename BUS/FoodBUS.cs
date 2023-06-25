using AutoMapper;
using DAO.Models;
using DAO.Services;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FoodBUS
    {
        Food food;
        FoodDTO foodDTO;
        FoodServices foodServices;
        IMapper mapper;
        public FoodBUS(IMapper _mapper)
        {
            this.mapper = _mapper;
        }

        public Food create(FoodDTO FoodDTO)
        {
            food = mapper.Map<Food>(FoodDTO);
            foodServices = new FoodServices();
            foodServices.Create(food);
            return food;
        }

        public List<FoodDTO> getAll()
        {
            foodServices = new FoodServices();
            var foods = foodServices.GetAll().Include(p => p.Category).ToList();
            var foodDTOs = mapper.Map<List<FoodDTO>>(foods);
            return foodDTOs;
        }

        public FoodDTO getFood(string id)
        {
            foodServices = new FoodServices();
            var food = foodServices.GetAll().Where(p => p.Id.Equals(id)).FirstOrDefault();
            var foodDTO = mapper.Map<FoodDTO>(food);
            return foodDTO;
        }

        public Food update(FoodDTO foodDTO)
        {
            food = mapper.Map<Food>(foodDTO);
            foodServices = new FoodServices();
            foodServices.Update(food);
            return food;
        }
    }
}
