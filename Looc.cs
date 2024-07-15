class Program
{
    static void Main(string[] args)
    {
        Result successResult = Result.Success();
        Console.WriteLine(successResult.Message); // Output: Operation succeeded.

        Result failureResult = Result.Failure("An error occurred.");
        Console.WriteLine(failureResult.Message); // Output: An error occurred.
    }
}
