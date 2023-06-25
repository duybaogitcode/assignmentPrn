using AutoMapper;
using DAO.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TableCoffeeBUS
    {
        private IMapper mapper;
        private TableCoffeeServices tableCoffeeServices;

        public TableCoffeeBUS(IMapper _mapper)
        {
            this.mapper = _mapper;
        }

        public List<TableCoffeeDTO> getAll()
        {
            tableCoffeeServices = new TableCoffeeServices();
            var tableCoffees = tableCoffeeServices.GetAll().ToList();
            var tableCoffeeDTOs = mapper.Map<List<TableCoffeeDTO>>(tableCoffees);
            return tableCoffeeDTOs;
        }
    }
}
