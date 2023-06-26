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

        public TableCoffee updateStatus(TableCoffeeDTO tableCoffeeDTO)
        {
            tableCoffeeServices = new TableCoffeeServices();
            var tableCoffee = mapper.Map<TableCoffee>(tableCoffeeDTO);
            tableCoffeeServices.Update(tableCoffee);
            return tableCoffee;
        }

        public TableCoffeeDTO getTable(string id) {
            tableCoffeeServices = new TableCoffeeServices();
            var tableCoffee = tableCoffeeServices.GetAll().Where(p=>p.Id.Equals(id)).FirstOrDefault();
            TableCoffeeDTO tableCoffeeDTO = mapper.Map<TableCoffeeDTO>(tableCoffee);
            return tableCoffeeDTO;
        }
    }
}
