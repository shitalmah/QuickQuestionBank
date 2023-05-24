﻿using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestionBank.Domain.Entities {
    public class QuestionAnswerMapping : BaseEntity
    {
        public virtual int QuestionId { get; set; }
        //[ForeignKey("QuestionId")]
        //public virtual QuizQuestion QuizQuestion { get; set; }
        public string OptionText { get; set; }
        public string IsCorrectAnswer { get; set; }
        public string SortOrder { get; set; }
    }
}
