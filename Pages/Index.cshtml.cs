using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quize.Models.Quizes;

namespace Quize.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Questionnaire Model { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Model = new Questionnaire
            {
                Asks = new List<Ask>
                {
                    new Ask
                    {
                        Subject = "Вид питомца",
                        Description = "Требуется выбрать вид питомца",
                        PlaceInLine = 0,
                        Replies = new List<IReply>
                        {
                            new ReplyDropDown
                            {
                                ReplyItems = new List<ReplyItemDropDown>
                                {
                                    new ReplyItemDropDown
                                    {
                                        Id = 0,
                                        Name = "Кошка",
                                    },
                                    new ReplyItemDropDown
                                    {
                                        Id = 1,
                                        Name = "Собака",
                                    },
                                }
                            },
                            new ReplyString { Answer = "Другое", PlaceInLine = 2 },
                        }
                    },
                    new Ask
                    {
                        Subject = "Проведена гельметизация?",
                        Description = "Проведена-ли гельметизация у питомца?",
                        PlaceInLine = 1,
                        Replies = new List<IReply>
                        {
                            new ReplyBool(),
                        }
                    }
                }
            };
        }
    }
}