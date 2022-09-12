namespace SaberTestString
{
    public class Test
    {
        public static void Main()
        {
            string? phrase = Console.ReadLine();
            string newString = string.Empty;

            char prev = phrase[0];
            newString += phrase[0];

            for (int i = 0; i < phrase.Length ; i++)
            {
                
                    if (phrase[i] != prev)
                    {
                        prev = phrase[i];
                        newString += phrase[i];
                    }
                    
            }
            Console.WriteLine(newString);

        }
    }
}
