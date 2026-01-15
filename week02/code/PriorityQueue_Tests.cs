using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with distinct priorities and remove them one by one.
    // Expected Result: Items are dequeued in order of their priorities (highest to lowest).
    // Defect(s) Found: None initially. Test Failed. Expected: Item3 Actual: returned Item2.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 10);
        priorityQueue.Enqueue("Item2", 20);
        priorityQueue.Enqueue("Item3", 15);

        Assert.AreEqual("Item2", priorityQueue.Dequeue()); // Highest priority
        Assert.AreEqual("Item3", priorityQueue.Dequeue()); // Next highest priority
        Assert.AreEqual("Item1", priorityQueue.Dequeue()); // Lowest priority
    }

    [TestMethod]
    // Scenario: Add items with the same priority and ensure FIFO behavior.
    // Expected Result: Items are dequeued in the same order they were enqueued.
    // Defect(s) Found: None initially. Test Failed: Expected: Item1 Actual: Item2.
    public void TestPriorityQueue_2()
    {
        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Item1", 10);
        priorityQueue2.Enqueue("Item2", 10);
        priorityQueue2.Enqueue("Item3", 10);

        Assert.AreEqual("Item1", priorityQueue2.Dequeue()); // FIFO for same priority
        Assert.AreEqual("Item2", priorityQueue2.Dequeue());
        Assert.AreEqual("Item3", priorityQueue2.Dequeue());
    }

    [TestMethod]
    // Scenario: Multiple items share the highest priority while lower priority items are also present.
    // Expected Result: The tied highest-priority items are dequeued in FIFO order before lower priorities.
    // Defect(s) Found: None initially. Test Failed. Expected: High2 Actual: High1.
    public void TestPriorityQueue_TieForHighestPriority_FIFO()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High1", 10);
        priorityQueue.Enqueue("Mid", 5);
        priorityQueue.Enqueue("High2", 10);

        Assert.AreEqual("High1", priorityQueue.Dequeue()); // FIFO among highest ties
        Assert.AreEqual("High2", priorityQueue.Dequeue());
        Assert.AreEqual("Mid", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }
}