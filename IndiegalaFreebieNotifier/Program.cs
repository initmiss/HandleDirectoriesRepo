
﻿using System;
using System.Threading.Tasks;
using NLog;
using Microsoft.Extensions.DependencyInjection;
using IndiegalaFreebieNotifier.Module;

namespace IndiegalaFreebieNotifier {
	class Program {
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		static async Task Main() {
			try {
				var services = DI.BuildDiAll();
				logger.Info(" - Start Job -");