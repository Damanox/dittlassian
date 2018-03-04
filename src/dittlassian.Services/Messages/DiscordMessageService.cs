using System;
using System.Collections.Generic;
using System.Text;
using dittlassian.Objects.Common.Interfaces;
using dittlassian.Objects.Jira;

namespace dittlassian.Services.Messages
{
    public class DiscordMessageService : IMessageService
    {
        public bool ProcessWebHook(IWebHook webHook)
        {
            switch (webHook)
            {
                case JiraWebHook j:
                    return true;
                    break;
            }

            return true;
        }
    }
}
