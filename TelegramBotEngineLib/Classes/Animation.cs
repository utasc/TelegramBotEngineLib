
namespace TelegramBotEngineLib.Classes
{
    public class Animation
{
    public string? file_id { get; set; } // Identifier for this file, which can be used to download or reuse the file
    public string? file_unique_id { get; set; } // Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
    public int width { get; set; } // Video width as defined by sender
    public int height { get; set; } // Video height as defined by sender
    public int duration { get; set; } // Duration of the video in seconds as defined by sender
    public PhotoSize? thumbnail { get; set; } // Optional. Animation thumbnail as defined by sender
    public string? file_name { get; set; } // Optional. Original animation filename as defined by sender
    public string? mime_type { get; set; } // Optional. MIME type of the file as defined by sender
    public int file_size { get; set; } // Optional. File size in bytes. It can be bigger than 2^31 and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this value.
}

}