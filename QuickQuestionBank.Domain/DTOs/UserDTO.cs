using QuickQuestionBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Domain.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public String UserType { get; set; }

    
    }
}
