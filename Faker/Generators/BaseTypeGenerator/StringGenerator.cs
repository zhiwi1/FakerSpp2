using System;
using System.Linq;

namespace Faker.Generators
{
    public class StringGenerator : IGenerator
    {

        const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public object GenerateRandomValue()
        {
            var random = new Random();
            return new string(Enumerable.Repeat(Chars, 255)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
    
}