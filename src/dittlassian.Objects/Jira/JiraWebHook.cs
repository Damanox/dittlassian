using System;
using System.Collections.Generic;
using System.Dynamic;
using dittlassian.Objects.Common.Interfaces;
using Newtonsoft.Json;

namespace dittlassian.Objects.Jira
{
    public class JiraWebHook : IWebHook
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

    public class CommentData
    {

        [JsonProperty("comments")]
        public IList<Comment> Comments { get; set; }

        [JsonProperty("maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("startAt")]
        public int StartAt { get; set; }
    }
    
    public class Comment
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public User Author { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("updateAuthor")]
        public User UpdateAuthor { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }
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

    public class WorklogData
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
    
    public class Worklog
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("author")]
        public User Author { get; set; }

        [JsonProperty("updateAuthor")]
        public User UpdateAuthor { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("started")]
        public DateTime Started { get; set; }

        [JsonProperty("timeSpent")]
        public string TimeSpent { get; set; }

        [JsonProperty("timeSpentSeconds")]
        public long TimeSpentSeconds { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("issueId")]
        public string IssueId { get; set; }
    }

    public class Fields
    {

        [JsonProperty("issuetype")]
        public Issuetype Issuetype { get; set; }

        [JsonProperty("timespent")]
        public int Timespent { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("fixVersions")]
        public IList<object> FixVersions { get; set; }

        [JsonProperty("aggregatetimespent")]
        public int Aggregatetimespent { get; set; }

        [JsonProperty("resolution")]
        public Resolution Resolution { get; set; }

        [JsonProperty("resolutiondate")]
        public DateTime ResolutionDate { get; set; }

        [JsonProperty("workratio")]
        public int Workratio { get; set; }

        [JsonProperty("lastViewed")]
        public DateTime LastViewed { get; set; }

        [JsonProperty("watches")]
        public Watches Watches { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("priority")]
        public Priority Priority { get; set; }

        [JsonProperty("labels")]
        public IList<string> Labels { get; set; }        

        [JsonProperty("timeestimate")]
        public int TimeEstimate { get; set; }

        [JsonProperty("aggregatetimeoriginalestimate")]
        public int AggregateTimeOriginalEstimate { get; set; }

        [JsonProperty("versions")]
        public IList<object> Versions { get; set; }

        [JsonProperty("issuelinks")]
        public IList<IssueLink> IssueLinks { get; set; }

        [JsonProperty("assignee")]
        public User Assignee { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("components")]
        public IList<Component> Components { get; set; }

        [JsonProperty("timeoriginalestimate")]
        public int TimeOriginalEstimate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timetracking")]
        public Timetracking Timetracking { get; set; }

        [JsonProperty("attachment")]
        public IList<Attachment> Attachment { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public int AggregateTimeEstimate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("creator")]
        public User Creator { get; set; }

        [JsonProperty("subtasks")]
        public IList<object> Subtasks { get; set; }

        [JsonProperty("reporter")]
        public User Reporter { get; set; }

        [JsonProperty("aggregateprogress")]
        public Aggregateprogress Aggregateprogress { get; set; }

        [JsonProperty("environment")]
        public object Environment { get; set; }

        [JsonProperty("duedate")]
        public DateTime DueDate { get; set; }

        [JsonProperty("progress")]
        public ProgressData ProgressData { get; set; }

        [JsonProperty("comment")]
        public CommentData CommentData { get; set; }

        [JsonProperty("votes")]
        public VotesData VotesData { get; set; }

        [JsonProperty("worklog")]
        public WorklogData WorklogData { get; set; }

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
    
    public class IssueLink
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("type")]
        public IssueLinkType Type { get; set; }

        [JsonProperty("outwardIssue")]
        public Issue OutwardIssue { get; set; }
    }
    
    public class IssueLinkType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inward")]
        public string Inward { get; set; }

        [JsonProperty("outward")]
        public string Outward { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }
    
    public class Component
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
    
    public class Attachment
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("author")]
        public User Author { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
    
    public class Resolution
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
