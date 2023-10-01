public class Program
{
    static void Main(string[] args)
    {
        string result = Compare(3,3);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    public static string Compare(int A, int B)
    {
        if (A > B)
        {
            return "A büyüktür B";
        } else if (B > A) {
            return "B büyüktür A";
        } else
        {
            return "A B'ye eşittir.";
        }
       
    }
    



}