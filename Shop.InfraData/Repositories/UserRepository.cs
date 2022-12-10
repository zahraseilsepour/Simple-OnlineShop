using Microsoft.EntityFrameworkCore;
using Shop.Domain.Interface;
using Shop.Domain.Models.Account;
using Shop.InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.InfraData.Repositories
{
    public class UserRepository:IUserRepository
    {
        #region Constractor
        private readonly ShopDbContext _context;
        public UserRepository()
        {

        }

        public async Task CreateUser(User user)
        {
          await _context.Users.AddAsync(user);
            _context.SaveChanges();
        }

        public async Task<User> GetUserByPhone(string phonNumber)
        {
          return await _context.Users.AsQueryable().SingleOrDefaultAsync(c=>c.PhoneNumber== phonNumber);

        }
        #endregion
        #region Account
        public async Task<bool> IsExistPhonNumber(string phonNumber)
        {
           return await _context.Users.AsQueryable().AnyAsync(c=>c.PhoneNumber== phonNumber);
        }
        #endregion
    }
}
