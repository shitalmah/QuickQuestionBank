using MediatR;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.DTOs;
using QuickQuestionBank.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Application.CQRS.User.Command
{
  
    public class InsertUserCommand : IRequest<Response<User_Admin>>
    {
        public User_Admin model { get; set; }
        //public int id { get; set; }  
    }


}
