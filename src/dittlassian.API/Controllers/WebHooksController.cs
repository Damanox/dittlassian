using System.IO;
using System.Text;
using dittlassian.Objects.Common;
using dittlassian.Objects.Jira;
using dittlassian.Services.Messages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace dittlassian.API.Controllers
{
    [Produces("application/json")]
    [Route("api/WebHooks")]
    public class WebHooksController : Controller
    {
        private readonly DiscordMessageService _discordMessageService;
        private readonly IOptions<Configuration> _configuration;

        public WebHooksController(ILogger<WebHooksController> hooks, DiscordMessageService discordMessageService,
            IOptions<Configuration> configuration)
        {
            _discordMessageService = discordMessageService;
            _configuration = configuration;
            //     hooks.LogInformation((LoggingEvents.GetItem, "Getting item {ID}", id);)
        }

        [HttpPost]
        [Consumes("text/plain")]
        public void Bitbucket()
        {
            var webHook = "";

            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                webHook = reader.ReadToEndAsync().Result;
            }

            _discordMessageService.ProcessWebHook(webHook, _configuration?.Value);
        }


        [HttpPost]
        public void Jira(JiraWebHook webHook)
        {
            _discordMessageService.ProcessWebHook(webHook, _configuration?.Value);
            return;
        }
    }
}