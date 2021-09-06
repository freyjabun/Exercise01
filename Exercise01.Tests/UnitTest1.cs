using System;
using System.IO;
using Xunit;

namespace Exercise01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Main_Prints_Hello_World()
        {
            //Assign
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!",output);
        }

        [Fact]
        public void Year_1600_Is_LeapYear()
        {
            var isLeapYear = Program.IsLeapYear(1600);
            Assert.True(isLeapYear);
        }

        [Fact]
        public void Year_1700_Is_LeapYear()
        {
            var isLeapYear = Program.IsLeapYear(1700);
            Assert.False(isLeapYear);
        }

        [Fact]
        public void Year_2000_Is_LeapYear()
        {
            var isLeapYear = Program.IsLeapYear(2000);
            Assert.True(isLeapYear);
        }

        [Fact]
        public void Year_2004_Is_LeapYear()
        {
            var isLeapYear = Program.IsLeapYear(2004);
            Assert.True(isLeapYear);
        }

    }
}
