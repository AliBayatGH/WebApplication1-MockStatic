using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests;

public class MyMathTests
{
    [Fact()]
    public void AddTest()
    {
        MyMath.Add = (x, y) => { return 10; };

        var sut = new Service1();

        var result=sut.SomeMethod();

        Assert.Equal(20, result);
    }
}