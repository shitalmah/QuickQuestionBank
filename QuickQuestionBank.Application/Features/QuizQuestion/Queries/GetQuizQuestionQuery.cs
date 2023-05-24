using MediatR;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Domain.DTOs;

namespace QuickQuestionBank.Application.Features.QuizQuestion.Queries {
    public class GetQuizQuestionQuery : IRequest<Response<QuizQuestionDTO>> {
        public int Id { get; set; }
    }
}
