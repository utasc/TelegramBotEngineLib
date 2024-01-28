
namespace TelegramBotEngineLib.Classes
{
    public class MessageReactionUpdated
{
    public Chat? chat { get; set; }
    public int message_id { get; set; }
    public User? user { get; set; }
    public Chat? actor_chat { get; set; }
    public int date { get; set; }
    public List<ReactionType>? old_reaction { get; set; }
    public List<ReactionType>? new_reaction { get; set; }
}

}