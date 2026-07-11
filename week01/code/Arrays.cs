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
        // Step 1: Create an array with the requested length.
        
        // Step 2: Loop through each position in the array.
        
        // Step 3: Calculate the multiple for the current position.
        
        // Since array indices start at 0, use (index + 1).
        
        // Step 4: Store the calculated multiple in the array.
        
        // Step 5: Return the completed array.
        double[] arr = new double[length];
    
        for (var x = 0; x < length; x++)
        {
            arr[x] = (x + 1) * number;

        }

        return arr; // replace this return statement with your own

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
        // If the list is empty, there is nothing to rotate.
    if (data.Count == 0) return;

    // Normalize amount so it is within the list size.
    // For example, rotating 7 times in a list of 5 is the same as rotating 2 times.
    amount = amount % data.Count;

    // Create a new array with the same size as the list.
    int[] newArr = new int[data.Count];

    // Move each item to its new position.
    // The item at index x moves to index (x + amount).
    // The modulo wraps it back to the beginning if it goes past the end.
    for (int x = 0; x < data.Count; x++)
    {
        newArr[(x + amount) % data.Count] = data[x];
    }

    // Copy the rotated values back into the original list.
    for (int x = 0; x < data.Count; x++)
    {
        data[x] = newArr[x];
    }
    }
}
