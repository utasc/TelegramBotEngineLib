
namespace TelegramBotEngineLib.Classes
{

    public class Message
{
    public int message_id { get; set; }
    public int? message_thread_id { get; set; }
    public User? from { get; set; }
    public Chat? sender_chat { get; set; }
    public int date { get; set; }
    public Chat? chat { get; set; }
    public MessageOrigin? forward_origin { get; set; }
    public bool is_topic_message { get; set; }
    public bool is_automatic_forward { get; set; }
    public Message? reply_to_message { get; set; }
    public ExternalReplyInfo? external_reply { get; set; }
    public TextQuote? quote { get; set; }
    public User? via_bot { get; set; }
    public int? edit_date { get; set; }
    public bool has_protected_content { get; set; }
    public string? media_group_id { get; set; }
    public string? author_signature { get; set; }
    public string? text { get; set; }
    public List<MessageEntity>? entities { get; set; }
    public LinkPreviewOptions? link_preview_options { get; set; }
    public Animation? animation { get; set; }
    public Audio? audio { get; set; }
    public Document? document { get; set; }
    public List<PhotoSize>? photo { get; set; }
    public Sticker? sticker { get; set; }
    public Story? story { get; set; }
    public Video? video { get; set; }
    public VideoNote? video_note { get; set; }
    public Voice? voice { get; set; }
    public string? caption { get; set; }
    public List<MessageEntity>? caption_entities { get; set; }
    public bool has_media_spoiler { get; set; }
    public Contact? contact { get; set; }
    public Dice? dice { get; set; }
    public Game? game { get; set; }
    public Poll? poll { get; set; }
    public Venue? venue { get; set; }
    public Location? location { get; set; }
    public List<User>? new_chat_members { get; set; }
    public User? left_chat_member { get; set; }
    public string? new_chat_title { get; set; }
    public List<PhotoSize>? new_chat_photo { get; set; }
    public bool delete_chat_photo { get; set; }
    public bool group_chat_created { get; set; }
    public bool supergroup_chat_created { get; set; }
    public bool channel_chat_created { get; set; }
    public MessageAutoDeleteTimerChanged? message_auto_delete_timer_changed { get; set; }
    public int? migrate_to_chat_id { get; set; }
    public int? migrate_from_chat_id { get; set; }
    public Message? pinned_message { get; set; }
    public Invoice? invoice { get; set; }
    public SuccessfulPayment? successful_payment { get; set; }
    public UsersShared? users_shared { get; set; }
    public ChatShared? chat_shared { get; set; }
    public string? connected_website { get; set; }
    public WriteAccessAllowed? write_access_allowed { get; set; }
    public PassportData? passport_data { get; set; }
    public ProximityAlertTriggered? proximity_alert_triggered { get; set; }
    public ForumTopicCreated? forum_topic_created { get; set; }
    public ForumTopicEdited? forum_topic_edited { get; set; }
    public ForumTopicClosed? forum_topic_closed { get; set; }
    public ForumTopicReopened? forum_topic_reopened { get; set; }
    public GeneralForumTopicHidden? general_forum_topic_hidden { get; set; }
    public GeneralForumTopicUnhidden? general_forum_topic_unhidden { get; set; }
    public GiveawayCreated? giveaway_created { get; set; }
    public Giveaway? giveaway { get; set; }
    public GiveawayWinners? giveaway_winners { get; set; }
    public GiveawayCompleted? giveaway_completed { get; set; }
    public VideoChatScheduled? video_chat_scheduled { get; set; }
    public VideoChatStarted? video_chat_started { get; set; }
    public VideoChatEnded? video_chat_ended { get; set; }
    public VideoChatParticipantsInvited? video_chat_participants_invited { get; set; }
    public WebAppData? web_app_data { get; set; }
    public InlineKeyboardMarkup? reply_markup { get; set; }
}

}