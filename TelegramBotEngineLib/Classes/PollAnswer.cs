
namespace TelegramBotEngineLib.Classes
{
    // PollAnswer class
    public class PollAnswer
{
    public string? poll_id { get; set; }
    public Chat? voter_chat { get; set; }
    public User? user { get; set; }
    public int[]? option_ids { get; set; }
}

}