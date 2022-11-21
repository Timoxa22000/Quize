using System.ComponentModel.DataAnnotations;

namespace Quize.Models.Quizes
{
    public interface IReply
    {
        [Key]
        public int Id { get; set; }
        public int PlaceInLine { get; set; }
        public ReplyType ReplyType { get; }
    }
    public class ReplyString : IReply
    {
        [Key]
        public int Id { get; set; }
        public string? Answer { get; set; }
        public int PlaceInLine { get; set; }
        public ReplyType ReplyType { get => ReplyType.String; }
    }
    public class ReplyBool : IReply
    {
        public int Id { get; set; }
        public bool Answer { get; set; } = false;
        public int PlaceInLine { get; set; }
        public ReplyType ReplyType { get => ReplyType.Boolean; }
        public void Toggle()
        {
            Answer = !Answer;
        } 
    }
    public class ReplyDropDown : IReply
    {
        public int Id { get; set; }
        public int AnswerResultId { get; set; }
        public int PlaceInLine { get; set; }
        public List<ReplyItemDropDown> ReplyItems { get; set; }
        public ReplyType ReplyType { get => ReplyType.DropDowmList; }
        public ReplyDropDown()
        {
            ReplyItems = new List<ReplyItemDropDown>();
        }
    }
    public class ReplyItemDropDown
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
