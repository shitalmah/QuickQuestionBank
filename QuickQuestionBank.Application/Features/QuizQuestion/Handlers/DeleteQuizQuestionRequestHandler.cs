﻿using MediatR;
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

namespace QuickQuestionBank.Application.Features.QuizQuestion.Handlers
{
    public class DeleteQuizQuestionRequestHandler : IRequestHandler<DeleteQuizQuestionQuery, Response<int?>>
    {
        private readonly IQuizQuestionRepository _repository;

        public DeleteQuizQuestionRequestHandler(IQuizQuestionRepository repository)
        {
            this._repository = repository;
        }

        public async Task<Response<int?>> Handle(DeleteQuizQuestionQuery request, CancellationToken cancellationToken)
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
