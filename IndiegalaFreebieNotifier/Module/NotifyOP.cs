﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using IndiegalaFreebieNotifier.Notifier;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Module {
	class NotifyOP : IDisposable {
		private readonly ILogger<NotifyOP> _logger;
		private readonly IServiceProvider services = DI.BuildDiNotifierOnly();

		#region debug stri