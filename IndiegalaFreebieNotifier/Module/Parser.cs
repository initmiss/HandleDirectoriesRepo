using System;
using System.Linq;
using System.Collections.Generic;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Module {
	class Parser : IDisposable {
		private readonly ILogger<Parser> _logger;

		public Parser(ILogger<Parser> logger) {
			_logger = logger;
		}

		public ParseResult Parse(string source, List<FreeGameRecord> records) {
			try {
				_logger.LogDebug("Start parsing");
				var parseResult = new ParseResul