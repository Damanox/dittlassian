using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dittlassian.Objects.Common
{
    public class Configuration
    {
        [JsonProperty("discord")]
        public DiscordConfiguration Discord { get; set; }

        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }
    }

    public class DiscordConfiguration
    {
        public string ServerId { get; set; }
        public string BotId { get; set; }
        public string Token { get; set; }
    }

    public class Rule
    {
        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("channelIds")]
        public List<ulong> ChannelIds { get; set; }
    }
}