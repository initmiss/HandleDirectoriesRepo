
﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace IndiegalaFreebieNotifier.Models.PostContent {
	public class Footer {
		[JsonProperty("text")]
		public string Text { get; set; }