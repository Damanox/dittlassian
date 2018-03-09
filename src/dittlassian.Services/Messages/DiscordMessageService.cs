using System.Collections.Generic;
using System.Linq;
using dittlassian.Objects.Common;
using dittlassian.Objects.Common.Interfaces;
using dittlassian.Objects.Jira;
using dittlassian.Utilities.ConditionParser;
using DSharpPlus;
using Microsoft.Extensions.Options;

namespace dittlassian.Services.Messages
{
    public class DiscordMessageService : IMessageService
    {
        private readonly ConditionParser _conditionParser;
        private readonly DiscordClient _discordClient;
        private readonly Configuration _configuration;

        public DiscordMessageService(ConditionParser conditionParser, DiscordClient discordClient, IOptions<Configuration> configuration)
        {
            _conditionParser = conditionParser;
            _discordClient = discordClient;
            _configuration = configuration.Value;
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
                    x.Source == source && _conditionParser.Parse(x.Condition, webHook)).SelectMany(x => x.ChannelIds)
                .ToHashSet();

            return true;
        }

        private void SendMessage(List<ulong> channelIds)
        {
            _discordClient.ConnectAsync().GetAwaiter().GetResult();

            var guildData = _discordClient.Guilds.FirstOrDefault(x => x.Key == ulong.Parse(_configuration.Discord.ServerId)).Value;

            foreach (var channel in guildData.Channels)
            {
                if(!channelIds.Contains(channel.Id))
                    continue;

                // Send message
            }
        }
    }
}