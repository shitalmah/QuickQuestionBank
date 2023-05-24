using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestionBank.Domain.DTOs
{
    public class QuestionAnswerMappingDTO
    {
        public int? Id { get; set; }
        public virtual int QuestionId { get; set; }

        //[ForeignKey("QuestionId")]
        //public virtual QuizQuestion QuizQuestion { get; set; }
        public string OptionText { get; set; }
        public string IsCorrectAnswer { get; set; }
        public string SortOrder { get; set; }

        #region Mappers
        public static void MapDtoToEntity(QuestionAnswerMappingDTO source, QuestionAnswerMapping destination)
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
            destination.QuestionId = source.QuestionId;
            destination.OptionText = source.OptionText;
            destination.IsCorrectAnswer = source.IsCorrectAnswer;
            destination.SortOrder = source.SortOrder;
        }
        public static void MapEntityToDto(QuestionAnswerMapping source, QuestionAnswerMappingDTO destination)
        {
            //Map using automapper or custom mapper
            //QuizDTO quizDTO = new() {
            destination.Id = source.Id;
            destination.QuestionId = source.QuestionId;
            destination.OptionText = source.OptionText;
            destination.IsCorrectAnswer = source.IsCorrectAnswer;
            destination.SortOrder = source.SortOrder;
        }
        #endregion
    }
}
