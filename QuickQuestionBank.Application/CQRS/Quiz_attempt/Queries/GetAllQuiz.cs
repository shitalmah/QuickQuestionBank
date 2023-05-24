using MediatR;
using Microsoft.EntityFrameworkCore;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.Entities;


namespace QuizApp_API.CQRS.Quiz_attempt.Queries
{
    public class GetAllQuiz : IRequest<List<Quiz>>
    {
        public class GetAllQuizHandler : IRequestHandler<GetAllQuiz, List<Quiz>>
        {
            private readonly QuickQuestionDbContext _context;
            public GetAllQuizHandler(QuickQuestionDbContext context)
            {
                _context = context;
            }
            public async Task<List<Quiz>> Handle(GetAllQuiz query, CancellationToken cancellationToken)
            {
                var productList = await _context.Quiz.ToListAsync();
                if (productList == null)
                {
                    return null;
                }
                return productList.ToList();
            }
        }
    }
   
}
