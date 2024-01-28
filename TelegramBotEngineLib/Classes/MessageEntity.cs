
namespace TelegramBotEngineLib.Classes
{
    public class MessageEntity
{
    public string? type { get; set; } // Type of the entity. Currently, can be “mention” (@username), “hashtag” (#hashtag), “cashtag” ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email” (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text), “italic” (italic text), “underline” (underlined text), “strikethrough” (strikethrough text), “spoiler” (spoiler message), “blockquote” (block quotation), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users without usernames), “custom_emoji” (for inline custom emoji stickers)
    public int offset { get; set; } // Offset in UTF-16 code units to the start of the entity
    public int length { get; set; } // Length of the entity in UTF-16 code units
    public string? url { get; set; } // Optional. For “text_link” only, URL that will be opened after user taps on the text
    public User? user { get; set; } // Optional. For “text_mention” only, the mentioned user
    public string? language { get; set; } // Optional. For “pre” only, the programming language of the entity text
    public string? custom_emoji_id { get; set; } // Optional. For “custom_emoji” only, unique identifier of the custom emoji. Use getCustomEmojiStickers to get full information about the sticker
}

}