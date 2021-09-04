using System;
using System.IO;
using Xunit;


namespace Assignment00.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Main_Prints_HelloWorld()
        {
          var writer = new StringWriter();
          Console.SetOut(writer);

          Program.Main(new string[0]);

          var output = writer.GetStringBuilder().ToString().Trim();
          Assert.Equal("Hello World!", output);
          
        }

        [Fact]
        public void IsLeapYear_Gets_LeapYears_Correct() {
            Assert.True(Program.IsLeapYear(1600));
            Assert.True(Program.IsLeapYear(2000));
            Assert.False(Program.IsLeapYear(1700));
            Assert.False(Program.IsLeapYear(1800));
            Assert.False(Program.IsLeapYear(1900));
        }
    }
}
