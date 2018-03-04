using dittlassian.Objects.Jira;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dittlassian.API.Controllers
{
    [Produces("application/json")]
    [Route("api/WebHooks")]
    public class WebHooksController : Controller
    {
        public WebHooksController(ILogger<WebHooksController> hooks)
        {
       //     hooks.LogInformation((LoggingEvents.GetItem, "Getting item {ID}", id);)
        }
        [HttpPost]
        public void Bitbucket()
        {
            return;
        }

        [HttpPost]
        public void Jira(JiraWebHook webHook)
        {
            return;
        }
    }
}