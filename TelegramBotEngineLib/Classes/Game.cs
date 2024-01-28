
namespace TelegramBotEngineLib.Classes
{
    // Game class
    public class Game
{
    public string? title { get; set; }
    public string? description { get; set; }
    public PhotoSize[]? photo { get; set; }
    public string? text { get; set; }
    public MessageEntity[]? text_entities { get; set; }
    public Animation? animation { get; set; }
}

}