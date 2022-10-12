using System;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using HtmlAgilityPack;
using IndiegalaFreebieNotifier.Model;

namespace IndiegalaFreebieNotifier.Notifier {
	internal class PushDeer: INotifiable {
		private readonly ILogger<PushDeer> _logger;

		#region debug strings
		private readonly string debugSendMessage = "