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
    public class BillBUS
    {
        private IMapper mapper;
        private BillServices billServices;
        private BillInfoServices billInfoServices;
        public BillBUS(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<BillDTO> getAll()
        {
            billServices = new BillServices();
            var bills = billServices.GetAll().ToList();
            var billDTOs = mapper.Map<List<BillDTO>>(bills);
            return billDTOs;
        }

        public Bill create(BillDTO billDTO, BillInfoDTO billInfoDTO)
        {
            using (var context = new CoffeeManagementContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        billServices = new BillServices();
                        billInfoServices = new BillInfoServices();

                        var bill = mapper.Map<Bill>(billDTO);
                        billServices.Create(bill);

                        var billInfo = mapper.Map<BillInfo>(billInfoDTO);
                        billInfo.BillId = bill.Id;
                        billInfoServices.Create(billInfo);

                        transaction.Commit();

                        return bill;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }
    }
}
