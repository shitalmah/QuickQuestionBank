using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QuickQuestionBank.Application.Features.QuizQuestion.Commands;
using QuickQuestionBank.Application.Features.QuizQuestion.Queries;
using QuickQuestionBank.Domain.DTOs;
using QuizApp_API.CQRS.Quiz_attempt.Queries;
using System.Runtime.InteropServices;

namespace QuickQuestionBank.API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuizQuestionController : ControllerBase
    {
        //  private readonly IMediator _mediator;
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public QuizQuestionController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get(int id) =>
            Ok(await _mediator.Send(new GetQuizQuestionQuery { Id = id }));

        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetAll() =>
            Ok(await _mediator.Send(new GetAllQuizQuestionQuery()));

        [HttpPost]
        [Route("save")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(QuizQuestionDTO model)
        {
            var response = await _mediator.Send(new CreateQuizQuestionCommand { model = model });
            return Ok(response);
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteQuizQuestionQuery { Id = id });
            if (response.Count == 0)
            {
                return NotFound();
            }
            return Ok(response);
        }



      

        [HttpGet("{userid}")]
        public async Task<IActionResult> GetQuizId(int userid)
        {

            var quiz = await Mediator.Send(new GetQuizByUserid { id = userid });
            int QUIZid = quiz[0].Id;
            return Ok(QUIZid);
        }

        [HttpGet]
        public async Task<IActionResult> GetQuetionsbyId(int id)
        {

            // var quiz = await Mediator.Send(new GetQuetionbyquizId { id = id });

            return Ok(await Mediator.Send(new GetQuetionbyquizId { id = id }));
        }
    }
}
