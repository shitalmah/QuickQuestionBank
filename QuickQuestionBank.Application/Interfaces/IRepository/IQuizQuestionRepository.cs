using QuickQuestionBank.Domain.DTOs;
using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IQuizQuestionRepository
    {
       // Task<int> DeleteAsync(Quiz entity);

        Task<int> DeleteAsync(int id);
        Task<IReadOnlyList<QuizQuestion>> GetAllAsync();
        Task<QuizQuestion> GetByIdAsync(int id);
        Task<QuizQuestion> SaveAsync(QuizQuestion entity);
       
    }
}
