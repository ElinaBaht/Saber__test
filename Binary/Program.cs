
using System;
using System.Linq;

namespace SaberTestBinary
{
    public class Test
    {
        public static void FindBinaryNumber(int num)
        {
            int code = 0;
            List<int> numbers = new List<int>();
            List<int> numbersNeg = new List<int>();
            if (num == 0)
            {
                Console.WriteLine(num);
            }
            if (num > 0)
            {
                while (num > 0)
                {
                    code = num % 2;
                    num /= 2;
                    numbers.Add(code);
                }

            }
            if (num < 0)
            {
                num *= -1;
                while (num > 0)
                {
                    code = num % 2;
                    num /= 2;
                    numbersNeg.Add(code);
                }

            }
            if (numbers.Count == 0)
            {
                BinaryNumberNeg(numbersNeg);
            }
            else
            {
                BinaryNumber(numbers);
            }

        }


        public static void BinaryNumber(List<int> binaryCode)
        {
            int[] rightBinaryCode = new int[binaryCode.Count];


            for (int i = rightBinaryCode.Length - 1; i >= 0; i--)
            {
                rightBinaryCode[rightBinaryCode.Length - 1 - i] = binaryCode[i];
            }
            Console.WriteLine(string.Join<int>("", rightBinaryCode));

        }
        public static void BinaryNumberNeg(List<int> binaryCode)
        {
            int[] rightBinaryCode = new int[binaryCode.Count];
            

            for (int i = rightBinaryCode.Length - 1; i >= 0; i--)
            {
                rightBinaryCode[rightBinaryCode.Length - 1 - i] = binaryCode[i];
            }

            if (rightBinaryCode.Length % 8 != 0)
            {
                int count = rightBinaryCode.Length % 8;
                int zero = 8 - count;
                int[] arr = new int[zero];
                List<int> numbers = new List<int>(rightBinaryCode);
                List<int> zeros = new List<int>(arr);
                zeros.AddRange(numbers);
                for (var i = 0; i < zeros.Count; i++)
                {
                    if (zeros[i] == 0)
                    {
                        zeros[i] = 1;
                    }
                    else
                    {
                        zeros[i] = 0;
                    }
                }
                for (int i = zeros.Count - 1; i >= 0; i--)
                {
                    if (zeros[i] == 0)
                    {
                        zeros[i] = 1;
                    }
                    else
                    {

                        while (zeros[i] != 0)
                        {
                            zeros[i] = 0;
                            i--;
                        }
                        if (zeros[i] == 0)
                        {
                            zeros[i] = 1;
                        }

                    }
                    break;

                }
                rightBinaryCode = zeros.ToArray();
            }else if (rightBinaryCode.Length % 8 == 0)
            {
  
                List<int> zeros = new List<int>(rightBinaryCode);

                for (var i = 0; i < zeros.Count; i++)
                {
                    if (zeros[i] == 0)
                    {
                        zeros[i] = 1;
                    }
                    else
                    {
                        zeros[i] = 0;
                    }
                }
                for (int i = zeros.Count - 1; i >= 0; i--)
                {
                    if (zeros[i] == 0)
                    {
                        zeros[i] = 1;
                    }
                    else
                    {

                        while (zeros[i] != 0)
                        {
                            zeros[i] = 0;
                            i--;
                        }
                        if (zeros[i] == 0)
                        {
                            zeros[i] = 1;
                        }

                    }
                    break;
                }
                rightBinaryCode = zeros.ToArray();
            }
            Console.WriteLine(string.Join<int>("", rightBinaryCode));  
        }
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            FindBinaryNumber(num);
        }
    }
    
}
