public static class TakingTurns
{
    public static void Test()
    {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        Console.WriteLine(players);    // This can be un-commented out for debug help
        while (players.Length > 0)
            players.GetNextPerson();
        // Defect(s) Found: Each player is printed out for each availbele turn before a new/next player is printed
        // instead of printing the names of players in the queue once then the next player and so on till
        // a player's turns are exhausted.
        // The Enqueue method adds new persons to the front (index 0) of the personQueue list instead of at the
        // back (last index + 1) of the list.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++)
        {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found: A player is printed until his turn is exhausted  or when the for loop that
        // calls the GetNextPerson() method has run five times before the next player/turn is printed. 


        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++)
        {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: A player's turn is exhausted before before the next player is printed. Also, 
        // Adding a player with 0 turns only enqueues the player once; so player's added with 0 turns are printed once instead
        // of infinity or the number of times indicated by the loop.
        // I got the 'No one in the queue' error even when there is a player with infinity turns in the queue.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++)
        {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: Player with infinity (-3) turns is only enqueued/printed once, also players are not printed in turns by each player's
        // is printed until his turns are exhausted before the next player is printed.

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found: No defect was found as the proper error message of 'No one in the queue' was displayed
        // indicating that the queue is empty.
    }
}






