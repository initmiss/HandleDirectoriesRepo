﻿using System;
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
						throw new Exception(message: "No Telegram ChatID provided!");
				}

				//Bark
				if (config.EnableBark) {
					if (string.IsNullOrEmpty(config.BarkAddress))
						throw new Exception(message: "No Bark Address provided!");
					if (string.IsNullOrEmpty(config.BarkToken))
						throw new Exception(message: "No Bark Token provided!");
				}

				//Email
				if (config.EnableEmail) {
					if (string.IsNullOrEmpty(config.FromEmailAddress))
						throw new Exception(message: "No from email address provided!");
					if (string.IsNullOrEmpty(config.ToEmailAddress))
						throw new Exception(message: "No to email address provided!");
					if (string.IsNullOrEmpty(config.SMTPServer))
						throw new Exception(message: "No SMTP server provided!");
					if (string.IsNullOrEmpty(config.AuthAccount))
						throw new Exception(message: "No email auth account provided!");
					if (string.IsNullOrEmpty(config.AuthPassword))
						throw new Exception(message: "No email auth password provided!");
				}

				//QQ
				if (config.EnableQQ) {
					if (string.IsNullOrEmpty(config.QQAddress))
						throw new Exception(message: "No QQ address provided!");
					if (string.IsNullOrEmpty(config.QQPort))
						throw new Exception(message: "No QQ port provided!");
					if (string.IsNullOrEmpty(config.ToQQID))
						throw new Exception(message: "No QQ ID provided!");
				}

				//PushPlus
				if (config.EnablePushPlus) {
					if (string.IsNullOrEmpty(config.PushPlusToken))
						throw new Exception(message: "No PushPlus token provided!");
				}

				//DingTalk
				if (config.EnableDingTalk) {
					if (string.IsNullOrEmpty(config.DingTalkBotToken))
						throw new Exception(message: "No DingTalk token provided!");
				}

				//PushDeer
				if (config.EnablePushDeer) {
					if (string.IsNullOrEmpty(config.PushDeerToken))
						throw new Exception(message: "No PushDeer token provided!");
				}

				//Discord
				if (config.EnableDiscord) {
					if (string.IsNullOrEmpty(config.DiscordWebhookURL))
						throw new Exception(message: "No Discord Webhook provided!");
				}

				_logger.LogDebug($"Done: {debugCheckValid}");
			} catch (Exception) {
				_logger.LogError($"Error: {debugCheckValid}");
				throw;
			} finally {
				Dispose();
			}
		}

		public void Dispose()