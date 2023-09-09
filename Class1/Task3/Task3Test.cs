using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1).Within(1e-5));
        That(F(105.5), Is.EqualTo(-1).Within(1e-5));
        That(F(-104.2), Is.EqualTo(0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(4000), Is.EqualTo(366));
        That(NumberOfDays(1904), Is.EqualTo(366));
        That(NumberOfDays(1900), Is.EqualTo(365));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('С', 1, 2), Is.EqualTo('З'));
        That(Rotate2('В', 2, -1), Is.EqualTo('Ю'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(20), Is.EqualTo("двадцать"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}