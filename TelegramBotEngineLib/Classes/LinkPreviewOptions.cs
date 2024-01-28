
namespace TelegramBotEngineLib.Classes
{
    public class LinkPreviewOptions
{
    public bool is_disabled { get; set; } // Optional. True, if the link preview is disabled
    public string? url { get; set; } // Optional. URL to use for the link preview. If empty, then the first URL found in the message text will be used
    public bool prefer_small_media { get; set; } // Optional. True, if the media in the link preview is supposed to be shrunk; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    public bool prefer_large_media { get; set; } // Optional. True, if the media in the link preview is supposed to be enlarged; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    public bool show_above_text { get; set; } // Optional. True, if the link preview must be shown above the message text; otherwise, the link preview will be shown below the message text
}

}