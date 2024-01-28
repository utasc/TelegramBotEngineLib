
namespace TelegramBotEngineLib.Classes
{
    public class EncryptedPassportElement
{
    public string? type { get; set; }
    public string? data { get; set; }
    public string? phone_number { get; set; }
    public string? email { get; set; }
    public PassportFile[]? files { get; set; }
    public PassportFile? front_side { get; set; }
    public PassportFile? reverse_side { get; set; }
    public PassportFile? selfie { get; set; }
    public PassportFile[]? translation { get; set; }
    public string? hash { get; set; }
    public EncryptedCredentials? credentials { get; set; }
}

}