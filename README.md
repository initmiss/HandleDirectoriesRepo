
# IndiegalaFreebieNotifier

A CLI tool fetchs data from [https://freebies.indiegala.com/](https://freebies.indiegala.com/) then sends notifications through Telegram, Bark, Email, QQ, PushPlus, DingTalk and Discord.

Indiegala has frequency check too, if you send too much requests in a short period of time, Indiegala will return a challenge(captcha) page.

Demo Telegram Channel [@azhuge233_FreeGames](https://t.me/azhuge233_FreeGames)

## Build

Install dotnet 7.0 SDK first, you can find installation packages/guides [here](https://dotnet.microsoft.com/download).

### Publish

```
dotnet publish -c Release -o /your/path/here -r [win10-x64/osx-x64/linux-x64] --sc
```

## Usage

Set your Telegram Bot token and chat ID in config.json

```json
{
	"TelegramToken": "xxxxxx:xxxxxx",
	"TelegramChatID": "xxxxxxxx"
}
```
