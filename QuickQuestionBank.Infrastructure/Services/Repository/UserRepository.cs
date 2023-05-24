using Microsoft.EntityFrameworkCore;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Infrastructure.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly QuickQuestionDbContext _context;

        public UserRepository(QuickQuestionDbContext context)
        {
            this._context = context;
        }
        public Task<User_Admin> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

    

        public async Task<User_Admin> GetByEmailIdAsync(string Email)
        {
            return await _context.User_Admins.Where(q => q.Email == Email).FirstOrDefaultAsync();
        }

        public Task<User_Admin> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User_Admin> SaveAsync(User_Admin entity)
        {
            if (entity.Id == default)
            {
                await _context.AddAsync(entity);
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return entity;
        }

      public async  Task<List<User_Admin>> GetAll()
        {
            return await _context.User_Admins.ToListAsync();
        }
    }
}
