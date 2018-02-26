using System;
using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;

namespace dittlassian.Objects.Jira
{
    public class JiraWebHook
    {

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("webhookEvent")]
        public string WebhookEvent { get; set; }

        [JsonProperty("issue_event_type_name")]
        public string IssueEventTypeName { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("issue")]
        public Issue Issue { get; set; }
    }

    public class AvatarUrls
    {

        [JsonProperty("48x48")]
        public string Size48X48 { get; set; }

        [JsonProperty("24x24")]
        public string Size24X24 { get; set; }

        [JsonProperty("16x16")]
        public string Size16X16 { get; set; }

        [JsonProperty("32x32")]
        public string Size32X32 { get; set; }
    }

    public class User
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class Issuetype
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtask")]
        public bool Subtask { get; set; }

        [JsonProperty("avatarId")]
        public int AvatarId { get; set; }
    }

    public class Project
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }
    }

    public class Watches
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("watchCount")]
        public int WatchCount { get; set; }

        [JsonProperty("isWatching")]
        public bool IsWatching { get; set; }
    }

    public class Priority
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class StatusCategory
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("colorName")]
        public string ColorName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Status
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("statusCategory")]
        public StatusCategory StatusCategory { get; set; }
    }

    public class Timetracking // TODO
    {
    }

    public class Creator
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class Reporter
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("avatarUrls")]
        public AvatarUrls AvatarUrls { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public class Aggregateprogress
    {

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ProgressData
    {

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Comment
    {

        [JsonProperty("comments")]
        public IList<object> Comments { get; set; }

        [JsonProperty("maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("startAt")]
        public int StartAt { get; set; }
    }

    public class VotesData
    {

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("hasVoted")]
        public bool HasVoted { get; set; }
    }

    public class Worklog
    {

        [JsonProperty("startAt")]
        public int StartAt { get; set; }

        [JsonProperty("maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("worklogs")]
        public IList<object> Worklogs { get; set; }
    }

    public class Fields
    {

        [JsonProperty("issuetype")]
        public Issuetype Issuetype { get; set; }

        [JsonProperty("timespent")]
        public object Timespent { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("fixVersions")]
        public IList<object> FixVersions { get; set; }

        [JsonProperty("aggregatetimespent")]
        public object Aggregatetimespent { get; set; }

        [JsonProperty("resolution")]
        public object Resolution { get; set; }

        [JsonProperty("resolutiondate")]
        public object Resolutiondate { get; set; }

        [JsonProperty("workratio")]
        public int Workratio { get; set; }

        [JsonProperty("lastViewed")]
        public object LastViewed { get; set; }

        [JsonProperty("watches")]
        public Watches Watches { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("priority")]
        public Priority Priority { get; set; }

        [JsonProperty("labels")]
        public IList<object> Labels { get; set; }        

        [JsonProperty("timeestimate")]
        public object Timeestimate { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate")]
        public object Aggregatetimeoriginalestimate { get; set; }

        [JsonProperty("versions")]
        public IList<object> Versions { get; set; }

        [JsonProperty("issuelinks")]
        public IList<object> Issuelinks { get; set; }

        [JsonProperty("assignee")]
        public object Assignee { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("components")]
        public IList<object> Components { get; set; }

        [JsonProperty("timeoriginalestimate")]
        public object Timeoriginalestimate { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("timetracking")]
        public Timetracking Timetracking { get; set; }

        [JsonProperty("attachment")]
        public IList<object> Attachment { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public object Aggregatetimeestimate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("subtasks")]
        public IList<object> Subtasks { get; set; }

        [JsonProperty("reporter")]
        public Reporter Reporter { get; set; }

        [JsonProperty("aggregateprogress")]
        public Aggregateprogress Aggregateprogress { get; set; }

        [JsonProperty("environment")]
        public object Environment { get; set; }

        [JsonProperty("duedate")]
        public object Duedate { get; set; }

        [JsonProperty("progress")]
        public ProgressData ProgressData { get; set; }

        [JsonProperty("comment")]
        public Comment Comment { get; set; }

        [JsonProperty("votes")]
        public VotesData VotesData { get; set; }

        [JsonProperty("worklog")]
        public Worklog Worklog { get; set; }

        [JsonExtensionData]
        public ExpandoObject CustomFields { get; set; }
    }

    public class Issue
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("fields")]
        public Fields Fields { get; set; }
    }
}
