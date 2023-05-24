using QuickQuestionBank.Domain.Entities;


namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IUserRepository
    {
        Task<User_Admin> GetByIdAsync(int id);

        Task<User_Admin> GetByEmailIdAsync(string Email);

        Task<List<User_Admin>> GetAll();
        Task<User_Admin> DeleteAsync(int id);
        Task<User_Admin> SaveAsync(User_Admin entity);
    }
}
