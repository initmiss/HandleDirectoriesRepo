﻿using System;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using HtmlAgilityPack;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Notifier {
	internal class PushDeer: INotifiable {
		private readonly ILogger<PushDeer> _logger;

		#region debug strings
		private readonly string debugSendMessage = "Send notification to PushDeer";
		#endregion

		public PushDeer(ILogger<PushDeer> logger) {
			_logger = logger;
		}

		public async Task SendMessage(NotifyConfig config, List<FreeGameRecord> records) {
			try {
				_logger.LogDebug(debugSendMessage);
				var webGet = new HtmlWeb();
				var resp = new HtmlDocument();

				foreach (var record in records) {
					_logger.LogDebug($"{debugSen