﻿using Microsoft.AspNetCore.Identity;

namespace QuickQuestionBank.Domain.Entities {
    public class User : IdentityUser
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
