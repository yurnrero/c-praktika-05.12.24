namespace c__praktika_05._12._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBits(4)); // 1
            Console.WriteLine(CountBits(10)); // 2
            Console.WriteLine(CountBits(32)); // 1

            Console.WriteLine(Persistence(39)); // 3
            Console.WriteLine(Persistence(9)); // 0
            Console.WriteLine(Persistence(999)); // 4

            Console.WriteLine(DigitalRoot(16)); // 7
            Console.WriteLine(DigitalRoot(942)); // 6
        }

        static int CountBits(int num)
        {
            string binary = Convert.ToString(num, 2); 
            int count = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count++;
                }
            }

            return count;
        }

        
        static int Persistence(int num)
        {
            int steps = 0;

            while (num >= 10)
            {
                int product = 1;
                while (num > 0)
                {
                    product *= num % 10; 
                    num /= 10; 
                }
                num = product; 
                steps++;
            }

            return steps;
        }

        
        static int DigitalRoot(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10; 
                    num /= 10; 
                }
                num = sum; 
            }

            return num;
        }
    }

}

