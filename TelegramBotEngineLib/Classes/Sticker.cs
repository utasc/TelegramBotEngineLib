
namespace TelegramBotEngineLib.Classes
{
    // Sticker class
    public class Sticker
{
    public string? file_id { get; set; }
    public string? file_unique_id { get; set; }
    public string? type { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public bool is_animated { get; set; }
    public bool is_video { get; set; }
    public PhotoSize? thumbnail { get; set; }
    public string? emoji { get; set; }
    public string? set_name { get; set; }
    public File? premium_animation { get; set; }
    public MaskPosition? mask_position { get; set; }
    public string? custom_emoji_id { get; set; }
    public bool needs_repainting { get; set; }
    public int file_size { get; set; }
}

}