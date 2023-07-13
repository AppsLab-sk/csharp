namespace AppsLab_018_Methods.Tests;

public class ExerciseTests
{
    private Exercise _exercise;

    [SetUp]
    public void Setup()
    {
        _exercise = new Exercise();
    }

    [TestCase(1, "1")]
    [TestCase(2, "2")]
    [TestCase(3, "Fizz")]
    [TestCase(4, "4")]
    [TestCase(5, "Buzz")]
    [TestCase(6, "Fizz")]
    [TestCase(7, "7")]
    [TestCase(8, "8")]
    [TestCase(9, "Fizz")]
    [TestCase(10, "Buzz")]
    [TestCase(11, "11")]
    [TestCase(12, "Fizz")]
    [TestCase(13, "13")]
    [TestCase(14, "14")]
    [TestCase(15, "FizzBuzz")]
    [TestCase(16, "16")]
    [TestCase(30, "FizzBuzz")]
    [TestCase(33, "Fizz")]
    [TestCase(100, "Buzz")]
    public void FizzBuzz_Input_ReturnsExpectedResult(int number, string expectedResult)
    {
        string result = _exercise.FizzBuzz(number);

        Assert.That(result, Is.EqualTo(expectedResult), $"The FizzBuzz of {number} should be {expectedResult}");
    }
}
