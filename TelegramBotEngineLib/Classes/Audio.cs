
namespace TelegramBotEngineLib.Classes
{
    // Audio class
    public class Audio
{
    public string? file_id { get; set; }
    public string? file_unique_id { get; set; }
    public int duration { get; set; }
    public string? performer { get; set; }
    public string? title { get; set; }
    public string? file_name { get; set; }
    public string? mime_type { get; set; }
    public int file_size { get; set; }
    public PhotoSize? thumbnail { get; set; }
}

}