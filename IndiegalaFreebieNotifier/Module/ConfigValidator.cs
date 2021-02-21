using System;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Module {
	class ConfigValidator : IDisposable {
		private readonly ILogger<ConfigValidator> _logger;

		#region debug strings
		private readonly string debugCheckValid = "Check config file validation";
		#endregion

		public ConfigValidator(ILogger<ConfigValidator> logger) {
			_logger = logger;
		}

		public void CheckValid(Config config) {
			try {
				_logger.LogDebug(debugCheckValid);

				//Telegram
				if (config.EnableTelegram) {
					if (string.IsNullOrEmpty(config.TelegramToken))
						throw new Exception(message: "No Telegram Token provided!");
					if (string.IsNullOrEmpty(config.TelegramChatID))
						throw new Exception(message: "No 