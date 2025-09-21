namespace YouTubeSearchApp
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class YouTubeSearchApp
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; } = string.Empty;

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("nextPageToken", NullValueHandling = NullValueHandling.Ignore)]
        public string NextPageToken { get; set; } = string.Empty;

        [JsonProperty("regionCode", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; } = string.Empty;

        [JsonProperty("pageInfo", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Item> Items { get; set; } 
    }

    public partial class Item
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; } = string.Empty;

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string Etag { get; set; } = string.Empty;

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Id Id { get; set; }

        [JsonProperty("snippet", NullValueHandling = NullValueHandling.Ignore)]
        public Snippet Snippet { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; } = string.Empty;

        [JsonProperty("videoId", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; } = string.Empty;
    }

    public partial class Snippet
    {
        [JsonProperty("publishedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PublishedAt { get; set; }

        [JsonProperty("channelId", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelId { get; set; } = string.Empty;

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("thumbnails", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnails Thumbnails { get; set; } 

        [JsonProperty("channelTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelTitle { get; set; } = string.Empty;

        [JsonProperty("liveBroadcastContent", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveBroadcastContent { get; set; }

        [JsonProperty("publishTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PublishTime { get; set; }
    }

    public partial class Thumbnails
    {
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public Default Default { get; set; }

        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public Default Medium { get; set; }

        [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
        public Default High { get; set; }
    }

    public partial class Default
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }
    }

    public partial class PageInfo
    {
        [JsonProperty("totalResults", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalResults { get; set; }

        [JsonProperty("resultsPerPage", NullValueHandling = NullValueHandling.Ignore)]
        public long? ResultsPerPage { get; set; }
    }
}
