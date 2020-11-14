using System.Text;

namespace IndiegalaFreebieNotifier.Model {
	public class FreeGameRecord {
		public string Url { get; set; }

		public string Title { get; set; }

		public string ToTelegramMessage() {
			re