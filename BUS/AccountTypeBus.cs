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

        AccountTypesServices accountTypesServices = new AccountTypesServices();
        AccountType accountType = new AccountType();

        public AccountType addNewAccountType(AccountTypeDTO accountTypeDTO)
        {

            accountType.Id = accountTypeDTO.Id;
            accountType.TypeName = accountTypeDTO.TypeName;

            accountTypesServices.Create(accountType);
            return accountType;
        }

    }


}
