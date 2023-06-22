using AutoMapper;
using DAO.Models;
using DAO.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CategoryFoodBUS
    {
        CategoryFood categoryFood;
        CategoryFoodDTO categoryFoodDTO;
        CategoryFoodServices categoryFoodServices;
        IMapper mapper;
        public CategoryFoodBUS(IMapper _mapper) {
            this.mapper = _mapper;
        }

        public CategoryFood create(CategoryFoodDTO categoryFoodDTO)
        {
            categoryFood = mapper.Map<CategoryFood>(categoryFoodDTO);
            categoryFoodServices = new CategoryFoodServices();
            categoryFoodServices.Create(categoryFood);
            return categoryFood;
        }
    }
}
