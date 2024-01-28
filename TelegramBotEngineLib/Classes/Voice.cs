
namespace TelegramBotEngineLib.Classes
{
    // Voice class
    public class Voice
{
    public string? file_id { get; set; }
    public string? file_unique_id { get; set; }
    public int duration { get; set; }
    public string? mime_type { get; set; }
    public int file_size { get; set; }
}

}