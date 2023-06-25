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
    public class BillInfoBUS
    {
        private IMapper mapper;
        private BillInfoServices billInfoServices;

        public BillInfoBUS(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<BillInfoDTO> getAll()
        {
            billInfoServices = new BillInfoServices();
            var billInfo = billInfoServices.GetAll().ToList();
            var billInfoDTOs = mapper.Map<List<BillInfoDTO>>(billInfo);
            return billInfoDTOs;
        }

        public BillInfo create(BillInfoDTO billInfoDTO)
        {
            billInfoServices = new BillInfoServices();
            var billInfo = mapper.Map<BillInfo>(billInfoDTO);
            billInfoServices.Create(billInfo);
            return billInfo;
        }
    }
}
