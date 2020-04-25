using System;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using Grpc.Net.Client;
using Tema2CNA.Protos;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var input = ValidateInput();

            var season = GetSeason(input);

            switch (season)
            {
                case "Winter":
                {
                    var client = new Winter.WinterClient(channel);
                    var request = new WinterRequest();
                    request.Date = input;
                    var response = client.GetWinterSign(request);
                    Console.WriteLine("You are born in Winter.");
                    Console.WriteLine($"Your sign is {response.Sign}");
                    break;
                }

                case "Spring":
                {
                    var client = new Spring.SpringClient(channel);
                    var request = new SpringRequest();
                    request.Date = input;
                    var response = client.GetSpringSign(request);
                    Console.WriteLine("You are born in Spring.");
                    Console.WriteLine($"Your sign is {response.Sign}");
                    break;
                }

                case "Summer":
                {
                    var client = new Summer.SummerClient(channel);
                    var request = new SummerRequest();
                    request.Date = input;
                    var response = client.GetSummerSign(request);
                    Console.WriteLine("You are born in Summer.");
                    Console.WriteLine($"Your sign is {response.Sign}");
                    break;
                }

                case "Autumn":
                {
                    var client = new Autumn.AutumnClient(channel);
                    var request = new AutumnRequest();
                    request.Date = input;
                    var response = client.GetAutumnSign(request);
                    Console.WriteLine("You are born in Autumn");
                    Console.WriteLine($"Your sign is {response.Sign}");
                    break;
                }
            }

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static string ValidateInput()
        {
            Console.WriteLine("Enter your birthdate:");
            var input = Console.ReadLine();

            while (true)
            {
                DateTime dateTime;
                if (!DateTime.TryParseExact(input, "MM/dd/yyyy", null, DateTimeStyles.None, out dateTime))
                {
                    Console.WriteLine("Invalid date input.");
                    input = Console.ReadLine();
                }
                return input;
            }
        }
        public static string GetSeason(string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            switch (dateTime.Month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                default:
                    return "Autumn";
            }
        }

    }
}
