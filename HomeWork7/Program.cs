namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayApplication();
        }

        static void DisplayApplication()
        {
            while (true)
            {
                Console.Write("Enter Text For Capitalize Words (for close app enter x): ");
                Console.Write("\nText: ");
                string text = Console.ReadLine();
                if (text.ToLower() == "x")
                {
                    break;
                }

                string result = CustomReplace(text);
                Console.WriteLine(result);
            }
        }

        static string CustomReplace(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            text = text.Trim();

            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                    break;
                }
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '.')
                {
                    int j = i + 1;
                    while (j < chars.Length && chars[j] == ' ') j++;

                    if (j < chars.Length && char.IsLetter(chars[j]))
                    {
                        chars[j] = char.ToUpper(chars[j]);
                    }
                }
            }

            return new string(chars);
        }
    }
}