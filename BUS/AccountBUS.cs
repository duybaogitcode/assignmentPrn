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

    public class AccountBUS
    {
        private IMapper mapper;

        public AccountBUS(IMapper _mapper)
        {
            this.mapper = _mapper;

        }

        public Account createAccount(AccountDTO accountDTO) {
            AccountServices accountservices = new AccountServices();
            Account account = new Account();
            account = mapper.Map<Account>(accountDTO);
            accountservices.Create(account);
            return account;
        }
        public Account updateAccount(AccountDTO accountDTO)
        {
            AccountServices accountservices = new AccountServices();
            Account account = new Account();
            account = mapper.Map<Account>(accountDTO);
            accountservices.Update(account);
            return account;
        }

        public bool deleteAccount(AccountDTO accountDTO)
        {
            AccountServices accountservices = new AccountServices();
            Account account = new Account();
            account = mapper.Map<Account>(accountDTO);
            bool isDelete =  accountservices.Delete(account);
            return isDelete;
        }

        public List<AccountDTO> GetAll()
        {
            AccountServices accountservices = new AccountServices();
            var accounts = accountservices.GetAll().Include(p=>p.Type).ToList();
            var accountDTOs = mapper.Map<List<AccountDTO>>(accounts);
            return accountDTOs;
        }

        public AccountDTO getAccount(string UserName)
        {
            AccountServices accountservices = new AccountServices();
            var account = accountservices.GetAll().Where(p => p.UserName.Equals(UserName)).FirstOrDefault();
            var accountDTO = mapper.Map<AccountDTO>(account);
            return accountDTO;
        }

    }
}
