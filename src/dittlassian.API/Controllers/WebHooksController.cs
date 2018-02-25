using dittlassian.Objects.Jira;
using Microsoft.AspNetCore.Mvc;

namespace dittlassian.API.Controllers
{
    [Produces("application/json")]
    [Route("api/WebHooks")]
    public class WebHooksController : Controller
    {
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