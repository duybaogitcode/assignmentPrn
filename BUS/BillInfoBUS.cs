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
    public class BillInfoBUS
    {
        private IMapper mapper;
        private BillInfoServices billInfoServices;

        public BillInfoBUS(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<BillInfoDTO> getAllByBillId(string billId)
        {
            billInfoServices = new BillInfoServices();
            var billInfo = billInfoServices.GetAll().Include(p=>p.Food)
                .Where(p=>p.BillId.Equals(billId)).ToList();
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
