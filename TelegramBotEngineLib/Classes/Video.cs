
namespace TelegramBotEngineLib.Classes
{
    // Video class
    public class Video
{
    public string? file_id { get; set; }
    public string? file_unique_id { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int duration { get; set; }
    public PhotoSize? thumbnail { get; set; }
    public string? file_name { get; set; }
    public string? mime_type { get; set; }
    public int file_size { get; set; }
}

}