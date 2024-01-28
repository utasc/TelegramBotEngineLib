
namespace TelegramBotEngineLib.Classes
{
    // Poll class
    public class Poll
{
    public string? id { get; set; }
    public string? question { get; set; }
    public List<PollOption>? options { get; set; }
    public int total_voter_count { get; set; }
    public bool is_closed { get; set; }
    public bool is_anonymous { get; set; }
    public string? type { get; set; }
    public bool allows_multiple_answers { get; set; }
    public int correct_option_id { get; set; }
    public string? explanation { get; set; }
    public List<MessageEntity>? explanation_entities { get; set; }
    public int open_period { get; set; }
    public int close_date { get; set; }
}

}