using IndiegalaFreebieNotifier.Model;
using IndiegalaFreebieNotifier.Models.PostContent;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IndiegalaFreebieNotifier.Notifier {
	public class Discord : INotifiable {
		private readonly ILogger<Discord> _logger;

		#region debug strings
		private readonly string debugSendMessage = "Send notification to Discord";
		#endregion

		public Discord(ILogger<Discord> logger) {
			_logger = logger;
		}

		public async Task SendMessage(NotifyConfig config, List<FreeGameRecord> records) {
			try {
				_logger.LogDebug(debugSendMessage);

				var url = config.DiscordWebhookURL;
				var content = new DiscordPostContent() {
					Content = records.Count > 1 ? "New Free Games - Indiegala" : "New Free Game - Indiegala"
				};

				foreach (var reco