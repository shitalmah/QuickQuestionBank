using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickQuestionBank.Application.CQRS.User;
using QuickQuestionBank.Application.CQRS.User.Command;
using QuickQuestionBank.Application.Features.QuizQuestion.Commands;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain.Entities;
using QuickQuestionBank.Infrastructure.Services.Repository;

namespace QuizApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        //private IMediator _mediator;
        //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
       
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        [HttpGet("{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {

            return Ok(await _userRepository.GetByEmailIdAsync(email));
        }


        [HttpGet]
        public async Task<IActionResult> Getall()
        {

            return Ok(await _userRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User_Admin value)
        {
            var response = await _userRepository.SaveAsync(value);
            return Ok(response);
        //    return Ok(await Mediator.Send(new InsertUserCommand{ model = value}));
        //    var model = new InsertUserCommand { user=value });
          //  return await _mediator.Send(model);
        }
    }
}
