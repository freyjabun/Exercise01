using System;
using System.IO;
using Xunit;

namespace Exercise01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Hello_World_Prints_Hello_World()
        {
            //Assign
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Hello_World(new string[0]);

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

        [Fact]
        public void PrintPrompt_Prints_Prompt()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.PrintPrompt();

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Enter Year",output);
        }

        [Fact]
        public void LeapYearUserInput_Reads_Input()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2000");
            Console.SetIn(input);

            Program.LeapYearUserInput();

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay",output);
        }
    }
}
