﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Notifier {
	class QQPusher: INotifiable {
		private readonly ILogger<QQPusher> _logger;

		#region debug strings
		private readonly string debugSendMessage = "Send notifications to QQ";
		#endregion

		public QQPusher(ILogger<QQPusher> logger) {
			_logger = logger;
		}

		public async Task SendMessage(NotifyConfig config, List<FreeGameRecord> records) {
			try {
				_logger.LogDebug(debugSendMessage);

				string url = new StringBuilder().AppendFormat(NotifyFormatStrings.qqUrlFormat, 