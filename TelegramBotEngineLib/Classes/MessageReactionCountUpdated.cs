
namespace TelegramBotEngineLib.Classes
{
    public class MessageReactionCountUpdated
{
    public Chat? chat { get; set; }
    public int message_id { get; set; }
    public int date { get; set; }
    public List<ReactionCount>? reactions { get; set; }
}

}