public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue and add the following priotity items: Sleep (1), Clean(4), Read (7), Code(6)
        // Expected Result: [Sleep (Pri:1), Clean (Pri:4), Read (Pri:7), Code (Pri:6)]
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Sleep", 1);
        priorityQueue.Enqueue("Clean", 4);
        priorityQueue.Enqueue("Read", 7);
        priorityQueue.Enqueue("Code", 6);

        Console.WriteLine(priorityQueue);

        // Defect(s) Found: The result shows that items are enqueued properly to the back of the queue,
        // therefore, no defects were found.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create 3 queues and add the following priority items to each queue,
        // to the first queue, add: Sleep (1), Clean(4), Read (7), Code(6)
        // to the second queue, add: Sleep (-1), Clean(-4), Read (1), Code(2)
        // to the third queue, add: Sleep (107), Clean(141), Read (52), Code(101)
        // Expected Result: Read, Code, Clean
        Console.WriteLine("Test 2");

        var priorityQueue1 = new PriorityQueue();
        priorityQueue1.Enqueue("Sleep", 1);
        priorityQueue1.Enqueue("Clean", 4);
        priorityQueue1.Enqueue("Read", 7);
        priorityQueue1.Enqueue("Code", 6);

        Console.WriteLine(priorityQueue1.Dequeue());

        var priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Sleep", -1);
        priorityQueue2.Enqueue("Clean", -4);
        priorityQueue2.Enqueue("Read", 1);
        priorityQueue2.Enqueue("Code", 2);

        Console.WriteLine(priorityQueue2.Dequeue());

        var priorityQueue3 = new PriorityQueue();
        priorityQueue3.Enqueue("Sleep", 107);
        priorityQueue3.Enqueue("Clean", 141);
        priorityQueue3.Enqueue("Read", 52);
        priorityQueue3.Enqueue("Code", 101);

        Console.WriteLine(priorityQueue3.Dequeue());

        // Defect(s) Found: The dequeue function does not always return the item with the hightest priority.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create 3 queues with multiple values having the same priority, thus,
        // to the first queue, add: Sleep (5), Clean(4), Read (5), Code(2)
        // to the second queue, add: Sleep (4), Clean(3), Pray (6), Code(1), Read (6)
        // to the third queue, add: Sleep (1), Clean(2), Read (11), Code(11), Wash (8), Iron (11)
        // Expected Result: Sleep, Pray, Read
        Console.WriteLine("Test 3");

        priorityQueue1 = new PriorityQueue();
        priorityQueue1.Enqueue("Sleep", 5);
        priorityQueue1.Enqueue("Clean", 4);
        priorityQueue1.Enqueue("Read", 5);
        priorityQueue1.Enqueue("Code", 2);

        Console.WriteLine(priorityQueue1.Dequeue());

        priorityQueue2 = new PriorityQueue();
        priorityQueue2.Enqueue("Sleep", 4);
        priorityQueue2.Enqueue("Clean", 3);
        priorityQueue2.Enqueue("Pray", 6);
        priorityQueue2.Enqueue("Code", 6);
        priorityQueue2.Enqueue("Read", 6);

        Console.WriteLine(priorityQueue2.Dequeue());

        priorityQueue3 = new PriorityQueue();
        priorityQueue3.Enqueue("Sleep", 1);
        priorityQueue3.Enqueue("Clean", 2);
        priorityQueue3.Enqueue("Read", 11);
        priorityQueue3.Enqueue("Code", 11);
        priorityQueue3.Enqueue("Wash", 8);
        priorityQueue3.Enqueue("Iron", 11);

        Console.WriteLine(priorityQueue3.Dequeue());

        // Defect(s) Found: The item with the highest priority and closest to the front of the queue is not returned.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Create an empty queue and call the dequeue method on it.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 4");

        priorityQueue = new PriorityQueue();

        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: The item with the highest priority and closest to the front of the queue is not returned.
    }
}