using System.Collections.Generic;
using System.Linq;

namespace dittlassian.Objects.BitBucket
{
    public class BitBucketWebhook
    {
        public BitBucketWebhook(string response)
        {
            var dictionary = FormatToDictionary(response);

            var properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                var propertyName = property.Name.ToLower();

                if (dictionary.TryGetValue($"pullrequest{propertyName}", out var propertyValue))
                {
                    var type = property.PropertyType;
                    
                    if (property.PropertyType == typeof(List<string>))
                    {
                        property.SetValue(this, propertyValue);
                    }
                    else
                    {
                        property.SetValue(this, propertyValue.First());
                    }
                }
            }
            
        }
        
        public string Action { get; set; }
        public string AuthorDisplayName { get; set; }
        public string CommentText { get; set; }
        
        public string FromBranch { get; set; }
        public string FromRepoName { get; set; }
        public string FromRepoProjectKey { get; set; }
        public List<string> ParticipantsApprovedCount { get; set; }
        public List<string> Reviewers { get; set; }
        public List<string> RequestReviewersApprovedCount { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public string ToBranch { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; } // => who updated request
        
        private static Dictionary<string, List<string>> FormatToDictionary(string text)
        {
            var hookFieldsDict = new Dictionary<string, List<string>>();
            var hookFieldsArr = text.Split("&");

            foreach (var arrField in hookFieldsArr)
            {
                var keyValueData = arrField.Split("=");
                
                hookFieldsDict.Add(keyValueData.ElementAt(0).ToLower().Replace("_", ""), keyValueData.ElementAt(1).Split(",").ToList());
            }
            return hookFieldsDict;
        }

    }
}