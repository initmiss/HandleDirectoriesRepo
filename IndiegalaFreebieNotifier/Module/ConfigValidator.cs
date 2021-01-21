using System;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Module {
	class ConfigValidator : IDisposable {
		private readonly ILogger<ConfigValidator> _logger;

		#region debug strings
		private readonly string debugCheckValid = "Ch