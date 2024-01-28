
namespace TelegramBotEngineLib.Classes
{
    // Document class
    public class Document
{
    public string? file_id { get; set; }
    public string? file_unique_id { get; set; }
    public PhotoSize? thumbnail { get; set; }
    public string? file_name { get; set; }
    public string? mime_type { get; set; }
    public int file_size { get; set; }
}

}