using IndiegalaFreebieNotifier.Model;
using IndiegalaFreebieNotifier.Models.PostContent;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IndiegalaFreebieNotifier.Notifier {
	public class Discord : INotifiable {
		private readonly ILogger<Discord> _logg