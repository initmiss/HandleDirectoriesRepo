using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Module {
	class JsonOP : IDisposable {
		private readonly ILogger<JsonOP> _logger;
		private readonly string confi