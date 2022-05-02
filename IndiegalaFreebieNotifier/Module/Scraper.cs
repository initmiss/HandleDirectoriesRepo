
﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using HtmlAgilityPack;
using Microsoft.Playwright;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Module {
	class Scraper : IDisposable {
		private readonly ILogger<Scraper> _logger;
		private readonly string url = "https://freebies.indiegala.com/";

		public Scraper(ILogger<Scraper> logger) {
			_logger = logger;
			// From https://github.com/microsoft/playwright-dotnet/issues/1545#issuecomment-865199736
			Microsoft.Playwright.Program.Main(new string[] { "install", "webkit" });
		}

		public async Task<string> GetHtmlSource(Config config) {