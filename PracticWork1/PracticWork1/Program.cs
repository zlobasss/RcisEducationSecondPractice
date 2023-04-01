
namespace PracticWork1
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            string jew = Console.ReadLine()!;
            string stone = Console.ReadLine()!;
            int count = 0;
            for (int i = 0; i < stone.Length; ++i)
            {
                for (int j = 0; j < jew.Length; ++j)
                {
                    if (jew[j] == stone[i])
                    {
                        ++count;
                    }
                }
            }
            Console.WriteLine(count);
        }
        
        static bool NextSet(int[] digits, int length, int index)
        {
            for (int i = index - 1; i >= 0; --i)
            {
                if (digits[i] < length - index + i)
                {
                    ++digits[i];
                    for (int j = i + 1; j < index; ++j)
                    {
                        digits[j] = digits[j - 1] + 1;
                    }
                    return true;
                }
            }
            return false;
        }

        static bool IsUnnessary(List<int[]> result, int[] array, int target)
        {
            foreach (int[] value in result)
            {
                for (int i = 0; i < value.Length; ++i)
                {
                    if (i == value.Length - 1 && value[i] == array[i])
                    {
                        return true;
                    }
                    if (value[i] == array[i])
                    {
                        continue;
                    }
                    break;
                }
            }
            return array.Sum() != target;
        }
        
        static void Task2()
        {
            Console.Write("candidates = ");
            string[] candidatesString = Console.ReadLine()!.Split(",");
            Console.Write("target = ");
            int target = Convert.ToInt32(Console.ReadLine());
            
            int[] candidates = new int [candidatesString.Length];
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < candidatesString.Length; ++i)
            {
                try
                {
                    candidates[i] = Convert.ToInt32(candidatesString[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Вы ввели не целочисленное число!!! {candidatesString[i]}");
                }
            }
            Array.Sort(candidates);
            
            for (int i = 1; i <= candidates.Length; ++i)
            {
                int[] digits = new int[i];
                for (int j = 0; j < i; ++j)
                {
                    digits[j] = j;
                }
                do
                {
                    int[] combs = new int[i];
                    for (int j = 0; j < digits.Length; ++j)
                    {
                        combs[j] = candidates[digits[j]];
                    }
                    
                    if (!IsUnnessary(result, combs, target))
                    {
                        result.Add(combs);
                    }
                } while (NextSet(digits, candidates.Length, i));
            }

            for (int i = 0; i < result.Count; ++i)
            {
                Console.WriteLine($"{string.Join(" + ", result[i])} = {target}");
            }
        }

        static bool IsHaveRepet(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; ++i)
            {
                for (int j = i + 1; j < nums.Count; ++j)
                {
                    if (nums[i] == nums[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Task3()
        {
            string[] numsStr = Console.ReadLine()!.Split(",");
            List<int> nums = new List<int>();
            for (int i = 0; i < numsStr.Length; ++i)
            {
                try
                {
                    nums.Add(Convert.ToInt32(numsStr[i]));
                }
                catch (SystemException)
                {
                    Console.WriteLine("Вы ввели не целочисленное число!!! ");
                }
            }
            Console.WriteLine(IsHaveRepet(nums));
        }
    }
}