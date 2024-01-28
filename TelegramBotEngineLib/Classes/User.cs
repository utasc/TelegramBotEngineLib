
namespace TelegramBotEngineLib.Classes
{
    public class User
{
    public int id { get; set; }
    public bool is_bot { get; set; }
    public string? first_name { get; set; }
    public string? last_name { get; set; }
    public string? username { get; set; }
    public string? language_code { get; set; }
    public bool is_premium { get; set; }
    public bool added_to_attachment_menu { get; set; }
    public bool can_join_groups { get; set; }
    public bool can_read_all_group_messages { get; set; }
    public bool supports_inline_queries { get; set; }
}

}