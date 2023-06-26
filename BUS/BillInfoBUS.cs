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

        public BillInfoDTO getByBillIdAndFoodId(string billId, string foodId)
        {
            billInfoServices = new BillInfoServices();
            var billInfo = billInfoServices.GetAll().Include(p => p.Food)
                .Where(p => p.BillId.Equals(billId) && p.FoodId.Equals(foodId)).FirstOrDefault();
            var billInfoDTO = mapper.Map<BillInfoDTO>(billInfo);
            return billInfoDTO;
        }

        public BillInfo create(BillInfoDTO billInfoDTO)
        {
            billInfoServices = new BillInfoServices();
            var billInfo = mapper.Map<BillInfo>(billInfoDTO);
            billInfoServices.Create(billInfo);
            return billInfo;
        }

        public BillInfo update(BillInfoDTO billInfoDTO)
        {
            billInfoServices = new BillInfoServices();
            var billInfo = mapper.Map<BillInfo>(billInfoDTO);
            billInfoServices.Update(billInfo);
            return billInfo;
        }

        public BillInfoDTO getById(string id)
        {
            billInfoServices = new BillInfoServices();
            var billInfo = billInfoServices.GetAll().Where(p => p.Id.Equals(id)).FirstOrDefault();
            var billInfoDTO = mapper.Map<BillInfoDTO>(billInfo);
            return billInfoDTO;

        }

        public int totalPrice(string billId)
        {
            var billInfos = getAllByBillId(billId);
            int totalPrice = 0;
            foreach(var billInfo in billInfos)
            {
                totalPrice += (billInfo.Food.Price * billInfo.Amount);   
            }

            if(totalPrice <= 0) {
                throw new Exception("Lỗi tính toán");
            }

            return totalPrice;
        }
    }
}
