﻿using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.Domain.DTOs
{
    public class QuizDTO
    {
        public int? Id { get; set; }
        public string QuizTitle { get; set; }
        public DateTime QuizExpiryDate { get; set; }
        public decimal QuizMarks { get; set; }
        public string QuestionsPerPage { get; set; }
        public string PassingCriteriaInPercentage { get; set; }
        public TimeSpan timeDuration { get; set; }

        #region Mappers
        public static void MapDtoToEntity(QuizDTO source, Quiz destination)
        {
            //Map using automapper or custom mapper
            if (source.Id == null)
            {
                destination.CreatedDate = DateTime.Now;
            }
            else
            {
                destination.ModifiedDate = DateTime.Now;
                destination.Id= (int)source.Id;
            }
            destination.QuizTitle = source.QuizTitle;
            destination.QuizExpiryDate = source.QuizExpiryDate;
            destination.QuizMarks = source.QuizMarks;
            destination.QuestionsPerPage = source.QuestionsPerPage;
            destination.PassingCriteriaInPercentage = source.PassingCriteriaInPercentage;
            destination.timeDuration = source.timeDuration;
        }
        public static void MapEntityToDto(Quiz source, QuizDTO destination)
        {
            //Map using automapper or custom mapper
            //QuizDTO quizDTO = new() {
            destination.Id = source.Id;
            destination.QuizTitle = source.QuizTitle;
            destination.QuizExpiryDate = source.QuizExpiryDate;
            destination.QuizMarks = source.QuizMarks;
            destination.QuestionsPerPage = source.QuestionsPerPage;
            destination.PassingCriteriaInPercentage = source.PassingCriteriaInPercentage;
            destination.timeDuration = source.timeDuration;
        }
        #endregion
    }
}
