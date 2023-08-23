using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TwillioDemoWebApi.Services.SMSSender
{
    public class SMSTwilioService: ISMSSender
    {
        private readonly TwilioSettings _settings;

        public SMSTwilioService(IOptions<TwilioSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task<MessageResource> Send(string to, string body)
        {
            TwilioClient.Init(_settings.AccountSID, _settings.AuthToken);

            var result = await MessageResource.CreateAsync(from: _settings.PhoneNumber,
                                                      to: to,
                                                      body: body);

            return result;
        }
    }
}
