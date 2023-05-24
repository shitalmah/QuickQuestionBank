using MediatR;
using Microsoft.EntityFrameworkCore;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.Entities;


using System.Collections.Generic;

namespace QuizApp_API.CQRS.Quiz_attempt.Queries
{
    public class GetQuizByUserid : IRequest<List<Quiz>>
    {
        public int id { get; set; }
        public class GetQuizByUseridHandler : IRequestHandler<GetQuizByUserid, List<Quiz>>
        {
         
            private readonly QuickQuestionDbContext _context;
            public GetQuizByUseridHandler(QuickQuestionDbContext context)
            {
                _context = context;
            }
            public async Task<List<Quiz>> Handle(GetQuizByUserid query, CancellationToken cancellationToken)
            {
               // List<Quiz_Attempt> quiz_Attempts = _context.quiz_Attempts.Include(r => r.UserId).Where(r => r.UserId == TxtRole.Text)
                  List <Quiz> quiz_Attempts = _context.Quiz.Where(a => a.UserId == query.id).ToList();                                 
                  return quiz_Attempts;
           
            }
        }
    }
  
}
