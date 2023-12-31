﻿using AutoMapper;
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

    public class AccountTypeBus
    {
        private IMapper mapper;
        private AccountTypesServices accountTypesServices;

        public AccountTypeBus(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public AccountType addNewAccountType(AccountTypeDTO accountTypeDTO)
        {
            accountTypesServices = new AccountTypesServices();
            AccountType accountType = mapper.Map<AccountType>(accountTypeDTO);

            accountTypesServices.Create(accountType);
            return accountType;
        }

    }


}
