namespace FindTheDiffInStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Please enter first string");
            String a = Console.ReadLine();

            Console.WriteLine("Please enter second string with one character different than first");

            String b = Console.ReadLine();

            char m = FindTheDifference(a, b);

            Console.WriteLine("The new character in second string is " + m);

        }
        public static char FindTheDifference(string s, string t)
        {
            for (int i = 0; i < s.Length; i++)
            {

                char x = s[i];
                for (int j = 0; j < t.Length; j++)
                {
                    if (x.Equals(t[j]))
                    {
                        t = t.Remove(j, 1);
                        //Console.WriteLine(t);

                    }
                }
            }
            char y = t[0];
            return y;

        }
    }
}
