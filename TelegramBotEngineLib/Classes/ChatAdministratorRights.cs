
namespace TelegramBotEngineLib.Classes
{
    public class ChatAdministratorRights
{
    public bool is_anonymous { get; set; }
    public bool can_manage_chat { get; set; }
    public bool can_delete_messages { get; set; }
    public bool can_manage_video_chats { get; set; }
    public bool can_restrict_members { get; set; }
    public bool can_promote_members { get; set; }
    public bool can_change_info { get; set; }
    public bool can_invite_users { get; set; }
    public bool can_post_messages { get; set; }
    public bool can_edit_messages { get; set; }
    public bool can_pin_messages { get; set; }
    public bool can_post_stories { get; set; }
    public bool can_edit_stories { get; set; }
    public bool can_delete_stories { get; set; }
    public bool can_manage_topics { get; set; }
}

}