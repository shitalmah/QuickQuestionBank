using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestionBank.Domain.Entities
{
      
    public class QuizQuestion : BaseEntity
    {
        public string QuestionText { get; set; }
        public int  QuestionTypeId { get; set; }

        [ForeignKey(nameof(QuestionTypeId))]
        public QuestionType QuestionType { get; set; }
        public int QuizId { get; set; }

        [ForeignKey(nameof(QuizId))]
        public Quiz Quiz_Attempt { get; set; }
        public decimal Marks { get; set; }
        public string SortOrder { get; set; }
        public string ComplexityLevel { get; set; }
    }
}
