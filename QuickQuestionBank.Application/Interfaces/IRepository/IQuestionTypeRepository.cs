using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IQuestionTypeRepository
    {
       // Task<int> DeleteAsync(Quiz entity);

        Task<int> DeleteAsync(int id);
        Task<IReadOnlyList<QuestionType>> GetAllAsync();
        Task<QuestionType> GetByIdAsync(int id);
        Task<QuestionType> SaveAsync(QuestionType entity);
    }
}
