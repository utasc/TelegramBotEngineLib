
namespace TelegramBotEngineLib.Classes
{
    public class Giveaway
{
    public List<Chat>? chats { get; set; }
    public int winners_selection_date { get; set; }
    public int winner_count { get; set; }
    public bool only_new_members { get; set; }
    public bool has_public_winners { get; set; }
    public string? prize_description { get; set; }
    public List<string>? country_codes { get; set; }
    public int premium_subscription_month_count { get; set; }
}

}