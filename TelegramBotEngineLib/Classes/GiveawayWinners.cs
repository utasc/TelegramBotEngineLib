
namespace TelegramBotEngineLib.Classes
{
    public class GiveawayWinners
{
    public Chat? chat { get; set; }
    public int giveaway_message_id { get; set; }
    public int winners_selection_date { get; set; }
    public int winner_count { get; set; }
    public List<User>? winners { get; set; }
    public int additional_chat_count { get; set; }
    public int premium_subscription_month_count { get; set; }
    public int unclaimed_prize_count { get; set; }
    public bool only_new_members { get; set; }
    public bool was_refunded { get; set; }
    public string? prize_description { get; set; }
}

}