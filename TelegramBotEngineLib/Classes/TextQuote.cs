
namespace TelegramBotEngineLib.Classes
{
    public class TextQuote
{
    public string? text { get; set; } // Text of the quoted part of a message that is replied to by the given message
    public List<MessageEntity>? entities { get; set; } // Optional. Special entities that appear in the quote. Currently, only bold, italic, underline, strikethrough, spoiler, and custom_emoji entities are kept in quotes.
    public int position { get; set; } // Approximate quote position in the original message in UTF-16 code units as specified by the sender
    public bool is_manual { get; set; } // Optional. True, if the quote was chosen manually by the message sender. Otherwise, the quote was added automatically by the server.
}

}