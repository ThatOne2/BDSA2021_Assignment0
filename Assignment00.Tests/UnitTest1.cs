using System;
using System.IO;
using Xunit;


namespace Assignment00.Tests
{
    public class UnitTest1
    {
        /*
        [Fact]
        public void Main_Prints_HelloWorld()
        {
          var writer = new StringWriter();
          Console.SetOut(writer);

          Program.Main(new string[0]);

          var output = writer.GetStringBuilder().ToString().Trim();
          Assert.Equal("Hello World!", output);
          
        } */

        [Fact]
        public void IsLeapYear_Gets_LeapYears_Correct() {
            Assert.True(Program.IsLeapYear(1600));
            Assert.True(Program.IsLeapYear(2000));
            Assert.False(Program.IsLeapYear(1700));
            Assert.False(Program.IsLeapYear(1800));
            Assert.False(Program.IsLeapYear(1900));
        }

        
        [Fact]
        public void Takes_User_input() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(1600);
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }
        
        [Fact]
        public void Takes_User_input2() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(2000);
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        } 

        [Fact]
        public void Takes_User_input3() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(1700);
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Takes_User_input4() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(1800);
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Takes_User_input5() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(1900);
            var output = writer.GetStringBuilder().ToString().Trim(); 
            Assert.Equal("nay", output);
        } 

        [Fact]
        public void Does_Not_Allow_Letters() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.Main(new string[0]);
            writer.WriteLine("hej"); //This fucntions as user input
            var output = writer.GetStringBuilder().ToString(); 
            string[] aWhyMoment = output.Split('\n');
            Assert.Equal("Please write the year in numbers only", aWhyMoment[1].Trim());

        } 
        [Fact]
        public void Does_Not_Allow_Years_Under_1582() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(1582);
            var output = writer.GetStringBuilder().ToString().Trim(); 
            Assert.Equal("nay", output);
        } 

        [Fact]
        public void Does_Not_Allow_Years_Under_1582_Test2() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(1581);
            var output = writer.GetStringBuilder().ToString().Trim(); 
            Assert.Equal("Year has to be 1582 or bigger", output);
        } 

        [Fact]
         public void Does_Not_Allow_Years_Under_1582_Test3() {
            var writer = new StringWriter();
            Console.SetOut(writer);
            Program.UserSpecifiedYear(0);
            var output = writer.GetStringBuilder().ToString().Trim(); 
            Assert.Equal("Year has to be 1582 or bigger", output);
        } 
    }
}
