using MediatR;
using QuickQuestionBank.Application.Features.QuestionType.Queries;
using QuickQuestionBank.Application.Features.QuizQuestion.Queries;
using QuickQuestionBank.Application.Features.UserQuiz.Queries;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain.DTOs;
using QuickQuestionBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Application.Features.QuestionType.Handlers
{
    public class DeleteQuestionTypeRequestHandler : IRequestHandler<DeleteQuestionTypeQuery, Response<int?>>
    {
        private readonly IQuestionTypeRepository _repository;

        public DeleteQuestionTypeRequestHandler(IQuestionTypeRepository repository)
        {
            this._repository = repository;
        }

        public async Task<Response<int?>> Handle(DeleteQuestionTypeQuery request, CancellationToken cancellationToken)
        {
            int result = await _repository.DeleteAsync(request.Id);
            string message = result != default ? "Record Deleted successfully!" : "Record Not Found!";
            return new Response<int?>()
            {
                Data = result != default ? result : null,
                Message = message,
                Count = 1,
            };
        }
    }
}
