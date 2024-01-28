
namespace TelegramBotEngineLib.Classes
{
    public class InlineKeyboardButton
{
    public string? text { get; set; }
    public string? url { get; set; }
    public string? callback_data { get; set; }
    public WebAppInfo? web_app { get; set; }
    public LoginUrl? login_url { get; set; }
    public string? switch_inline_query { get; set; }
    public string? switch_inline_query_current_chat { get; set; }
    public SwitchInlineQueryChosenChat? switch_inline_query_chosen_chat { get; set; }
    public CallbackGame? callback_game { get; set; }
    public bool pay { get; set; }
}

}