
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
                for ( int j = i + 1; j < phrase.Length; j++)
                {
                    if (phrase[i] != phrase[j])
                    {
                        newString += phrase[i];
                    }
                }
                
                    
                   
               
                
            }
            Console.WriteLine(newString);

        }
        

    }
}
