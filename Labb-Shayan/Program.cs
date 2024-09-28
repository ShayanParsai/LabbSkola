namespace Labb_Shayan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "29535123p48723487597645723645"; // We will send this hardcoded string, but the code can take any similar strings.

            Console.Write("Original string: ");
            Console.Write(input);

            LabbMath labbMath = new LabbMath();
            labbMath.FindAndPrintValidSubstrings(input); // Search for valid substrings and print them
            labbMath.AddTheTotalOfTheValidSubStrings(); // Sum the valid ones and print out the result
        }
    }
}
