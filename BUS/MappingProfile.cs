using AutoMapper;
using DAO.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AccountTypeDTO, AccountType>();
            CreateMap<AccountType, AccountTypeDTO>();
            CreateMap<AccountDTO, Account>();
            CreateMap<Account, AccountDTO>();
            CreateMap<BillDTO, Bill>();
            CreateMap<Bill, BillDTO>();
            CreateMap<BillInfoDTO, BillInfo>();
            CreateMap<BillInfo, BillInfoDTO>();
            CreateMap<FoodDTO, Food>();
            CreateMap<Food, FoodDTO>();
            CreateMap<CategoryFoodDTO, CategoryFood>();
            CreateMap<CategoryFood, CategoryFoodDTO>();
            CreateMap<TableCoffeeDTO, TableCoffee>();
            CreateMap<TableCoffee, TableCoffeeDTO>();
        }
    }
}
