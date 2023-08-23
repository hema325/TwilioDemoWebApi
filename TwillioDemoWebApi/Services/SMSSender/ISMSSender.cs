using Twilio.Rest.Api.V2010.Account;

namespace TwillioDemoWebApi.Services.SMSSender
{
    public interface ISMSSender
    {
        Task<MessageResource> Send(string to, string body);
    }
}
