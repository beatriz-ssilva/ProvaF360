public class Questao5
class Program
{
    static void Main(string[] args)
    {
        string input = "Beatriz";

        string result = InvertStringWithSpaces(input);

        Console.WriteLine(result);
    }

    static string InvertStringWithSpaces(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string inverted = "";
        foreach (char c in charArray)
        {
            inverted += c;
            if (IsVowel(c))
            {
                inverted += " ";
            }
        }
        return inverted;
    }

    static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return Array.IndexOf(vowels, c) != -1;
    }
}