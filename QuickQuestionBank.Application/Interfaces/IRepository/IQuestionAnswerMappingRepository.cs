using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IQuestionAnswerMappingRepository
    {
       // Task<int> DeleteAsync(Quiz entity);

        Task<int> DeleteAsync(int id);
        Task<IReadOnlyList<QuestionAnswerMapping>> GetAllAsync();
        Task<QuestionAnswerMapping> GetByIdAsync(int id);
        Task<QuestionAnswerMapping> SaveAsync(QuestionAnswerMapping entity);
    }
}
