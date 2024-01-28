
namespace TelegramBotEngineLib.Classes
{
    public class ExternalReplyInfo
{
    public MessageOrigin? origin { get; set; } // Origin of the message replied to by the given message
    public Chat? chat { get; set; } // Optional. Chat the original message belongs to. Available only if the chat is a supergroup or a channel.
    public int message_id { get; set; } // Optional. Unique message identifier inside the original chat. Available only if the original chat is a supergroup or a channel.
    public LinkPreviewOptions? link_preview_options { get; set; } // Optional. Options used for link preview generation for the original message, if it is a text message
    public Animation? animation { get; set; } // Optional. Message is an animation, information about the animation
    public Audio? audio { get; set; } // Optional. Message is an audio file, information about the file
    public Document? document { get; set; } // Optional. Message is a general file, information about the file
    public List<PhotoSize>? photo { get; set; } // Optional. Message is a photo, available sizes of the photo
    public Sticker? sticker { get; set; } // Optional. Message is a sticker, information about the sticker
    public Story? story { get; set; } // Optional. Message is a forwarded story
    public Video? video { get; set; } // Optional. Message is a video, information about the video
    public VideoNote? video_note { get; set; } // Optional. Message is a video note, information about the video message
    public Voice? voice { get; set; } // Optional. Message is a voice message, information about the file
    public bool has_media_spoiler { get; set; } // Optional. True, if the message media is covered by a spoiler animation
    public Contact? contact { get; set; } // Optional. Message is a shared contact, information about the contact
    public Dice? dice { get; set; } // Optional. Message is a dice with a random value
    public Game? game { get; set; } // Optional. Message is a game, information about the game. More about games »
    public Giveaway? giveaway { get; set; } // Optional. Message is a scheduled giveaway, information about the giveaway
    public GiveawayWinners? giveaway_winners { get; set; } // Optional. A giveaway with public winners was completed
    public Invoice? invoice { get; set; } // Optional. Message is an invoice for a payment, information about the invoice. More about payments »
    public Location? location { get; set; } // Optional. Message is a shared location, information about the location
    public Poll? poll { get; set; } // Optional. Message is a native poll, information about the poll
    public Venue? venue { get; set; } // Optional. Message is a venue, information about the venue
}

}