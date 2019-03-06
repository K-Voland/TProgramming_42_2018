using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
      public class DateTest
    {
      [Fact]
      public void Test1()
      {
        DateTime dr = new DateTime(1990, 9, 17);
        var time = Date.DateB(dr);
        Assert.Equal("Год: 28 Месяц: 05 День: 20", Date.DateB(dr));
      }

      [Fact]
      public void Test2()
      {
        DateTime dr = new DateTime(2010, 2, 2);
        var time = Date.DateB(dr);
        Assert.Equal("Год: 09 Месяц: 01 День: 04", Date.DateB(dr));
      }

      [Fact]
      public void Test3()
      {
        DateTime dr = new DateTime(11, 11, 11);
        var time = Date.DateB(dr);
        Assert.Equal("Год: 07 Месяц: 03 День: 26", Date.DateB(dr));
      }
    }
  }