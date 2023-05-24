using MediatR;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.Entities;



namespace QuizApp_API.CQRS.Quiz_attempt.Queries
{
    public class GetQuetionbyquizId : IRequest<List<QuizQuestion>>
    {
        public int id { get; set; }
        public class GetQuetionbyquizIddHandler : IRequestHandler<GetQuetionbyquizId, List<QuizQuestion>>
        {

            private readonly QuickQuestionDbContext _context;
            public GetQuetionbyquizIddHandler(QuickQuestionDbContext context)
            {
                _context = context;
            }
            public async Task<List<QuizQuestion>> Handle(GetQuetionbyquizId query, CancellationToken cancellationToken)
            {
                // List<Quiz_Attempt> quiz_Attempts = _context.quiz_Attempts.Include(r => r.UserId).Where(r => r.UserId == TxtRole.Text)
                List<QuizQuestion> quiz_Attempts = _context.QuizQuestions.Where(a => a.QuizId == query.id).ToList();
                return quiz_Attempts;

            }
        }
    }
}
