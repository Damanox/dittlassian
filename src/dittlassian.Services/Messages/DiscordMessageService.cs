using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dittlassian.Objects.Common;
using dittlassian.Objects.Common.Interfaces;
using dittlassian.Objects.Jira;
using dittlassian.Utilities.ConditionParser;

namespace dittlassian.Services.Messages
{
    public class DiscordMessageService : IMessageService
    {
        public bool ProcessWebHook(IWebHook webHook, Configuration configuration)
        {
            var source = Source.Bitbucket;

            switch (webHook)
            {
                case JiraWebHook j:
                    source = Source.Jira;
                    break;
            }

            var channels = configuration.Rules.Where(x =>
                x.Source == source && ConditionParserUtil.Parse(x.Condition, webHook)).SelectMany(x => x.ChannelIds).ToHashSet();

            return true;
        }
    }
}