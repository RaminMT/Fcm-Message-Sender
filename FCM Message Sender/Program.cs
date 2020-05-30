using System;
using System.IO;
using System.Text.Json;
using FCM.Net;

namespace FCM_Message_Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("runtimeconfig.json");
            var model = JsonSerializer.Deserialize<FcmModel>(jsonString);
            
            using var sender = new Sender(model.FcmKey);
            var response = sender.SendAsync(model.Message).GetAwaiter().GetResult();

            Console.WriteLine(response.StatusCode);
            Console.WriteLine(JsonSerializer.Serialize(response));
            Console.WriteLine();
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}