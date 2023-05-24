﻿using MediatR;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Application.Features.QuestionAnswerMapping.Commands
{
    public class CreateQuestionAnswerMappingCommand : IRequest<Response<QuestionAnswerMappingDTO>>
    {
    public QuestionAnswerMappingDTO model { get; set; }  
    //public int id { get; set; }  
    }
}
