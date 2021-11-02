using System;

namespace Faker.Generators
{
    public class LongGenerator: IGenerator
    {
        private Random Random;

        public LongGenerator()
        {
            Random = new Random();
        }
        public object GenerateRandomValue()
        {
            return Random.Next();
        }
    }
}