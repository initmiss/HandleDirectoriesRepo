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
				var parseResult = new ParseResult();

				var htmlDoc = new HtmlDocument();
				htmlDoc.LoadHtml(source);

				if (htmlDoc.DocumentNode.SelectNodes(ParseStrings.divXpath) != null) {
					var freebies = htmlDoc.DocumentNode.SelectNodes(ParseStrings.divXpath).ToList();

					foreach (var each in freebies) {
						// get article titles and links
						var title = each.SelectSingleNode(ParseStrings.titleXpath).InnerText;
						var link = each.SelectSingleNode(ParseStrings.linkXpath).Attributes["href"].Value;

						_logger.LogInformation("Found new info: {0}", title);

						// save titles and links to List
						var newFreeGame = new FreeGameRecord { Title = title, Url = li