using Microsoft.AspNetCore.Mvc;
using TwillioDemoWebApi.Dtos;
using TwillioDemoWebApi.Services.SMSSender;

namespace TwillioDemoWebApi.Controllers
{
    [ApiController]
    [Route("SMS")]
    public class SMSController : ControllerBase
    {
        private readonly ISMSSender _smsSender;

        public SMSController(ISMSSender smsSender)
        {
            _smsSender = smsSender;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendAsync(SMSDto sms)
        {
            return Ok(await _smsSender.Send(sms.to, sms.Body));
        }
    }
}
