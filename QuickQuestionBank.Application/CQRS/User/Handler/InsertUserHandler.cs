using AutoMapper;
using MediatR;

using QuickQuestionBank.Application.CQRS.User.Command;
using QuickQuestionBank.Application.Features.QuizQuestion.Commands;
using QuickQuestionBank.Application.Features.UserQuiz.Commands;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.DTOs;
using QuickQuestionBank.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Application.CQRS.User.Handler
{
    public class InsertUserHandler : IRequestHandler<InsertUserCommand, Response<User_Admin>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public InsertUserHandler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
   


        public async Task<Response<User_Admin>> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            //Quiz result=  _mapper.Map<Quiz>(request.model);
            QuickQuestionBank.Domain.Entities.User_Admin result = new();
            string msg = request.model.Id == null ? "Quiz Question Created Successfully" : "Quiz Questions Updated Successfully";
          //  UserDTO.MapDtoToEntity(request.model, result);
            User_Admin response = await _repository.SaveAsync(result);
            if (response == null)
            {
                return new Response<User_Admin>()
                {
                    Data = null,
                    Message = "Quiz Not Found!",
                    Count = 1,
                };
            }
            request.model.Id = response.Id;
            return new Response<User_Admin>()
            {
                Data = request.model,
                Message = msg,
                Count = 1,
            };
        }
    }
}
