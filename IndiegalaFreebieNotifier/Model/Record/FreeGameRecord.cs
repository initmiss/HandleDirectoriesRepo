﻿using System.Text;

namespace IndiegalaFreebieNotifier.Model {
	public class FreeGameRecord {
		public string Url { get; set; }

		public string Title { get; set; }

		public string ToTelegramMessage() {
			return new StringBuilder().AppendFormat(NotifyFormatStrings.telegramPushFormat, Title, Url).ToString();
		}

		public string ToBarkMessage() {
			return new StringBuilder().AppendFormat(NotifyFormatStrings.barkPushFormat, Title, Url).ToString();
		}

		public string ToEmailMessage() {
			return new StringBuilder().AppendFormat(Notif