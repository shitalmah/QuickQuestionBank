using QuickQuestionBank.Domain.Entities;

using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestionBank.Domain.Entities
{
    public class Quiz : BaseEntity
    {
        public string QuizTitle { get; set; }
        public DateTime QuizExpiryDate { get; set; }
        public decimal QuizMarks { get; set; }
        public string QuestionsPerPage { get; set; }
        public string PassingCriteriaInPercentage { get; set; }
        public TimeSpan timeDuration { get; set; }



        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User_Admin user_admin { get; set; }
    }
}
