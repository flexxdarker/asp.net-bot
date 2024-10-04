// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

Console.WriteLine("Hello, World!");

string token = "7524090692:AAGveiBO-MnfJF50naLhZVUvslWnC5C5A1Q";

var client = new TelegramBotClient(token);

client.StartReceiving(Update, Error);

Console.ReadLine();

async Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
{
    throw new NotImplementedException();
}

async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
{
    var message = update.Message;
    if (message == null || message.Type != MessageType.Text)
        return;
    if(!string.IsNullOrEmpty(message.Text))
    {
        Console.WriteLine($"{message.Chat.FirstName}   |    {message.Text}");
    }
}