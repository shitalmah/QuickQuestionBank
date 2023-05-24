using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IQuizRepository
    {
       // Task<int> DeleteAsync(Quiz entity);

        Task<int> DeleteAsync(int id);
        Task<IReadOnlyList<Quiz>> GetAllAsync();
        Task<Quiz> GetByIdAsync(int id);
        Task<Quiz> SaveAsync(Quiz entity);
    }
}
