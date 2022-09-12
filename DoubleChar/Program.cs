namespace SaberTestString
{
    public class Test
    {
        public static void Main()
        {
            string? phrase = Console.ReadLine();
            string newString = string.Empty;

            for (int i = 0; i < phrase.Length - 1; i++)
            {
                
                    if (phrase[i] != phrase[i + 1])
                    {
                        newString += phrase[i];
                    } 
            }
            Console.WriteLine(newString);

        }
    }
}
