
namespace TelegramBotEngineLib.Classes
{
    public class GiveawayCompleted
{
    public int winner_count { get; set; }
    public int unclaimed_prize_count { get; set; }
    public Message? giveaway_message { get; set; }
}

}