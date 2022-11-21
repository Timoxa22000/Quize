using System.ComponentModel.DataAnnotations;

namespace Quize.Models.Quizes
{
    public class Questionnaire
    {
        [Key]
        public int Id { get; set; }
        public List<Ask> Asks { get; set; }
        public Questionnaire()
        {
            Asks = new List<Ask>();
        }
    }
}
