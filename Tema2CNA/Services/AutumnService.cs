using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Tema2CNA.Protos;

namespace Tema2CNA.Services
{
    public class AutumnService: Autumn.AutumnBase
    {
        public override Task<AutumnResponse> GetAutumnSign(AutumnRequest request, ServerCallContext context)
        {
            var birthday = request.Date;
            var year = GetYears(birthday);
            var dateTime = DateTime.Parse(birthday);
            var path = "Autumn.txt";
            var file = File.ReadAllLines(path);

            string sign = GetSign(file, year, dateTime);

            Console.WriteLine("Your sign is : " + sign);
            return Task.FromResult(new AutumnResponse() { Sign = sign });
        }


        //converts requested date from string to DateTime
        public static DateTime GetDate(string date, int year)
        {
            DateTime dateTime = DateTime.Parse(date);
            var birthYears = dateTime.AddYears(-dateTime.Year + year);

            return birthYears;
        }


        //get the years from birthday
        public static int GetYears(string date)
        {
            string[] pieces = date.Split('/');

            return int.Parse(pieces[2]);
        }

        //return the sign
        public static string GetSign(string[] files, int year, DateTime birthdate)
        {
            DateTime startDay;
            DateTime endDay;
            string sign;

            for (int i = 0; i < files.Length; i += 3)
            {
                sign = files[i];
                startDay = GetDate(files[i + 1], year);
                endDay = GetDate(files[i + 2], year);
                if (startDay <= birthdate && birthdate <= endDay)
                {
                    return sign;
                }
            }

            return "Eroare";
        }
    }

}
