
namespace TelegramBotEngineLib.Classes
{
    public class Chat
{
    public int id { get; set; }
    public string? type { get; set; }
    public string? title { get; set; }
    public string? username { get; set; }
    public string? first_name { get; set; }
    public string? last_name { get; set; }
    public bool is_forum { get; set; }
    public ChatPhoto? photo { get; set; }
    public List<string>? active_usernames { get; set; }
    public List<ReactionType>? available_reactions { get; set; }
    public int accent_color_id { get; set; }
    public string? background_custom_emoji_id { get; set; }
    public int profile_accent_color_id { get; set; }
    public string? profile_background_custom_emoji_id { get; set; }
    public string? emoji_status_custom_emoji_id { get; set; }
    public int emoji_status_expiration_date { get; set; }
    public string? bio { get; set; }
    public bool has_private_forwards { get; set; }
    public bool has_restricted_voice_and_video_messages { get; set; }
    public bool join_to_send_messages { get; set; }
    public bool join_by_request { get; set; }
    public string? description { get; set; }
    public string? invite_link { get; set; }
    public Message? pinned_message { get; set; }
    public ChatPermissions? permissions { get; set; }
    public int slow_mode_delay { get; set; }
    public int message_auto_delete_time { get; set; }
    public bool has_aggressive_anti_spam_enabled { get; set; }
    public bool has_hidden_members { get; set; }
    public bool has_protected_content { get; set; }
    public bool has_visible_history { get; set; }
    public string? sticker_set_name { get; set; }
    public bool can_set_sticker_set { get; set; }
    public int linked_chat_id { get; set; }
    public ChatLocation? location { get; set; }
}

}