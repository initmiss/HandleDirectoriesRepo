using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Notifier {
	class QQPusher: INotifiable {
		private readonly ILogger<QQPusher> _logger;

		#region debug str