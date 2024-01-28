
namespace TelegramBotEngineLib.Classes
{
    // SuccessfulPayment class
    public class SuccessfulPayment
{
    public string? currency { get; set; }
    public int total_amount { get; set; }
    public string? invoice_payload { get; set; }
    public string? shipping_option_id { get; set; }
    public OrderInfo? order_info { get; set; }
    public string? telegram_payment_charge_id { get; set; }
    public string? provider_payment_charge_id { get; set; }
}

}