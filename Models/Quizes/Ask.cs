namespace Quize.Models.Quizes
{
    public class Ask
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public int PlaceInLine { get; set; }
        public List<IReply> Replies { get; set; }
        public Ask()
        {            
            Replies = new List<IReply>();
        }
        public Ask(string subject, string description)
        {
            Subject = subject;
            Description = description;
            Replies = new List<IReply>();
        }
    }
}
