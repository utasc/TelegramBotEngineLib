
namespace TelegramBotEngineLib.Classes
{
    public class SwitchInlineQueryChosenChat
{
    public string? query { get; set; }
    public bool allow_user_chats { get; set; }
    public bool allow_bot_chats { get; set; }
    public bool allow_group_chats { get; set; }
    public bool allow_channel_chats { get; set; }
}

}