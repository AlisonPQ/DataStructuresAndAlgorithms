internal class Program
{
    private static void Main(string[] args)
    {
        string str = ;
        Console.WriteLine(reverse("Hello! I am Alison."));
    }

    static string reverse(string str) {
      string[] result = new string[str.Length];
      int index = 0;
      for (int i = str.Length -1; i >= 0; i-- ) {
        result[index] = str[i].ToString();
        index++;
      }
      return String.Join("", result);
    }
}
