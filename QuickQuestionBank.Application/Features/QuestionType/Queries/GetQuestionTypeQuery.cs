using MediatR;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Domain.DTOs;

namespace QuickQuestionBank.Application.Features.QuestionType.Queries {
    public class GetQuestionTypeQuery : IRequest<Response<QuestionTypeDTO>> {
        public int Id { get; set; }
    }
}
