﻿using AutoMapper;
using DAO.Models;
using DAO.Services;
using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        private TableCoffeeServices tableCoffeeServices;
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

        public BillDTO getBillDTO(string tableId)
        {
            billServices = new BillServices();
            var bill = billServices.GetAll().Where(p => p.TableId.Equals(tableId) && p.CheckOut == null).FirstOrDefault();
            var billDTO = mapper.Map<BillDTO>(bill);
            return billDTO;
        }

        public BillDTO getById(string Id)
        {
            billServices = new BillServices();
            var bill = billServices.GetAll().Where(p => p.Id.Equals(Id)).FirstOrDefault();
            var billDTO = mapper.Map<BillDTO>(bill);
            return billDTO;
        }
    

        public void create(BillDTO billDTO, BillInfoDTO billInfoDTO, TableCoffeeDTO tableCoffeeDTO)
        {
            using (var context = new CoffeeManagementContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        billServices = new BillServices();
                        billInfoServices = new BillInfoServices();
                        tableCoffeeServices = new TableCoffeeServices();

                        var tableCoffee = mapper.Map<TableCoffee>(tableCoffeeDTO);

                        var bill = mapper.Map<Bill>(billDTO);

                        var billInfo = mapper.Map<BillInfo>(billInfoDTO);
                        billInfo.BillId = bill.Id;


                        tableCoffeeServices.Update(tableCoffee);


                        billInfoServices.Delete(billInfo);

                        billServices.Delete(bill);


                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void update(BillDTO billDTO, TableCoffeeDTO tableCoffeeDTO)
        {
            using (var context = new CoffeeManagementContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        billServices = new BillServices();
                        tableCoffeeServices = new TableCoffeeServices();

                        var tableCoffee = mapper.Map<TableCoffee>(tableCoffeeDTO);
                        tableCoffeeServices.Update(tableCoffee);

                        var bill = mapper.Map<Bill>(billDTO);
                        billServices.Update(bill);


                        transaction.Commit();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public void delete(BillDTO billDTO, TableCoffeeDTO tableCoffeeDTO)
        {
            using (var context = new CoffeeManagementContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        billServices = new BillServices();
                        tableCoffeeServices = new TableCoffeeServices();
                        billInfoServices = new BillInfoServices();

                        var tableCoffee = mapper.Map<TableCoffee>(tableCoffeeDTO);
                        tableCoffeeServices.Update(tableCoffee);


                        var bill = mapper.Map<Bill>(billDTO);
                        billServices.Delete(bill);


                        transaction.Commit();

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
