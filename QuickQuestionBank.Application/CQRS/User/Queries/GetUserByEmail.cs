using MediatR;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.Entities;

using System.Collections.Generic;

namespace QuickQuestionBank.Application.CQRS.User
{
    
    public class GetUserByEmail : IRequest<User_Admin>
    {
        public string Email { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetUserByEmail, User_Admin>
        {
            private readonly QuickQuestionDbContext _context;
            public GetProductByIdQueryHandler(QuickQuestionDbContext context)
            {
                _context = context;
            }
            public async Task<User_Admin> Handle(GetUserByEmail query, CancellationToken cancellationToken)
            {
                var user = _context.User_Admins.Where(a => a.Email == query.Email).FirstOrDefault();
                if (user == null) return null;
                return user;


            }
        }
    }
}
