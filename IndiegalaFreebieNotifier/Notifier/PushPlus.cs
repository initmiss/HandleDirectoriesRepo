
﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Notifier {
	class PushPlus: INotifiable {
		private readonly ILogger<PushPlus> _logger;

		#region debug strings
		private readonly string debugSendMessage = "Send notification to PushPlus";
		private readonly string debugCreateMessage = "Create notification message";
		#endregion

		public PushPlus(ILogger<PushPlus> logger) {
			_logger = logger;
		}

		private string CreateMessage(List<FreeGameRecord> records) {
			try {
				_logger.LogDebug(debugCreateMessage);

				var sb = new StringBuilder();

				records.ForEach(record => sb.AppendFormat(NotifyFormatStrings.pushPlusBodyFormat, record.ToPushPlusMessage()));

				sb.Append(NotifyFormatStrings.projectLinkHTML);

				_logger.LogDebug($"Done: {debugCreateMessage}");
				return HttpUtility.UrlEncode(sb.ToString());