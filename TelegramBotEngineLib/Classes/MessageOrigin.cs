
namespace TelegramBotEngineLib.Classes
{
    public class MessageOrigin
{
    public string? type { get; set; } // Always "user"
    public int date { get; set; } // Date the message was sent originally in Unix time
    public User? sender_user { get; set; } // User that sent the message originally
    public string? sender_user_name { get; set; } // Name of the user that sent the message originally
    public Chat? sender_chat { get; set; } // Chat that sent the message originally
    public string? author_signature { get; set; } // Optional. For messages originally sent by an anonymous chat administrator, original message author signature
    public Chat? chat { get; set; } // Channel chat to which the message was originally sent
    public int message_id { get; set; } // Unique message identifier inside the chat
}

}