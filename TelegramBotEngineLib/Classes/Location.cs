
namespace TelegramBotEngineLib.Classes
{
    public class Location
{
    public float longitude { get; set; }
    public float latitude { get; set; }
    public float? horizontal_accuracy { get; set; }
    public int? live_period { get; set; }
    public int? heading { get; set; }
    public int? proximity_alert_radius { get; set; }
}

}