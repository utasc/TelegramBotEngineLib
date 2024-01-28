
namespace TelegramBotEngineLib.Classes
{
    public class ChatInviteLink
{
    public string? invite_link { get; set; }
    public User? creator { get; set; }
    public bool creates_join_request { get; set; }
    public bool is_primary { get; set; }
    public bool is_revoked { get; set; }
    public string? name { get; set; }
    public int? expire_date { get; set; }
    public int? member_limit { get; set; }
    public int? pending_join_request_count { get; set; }
}

}