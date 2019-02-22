using System;
using System.Collections.Generic;
using System.Linq;
using dittlassian.Objects.BitBucket;
using dittlassian.Objects.Common;
using dittlassian.Objects.Common.Interfaces;
using dittlassian.Objects.Jira;
using dittlassian.Utilities.ConditionParser;
using DSharpPlus;
using DSharpPlus.Entities;
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

        public bool ProcessWebHook(object webHook, Configuration configuration)
        {
            var source = Source.Bitbucket;

            switch (webHook)
            {
                case JiraWebHook _:
                    source = Source.Jira;
                    break;
            }

            var channels = configuration.Rules.Where(x =>
                    x.Source == source).SelectMany(x => x.ChannelIds)
                .ToHashSet();
            
            SendMessage(channels.ToList(), webHook.ToString());

            return true;

        }

       private void SendMessage(List<ulong> channelIds, string message)
        {
            _discordClient.ConnectAsync().GetAwaiter().GetResult();

            var guild = _discordClient.GetGuildAsync(ulong.Parse(_configuration.Discord.ServerId)).Result;

            foreach (var channel in guild.Channels)
            {
                if(!channelIds.Contains(channel.Id))
                    continue;

                try
                {
                    _discordClient.SendMessageAsync(channel, null, false, CreateEmbeddedObj(message)).GetAwaiter().GetResult();
                }
                catch (Exception) { }
            }
        }
        
        private DiscordEmbed CreateEmbeddedObj(string text)
        {
            var hook = new BitBucketWebhook(text);
            
            var builder = new DiscordEmbedBuilder();

            var title =
                $"{hook?.UserName} {hook?.Action?.ToUpper()} pull request {hook?.Title} by {hook?.AuthorDisplayName}";

            var color = GetColor(hook?.Action);

            builder.WithTitle(title)
                .WithTimestamp(DateTime.Now)
                .WithColor(color)
                .WithUrl(hook?.Url)
                .AddField("Repository:", hook?.FromRepoName, true)
                .AddField("From Branch:", hook?.FromBranch, true)
                .AddField("To Branch:", hook?.ToBranch, true)
                .AddField("Approve Counts:", hook?.ParticipantsApprovedCount.FirstOrDefault() ?? "", true);

            return builder.Build();
        }

        private DiscordColor GetColor(string action)
        {
            switch (action)
            {
                case "reopened":
                case "opened":
                    return DiscordColor.Yellow;  
                case "declined":
                    return DiscordColor.IndianRed; 
                case "commented":
                    return DiscordColor.Blue; 
                case "updated":
                    return DiscordColor.Orange;
                case "approved":
                    return DiscordColor.Green;
                default:
                    return DiscordColor.Cyan;
            }
        }
    }
}