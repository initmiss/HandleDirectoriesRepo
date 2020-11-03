using Newtonsoft.Json;

namespace IndiegalaFreebieNotifier.Model.PostContent
{
	public class Content {
		[JsonProperty("content")]
		public string Content_ { get; set; }
	}
	public class DingTalkPostContent {
		[JsonProperty("msgtype")]
		public string Me