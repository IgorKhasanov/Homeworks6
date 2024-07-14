// Задайте произвольную строку. Выясните, является ли она палиндромом.
    string input = "кабак";
    bool isPalindrome = IsPalindrome(input);
    Console.WriteLine(isPalindrome ? "да" : "нет");

bool IsPalindrome(string str)
{
    string normalized = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    return normalized.SequenceEqual(normalized.Reverse());
}