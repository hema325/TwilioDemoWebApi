namespace TwillioDemoWebApi.Services.SMSSender
{
    public class TwilioSettings
    {
        public const string SectionName = "Twilio";

        public string AccountSID { get; init; }
        public string AuthToken { get; init; }
        public string PhoneNumber { get; init; }
    }
}
