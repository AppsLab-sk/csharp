namespace AppsLab_017_List.Tests;

/// <summary>
/// This class contains tests for the <see cref="Queue"/> class.
/// </summary>
[TestFixture]
public class QueueTests
{
    /// <summary>
    /// This test checks that the <see cref="Queue.Enqueue(string)"/> method adds the item to the end of the queue.
    /// </summary>
    [Test]
    public void Enqueue_AddNewItem_ItemAddedToEnd()
    {
        // Arrange
        var queue = new Queue();

        // Act
        queue.Enqueue("First");
        queue.Enqueue("Second");

        // Assert
        Assert.That(queue.Dequeue(), Is.EqualTo("First"), "The item was not added correctly.");
    }

    /// <summary>
    /// This test checks that the <see cref="Queue.Dequeue()"/> method removes the item from the start of the queue.
    /// </summary>
    [Test]
    public void Dequeue_RemoveItem_ItemRemovedFromStart()
    {
        // Arrange
        var queue = new Queue();
        queue.Enqueue("First");
        queue.Enqueue("Second");

        // Act
        var removedItem = queue.Dequeue();
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(removedItem, Is.EqualTo("First"), "The item was not removed correctly.");
            Assert.That(queue.Dequeue(), Is.EqualTo("Second"), "The item was not dequeued correctly.");
        });
    }
}
