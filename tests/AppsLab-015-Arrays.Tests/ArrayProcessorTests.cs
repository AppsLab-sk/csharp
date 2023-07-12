namespace AppsLab_015_Arrays.Tests;

/// <summary>
/// Class ArrayProcessorTests provides unit tests for class ArrayProcessor.
/// </summary>
[TestFixture]
public class ArrayProcessorTests
{
    private ArrayProcessor _arrayProcessor;

    /// <summary>
    /// Initializes the ArrayProcessor instance before each test.
    /// </summary>
    [SetUp]
    public void SetUp()
    {
        _arrayProcessor = new ArrayProcessor();
    }

    /// <summary>
    /// Tests the GetFirstElement method.
    /// </summary>
    [Test]
    public void GetFirstElement_GivenEmptyArray_ReturnsZero()
    {
        int[] numbers = new int[0];
        Assert.That(_arrayProcessor.GetFirstElement(numbers), Is.EqualTo(0), "The first element of an empty array should be 0.");
    }

    /// <summary>
    /// Tests the GetFirstElement method.
    /// </summary>
    [Test]
    public void GetFirstElement_GivenArray_ReturnsFirstElement()
    {
        int[] numbers = new int[] { 5, 3, 7 };
        Assert.That(_arrayProcessor.GetFirstElement(numbers), Is.EqualTo(5), "Incorrect first element returned.");
    }

    /// <summary>
    /// Tests the GetLastElement method.
    /// </summary>
    [Test]
    public void GetLastElement_GivenEmptyArray_ReturnsZero()
    {
        int[] numbers = new int[0];
        Assert.That(_arrayProcessor.GetLastElement(numbers), Is.EqualTo(0), "The last element of an empty array should be 0.");
    }

    /// <summary>
    /// Tests the GetLastElement method.
    /// </summary>
    [Test]
    public void GetLastElement_GivenArray_ReturnsLastElement()
    {
        int[] numbers = new int[] { 5, 3, 7 };
        Assert.That(_arrayProcessor.GetLastElement(numbers), Is.EqualTo(7), "Incorrect last element returned.");
    }

    /// <summary>
    /// Tests the GetElementAtPosition method.
    /// </summary>
    [Test]
    public void GetElementAtPosition_GivenPositionOutOfRange_ReturnsZero()
    {
        int[] numbers = new int[] { 5, 3, 7 };
        Assert.That(_arrayProcessor.GetElementAtPosition(numbers, 3), Is.EqualTo(0), "A position outside of the array range should return 0.");
    }

    /// <summary>
    /// Tests the GetElementAtPosition method.
    /// </summary>
    [Test]
    public void GetElementAtPosition_GivenValidPosition_ReturnsElement()
    {
        int[] numbers = new int[] { 5, 3, 7 };
        Assert.That(_arrayProcessor.GetElementAtPosition(numbers, 1), Is.EqualTo(3), "Incorrect element returned for given position.");
    }

    /// <summary>
    /// Tests the GetLength method.
    /// </summary>
    [Test]
    public void GetLength_GivenArray_ReturnsLength()
    {
        int[] numbers = new int[] { 5, 3, 7 };
        Assert.That(_arrayProcessor.GetLength(numbers), Is.EqualTo(3), "Incorrect length returned for given array.");
    }
}
