﻿using System;
using ConsoleApplication;
using NUnit.Framework;

namespace TestFaker
{
    [TestFixture]
    public class Tests
    {
        private Foo foo;
        private Class1 class1;
        private Faker.Faker faker;
        
        [SetUp]
        public void initialization()
        {
            faker = new Faker.Faker();
            foo = faker.Create<Foo>();
            class1 = faker.Create<Class1>();
        }

        [Test] 
        public void TestGenerateBool()
        {
            Assert.True(foo._isTrue);
        }
        
        [Test]
        public void TestGenerateClass()
        {
            Assert.True(foo._bar != null);
        }
        
        [Test]
        public void TestGenerateLong()
        {
            Assert.True(foo._long != 0L);
        }
        
        [Test]
        public void TestGenerateFloat()
        {
            Assert.True(foo._float != 0f);
        }
        
        [Test]
        public void TestGenerateWithoutConstructor()
        {
            Assert.True(foo._int1 != 0);
        }
        
        [Test]
        public void TestGenerateList()
        {
            Assert.True(foo._bar._intList.Count > 0);
            foreach (int num in foo._bar._intList)
            {
                Assert.True(num != 0);
            }
        }
        
        [Test]
        public void TestGenerateDateTime()
        {
            DateTime dateTime = new DateTime();
            Assert.False(dateTime.Equals(foo._bar._dateTime));
        }
        
        [Test]
        public void TestGenerateCircleDependencies()
        {
            Assert.True(class1.class2.class1.class2 == null && class1.class2.class1 != null);
        }
        
        [Test]
        public void TestGenerateValueWithoutGenerator()
        {
            Assert.True(foo._ints == null);
        }
    }
}