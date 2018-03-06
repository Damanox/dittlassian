using System.Linq;
using dittlassian.Objects.Common;
using dittlassian.Objects.Common.Interfaces;
using dittlassian.Objects.Jira;
using dittlassian.Utilities.ConditionParser;

namespace dittlassian.Services.Messages
{
    public class DiscordMessageService : IMessageService
    {
        private readonly ConditionParser _conditionParser;

        public DiscordMessageService(ConditionParser conditionParser)
        {
            _conditionParser = conditionParser;
        }

        public bool ProcessWebHook(IWebHook webHook, Configuration configuration)
        {
            var source = Source.Bitbucket;

            switch (webHook)
            {
                case JiraWebHook _:
                    source = Source.Jira;
                    break;
            }

            var channels = configuration.Rules.Where(x =>
                x.Source == source && _conditionParser.Parse(x.Condition, webHook)).SelectMany(x => x.ChannelIds).ToHashSet();

            return true;
        }
    }
}