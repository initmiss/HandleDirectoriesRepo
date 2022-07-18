using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using MailKit.Net.Smtp;
using MimeKit;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Notifier {
	class Email : INotifiable {
		private readonly ILogger<Email> _logger;

		#region debug strings
		private readonly string debugSendMessage = "Send notification to Email";
		private readonly string debugCreateMessage = "Create notification message";
		#endregion

		public Email(ILogger<Email> logger) {
			_logger = logger;
		}

		private MimeMessage CreateMessage(List<FreeGameRecord> pushList, string fromAddress, string toAddress) {
			try {
				_logger.LogDebug(debugCreateMessage);

				var message = new MimeMessage();
