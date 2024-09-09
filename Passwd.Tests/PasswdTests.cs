using System;
using NUnit.Framework;

namespace Parol.Tests
{
    [TestFixture]
    public class PasswordCheckerTests
    {
        private PasswordChecker _passwordChecker;

        [SetUp]
        public void SetUp()
        {
            _passwordChecker = new PasswordChecker();
        }

        [Test]
        public void TestPasswordWithDigitsAndLowercaseLetters()
        {
            int score = _passwordChecker.CheckPassword("Password123");
            Assert.AreEqual(3, score);
        }

        [Test]
        public void TestPasswordWithLowercaseLetters()
        {
            int score = _passwordChecker.CheckPassword("password123");
            Assert.AreEqual(2, score);
        }

        [Test]
        public void TestPasswordWithUppercaseLetters()
        {
            int score = _passwordChecker.CheckPassword("PASSWORD123");
            Assert.AreEqual(3, score);
        }

        [Test]
        public void TestPasswordWithSpecialCharacters()
        {
            int score = _passwordChecker.CheckPassword("Password!123");
            Assert.AreEqual(4, score);
        }

        [Test]
        public void TestPasswordWithMoreThanTenCharacters()
        {
            int score = _passwordChecker.CheckPassword("LongPassword123!");
            Assert.AreEqual(5, score);
        }

        [Test]
        public void TestPasswordWithLessThanTenCharacters()
        {
            int score = _passwordChecker.CheckPassword("short");
            Assert.AreEqual(0, score);
        }
    }
}
