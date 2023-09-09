using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(10540, 203, -103), Is.EqualTo(-103));
    }

    [Test]
    public void Min3Test3()
    {
        /*That(Min3(103, Double.PositiveInfinity, Double.NegativeInfinity), Is.EqualTo(Double.NegativeInfinity));*/
        That(Min3(10540, 0, -103), Is.EqualTo(-103));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(10540, 203, -103), Is.EqualTo(10540));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(34065540, 0, -103), Is.EqualTo(34065540));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(0, 456623, -55432), Is.EqualTo(456623));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }
    
    [Test]
    public void Deg2RadTest2()
    {
        That(Deg2Rad(90.0), Is.EqualTo(Math.PI/2).Within(1e-5));
    }
    //--------------------------------------------------------
    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }
    [Test]
    public void MoreRadDegTests()
    {
        That(Min3(-1304, 0, 394398), Is.EqualTo(-1304));
        That(Max3(984359, -20395, -103), Is.EqualTo(984359));
        That(Deg2Rad(360.0), Is.EqualTo(2*Math.PI).Within(1e-5));
        That(Rad2Deg(2*Math.PI), Is.EqualTo(360.0).Within(1e-5));
    }
}