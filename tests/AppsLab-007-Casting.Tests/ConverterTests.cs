//namespace AppsLab_007_Casting.Tests;

//public class ConverterTests
//{
//    private Converter converter;

//    [SetUp]
//    public void Setup()
//    {
//        converter = new Converter();
//    }

//    [Test]
//    public void IntToDouble_Given7_ShouldReturn7Point0()
//    {
//        var result = converter.IntToDouble(7);
//        Assert.That(result, Is.EqualTo(7.0), "IntToDouble(7) should return 7.0");
//    }

//    [Test]
//    public void DoubleToInt_Given7Point8_ShouldReturn7()
//    {
//        var result = converter.DoubleToInt(7.8);
//        Assert.That(result, Is.EqualTo(7), "DoubleToInt(7.8) should return 7");
//    }

//    [Test]
//    public void StringToDouble_Given7Point8AsString_ShouldReturn7Point8()
//    {
//        var result = converter.StringToDouble("7.8");
//        Assert.That(result, Is.EqualTo(7.8), "StringToDouble(\"7.8\") should return 7.8");
//    }

//    [Test]
//    public void DoubleToString_Given7Point8_ShouldReturn7Point8AsString()
//    {
//        var result = converter.DoubleToString(7.8);
//        Assert.That(result, Is.EqualTo("7.8"), "DoubleToString(7.8) should return \"7.8\"");
//    }

//    [Test]
//    public void IntToString_Given7_ShouldReturn7AsString()
//    {
//        var result = converter.IntToString(7);
//        Assert.That(result, Is.EqualTo("7"), "IntToString(7) should return \"7\"");
//    }

//    [Test]
//    public void StringToBool_GivenTrueAsString_ShouldReturnTrue()
//    {
//        var result = converter.StringToBool("true");
//        Assert.That(result, Is.True, "StringToBool(\"true\") should return true");
//    }

//    [Test]
//    public void BoolToString_GivenTrue_ShouldReturnTrueAsString()
//    {
//        var result = converter.BoolToString(true);
//        Assert.That(result, Is.EqualTo("True"), "BoolToString(true) should return \"True\"");
//    }

//    [Test]
//    public void BoolToString_GivenFalse_ShouldReturnFalseAsString()
//    {
//        var result = converter.BoolToString(false);
//        Assert.That(result, Is.EqualTo("False"), "BoolToString(false) should return \"False\"");
//    }
//}
