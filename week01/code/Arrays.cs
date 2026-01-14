public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Initialize an array to store the multiples
        // The array size should be equal to 'length'
        double[] multiples = new double[length];

        
        // Step 2: Use the loop to generate each multiple
        // Looping 'length' times, each time calculating a new multiple
        for (int i = 0; i < multiples.Length; i++)
        {
            // Calculate the multiple by multiplying 'startingNumber' by (i + 1)
            multiples[i] = number * (i + 1);
            // Example: If startingNumber is 3 and i is 0, this gives 3 * 1 = 3
            // If i is 1, this gives 3 * 2 = 6, and so on.
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Calculate the split point
        // This is where I will divide the  list into two parts
        int splitPoint = data.Count - amount;

        // Step 2: Get the two slices
        // Slice 1 - is the last 'amount' elements that will be moved to the front
        List<int> rotatedPart = data.GetRange(splitPoint, amount);
        // Slice 2 - is the remaining elements that will be moved to the back
        List<int> remainingPart = data.GetRange(0, splitPoint);

        // Step 3: before combining the list, I will clear the original list
        data.Clear(); // remove all elements from the original list
        data.AddRange(rotatedPart); // add the rotated part first
        data.AddRange(remainingPart); // add the remaining part last

        // Now the list is rotated to the right by 'amount' places
        /*
        * List<int> data = new List<int> {7, 8, 9, 1, 2, 3, 4, 5, 6};
        * int amount = 5;
        *
        * int splitPoint =  (data.Count - amount) → 9 - 5 = 4.
        * 
        * rotatedPart = data.GetRange(4, 5); → {5, 6, 7, 8, 9}
        * remainingPart = data.GetRange(0, 4); → {1, 2, 3, 4}
        *
        * data =  {5, 6, 7, 8, 9} + {1, 2, 3, 4} → {5, 6, 7, 8, 9, 1, 2, 3, 4}
        */
    }
}
